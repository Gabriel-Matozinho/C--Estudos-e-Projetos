using System;

namespace Matriz07 {
    internal class Program {
        static void Main(string[] args) {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int[,] Mat = new int[M, N];

            for (int i = 0; i < M; i++) {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    Mat[i, j] = int.Parse(s[j]);
                }
            }
            int linhaEscolhida = int.Parse(Console.ReadLine());

            // Executar o exercício "girar fila"
            int ultimoSoldado = Mat[linhaEscolhida - 1, N - 1];
            for (int j = N - 1; j > 0; j--) {
                Mat[linhaEscolhida - 1, j] = Mat[linhaEscolhida - 1, j - 1];
            }
            Mat[linhaEscolhida - 1, 0] = ultimoSoldado;

            // Imprimir a formação do pelotão após a execução do exercício "girar fila"
            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                    Console.Write(Mat[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}