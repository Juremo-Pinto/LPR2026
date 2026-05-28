using System;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
namespace Tabuada
{
    class Programinha
    {
        static void falar(string m) => Console.Write(m);
        static int ouvirP() => int.Parse(Console.ReadLine());
        static double ouvir2() => Convert.ToDouble(Console.ReadLine());
        static void Main()
        {
            int count;
            int num = 0;

            for (count = 50; count < 501; count++)
            {
                if (count % 3 == 0 && count % 2 != 0)
                {
                    num += count;
                }
            }
            falar($"É esse o numero que vc queria? \n \n{num}");

        }
    }
}