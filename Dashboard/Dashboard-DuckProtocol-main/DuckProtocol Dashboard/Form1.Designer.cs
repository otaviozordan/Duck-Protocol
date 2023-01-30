
namespace Monitor_CAN
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btConectar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btEnviar = new System.Windows.Forms.Button();
            this.textBoxEnviarId = new System.Windows.Forms.TextBox();
            this.textBoxPrompt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timerCOM = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnExcluirRec = new System.Windows.Forms.Button();
            this.OnOff1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.OnOff2 = new System.Windows.Forms.Button();
            this.OnOff4 = new System.Windows.Forms.Button();
            this.OnOff3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Indicador1 = new System.Windows.Forms.Button();
            this.Indicador3 = new System.Windows.Forms.Button();
            this.Indicador2 = new System.Windows.Forms.Button();
            this.Indicador4 = new System.Windows.Forms.Button();
            this.comboBoxId2 = new System.Windows.Forms.ComboBox();
            this.comboBoxId3 = new System.Windows.Forms.ComboBox();
            this.comboBoxId4 = new System.Windows.Forms.ComboBox();
            this.comboBoxId1 = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.comboBoxIdInd2 = new System.Windows.Forms.ComboBox();
            this.comboBoxIdInd1 = new System.Windows.Forms.ComboBox();
            this.comboBoxIdInd3 = new System.Windows.Forms.ComboBox();
            this.comboBoxIdInd4 = new System.Windows.Forms.ComboBox();
            this.textBoxEnviarEnd = new System.Windows.Forms.TextBox();
            this.textBoxEnviarData = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btConectar
            // 
            this.btConectar.Location = new System.Drawing.Point(27, 124);
            this.btConectar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btConectar.Name = "btConectar";
            this.btConectar.Size = new System.Drawing.Size(117, 32);
            this.btConectar.TabIndex = 0;
            this.btConectar.Text = "Conectar";
            this.btConectar.UseVisualStyleBackColor = true;
            this.btConectar.Click += new System.EventHandler(this.btConectar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(167, 126);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(245, 28);
            this.comboBox1.TabIndex = 2;
            // 
            // btEnviar
            // 
            this.btEnviar.Location = new System.Drawing.Point(27, 169);
            this.btEnviar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEnviar.Name = "btEnviar";
            this.btEnviar.Size = new System.Drawing.Size(117, 32);
            this.btEnviar.TabIndex = 3;
            this.btEnviar.Text = "Enviar";
            this.btEnviar.UseVisualStyleBackColor = true;
            this.btEnviar.Click += new System.EventHandler(this.btEnviar_Click);
            // 
            // textBoxEnviarId
            // 
            this.textBoxEnviarId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEnviarId.Location = new System.Drawing.Point(167, 174);
            this.textBoxEnviarId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEnviarId.Name = "textBoxEnviarId";
            this.textBoxEnviarId.Size = new System.Drawing.Size(83, 27);
            this.textBoxEnviarId.TabIndex = 4;
            this.textBoxEnviarId.Tag = "";
            // 
            // textBoxPrompt
            // 
            this.textBoxPrompt.Location = new System.Drawing.Point(631, 133);
            this.textBoxPrompt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPrompt.Multiline = true;
            this.textBoxPrompt.Name = "textBoxPrompt";
            this.textBoxPrompt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPrompt.Size = new System.Drawing.Size(465, 84);
            this.textBoxPrompt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(533, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Prompt:";
            // 
            // timerCOM
            // 
            this.timerCOM.Interval = 1000;
            this.timerCOM.Tick += new System.EventHandler(this.timerCOM_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(416, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 39);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dashboard RS458";
            // 
            // btnExcluirRec
            // 
            this.btnExcluirRec.Location = new System.Drawing.Point(524, 183);
            this.btnExcluirRec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcluirRec.Name = "btnExcluirRec";
            this.btnExcluirRec.Size = new System.Drawing.Size(89, 34);
            this.btnExcluirRec.TabIndex = 14;
            this.btnExcluirRec.Text = "Limpar";
            this.btnExcluirRec.UseVisualStyleBackColor = true;
            this.btnExcluirRec.Click += new System.EventHandler(this.btnExcluirRec_Click);
            // 
            // OnOff1
            // 
            this.OnOff1.BackColor = System.Drawing.Color.Honeydew;
            this.OnOff1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnOff1.Location = new System.Drawing.Point(67, 349);
            this.OnOff1.Name = "OnOff1";
            this.OnOff1.Size = new System.Drawing.Size(173, 94);
            this.OnOff1.TabIndex = 15;
            this.OnOff1.Text = "Acionar";
            this.OnOff1.UseVisualStyleBackColor = false;
            this.OnOff1.Click += new System.EventHandler(this.OnOff1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 32);
            this.label4.TabIndex = 16;
            this.label4.Text = "Comandos:";
            // 
            // OnOff2
            // 
            this.OnOff2.BackColor = System.Drawing.Color.Honeydew;
            this.OnOff2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnOff2.Location = new System.Drawing.Point(317, 349);
            this.OnOff2.Name = "OnOff2";
            this.OnOff2.Size = new System.Drawing.Size(179, 94);
            this.OnOff2.TabIndex = 18;
            this.OnOff2.Text = "Acionar";
            this.OnOff2.UseVisualStyleBackColor = false;
            this.OnOff2.Click += new System.EventHandler(this.OnOff2_Click);
            // 
            // OnOff4
            // 
            this.OnOff4.BackColor = System.Drawing.Color.Honeydew;
            this.OnOff4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnOff4.Location = new System.Drawing.Point(317, 546);
            this.OnOff4.Name = "OnOff4";
            this.OnOff4.Size = new System.Drawing.Size(173, 94);
            this.OnOff4.TabIndex = 22;
            this.OnOff4.Text = "Acionar";
            this.OnOff4.UseVisualStyleBackColor = false;
            this.OnOff4.Click += new System.EventHandler(this.OnOff4_Click);
            // 
            // OnOff3
            // 
            this.OnOff3.BackColor = System.Drawing.Color.Honeydew;
            this.OnOff3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnOff3.Location = new System.Drawing.Point(67, 546);
            this.OnOff3.Name = "OnOff3";
            this.OnOff3.Size = new System.Drawing.Size(179, 94);
            this.OnOff3.TabIndex = 20;
            this.OnOff3.Text = "Acionar";
            this.OnOff3.UseVisualStyleBackColor = false;
            this.OnOff3.Click += new System.EventHandler(this.OnOff3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Meu Id: 0x0f";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(187, 661);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 32);
            this.label6.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(571, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 32);
            this.label7.TabIndex = 27;
            this.label7.Text = "Indicadores:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(604, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 28;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Indicador1
            // 
            this.Indicador1.BackColor = System.Drawing.Color.Honeydew;
            this.Indicador1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Indicador1.Location = new System.Drawing.Point(604, 349);
            this.Indicador1.Name = "Indicador1";
            this.Indicador1.Size = new System.Drawing.Size(179, 94);
            this.Indicador1.TabIndex = 29;
            this.Indicador1.Text = "Indicador\r\n";
            this.Indicador1.UseVisualStyleBackColor = false;
            // 
            // Indicador3
            // 
            this.Indicador3.BackColor = System.Drawing.Color.Honeydew;
            this.Indicador3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Indicador3.Location = new System.Drawing.Point(604, 546);
            this.Indicador3.Name = "Indicador3";
            this.Indicador3.Size = new System.Drawing.Size(179, 94);
            this.Indicador3.TabIndex = 30;
            this.Indicador3.Text = "Indicador";
            this.Indicador3.UseVisualStyleBackColor = false;
            // 
            // Indicador2
            // 
            this.Indicador2.BackColor = System.Drawing.Color.Honeydew;
            this.Indicador2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Indicador2.Location = new System.Drawing.Point(868, 346);
            this.Indicador2.Name = "Indicador2";
            this.Indicador2.Size = new System.Drawing.Size(179, 94);
            this.Indicador2.TabIndex = 31;
            this.Indicador2.Text = "Indicador";
            this.Indicador2.UseVisualStyleBackColor = false;
            // 
            // Indicador4
            // 
            this.Indicador4.BackColor = System.Drawing.Color.Honeydew;
            this.Indicador4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Indicador4.Location = new System.Drawing.Point(868, 546);
            this.Indicador4.Name = "Indicador4";
            this.Indicador4.Size = new System.Drawing.Size(179, 94);
            this.Indicador4.TabIndex = 32;
            this.Indicador4.Text = "Indicador";
            this.Indicador4.UseVisualStyleBackColor = false;
            // 
            // comboBoxId2
            // 
            this.comboBoxId2.FormattingEnabled = true;
            this.comboBoxId2.Items.AddRange(new object[] {
            "0x10",
            "0x11",
            "0x12",
            "0x13",
            "0x14",
            "0x15",
            "0x16",
            "0x17",
            "0x18",
            "0x19",
            "0x1a",
            "0x1b",
            "0x1c",
            "0x1d",
            "0x1e",
            "0x1f"});
            this.comboBoxId2.Location = new System.Drawing.Point(341, 449);
            this.comboBoxId2.Name = "comboBoxId2";
            this.comboBoxId2.Size = new System.Drawing.Size(121, 24);
            this.comboBoxId2.TabIndex = 33;
            // 
            // comboBoxId3
            // 
            this.comboBoxId3.FormattingEnabled = true;
            this.comboBoxId3.Items.AddRange(new object[] {
            "0x10",
            "0x11",
            "0x12",
            "0x13",
            "0x14",
            "0x15",
            "0x16",
            "0x17",
            "0x18",
            "0x19",
            "0x1a",
            "0x1b",
            "0x1c",
            "0x1d",
            "0x1e",
            "0x1f"});
            this.comboBoxId3.Location = new System.Drawing.Point(93, 646);
            this.comboBoxId3.Name = "comboBoxId3";
            this.comboBoxId3.Size = new System.Drawing.Size(121, 24);
            this.comboBoxId3.TabIndex = 34;
            // 
            // comboBoxId4
            // 
            this.comboBoxId4.FormattingEnabled = true;
            this.comboBoxId4.Items.AddRange(new object[] {
            "0x10",
            "0x11",
            "0x12",
            "0x13",
            "0x14",
            "0x15",
            "0x16",
            "0x17",
            "0x18",
            "0x19",
            "0x1a",
            "0x1b",
            "0x1c",
            "0x1d",
            "0x1e",
            "0x1f"});
            this.comboBoxId4.Location = new System.Drawing.Point(341, 646);
            this.comboBoxId4.Name = "comboBoxId4";
            this.comboBoxId4.Size = new System.Drawing.Size(121, 24);
            this.comboBoxId4.TabIndex = 35;
            // 
            // comboBoxId1
            // 
            this.comboBoxId1.FormattingEnabled = true;
            this.comboBoxId1.Items.AddRange(new object[] {
            "0x10",
            "0x11",
            "0x12",
            "0x13",
            "0x14",
            "0x15",
            "0x16",
            "0x17",
            "0x18",
            "0x19",
            "0x1a",
            "0x1b",
            "0x1c",
            "0x1d",
            "0x1e",
            "0x1f"});
            this.comboBoxId1.Location = new System.Drawing.Point(93, 449);
            this.comboBoxId1.Name = "comboBoxId1";
            this.comboBoxId1.Size = new System.Drawing.Size(121, 24);
            this.comboBoxId1.TabIndex = 36;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(921, 290);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(126, 41);
            this.btnRefresh.TabIndex = 37;
            this.btnRefresh.Text = "Ativar Busca";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // comboBoxIdInd2
            // 
            this.comboBoxIdInd2.FormattingEnabled = true;
            this.comboBoxIdInd2.Items.AddRange(new object[] {
            "0x10",
            "0x11",
            "0x12",
            "0x13",
            "0x14",
            "0x15",
            "0x16",
            "0x17",
            "0x18",
            "0x19",
            "0x1a",
            "0x1b",
            "0x1c",
            "0x1d",
            "0x1e",
            "0x1f"});
            this.comboBoxIdInd2.Location = new System.Drawing.Point(895, 449);
            this.comboBoxIdInd2.Name = "comboBoxIdInd2";
            this.comboBoxIdInd2.Size = new System.Drawing.Size(121, 24);
            this.comboBoxIdInd2.TabIndex = 38;
            // 
            // comboBoxIdInd1
            // 
            this.comboBoxIdInd1.FormattingEnabled = true;
            this.comboBoxIdInd1.Items.AddRange(new object[] {
            "0x10",
            "0x11",
            "0x12",
            "0x13",
            "0x14",
            "0x15",
            "0x16",
            "0x17",
            "0x18",
            "0x19",
            "0x1a",
            "0x1b",
            "0x1c",
            "0x1d",
            "0x1e",
            "0x1f"});
            this.comboBoxIdInd1.Location = new System.Drawing.Point(630, 449);
            this.comboBoxIdInd1.Name = "comboBoxIdInd1";
            this.comboBoxIdInd1.Size = new System.Drawing.Size(121, 24);
            this.comboBoxIdInd1.TabIndex = 39;
            // 
            // comboBoxIdInd3
            // 
            this.comboBoxIdInd3.FormattingEnabled = true;
            this.comboBoxIdInd3.Items.AddRange(new object[] {
            "0x10",
            "0x11",
            "0x12",
            "0x13",
            "0x14",
            "0x15",
            "0x16",
            "0x17",
            "0x18",
            "0x19",
            "0x1a",
            "0x1b",
            "0x1c",
            "0x1d",
            "0x1e",
            "0x1f"});
            this.comboBoxIdInd3.Location = new System.Drawing.Point(630, 646);
            this.comboBoxIdInd3.Name = "comboBoxIdInd3";
            this.comboBoxIdInd3.Size = new System.Drawing.Size(121, 24);
            this.comboBoxIdInd3.TabIndex = 40;
            // 
            // comboBoxIdInd4
            // 
            this.comboBoxIdInd4.FormattingEnabled = true;
            this.comboBoxIdInd4.Items.AddRange(new object[] {
            "0x10",
            "0x11",
            "0x12",
            "0x13",
            "0x14",
            "0x15",
            "0x16",
            "0x17",
            "0x18",
            "0x19",
            "0x1a",
            "0x1b",
            "0x1c",
            "0x1d",
            "0x1e",
            "0x1f"});
            this.comboBoxIdInd4.Location = new System.Drawing.Point(895, 646);
            this.comboBoxIdInd4.Name = "comboBoxIdInd4";
            this.comboBoxIdInd4.Size = new System.Drawing.Size(121, 24);
            this.comboBoxIdInd4.TabIndex = 41;
            // 
            // textBoxEnviarEnd
            // 
            this.textBoxEnviarEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEnviarEnd.Location = new System.Drawing.Point(256, 174);
            this.textBoxEnviarEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEnviarEnd.Name = "textBoxEnviarEnd";
            this.textBoxEnviarEnd.Size = new System.Drawing.Size(83, 27);
            this.textBoxEnviarEnd.TabIndex = 42;
            // 
            // textBoxEnviarData
            // 
            this.textBoxEnviarData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEnviarData.Location = new System.Drawing.Point(345, 174);
            this.textBoxEnviarData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEnviarData.Name = "textBoxEnviarData";
            this.textBoxEnviarData.Size = new System.Drawing.Size(83, 27);
            this.textBoxEnviarData.TabIndex = 43;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Monitor_CAN.Properties.Resources.CEDEN_logo;
            this.pictureBox1.Location = new System.Drawing.Point(749, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 736);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxEnviarData);
            this.Controls.Add(this.textBoxEnviarEnd);
            this.Controls.Add(this.comboBoxIdInd4);
            this.Controls.Add(this.comboBoxIdInd3);
            this.Controls.Add(this.comboBoxIdInd1);
            this.Controls.Add(this.comboBoxIdInd2);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.comboBoxId1);
            this.Controls.Add(this.comboBoxId4);
            this.Controls.Add(this.comboBoxId3);
            this.Controls.Add(this.comboBoxId2);
            this.Controls.Add(this.Indicador4);
            this.Controls.Add(this.Indicador2);
            this.Controls.Add(this.Indicador3);
            this.Controls.Add(this.Indicador1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OnOff4);
            this.Controls.Add(this.OnOff3);
            this.Controls.Add(this.OnOff2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OnOff1);
            this.Controls.Add(this.btnExcluirRec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPrompt);
            this.Controls.Add(this.textBoxEnviarId);
            this.Controls.Add(this.btEnviar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btConectar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConectar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btEnviar;
        private System.Windows.Forms.TextBox textBoxEnviarId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerCOM;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBoxPrompt;
        private System.Windows.Forms.Button btnExcluirRec;
        private System.Windows.Forms.Button OnOff1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button OnOff2;
        private System.Windows.Forms.Button OnOff4;
        private System.Windows.Forms.Button OnOff3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Indicador1;
        private System.Windows.Forms.Button Indicador3;
        private System.Windows.Forms.Button Indicador2;
        private System.Windows.Forms.Button Indicador4;
        private System.Windows.Forms.ComboBox comboBoxId2;
        private System.Windows.Forms.ComboBox comboBoxId3;
        private System.Windows.Forms.ComboBox comboBoxId4;
        private System.Windows.Forms.ComboBox comboBoxId1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox comboBoxIdInd2;
        private System.Windows.Forms.ComboBox comboBoxIdInd1;
        private System.Windows.Forms.ComboBox comboBoxIdInd3;
        private System.Windows.Forms.ComboBox comboBoxIdInd4;
        private System.Windows.Forms.TextBox textBoxEnviarEnd;
        private System.Windows.Forms.TextBox textBoxEnviarData;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

