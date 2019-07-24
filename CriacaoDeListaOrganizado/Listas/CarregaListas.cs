using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoDeListaOrganizado.Listas
{
    class CarregaListas
    {

        string[] lista;

        public CarregaListas()
        {
            lista = new string[10];
            CarregarLista();
        }

       
        public void CarregarLista()
        {
            for (int i = 0; i < lista.Length; i++)
                lista[i] = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff");
        }

        public void MostrarLista()
        {
            foreach (var item in lista)
                Console.WriteLine(item);
            Console.ReadKey();

        }

        public void ApagaLista()
        {
            for (int i = 0; i < lista.Length; i++)
                lista[i] = ".";//string.Empty;//Aqui limpamos o nosso valor dentro da coleção

            Console.ReadKey();
        }
    }
}
