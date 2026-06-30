using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
namespace Tabuada
{
    class Programinha
    {
        static Chamado[] chms = new Chamado[10];
        public struct Chamado
        {
            public int num;
            public string slc;
            public string sec;
            public int prty;
            public string stats;
            public string desc;
        }
        static void falar(string m) => Console.Write(m);
        static void falarEndl(string m) => Console.WriteLine(m);
        static string ouvir() => Convert.ToString(Console.ReadLine());
        static int ouvirInt() => int.Parse(Console.ReadLine());
        static double ouvir2() => Convert.ToDouble(Console.ReadLine());

        static void cadastrarChamado()
        {
            
        }
        static void Main()
        {

        }
    }
}