using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class ColecoesDictionary
    {
        public static void Executar()
        {
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem-Aranha");
            filmes.Add(2004, "Os Incríveis");
            filmes.Add(2006, "O Grande Truque");

            if (filmes.ContainsKey(2004))
            {
                Console.WriteLine("2004: " + filmes[2004]);
                //Console.WriteLine("2004: " + filmes.GetValueOrDefault(2004));
            }

            Console.WriteLine(filmes.ContainsValue("Amnésia"));
            Console.WriteLine($"Removeu? {filmes.Remove(2004)}");

            filmes.TryGetValue(2006, out string filme2006);
            Console.WriteLine($"{filme2006}!");

            //Pecorrer todo o dictionary
            //Pecorrer atraves das chaves [int]
            foreach (var chave in filmes.Keys)
            {
                Console.WriteLine(chave);
            }
            //Pecorrer atraves das strings
            foreach (var valor in filmes.Values)
            {
                Console.WriteLine(valor);
            }
            //Pecorrer atraves das chaves e strings
            foreach (KeyValuePair<int, string> filme in filmes)
            {
                Console.WriteLine($"{filme.Value} é de {filme.Key}.");
            }

            //Deixar o próprio compilador fazer essa varredura
            foreach (var filme in filmes)
            {
                Console.WriteLine($"{filme.Value} é de {filme.Key}.");
            }
        }
    }
}
