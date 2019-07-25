using ExercicioBibliotecaBoletim.ListaFuncoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioBibliotecaBoletim
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcoes funcoes = new Funcoes();
            CrudEscola cruds = new CrudEscola();


            while (true)
            {
                switch (cruds.MenuInicialSistema())
                {
                    case 1:
                        cruds.InsertAluno();
                        cruds.Voltar();
                        break;

                    case 2:
                        cruds.ListarAluno();
                        cruds.Voltar();
                        break;

                    case 3:
                        cruds.ExcluirAluno();
                        cruds.Voltar();
                        break;

                    case 4:
                        cruds.AlterarNota();
                        cruds.Voltar();
                        break;

                    case 5:
                        cruds.AlterarFrequencia();
                        cruds.Voltar();
                        break;

                    case 6:

                        { return; }

                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
            }
        }
    }
}
