using MinhaPrimeiraListaTipada.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraListaTipada
{
    class Program
    {
        static void Main(string[] args)
        {
            //indicador <T> o tipo da lista, coleção de lanches
            List<Lanche> minhaLista = new List<Lanche>();
            minhaLista.Add(new Lanche()
            {
                Nome = "Pão de Queijo",
                Quantidade = 4,
                Valor = 1.85
            });

            minhaLista.Add(new Lanche()
            {
                Nome = "Bolinho Soya",
                Quantidade = 2,
                Valor = 5
            });

            Console.WriteLine("quantos objetos deseja cadastrar?");
            var quantidade = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < quantidade; i++)
            {
            Console.WriteLine("informe o nome, a quantidade e o Valor");
            minhaLista.Add(new Lanche() {

                Nome = Console.ReadLine(),
                Quantidade = Convert.ToInt32(Console.ReadLine()),
                Valor = Convert.ToDouble(Console.ReadLine())

            });
            }

            //apresenta valores da lista 
            foreach (Lanche item in minhaLista)
                Console.WriteLine($"Lanches disponiveis: {item.Nome}");

            minhaLista.Remove(minhaLista.FirstOrDefault(x => x.Quantidade == 2));

            var meuItem = (from item in minhaLista
                           where item.Quantidade == 3
                           select item).ToList<Lanche>();

            Console.WriteLine("Digite uma quantidade para apagar do mapa");
            var apagar = Convert.ToInt32(Console.ReadLine());
            foreach (Lanche item in minhaLista)
            {
                if (item.Quantidade == apagar)
                {
                    minhaLista.Remove(item);
                    break;
                }
            }

            foreach (Lanche item in minhaLista)
                Console.WriteLine($"Lanches disponiveis: {item.Nome}");

            Console.ReadKey();
        }
    }
}
