using System;
using System.Globalization;


namespace Vetor03 {
    internal class Program {
        static void Main(string[] args) {
        
            // Declaração das variáveis 'int' e 'vetores'
            int n;
            int[] A, B, C;

            //Entraada de dados
            n = int.Parse(Console.ReadLine());

            // Vetores irão ter o tamanho do valor da variável 'n'
            A = new int[n];
            B = new int[n];
            C = new int[n];

            //Vetores que irão receber os valores na horizontal
            string[] valorA = Console.ReadLine().Split(' ');
            string[] valorB = Console.ReadLine().Split(' ');

            //Laço de repetição
            for (int i = 0; i < n; i++) {

                //Conversão de valores string na horizontal para inteiros na horizontal
                A[i] = int.Parse(valorA[i]);
                B[i] = int.Parse(valorB[i]);                
            }

            //Logica da soma entre vetores na mesma posição
            int soma = 0;
            for(int i = 0; i<n; i++) {
                C[i] = A[i] + B[i]; // O vetor 'C' irá receber a soma dos valores de mesma posição dentro dos vetores 'A' e 'B'
                soma = C[i]; // Deixando o código limpo atribuindo à uma variavel o papel de receber a soma
                Console.Write(soma + " ");//Saída de dados
            }            
        }
    }
}