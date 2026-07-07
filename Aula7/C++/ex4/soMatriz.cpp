#include <iostream>
#include <windows.h>
#include <locale>
#include <vector>
#include <algorithm>
#include <limits>

using namespace std;

int main()
{

    SetConsoleOutputCP(65001);       // permite que o terminal mostre caracteres utf-8 corretamente
    setlocale(LC_ALL, "pt_BR.utf8"); // permite usar acentuação e interpretar caracteres utf-8

    int nums[3][3];
    int sum = 0;

    cout << "Insira uma matriz: " << endl;
    for (int bans = 0; bans < 3; bans++)
    {
        for (int majas = 0; majas < 3; majas++)
        {
            cin >> nums[bans][majas];
        }
    }

    for (int bans = 0; bans < 3; bans++)
    {
        if (bans == 0 || bans == 2)
            cout << "        ";
        else
        cout << "Matriz: ";

            for (int majas = 0; majas < 3; majas++)
            {

                sum += nums[bans][majas];

                cout << nums[bans][majas] << " ";

                if (majas == 2)
                    cout << endl;
            }
    }

    cout << endl
         << "Soma: ";

    cout << sum;
}