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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void metodoDeBiseccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Metodo_Biseccion formBiseccion = new Metodo_Biseccion();
            formBiseccion.Show();
        }

        private void metodoDeLaFalsaPosicionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Metodo_Falsa_Posicion formFalsaPosicion = new Metodo_Falsa_Posicion();
            formFalsaPosicion.Show();
        }

        private void metodoDeNewtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Metodo_Newton formNewton = new Metodo_Newton();
            formNewton.Show();
        }

        private void metodoIteracionDePuntoFijoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Metodo_Punto_Fijo formPuntoFijo = new Metodo_Punto_Fijo();
            formPuntoFijo.Show();
        }

        private void metodoDeLaSecanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Metodo_Secante formSecante = new Metodo_Secante();
            formSecante.Show();
        }

        private void metodoDeMullerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Metodo_Muller formMuller = new Metodo_Muller();
            formMuller.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metodoSteffensenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Metodo_Steffensen formSteffensen = new Metodo_Steffensen();
            formSteffensen.Show();
        }

        private void metodoAitkenBiseccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Metodo_Aitken_Biseccion formAitkenB = new Metodo_Aitken_Biseccion();
            formAitkenB.Show();
        }

        private void metodoAitkenSecanteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
