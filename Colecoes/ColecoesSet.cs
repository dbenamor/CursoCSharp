using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class ColecoesSet
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Throne", 49.9);
            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            //HashSet não é uma estrutura indexada e portando os elemntos de index deixam de funcionar
            var combo = new HashSet<Produto>
            {
                new Produto("Camisa",29.9),
                new Produto("8ª temporada GoT",99.9),
                new Produto("Poster",10),
                new Produto("Poster",10)
            };

            //carrinho.AddRange(combo);
            carrinho.UnionWith(combo);

            Console.WriteLine(carrinho.Count);
            //carrinho.RemoveAt(3);

            foreach (var item in carrinho)
            {
                //Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" - {item.Nome} por R${item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);
            //Console.WriteLine(carrinho.LastIndexOf(livro));
        }
    }
}
