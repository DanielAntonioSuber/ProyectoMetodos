using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMetodos
{
    internal class EcuaDif
    {

        public int MetodoEuler(float tMax, float y0, float h, DataGridView dgvResultado)
        {
            // Variables de iteración
            float t = 0;
            float y = y0;
            int i = 1;

            // Limpiar el DataGridView antes de agregar resultados
            dgvResultado.Rows.Clear();
            dgvResultado.Columns.Clear();
            dgvResultado.Columns.Add("iteracion", "i");
            dgvResultado.Columns.Add("t", "t");
            dgvResultado.Columns.Add("Aproximacion_Euler", "Euler");
            dgvResultado.Columns.Add("Solucion_Real", "SolExacta");

            // Validación de que h sea mayor que 0
            if (h <= 0)
            {
                MessageBox.Show("El paso h debe ser mayor a 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            while (t <= tMax)
            {
                float real = FuncPrin(t); 

                y = y + h * (-2 * y);

                int newRowIdx = dgvResultado.Rows.Add();
                dgvResultado.Rows[newRowIdx].Cells[0].Value = i;
                dgvResultado.Rows[newRowIdx].Cells[1].Value = Math.Round(t, 4);
                dgvResultado.Rows[newRowIdx].Cells[2].Value = Math.Round(y, 6);
                dgvResultado.Rows[newRowIdx].Cells[3].Value = Math.Round(real, 6);

                t += h;
                i++;
            }

            MessageBox.Show("Se obtuvieron las aproximaciones con Euler", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return 0;
        }


        public void RungeKuta ()
        {

        }

        public float RK(float h, float t, float w)
        {
            return h * Funcion(t, w);
        }
    
        public float RK2(float h, float t, float w, float k) {
            return h * Funcion(t + h / 2, (float)( w + 0.5 * k));
        }

        public void RK3() { }

        public void RK4() { }

        public float Funcion (float ti, float wi)
        {
            return (float)-(0.55f * 0.000706f * Math.Sqrt(2 * 9.81 * wi) / (Math.PI * (Math.Pow(1.5, 2) - Math.Pow(1.5 - wi, 2))));
        }
        private float FuncPrin(float x) //funcion principal, derivada 4
        {
            return (float)Math.Cos(x);
        }

    }
}
