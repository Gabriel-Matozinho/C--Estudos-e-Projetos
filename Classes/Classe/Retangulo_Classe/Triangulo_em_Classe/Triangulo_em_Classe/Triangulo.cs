using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo_em_Classe {
    internal class Triangulo 
    {
        public double A, B, C;

        public double Area() { 
        
        double p = (A + B + C) /2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
