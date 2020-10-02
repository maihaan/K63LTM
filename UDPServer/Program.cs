using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.CodeDom.Compiler;

namespace UDPServer
{
    class Program
    {
        static void Main(string[] args)
        {
            LangNghe();
        }

        private static void LangNghe()
        {
            UdpClient server = new UdpClient(6868);
            while(true)
            {
                IPEndPoint ep = new IPEndPoint(IPAddress.Any, 6868);
                byte[] buffer = server.Receive(ref ep);
                Console.WriteLine(Encoding.UTF8.GetString(buffer) + "\r\n");
                server.Send(Encoding.UTF8.GetBytes("OK"), 2);
            }    
        }
    }
}
