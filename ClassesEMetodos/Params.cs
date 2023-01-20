using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Params
    {
        //String[] é um parametro array do tipo string chamado pessoas
        public static void Recepcionar(params string[] pessoas)
        {
            foreach(var pessoa in pessoas)
            {
                Console.WriteLine("Olá {0}", pessoa);
            }
        }
        public static void Executar()
        {
            Recepcionar("Pedro", "Manu", "Roger", "Ana", "Bia");
        }
    }
}
