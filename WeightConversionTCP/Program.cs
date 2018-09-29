using System;
using WeightConversionTCPServer;

namespace WeightConversionTCP
{
    class Program
    {
        static void Main(string[] args)
        {
           
           WeightConversionServer wcs = new WeightConversionServer(7);
            wcs.Start();

            Console.ReadLine();
        }
    }
}
