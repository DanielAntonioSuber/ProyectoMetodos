using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMetodos
{
    internal class Integracion
    {
        public float x0;
        public float xn;
        public int n;
        
        public float MetodoTrapecio(float x0, float xn, int NumSubInt)
        {
            float h;
            float sumatoria;
            float a = x0;
            float b = xn;
            int n = NumSubInt;
            int i;

            if (NumSubInt <= 0)
            {
                MessageBox.Show("El numero de subintervalos debe ser mayor a 0", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            h = (b - a) / n;
            sumatoria = 0;

            for (i = 1; i < n; i++)
            {
                sumatoria += funcion(a + i * h);
            }
            
            sumatoria = sumatoria * h;
            sumatoria += h * (funcion(a) + funcion(b)) / 2;
            return sumatoria;
        }

        //metodo simpson 1/3
        // integral = (h/3) * (f0 + 4sumatoria(f2i -1) + 2*sumatoria(f2i) +fn
        public float Simpson1_3(float x0, float xn, int k)
        {
            float h;
            float sum1 = 0;
            float sum2 = 0;
            float n = 2 * k;
            float a = x0;
            float b = xn;

            if (k <= 0)
            {
                MessageBox.Show("El numero de k debe ser mayor a 0", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            h = (b - a) / n;

            for (int i = 1; i <= k; i++)
            {
                sum1 += funcion(a + (2 * i - 1) * h);
            }

            sum1 = 4 * sum1;

            for (int i = 1; i < k; i++)
            {
                sum2 += funcion(a + 2 * i * h);
            }
            sum2 = 2 * sum2;

            sum1 = (h / 3) * (funcion(a) + sum1 + sum2 + funcion(b));
            return sum1;
        }


        float funcion(float x)
        {
            float r;
            r = x * (float)Math.Sin(x);
            return r;
        }
    }
}
