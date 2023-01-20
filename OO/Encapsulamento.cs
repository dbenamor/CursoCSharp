using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsulamento;


namespace CursoCSharp.OO
{
    public class FilhoNaoReconhecido : SubCelebridade
    {
        //Os itens comentados abaixo, são atributos que não são possiveis ser acessados nessa classe
        public new void MeusAcessos()
        {
            Console.WriteLine("\nFilhoNaoReconhecido...");

            Console.WriteLine(infoPublica);
            Console.WriteLine(CorDoOlho);
            //Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            //Console.WriteLine(SegredoFamilia);
            //Console.WriteLine(UsaMuitoPhotoshop);
        }
    }

    public class AmigoDistante
    {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos()
        {
            Console.WriteLine("\nAmigoDistante...");

            Console.WriteLine(amiga.infoPublica);
            //Console.WriteLine(amiga.CorDoOlho);
            //Console.WriteLine(amiga.NumeroCelular);
            //Console.WriteLine(amiga.JeitoDeFalar);
            //Console.WriteLine(amiga.SegredoFamilia);
            //Console.WriteLine(amiga.UsaMuitoPhotoshop);
        }
    }

    class Encapsulamento
    {
        public static void Executar()
        {
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            new FilhoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();

            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoDistante().MeusAcessos();
        }
    }
}
