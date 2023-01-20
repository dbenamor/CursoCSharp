using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CursoCSharp.API
{
    public static class ExtensaoString
    {
        public static string ParseHome(this string path)
        {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix ||
                Environment.OSVersion.Platform == PlatformID.MacOSX)
                ? Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");

            return path.Replace("~", home);
        }
    }

    class PrimeiroArquivo
    {        
        public static void Executar()
        {
            //O arroba serve para leitura correta do caminnho, para não interpretar o /, como sendo tabulação.
            //o ~ indica que caminho "começa" na pasta principal do sistema
            var path = @"~/primeiro_arquivo.txt".ParseHome();

            if (!File.Exists(path))
            {
                //Comando para criar o arquivo
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Esse é");
                    sw.WriteLine("o nosso");
                    sw.WriteLine("primeiro");
                    sw.WriteLine("arquivo!");
                }
            }
            //comando para alterar o arquivo existente
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("");
                sw.WriteLine("é possível");
                sw.WriteLine("adicionar");
                sw.WriteLine("mais texto!");
            }
        }
    }
}
