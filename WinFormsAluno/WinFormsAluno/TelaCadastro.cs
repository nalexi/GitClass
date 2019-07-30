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
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        public Aluno novoAluno = new Aluno();
        private void BtSalvar_Click(object sender, EventArgs e)
        {
            novoAluno.Nome = tbxNome.Text;
            novoAluno.Idade = (int)nrIdade.Value;
            

            this.Close();
        }
    }
}
