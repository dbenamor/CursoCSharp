using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class MetodosEstaticos
    {
        public class CalculadoraEstatica
        {            
            //Método de Classe ou Método estático, só pode ser acessado pela classe
            public static int Multiplicar(int a, int b)
            {
                return a * b;
            }

            //Método de instância, só pode ser acessado instanciando o obejto
            public static int Somar(int a, int b)
            {
                return a + b;
            }
        }
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine("O resultado da multiplicação é: {0}", resultado);

            Console.WriteLine("O resultado da soma é: " + CalculadoraEstatica.Somar(2,2));
        }
    }
}
