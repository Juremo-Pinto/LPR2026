using System;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
namespace Tabuada
{
    class Programinha
    {
        static void falar(string m) => Console.Write(m);
        static int ouvir32() => Convert.ToInt32(Console.ReadLine());
        static double ouvir2() => Convert.ToDouble(Console.ReadLine());
        static void Main()
        {
            int stupid = 0;
            bool EBA = false;
            Random rnd = new Random();
            int num = rnd.Next(1, 101);
            falar("Ache o numero de 1 a 100: ");
            do
            {

                int guess = ouvir32();
                stupid += 1;

                if (guess > 101)
                {

                    falar("É abaixo de 100 abestalhado!\n");
                }
                else if (guess < 1)
                {

                    falar("É acima de 1 abestalhado!\n");
                }
                else if (guess < num)
                {

                    falar("Errou pra baixo\n");
                }
                else if (guess > num)
                {

                    falar("Errou pra cima\n");
                }
                else
                {

                    falar("Acertou!\n");
                    falar($"Vc errou {stupid} vezes.\n");
                    EBA = true;
                }

            } while (!EBA);

        }
    }
}