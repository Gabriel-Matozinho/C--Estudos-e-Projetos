using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDolar {
    internal class ConversorDeMoeda {

        public static double IOF = 6.0 / 100;

        public static double Convercao(double q,double c) {
            double total = q * c;
            return total + (total * IOF);   
        }
    }
}
