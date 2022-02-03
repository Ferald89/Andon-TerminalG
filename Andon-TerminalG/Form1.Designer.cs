namespace Andon_TerminalG
{
    partial class start
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Form_message = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Form_DmToRead = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.Form_OCommd = new System.Windows.Forms.TextBox();
            this.Form_OPartsOK = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Form_DMPiezasOK = new System.Windows.Forms.NumericUpDown();
            this.Form_OPartsNG = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Form_DMPiezasNG = new System.Windows.Forms.NumericUpDown();
            this.Form_OTurno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Form_DMTurno = new System.Windows.Forms.NumericUpDown();
            this.Form_Start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.Form_IP = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Form_memorySelect = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Form_DmToRead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Form_DMPiezasOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Form_DMPiezasNG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Form_DMTurno)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Form_message
            // 
            this.Form_message.Location = new System.Drawing.Point(527, 311);
            this.Form_message.Multiline = true;
            this.Form_message.Name = "Form_message";
            this.Form_message.Size = new System.Drawing.Size(223, 115);
            this.Form_message.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(524, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Log";
            // 
            // Form_DmToRead
            // 
            this.Form_DmToRead.Location = new System.Drawing.Point(160, 28);
            this.Form_DmToRead.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Form_DmToRead.Name = "Form_DmToRead";
            this.Form_DmToRead.Size = new System.Drawing.Size(90, 20);
            this.Form_DmToRead.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Comando de Guardar";
            // 
            // Form_OCommd
            // 
            this.Form_OCommd.Enabled = false;
            this.Form_OCommd.Location = new System.Drawing.Point(317, 28);
            this.Form_OCommd.Name = "Form_OCommd";
            this.Form_OCommd.Size = new System.Drawing.Size(121, 20);
            this.Form_OCommd.TabIndex = 14;
            // 
            // Form_OPartsOK
            // 
            this.Form_OPartsOK.Enabled = false;
            this.Form_OPartsOK.Location = new System.Drawing.Point(317, 53);
            this.Form_OPartsOK.Name = "Form_OPartsOK";
            this.Form_OPartsOK.Size = new System.Drawing.Size(121, 20);
            this.Form_OPartsOK.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Piezas OK";
            // 
            // Form_DMPiezasOK
            // 
            this.Form_DMPiezasOK.Location = new System.Drawing.Point(160, 53);
            this.Form_DMPiezasOK.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Form_DMPiezasOK.Name = "Form_DMPiezasOK";
            this.Form_DMPiezasOK.Size = new System.Drawing.Size(90, 20);
            this.Form_DMPiezasOK.TabIndex = 15;
            // 
            // Form_OPartsNG
            // 
            this.Form_OPartsNG.Enabled = false;
            this.Form_OPartsNG.Location = new System.Drawing.Point(317, 78);
            this.Form_OPartsNG.Name = "Form_OPartsNG";
            this.Form_OPartsNG.Size = new System.Drawing.Size(121, 20);
            this.Form_OPartsNG.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Piezas NG";
            // 
            // Form_DMPiezasNG
            // 
            this.Form_DMPiezasNG.Location = new System.Drawing.Point(160, 78);
            this.Form_DMPiezasNG.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Form_DMPiezasNG.Name = "Form_DMPiezasNG";
            this.Form_DMPiezasNG.Size = new System.Drawing.Size(90, 20);
            this.Form_DMPiezasNG.TabIndex = 18;
            // 
            // Form_OTurno
            // 
            this.Form_OTurno.Enabled = false;
            this.Form_OTurno.Location = new System.Drawing.Point(317, 103);
            this.Form_OTurno.Name = "Form_OTurno";
            this.Form_OTurno.Size = new System.Drawing.Size(121, 20);
            this.Form_OTurno.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Target";
            // 
            // Form_DMTurno
            // 
            this.Form_DMTurno.Location = new System.Drawing.Point(160, 103);
            this.Form_DMTurno.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Form_DMTurno.Name = "Form_DMTurno";
            this.Form_DMTurno.Size = new System.Drawing.Size(90, 20);
            this.Form_DMTurno.TabIndex = 21;
            // 
            // Form_Start
            // 
            this.Form_Start.BackColor = System.Drawing.Color.Red;
            this.Form_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Form_Start.Location = new System.Drawing.Point(555, 63);
            this.Form_Start.Name = "Form_Start";
            this.Form_Start.Size = new System.Drawing.Size(206, 62);
            this.Form_Start.TabIndex = 25;
            this.Form_Start.Text = "Offline";
            this.Form_Start.UseVisualStyleBackColor = false;
            this.Form_Start.Click += new System.EventHandler(this.Form_Start_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "IP Adress";
            // 
            // Form_IP
            // 
            this.Form_IP.Location = new System.Drawing.Point(18, 43);
            this.Form_IP.Name = "Form_IP";
            this.Form_IP.Size = new System.Drawing.Size(183, 20);
            this.Form_IP.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Form_DmToRead, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Form_DMPiezasOK, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Form_DMPiezasNG, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Form_OTurno, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.Form_DMTurno, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Form_OPartsNG, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.Form_OCommd, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Form_OPartsOK, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 311);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(473, 127);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Dirección";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 29;
            this.label10.Tag = "Nombre";
            this.label10.Text = "Nombre";
            // 
            // Form_memorySelect
            // 
            this.Form_memorySelect.BackColor = System.Drawing.Color.White;
            this.Form_memorySelect.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Form_memorySelect.FormattingEnabled = true;
            this.Form_memorySelect.Items.AddRange(new object[] {
            "DM",
            "CIO"});
            this.Form_memorySelect.Location = new System.Drawing.Point(230, 42);
            this.Form_memorySelect.Name = "Form_memorySelect";
            this.Form_memorySelect.Size = new System.Drawing.Size(90, 21);
            this.Form_memorySelect.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Device";
            // 
            // start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Form_memorySelect);
            this.Controls.Add(this.Form_Start);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Form_IP);
            this.Controls.Add(this.Form_message);
            this.Name = "start";
            this.Text = "Andon Deica";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Form_DmToRead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Form_DMPiezasOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Form_DMPiezasNG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Form_DMTurno)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Form_message;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Form_DmToRead;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Form_OCommd;
        private System.Windows.Forms.TextBox Form_OPartsOK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown Form_DMPiezasOK;
        private System.Windows.Forms.TextBox Form_OPartsNG;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown Form_DMPiezasNG;
        private System.Windows.Forms.TextBox Form_OTurno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown Form_DMTurno;
        private System.Windows.Forms.Button Form_Start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Form_IP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox Form_memorySelect;
        private System.Windows.Forms.Label label5;
    }
}

