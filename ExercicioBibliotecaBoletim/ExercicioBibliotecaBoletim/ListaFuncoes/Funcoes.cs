using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioBibliotecaBoletim.ListaFuncoes
{
    public class Funcoes
    {
        /// <summary>
        /// Metodo calcula media das 3 notas
        /// </summary>
        /// <param name="nota1">passa nota1 para calculo</param>
        /// <param name="nota2">passa nota2 para calculo</param>
        /// <param name="nota3">passa nota3 para calculo</param>
        /// <returns></returns>
        public decimal CalcularMedia(int nota1, int nota2, int nota3)
        {
            return (nota1 + nota2 + nota3) / 3;
        }

        /// <summary>
        /// Metodo calcula porcentagem da frequencia do aluno
        /// </summary>
        /// <param name="total">passa o total de aulas</param>
        /// <param name="faltas">passa o total de faltas</param>
        /// <returns></returns>
        public decimal CalcularFrequencia(int total, int faltas)
        {
            return ((total - faltas) * 100) / total;
        }

        /// <summary>
        /// Metodo verifica se o aluno esta aprovado ou reprovado
        /// </summary>
        /// <param name="Media">passa a media calculada</param>
        /// <param name="Frequencia">passa a frequecia calculada</param>
        /// <returns></returns>
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
