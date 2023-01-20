using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Executar()
        {
            //preço desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComdesconto = total - (total * desconto);
            Console.WriteLine("O preço final com desconto é: {0}", totalComdesconto);
            Console.WriteLine("O preço final sem desconto é: {0}", total);

            //IMC
            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / Math.Pow(altura, 2); //cálculo de potência (base, expoente)
            Console.WriteLine($"IMC é {imc}.");

            //numero par/impar
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);
        }
    }
}
