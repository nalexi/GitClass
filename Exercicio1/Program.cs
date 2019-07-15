using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1VerificarIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "1";


            while (opcao == "1")
            {
                Console.Clear();

                Console.WriteLine("=================================================");
                Console.WriteLine("Bem Vindo ao Sistema de Verificação de Maioridade");
                Console.WriteLine("=================================================");
                Console.WriteLine("Digite o nome da pessoa a ser verificada");

                string nome = Console.ReadLine();
                Console.WriteLine($"Digite a idade de {nome}");
                int.TryParse(Console.ReadLine(), out int idade);

                if (idade < 0)
                {
                    Console.WriteLine("\r\nIDADE NÃO PODE SER NEGATIVA");
                }
                else if (idade > 18)
                {
                    Console.WriteLine($"\r\n{nome}, é maior de idade com {idade} anos, pode consumir bebida alcoolica!");
                    Console.WriteLine($" Bem vindo ao mundo AMBEV {nome}!");

                }
                else
                {
                    Console.WriteLine($"{nome}, é menor de idade com {idade} anos, não pode consumir bebida alcoolica!");
                }

            Console.WriteLine("\r\nDigite 1 para refazer o teste ou qualquer tecla para sair");
            opcao = Console.ReadKey().KeyChar.ToString();
            }

          
        }
    }
}
