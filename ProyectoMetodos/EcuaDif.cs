using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMetodos
{
    internal class EcuaDif
    {


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

    }
}
