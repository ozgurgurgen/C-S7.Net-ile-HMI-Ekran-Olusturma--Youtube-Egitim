using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Plc plcim;
        public Form1()
        {
            InitializeComponent();
        }

        private void connect_Click(object sender, EventArgs e)
        {
            CpuType cpu = new CpuType();
            string ipAdres = ipAddress.Text;
            string comboBoxSecim = plcTipi.SelectedItem.ToString();
            short rack = Convert.ToInt16(RackCombo.SelectedItem);
            short slot = Convert.ToInt16(SlotCombo.SelectedItem);

            if (comboBoxSecim.Equals("S71500"))
            {
                cpu = CpuType.S71500;
            }
            else if (comboBoxSecim.Equals("S71200"))
            {
                cpu = CpuType.S71200;
            }
            plcim = new Plc(cpu, ipAdres, rack, slot);
            plcim.Open();
            if(plcim.IsConnected)
            {
                durumLabel.Text = "PLC'ye Bağlantı Başarılı";
                durumLabel.ForeColor = Color.Green;
            }
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ipAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void plc_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void plcTipi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VeriCek_Click(object sender, EventArgs e)
        {
            DBX00.Text = (plcim.Read(DataType.DataBlock, 4, 0, VarType.Bit, 1)).ToString();
        }

        private void disconnect_Click(object sender, EventArgs e)
        {
            plcim.Close();
        }
    }
}