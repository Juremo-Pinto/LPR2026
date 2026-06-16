#include <iostream>
#include <windows.h>
#include <locale>

using namespace std;

// Códigos reusados e modificados do repo. de correção por motivos praticalidade
// Créditos ao Andery     setlocale(LC_ALL, "pt_BR.utf8");

int mediaParFunc()
{

    int quantidade;
    cout << "Digite a quantidade de números a serem inseridos: ";
    cin >> quantidade;

    int soma = 0;
    int contador = 0;

    while (quantidade > 0)
    {
        int numero;
        cout << "Digite um número: ";
        cin >> numero;

        if (numero % 2 == 0)
        {
            soma += numero;
            contador++;
        }

        quantidade--;
    }

    if (contador > 0)
    {
        double media = static_cast<double>(soma) / contador;
        cout << "A média dos números pares é: " << media << endl;
    }
    else
    {
        cout << "Nenhum número par foi digitado." << endl;
    }
}

int multThreeFunc()
{

    int soma = 0;

    for (int i = 50; i <= 500; i++)
    {
        if (i % 2 != 0 && i % 3 == 0)
        {
            soma += i;
        }
    }

    cout << "A soma dos números ímpares múltiplos de 3 de 50 a 500 é: " << soma << endl;
}

int squaredDigitsSumFunc()
{
    setlocale(LC_ALL, "pt_BR.utf8");
    cout << "Digite um número: ";
    int numero;
    cin >> numero;

    int quadrado = numero * numero;
    int somaDigitos = 0;

    while (quadrado > 0)
    {
        somaDigitos += quadrado % 10;
        quadrado /= 10;
    }

    cout << "A soma dos dígitos do quadrado de " << numero << " é: " << somaDigitos << endl;
}

int main()
{
    cout << "Escolha 1 entre os 3 programas para utilizar..." << endl;
    cout << "1 - Calc. de média aritimética." << endl;
    cout << "2 - Soma dos numeros entre 50 e 500 que são multiplos de 3." << endl;
    cout << "3 - Soma dos numeros contidos dentro do quadrado." << endl;

    int cases = 0;
    cin >> cases;

    switch (cases)
    {

    case 1:
        mediaParFunc();
        break;

    case 2:
        multThreeFunc();
        break;

    case 3:
        squaredDigitsSumFunc();
        break;

    case default:
        cout << "Função não encontrada" << endl;
    }
}