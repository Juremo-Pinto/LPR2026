using System;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
namespace Tabuada
{
    class Programinha
    {
        static void falar(string m) => Console.Write(m);
        static void falarEnd(string m) => Console.WriteLine(m);
        static int ouvir() => Convert.ToInt32(Console.ReadLine());
        static double ouvir2() => Convert.ToDouble(Console.ReadLine());
        static void Main()
        {
            while (true)
            {
                falar("Escreva um numero inteiro: ");
                double numInt = ouvir2();
                if (numInt % 1 == 0)
                {
                    if (numInt % 2 == 0)
                    {
                        falarEnd($"O numero {numInt} é par!");
                    }
                    else
                    {
                        falarEnd($"O numero {numInt} é impar!");
                    }
                }
                else
                {
                    falarEnd("Eu disse inteiro...");
                }
            }

        }

    }

}