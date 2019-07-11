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

            var opcaoMenu = MenuPrincipal();

            while (opcaoMenu != 3)
            {
                if (MenuPrincipal() == 1)
                {
                    MostrarMenuLocacao();
                }

                opcaoMenu = MenuPrincipal();
            }
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
            Console.Clear();

            MostrarSejaBemVindo();

            Console.WriteLine("O que gostaria de realizar?");
            Console.WriteLine("1 - Locar livro");
            Console.WriteLine("2 - Devolver um Livro");
            Console.WriteLine("3 - Sair do Sistema");
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
        /// Metodo para alterar a informação de locação do livro
        /// </summary>
        /// <param name="nomeLivro">Nome do livro</param>
        /// <param name="locar">Valor booleano que define se o livro esta ou nao disponivel</param>
        public static void LocarLivro(string nomeLivro, bool locar)
        {
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (nomeLivro == baseDeLivros[i, 0])
                {
                    baseDeLivros[i, 1] = locar ? "não" : "sim";
                }
            }
            Console.Clear();
            Console.WriteLine("Livro atualizado com sucesso!");
        }

        /// <summary>
        /// Metodo que carrrega o conteudo inicial da aplicação
        /// </summary>
        public static void MostrarMenuLocacao()
        {

            MostrarMenuIncialLivros("Locar livro");
            var nomeLivro = Console.ReadLine();

            if (PesquisaLivroLocacao(nomeLivro))
            {
                Console.Clear();
                Console.WriteLine("Voce deseja locar o livro? para sim(1) para não(0)");

                LocarLivro(nomeLivro, Console.ReadKey().KeyChar.ToString() == "1");

                MostrarListaDeLivros();

                Console.WriteLine("Obrigado");
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Metodo que mostra a lista de livros atualizada
        /// </summary>
        public static void MostrarListaDeLivros()
        {
            Console.WriteLine("Listagem de livros");
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                Console.WriteLine($"Livros: {baseDeLivros[i, 0]} Disponivel: {baseDeLivros[i, 1]}");
            }

        }

        public static void DesalugarLivro()
        {
            MostrarMenuIncialLivros("Desalocar um livro");
            MostrarListaDeLivros();

            var nomeLivro = Console.ReadLine();

            if (!PesquisaLivroLocacao(nomeLivro))
            {
                Console.Clear();
                MostrarSejaBemVindo();
                Console.WriteLine("Voce deseja devolver o livro? para sim(1) para não(0)");

                LocarLivro(nomeLivro, Console.ReadKey().KeyChar.ToString() == "1");

                MostrarListaDeLivros();

                Console.WriteLine("Obrigado");
                Console.ReadKey();
            }
        }
        public static void MostrarMenuIncialLivros(string operacao)
        {
            Console.Clear();
            MostrarSejaBemVindo();

            Console.WriteLine($"Menu - {operacao}");
            Console.WriteLine("Digite o nome do livro a ser locado");
        }
        #endregion

    }
    /*apresentacao inicial, menu de escolha, summary's, base de dados*/
}
