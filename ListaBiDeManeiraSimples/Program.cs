using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiDeManeiraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            //cria lista bi
            string[,] listaDeNome = new string[5, 2];

            //usando um laço simples para colocar valores mas no mesmo, agora utilizando o GetLenght
            //como parametro "0" para indicar que queremos o tamanho da primeira coluna 
            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {
                
                listaDeNome[i, 0] = i.ToString();//carregando o que podemos chamar de ID, indentificar do nosso registro unico

                listaDeNome[i, 1] = $"Nicholas_{i}";//add info extra

            }

            //GetLength é um metodo e usamos "(parametro)" com o parametro
            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {
                Console.WriteLine($"ID:{ listaDeNome[i,0]} - Nome:{listaDeNome[i,1]}");
            }
        }
    }
}
