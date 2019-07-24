using BibliotecaDeArquivosDoWindows;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraBibliotecaExterna
{
    class Program
    {
        static void Main(string[] args)
        {
            var files = new GetFiles();
            Console.WriteLine("Documents files");
            foreach (var item in files.RetornaArquivosDoMeuDocumentos())
            {
                Console.WriteLine(item);

            }
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("Image files");
            foreach (var item in files.RetornaArquivosImagesFiles())
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();


            Console.WriteLine("");
            Console.WriteLine("Git files");
            foreach (var item in files.RetornaArquivosGit())
                Console.WriteLine(item);

            Console.ReadKey();
        }
        
    }

}
