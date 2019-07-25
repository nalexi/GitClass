using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioBibliotecaBoletim.ListaFuncoes
{
    public class Funcoes
    {
        public decimal CalcularMedia(int nota1, int nota2, int nota3)
        {
            return (nota1 + nota2 + nota3) / 3;
        }

        public decimal CalcularFrequencia(int total, int faltas)
        {
            return ((total - faltas) * 100) / total;
        }

        public string VerificarAprovado(decimal Media, decimal Frequencia)
        {

            if (Media >= 7 && Frequencia >= 75)
            {
                return "Aprovado";
            }
            else
            {
                return "Reprovado";
            }
        }
    }
}
