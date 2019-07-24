using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var elementoX = new Teste(5, 5); //new é operador de memoria de instancia

            elementoX.MostrarInfo();

            elementoX.AlterandoInFo(5,5);

            elementoX.MostrarInfo();

            MeninaFoderoza(elementoX);



            Console.ReadKey();
        }
    }

    public class Teste
    {
        private int A { get; set; } = 0;
        private int B { get; set; } = 0; //propriedades

        public Teste(int pA, int pB) //construtor
        {
            A = pA;
            B = pB;
        }
        public void MostrarInfo()
        {
            Console.WriteLine(A+B);
        }

        public void AlterandoInFo(int pA, int pB)
        {
            A = pA * 2;
            B = pB * 2;
        }
        public void AlterandoInFo()
        {
            A = B * 100;
           
        }
        public static void MeninaFoderoza(ref Teste pTeste)
        {
            pTeste.AlterandoInFo();

            MostrarInfo();
        }
    }
}
