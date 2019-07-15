using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddValoresEmListaManualmente
{
    class Program
    {
        static void Main(string[] args)
        {
            //criação lista
            string[,] listaDeNome = new string[2, 2];
            //forma externa de identificar registros
            int idParaLista = 0;
            //aqui aciona novamente os registros
            InserirRegistro(ref listaDeNome, ref idParaLista);

            Console.ReadKey();

            Console.ReadKey();

        }

        /// <summary>
        /// MEtodo que insere novo registro
        /// </summary>
        /// <param name="listaDeNome">lista de nomes vazia</param>
        /// <param name="idParaLista">referencia externa de id</param>
        public static void InserirRegistro(ref string[,] listaDeNome, ref int idParaLista)
        {

            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {
                //
                if (listaDeNome[i, 0] != null)
                    continue;

                //indicamos que ele deve apenas informar o proximo registro
                Console.WriteLine("informa um nome para adicionar um registro");
                var nome = Console.ReadLine();

                /*criamos o identificador unico com um objetivo externo que mesmo
                 apos sairmos do laço ainda pode ser incremementado*/
                listaDeNome[i, 0] = (idParaLista++).ToString();
                //insere nome na lista
                listaDeNome[i, 1] = nome;

                //Identificamos se o mesmo ainda deseja inserir registros na lista
                Console.WriteLine("Deseja inserir um novo registro? sim(1) nao(0)");
                /*o readkey so espera uma unica tecla e nos retorna a tecla que foi acionada e nao seu valor, 
                 por isso usamos o keychar para pegar esse valor e converter em string*/
                var continuar = Console.ReadKey().KeyChar.ToString();
                if (continuar == "0")
                    break;//é uma palavra reservada do c# que para todo laço de repetiçao ou sequenciador logico


                AumentaTamanhoDaLista(ref listaDeNome);
            }
            Console.WriteLine("\r\nRegistro add com sucesso, segue lista");
            for (int i = 0; i < listaDeNome.GetLength(0); i++)
                /*Utilizamos o string format, faz o mesmo que $, porem este aceita grandes quantidades*/
                Console.WriteLine(string.Format("Registro ID {0} - Nome:{1}", listaDeNome[i, 0], listaDeNome[i, 1]));


        }
        public static void AumentaTamanhoDaLista(ref string[,] ListaDeNome)
        {
            //verifica se precisa criar uma lista maior
            var limiteDaLista = true;

            //laço verifica se existe registro disponivel
            for (int i = 0; i < ListaDeNome.GetLength(0); i++)
            {
                //caso ainda existir registro disponivel ele seta variavel "limiteDaLista" para false
                if (ListaDeNome[i,0] == null)
                {
                    limiteDaLista = false;
                }
            }
            //caso nao tenha mais regsitro, a variavel fica como true e entao indica que precisamos aumentar
            if (limiteDaLista)
            {
                //criamos uma copia da lista para nao perder valores
                var listaCopia = ListaDeNome;

                //aqui limpamos a lista antiga e assinamos novamente com mais espaço
                ListaDeNome = new string[ListaDeNome.GetLength(0) + 5, 2];

                //agora copiamos os registros da lista antiga e passamos para nova lista
                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    ListaDeNome[i, 0] = listaCopia[i, 0];
                    ListaDeNome[i, 1] = listaCopia[i, 1];
                }
                Console.WriteLine("Tamanho da lista atualizado com sucesso");
            }
        }
    }
}
