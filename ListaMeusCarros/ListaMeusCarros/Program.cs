using ListaMeusCarros.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaMeusCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Carro> meusCarros = new List<Carro>();


            while (true)
            {
                switch (MostrarMenu())
                {
                    case 1:
                        Console.Clear();

                        Console.WriteLine("Adicione um veiculo");

                        meusCarros.Add(new Carro()
                        {
                            Modelo = RetornarValores("Modelo"),
                            Ano = RetornarValores("Ano"),
                            Placa = RetornarValores("placa"),
                            PulsoesPulgmaticos = Convert.ToInt32(RetornarValores("Pulsoes Pugmaticos"))
                        });
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Lista de carros");
                        foreach (Carro item in meusCarros)
                        {
                            Console.WriteLine($"Carro: {item.Modelo}, de ano: {item.Ano}, placa: {item.Modelo} e " +
                                $"{item.PulsoesPulgmaticos} pulsoes pugmaticos");
                        }

                        break;

                    case 3:

                        return;

                    default:
                        Console.WriteLine("Digite um valor valido");
                        break;
                }
            }
        }

        public static string RetornarValores(string valor)
        {
            Console.WriteLine($"Digite o valor para o campo {valor}");
            return Console.ReadLine();
        }

        public static int MostrarMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("Escolha opção");
            Console.WriteLine("1 - Adicionar Veiculos");
            Console.WriteLine("2 - Listar veículos");
            Console.WriteLine("3 - sair");

            var opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;
        }
    }
}
