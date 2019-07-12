using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2ReceitaBolo
{
    class Program
    {
        static string[] ingredientes;
        static string[] preparo;
        static void Main(string[] args)
        {
            CarregarReceita();

            MostrarBemVindo();

            MetodoIngredientes();

            MetodoPreParo();

            Console.WriteLine("\r\nBom Apetite!");
            Console.ReadKey();



        }
        /// <summary>
        /// Metodo mostra os itens da lista de Preparo
        /// </summary>
        private static void MetodoPreParo()
        {

            Console.Clear();
            MostrarBemVindo();
            Console.WriteLine("Modo De Preparo!");
            for (int i = 0; i < preparo.Length; i++)
            {
                Console.WriteLine(preparo[i]);

                Console.ReadKey();

            }
        }

        /// <summary>
        /// Metodo mostra os itens da lista de Ingredientes
        /// </summary>
        private static void MetodoIngredientes()
        {

            MostrarIntroducao();

            Console.WriteLine("\r\nPara começar voce ira precisar dos proximos itens!");
            Console.WriteLine("Presisone ENTER para prosseguir com os Ingredientes");
            Console.WriteLine("INGREDIENTES");
            for (int i = 0; i < ingredientes.Length; i++)
            {
                Console.WriteLine(ingredientes[i]);

                Console.ReadKey();

            }
            Console.WriteLine("\r\nEsta com todos os itens preparados?!");
            Console.WriteLine("Pressione ENTER para porsseguir para o Modo de Preparo!");
            Console.ReadKey();
        }

        /// <summary>
        /// Metodo carrega os valores da lista de ingredientes e modo de preparo
        /// </summary>
        private static void CarregarReceita()
        {
            ingredientes = new string[] {

                "1 lata de leite condensado(395 g",
                "1 lata de leite",
                "1 lata de farinha de trigo",
                "½ lata de açúcar",
                "1 vidro de leite de coco(200 g)",
                "3 ovos",
                "3 colheres de sopa de margarina ou manteiga",
                "1 pitada de sal",
            };

            preparo = new string[] {"Coloque o forno para preaquecer até 180ºC",
            "Coloque todos os ingredientes no liquidificador",
            "Bata por 5 minutos ou até tudo estar muito bem misturado",
            "Unte uma forma e polvilhe com farinha",
            "Coloque a massa batida do bolo na forma",
            "Leve para assar no forno preaquecido",
            "E coloque para assar a 180ºC por 50-60 minutos.",
            "Retire do forno e Sirva!",
            
            };
        }

        /// <summary>
        /// Metodo mostra bem vindo e instruções
        /// </summary>
        public static void MostrarBemVindo()
        {
            Console.WriteLine("=========================================================================");
            Console.WriteLine("|                              BomBolo!                                 |");
            Console.WriteLine("=========================================================================");
            Console.WriteLine("Instruções: A cada passo completado da receita, pressione ENTER para prosseguir!");

            Console.ReadKey();
        }

        /// <summary>
        /// Metodo mostra breve introdução
        /// </summary>
        public static void MostrarIntroducao()
        {
            Console.WriteLine("\r\nVamos começar com aquele bolo cremoso e macio que lembra pudim,delicioso para comer acompanhado de um cafezinho!");
            Console.WriteLine("É só pressionar ENTER para começar!");
            Console.ReadKey();
        }
    }
}
