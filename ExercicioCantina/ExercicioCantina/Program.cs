using ExercicioCantina.Cantina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCantina
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodos metodo = new Metodos();
            while (metodo.Troco() > 0)
            {

                foreach (var item in metodo.Lanches)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("digite o item desejado");
                if (metodo.ComprarRisoles(Console.ReadLine()))
                {
                    Console.WriteLine("Compra efetuada com sucesso!");
                    Console.WriteLine($"{metodo.Nome}, seu saldo atual" +
                    $" é de {metodo.Troco()}");
                }
                else
                    Console.WriteLine("Dinheiro insuficiente");

            }
            Console.ReadKey();
        }
    }
}
