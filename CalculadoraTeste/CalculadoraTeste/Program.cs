using CalculadoraClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            MostraCalculadora funcao = new MostraCalculadora();

            Console.WriteLine(funcao.CalculaAdicao(2,2));
            Console.WriteLine(  funcao.CalculaSubtracao(2,2));
            Console.WriteLine(  funcao.CalculaMultiplicacao(2,2));
            Console.WriteLine(  funcao.CalculaDivisao(2,2));
            Console.WriteLine(  funcao.CalculoRetangulo(2,2));
            Console.WriteLine(  funcao.CalculoDeTrianguloEquilatero(2));
            Console.WriteLine(  funcao.CalculoAreaDeCirculo(2));

            Console.ReadKey();

        }
    }
}
