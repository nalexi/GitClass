using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SistemaAluguelCarro
{
    class Program
    {
        static string[,] bancoDeCarros;
        static void Main(string[] args)
        {
            CarregarBancoDeCarros();
            MostrarMenuPrincipal();
            Console.ReadKey();
        }
        #region metodos

        /// <summary>
        /// Metodo abre opções para seleção
        /// </summary>
        private static void MostrarMenuPrincipal()
        {
            switch (MenuInicialSistema())
            {
                case 1:
                    MenuModeloDesejado();
                    break;

                case 2:
                    PesquisarVeiculos();
                    break;

                case 3:
                    DevolverVeiculo();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Obrigado volte sempre");
                    break;
            }
        }

        /// <summary>
        /// metodo da baixa no banco da devolução do carro
        /// </summary>
        /// <param name="modeloVeiculo"></param>
        private static void DevolverVeiculo()
        {
            Console.Clear();
            MostrarSejaBemVindo();

            MostrarTodosDaLista();

            Console.WriteLine("");
            Console.WriteLine("Digite o modelo do veículo para devolver");
            var modeloVeiculo = Console.ReadLine();

            Console.WriteLine("");

            if (!PesquisarVeiculoDesejado(modeloVeiculo))
            {
                for (int i = 0; i < bancoDeCarros.GetLength(0); i++)
                {
                    if (modeloVeiculo == bancoDeCarros[i, 0])
                    {
                        MostrarSejaBemVindo();
                        bancoDeCarros[i, 2] = "sim";
                        Console.WriteLine("\r\ncarro devolvido com sucesso!");
                        MostrarVoltarInicio();
                    }
                }
            }
            else
            {
                MostrarSejaBemVindo();
                Console.WriteLine("Carro invalido, escolha novamente");
                Thread.Sleep(2000);
                DevolverVeiculo();
            }
        }

        /// <summary>
        /// Metodo mostra lista de veiculos por ano, modelo, disponibilidade ou todos
        /// </summary>
        private static void PesquisarVeiculos()
        {
            Console.Clear();
            Console.WriteLine("Selecione o numero a ser Pesquisado");
            Console.WriteLine("(1) Modelo, (2) Ano, (3) Disponibilidade, (4)Mostrar todos (5) Volta ao Menu Inicial");

            switch (int.Parse(Console.ReadKey().KeyChar.ToString()))
            {
                case 1:

                    for (int i = 0; i < bancoDeCarros.GetLength(0); i++)
                    {
                        Console.WriteLine($"\r\nModelo: {bancoDeCarros[i, 0]}");
                    }
                    MostrarVoltarInicio();
                    break;
                case 2:

                    for (int i = 0; i < bancoDeCarros.GetLength(0); i++)
                    {
                        Console.WriteLine($"\r\nAno {bancoDeCarros[i, 1]}");
                    }
                    MostrarVoltarInicio();
                    break;
                case 3:

                    for (int i = 0; i < bancoDeCarros.GetLength(0); i++)
                    {
                        Console.WriteLine($"\r\nModelo: {bancoDeCarros[i, 0]}, Esta disponivel para locação?:{bancoDeCarros[i, 2]} ");
                    }

                    MostrarVoltarInicio();
                    break;
                case 4:

                    MostrarTodosDaLista();

                    MostrarVoltarInicio();
                    break;
                default:
                    MostrarMenuPrincipal();

                    break;
            }
        }

        /// <summary>
        /// metodo retorna ao menu inicial
        /// </summary>
        private static void MostrarVoltarInicio()
        {
            Console.WriteLine("\r\nPressione qualquer tecla para voltar");
            Console.ReadKey();
            MostrarMenuPrincipal();
        }

        /// <summary>
        /// metodo mostra a disponibilidade do veiculo desejado
        /// </summary>
        private static void MenuModeloDesejado()
        {
            Console.Clear();
            MostrarSejaBemVindo();
            Console.WriteLine("Menu de locação de veiculos");

            Console.WriteLine("");
            MostrarTodosDaLista();
            Console.WriteLine("");

            Console.WriteLine("Digite o modelo do veículo desejado");
            var modeloVeiculo = Console.ReadLine();

            if (PesquisarVeiculoDesejado(modeloVeiculo))
            {
                Console.WriteLine("Deseja alugar o veiculo? sim - 1, nao - 2 ");
                Console.WriteLine("Digite a opcao desejada");
                if (Console.ReadKey().KeyChar.ToString() == "1")
                {
                    AlugarCarro(modeloVeiculo);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Obrigado volte sempre");
                }
            }
            MostrarVoltarInicio();
        }

        /// <summary>
        /// metodo da baixa no banco de aluguel do carro
        /// </summary>
        /// <param name="modeloVeiculo"></param>
        private static void AlugarCarro(string modeloVeiculo)
        {
            for (int i = 0; i < bancoDeCarros.GetLength(0); i++)
            {
                if (modeloVeiculo == bancoDeCarros[i, 0])
                {
                    bancoDeCarros[i, 2] = "não";
                    Console.WriteLine("\r\ncarro alugado com sucesso!");


                }
            }
        }


        public static bool PesquisarVeiculoDesejado(string modeloVeiculo)
        {
            modeloVeiculo = modeloVeiculo.ToLower().Trim();
            for (int i = 0; i < bancoDeCarros.GetLength(0); i++)
            {
                if (modeloVeiculo == bancoDeCarros[i, 0])
                {
                    Console.WriteLine($"Modelo: {modeloVeiculo}, de ano {bancoDeCarros[i, 1]}, Esta disponivel para locação?:{bancoDeCarros[i, 2]} ");
                    return bancoDeCarros[i, 2] == "sim";
                }
            }
            return false;
        }

        private static void CarregarBancoDeCarros()
        {
            bancoDeCarros = new string[2, 3]
            {
                { "honda", "2019", "sim" },
                { "ford", "2017", "não" },
            };
        }

        public static void MostrarSejaBemVindo()
        {
            Console.Clear();
            Console.WriteLine("============================================");
            Console.WriteLine("                CAR-ONLINE                  ");
            Console.WriteLine("============================================");

        }

        public static int MenuInicialSistema()
        {
            MostrarSejaBemVindo();
            Console.WriteLine("Escolha o numero abaixo para continuar");
            Console.WriteLine("1 - Alugar um carro");
            Console.WriteLine("2 - Pesquisar veiculos");
            Console.WriteLine("3 - Devolver Veiculo");
            Console.WriteLine("4 - Sair do sistema");
            Console.WriteLine("make your choice");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);
            return opcao;
        }

        /// <summary>
        /// Metodo mostra a lista de veiculos
        /// </summary>
        public static void MostrarTodosDaLista()
        {
            Console.WriteLine("Lista de Veiculos");
            for (int i = 0; i < bancoDeCarros.GetLength(0); i++)
            {
                Console.WriteLine($"Modelo: {bancoDeCarros[i, 0]}, de ano {bancoDeCarros[i, 1]}, Esta disponivel para locação?:{bancoDeCarros[i, 2]} ");
            }

        }

    }
    #endregion
}
