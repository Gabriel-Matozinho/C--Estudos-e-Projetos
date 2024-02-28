using System;

namespace Matriz03 {
    internal class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n,n];

            for (int i = 0; i < n; i++) {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(s[j]);
                }                
            }

            int soma = 0;
            for(int i = 0; i < n; i++) {
                for(int j = 0;j < n; j++) {
                    if(j > i) {
                        soma += mat[i, j]; 
                    }
                }
            }
            Console.WriteLine(soma);
        }
    }
}