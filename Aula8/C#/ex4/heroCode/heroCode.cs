using System;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
namespace Tabuada
{
    class Programinha
    {
        public struct Hero
        {
            public string name;
            public string power;
            public int points;
        }
        static void falar(string m) => Console.Write(m);
        static void falarEndl(string m) => Console.WriteLine(m);
        static string ouvir() => Convert.ToString(Console.ReadLine());
        static int ouvirInt() => int.Parse(Console.ReadLine());
        static double ouvir2() => Convert.ToDouble(Console.ReadLine());
        static void heroRegistry()
        {
            Hero[] team = new Hero[5];

            for (int bananas = 0; bananas < 5; bananas++)
            {
                falar($"Nome do heroi {bananas + 1}: ");
                team[bananas].name = ouvir();
                falar($"Poder do heroi {bananas + 1}");
                team[bananas].power = ouvir();
                falar($"Pontuação do heroi {bananas + 1}");
                team[bananas].points = ouvirInt();

            }
        }
        static void teamSelection()
        {
            foreach (Hero hero in team)
            {
                
            }
        }
        static void main()
        {
            heroRegistry();
        }
    }
}