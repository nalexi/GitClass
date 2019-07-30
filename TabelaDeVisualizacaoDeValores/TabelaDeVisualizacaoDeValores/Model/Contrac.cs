using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelaDeVisualizacaoDeValores.Model
{
    public class Contrac
    {
        /// <summary>
        /// Identity of Id Class
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Property to get
        /// </summary>
        public int Value { get; set; }
        public DateTime DatInc { get; set; }
    }
}
