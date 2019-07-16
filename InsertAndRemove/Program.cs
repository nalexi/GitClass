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
            string[,] baseDeDados = new string[2, 5];

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
                        { MostrarInformaçoes(ref baseDeDados, "true"); }
                        break;
                    case "5":
                        //retorna dentro do caso de escolha, sair do metodo principal ou metodo dentro do contexto
                        return;
                    default:
                        {
                            Console.WriteLine("Digite uma opção valida");
                            Console.ReadKey();
                        }
                        break;
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
            Console.WriteLine("4 - Lista as informações destivadas");
            Console.WriteLine("5 - Sair do sistema");

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
            AumentaTamanhoDaLista(ref pBaseDeDados);
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
                pBaseDeDados[i, 3] = "true";
                pBaseDeDados[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                //finalizado aqui para inserir apenas um registro por vez
                break;
            }
            Console.WriteLine("Registro cadastrado com sucesso");
            Console.WriteLine("para voltar ao menu incial, pressione qualquer tecla");
            Console.ReadKey();
        }

        /// <summary>
        /// Mostra informações dentro da base de dados
        /// </summary>
        /// <param name="pBaseDeDados">base de dados para leitura e mostrar para o usuario</param>
        /// <param name="mostrarRegistroInativos">quando identificamos o valor true, o mesmo mostra os valores que nao estao ativos</param>
        public static void MostrarInformaçoes(ref string[,] pBaseDeDados, string mostrarRegistroInativos = "false")
        {
            //informar que tela esta
            Console.WriteLine("apresenta informações dentro da base de dados");
            if (mostrarRegistroInativos == "false")
                Console.WriteLine("Registros desativados dentro do sistema");

            for (int i = 0; i < pBaseDeDados.GetLength(0); i++)
            {
                //aqui deixamos de mostrar as infos que foram desabilitadas no sis
                if (pBaseDeDados[i, 3] != mostrarRegistroInativos)
                {
                    Console.WriteLine($"ID {pBaseDeDados[i, 0]} " +
                        $"- Nome:{pBaseDeDados[i, 1]} " +
                        $"- Idade:{pBaseDeDados[i, 2]}" +
                        $"- Data alteração{pBaseDeDados[i, 4]}");
                }
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
                if (pBaseDeDados[i, 3] != "false")
                    Console.WriteLine($"ID {pBaseDeDados[i, 0]} " +
                     $"- Nome:{pBaseDeDados[i, 1]} " +
                     $"- Idade:{pBaseDeDados[i, 2]}" +
                     $"- Data alteração{pBaseDeDados[i, 4]}");
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
                    pBaseDeDados[i, 3] = "false";
                    pBaseDeDados[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                }
            }

            Console.WriteLine("Operação finalizada");
            Console.WriteLine("para voltar ao menu incial, pressione qualquer tecla");
            Console.ReadKey();

        }

        public static void AumentaTamanhoDaLista(ref string[,] pBaseDeDados)
        {
            //verifica se precisa criar uma lista maior
            var limiteDaLista = true;

            //laço verifica se existe registro disponivel
            for (int i = 0; i < pBaseDeDados.GetLength(0); i++)
            {
                //caso ainda existir registro disponivel ele seta variavel "limiteDaLista" para false
                if (pBaseDeDados[i, 0] == null)
                {
                    limiteDaLista = false;
                }
            }
            //caso nao tenha mais regsitro, a variavel fica como true e entao indica que precisamos aumentar
            if (limiteDaLista)
            {
                //criamos uma copia da lista para nao perder valores
                var listaCopia = pBaseDeDados;

                //aqui limpamos a lista antiga e assinamos novamente com mais espaço
                pBaseDeDados = new string[pBaseDeDados.GetLength(0) + 5, pBaseDeDados.GetLength(1)];

                //agora copiamos os registros da lista antiga e passamos para nova lista
                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    pBaseDeDados[i, 0] = listaCopia[i, 0];
                    pBaseDeDados[i, 1] = listaCopia[i, 1];
                    pBaseDeDados[i, 2] = listaCopia[i, 2];
                    pBaseDeDados[i, 3] = listaCopia[i, 3];
                    pBaseDeDados[i, 4] = listaCopia[i, 4];
                }
                Console.WriteLine("Tamanho da lista atualizado com sucesso");
            }
        }
    }
}
