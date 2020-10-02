using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace UDPClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btGui_Click(object sender, EventArgs e)
        {
            String ip = "127.0.0.1";
            int port = 6868;

            UdpClient client = new UdpClient();
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(ip), port);
            client.Connect(ep);

            String msg = tbNguoiGui.Text + "~" + tbNguoiNhan.Text + "~" + tbTinNhan.Text;
            client.Send(Encoding.UTF8.GetBytes(msg), msg.Length);

            byte[] buffer = client.Receive(ref ep);
            tbLichSu.Text += "\r\n" + Encoding.UTF8.GetString(buffer);
            tbTinNhan.Text = "";
            client.Close();
        }
    }
}
