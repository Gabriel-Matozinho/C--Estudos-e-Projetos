using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tempo_Fabrica_Classe {
    internal class SegundoParaHora {

        public double Minutos;
        

        public double RestHor(double s) {
            return  s / 3600;      
        }

        public double RestMin(double s) {
            Minutos = (s % 3600) * 60;
            return Minutos;
        }

        public double Segundos() {
            return Minutos / 60;
        }
    }
}
