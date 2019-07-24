using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiManeiraSimplesComClass.Carrega
{
    class CarregarLista
    {
        string[,] listaDeNome;

        /// <summary>
        /// Retorna a Lista de Nomes apenas como leitura 
        /// </summary>
        public string[,] ListaNome { get { return listaDeNome; } }

        /// <summary>
        /// Nosso metodo contrutor que sempre recebe o nome da classe
        /// </summary>
        /// <param name="arrayBi">Array que ja deve estar assinado</param>
        public CarregarLista()
        {
            //Assinamos a lista AQUI e deixamos pronto para os demais metodos
            //sem passar paramentro
           listaDeNome = new string[5, 2];
        }

        /// <summary>
        /// metodo que carrega as infos dentro da nossa lista criada no metodo MAIN
        /// e mostra em seguda
        /// </summary>
        /// <param name="listaDeNome">Nossa lista a ser carregadaa</param>
        public void CarregaInformacoesEListaElasEmTela()
        {
            //usando um laço simples para colocar valores mas no mesmo, agora utilizando o GetLenght
            //como parametro "0" para indicar que queremos o tamanho da primeira coluna 
            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {

                listaDeNome[i, 0] = i.ToString();//carregando o que podemos chamar de ID, indentificar do nosso registro unico

                listaDeNome[i, 1] = $"Nicholas_{i}";//add info extra

            }

            //GetLength é um metodo e usamos "(parametro)" com o parametro
            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {
                Console.WriteLine($"ID:{ listaDeNome[i, 0]} - Nome:{listaDeNome[i, 1]}");
            }

        }
    }
}
