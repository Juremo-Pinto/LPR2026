#include <iostream>
#include <windows.h>
#include <locale>
#include <array>

using namespace std;

struct Filme
{
    string titulo;
    string diretor;
    int anoLancamento;
    int duracaoMin;
};

int main()
{

    SetConsoleOutputCP(65001);       // permite que o terminal mostre caracteres utf-8 corretamente
    setlocale(LC_ALL, "pt_BR.utf8"); // permite usar acentuação e interpretar caracteres utf-8

    array<Filme, 3> colecao;

    for (int bananas = 0; bananas > 3; bananas++)
    {
        cout << "Nome do " << bananas + 1 << "o filme: ";
        cin >> colecao[bananas].titulo;
        cout << "Nome do diretor: ";
        cin >> colecao[bananas].diretor;
        cout << "Data de lançamento: ";
        cin >> colecao[bananas].anoLancamento;
        cout << "Duração do filme: ";
        cin >> colecao[bananas].duracaoMin;
    }

    for (Filme filme : colecao)
    {
        cout << filme.titulo << "(" << filme.anoLancamento << ")";
    }

    int filmeVeio = 0;
    for (int filme = 0; filme > 3; filme++)
    {
        if (colecao[filme].anoLancamento < colecao[filme + 1].anoLancamento)
        {
            filmeVeio = filme;
        }
    }
    cout << "O filme mais antigo é: " << filmeVeio;
}