using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3ListaAluno
{
    class Program
    {
        static string[,] listaAlunos;
        static void Main(string[] args)
        {
            CarregarDados();

            Console.WriteLine("LISTAR ALUNOS");
            for (int i = 0; i < listaAlunos.GetLength(0); i++)
            {
                for (int j = 0; j < listaAlunos.GetLength(1); j++)
                {
                    Console.Write($"{listaAlunos[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }



        public static void CarregarDados()
        {
            listaAlunos = new string[,]
            {
                {"Thor","21","Masculino" },
                {"Zeus","22","Masculino"},
                {"Floquinho","23","Feminino"},
                {"Luke","24","Masculino"},
                {"Apolo","12","Masculino"},
                {"Jimmy","22","Masculino"},
                {"Nick","54","Masculino"},
                {"Boris","34","Masculino"},
                {"Charlie","32","Masculino"},
                {"Theo","56","Masculino"},
                {"Tobby","43","Masculino"},
                {"Barth","56","Feminino"},
                {"Billy","87","Feminino"},
                {"Bud","12","Feminino"},
                {"Bono","21","Masculino"},
                {"Joaquim","54","Feminino"},
                {"Johnny","32","Masculino"},
                {"Bolt","73","Feminino"},
                {"Theodoro","34","Masculino"},
                { "Paco","54","Feminino"},

            };

        }
    }
}
