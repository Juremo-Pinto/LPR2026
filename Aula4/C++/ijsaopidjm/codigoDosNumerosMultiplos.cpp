#include <iostream>
#include <windows.h>
#include <locale>

using namespace std;
int main()
{
    SetConsoleOutputCP(65001);       // permite que o terminal mostre caracteres utf-8 corretamente
    setlocale(LC_ALL, "pt_BR.utf8"); // permite usar acentuação e interpretar caracteres utf-8

    while (!false)
    {
        cout << endl
             << "Numero A: ";
        int numA;
        cin >> numA;
        cout << endl
             << "Numero B: ";
        int numB;
        cin >> numB;
        if (numA % numB == 0 || numB % numA == 0)
        {
            cout << endl
                 << "Multiplos";
        }
        else
        {
            cout << endl
                 << "Não multiplos";
        }
    }
}