using System;
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
   
        Operación operacion = Operaciones.Sumar;
        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = (double)nudPrimero.Value;
            b = (double)nupSegundo.Value;
            c = operacion(a, b);
            MessageBox.Show(c.ToString());
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
             operacion = Operaciones.Multiplicar;
             label1.Text = "×";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
             operacion = Operaciones.Restar;
             label1.Text = "-";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
             operacion = Operaciones.Sumar;
             label1.Text = "+";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
             operacion = Operaciones.Dividir;
             label1.Text = "÷";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
             operacion = Operaciones.Exponenciar;
             label1.Text = "^";
        }
    }
}
