using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class SubCelebridade
    {
        //Todos
        public string infoPublica = "Tenho um instagram!";

        //Herança
        protected string CorDoOlho = "Verde";

        //Mesmo projeto (assemblry)
        internal ulong NumeroCelular = 5521999999999;

        //Herança ou mesmo projeto
        protected internal string JeitoDeFalar = "Uso muitas gírias";

        //Mesma class ou herança no mesmo projeto (dispnivível na versão C# >= 7.2)
        private protected string SegredoFamilia = "Blá blá";

        //private ou padrão
        bool UsaMuitoPhotoshop;

        public void MeusAcessos()
        {
            Console.WriteLine("SubCelebridade...");

            Console.WriteLine(infoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}
