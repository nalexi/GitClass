﻿using CadastroDeLanche.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDeLanche
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<Lanche> lanches = new List<Lanche>();


        private void Button1_Click(object sender, EventArgs e)
        {
            TelaDeCadastro formCadastro = new TelaDeCadastro();
            formCadastro.ShowDialog();
            lanches.Add(formCadastro.novoLanche);
        }
    }
}
