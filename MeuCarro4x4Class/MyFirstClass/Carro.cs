using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuCarro4x4Class.MyFirstClass
{
    class Carro
    {
        public int Rodas { get; set; } = 0;
        public int Portas { get; set; } = 0;
        public int Bancos { get; set; } = 0;
        public int Janelas { get; set; } = 0;

        public static Carro operator++(Carro carro) //altera o operador ++, implementação de MAIS 5 ao inves do convencional +1
        {
            carro.Rodas = carro.Rodas + 5;
            return carro;
        }

        public void MostrarCarro()
        {
            Console.WriteLine($"Nosso carro: \r\n" +
                $"qtde Rodas {Rodas} \r\n " +
                $"qtde portas {Portas} \r\n " +
                $"qtde bancos {Bancos} \r\n " +
                $"qtde janelas {Janelas}");
        }

    }
}
