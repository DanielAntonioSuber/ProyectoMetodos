using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMetodos
{
    public partial class Derivada_Númerica : Form
    {
        public Derivada_Númerica()
        {
            InitializeComponent();
        }
        /*
        public void button1_Click(object sender, EventArgs e)
        {
            float x0;
            int h;
            float resultado;

            Integracion MetIntegracion = new Integracion();

           x0 = float.Parse(x0_txt.Text);
            h = int.Parse(h_txt.Text);
            

            resultado = Derivadas_Numericas.Derivada_Dos_Puntos(x0, h);
            Resultado_2pts_txt.Text = resultado.ToString();
        }
        public void button2_Click(object sender, EventArgs e)
        {
            float x0;
            int h;
            float resultado;

            Integracion MetIntegracion = new Integracion();

            x0 = float.Parse(x0_txt.Text);
            h = int.Parse(h_txt.Text);


            resultado = Derivadas_Numericas.Derivada_Tres_Puntos(x0, h);
            Resultado_2pts_txt.Text = resultado.ToString();
        }

        public void button3_Click(object sender, EventArgs e)
        {
            float x0;
            int h;
            float resultado;

            Integracion MetIntegracion = new Integracion();

            x0 = float.Parse(x0_txt.Text);
            h = int.Parse(h_txt.Text);


            resultado = Derivadas_Numericas.Derivada_Cuatro_Puntos(x0, h);
            Resultado_2pts_txt.Text = resultado.ToString();
        }
        */
        private void Resultado_2pts_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Resultado_3pts_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Resultado_4pts_txt_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
