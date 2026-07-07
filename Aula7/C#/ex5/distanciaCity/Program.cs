using System;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
namespace Tabuada
{
    class Programinha
    {
        static void falar(string m) => Console.Write(m);
        static void falarEndl(string m) => Console.WriteLine(m);
        static string ouvir() => Convert.ToString(Console.ReadLine());
        static int ouvirInt() => int.Parse(Console.ReadLine());
        static double ouvir2() => Convert.ToDouble(Console.ReadLine());
        static void Main()
        {
            
            int[,] cities =
            {
                {0, 524, 521, 882}, //vitoria 1
                {524, 0, 434, 586}, //bh 2 
                {524, 434, 0, 429}, //riodejaneir 3
                {882, 586, 429, 0}  //saopaulo 4
            };

            int dist = 0;

            int city1 = ouvirInt();
            int city2 = ouvirInt();

            dist = cities[city1-1,city2-1];

            falar($"A distancia é {dist}km.");
        }
    }
}