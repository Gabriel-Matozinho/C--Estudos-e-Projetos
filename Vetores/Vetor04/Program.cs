using System;
using System.Globalization;
namespace Vetor04 {
    internal class Program {
        static void Main(string[] args) {

            //Declaração de variáveis
            int n;
            double[] numeros;

            //Entrada de Dados
            n = int.Parse(Console.ReadLine());
            //Vetor irá ser do tamanho do valor de 'n' 
            numeros = new double[n];

            //Vetor 'string' para ler na horizontal os valores passados
            string[] s = Console.ReadLine().Split(' ');
            // Laço de repetição
            for(int i = 0; i < n; i++) {
                numeros[i] = double.Parse(s[i], CultureInfo.InvariantCulture); //Conversão dos valores 'string' para 'double'.
            }

            //Logica para somar os valores dentro do vetor
            //Declaração da variável que irá receber o valor da soma
            double soma = 0;
            //Laço de repetição
            for(int i = 0; i < n; i++) {
                soma = soma + numeros[i];//Soma recebe o valor dela mesma mais o valor dentro do vetor pelo indice 'i'.
            }

            //Logica para a media aritmética
            //Variável que irá receber o valor da média
            double media;
            //Como o valor da variável 'n' é do tipo int colocasse '(double)' antes da expressão matemática, para não gerar erro na sua depuração.O C# pede para que se faça isso. 
            media = (double)soma / n;

            //Saída de dados
            Console.WriteLine($"{media.ToString("F3", CultureInfo.InvariantCulture)}");
            for (int i = 0; i < n; i++) {
                if (numeros[i] < media) {
                    Console.WriteLine(numeros[i].ToString("F1",CultureInfo.InvariantCulture));
                }
            }
        }
    }
}