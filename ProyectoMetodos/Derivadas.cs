using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMetodos
{
    internal class Derivadas_Numericas
    {
        public float Derivada_Dos_Puntos(float x0, float h)
        {
            float xi = x0;
            float xi_1 = x0 + h;

            float aproximacion = (Func(xi_1) - Func(xi)) / h;
            return aproximacion;
        }

        public float Derivada_Tres_Puntos(float x0, float h)
        {
            float xi = x0;
            float xi_1 = x0 + h;
            float xi_2 = x0 + 2 * h;

            float aproximacion = (-Func(xi) + 4 * Func(xi_1) - Func(xi_2)) / (2 * h);
            return aproximacion;
        }

        public float Derivada_Cuatro_Puntos(float x0, float h)
        {
            float xi = x0;
            float xi_1 = x0 + h;
            float xi_2 = x0 + 2 * h;
            float xi_3 = x0 + 3 * h;

            float aproximacion = (-25 * Func(xi) + 48 * Func(xi_1) - 36 * Func(xi_2) + 16 * Func(xi_3)) / (12 * h);
            return aproximacion;
        }

        private float Func(float x)
        {
        
            return x * x - 3 * x + 2; 
        }
    }
}
