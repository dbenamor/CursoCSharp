using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); //Arredondamento.
            Console.WriteLine(valor.ToString("C")); //Valor monetário.
            Console.WriteLine(valor.ToString("p")); //Percentual.
            Console.WriteLine(valor.ToString("#.##")); //Número com 2 casass decimais.

            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C3", cultura)); //Imprimir em formato de dinheiro, sem casas decimais.

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); //Imprimir a quantidade de x numeros de caracteres.
        }
    }
}
