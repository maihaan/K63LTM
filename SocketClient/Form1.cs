using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Setting = SocketClient.Properties.Settings;
using System.Net;
using System.Net.Sockets;

namespace SocketClient
{
    public partial class Form1 : Form
    {
        Timer tm = new Timer();

        public Form1()
        {
            InitializeComponent();

            tm.Enabled = true;
            tm.Interval = 3000;
            tm.Tick += Tm_Tick;

            tm.Start();
        }

        private void Tm_Tick(object sender, EventArgs e)
        {
            // Bước 1
            String ip = "127.0.0.1";
            int port = 6868;

            // Bước 2
            String username = tbUsername.Text.Trim();
            String message = "?" + username;
            byte[] buffer = Encoding.UTF8.GetBytes(message);

            // Bước 3
            try
            {
                Socket sk = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                sk.Connect(ip, port);

                // Bước 4
                int sentByteCount = sk.Send(buffer);
                if (sentByteCount == buffer.Length)
                {
                    // Bước 5
                    byte[] receiveBuffer = new byte[1024];
                    int count = sk.Receive(receiveBuffer);
                    String receiveMessage = Encoding.UTF8.GetString(receiveBuffer, 0, count);

                    tbHistory.Text += "You: ?\r\n";
                    tbHistory.Text += "Status: " + receiveMessage + "\r\n";
                    tbHistory.ScrollToCaret();
                    // Bước 6
                    sk.Disconnect(false);
                    sk.Dispose();
                }
                else
                {
                    MessageBox.Show("Gửi lỗi, hãy thử lại");
                    btSend.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối đến máy chủ. Hãy thử lại!");
                btSend.Focus();
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Đọc username và history từ setting để nạp vào các control
            tbUsername.Text = Setting.Default.Username;
            tbHistory.Text = Setting.Default.History;
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào
            if(String.IsNullOrEmpty(tbUsername.Text))
            {
                MessageBox.Show("Bạn phải nhập Người gửi");
                tbUsername.Focus();
                return;
            }

            if (String.IsNullOrEmpty(tbTo.Text))
            {
                MessageBox.Show("Bạn phải nhập Người nhận");
                tbTo.Focus();
                return;
            }

            if (String.IsNullOrEmpty(tbContent.Text))
            {
                MessageBox.Show("Bạn phải nhập Nội dung tin nhắn");
                tbContent.Focus();
                return;
            }

            // Lưu username
            Setting.Default.Username = tbUsername.Text;
            Setting.Default.Save();

            // Gửi tin nhắn đến Server
            // Các bước gửi tin nhắn đến server gồm:
            // Bước 1: Xác định địa chỉ của máy nhận: IP, Port
            // Bước 2: Chuyển đổi dữ liệu cần gửi thành dạng mảng Byte
            // Bước 3: Kết nối đến máy nhận
            // Bước 4: Gửi dữ liệu
            // Bước 5: Chờ nhận phản hồi
            // Bước 6: Đóng kết nối

            // Bước 1
            String ip = "127.0.0.1";
            int port = 6868;

            // Bước 2
            String username = tbUsername.Text.Trim();
            String content = tbContent.Text.Trim();
            String to = tbTo.Text.Trim();
            String spliter = "[#*123*#]";

            String message = username + spliter + to + spliter + content;
            byte[] buffer = Encoding.UTF8.GetBytes(message);

            // Bước 3
            try
            {
                Socket sk = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                sk.Connect(ip, port);

                // Bước 4
                int sentByteCount = sk.Send(buffer);
                if(sentByteCount == buffer.Length)
                {
                    // Bước 5
                    byte[] receiveBuffer = new byte[1024];
                    int count = sk.Receive(receiveBuffer);
                    String receiveMessage = Encoding.UTF8.GetString(receiveBuffer, 0, count);
                    
                    tbHistory.Text += "You: " + content + "\r\n";
                    tbHistory.Text += "Status: " + receiveMessage + "\r\n";
                    tbHistory.ScrollToCaret();
                    // Bước 6
                    sk.Disconnect(false);
                    sk.Dispose();
                } 
                else
                {
                    MessageBox.Show("Gửi lỗi, hãy thử lại");
                    btSend.Focus();
                    return;
                }    
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối đến máy chủ. Hãy thử lại!");
                btSend.Focus();
                return;
            }
        }
    }
}
