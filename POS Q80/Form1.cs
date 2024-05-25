using System;
using System.IO.Ports;
using System.Transactions;
using POS_PC_v3;

namespace POS_Q80
{
    public partial class Form1 : Form
    {
        POS_PC_v3.Transaction.Connection connect = new POS_PC_v3.Transaction.Connection();
        Result retCode = new Result();

        public Form1()
        {
            InitializeComponent();
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            connect.CommunicationType = "TCP/IP";
            connect.POSPC_TCPCOMMU_SocketRecTimeout = 60000;
            connect.POS_PORTtcp = 1024;
            connect.POS_IP = "192.168.5.87";
        }

        private void sendDataBtn_Click(object sender, EventArgs e)
        {
            POS_PC_v3.Transaction TNX = new POS_PC_v3.Transaction(connect);

            MessageBox.Show("stage1");
            try
            {
                retCode = TNX.Debits_Goods_And_Service("", "20000", "88881", "1888", "17777");
            }
            catch (Exception)
            {
                MessageBox.Show("Transaction Failed");
            }

            MessageBox.Show(retCode.ReturnCode.ToString());
        }
    }
}