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


            //cria lista bi


            //Iniciamos o nosso objeto de memoria
            var Nicholas = new CarregarLista();

            //chama o metodo Carregar lista
            Nicholas.CarregaInformacoesEListaElasEmTela();

            //carrega a classe MostrarLista
            var FelipeBlindao = new MostrarLista();
            //chama o metodo
            FelipeBlindao.PesquisandoInfoNaNossaLista(Nicholas.ListaNome,"0");

            Console.ReadKey();

        }

           

            


    }
}

