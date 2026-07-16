#include "bits/stdc++.h"
#include <iostream>
#include <windows.h>
#include <locale>
#include <array>
#include <limits>

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

    for (int bananas = 0; bananas < 3; bananas++)
    {
        cout << "Nome do " << bananas + 1 << "o filme: ";
        getline(cin, colecao[bananas].titulo);
        cout << "Nome do diretor: ";
        getline(cin, colecao[bananas].diretor);
        cout << "Data de lançamento: ";
        cin >> colecao[bananas].anoLancamento;
        cout << "Duração do filme: ";
        cin >> colecao[bananas].duracaoMin;
        cin.ignore(numeric_limits<streamsize>::max(), '\n');
    }

    for (Filme filme : colecao)
    {
        cout << filme.titulo << " (" << filme.anoLancamento << ")" << endl;
    }

    int indexMaisAntigo = 0;
    for (size_t i = 1; i < colecao.size(); ++i)
    {
        if (colecao[i].anoLancamento < colecao[indexMaisAntigo].anoLancamento)
        {
            indexMaisAntigo = static_cast<int>(i);
        }
    }
    cout << "O filme mais antigo é: " << colecao[indexMaisAntigo].titulo
         << " (" << colecao[indexMaisAntigo].anoLancamento << ")" << endl;
}