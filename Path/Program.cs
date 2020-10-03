using System;
using System.IO;

namespace _Path
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * PATH:
             - Realiza operações com strings que contém informações de arquivos ou pasta
             */

            string path = @"C:\ProgramasCSharp\ConceitoDePath\Path\file1.txt";

            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar); // .DirectorySeparatorChar é uma operação(Método) que utiliza um caracter para a separação. Nesse caso é a baara invertida "\" pois no sistema windows é essa barra invertida
            Console.WriteLine("PathSeparator: " + Path.PathSeparator); //.PathSeparator é uma operação(Método) que mostra qual o caracter utilizado para separar entre path diferentes. 
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path)); // .GETDirectoryName é uma operação(Método) que pega apenas o caminho da pasta que contém o arquivo sem incluir seu nome junto
            Console.WriteLine("GetFileName: " + Path.GetFileName(path)); //.GetFileName é uma função´para pegar o nome do arquivo.
            Console.WriteLine("GetExtension: " + Path.GetExtension(path)); // .GetExtension é uma função que pega apenas a extenção do arquivo
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path)); // .GetFileNameWithoutExtension é uma funçao que ´pega apenas o nome do arquivo sem sua extenção
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path)); // .GetFullPath pega todo o caminho do arquivo junto com o nome do arquivo e sua extenção.
            Console.WriteLine("GetTempPath: " + Path.GetTempPath()); // .GetFullPath é uma função que mostra o caminho da pasta que guarda temporariamento dados.

        }
    }
}
