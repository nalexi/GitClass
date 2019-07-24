using CriacaoDeListaOrganizado.Listas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoDeListaOrganizado
{
    class Program
    {
        static void Main(string[] args)
        {
            var testeLista = new CarregaListas();

            testeLista.MostrarLista();

            testeLista.ApagaLista();
         
            testeLista.MostrarLista();

            testeLista.CarregarLista();
            

            

        }

    }
}
