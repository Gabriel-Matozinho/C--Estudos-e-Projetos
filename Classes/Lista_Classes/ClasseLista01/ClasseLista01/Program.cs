using System.Globalization;

namespace ClasseLista01 {
    internal class Program {
        static void Main(string[] args) {
            
            int N = int.Parse(Console.ReadLine());

            List<Produto> produtos = new List<Produto>();

            for(int i = 0; i < N; i++) {
                string[] s = Console.ReadLine().Split(' ');
                string nome = s[0];
                double preco = double.Parse(s[1],CultureInfo.InvariantCulture);
                produtos.Add(new Produto(nome, preco));
            }

            double sum = 0.0;
            for(int i = 0; i < N; i++) {
                sum += produtos[i].Preco;
            }

            double avg = 0.0;
            for(int i = 0; i < N; i++) {
                avg = sum / N;
            }
            Console.WriteLine(avg.ToString("f2",CultureInfo.InvariantCulture));
        }
    }
}
