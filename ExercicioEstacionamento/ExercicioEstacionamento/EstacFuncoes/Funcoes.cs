using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEstacionamento.EstacFuncoes
{
    class Funcoes
    {
        string[,] ListaCarros;
        const string Ativo = "Ativo";
        const string Inativo = "Inativo";

        public Funcoes()
        {
            ListaCarros = new string[6, 5];
        }

        public void InsertCarro()
        {
            MostrarSejaBemVindo();
            for (int i = 0; i < ListaCarros.GetLength(0); i++)
            {
                if (ListaCarros[i, 0] != null)
                    continue;

                Console.WriteLine("Digite a placa do veiculo");
                ListaCarros[i, 0] = Console.ReadLine();
                ListaCarros[i, 1] = ;
                ListaCarros[i, 2] = "0";
                ListaCarros[i, 3] = "0";
                ListaCarros[i, 4] = "não definida";
                ListaCarros[i, 5] = CrudEscola.Ativo;
                return;
            }
        }

        public void ListarCarros()
        {
            for (int i = 0; i < ListaCarros.GetLength(0); i++)
            {
                Console.WriteLine($"Placa: {ListaCarros[i, 0]}, Modelo: {ListaCarros[i, 1]}, " +
                    $"Hora de Entrada: {ListaCarros[i, 2]}, Hora de Saida {ListaCarros[i, 3]}");
            }
        }

        public void MostrarSejaBemVindo()
        {
            Console.Clear();
            Console.WriteLine("============================================");
            Console.WriteLine("               Estacionamento               ");
            Console.WriteLine("============================================");
        }
    }
}
