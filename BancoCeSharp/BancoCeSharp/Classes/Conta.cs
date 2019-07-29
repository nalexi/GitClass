using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCeSharp.Classes
{
    public class Conta
    {
            double saldo = 0;
        public double Saldo { get { return saldo; } } 

        public Conta()
        {
            //bonus
            saldo = 1000;
        }

        /// <summary>
        /// metodo para sacar de acordo com o saldo 
        /// </summary>
        /// <param name="valor">valor para sacar</param>
        /// <returns>restorna seo saque foi feito ou nao</returns>
        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            return false;

        }   

        /// <summary>
        /// Metodo para mostrar o saldo em conta disponivel
        /// </summary>
        /// <param name="valor"></param>
        public double MostrarSaldo()
        {
            return saldo;
        }



    }
}
