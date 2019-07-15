using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiDeManeiraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            //cria lista bi
            string[,] listaDeNome = new string[5, 2];

            CarregaInformacoesEListaElasEmTela(ref listaDeNome);

            //apos carregar as informações e mostrar em tela ele espera um comando
            Console.ReadKey();

            //Indicamos que o usuario precisa informar um numero de id 
            Console.WriteLine("Informe o ID do registro a ser pesquisado");
            /*aqui como realizamos a pesquisa somente na chamada
             passamos a nossa lista normalmente pois nao sera alterado somente pesquisa 
             apos a virgula temos o console read que espera o identificador unico*/
            PesquisandoInfoNaNossaLista(listaDeNome, Console.ReadLine());

            Console.ReadKey();
        }

        /// <summary>
        /// metodo que carrega as infos dentro da nossa lista criada no metodo MAIN
        /// e mostra em seguda
        /// </summary>
        /// <param name="arrayBi">Nossa lista a ser carregadaa</param>
        public static void CarregaInformacoesEListaElasEmTela(ref string[,] arrayBi)
        {
            //usando um laço simples para colocar valores mas no mesmo, agora utilizando o GetLenght
            //como parametro "0" para indicar que queremos o tamanho da primeira coluna 
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                
                arrayBi[i, 0] = i.ToString();//carregando o que podemos chamar de ID, indentificar do nosso registro unico

                arrayBi[i, 1] = $"Nicholas_{i}";//add info extra

            }

            //GetLength é um metodo e usamos "(parametro)" com o parametro
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                Console.WriteLine($"ID:{ arrayBi[i,0]} - Nome:{arrayBi[i,1]}");
            }

        }

        /// <summary>
        /// Metodo que realiza pesquisa pelo identificador unico de nossa coleção
        /// 
        /// </summary>
        /// <param name="arrayBi">Nossa coleção de info</param>
        /// <param name="pId">Nosso identificador unico</param>
        public static void PesquisandoInfoNaNossaLista(string[,] arrayBi ,string pId)
        {
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                //Realizamos nossa comparação dos mesmos tipos
                if (arrayBi[i,0] == pId)
                {//Mostramos info formatadas da nossa pesquisa
                    Console.WriteLine($"Informação escolhida: Id:{arrayBi[i,0]} - Nome:{arrayBi[i,1]}");
                    //aqui saimos da nossa lista mas retornamos vazio "return" pois estamos em um metodo
                    //vazio void que nao espera retornar

                    return;
                }
            }
            //caso nao encontre resultado esperado
            Console.WriteLine("Nao foram encontrados dados compativeis");
        }
    }
}
