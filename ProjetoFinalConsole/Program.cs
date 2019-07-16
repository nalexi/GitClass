using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] baseLivros = new string[2, 5];
            int indiceLivros = 0;


            var escolhaIncial = MostraMenuInicial();

            while (true)
            {
                switch (escolhaIncial)
                {
                    case "1":
                    //vai para metodo inserir
                        { InserirNovoLivro(ref baseLivros, ref indiceLivros); }
                        break;

                    case "2":
                    //vai para metodo remover
                        { RemoverLivro(ref baseLivros); }
                        break;

                    case "3":
                    //vai para metodo listar Ativos
                        { MostrarListaLivros(ref baseLivros); }
                        break;

                    case "4":
                    //vai para metodo listar Inativos
                        { MostrarListaLivros(ref baseLivros, "true"); }
                        break;

                    case "5":
                        //Encerra aplicação
                        return;

                    default:
                        Console.WriteLine("Numero inválido, pressione qualquer tecla para volta ao menu");
                        Console.ReadKey();

                        break;
                }

                escolhaIncial = MostraMenuInicial();
            }
        }

        /// <summary>
        /// Mostra informações dentro da base de dados
        /// </summary>
        /// <param name="pBaseDeDados">base de dados para leitura e mostrar para o usuario</param>
        /// <param name="mostrarRegistroInativos">valor true mostra os valores que nao estao ativos</param>
        public static void MostrarListaLivros(ref string[,] pBaseLivros, string registroInativo = "false")
        {
            Console.Clear();
            Console.WriteLine("==========================================================");
            Console.WriteLine("                Lista de livros Cadastrados               ");
            Console.WriteLine("==========================================================");

            if (registroInativo == "true")
                Console.WriteLine("Lista de livros desativados");
            else
                Console.WriteLine("Lista de Livros cadastrados");


            for (int i = 0; i < pBaseLivros.GetLength(0); i++)
            {
                if (pBaseLivros[i, 4] != registroInativo)
                {
                    Console.WriteLine($"ID: {pBaseLivros[i, 0]} " +
                            $"- Livro: {pBaseLivros[i, 1]} " +
                            $"- Autor: {pBaseLivros[i, 2]}" +
                            $"- Data alteração: {pBaseLivros[i, 3]}");
                }
            }

            Console.WriteLine("Para voltar ao menu incial, pressione qualquer tecla");
            Console.ReadKey();
        }

        /// <summary>
        /// metodo utilizado para remover um livro pelo id
        /// </summary>
        /// <param name="pBaseDeDados">base de dados em que sera removido</param>
        private static void RemoverLivro(ref string[,] pBaseLivros)
        {
            Console.Clear();
            Console.WriteLine("==========================================================");
            Console.WriteLine("                Remover livro da Biblioteca               ");
            Console.WriteLine("==========================================================");
            Console.WriteLine("Lista de Livros cadastrados");

            for (int i = 0; i < pBaseLivros.GetLength(0); i++)
            {
                if (pBaseLivros[i, 4] == "true")
                {
                    Console.WriteLine($"ID: {pBaseLivros[i, 0]} " +
                            $"- Livro: {pBaseLivros[i, 1]} " +
                            $"- Autor: {pBaseLivros[i, 2]}" +
                            $"- Data alteração: {pBaseLivros[i, 3]}");
                }
            }

            Console.WriteLine("Escolha um ID a ser Removido");
            var escolhaId = Console.ReadLine();

            //varre banco, encontra ID desejado e altera estado para ativo = false
           
            for (int i = 0; i < pBaseLivros.GetLength(0); i++)
            {
                if (pBaseLivros[i, 0] == escolhaId && pBaseLivros[i, 0] != null)
                {
                    pBaseLivros[i, 3] = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
                    pBaseLivros[i, 4] = "false";
                    Console.WriteLine("Livro Removido");
                    break;
                }
               
            }
            Console.WriteLine("Processo finalizado");
            Console.WriteLine("Para voltar ao menu incial, pressione qualquer tecla");
            Console.ReadKey();
        }

        /// <summary>
        /// Metodo que insere Livro na base de dados
        /// </summary>
        /// <param name="pBaseLivros">base de dados que será inserido livro</param>
        /// <param name="pIndiceLivros"></param>
        public static void InserirNovoLivro(ref string[,] pBaseLivros, ref int pIndiceLivros)
        {
            Console.Clear();
            Console.WriteLine("==========================================================");
            Console.WriteLine("             Inserir um novo livro na Biblioteca          ");
            Console.WriteLine("==========================================================");
            AumentaTamanhoDaLista(ref pBaseLivros);

            Console.WriteLine("Digite o nome do Livro a ser Inserido");
            var nomeLivro = Console.ReadLine();
            Console.WriteLine("Digite o nome do Autor do novo Livro");
            var nomeAutor = Console.ReadLine();

            //varre banco, adiciona id sequencial, nome livro, nome autor, data atual, e atualiza o estado ativo = "true"
            for (int i = 0; i < pBaseLivros.GetLength(0); i++)
            {
                if (pBaseLivros[i, 0] != null)
                    continue;

                pBaseLivros[i, 0] = (pIndiceLivros++).ToString();
                pBaseLivros[i, 1] = nomeLivro;
                pBaseLivros[i, 2] = nomeAutor;
                pBaseLivros[i, 3] = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
                pBaseLivros[i, 4] = "true";
                break;
            }
            Console.WriteLine("Livro cadastrado com sucesso");
            Console.WriteLine("Para voltar ao menu incial, pressione qualquer tecla");
            Console.ReadKey();
        }

        /// <summary>
        /// Metodo mostra menu principal de escolhas
        /// </summary>
        /// <returns>retorna valor escolhido</returns>
        public static string MostraMenuInicial()
        {
            Console.Clear();
            Console.WriteLine("==========================================================");
            Console.WriteLine("                   SISTEMA DE BIBLIOTECA                  ");
            Console.WriteLine("==========================================================");
            Console.WriteLine("Menu");
            Console.WriteLine("1 - Inserir novo Livro.");
            Console.WriteLine("2 - Remover um livro.");
            Console.WriteLine("3 - Listar livros.");
            Console.WriteLine("4 - Listar livros desativados.");
            Console.WriteLine("5 - Sair do sistema.");

            Console.WriteLine("Digite o numero da opção desejada");

            return Console.ReadLine();

        }

        /// <summary>
        /// Metodo que Aumenta o tamanho da lista de livros caso necessário
        /// </summary>
        /// <param name="pBaseLivros">base de dados que será aumentado tamanho</param>
        public static void AumentaTamanhoDaLista(ref string[,] pBaseLivros)
        {
            var limiteDaLista = true;

            for (int i = 0; i < pBaseLivros.GetLength(0); i++)
            {
                if (pBaseLivros[i, 0] == null)
                {
                    limiteDaLista = false;
                }
            }

            //verifica limite alcançado
            if (limiteDaLista)
            {
                var listaCopia = pBaseLivros;
                //aumenta lista
                pBaseLivros = new string[pBaseLivros.GetLength(0) + 5, pBaseLivros.GetLength(1)];

                //copia lista
                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    pBaseLivros[i, 0] = listaCopia[i, 0];
                    pBaseLivros[i, 1] = listaCopia[i, 1];
                    pBaseLivros[i, 2] = listaCopia[i, 2];
                    pBaseLivros[i, 3] = listaCopia[i, 3];
                    pBaseLivros[i, 4] = listaCopia[i, 4];
                }
                Console.WriteLine("Tamanho da lista atualizado com sucesso");
            }
        }
    }
}
