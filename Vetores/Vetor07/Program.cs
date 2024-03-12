using System;
using System.Globalization;

namespace Vetor07 {
    internal class Program {
        static void Main(string[] args) {

            int n;
            string[] nomes;
            double[] notas1, notas2;

            n = int.Parse(Console.ReadLine());
            nomes = new string[n];
            notas1 = new double[n];
            notas2 = new double[n];

            for (int i = 0; i < n; i++) {
                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                notas1[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
                notas2[i] = double.Parse(s[2], CultureInfo.InvariantCulture);

            }

            Console.WriteLine("Alunos aprovados: ");
            double media = 0.0;
            string aprovados;
            for(int i = 0; i < n;i++) {
                media = (double)(notas1[i] + notas2[i]) / 2.0;
                if (media >= 6) {
                    aprovados = nomes[i];
                    Console.WriteLine(aprovados);
                }
            }               
        }
    }
}
