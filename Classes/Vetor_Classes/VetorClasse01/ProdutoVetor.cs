using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetorClasse01 {
    internal class ProdutoVetor {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public ProdutoVetor(string nome,double preco) {
            Nome = nome;
            Preco = preco;       
        }
    }
}
