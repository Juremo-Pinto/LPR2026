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
        static int classe = 0;
        static string name, hab1, hab2;
        static void Main()
        {
            falar("Escolha uma classe");

            falarEnd("Guerreiro = 1");
            falarEnd("Arqueiro = 2");
            falarEnd("Mago = 3");

            classAtribute();

            classFeedback();
        }
        static void classAtribute()
        {
            classe = ouvirNum();

            switch (classe)
            {
                case 1:
                    name = "Guerreiro";
                    hab2 = "Ataque Pesado";
                    hab1 = "Defesa Total";
                break;

                case 2:
                    name = "Arqueiro";
                    hab1 = "Flecha Precisa";
                    hab2 = "Disparo Triplo";
                break;

                case 3:
                    name = "Mago";
                    hab1 = "Bola de Fogo";
                    hab2 = "Escudo de Gelo";
                break;

                default:
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
                break;

                case 2:
                    falarEnd($"Você escolheu {name}: ");
                    falarEnd("Habilidades :");
                    falar($"-> {hab1}");
                    falar($"-> {hab2}");
                break;

                case 3:
                    falarEnd($"Você escolheu {name}: ");
                    falarEnd("Habilidades :");
                    falar($"-> {hab1}");
                    falar($"-> {hab2}");
                break;

                default:
                    falar("q?");
                break;
            }
        }
    }
}