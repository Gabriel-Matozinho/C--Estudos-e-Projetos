using System.Globalization;

namespace Lista05 {
    internal class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());
            
            List<int> numeros = new List<int>();

            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++) {
                numeros.Add(int.Parse(s[i]));
            }

            int soma = 0;
            int contPar = 0;
            for (int i = 0; i < n;i++) {
                if (numeros[i] % 2 == 0) {
                    soma += numeros[i];
                    contPar++;
                }
            }
            double media = (double)soma / contPar;
            Console.WriteLine(media.ToString("F1",CultureInfo.InvariantCulture));
        }
    }
}