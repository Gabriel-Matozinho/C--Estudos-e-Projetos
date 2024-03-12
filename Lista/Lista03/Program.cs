using System.Diagnostics.CodeAnalysis;

namespace Lista03 {
    internal class Program {
        static void Main(string[] args) {

            // Declaração das variáveis 'int' e 'listas'
            //Entrada de dados
            int n = int.Parse(Console.ReadLine());
            List<int> A, B, C;

            // Vetores irão ter o tamanho do valor da variável 'n'
            A = new List<int>();
            B = new List<int>();
            C = new List<int>();

            //Vetores que irão receber os valores na horizontal
            string[] listaA = Console.ReadLine().Split(' ');
            string[] listaB = Console.ReadLine().Split(' ');

            //Laço de repetição
            for (int i = 0;i < n ;i++) {
                //Conversão de valores string na horizontal para inteiros na horizontal
                A.Add(int.Parse(listaA[i]));
                B.Add(int.Parse(listaB[i]));
            }
            
            //Somando duas listas e colocando o resultado em outra lista
            for (int i = 0; i < n ;i++) {
                C.Add(A[i]+B[i]);                
            }

            //Saída de dados da lista C
            foreach(int numeros in C) {
                Console.Write(numeros + " ");
            }    
        }
    }
}