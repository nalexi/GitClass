using ListaBiManeiraSimplesComClass.Carrega;
using ListaBiManeiraSimplesComClass.Mostar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiManeiraSimplesComClass
{
    class Program
    {
        static void Main(string[] args)
        {


             //Iniciamos o nosso objeto de memoria
            var carregaLista = new CarregarLista();

            //chama o metodo Carregar lista
            carregaLista.CarregaInformacoesEListaElasEmTela();

            //carrega a classe MostrarLista
            var mostrarLista = new MostrarLista();
            //chama o metodo
            mostrarLista.PesquisandoInfoNaNossaLista(carregaLista.ListaNome,"0");

            Console.ReadKey();

        }

           

            


    }
}

