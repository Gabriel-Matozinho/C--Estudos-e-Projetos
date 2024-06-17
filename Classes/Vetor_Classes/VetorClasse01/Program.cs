using System;
using System.Globalization;

namespace VetorClasse01 {
    internal class Program {
        static void Main(string[] args) {
            
            int n = int.Parse(Console.ReadLine());
            ProdutoVetor[] prod = new ProdutoVetor[n];

            for(int i = 0; i < n; i++) {
                string[] s = Console.ReadLine().Split(' ');
                string nome = s[0];
                double preco = double.Parse(s[1],CultureInfo.InvariantCulture);
                prod[i] = new ProdutoVetor(nome,preco);
            }

            double sum = 0.0;
            for(int i = 0; i < n; i++) {
                sum += prod[i].Preco;
            }

            double avg = 0.0;
            for(int i = 0; i < n; i++) {
                avg = sum / n;
            }

            Console.WriteLine(avg.ToString("F2",CultureInfo.InvariantCulture));
        }        
    }
}
