#include <iostream>
#include <windows.h>
#include <locale>
#include <vector>
#include <limits>

using namespace std;

int main()
{

    SetConsoleOutputCP(65001);       // permite que o terminal mostre caracteres utf-8 corretamente
    setlocale(LC_ALL, "pt_BR.utf8"); // permite usar acentuação e interpretar caracteres utf-8

    vector<int> numOdd;
    vector<int> numEven;

    int num[10];

    cout << "10 numeros agora: " << endl;

    for (int banas = 0; banas < 10; banas++)
    {

        cin >> num[banas];

        if ((num[banas] % 2) == 0)
            numEven.push_back(num[banas]);
        else
            numOdd.push_back(num[banas]);
    }

    cout << "PAR: ";

    for (int evenSteven : numEven)
        cout << evenSteven << " ";

    cout << endl
         << "ÍMPAR: ";

    for (int oddTod : numOdd)
        cout << oddTod << " ";
}