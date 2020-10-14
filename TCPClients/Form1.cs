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
using System.IO;

namespace TCPClients
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btGui_Click(object sender, EventArgs e)
        {
            TcpClient client = new TcpClient();
            client.Connect("127.0.0.1", 6868);
            Stream str = client.GetStream();
            String msg = tbNguoiGui.Text + "~" + tbNguoiNhan.Text + "~" + tbTinNhan.Text;
            byte[] buffer = Encoding.UTF8.GetBytes(msg);
            str.Write(buffer, 0, buffer.Length);
            byte[] result = new byte[1024];
            int count = str.Read(result, 0, 1024);
            client.Close();
            tbLichSu.Text += "Client: " + tbTinNhan.Text;
            tbLichSu.Text += "Server: " + Encoding.UTF8.GetString(result).Trim();
        }
    }
}
