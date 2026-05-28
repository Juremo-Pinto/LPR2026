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
            falar("Defina a quantidade de numeros da sequencia: ");
            int counter = 0;
            int quant = ouvirP();
            double soma = 0;
            int impar = 0;


            while (counter < quant)
            {
                falar("Numero par: ");
                double num = ouvir2();
                if (num % 2 == 0)
                {
                    counter++;
                    soma += num;
                }
                else
                {
                    counter++;
                    impar--;
                }

            }

            falar($"A média é de {soma / (quant + impar)}");

        }
    }
}