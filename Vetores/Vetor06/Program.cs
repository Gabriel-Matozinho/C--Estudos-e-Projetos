using System;

namespace Vetor06 {
    internal class Program {
        static void Main(string[] args) {

            int n;
            string[] nomes;
            int[] idades;

            n = int.Parse(Console.ReadLine());
            nomes = new string[n];
            idades = new int[n];

            for(int i = 0; i < n; i++) {
                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                idades[i] = int.Parse(s[1]);
            }

            int maiorIdade = idades[0];
            string identidade = nomes[0];
            for(int i = 0; i < n; i++) {
                if (idades[i] > maiorIdade) {
                    maiorIdade = idades[i];
                    identidade = nomes[i];
                }
            }
            Console.WriteLine($"Pessoa mais velha: {identidade}");
        }
    }
}