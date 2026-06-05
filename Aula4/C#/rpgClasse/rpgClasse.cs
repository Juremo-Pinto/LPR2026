using System;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
/*
Suponha que você está desenvolvendo um jogo
de RPG. Você é responsável por implementar a
mecânica de habilidades especiais para
diferentes classes de personagens. Cada classe
tem suas próprias habilidades especiais.
Crie um programa que permita ao jogador
escolher uma classe de personagem e, em
seguida, exiba suas habilidades especiais
correspondentes.
*/
namespace Tabuada
{
    class Programinha
    {
        static void falar(string m) => Console.Write(m);
        static void falarEnd(string m) => Console.WriteLine(m);
        static int ouvirNum() => Convert.ToInt32(Console.ReadLine());
        static double ouvir2() => Convert.ToDouble(Console.ReadLine());
        static void classAtribute()
        {
            if (classe = 1)
            {
                string name = "Guerreiro";
                string hab1 = "Defesa Total";
                string hab2 = "Ataque Pesado";
            }
            else if (classe = 2)
            {
                string name = "Arqueiro";
                string hab1 = "Flecha Precisa";
                string hab2 = "Disparo Triplo";
            }
            else if (classe = 3)
            {
                string name = "Mago";
                string hab1 = "Bola de Fogo";
                string hab2 = "Escudo de Gelo";
            }
            else
            {
                falarEnd("erro, opção invalida...");
                break;
            }
        }
        static void classFeedback()
        {
            switch (classe)
            {
                case 1:

                    falarEnd($"Você escolheu {name}: ");
                    falarEnd("Habilidades :");
                    falar($"-> {hab1}");
                    falar($"-> {hab2}");
                case 2:

                    falarEnd($"Você escolheu {name}: ");
                    falarEnd("Habilidades :");
                    falar($"-> {hab1}");
                    falar($"-> {hab2}");
                case 3:

                    falarEnd($"Você escolheu {name}: ");
                    falarEnd("Habilidades :");
                    falar($"-> {hab1}");
                    falar($"-> {hab2}");
                case default:
                    falar("q?");
            }
        }
        static void Main()
        {
            int classe = ouvirNum();

            falar("Escolha uma classe");

            falarEnd("Guerreiro = 1");
            falarEnd("Arqueiro = 2");
            falarEnd("Mago = 3");

            classAtribute();

            classFeedback();

        }

    }

}
