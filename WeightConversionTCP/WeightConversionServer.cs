using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using WeightConversionDLL;

namespace WeightConversionTCPServer
{
    public class WeightConversionServer
    {
        private int _port;

        public WeightConversionServer(int port)
        {
            _port = port;
        }


        public void Start()
        {
            TcpListener serverListener = new TcpListener(IPAddress.Loopback, _port);
            serverListener.Start();

            while (true)
            {
                // AcceptTcpClient venter "hårdt" på at der kommer en forbindelse og går ikke videre før den har fået en
                TcpClient socket = serverListener.AcceptTcpClient();
                {
                    TcpClient tempSocket = socket;
                    Task.Run(() =>
                    {
                        DoClient(tempSocket);
                    });
                }
            }

        }

        public void DoClient(TcpClient socket)
        {
            using (StreamReader sr = new StreamReader(socket.GetStream()))
            using (StreamWriter sw = new StreamWriter(socket.GetStream()))
            {
                string str = sr.ReadLine();

                // Deler Stringen fra streamen op i 2 dele - method (togram eller toounces) og value (vægt)
                string[] strs = str.Split(" ");
                string method = strs[0];
                string value = strs[1];

                double valueNumber = double.Parse(value);

                // konverterer her værdien fra clienten baseret på navnet af den metode der medbringes i den første del af stringen. Der laves ikke fejlhåndtering.
                sw.WriteLine(method.ToLower() == "togram"
                    ? ConverterClass.ConvertToGram(valueNumber) : ConverterClass.ConvertToOunces(valueNumber));

                sw.Flush();
            }
        }
    }
}
