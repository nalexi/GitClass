using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoDeLista
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lista = new string[10];//aqui defiinimos as posições da lista iniciando ela com 10 espaços
                                            //na memoria para alocar informações de texto

            //laço usado para percorrer listas
            for (int i = 0; i < lista.Length; i++)
            {
                //carregando os valores da lista
                //aonde "i" representa cada espaço disponivel 

                lista[i] = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff");
                //datetime e um tipo do .net c# que disponibiliza funções relacionadas a datas
                //e horas, para trabalhar com isso, usar datetime
            }

            //laço de repetição que usamos para varrer nossa lista de maneira simples
            foreach (var item in lista)//var item indica uma nidade da nossa lista "in lista"
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

            for (int i = 0; i < lista.Length; i++)
                lista[i] = string.Empty; //limpa o valor dentro da nossa lista
            foreach (var item in lista)
                Console.WriteLine("item");

            Console.ReadKey();

        }
    }
}
