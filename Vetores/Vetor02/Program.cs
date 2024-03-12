using System;
using System.Globalization;

namespace Vetor02 {
    internal class Program {
        static void Main(string[] args) {

            //Declaração das variáveis
            int n;
            int[] numeros;

            //Entrada de dados
            n = int.Parse(Console.ReadLine());

            //Declarando o tamanho do vetor bvaseado no valor da variável 'n'
            numeros = new int[n];

            //Conversão para strinf para o vetor ser lido na horizontal
            string[] s = Console.ReadLine().Split(' '); 

            //Laço de repetição para os valores na horizontal que estão no vetor 's' serem recebidos pelo vetor 'numeros'
            for(int i = 0; i < n; i++) {
                numeros[i] = int.Parse(s[i]);
            }

            //variaveis para achar os numeros pares dentro do vetor e a sua quantidade
            int par = 0;
            int cont = 0;

            //Laço de repetição
            for(int i = 0; i < n; i++) {
                if (numeros[i] %2 == 0) { // condi~ção para buscar os valores pares dentro do vetor
                    par = numeros[i]; // variavel 'par' irá receber o número par que está dentro do vetor 'numeros'
                    cont++; //variaável que irá contabilizar a quantidade de números pares que seram encontrados dentro do vetor
                    Console.Write(par + " "); //Saída de dados
                }                
            }            
            Console.WriteLine();
            Console.WriteLine(cont);
        }
    }
}