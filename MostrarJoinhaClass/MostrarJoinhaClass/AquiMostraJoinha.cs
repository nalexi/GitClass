using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostrarJoinhaClass
{
    public class AquiMostraJoinha
    {
        /// <summary>
        /// mostra joinha
        /// </summary>
        public void MetodoInicialDoJoinha()
        {
            Console.WriteLine("Aqui mostra o joinha");
            Console.ReadKey();
        }

        /// <summary>
        /// escolhe se é quinta ou sextou
        /// </summary>
        /// <param name="eQuinta"></param>
        public void MetodoNovoEstaChegando(bool eQuinta)
        {
            if (eQuinta)
                Console.WriteLine("ta quasee");
            else
                Console.WriteLine("agora sim!");
            Console.ReadKey();
        }

        /// <summary>
        /// metodo que vamos identificar o tipo
        /// </summary>
        /// <returns>retorna</returns>
        public string[] TesteOperadorLegal()
        {
            return new string[2] { "teste 1", "teste 2" };
        }
    }
}
