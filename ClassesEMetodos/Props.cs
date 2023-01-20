using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class CarroOpcional
    {
        double desconto = 0.1;
        string nome;

        public string Nome
        {
            get { return "Opcional: " + nome; }
            set { nome = value; }
        }
        //Propiedade autoimplementada
        public double Preco { get; set; }
        //Propiedade somente leitura, não possui o SET
        public double PrecoComDesconto
        {
            get => Preco - (desconto * Preco); //Lambda
            //Outra forma de declarar o mesmo get
            //get { return Preco - (desconto * Preco); }
        }

        public CarroOpcional()
        {

        }

        public CarroOpcional(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }

    class Props
    {
        public static void Executar()
        {
            var op1 = new CarroOpcional("Ar condicionado", 3499.9);
            Console.WriteLine(op1.PrecoComDesconto);

            var op2 = new CarroOpcional();
            op2.Nome = "Direção elétrica";
            op2.Preco = 2349.9;
            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.Preco);

            Console.WriteLine(op2.Nome);
            Console.WriteLine(op2.Preco);
            Console.WriteLine(op2.PrecoComDesconto);            
        }
    }
}
