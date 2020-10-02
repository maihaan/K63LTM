using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Data;

namespace SocketServer
{
    class Program
    {
        static void Main(string[] args)
        {
            LangNghe();
        }


        static private void LangNghe()
        {
            // B1
            String serverIp = "127.0.0.1";
            int serverPort = 6868;
            Socket listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(serverIp), serverPort);
            listenSocket.Bind(ep);
            listenSocket.Listen(100);

            // B2
            while(true)
            {
                // Neu co ket noi den
                Socket handler = listenSocket.Accept();
                // B3
                String data = "";
                byte[] buffer = new byte[1024];
                while (handler.Available > 0)
                {
                    int byteReceiveCount = handler.Receive(buffer);
                    data += Encoding.UTF8.GetString(buffer, 0, byteReceiveCount);
                }
                Console.WriteLine("Da nhan: " + data);
                if (data.StartsWith("?"))
                {
                    // Kiem tra xem co tin nhan nao moi gui den cho client khong?
                    String query = "Select * From tbSocket Where Receiver=N'"
                        + data.Substring(1) + "' And Status=N'Đã nhận'";
                    DataAccess da = new DataAccess();
                    DataTable tb = da.Read(query);
                    if(tb != null && tb.Rows.Count > 0)
                    {
                        String msg = "";
                        foreach(DataRow r in tb.Rows)
                        {
                            msg += r["Sender"].ToString() + ": " + r["Message"] + "\r\n";
                            String upQuery = "Update tbSocket Set Status=N'Đã đọc' Where ID=" + r["ID"].ToString();
                            da.Write(upQuery);
                        }
                        // Gui lại cho client
                        handler.Send(Encoding.UTF8.GetBytes(msg));
                        handler.Close();
                        handler.Dispose();
                    }
                    else
                    {
                        handler.Send(Encoding.UTF8.GetBytes("Khong co gi"));
                        handler.Close();
                        handler.Dispose();
                    }    
                }
                else
                {
                    // Luu du lieu
                    String spliter = "[#*123*#]";
                    String temp = data.Replace(spliter, "~");
                    String from = temp.Split('~')[0];
                    String to = temp.Split('~')[1];
                    String content = temp.Split('~')[2];

                    String query = "Insert Into tbSocket(Sender, Receiver, Message, Time) Values("
                        + "N'" + from + "',"
                        + "N'" + to + "',"
                        + "N'" + content + "',"
                        + "N'" + DateTime.Now.ToString() + "')";
                    DataAccess da = new DataAccess();
                    da.Write(query);

                    // Tra loi
                    handler.Send(Encoding.UTF8.GetBytes("OK"));
                    handler.Close();
                    handler.Dispose();
                }

            }    
        }
    }
}
