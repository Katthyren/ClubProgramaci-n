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
<<<<<<< HEAD
            MessageBox.Show("El resultado es: " + c.ToString(), "Resultado");
=======
            MessageBox.Show(c.ToString());
>>>>>>> 178c28aa407c6793822fa42402b150ff4795b636
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
             operacion = Operaciones.Multiplicar;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
             operacion = Operaciones.Restar;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
             operacion = Operaciones.Sumar;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
             operacion = Operaciones.Dividir;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
             operacion = Operaciones.Exponenciar;
        }
    }
}
