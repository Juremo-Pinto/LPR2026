#include <iostream>
#include <windows.h>
#include <locale>

using namespace std;
int main()
{
    SetConsoleOutputCP(65001);       // permite que o terminal mostre caracteres utf-8 corretamente
    setlocale(LC_ALL, "pt_BR.utf8"); // permite usar acentuação e interpretar caracteres utf-8

    int hrs = 0;
    int hrsTotal = 0;
    int days = 0;

    cout << endl
         << "Bem vindo a simulação de treinamento Jedi!";

    cout << endl
         << "Insira o numero de horas diarias: ";
    cin >> hrs;

    while (hrsTotal < 1000)
    {
        hrsTotal += hrs;
        days++;
    }

    int weeks = days / 5;
    int months = weeks / 4.5;

    cout << "Total de horas treinadas : " << hrsTotal;
    cout << "Total de dias : " << days;
    cout << "Total de semanas : " << weeks;
    cout << "Total de meses : " << months;
    
}