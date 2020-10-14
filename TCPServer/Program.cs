using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TCPServer
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress ipAd = IPAddress.Parse("127.0.0.1");
            TcpListener myList = new TcpListener(ipAd, 6868);
            myList.Start();
            Console.WriteLine("Waiting for a connection.....");
            while (true)
            {
                Socket s = myList.AcceptSocket();
                Console.WriteLine("Connection accepted from " + s.RemoteEndPoint);

                byte[] b = new byte[100];
                int k = s.Receive(b);
                Console.WriteLine("Recieved...");
                for (int i = 0; i < k; i++)
                    Console.Write(Convert.ToChar(b[i]));

                ASCIIEncoding asen = new ASCIIEncoding();
                s.Send(asen.GetBytes("OK"));
                Console.WriteLine("\nSent OK");
                s.Close();                
            }
            myList.Stop();
        }
    }
}
