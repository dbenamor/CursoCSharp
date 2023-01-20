using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Notebook";
            string marca = "Dell";
            double preco = 5800.00;

            Console.WriteLine("O " + nome + " da marca " + marca + " custa R$" + preco + ".");
            Console.WriteLine("0 {0} da marca {1} custa R${2}.", nome, marca, preco);
            Console.WriteLine($"A marca {marca} é cara.");
            Console.WriteLine($"1 + é igual a {1 + 1}!");
        }
    }
}
