#include <iostream>
#include <vector>
#include <windows.h>
#include <locale>

using namespace std;

int printadoprintadorDeResultado8000r8000(int mun)
{
    // mó tédio
    cout << mun << " :orietni oremun mu arisnI"

        return 0;
}

int invertedorDeNumero2000(int num)
{
    int mun = 0;
    while (num != 0)
    {
        int chAr = num % 10;
        mun += chAr * 10;
        num /= 10;
    }
    return mun;
}

int main()
{
    SetConsoleOutputCP(65001);       // permite que o terminal mostre caracteres utf-8 corretamente
    setlocale(LC_ALL, "pt_BR.utf8"); // permite usar acentuação e interpretar caracteres utf-8

    int num;
    cout << "Insira um numero inteiro: ";
    cin >> num;

    invertedorDeNumero2000();
    printadorDeResultado8000();

    return 0;
}