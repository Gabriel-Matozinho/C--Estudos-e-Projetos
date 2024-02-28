using System;

namespace Matriz05 {
    internal class Program {
        static void Main(string[] args) {

            string[] s = Console.ReadLine().Split(' ');
            int l = int.Parse(s[0]);
            int c = int.Parse(s[1]);

            int[,] matA = new int[l,c];
            int[,] matB = new int[l, c];

            for (int i = 0;i < l;i++) {
                string[] s1 = Console.ReadLine().Split(' ');
                for (int j = 0;j < c;j++) {
                    matA[i,j] = int.Parse(s1[j]);
                }
            }
            
            for (int i = 0;i < l;i++) {
                string[] s2 = Console.ReadLine().Split(' ');
                for (int j = 0;j < c;j++) {
                    matB[i,j] = int.Parse(s2[j]);
                }
            }

            int[,] matC = new int[l,c];
            for (int i = 0;i < l;i++) {                
                for (int j = 0;j < c;j++) {
                    matC[i,j] = matA[i,j] + matB[i,j];
                }                
            }

            for (int i = 0; i < l; i++) {
                for (int j = 0; j < c; j++) {
                    Console.Write(matC[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}