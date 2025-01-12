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
            float multiplicador;

            for (i = 0; i < n - 1; i++)
            {
                for (r = i + 1; r < n; r++)
                {
                    multiplicador = -matriz[r, i] / matriz[i, i];
                    matriz[r, i] = 0;

                    for (j = i + 1; j <= n; j++)
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

        public bool PivoteoMaximoColumna(float[,] matriz, int n)
        {
            int i, j, r;
            int RengInterec;
            float aux;
            float multiplicador;

            for (i = 0; i < n; i++)
            {
                // Encontrar el valor max absoluto en la columna i
                RengInterec = i;
                aux = Math.Abs(matriz[i, i]);
                for (r = i + 1; r < n; r++)
                {
                    if (Math.Abs(matriz[r, i]) > aux)
                    {
                        RengInterec = r;
                        aux = Math.Abs(matriz[r, i]);
                    }
                }

                if (RengInterec != i)
                {
                    for (j = 0; j <= n; j++)
                    {
                        float temp = matriz[i, j];
                        matriz[i, j] = matriz[RengInterec, j];
                        matriz[RengInterec, j] = temp;
                    }
                }

                if (Math.Abs(matriz[i, i]) < 1e-6)
                {
                    return false;
                }

                for (r = i + 1; r < n; r++)
                {
                    multiplicador = -matriz[r, i] / matriz[i, i];
                    matriz[r, i] = 0;

                    for (j = i + 1; j <= n; j++)
                    {
                        matriz[r, j] += multiplicador * matriz[i, j];
                    }
                }
            }
            return true;
        }


        public bool PivoteoParcialEscalado(float[,] matriz, int n)
        {
            int[] permutacion = new int[n];
            float[] escalas = new float[n];
            int i, j, r, k;
            int mejorFila;
            float Coef, maxCoef;

            for (i = 0; i < n; i++)
            {
                permutacion[i] = i;
                escalas[i] = 0;

                for (j = 0; j < n; j++)
                {
                    escalas[i] = Math.Max(escalas[i], Math.Abs(matriz[i, j])); // max de la fila
                }

                if (escalas[i] == 0)
                {
                    return false;
                }
            }

            for (i = 0; i < n - 1; i++)
            {
                mejorFila = i;
                maxCoef = 0;

                for (k = i; k < n; k++)
                {
                    Coef = Math.Abs(matriz[permutacion[k], i]) / escalas[permutacion[k]];
                    if (Coef > maxCoef)
                    {
                        maxCoef = Coef;
                        mejorFila = k;
                    }
                }

                if (mejorFila != i)
                {
                    int temp = permutacion[i];
                    permutacion[i] = permutacion[mejorFila];
                    permutacion[mejorFila] = temp;
                }

                if (Math.Abs(matriz[permutacion[i], i]) < 1e-6)
                {
                    return false;
                }

                // Eliminacion hacia adelante
                for (r = i + 1; r < n; r++)
                {
                    float multiplicador = -matriz[permutacion[r], i] / matriz[permutacion[i], i];
                    matriz[permutacion[r], i] = 0;

                    for (j = i + 1; j <= n; j++)
                    {
                        matriz[permutacion[r], j] += multiplicador * matriz[permutacion[i], j];
                    }
                }
            }

            return true;
        }


    }
}

