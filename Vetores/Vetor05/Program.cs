using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace Vetor05 {
    internal class Program {
        static void Main(string[] args) {

            //Variáveis 
            int n;
            int[] numeros;

            //Entrada de dados
            n = int.Parse(Console.ReadLine());
            numeros = new int[n];
            //Vetor lido na horizontal
            string[] s = Console.ReadLine().Split(' ');

            //Laço de repetição
            for (int i = 0; i < n; i++) {
                numeros[i] = int.Parse(s[i]);//Vetor 'numeros' recebe os valores do vetor 's' convertidos para o tipo int
            }

            //Lógica para somar e contar apenas os valores positivos dentro do vetor
            int somaPar = 0;
            int contPar = 0;
            for (int i = 0;i < n; i++) {
                if (numeros[i] % 2 == 0){
                    somaPar = somaPar + numeros[i];
                    contPar++;
                }
            }
            double media;
            media =(double) somaPar / contPar;

            Console.WriteLine($"{media.ToString("F1", CultureInfo.InvariantCulture)}");
        }
    }
}