#include <iostream>
#include <vector>
#include <windows.h>
#include <locale>

using namespace std;

int invertedorDeNumero2000(int num)
{
    int numR = 0;
    while (num != 0) {
        int chAr = num % 10;
        numR += chAr * 10;
        num -= chAr;
    }
    return numR;
}

int main()
{
    SetConsoleOutputCP(65001);       // permite que o terminal mostre caracteres utf-8 corretamente
    setlocale(LC_ALL, "pt_BR.utf8"); // permite usar acentuação e interpretar caracteres utf-8

    int num;
    cout << "Insira um numero inteiro: ";
    cin >> num;

    for (int bananas = 0; bananas < 4)
    {
    }
}