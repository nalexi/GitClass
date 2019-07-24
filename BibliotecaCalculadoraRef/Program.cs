using BibliotecaCalculadora.Funcoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCalculadoraRef
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaFuncoes funcoes = new ListaFuncoes();
            //Console.WriteLine("digite os valores desejados");
            //
            //Console.WriteLine(funcoes.Adicao(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            Console.WriteLine(funcoes.Adicao(2, 2));
            Console.WriteLine(funcoes.Subtracao(2, 2));
            Console.WriteLine(funcoes.Multiplicacao(2, 2));
            Console.WriteLine(funcoes.Divisao(2, 2));

            Console.ReadKey();
         

        }
    }
}
