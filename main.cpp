#include <bits/stdc++.h>

using namespace std;

int main()
{

    int idade, soma, quantidade;
    double media;

    soma = 0;
    quantidade = 0;

    cout << "Digite as idades: " << endl;
    cin >> idade;

    while (idade >= 0) {
         soma = soma + idade;
         quantidade = quantidade + 1;
         cin >> idade;
    }

    if (quantidade < 0 || quantidade == 0) {
        cout << "IMPOSSIVEL CALCULAR";
    }
    else { media = (double) soma / quantidade;
          cout << fixed << setprecision(2);
          cout << "MEDIA = " << media << endl;
    }


    return 0;
}
