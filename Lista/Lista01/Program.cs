global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;
using System.Globalization;


namespace ListaExercicio01 {
    internal class Program {
        static void Main(string[] args) {
            //Declaração do tamanho da lista na variável 'n' 
            int N = int.Parse(Console.ReadLine());

            //Declaração da lista em double
            List<double> numeros = new List<double>();

            //Passar os dados da lista na horizontal
            string[] s = Console.ReadLine().Split(' ');

            //Laço de interação para adicionar os valores na lista
            for (int i = 0; i < N; i++) {                
                numeros.Add(double.Parse(s[i], CultureInfo.InvariantCulture));
            }           

            //Achando o maior e em qual possição ele estará
            double maiorNumero = 0.0;
            int posicao = 0;

            for (int i = 0;i < N;i++) {
                if (numeros[i]>maiorNumero) {
                    maiorNumero = numeros[i];
                    posicao = i+1;
                }
            }
            Console.WriteLine(maiorNumero.ToString("F1",CultureInfo.InvariantCulture));
            Console.WriteLine(posicao);
            //Mostrando a lista na saída de dados
            foreach (double numero in numeros) {
                Console.Write(numero.ToString("F1",CultureInfo.InvariantCulture) + " ");
            }

        }
    }
}