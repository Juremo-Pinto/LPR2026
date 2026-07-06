#include <iostream>
#include <windows.h>
#include <locale>
#include <array>
#include <limits>

using namespace std;

int main()
{

    SetConsoleOutputCP(65001);       // permite que o terminal mostre caracteres utf-8 corretamente
    setlocale(LC_ALL, "pt_BR.utf8"); // permite usar acentuação e interpretar caracteres utf-8

    int num[5];
    int bigNum;
    int bigPos;

    cout << "5 numeros agora: " << endl;

    for (int banas = 0; banas < 5; banas++)
    {
        cin >> num[banas];
    }
    cout << endl
         << "Vetor: ";

    bigNum = num[0];
    bigPos = 0;

    for (int cujas = 0; cujas < 5; cujas++)
    {
        cout << num[cujas] << " ";

        if (num[cujas] > bigNum)
        {
            bigNum = num[cujas];
            bigPos = cujas;
        }
    }

    cout << endl
         << "Maior valor: " << bigNum << endl
         << "Posição: " << bigPos+1 << "(" << bigPos << ")";

    return 0;
}