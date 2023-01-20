using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual o seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qualo seu salário? ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"O seu nome é {nome}, a sua idade é {idade} e você tem o salário de R${salario}.");
        }
    }
}
