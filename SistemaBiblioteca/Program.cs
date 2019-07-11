using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SistemaBibliotecaOnline
{
    class Program
    {
        static string[,] baseDeLivros;
        static void Main(string[] args)
        {
            CarregaBaseDeDados();
            MostrarSejaBemVindo();

            if (MenuPrincipal() == 1)
            {
                MostrarMenuLocacao();
            }
            Console.ReadKey();
        }

        #region Metodos
        /// <summary>
        /// metodo que mostra a parte inicial da aplicação 
        /// </summary>
        public static void MostrarSejaBemVindo()
        {
            Console.WriteLine("|_________________________________________________________________|");
            Console.WriteLine("|           Seja bem vindo ao sistema de locação de livros        |");
            Console.WriteLine("|_________________________________________________________________|");
            Console.WriteLine("|                           Sistemas LOL                          |");
            Console.WriteLine("|_________________________________________________________________|");

        }

        /// <summary>
        /// metodo mostra o conteudo do menu e as opções de escolha
        /// </summary>
        /// <returns>retorna o valor do menu escolhido em um tipo inteiro</returns>
        public static int MenuPrincipal()
        {
            

            Console.WriteLine("O que gostaria de realizar?");
            Console.WriteLine("1 - Locar livro");
            Console.WriteLine("2 - Sair do Sistema");
            Console.WriteLine("Digite numero escolhido");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);
            //var opcao = Console.ReadKey().KeyChar.ToString();//to string busca informação textual e nao de memoria
            return opcao;

        }

        /// <summary>
        /// Metodo que carrega a base de dados dentro do sistema
        /// </summary>
        public static void CarregaBaseDeDados()
        {
            baseDeLivros = new string[2, 2]
            {
                { "o pequeno", "sim" },
                { "o grande", "não" }
            };
        }

        /// <summary>
        /// metodo que retorna se um livro pode ser locado
        /// </summary>
        /// <param name="nomeLivro"> nome do livro a ser pesquisado</param>
        /// <returns>retorna verdadeiro em caso do livro estiver disponivel</returns>
        public static bool PesquisaLivroLocacao(string nomeLivro)
        {
            MostrarSejaBemVindo();

            nomeLivro = nomeLivro.ToLower().Trim();

            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (nomeLivro == baseDeLivros[i, 0])
                {
                    Console.WriteLine($"O livro: '{nomeLivro}' pode ser locado?:{ baseDeLivros[i, 1]}");
                    return baseDeLivros[i, 1] == "sim";

                }

            }
            return false;
        }

        /// <summary>
        /// Metodo que aluga o livro de acordo com o parametro passado
        /// </summary>
        /// <param name="nomeLivro">Nome do livro a ser aluga</param>
        public static void LocarLivro(string nomeLivro)
        {
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (nomeLivro == baseDeLivros[i, 0])
                    baseDeLivros[i, 1] = "não";
            }
        }

        /// <summary>
        /// Metodo que carrrega o conteudo inicial da aplicação
        /// </summary>
        public static void MostrarMenuLocacao()
        {
            Console.Clear();
            MostrarSejaBemVindo();
            Console.WriteLine("Menu - Locação livro");
            Console.WriteLine("Digite o nome do livro a ser locado");

            var nomeLivro = Console.ReadLine();

            if (PesquisaLivroLocacao(nomeLivro))
            {
                Console.Clear();
                Console.WriteLine("Voce deseja locar o livro? para sim(1) para não(0)");
                if (Console.ReadKey().KeyChar.ToString() == "1")
                {
                    LocarLivro(nomeLivro);
                    Console.Clear();
                    Console.WriteLine("Livro locado com sucesso!");
                }
                else
                    Console.Clear();

                Console.WriteLine("Listagem de livros");
                for (int i = 0; i < baseDeLivros.GetLength(0); i++)
                {
                    Console.WriteLine($"Livros: {baseDeLivros[i, 0]} Disponivel: {baseDeLivros[i, 1]}");
                }
                Console.WriteLine("Obrigado");
            }
        }
        #endregion
                
    }
    /*apresentacao inicial, menu de escolha, summary's, base de dados*/
}
