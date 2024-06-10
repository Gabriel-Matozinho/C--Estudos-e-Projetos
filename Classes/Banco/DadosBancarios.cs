using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste {
    internal class DadosBancarios {

        public int Conta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public DadosBancarios(int conta,string titular) {
            Conta = conta;
            Titular = titular;
        }

        public DadosBancarios(int conta,string titular,double saldo) : this(conta,titular) {
            Saldo = saldo;
        }

        public void Deposito(double deposito) {
            Saldo += deposito;
        }

        public void Saque(double saque) {
            Saldo = Saldo - saque - 5.00;
        }

        public override string ToString() {
            return "Conta "
                + Conta
                + ", Titular: "
                + Titular
                + ", Saldo: R$ "
                + Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
