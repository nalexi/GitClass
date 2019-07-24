using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiManeiraSimplesComClass.Mostar
{
    class MostrarLista
    {
        /// <summary>
        /// Metodo que realiza pesquisa pelo identificador unico de nossa coleção
        /// 
        /// </summary>
        /// <param name="arrayBi">Nossa coleção de info</param>
        /// <param name="pId">Nosso identificador unico</param>
        public void PesquisandoInfoNaNossaLista(string[,] arrayBi, string pId)
        {
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                //Realizamos nossa comparação dos mesmos tipos
                if (arrayBi[i, 0] == pId)
                {//Mostramos info formatadas da nossa pesquisa
                    Console.WriteLine($"Informação escolhida: Id:{arrayBi[i, 0]} - Nome:{arrayBi[i, 1]}");
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
