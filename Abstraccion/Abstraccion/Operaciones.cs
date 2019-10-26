using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{
    public class Operaciones
    {
        public double Convertir(double a, double b , double c = 2)
        {
            double tri = (a * b)/ c;
            return tri;
        }

        public double Convertir(double a, double b = 39.37)
        {
            double cua = a * b;
            return cua;
        }
    }
}
