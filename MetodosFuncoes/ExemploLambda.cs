using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosFuncoes
{
    class ExemploLambda
    {
        public static void Executar()
        {
            //Action = () => função
            Action algoNoConsole = () =>
            {
                Console.WriteLine("Lambda com C#!");
            };

            algoNoConsole();
            //função com o tipo de retorno int
            Func<int> jogarDado = () =>
            {
                Random random = new Random();
                return random.Next(1, 7);
            };

            Console.WriteLine(jogarDado());

            Func<int, string> conversorHex = numero => numero.ToString("x");
            Console.WriteLine(conversorHex(1234));

            Func<int, int, int, string> formartarData = (dia, mes, ano) => String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);
            Console.WriteLine(formartarData(1,1,2019));
        }
    }
}
