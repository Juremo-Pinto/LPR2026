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

    vector<int> numBank;

    cout << "Deposite 10 numeros agora: " << endl;
    for (int banas = 0; banas < 10; banas++)
    {
        int deposit;
        cin >> deposit;
        numBank.push_back(deposit);
    }

    cout << endl
         << "Qual numero vc quer?" << endl;
    int withdrawl;
    cin >> withdrawl;

    bool found = false;
    auto theNumberYouAskedFor = find(numBank.begin(), numBank.end(), withdrawl);
    while (theNumberYouAskedFor != numBank.end())
    {
        found = true;
        cout << theNumberYouAskedFor - numBank.begin() << " ";

        theNumberYouAskedFor = find(theNumberYouAskedFor + 1, numBank.end(), withdrawl);
    }

    if (!found)
        cout << endl
             << "Numero não existe" << endl;
}