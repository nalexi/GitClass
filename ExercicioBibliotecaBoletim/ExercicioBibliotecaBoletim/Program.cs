using ExercicioBibliotecaBoletim.ListaFuncoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioBibliotecaBoletim
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcoes funcoes = new Funcoes();
            Console.WriteLine("BEM VINDO AO MUNDO DAS NOTAS");
            Console.WriteLine("Digite a primeira nota");
            int nota1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota");
            int nota2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota");
            int nota3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o total de aulas");
            int total = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o total de faltas");
            int faltas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($@"Aluno com frequencia de:{funcoes.CalcularFrequencia(total, faltas)}%
Aluno com media de {funcoes.CalcularMedia(nota1, nota2, nota3)}");

            funcoes.VerificarAprovado(funcoes.CalcularMedia(nota1, nota2, nota3), funcoes.CalcularFrequencia(total,faltas));

            Console.ReadKey();
        }
    }
}
