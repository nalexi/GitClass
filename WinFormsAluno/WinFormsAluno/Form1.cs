using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsAluno.Classes;

namespace WinFormsAluno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       public List<Aluno> alunos = new List<Aluno>();

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            TelaCadastro telaCadastro = new TelaCadastro();
            telaCadastro.ShowDialog();
            alunos.Add(telaCadastro.novoAluno);
            //MessageBox.Show("aluno cadastrado");

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = alunos;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtMLista_Click(object sender, EventArgs e)
        {
         
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
