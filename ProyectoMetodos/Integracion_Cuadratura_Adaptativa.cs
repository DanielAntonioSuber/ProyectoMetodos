using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ProyectoMetodos
{
    public partial class Integracion_Cuadratura_Adaptativa : Form
    {
        public Integracion_Cuadratura_Adaptativa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Integracion integracion = new Integracion();

            float a = float.Parse(A_txt.Text.ToString());
            float b = float.Parse(B_txt.Text.ToString());

            float resultado = integracion.MetodoCuadraturaGaussiana(a, b);
            Resultado_txt.Text = resultado.ToString();
        }

   
    }
}
