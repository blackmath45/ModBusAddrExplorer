using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// Développé par Mathieu DABERT le 10/06/2019

namespace ModBusAddrExplorer
{
    public partial class MainForm : Form
    {
        //public enum DataType { BOOL, INT, DINT, UDINT, WORD, DWORD, FLOAT, STRING };
        public enum DataType { INT, DINT, UDINT, WORD, DWORD, FLOAT };

        private EasyModbus.ModbusClient modbusClient;

        int[] HoldingRegisters = new int[65536];

        int iCurrentAddress = 0;

        public MainForm()
        {
            InitializeComponent();

            modbusClient = new EasyModbus.ModbusClient();
            modbusClient.ConnectedChanged += new EasyModbus.ModbusClient.ConnectedChangedHandler(UpdateConnectedChanged);

            CB_DataType.DataSource = Enum.GetValues(typeof(DataType));

            RefreshGUI();
        }

        private void UpdateConnectedChanged(object sender)
        {
            RefreshGUI();
        }

        private void BTN_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                if (modbusClient.Connected)
                    modbusClient.Disconnect();

                modbusClient.IPAddress = TB_IP.Text;
                modbusClient.Port = 502;
                modbusClient.SerialPort = null;
                modbusClient.ConnectionTimeout = 10000;

                modbusClient.Connect();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Unable to connect to Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshGUI();
        }

        private void BTN_Disconnect_Click(object sender, EventArgs e)
        {
            modbusClient.Disconnect();
        }

        private void BTN_Scan_Start_Click(object sender, EventArgs e)
        {
            if (iCurrentAddress < NUD_MinAddr.Value)
                iCurrentAddress = (int)NUD_MinAddr.Value;

            LB_Data.Items.Clear();

            TMR_Read.Enabled = true;
            RefreshGUI();
        }

        private void BTN_Scan_Stop_Click(object sender, EventArgs e)
        {
            TMR_Read.Enabled = false;
            RefreshGUI();
        }

        private void RefreshGUI()
        {
            if (modbusClient.Connected)
            {
                BTN_Connect.Enabled = false;
                BTN_Disconnect.Enabled = true;
                txtConnectedStatus.Text = "Connected to Server";
                txtConnectedStatus.BackColor = Color.Green;

                if (TMR_Read.Enabled == false)
                {
                    BTN_Scan_Start.Enabled = true;
                    BTN_Scan_Stop.Enabled = false;
                }
                else
                {
                    BTN_Scan_Start.Enabled = false;
                    BTN_Scan_Stop.Enabled = true;
                }
            }
            else
            {
                BTN_Connect.Enabled = true;
                BTN_Disconnect.Enabled = false;
                txtConnectedStatus.Text = "Not Connected to Server";
                txtConnectedStatus.BackColor = Color.Red;

                BTN_Scan_Start.Enabled = false;
                BTN_Scan_Stop.Enabled = false;
            }

            L_Scan_Current.Text = iCurrentAddress.ToString() + " / " + (NUD_MaxAddr.Value - NUD_MinAddr.Value).ToString();
        }

        private void TMR_Read_Tick(object sender, EventArgs e)
        {
            int[] tmp;

            if (modbusClient.Connected)
            {
                try
                {
                    tmp = modbusClient.ReadHoldingRegisters(iCurrentAddress, 1);
                    LB_Data.Items.Add(iCurrentAddress + " => " + tmp[0]);
                    HoldingRegisters[iCurrentAddress] = tmp[0];
                }
                catch (Exception ex)
                {

                }

                iCurrentAddress++;

                if (iCurrentAddress > NUD_MaxAddr.Value)
                {
                    iCurrentAddress = (int)NUD_MaxAddr.Value;
                    TMR_Read.Enabled = false;
                }

            }
            else
            {
                TMR_Read.Enabled = false;
            }

            RefreshGUI();
        }

        private void BTN_Analyse_Click(object sender, EventArgs e)
        {
            DataType type;
            Enum.TryParse<DataType>(CB_DataType.SelectedValue.ToString(), out type);
            string tmp;

            LB_Analyse.Items.Clear();

            for (int i = 0; i < 65535; i++)
            {
                tmp = string.Empty;

                switch (type)
                {
                    case DataType.WORD: // 1 registre
                        tmp = (unchecked((uint)HoldingRegisters[i])).ToString();//serverResponse[tmp.Value.Adresse - iMinAddress])).ToString();
                        break;

                    case DataType.INT: // 1 registre
                        tmp = HoldingRegisters[i].ToString();// serverResponse[tmp.Value.Adresse - iMinAddress].ToString();
                        break;

                    case DataType.FLOAT: // 2 registre
                        if ((i + 1) > 65535)
                            break;
                        int[] tmpregistrefloat = { HoldingRegisters[i], HoldingRegisters[i + 1] };
                        tmp = EasyModbus.ModbusClient.ConvertRegistersToFloat(tmpregistrefloat).ToString();
                        break;

                    case DataType.DINT: // 2 registre
                        if ((i + 1) > 65535)
                            break;
                        int[] tmpregistredint = { HoldingRegisters[i], HoldingRegisters[i + 1] };
                        tmp = EasyModbus.ModbusClient.ConvertRegistersToInt(tmpregistredint).ToString();
                        break;

                    case DataType.UDINT: // 2 registre
                        if ((i + 1) > 65535)
                            break;
                        int[] tmpregistreudint = { HoldingRegisters[i], HoldingRegisters[i + 1] };
                        int tmpudint = EasyModbus.ModbusClient.ConvertRegistersToInt(tmpregistreudint);
                        tmp = (unchecked((uint)tmpudint)).ToString();
                        break;

                    case DataType.DWORD: // 2 registre
                        if ((i + 1) > 65535)
                            break;
                        int[] tmpregistredword = { HoldingRegisters[i], HoldingRegisters[i + 1] };
                        int tmpdword = EasyModbus.ModbusClient.ConvertRegistersToInt(tmpregistredword);
                        tmp = (unchecked((uint)tmpdword)).ToString();
                        break;
                }

                if (TB_Analyse_Search.Text.Length == 0)
                {
                    LB_Analyse.Items.Add(i + " => " + tmp);
                }
                else
                {
                    if (tmp.Contains(TB_Analyse_Search.Text))
                        LB_Analyse.Items.Add(i + " => " + tmp);
                }

            }

        }

        private void NUD_MinAddr_ValueChanged(object sender, EventArgs e)
        {
            RefreshGUI();
        }

        private void NUD_MaxAddr_ValueChanged(object sender, EventArgs e)
        {
            RefreshGUI();
        }

        private void BTN_Scan_Reset_Click(object sender, EventArgs e)
        {
            iCurrentAddress = (int)NUD_MinAddr.Value;
            RefreshGUI();
        }
    }
}
