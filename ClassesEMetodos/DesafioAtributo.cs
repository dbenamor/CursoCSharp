using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class DesafioAtributo
    {
        int a = 10; //Atributo de instância. Método dentro de classe não acessa esse tipo de atributo
        public static void Executar()
        {
            //Acessar variável 'a' dentro do metrodo executar!
            //Console.WriteLine($"{a}");
            //è necessário declarar uma instância para acessar o atributo
            DesafioAtributo desafio = new DesafioAtributo();
            Console.WriteLine(desafio.a);
        }
    }
}
