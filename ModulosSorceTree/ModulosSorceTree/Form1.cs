﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModulosSorceTree
{
    delegate double Operación(double a,double b);
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
   
        Operación operacion = Operaciones.Multiplicar;
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Operación operacion = Operaciones.Multiplicar;
        }
    }
}