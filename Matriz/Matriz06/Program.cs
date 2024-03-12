using System;
using System.Globalization;

namespace Testes {
    internal class Program {
        static void Main(string[] args) {
            //Declaração das variáveis e entrada de dados
            int n = int.Parse(Console.ReadLine());
            double[,] mat = new double[n, n];

            //Leitura dos valores da Matriz
            for (int i = 0; i < n; i++) {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    mat[i, j] = double.Parse(s[j], CultureInfo.InvariantCulture);
                }
            }

            //Soma dos valores positivos da Matriz
            double soma = 0.0;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat[i, j] > 0) {
                        soma += mat[i, j];
                    }
                }
            }

            int linhaEscolhida = int.Parse(Console.ReadLine());
            double[] linha = new double[n];
            for (int j = 0; j < n; j++) {
                linha[j] = (double)mat[linhaEscolhida, j];
            }

            int colunaEscolhida = int.Parse(Console.ReadLine()); ;
            double[] coluna = new double[n];
            for (int i = 0; i < n; i++) {
                coluna[i] = (double)mat[i, colunaEscolhida];
            }

            Console.WriteLine($"SOMA DOS POSITIVOS:{soma.ToString("F1", CultureInfo.InvariantCulture)} ");
            Console.Write($"LINHA ESCOLHIDA: ");
            for (int j = 0; j < n; j++) {
                Console.Write(linha[j].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            Console.Write($"COLUNA ESCOLHIDA: ");
            for (int i = 0; i < n; i++) {
                Console.Write(coluna[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            Console.Write("DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < n; i++) {
                Console.Write(mat[i, i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            Console.WriteLine("MATRIZ ALTERADA: ");
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat[i, j] < 0) {
                        mat[i, j] = Math.Pow(mat[i, j], 2);
                    }
                }
            }

            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    Console.Write(mat[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
