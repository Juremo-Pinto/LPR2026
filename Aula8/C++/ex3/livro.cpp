#include <iostream>
#include <windows.h>
#include <locale>
#include <array>
#include <limits>

using namespace std;

struct Book
{
    string title;
    string author;
    int year;
    int pages;
    int price;
};

int main()
{

    SetConsoleOutputCP(65001);       // permite que o terminal mostre caracteres utf-8 corretamente
    setlocale(LC_ALL, "pt_BR.utf8"); // permite usar acentuação e interpretar caracteres utf-8

    int pagesTotal;
    int priceTotal;

    array<Book, 3> cart;

    for (int maracujas = 0; maracujas < 3; maracujas++)
    {
        cout << "Nome do " << maracujas + 1 << "o Livro: ";
        getline(cin, cart[maracujas].title);
        cout << "Autor: ";
        getline(cin, cart[maracujas].author);
        cout << "Ano de lançamento: ";
        cin >> cart[maracujas].year;
        cout << "Paginas: ";
        cin >> cart[maracujas].pages;
        cout << "Preço: ";
        cin >> cart[maracujas].price;
        cout << endl;
        cin.ignore(numeric_limits<streamsize>::max(), '\n');
    }

    for (Book book : cart)
    {

        priceTotal += book.price;

        pagesTotal += book.price;
    }

    int pagesAvg = pagesTotal / 3;

    cout << "Total a pagar => " << priceTotal << endl;
    cout << "Média de paginas: " << pagesAvg;

}