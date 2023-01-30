using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using System.IO.Ports;  // necessário para ter acesso as portas

namespace Monitor_CAN
{
    public partial class Form1 : Form
    {
        byte[] frame = new byte[3];

        public Form1()
        {
            InitializeComponent();
            timerCOM.Enabled = true;

            comboBoxId1.Text = "0x10";
            comboBoxId2.Text = "0x10";
            comboBoxId3.Text = "0x10";
            comboBoxId4.Text = "0x10";
            comboBoxIdInd1.Text = "0x10";
            comboBoxIdInd2.Text = "0x10";
            comboBoxIdInd3.Text = "0x10";
            comboBoxIdInd4.Text = "0x10";
            textBoxEnviarId.Text = "0x10";
            textBoxEnviarEnd.Text = "0xb1";
            textBoxEnviarData.Text = "0x3d";
        }

        private void atualizaListaCOMs()
        {
            int i;
            bool quantDiferente;    //flag para sinalizar que a quantidade de portas mudou

            i = 0;
            quantDiferente = false;

            //se a quantidade de portas mudou
            if (comboBox1.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    if (comboBox1.Items[i++].Equals(s) == false)
                    {
                        quantDiferente = true;
                    }
                }
            }
            else
            {
                quantDiferente = true;
            }

            //Se não foi detectado diferença
            if (quantDiferente == false)
            {
                return;                     //retorna
            }

            //limpa comboBox
            comboBox1.Items.Clear();

            //adiciona todas as COM diponíveis na lista
            foreach (string s in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(s);
            }
            //seleciona a primeira posição da lista
            comboBox1.SelectedIndex = 0;
        }

        private void timerCOM_Tick(object sender, EventArgs e)
        {
            atualizaListaCOMs();
        }

        private void btConectar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                try
                {
                    serialPort1.PortName = comboBox1.Items[comboBox1.SelectedIndex].ToString();
                    serialPort1.BaudRate = 9600;
                    serialPort1.Parity = Parity.None;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.DataBits = 8;
                    serialPort1.RtsEnable = true;
                    serialPort1.DtrEnable = true;
                    serialPort1.Handshake = System.IO.Ports.Handshake.XOnXOff;
                    serialPort1.DataReceived += new SerialDataReceivedEventHandler(MyDataReceivedHandler);

                    //Tamanho do buffer e quando disparar DataReciverd
                    serialPort1.ReadBufferSize = 8000; //1000 bytes
                    serialPort1.ReceivedBytesThreshold = 5;
                    serialPort1.Open();
                    serialPort1.DiscardInBuffer();
                    serialPort1.DiscardOutBuffer();
                    frame[0] = 0x00; frame[1] = 0x00; frame[2] = 0x00;

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error ao abrir ou escrever na Porta Serial: " + ex.Message, "Error!");
                    return;

                }
                if (serialPort1.IsOpen)
                {
                    btConectar.Text = "Desconectar";
                    comboBox1.Enabled = false;

                }
            }
            else
            {

                try
                {
                    if (btnRefresh.Text == "Desativar Busca")
                    {
                        MessageBox.Show("Desative a busca primeiro.");
                        return;
                    }

                    
                    serialPort1.Close();
                    comboBox1.Enabled = true;
                    btConectar.Text = "Conectar";
                    textBoxPrompt.AppendText(Environment.NewLine + Environment.NewLine + "Porta " + serialPort1.PortName + " desconectada" );

                }
                catch
                {
                    return;
                }

            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen == true)  // se porta aberta 
                serialPort1.Close();            //fecha a porta
        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true) //Porta está aberta
            {
                byte id, end, data;
                id = pegarValorHexTextBox(textBoxEnviarId);
                end = pegarValorHexTextBox(textBoxEnviarEnd);
                data = pegarValorHexTextBox(textBoxEnviarData);
                enviarPayload(id, end, data);
            }
        }

        private void btnExcluirRec_Click(object sender, EventArgs e)
        {
            textBoxPrompt.Text = "";
        }

        private void OnOff1_Click(object sender, EventArgs e)
        {
            byte data = 0x3d; //Acionamento data 13
            if(OnOff1.Text == "Acionado")
            {
                OnOff1.Text = "Desacionado";
                OnOff1.BackColor = Color.Red;
                enviarPayload(pegarValorHexCombo(comboBoxId1), 0xb0, data);
            }
            else //Primeiro Acionamento
            {
                OnOff1.Text = "Acionado";
                OnOff1.BackColor = Color.LimeGreen;
                enviarPayload(pegarValorHexCombo(comboBoxId1), 0xb1, data);
            }
        }

        private void OnOff2_Click(object sender, EventArgs e)
        {
            byte data = 0x3c; //Acionamento data 12
            if (OnOff2.Text == "Acionado")
            {
                OnOff2.Text = "Desacionado";
                OnOff2.BackColor = Color.Red;
                enviarPayload(pegarValorHexCombo(comboBoxId2), 0xb0, data);
            }
            else //Primeiro Acionamento
            {
                OnOff2.Text = "Acionado";
                OnOff2.BackColor = Color.LimeGreen;
                enviarPayload(pegarValorHexCombo(comboBoxId2), 0xb1, data);
            }
        }

        private void OnOff3_Click(object sender, EventArgs e)
        {
            byte data = 0x3b; //Acionamento data 11
            if (OnOff3.Text == "Acionado")
            {
                OnOff3.Text = "Desacionado";
                OnOff3.BackColor = Color.Red;
                enviarPayload(pegarValorHexCombo(comboBoxId3), 0xb0, data);
            }
            else //Primeiro Acionamento
            {
                OnOff3.Text = "Acionado";
                OnOff3.BackColor = Color.LimeGreen;
                enviarPayload(pegarValorHexCombo(comboBoxId3), 0xb1, data);
            }
        }

        private void OnOff4_Click(object sender, EventArgs e)
        {

            byte data = 0x3a; //Acionamento data 10
            if (OnOff4.Text == "Acionado")
            {
                OnOff4.Text = "Desacionado";
                OnOff4.BackColor = Color.Red;
                enviarPayload(pegarValorHexCombo(comboBoxId4), 0xb0, data);
            }
            else //Primeiro Acionamento
            {
                OnOff4.Text = "Acionado";
                OnOff4.BackColor = Color.LimeGreen;
                enviarPayload(pegarValorHexCombo(comboBoxId4), 0xb1, data);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (btnRefresh.Text == "Ativar Busca" && serialPort1.IsOpen)
            {
                btnRefresh.BackColor = Color.LimeGreen;
                btnRefresh.Text = "Desativar Busca";
                solicitarValores();
            }
            else
            {
                btnRefresh.BackColor = Color.White;
                btnRefresh.Text = "Ativar Busca";
                if (!serialPort1.IsOpen)
                {
                   MessageBox.Show("Porta COM fechada.");
                }
            }
        }

        private async void solicitarValores()
        {
            while (true)
            {
                int i;

                const int timeResponse = 10; //Ciclos de espera para resposta. Aumentar se o slave não estiver respondendo em tempo (Recomendado 10 para evitar perda de pacotes) 
                const int noBugTime = 7; //Quanto maior, menor será a frequencia de verificação dos 4 slaves (50 padrão, minimo 5 para evitar OverFlow no buffer)

                i = 0;
                //Dispara request
                frame[0] = 0x0; frame[1] = 0x0; frame[2] = 0x0;
                byte idS1 = pegarValorHexCombo(comboBoxIdInd1);
                enviarPayload(idS1, 0xb2, 0x39);
                //Espera resposta
                while (i < timeResponse)
                {
                    if (frame[0] == 0x0f)
                    {
                        atualizarIndicador(Indicador1);
                        await Task.Delay(noBugTime);
                        break;
                    }
                    await Task.Delay(1);
                    i++;
                }
                if(frame[0] == 0x0)
                {
                    Indicador1.Text = "Não recebido";
                    Indicador1.BackColor = Color.Cyan;
                }

                frame[0] = 0x0; frame[1] = 0x0; frame[2] = 0x0;

                i = 0;
                //Dispara request
                frame[0] = 0x0; frame[1] = 0x0; frame[2] = 0x0;
                byte idS2 = pegarValorHexCombo(comboBoxIdInd2);
                enviarPayload(idS2, 0xb2, 0x38);
                //Espera resposta
                while (i < timeResponse)
                {
                    if (frame[0] == 0x0f)
                    {
                        atualizarIndicador(Indicador2);
                        await Task.Delay(noBugTime);
                        break;
                    }
                    await Task.Delay(1);
                    i++;
                }
                if (frame[0] == 0x0)
                {
                    Indicador2.Text = "Não recebido";
                    Indicador2.BackColor = Color.Cyan;
                }

                frame[0] = 0x0; frame[1] = 0x0; frame[2] = 0x0;

                i = 0;
                //Dispara request
                frame[0] = 0x0; frame[1] = 0x0; frame[2] = 0x0;
                byte idS3 = pegarValorHexCombo(comboBoxIdInd3);
                enviarPayload(idS3, 0xb2, 0x37);
                //Espera resposta
                while (i < timeResponse)
                {
                    if (frame[0] == 0x0f)
                    {
                        atualizarIndicador(Indicador3);
                        await Task.Delay(noBugTime);
                        break;
                    }
                    await Task.Delay(1);
                    i++;
                }
                if (frame[0] == 0x00)
                {
                    Indicador3.Text = "Não recebido";
                    Indicador3.BackColor = Color.Cyan;
                }

                frame[0] = 0x0; frame[1] = 0x0; frame[2] = 0x0;

                i = 0;
                //Dispara request
                frame[0] = 0x0; frame[1] = 0x0; frame[2] = 0x0;
                byte idS4 = pegarValorHexCombo(comboBoxIdInd4);
                enviarPayload(idS4, 0xb2, 0x36);
                //Espera resposta
                while (i < timeResponse)
                {
                    if (frame[0] == 0x0f)
                    {
                        atualizarIndicador(Indicador4);
                        await Task.Delay(noBugTime);
                        break;
                    }
                    await Task.Delay(1);
                    i++;
                }
                if (frame[0] == 0x00)
                {
                    Indicador4.Text = "Não recebido";
                    Indicador4.BackColor = Color.Cyan;
                }

                frame[0] = 0x0; frame[1] = 0x0; frame[2] = 0x0;

                if (btnRefresh.Text != "Desativar Busca")
                {
                    break;
                }
            }
        }

        private void atualizarIndicador(Button indicador)
        {
            if (frame[1] == 0xb3)
            {
                if (frame[2] == 0x31)
                {
                    indicador.Text = "ON";
                    indicador.BackColor = Color.LimeGreen;
                }
                else if (frame[2] == 0x30)
                {
                    indicador.Text = "OFF";
                    indicador.BackColor = Color.Red;
                }
                else
                {
                    indicador.Text = "Indefinido";
                }
            }
        }

        public byte pegarValorHexCombo(ComboBox combo)
        {
            String hex = combo.Text;
            byte b = Convert.ToByte(hex, 16); // 15;
            return b;
        }

        public byte pegarValorHexTextBox(TextBox box)
        {
            String hex = box.Text;
            byte b = Convert.ToByte(hex, 16); // 15;
            return b;
        }

        private void enviarPayload(byte id, byte end, byte data)
        {
            byte[] payload = new byte[5];

            //Payload --> 0x02 + id + end + val + 0x03
            payload[0] = 0x02;
            payload[1] = id;
            payload[2] = end;
            payload[3] = data;
            payload[4] = 0x03;

            if (serialPort1.IsOpen == true && serialPort1.BytesToWrite == 0)
            {
                serialPort1.Write(payload, 0, 5);
                textBoxPrompt.AppendText(Environment.NewLine + "Enviado: " + payload[0].ToString("x") + " " + payload[1].ToString("x") + " " + payload[2].ToString("x") + " " + payload[3].ToString("x") + " " + payload[4].ToString("x"));
            }
        }

        void MyDataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            byte buffer;
            for (int i = 0; i < serialPort1.BytesToRead; i++)
            {
                buffer = (byte)serialPort1.ReadByte();

                if (buffer == 0x02)
                {
                    break;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                try
                {
                    buffer = (byte)serialPort1.ReadByte(); //Salva frame byte a byte
                }
                catch (System.IO.IOException msg)
                {
                    textBoxPrompt.AppendText(Environment.NewLine + "Erro: " + msg);
                    break;
                }

                if (buffer == 0x03)
                {
                    break;
                }

                frame[i] = buffer;

                if (buffer == 0x02)
                {
                    i = -1;
                }
            }

            this.Invoke(new EventHandler(tratarDados));
        }

        private void tratarDados(object s, EventArgs e)
        {
            if (frame.Length != 3)
            {
                textBoxPrompt.AppendText(Environment.NewLine + "Frame incompleto");
            }

            byte endFrame = (byte)serialPort1.ReadByte();
            if (endFrame != 0x03)
            {
                textBoxPrompt.AppendText(Environment.NewLine + "Endframe não encontrado: " + endFrame.ToString("x"));
            }
            textBoxPrompt.AppendText(Environment.NewLine + "Recebido: " + 0x02.ToString("x") + " " + frame[0].ToString("x") + " " + frame[1].ToString("x") + " " + frame[2].ToString("x") + " " + endFrame.ToString("x"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}