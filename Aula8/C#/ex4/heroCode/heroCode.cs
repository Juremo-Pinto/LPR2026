using System;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
namespace Tabuada
{
    class Programinha
    {
        static Hero[] hero = new Hero[5];
        static Team[] team = new Team[3];
        public struct Hero
        {
            public string name;
            public string power;
            public int points;
        }
        public struct Team
        {
            public string namet;
            public string powert;
            public int pointst;
        }
        static void falar(string m) => Console.Write(m);
        static void falarEndl(string m) => Console.WriteLine(m);
        static string ouvir() => Convert.ToString(Console.ReadLine());
        static int ouvirInt() => int.Parse(Console.ReadLine());
        static double ouvir2() => Convert.ToDouble(Console.ReadLine());
        static void heroRegistry()
        {

            for (int bananas = 0; bananas < hero.Length; bananas++)
            {
                falar($"Nome do heroi {bananas}: ");
                hero[bananas].name = ouvir();
                falar($"Poder do heroi {bananas}");
                hero[bananas].power = ouvir();
                falar($"Pontuação do heroi {bananas}");
                hero[bananas].points = ouvirInt();

            }

            menu();
        }
        static void teamSelection()
        {
            falar($"Lista de herois para adicionar ao time: ");

            for (int num = 0; num < hero.Length; num++)
            {
                falar($" Heroi {num + 1} => {hero[num].name} {hero[num].power} {hero[num].points}");
            }

            for (int maracujas = 0; maracujas < team.Length; maracujas++)
            {
                int uh = ouvirInt();
                if (0 <= uh && uh <= 4)
                {
                    team[maracujas].namet = hero[uh].name;
                    team[maracujas].powert = hero[uh].power;
                    team[maracujas].pointst = hero[uh].points;
                }
            }

            menu();
        }
        static int teamPoints()
        {
            int totalPoints = 0;

            foreach (Team teamZ in team)
            {
                totalPoints += teamZ.pointst;
            }

            return totalPoints;

        }

        static void teamShow()
        {

            int batatas = 0;

            falar("Equipe: ");
            foreach (Team teamZ in team)
            {
                batatas++;
                falar($"Integrante {batatas} =>");
                falarEndl("");

                falar($"{teamZ.namet}");
                falar($"{teamZ.powert}");
                falarEndl("");
            }

            int totalPoints = teamPoints();

            falar($"Pontuação total => {totalPoints}");
            falarEndl("");

            menu();
        }
        static void preMenu()
        {
            falar("Bem vindo ao menu principal do criador de equipe!");
            falarEndl("");
            falar("Registre os heris disponiveis, seus poderes e pontuação.");
            falar("1 para sim, 0 para sair");

            int choice = ouvirInt();

            if (choice == 1)
            {
                heroRegistry();
            }
            else
            {
                falar("Goodbye.");
                Environment.Exit(0);
            }

        }
        static void menu()
        {
            falarEndl("");
            falarEndl("1 - Registrar heróis");
            falarEndl("2 - Montar equipe");
            falarEndl("3 - Mostrar equipe");
            falarEndl("0 - Sair");

            int select = ouvirInt();
            switch (select)
            {
                case 1:
                    heroRegistry();
                    break;

                case 2:
                    teamSelection();
                    break;

                case 3:
                    teamShow();
                    break;

                default:
                    Environment.Exit(0);
                    break;
            }

        }
        static void Main()
        {
            preMenu();

        }
    }
}

// i am become programer
// maker of codes