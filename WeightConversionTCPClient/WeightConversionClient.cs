using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace WeightConversionTCPClient
{
    public class WeightConversionClient
    {

        public void Start()
        {

            using (TcpClient socket = new TcpClient("localhost", 7))
            using (NetworkStream ns = socket.GetStream())
            using (StreamReader sr = new StreamReader(ns))
            using (StreamWriter sw = new StreamWriter(ns))
            {

                // I konsollen kan man enten skrive "togram VÆRDI" eller "toounce VÆRDI". Der gøres ikke forskel på store eller små bogstaver.
                string str = Console.ReadLine();
                sw.WriteLine(str);
                sw.Flush();

                string line = sr.ReadLine();

                Console.WriteLine($"String reads {line}");



            }
        }
    }
}
