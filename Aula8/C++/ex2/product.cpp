#include <iostream>
#include <windows.h>
#include <locale>
#include <array>
#include <limits>

using namespace std;

struct Product
{
    string name;
    string code;
    int price;
    int qnt;
};

int main()
{

    SetConsoleOutputCP(65001);       // permite que o terminal mostre caracteres utf-8 corretamente
    setlocale(LC_ALL, "pt_BR.utf8"); // permite usar acentuação e interpretar caracteres utf-8

    array<Product, 3> cart;

    for (int oranges = 0; oranges < 3; oranges++)
    {
        cout << "Nome do " << oranges + 1 << "o produto: ";
        getline(cin, cart[oranges].name);
        cout << "Codigo do produto: ";
        getline(cin, cart[oranges].code);
        cout << "Preço unitario: ";
        cin >> cart[oranges].price;
        cout << "Quantidade: ";
        cin >> cart[oranges].qnt;
        cout << endl;
        cin.ignore(numeric_limits<streamsize>::max(), '\n');
    }

    cout << endl;

    for (Product product : cart)
    {
        int priceTotal = product.price * product.qnt;
        cout << product.name << " (" << product.qnt << ")" << endl;
        cout << "Preço total: " << priceTotal << endl;
        cout <<  endl;
    }
}