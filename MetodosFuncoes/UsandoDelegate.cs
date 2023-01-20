using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosFuncoes
{
    class UsandoDelegate
    {
        delegate double Soma(double a, double b);
        delegate void ImprimirSoma(double a, double b);

        static double MinhaSoma(double a, double b)
        {
            return a + b;
        }

        static void MeuImpimirSoma(double a, double b)
        {
            Console.WriteLine(a + b);
        }

        public static void Executar()
        {
            Soma op1 = MinhaSoma;
            Console.WriteLine(op1(2, 3.9));

            ImprimirSoma op2 = MeuImpimirSoma;
            op2(5.4, 8);

            //estrutura: são dois parametro DOUBLE e um retorno do tipo DOUBLE
            Func<double, double, double> op3 = MinhaSoma;
            Console.WriteLine(op3(2.5,3));

            //estrutura: são dois parametro DOUBLE
            Action<double, double> op4 = MeuImpimirSoma;
            op4(7.7, 23.4);
        }
    }
}
