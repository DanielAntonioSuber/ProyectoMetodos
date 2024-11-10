using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMetodos
{
    public partial class Metodo_Horner : Form
    {
        public Metodo_Horner()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float p0, p1, p2, ErrorMaximo;
            int NumMaxIter;
            bool Result;
            MetSolEc metodos = new MetSolEc();

            float[] coeficientes = textCoeficientes.Text.Split(',')              // Separa el texto por comas
                               .Select(float.Parse)     // Convierte cada parte en un float
                               .ToArray();
            int grado = int.Parse(textGrado.Text);
            p0 = float.Parse(textBox1.Text);
            p1 = float.Parse(textBox3.Text);
            p2 = float.Parse(textBox5.Text);

            ErrorMaximo = float.Parse(ErrMaxtxt.Text);
            NumMaxIter = int.Parse(NuMaxItertxt.Text);

            Complex p0C = new Complex(p0, 0);
            Complex p1C = new Complex(p1, 0);
            Complex p2C = new Complex(p2, 0);



            metodos.NumIter = NumMaxIter;
            metodos.errorMax = ErrorMaximo;

            Result = metodos.MetodoHorner(grado, coeficientes, p0C, p1C, p2C, ref dataGridView1);
        }
    }
}
