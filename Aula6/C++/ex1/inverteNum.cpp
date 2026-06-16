#include <iostream>
#include <windows.h>
#include <locale>

using namespace std;
int invertNumFunc(int num)
{
    int inverse = 0;

    while (num > 0)
    {

        int digit = num % 10;           // divide o numero por 10, o resto do numero vai ser o digito final porque: 416 / 10 +
        inverse = inverse * 10 + digit; // 
        num /= 10;
    }
    return inverse;
}

int main()
{
    SetConsoleOutputCP(65001);       // permite que o terminal mostre caracteres utf-8 corretamente
    setlocale(LC_ALL, "pt_BR.utf8"); // permite usar acentuação e interpretar caracteres utf-8

    cout << "Qual numero você deseja inverter?" << endl;
    int num;
    cin >> num;

    int inverse = invertNumFunc(num);
    cout << "O numero " << num << "invertido é " << inverse;
}