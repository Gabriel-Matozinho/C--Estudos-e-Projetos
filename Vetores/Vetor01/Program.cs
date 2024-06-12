using System.Globalization;

namespace Vetor01 {
    internal class Program {
        static void Main(string[] args) {
            //Declaração das variáveis
            int n;
            double[] vet;
            n = int.Parse(Console.ReadLine());
            vet = new double[n];

            //Entrada de dados, converção para um vetor de string de leitura horizontal.
            string[] s = Console.ReadLine().Split(' ');

            //Usando o laço para converter o tipo string para double e usar da variavel 'i' para alocação dos valores dos dados de entrada no vetor
            for (int i = 0; i < n; i++) {
                vet[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }

            //declaração das variaveis para achar o maior valor dentro do vetor e também sua posição
            double maior = vet[0];
            int posicao = 0;

            //Logiaca para achar o maior valor e sua posição dentro do vetor
            for (int i = 0; i < n; i++) {
                if (vet[i] > maior) {
                    maior = vet[i];
                    posicao = i;
                }
            }

            //Saída de dados
            Console.WriteLine($"Maior número no vetor é: {maior.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Sua posiçãop é a {posicao}");
        }
    }
}
