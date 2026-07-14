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

            int[3][3] numsA;
            for (int bans = 0; bans < 3; bans++)
            {
                for (int majas = 0; majas < 3; majas++)
                {
                    ouvirInt() = numsA[bans][majas];
                }
            }

            int[3][3] numsB;
            for (int bans = 0; bans < 3; bans++)
            {
                for (int majas = 0; majas < 3; majas++)
                {
                    ouvirInt() = numsB[bans][majas];
                }
            }

            int[,] numsC;
            for (int bans = 0; bans < 3; bans++)
            {
                for (int majas = 0; majas < 3; majas++)
                {
                    numsC[bans, majas] = 0;
                    for (int jabus = 0; jabus < 3; jabus++)
                    {
                        numsC[bans, majas] += numsA[bans, jabus] * numsB[jabus, majas];
                    }
                }
            }

            for (int bans = 0; bans < 3; bans++)
            {
                for (int majas = 0; majas < 3; majas++)
                {

                    falar($"{numsC[bans][majas]} ");

                    if (majas == 2)
                        falarEndl("");
                }
            }

        }
    }
}