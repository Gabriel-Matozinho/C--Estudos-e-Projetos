using System.Globalization;


namespace Testes {
    internal class ContaBancaria {

        public int IdBanco { get; private set; }
        public string NomeBanco { get; set; }
        public double SaldoBanco { get; private set; }        
        
        public ContaBancaria(int id, string nome) {
            IdBanco = id;
            NomeBanco = nome;            
        }

        public ContaBancaria(int id,string nome,double saldo) : this(id,nome) {
            SaldoBanco = saldo;
        }

        public void Deposito(double quantia) { 
            SaldoBanco += quantia;
        }

        public void Saque(double quantia) { 
            SaldoBanco = SaldoBanco - quantia - 5.00;
        }

        public override string ToString() {
            return "Conta "
                + IdBanco
                + ", Titular: "
                + NomeBanco
                + ", Saldo: $ "
                + SaldoBanco.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
