using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioBibliotecaBoletim.ListaFuncoes
{
    public class CrudEscola
    {

        Funcoes funcoes = new Funcoes();

        string[,] RegAlunos;
        int indiceAluno = 0;
        const string Ativo = "Ativo";
        const string Inativo = "Inativo";

        public decimal Media { get; set; }
        public decimal Frequencia { get; set; }


        public CrudEscola()
        {
            RegAlunos = new string[5, 6]; //id, nome, media, frequencia, situacao, ativo 
        }
        public void InsertAluno()
        {
            MostrarSejaBemVindo();
            for (int i = 0; i < RegAlunos.GetLength(0); i++)
            {
                if (RegAlunos[i, 0] != null)
                    continue;

                RegAlunos[i, 0] = (indiceAluno++).ToString();
                Console.WriteLine("Digite nome do aluno");
                RegAlunos[i, 1] = Console.ReadLine();
                RegAlunos[i, 2] = "0";
                RegAlunos[i, 3] = "0";
                RegAlunos[i, 4] = "não definida";
                RegAlunos[i, 5] = CrudEscola.Ativo;
                return;
            }
        }

        public void ListarAluno()
        {
            MostrarSejaBemVindo();
            for (int i = 0; i < RegAlunos.GetLength(0); i++)
            {
                if (RegAlunos[i, 0] == null || RegAlunos[i, 5] == Inativo)
                    continue;

                Console.WriteLine($"Aluno: {RegAlunos[i, 1]} com Id: {RegAlunos[i, 0]}, " +
                    $"media {RegAlunos[i, 2]}, frequencia {RegAlunos[i, 3]}, esta {RegAlunos[i, 4]} ");
            }
        }

        public void ExcluirAluno()
        {
            MostrarSejaBemVindo();
            ListarAluno();

            Console.WriteLine("\nDigite o Id do Aluno a ser apagado");
            string pesquisa = Console.ReadKey().KeyChar.ToString();

            for (int i = 0; i < RegAlunos.GetLength(0); i++)
            {
                if ((RegAlunos[i, 0] == pesquisa) && (RegAlunos[i, 0] != null))
                {
                    RegAlunos[i, 5] = CrudEscola.Inativo;
                    Console.WriteLine("Aluno excluido com sucesso");
                    return;
                }
            }
            Console.WriteLine("Aluno não encontrado");
        }

        public void AlterarNota()
        {
            MostrarSejaBemVindo();
            ListarAluno();

            Console.WriteLine("\nDigite o Id do Aluno desejado para alterar notas");
            string pesquisa = Console.ReadKey().KeyChar.ToString();

            for (int i = 0; i < RegAlunos.GetLength(0); i++)
            {
                if ((RegAlunos[i, 0] == pesquisa) && (RegAlunos[i, 0] != null))
                {
                    Console.WriteLine("\nDigite a primeira nota");
                    int nota1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Digite a segunda nota");
                    int nota2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Digite a terceira nota");
                    int nota3 = Convert.ToInt32(Console.ReadLine());

                    var media = funcoes.CalcularMedia(nota1, nota2, nota3);
                    RegAlunos[i, 2] = media.ToString();

                    int frequencia = Convert.ToInt32(RegAlunos[i, 3]);
                    RegAlunos[i, 4] = funcoes.VerificarAprovado(media, frequencia);

                }
            }
        }

        public void AlterarFrequencia()
        {
            MostrarSejaBemVindo();
            for (int i = 0; i < RegAlunos.GetLength(0); i++)
            {
                Console.WriteLine($"Aluno: {RegAlunos[i, 1]} com Id: {RegAlunos[i, 0]}, " +
                    $"media{RegAlunos[i, 2]}, frequencia{RegAlunos[i, 3]}, esta {RegAlunos[i, 4]} ");
            }

            Console.WriteLine("\nDigite o Id do Aluno para alterar Frequencia");
            string pesquisa = Console.ReadKey().KeyChar.ToString();

            for (int i = 0; i < RegAlunos.GetLength(0); i++)
            {
                if ((RegAlunos[i, 0] == pesquisa) && (RegAlunos[i, 0] != null))
                {
                    Console.WriteLine("\nDigite o total de aulas");
                    int total = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nDigite o total de faltas");
                    int faltas = Convert.ToInt32(Console.ReadLine());

                    var frequencia = funcoes.CalcularFrequencia(total, faltas);
                    RegAlunos[i, 3] = frequencia.ToString();

                    int media = Convert.ToInt32(RegAlunos[i, 2]);
                    RegAlunos[i, 4] = funcoes.VerificarAprovado(media, frequencia);

                    return;
                }
            }
        }

        public void MostrarSejaBemVindo()
        {
            Console.Clear();
            Console.WriteLine("============================================");
            Console.WriteLine("                   BOLETIM                  ");
            Console.WriteLine("============================================");

        }

        public int MenuInicialSistema()
        {
            MostrarSejaBemVindo();
            Console.WriteLine("Escolha o numero abaixo para continuar");
            Console.WriteLine("1 - Inserir Aluno");
            Console.WriteLine("2 - Listar Alunos");
            Console.WriteLine("3 - Excluir aluno");
            Console.WriteLine("4 - Alterar Nota aluno");
            Console.WriteLine("5 - Alterar Frequencia aluno");
            Console.WriteLine("6 - Sair");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);
            return opcao;
        }

        public void Voltar()
        {
            Console.WriteLine("Pressione qualquer tecla");
            Console.ReadKey();
        }

    }

}

