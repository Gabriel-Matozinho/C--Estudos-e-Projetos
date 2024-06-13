using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empregados_Classe_Lista {
    internal class Empregados {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Empregados(int id,string nome,double salario) {
            Id = id;
            Nome = nome;
            Salario = salario;
        }
        
        public void AumentoSalario(double porcentagem) {
            Salario = Salario + (Salario * porcentagem / 100.0);
        }

        public override string ToString() {
            return Id
                + ", "
                + Nome
                + ", "
                + Salario.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
