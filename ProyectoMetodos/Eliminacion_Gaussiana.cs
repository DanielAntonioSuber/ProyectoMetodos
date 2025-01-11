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
    public partial class Eliminacion_Gaussiana : Form
    {
        public int NumIncog;
        public float[,] MatrizAum;

        public Eliminacion_Gaussiana()
        {
            InitializeComponent();
        }

        private void Eliminacion_Gaussiana_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NumIncogtxt_TextChanged(object sender, EventArgs e)
        {
            int i;
            NumIncog = int.Parse(NumIncogtxt.Text);
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            for (i = 0; i <= NumIncog; i++)
                dataGridView1.Columns.Add($"col_{i}", i == NumIncog ? "Resultado" : $"X{i + 1}");
            for (i = 0; i < NumIncog; i++)
                dataGridView1.Rows.Add();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MatrizAum = new float[NumIncog, NumIncog + 1];
                for (int i = 0; i < NumIncog; i++)
                {
                    for (int j = 0; j <= NumIncog; j++)
                    {
                        MatrizAum[i, j] = float.Parse(dataGridView1.Rows[i].Cells[j].Value?.ToString());
                    }
                }

                Sist_Ec_Lineales solver = new Sist_Ec_Lineales();
                if (solver.eliminacion_gaussiana(MatrizAum, NumIncog))
                {
                    MessageBox.Show("Eliminación gaussiana realizada con éxito.");
                    Resultado();
                }
                else
                {
                    MessageBox.Show("No se pudo realizar la eliminación gaussiana.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void Resultado()
        {
            int i, j;
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();

            for (i = 0; i <= NumIncog; i++)
                dataGridView2.Columns.Add($"col_{i}", i == NumIncog ? "Resultado" : $"X{i + 1}");
            for (i = 0; i < NumIncog; i++)
                dataGridView2.Rows.Add();

            for (i = 0; i < NumIncog; i++)
            {
                for (j = 0; j <= NumIncog; j++)
                {
                    dataGridView2.Rows[i].Cells[j].Value = MatrizAum[i, j].ToString();
                }
            }
        }
    }
}

