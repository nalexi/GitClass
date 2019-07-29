using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCantina.Cantina
{
    public class Metodos
    {
        string nome;
        string[,] lanches;
        
        public string Nome { get { return nome; } }
        public string[,] Lanches { get { return lanches; } }
        
        double pilaPraMerenda;

        public Metodos()
        {
            nome = "Jão";
            pilaPraMerenda = 20;
            lanches = new string[3, 2] { { "risoles", "5" }, { "pastel", "8" }, { "biluzitos", "12" } };
        }

        public bool ComprarRisoles(string pedido)
        {
            for (int i = 0; i < lanches.GetLength(0); i++)
            {
                if (pedido == lanches[i,0] && pilaPraMerenda >= Convert.ToDouble(lanches[i,1]))
                {
                    pilaPraMerenda -= Convert.ToDouble(lanches[i,1]);
                    return true;
                }
            }
            return false;
        }

        public double Troco()
        {
            return pilaPraMerenda;
        }

      
    }
}
