using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiSuperCompacta.BibliotecaListaBi
{
    class ListaBi
    {
        string[,] listaBi;

        /// <summary>
        /// Inicia lista, quando inicia a instancia, lista ja vem carregada
        /// </summary>
        public ListaBi()
        {
            listaBi = new string[5, 2];

            CarregaListaBi();
        }

        /// <summary>
        /// Popula(insere) a lista quando chama o metodo
        /// </summary>
        public void CarregaListaBi()
        {
            for (int i = 0; i < listaBi.GetLength(0); i++)
            {
                listaBi[i, 0] = i.ToString();
                listaBi[i, 1] = $"Nico_{i}";
                Console.WriteLine($"Id:{i} Nome:Nico_{i}");
            }
        }

        /// <summary>
        /// MEtodo que realiza a pesquisa de informações na lista
        /// </summary>
        /// <param name="idPesquisa">ID da nossa informação</param>
        public void PesquisaLista(string idPesquisa)
        {
            for (int i = 0; i < listaBi.GetLength(0); i++)
            {
                if  (listaBi[i, 0] == idPesquisa)
                {
                    Console.WriteLine("Resultado encontrado com sucesso");
                    Console.WriteLine($"Voce pesquisou pelo registro: {listaBi[i,1]}");
                    //sai do metodo sem retorno pq só informa a pesquisa
                    return;
                }
            }
            Console.WriteLine("Nenhum registro com esse ID");
        }
    }
}
