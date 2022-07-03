using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROBLEMA_MEDIA_IDADES {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int idade, soma, quantidade;
            double media;

            soma = 0;
            quantidade = 0;

            Console.WriteLine("Digite as idades: ");
            idade = int.Parse(Console.ReadLine());

            while (idade >= 0) {
                soma = soma + idade;
                quantidade = quantidade + 1;
                idade = int.Parse(Console.ReadLine());
            }

            if (quantidade < 0 || quantidade == 0) {
                Console.WriteLine("IMPOSSIVEL CALCULAR");
            }

            else {
                media = (double)soma / quantidade;
                Console.WriteLine("MEDIA = " + media.ToString("F2", CI));
            }


        }
    }
}
