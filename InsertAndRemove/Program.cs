using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertAndRemove
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] baseDeDados = new string[2, 3];

            int indiceBaseDados = 0;

            //apresentação inicial do sis
            Console.WriteLine("Iniciando sistema de lista de Nome e idade");


            //Criamos a variavel forapara não ser criada novamente
            var escolhaInicial = ApresentaMenuInicial();

            while (true)
            {
                switch (escolhaInicial)
                {
                    case "1":
                        { InserirValoresNaLista(ref baseDeDados, ref indiceBaseDados); }
                        break;
                    case "2":
                        { RemoverInformacoes(ref baseDeDados); }
                        break;

                    case "3":
                        { MostrarInformaçoes(ref baseDeDados); }
                        break;
                    case "4":
                        //retorna dentro do caso de escolha, sair do metodo principal ou metodo dentro do contexto
                        {
                            return;
                        }
                }
                escolhaInicial = ApresentaMenuInicial();
            }
        }

        /// <summary>
        /// apresenta as informações do menu inicial
        /// </summary>
        /// <returns></returns>
        public static string ApresentaMenuInicial()
        {
            //entra o menu inicial limpo
            Console.Clear();
            Console.WriteLine("Menu");
            Console.WriteLine("1 - Inserir um novo registro");
            Console.WriteLine("2 - Remover um novo registro");
            Console.WriteLine("3 - Listar registros");
            Console.WriteLine("4 - Sair do sistema");

            Console.WriteLine("Digite o numero da opcao desejada");

            return Console.ReadLine();

        }

        /// <summary>
        /// metodo que insere informaççoes dentro do banco de daods
        /// </summary>
        /// <param name="pBaseDeDados"></param>
        /// <param name="pIndiceBaseDeDados"></param>
        public static void InserirValoresNaLista(ref string[,] pBaseDeDados, ref int pIndiceBaseDeDados)
        {
            Console.WriteLine("Inserindo valores na lista");

            Console.WriteLine("Informe nome");
            var nome = Console.ReadLine();

            Console.WriteLine("Informe idade");
            var idade = Console.ReadLine();

            for (int i = 0; i < pBaseDeDados.GetLength(0); i++)
            {
                if (pBaseDeDados[i, 0] != null)
                    continue;

                //incrementa antes de converter para string
                pBaseDeDados[i, 0] = (pIndiceBaseDeDados++).ToString();
                //carregar na segunda coluna valor nome
                pBaseDeDados[i, 1] = nome;
                //carregar na segunda coluna valor idade
                pBaseDeDados[i, 2] = idade;
                //finalizado aqui para inserir apenas um registro por vez
                break;
            }
            Console.WriteLine("Registro cadastrado com sucesso");
            Console.WriteLine("para voltar ao menu incial, pressione qualquer tecla");
            Console.ReadKey();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pBaseDeDados">base de dados para leitura e mostrar para o usuario</param>
        public static void MostrarInformaçoes(ref string[,] pBaseDeDados)
        {
            //informar que tela esta
            Console.WriteLine("apresenta informações dentro da base de dados");

            //laço que mostra de maneira formatada as infos
            for (int i = 0; i < pBaseDeDados.GetLength(0); i++)
            {


                Console.WriteLine($"ID {pBaseDeDados[i, 0]} " +
                    $"- Nome:{pBaseDeDados[i, 1]} " +
                    $"- Idade:{pBaseDeDados[i, 2]}");
            }
            Console.WriteLine("Registro cadastrado com sucesso");
            Console.WriteLine("para voltar ao menu incial, pressione qualquer tecla");
            Console.ReadKey();
        }
        /// <summary>
        /// metodo utilizado para remover um registro pelo id
        /// </summary>
        /// <param name="pBaseDeDados">base de dados em que sera removido</param>
        public static void RemoverInformacoes(ref string[,] pBaseDeDados)
        {
            Console.WriteLine("Remover Registro");

            for (int i = 0; i < pBaseDeDados.GetLength(0); i++)
            {
                //laço de repetição que mostra infos dentro da tela de exclusao
                Console.WriteLine($"ID {pBaseDeDados[i, 0]} " +
                 $"- Nome:{pBaseDeDados[i, 1]} " +
                 $"- Idade:{pBaseDeDados[i, 2]} ");
            }

            Console.WriteLine("Informe o ID do registro a ser removido");
            var id = Console.ReadLine();

            for (int i = 0; i < pBaseDeDados.GetLength(0); i++)
            {

                //laço para remover dados caso id exista
                if (pBaseDeDados[i, 0] == id && pBaseDeDados[i, 0] != null)
                {/*aqui comparamos os registros para validar o id,
                    colocamos && pois a comparação de um valor string com um valor null
                    pode gerar exception*/
                    pBaseDeDados[i, 0] = null;
                    pBaseDeDados[i, 1] = null;
                    pBaseDeDados[i, 2] = null;
                }
            }

            Console.WriteLine("Operação finalizada");
            Console.WriteLine("para voltar ao menu incial, pressione qualquer tecla");
            Console.ReadKey();

        }
    }
}
