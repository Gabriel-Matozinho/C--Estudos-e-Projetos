using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes {
    internal class ConversorDeMoeda {

        public static double Iof = 6.0/100;
        
        public static double DolarParaReal(double quantia, double cotacao) {
            double total = quantia * cotacao;
            return Iof * total + total;
        }
    }
}
