using System;
using System.IO;

namespace CursoCSharp.API
{
    class Diretorios
    {
        public static void Executar()
        {
            var novoDir = @"~/PastaCSharp".ParseHome();
            var novoDirDestino = @"~/PastaCSharpDestino".ParseHome();
            var dirProjeto = @"~/source/repos/CursoCSharp/CursoCSharp".ParseHome();

            if (Directory.Exists(novoDir))
            {
                //O parêmetro TRUE é para excluir os diretórios para serem excluidos de forma recursiva
                Directory.Delete(novoDir, true);
            }

            if (Directory.Exists(novoDirDestino))
            {
                Directory.Delete(novoDirDestino, true);
            }

            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));

            Console.WriteLine("====PASTAS=====");
            var pastas = Directory.GetDirectories(dirProjeto);
            foreach(var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }

            Console.WriteLine("\n\n====ARQUIVOS====");
            var arquivos = Directory.GetFiles(dirProjeto);
            foreach(var arqvuivo in arquivos)
            {
                Console.WriteLine(arqvuivo);
            }

            Console.WriteLine("\n\n====RAIZ====");
            Console.WriteLine(Directory.GetDirectoryRoot(novoDir));

            Directory.Move(novoDir, novoDirDestino);
        }
    }
}
