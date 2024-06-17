using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseLista03 {
    internal class Empregados {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double  Salario { get; private  set; }

        public Empregados(int id,string nome) {
            Id = id;
            Nome = nome;            
        }

        public Empregados(int id,string nome,double salario): this(id,nome) {
            Salario = salario;
        }

        public void AumentarSalario(double porcentagem) {
            Salario += Salario * (porcentagem / 100);
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
