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

            bool KILL_CODE = false;

            while (KILL_CODE == false)
            {

                int[,] cities =
                {
                {0, 524, 521, 882}, //vitoria 0
                {524, 0, 434, 586}, //bh 1
                {524, 434, 0, 429}, //riodejaneir 2
                {882, 586, 429, 0}  //saopaulo 3
                };
                int dist;

                falarEndl("Saiba a distancia entre estas 4 cidades em especifico!\n");
                falar("Vitoria = 1\nBelo Horizonte = 2\nRio De Janeiro = 3\nSão Paulo = 4");
                int city1 = ouvirInt();
                int city2 = ouvirInt();

                dist = cities[city1 - 1, city2 - 1];

                falarEndl($"A distancia é {dist}km.");

                if (dist == 0)
                    KILL_CODE = true;
                else
                    KILL_CODE = false;
            }
        }
    }
}