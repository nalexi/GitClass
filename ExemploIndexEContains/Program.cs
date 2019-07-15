using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploIndexEContains
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("primeiro valor");
            string primeiro = Console.ReadLine();
            Console.WriteLine("segundo valor");
            string segundo = Console.ReadLine();

            if (primeiro == segundo)
            {
                Console.WriteLine("primeiro igual ao segundo");
            }
            if (segundo.Contains(primeiro))
            {
                Console.WriteLine("verifica se contem info dentro do segundo");
            }
            if (segundo.IndexOf(primeiro) > -1)// indexOf retorna int
            {
                Console.WriteLine($"o primeiro existe no segundo na posição: {segundo.IndexOf(primeiro)}");
            }

            Console.WriteLine("Expressao a ser encontrada");
            string expressao = Console.ReadLine();
            for (int i = 0; i < listaDeNomes.Length; i++)
            {
                if (listaDeNomes[i].Contains(expressao))
                {
                    
                }
            }
            var pos = texto.ToLower().indexOf("TEXTO OU PARAMETRO")
            string texto = texto.Substring(pos,2); //espera dois parametros: startIndex qie represemta a posição inicial da seleção 
            //e length representa o tamanho da minha posição
        }
    }
}
