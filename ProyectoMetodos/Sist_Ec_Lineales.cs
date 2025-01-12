using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMetodos
{
    internal class Sist_Ec_Lineales
    {
        
        public bool eliminacion_gaussiana(float[,] matriz, int n)
        {
            int i, j, r;

            for (i = 0; i < n - 1; i++)
            {
                for (r = i + 1; r < n; r++)
                {
                    float multiplicador = -matriz[r, i] / matriz[i, i];
                    matriz[r, i] = 0;
            
                    for (j = i + 1; j <= n ; j++)
                    {
                        matriz[r, j] = multiplicador * matriz[i, j] + matriz[r, j];
                    }
                }
            }
            return true;
        }

        public float[] SustitucionHaciaAtras(float[,] matriz, int n)
        {
            float[] soluciones = new float[n];
            int i; 

            for (i = n - 1; i >= 0; i--)
            {
                float suma = 0;
                for (int j = i + 1; j < n; j++)
                {
                    suma += matriz[i, j] * soluciones[j];
                }
                soluciones[i] = (matriz[i, n] - suma) / matriz[i, i];
            }

            return soluciones;
        }
    }
}
