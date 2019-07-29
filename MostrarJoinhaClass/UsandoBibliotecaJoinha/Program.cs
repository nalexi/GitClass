using MostrarJoinhaClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoBibliotecaJoinha 
{
    class Program
    {
        static void Main(string[] args)
        {
            new AquiMostraJoinha().MetodoInicialDoJoinha();

            AquiMostraJoinha aqui = new AquiMostraJoinha();

            new AquiMostraJoinha().MetodoNovoEstaChegando(true);
            new AquiMostraJoinha().MetodoNovoEstaChegando(false);

            Console.WriteLine(new AquiMostraJoinha().TesteOperadorLegal());

            var teste = aqui.TesteOperadorLegal().GetType();

            //operacao pesada com leitura e gravação em memoria
            var colecao = aqui.TesteOperadorLegal();

            foreach (var item in colecao)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}
