using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);
            Console.WriteLine("Área é " + (area + 1000));

            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            int menorValorInt = int.MinValue;
            Console.WriteLine(menorValorInt);

            uint menorValorIntSemSinal = 207_600_000;
            Console.WriteLine(menorValorIntSemSinal);

            float precoComputador = 1299.99f;
            Console.WriteLine(precoComputador);
        }
    }
}
