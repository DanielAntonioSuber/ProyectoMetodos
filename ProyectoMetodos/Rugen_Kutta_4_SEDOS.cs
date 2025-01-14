using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoMetodos
{
    public partial class Rugen_Kutta_4_SEDOS : Form
    {

        public Rugen_Kutta_4_SEDOS()
        {
            InitializeComponent();
            // Configuración de las columnas del DataGridView
            dataGridView1.Columns.Add("j", "Paso");
            dataGridView1.Columns.Add("tj", "Tiempo (t)");
            dataGridView1.Columns.Add("i", "Variable");
            dataGridView1.Columns.Add("wij", "Valor de w");
            dataGridView1.Columns.Add("k1", "k1");
            dataGridView1.Columns.Add("k2", "k2");
            dataGridView1.Columns.Add("k3", "k3");
            dataGridView1.Columns.Add("k4", "k4");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (double.TryParse(w1_0txt.Text, out double w1_0) &&
        double.TryParse(w2_0txt.Text, out double w2_0) &&
        double.TryParse(htxt.Text, out double h) &&
        double.TryParse(t0txt.Text, out double t0) &&
        int.TryParse(txtIter.Text, out int steps))
            {
                // Llamar al método de Runge-Kutta para obtener la lista de resultados
                var results = SEDOS_Rugen_Kutta.RungeKutta.SolveWithTableFormat(h, t0, w1_0, w2_0, steps);

                // Limpiar el DataGridView
                dataGridView1.Rows.Clear();

                // Mostrar los resultados en el DataGridView
                foreach (var result in results)
                {
                    // Agregar los valores correspondientes a cada columna en el DataGridView
                    dataGridView1.Rows.Add(result.j, result.tj, result.i, result.wij, result.k1, result.k2, result.k3, result.k4);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese todos los valores correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
