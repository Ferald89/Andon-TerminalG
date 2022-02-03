using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// System
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Net.Http;



namespace Andon_TerminalG
{
    public partial class start : Form
    {
        // Local variables
        private ApiStats api = new ApiStats();
        private FinsCommunication fins = new FinsCommunication();
        private Boolean online = false;
        private Byte[] memory = { 0x82, 0x80 };
        Dictionary<string, ushort> dataPLC = new Dictionary<string, ushort>();
        private Boolean commandStarted = false;

        public start()
        {
            // Constructor function of Form 
            InitializeComponent();

            //Defaut Setting
            Form_IP.Text = "192.168.24.110";
            Form_DmToRead.Value = 20;
            Form_DMPiezasOK.Value = 21;
            Form_DMPiezasNG.Value = 22;
            Form_DMTurno.Value = 23;
            Form_memorySelect.SelectedIndex = 0;
            timer1.Interval = 300; // 300 ms de refresco
            dataPLC.Add("CommandOK", 0x00);
            dataPLC.Add("PartsOK", 0x00);
            dataPLC.Add("PartsNG", 0x00);
            dataPLC.Add("Turno", 0x00);

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private async void handleButton()
        {
            Dictionary<string, short> dmMemory = new Dictionary<string, short>();
            dmMemory.Add("CommandOK", (short)Form_DmToRead.Value);
            dmMemory.Add("PartsOK", (short)Form_DMPiezasOK.Value);
            dmMemory.Add("PartsNG", (short)Form_DMPiezasNG.Value);
            dmMemory.Add("Target", (short)Form_DMTurno.Value);



            ushort[] words = new ushort[dmMemory.Count];

            foreach(KeyValuePair< string, short> data in dmMemory)
            {
                try
                {
                    dataPLC[data.Key] = await fins.sendData(
                        data.Value, 
                        Form_IP.Text,
                        memory[Form_memorySelect.SelectedIndex]
                        );
                }
                catch (Exception ex)
                {
                    Form_message.Text = ex.ToString();
                }
            }
            Form_OCommd.Text = dataPLC["CommandOK"].ToString();
            Form_OPartsOK.Text = dataPLC["PartsOK"].ToString();
            Form_OPartsNG.Text = dataPLC["PartsNG"].ToString();
            Form_OTurno.Text = dataPLC["Target"].ToString();

            if (dataPLC["CommandOK"] == 0x01 && commandStarted == false)
            {
                commandStarted = true;
                handleCommand();
            }
            if(dataPLC["CommandOK"] == 0x00)
            {
                commandStarted = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            handleButton();
        }     

        private async void handleCommand()
        {
            string result = await api.PatchStat(
                "220111018", 
                (int)dataPLC["PartsOK"], 
                (int)dataPLC["PartsNG"],
                (int)dataPLC["Target"]
                );
            Form_message.Text = result;
        }
        private void handleErase()
        {
            Form_OCommd.Text = "";
            Form_OPartsOK.Text = "";
            Form_OPartsNG.Text = "";
            Form_OTurno.Text = "";
        }

        private void Form_Start_Click(object sender, EventArgs e)
        {


            if (!online)
            {
                timer1.Enabled = true;
                timer1.Start();
                online = true;
                Form_Start.BackColor = Color.Green;
                Form_Start.Text = "online";
            }
            else
            {
                timer1.Enabled = false;
                timer1.Stop();
                online = false;
                Form_Start.BackColor= Color.Red;
                Form_Start.Text = "offline";
                handleErase();
            }
        }

    }

    public class ApiStats {
        /*Api Class
         *Class in charge to handle request to App
         */

        public HttpClient httpClient = new HttpClient();
        public string BASE_URL = "http://localhost:8000/api/stats/";

        public ApiStats()
        {

        }

        public async Task<string> GetStat()
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(BASE_URL + "220111018/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
            catch (Exception fault)
            {
                return fault.ToString();
            }
        }

        public async Task<string> PostStat()
        {
            string myJson = "{" +
                              "\"id_abstract\": 22011301," +
                              " \"current_model\": null, " +
                              "\"current_product\": null}";
            StringContent content = new StringContent(myJson, Encoding.UTF8, "application/json");
            try
            {
                HttpResponseMessage response = await httpClient.PostAsync(BASE_URL, content);
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
            catch (Exception fault)
            {
                return fault.ToString();
            }
        }

        public async Task<string> PatchStat(string id, int PartsOK, int PartsNG, int Target)
        {
            string myJson =
                            "{" +
                              "\"PartsOK\":" + PartsOK + "," +
                              "\"PartsNG\":" + PartsNG + "," +
                              "\"PartsTarget\":" + Target + "," +
                              " \"current_model\": null, " +
                              "\"current_product\": null}";
            StringContent content = new StringContent(myJson, Encoding.UTF8, "application/json");
            HttpMethod method = new HttpMethod("PATCH");
            HttpRequestMessage request = new HttpRequestMessage(method, BASE_URL + id + "/");
            request.Content = content;
            try
            {
                HttpResponseMessage response = await httpClient.SendAsync(request);
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
            catch (Exception fault)
            {
                return fault.ToString();
            }
        }

    }

    public class FinsCommunication {
        public Byte[] HEADER =
        {
            0x80, // ICF
            0x00, // RSV
            0x02, // GCT
            0x00, // DNA
            0x00, // DA1 (100 from ip)
            0x00, // DA2
            0x00, // SNA
            0x22, // SA1 (236 from PLC actual)
            0x00, // SA2
            0x00, // SID
            0x01,
            0x01, // Command Code
            0x82, // D Memory
            0x00,
        };

        public Byte[] COUNT = { 0x00, 0x01 };

        public FinsCommunication()
        {

        }
        public async Task<ushort> sendData(short beginer, string ip, Byte memory)
        {

            // Create array Byte from beginer
            Byte[] begginerByte  = BitConverter.GetBytes(beginer);
            HEADER[12] = memory; // Memory located in byte 12

            // Create message
            Byte[] message = new Byte[HEADER.Length + begginerByte.Length + COUNT.Length];
            Buffer.BlockCopy(HEADER, 0, message, 0, HEADER.Length);
            Buffer.BlockCopy(begginerByte, 0, message, HEADER.Length, begginerByte.Length);
            Buffer.BlockCopy(COUNT, 0, message, HEADER.Length + begginerByte.Length, COUNT.Length);

            //Console.WriteLine(BitConverter.ToString(message));
            try
            {
                // UDP client async
                UdpClient udpClient = new UdpClient(300);
                // Connect udp client an send message
                udpClient.Connect(ip, 9600);
                udpClient.Send(message, message.Length);
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 60240);
                var receiveBytes =  await udpClient.ReceiveAsync();
                Byte[] buffer = receiveBytes.Buffer;
                Byte[] response = new Byte[2];
                response[0] = buffer[buffer.Length - 1];
                response[1] = buffer[buffer.Length - 2];
                ushort responses = BitConverter.ToUInt16(response, 0);
                udpClient.Close();
                return responses;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return 0;
            }
        }

    }

}

