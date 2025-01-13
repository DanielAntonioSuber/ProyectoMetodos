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
            float t = 0;
            float y = y0;
            int i = 1;

            dgvResultado.Rows.Clear();
            dgvResultado.Columns.Clear();
            dgvResultado.Columns.Add("iteracion", "i");
            dgvResultado.Columns.Add("t", "t");
            dgvResultado.Columns.Add("Aproximacion_Euler", "Euler");
            dgvResultado.Columns.Add("Solucion_Real", "SolExacta");

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


        public int RungeKuta4(float tMax, float y0, float h, DataGridView dgvResultado)
        {
            if (h <= 0 || tMax <= 0) 
            {
                return -1; 
            }

            float t = 0;
            float w = y0;
            int iteracion = 0;

            dgvResultado.Rows.Clear();
            dgvResultado.Columns.Clear();
            dgvResultado.Columns.Add("iteracion", "i");
            dgvResultado.Columns.Add("t", "t");
            dgvResultado.Columns.Add("aproximacionRK", "Runge-Kutta 4");

            try
            {
                while (t <= tMax)
                {
                    dgvResultado.Rows.Add(iteracion, t, w);

                    float k1 = h * Funcion(t, w);
                    float k2 = h * Funcion(t + h / 2, w + k1 / 2);
                    float k3 = h * Funcion(t + h / 2, w + k2 / 2);
                    float k4 = h * Funcion(t + h, w + k3);

                    w += (k1 + 2 * k2 + 2 * k3 + k4) / 6;

                    t += h;
                    iteracion++;
                }
            }
            catch
            {
                return -1; 
            }

            return 0; 
        }

        public int RungeKutta2(float tMax, float y0, float h, DataGridView dgvResultado)
        {
            if (h <= 0 || tMax <= 0) 
            {
                return -1;
            }

            float t = 0;
            float w = y0;
            int iteracion = 0;

            dgvResultado.Rows.Clear();
            dgvResultado.Columns.Clear();
            dgvResultado.Columns.Add("iteracion", "i");
            dgvResultado.Columns.Add("t", "t");
            dgvResultado.Columns.Add("aproximacionRK2", "Runge-Kutta 2");

            try
            {
                while (t <= tMax)
                {
                    dgvResultado.Rows.Add(iteracion, t, w);

                    float k1 = h * Funcion(t, w);
                    float k2 = h * Funcion(t + h, w + k1);

                    w = w + (k1 + k2) / 2;

                    t += h;
                    iteracion++;
                }
            }
            catch
            {
                return -1; 
            }

            return 0; 
        }


        private float Funcion(float t, float y)
        {
            return -2 * t * y; // Ejemplo: dy/dt = -2ty
        }

        private float FuncPrin(float x)
        {
            return (float)Math.Cos(x);
        }

    }

}
