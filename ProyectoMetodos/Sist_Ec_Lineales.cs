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
                // Encontrar el valor máximo absoluto en la columna i
                RengInterec = -1;
                aux = Math.Abs(matriz[i, i]);
                for (r = i + 1; r < n; r++)
                {
                    if (Math.Abs(matriz[r, i]) > aux)
                    {
                        RengInterec = r;
                        aux = Math.Abs(matriz[r, i]);
                    }
                }

                // Intercambiar filas si se encuentra un nuevo pivote
                if (RengInterec != -1)
                {
                    for (j = 1; j <= n; j++) // j comienza en 0
                    {
                        aux = matriz[i, j];
                        matriz[i, j] = matriz[RengInterec, j];
                        matriz[RengInterec, j] = aux;
                    }
                }

                // Verificar si el pivote es cero (división imposible)
                if (matriz[i, i] == 0)
                {
                    continue;
                }

                // Realizar eliminación hacia adelante
                for (r = i + 1; r < n; r++)
                {
                    multiplicador = -matriz[r, i] / matriz[i, i];
                    matriz[r, i] = 0; // Eliminar este elemento

                    for (j = i + 1; j <= n; j++) // j comienza en i + 1
                    {
                        matriz[r, j] = multiplicador * matriz[i, j] + matriz[r, j];
                    }
                }
            }
            return true;
        }

        public bool PivoteoParcialEscalado(float[,] matriz, int n)
        {
            int[] permutacion = new int[n];
            float[] escalas = new float[n];

            // Inicializar las permutaciones y las escalas
            for (int i = 0; i < n; i++)
            {
                permutacion[i] = i;
                escalas[i] = 0;

                // Calcular la escala como el valor máximo absoluto en cada fila
                for (int j = 0; j < n; j++)
                {
                    escalas[i] = Math.Max(escalas[i], Math.Abs(matriz[i, j]));
                }

                // Verificar si la fila es nula (escala cero)
                if (escalas[i] == 0)
                {
                    return false; // El sistema no tiene solución
                }
            }

            // Iterar sobre cada columna para triangular la matriz
            for (int k = 0; k < n; k++)
            {
                // Encontrar el pivote usando el criterio de escalado
                int pivoteFila = k;
                float maxRatio = 0;

                for (int i = k; i < n; i++)
                {
                    float ratio = Math.Abs(matriz[permutacion[i], k]) / escalas[permutacion[i]];
                    if (ratio > maxRatio)
                    {
                        maxRatio = ratio;
                        pivoteFila = i;
                    }
                }

                // Intercambiar filas en la permutación
                if (pivoteFila != k)
                {
                    int temp = permutacion[k];
                    permutacion[k] = permutacion[pivoteFila];
                    permutacion[pivoteFila] = temp;
                }

                // Verificar si el pivote es cero (matriz singular)
                if (matriz[permutacion[k], k] == 0)
                {
                    return false; // No se puede triangular
                }

                // Eliminar hacia adelante para triangular la matriz
                for (int i = k + 1; i < n; i++)
                {
                    float factor = -matriz[permutacion[i], k] / matriz[permutacion[k], k];
                    matriz[permutacion[i], k] = 0; // Eliminar el elemento debajo del pivote

                    for (int j = k + 1; j < n; j++)
                    {
                        matriz[permutacion[i], j] += factor * matriz[permutacion[k], j];
                    }
                }
            }

            // Si llegamos aquí, el pivoteo fue exitoso
            return true;
        }
    }
}
