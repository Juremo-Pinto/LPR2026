using System;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
namespace Tabuada
{
    class Programinha
    {
        static void falar(string m) => Console.Write(m);
        static void falarEndl(string m) => Console.WriteLine(m);
        static string ouvir() => Convert.ToString(Console.ReadLine());
        static int ouvirInt() => int.Parse(Console.ReadLine());
        static double ouvir2() => Convert.ToDouble(Console.ReadLine());
        static string? nome1 = "", poder1 = "";
        static int pontuacao1 = 0;
        static string? nome2 = "", poder2 = "";
        static int pontuacao2 = 0;
        static string? nome3 = "", poder3 = "";
        static int pontuacao3 = 0;
        static string? nome4 = "", poder4 = "";
        static int pontuacao4 = 0;
        static string? nome5 = "", poder5 = "";
        static int pontuacao5 = 0;
        static int heroi1 = 0, heroi2 = 0, heroi3 = 0;
        static void cadastrarHeroi()
        {
            falar("Cadastro de heroi, ");
            falar("insira um numero de 1 a 5 e cadastre o nome do heroi: ");
            int cadastro = ouvirInt();
            switch (cadastro)
            {
                case 1:
                    falar("Insira o nome do 1o heroi: ");
                    nome1 = ouvir();
                    falar("Insira seu poder: ");
                    poder1 = ouvir();
                    falar("Insira sua pontuação: ");
                    pontuacao1 = ouvirInt();
                    falarEndl($"{nome1} cadastrado.");
                    cadastrarHeroi();
                    break;

                case 2:
                    falar("Insira o nome do 2o heroi: ");
                    nome2 = ouvir();
                    falar("Insira seu poder: ");
                    poder2 = ouvir();
                    falar("Insira sua pontuação: ");
                    pontuacao2 = ouvirInt();
                    falarEndl($"{nome2} cadastrado.");
                    cadastrarHeroi();
                    break;

                case 3:
                    falar("Insira o nome do 3o heroi: ");
                    nome3 = ouvir();
                    falar("Insira seu poder: ");
                    poder3 = ouvir();
                    falar("Insira sua pontuação: ");
                    pontuacao3 = ouvirInt();
                    falarEndl($"{nome3} cadastrado.");
                    cadastrarHeroi();
                    break;

                case 4:
                    falar("Insira o nome do 4o heroi: ");
                    nome4 = ouvir();
                    falar("Insira seu poder: ");
                    poder4 = ouvir();
                    falar("Insira sua pontuação: ");
                    pontuacao4 = ouvirInt();
                    falarEndl($"{nome4} cadastrado.");
                    cadastrarHeroi();
                    break;

                case 5:
                    falar("Insira o nome do 5o heroi: ");
                    nome5 = ouvir();
                    falar("Insira seu poder: ");
                    poder5 = ouvir();
                    falar("Insira sua pontuação: ");
                    pontuacao5 = ouvirInt();
                    falarEndl($"{nome5} cadastrado.");
                    cadastrarHeroi();
                    break;

                case 6:
                    falarEndl("Voltando para o menu principal.");

                    break;

                case default:
                    falar("O numero inserido é invalido tente novamente.");
                    cadastrarHeroi();
                    break;
            }
        }
        static void selecionarEquipe()
        {
            falar("Selecinar equipe, ");
            falar("escolha até 3 dos herois cadastrados para sua equipe: ");

            falarEndl($"{nome1} | {poder1} | {pontuacao1}");
            falarEndl($"{nome2} | {poder2} | {pontuacao2}");
            falarEndl($"{nome3} | {poder3} | {pontuacao3}");
            falarEndl($"{nome4} | {poder4} | {pontuacao4}");
            falarEndl($"{nome5} | {poder5} | {pontuacao5}");

            falar("Heroi 1: ");
            heroi1 = ouvirInt;
            falar("Heroi 2: ");
            heroi2 = ouvirInt;
            falar("Heroi 3: ");
            heroi3 = ouvirInt;
            falar("Voltar menu");
        }
        static int pontuacaoTotal()
        {
            
        } //ARRRRRRRRGH DIFICL DEMAIS
        static void exibirEquipe()
        {
            falar("");
        }

    }
}