using System;

namespace WeightConversionTCPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            WeightConversionClient c = new WeightConversionClient();

            c.Start();

            Console.ReadKey();
        }
    }
}
