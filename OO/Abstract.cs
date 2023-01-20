using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    public abstract class Celular {
        public abstract string Assistente();
        public string Tocar() {
            return "Trim trim trim...";
        }
    }

    public class Samsung : Celular {
        public override string Assistente() {
            return "Olá!! Meu nome é Bixby";
        }
    }

    public class Iphone : Celular {
        public override string Assistente() {
            return "Olá!! Meu nome é Siri";
        }
    }

    class Abstract
    {        
        public static void Executar() {
            //vc não instância classe abstrata
            //Celular C = new Celular();
            var celulares = new List<Celular> { new Samsung(), new Iphone() };

            foreach (var celular in celulares) {

                Console.WriteLine(celular.Assistente());
            }
        }
    }
}
