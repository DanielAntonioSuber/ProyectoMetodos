﻿using System;
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
    public partial class Integracion_Trapecio : Form
    {
        public Integracion_Trapecio()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Integracion_Trapecio_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void A_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void B_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void N_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Resultado_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a;
            float b;
            int n;
            float resultado;

            Integracion MetIntegracion = new Integracion();

            a = float.Parse(A_txt.Text);
            b = float.Parse(B_txt.Text);
            n = int.Parse(N_txt.Text);

            resultado = MetIntegracion.MetodoTrapecio(a, b, n);
            Resultado_txt.Text = resultado.ToString();

        }
    }
}
