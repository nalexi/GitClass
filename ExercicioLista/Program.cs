using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLista
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] listaCarros = new string[3, 3];
            int IdControle = 0;

            InserirDados(ref listaCarros, ref IdControle);
            Console.ReadKey();
            InserirDados(ref listaCarros, ref IdControle);
            Console.ReadKey();

        }

        public static void InserirDados(ref string[,] listaCarros, ref int IdControle)
        {
            for (int i = 0; i < listaCarros.GetLength(0); i++)
            {
                if (listaCarros[i, 0] != null)
                    continue;

                listaCarros[i, 0] = (IdControle++).ToString();

                Console.WriteLine("\r\nDigite o nome do veiculo");
                listaCarros[i, 1] = Console.ReadLine();
                Console.WriteLine("\r\nDigite a Marca do veiculo");
                listaCarros[i, 2] = Console.ReadLine();

                Console.WriteLine("O que deseja realizar? 1-Inserir 2-apagar 3-sair");

                if (Console.ReadKey().KeyChar.ToString() == "2")
                    ExcluirItemLista(ref listaCarros);


                if (Console.ReadKey().KeyChar.ToString() == "3")
                {
                    Console.Clear();
                    Console.WriteLine("System out"); ;
                    Console.ReadKey();
                    break;
                }


                AumentaLista(ref listaCarros);
            }

            Console.WriteLine("\r\nRegistro atualiado com sucesso");
            for (int i = 0; i < listaCarros.GetLength(0); i++)
            {
                Console.WriteLine(string.Format("Carro com Id: {0}, nome: {1}, de marca: {2}", listaCarros[i, 0], listaCarros[i, 1], listaCarros[i, 2]));
            }


        }

        private static void ExcluirItemLista(ref string[,] listaCarros)
        {
            Console.WriteLine("Escolha um registro a ser apagado");
            var idEscolhido = Console.ReadLine();


            for (int i = 0; i < listaCarros.GetLength(0); i++)
            {
                if (idEscolhido == listaCarros[i, 0])
                {
                    listaCarros[i, 0] = null;
                    listaCarros[i, 1] = null;
                    listaCarros[i, 2] = null;
                    Console.WriteLine($"Carro com Id: {idEscolhido}, foi excluido com sucesso") ;
                    Console.WriteLine("Pressione ENTER para Prosseguir") ;

                    break;
                }

            }
        }

        public static void AumentaLista(ref string[,] ListaCarros)
        {
            var limiteLista = true;

            for (int i = 0; i < ListaCarros.GetLength(0); i++)
            {
                if (ListaCarros[i, 0] == null)
                {
                    limiteLista = false;
                }
            }

            if (limiteLista)
            {
                var listaCopia = ListaCarros;

                ListaCarros = new string[ListaCarros.GetLength(0) + 5, 3];

                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    ListaCarros[i, 0] = listaCopia[i, 0];
                    ListaCarros[i, 1] = listaCopia[i, 1];
                    ListaCarros[i, 2] = listaCopia[i, 2];
                    Console.WriteLine(string.Format("Carro com Id: {0}, nome: {1}, de marca: {2}", ListaCarros[i, 0], ListaCarros[i, 1], ListaCarros[i, 2]));
                }
                Console.WriteLine("Lista Atualizada");
            }
        }

    }
}
