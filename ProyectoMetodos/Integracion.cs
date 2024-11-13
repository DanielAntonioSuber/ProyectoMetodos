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

        public float MetodoTrapecioMultiple(float x0, float xn, int numSubIntX, float y0, float ym, float numSubIntY)
        {

            float hx, hy;
            float resultado = 0;
            float n = numSubIntX;
            float m = numSubIntY;
            
            hx = (xn - x0) / n;
            hy = (ym - y0) / m;

            float sum = 0;
            float sum2 = 0;
            float sum3 = 0;

       
            for (int j = 0; (j < m - 1); j ++)
            {
                sum = funcion2(x0, y0 + (hy * j));
            }

            resultado += ((hx * hy) / 2) * (funcion2(x0, y0) / 2) + sum + (funcion2(x0, ym) / 2) ;

            sum = 0;
            for (int i = 0;  (i < n - 1); i++)
            {
                sum = funcion2(x0 + (hx * i), y0);
            }

            for (int i = 0; (i < n - 1); i++)
            {
                for (int j = 0; (j < m - 1); j++)
                {
                    sum2 = funcion2(x0 + (hx * i) , y0 + (hy * j));
                }
            }

            for (int i = 1; (i < (n - 1)); i++)
            {
                sum3 = funcion2(x0 + (hx * (i + 1)), ym);
            }

            resultado += hx * hy * ((sum / 2) + sum2 + (sum3 / 2));

            sum = 0;
            for (int j = 0; j < (m - 1); j++)
            {
                sum += funcion2(xn, y0 + (hy * j));
            }

            resultado += ((hx * hy) / 2) * ( (funcion2(xn, y0) / 2) + sum + (funcion2(xn, ym) / 2)) ;

            return resultado;
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

        public float Simpson3_8(float x0, float xn, int k)
        {
            float h;
            float sum1 = 0;
            float sum2 = 0;
            float sum3 = 0;
            float n = 3 * k;
            float a = x0;
            float b = xn;
            float formula;

            if (k <= 0)
            {
                MessageBox.Show("El numero de k debe ser mayor a 0", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            h = (b - a) / n;

            for(int i = 1; i <= k; i++)
            {
                sum1 += funcion(a + (3 * i - 2) * h);
            }

            sum1 = 3 * sum1;

            for (int i = 1; i <= k; i++)
            {
                sum2 += funcion(a + (3 * i - 1) * h);
            }

            sum2 = 3 * sum2;

            for (int i = 1; i < k; i++)
            {
                sum3 += funcion(a + (3 * i) * h);
            }

            sum3 = 2 * sum3;

            formula =  ((3 * h) / 8) * (funcion(a) + sum1 + sum2 + sum3 + funcion(b));

            return formula;

        }


        float funcion(float x)
        {
            float r;
            r = x * (float)Math.Sin(x);
            return r;
        }

        float funcion2(float x, float y)
        {
            float res;
            float r = (float) Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

            res =  r * (float) Math.Sin(r);

            return res;
        }
    }
}
