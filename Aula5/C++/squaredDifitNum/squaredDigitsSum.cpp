#include <iostream>
#include <windows.h>
#include <locale>

using namespace std;
int main()
{
    SetConsoleOutputCP(65001);       // permite que o terminal mostre caracteres utf-8 corretamente
    setlocale(LC_ALL, "pt_BR.utf8"); // permite usar acentuação e interpretar caracteres utf-8

    cout << endl
         << "Insira um numero: ";

    int num;
    cin >> num;

    int numSq = num * num;
    int sumDigits = 0;

    while (numSq > 0)
    {
        sumDigits += numSq % 10;
        numSq /= 10;
    }

    cout << "The sum of the the digits of the square of the number " << num << "is " << sumDigits << endl;
}