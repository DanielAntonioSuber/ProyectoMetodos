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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void metodoDeBisecciomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Metodo_Biseccion formBiseccion = new Metodo_Biseccion();
            formBiseccion.Show();

        }

        private void metodoDeFalsaPosicionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Metodo_Falsa_Posicion formFalsaPosicion = new Metodo_Falsa_Posicion();
            formFalsaPosicion.Show();

        }

        private void metodoDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Metodo_Punto_Fijo formPuntoFijo = new Metodo_Punto_Fijo();
            formPuntoFijo.Show();

        }

        private void metodoDeSecanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Metodo_Secante formSecante = new Metodo_Secante();
            formSecante.Show();
        }

        private void metodoDeNewtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Metodo_Newton formNewton = new Metodo_Newton();
            formNewton.Show();
        }

        private void metodoDeSteffensenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Metodo_Steffensen formSteffensen = new Metodo_Steffensen();
            formSteffensen.Show();
        }

        private void metodoDeAikenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aitkenBiseccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Metodo_Aitken_Biseccion formAitkenB = new Metodo_Aitken_Biseccion();
            formAitkenB.Show();
        }

        private void aitkenSecanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Metodo_Aitken_Secante formAitkenS = new Metodo_Aitken_Secante();
            formAitkenS.Show();
        }

        private void metodoDeHornerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Metodo_Horner formHorner = new Metodo_Horner();
            formHorner.Show();
        }

        private void metodosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void integracionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void trapecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Integracion_Trapecio formTrapecio = new Integracion_Trapecio();
            formTrapecio.Show();
        }

        private void simpson13ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Integracion_Simpson_1_3 formSimpson13 = new Integracion_Simpson_1_3();
            formSimpson13.Show();
        }

        private void simpson38ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Integracion_Simpson_3_8 formSimpson38 = new Integracion_Simpson_3_8();
            formSimpson38.Show();
        }

        private void metodoDeMullerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Metodo_Muller formMuller = new Metodo_Muller();
            formMuller.Show();
        }

        private void formulaT2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void taylorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void formulaTaylor1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formula_Taylor_0 taylor1Form = new Formula_Taylor_0();
            taylor1Form.Show();
        }

        private void formulaTaylor2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formula_Taylor_1 taylor1Form = new Formula_Taylor_1();
            taylor1Form.Show();
        }

        private void formulaTaylor3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formula_Taylor_2 taylor1Form = new Formula_Taylor_2();
            taylor1Form.Show();
        }

        private void formulaTaylor4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formula_Taylor_3 taylor1Form = new Formula_Taylor_3();
           
            taylor1Form.Show();
        }

        private void formulaTaylor5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario_Taylor_4 taylor1Form = new Formulario_Taylor_4();
            taylor1Form.Show();
        }

        private void formulaTaylor5ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Formula_Taylor_5 taylor1Form = new Formula_Taylor_5();
            taylor1Form.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void ecDiferencialesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void derivacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sistemasEcLinealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eliminacionGaussianaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Eliminacion_Gaussiana Elim_Gauss = new Eliminacion_Gaussiana();
            Elim_Gauss.Show();
        }

        private void pivoteoMaxDeColumnaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eliminacionGaussianaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Eliminacion_Gaussiana Elim_Gauss = new Eliminacion_Gaussiana();
            Elim_Gauss.Show();
        }

        private void eulerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Metodo_euler Euler = new Metodo_euler();
            Euler.Show();
        }

        private void trapecioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Trapecio_Compuesta_Multiple Trapecio_doble = new Trapecio_Compuesta_Multiple();
            Trapecio_doble.Show();
        }

        private void simpson13ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Simpson_Compuesta_Multiple Trapecio_doble = new Simpson_Compuesta_Multiple();
            Trapecio_doble.Show();
        }

        private void derivacionAdelanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Derivada_Númerica derivar = new Derivada_Númerica();
            derivar.Show();
        }

        private void cuadraturaAdaptativaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Integracion_Cuadratura_Adaptativa cuadraturaAdaptativa = new Integracion_Cuadratura_Adaptativa();
            cuadraturaAdaptativa.Show();
        }

        private void cuadraturaGaussianaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Integracion_Cuadratura_Gaussiana cuadraturaGaussiana = new Integracion_Cuadratura_Gaussiana();

            cuadraturaGaussiana.Show();
        }

        private void rugenTripas1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
