﻿using ListaBiSuperCompacta.BibliotecaListaBi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiSuperCompacta
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaBi = new ListaBi();
            listaBi.PesquisaLista("4");
            Console.ReadKey();
        }
    }
}
