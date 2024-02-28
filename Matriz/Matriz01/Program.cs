using System;

namespace Matriz01 {
    internal class Program {
        static void Main(string[] args) {

            // Declaração das variáveis inteiras e da Matriz
            int l, c;
            int[,] numeros;

            //Usando o vetor de string para ler os valores na horizontal
            string[] s1 = Console.ReadLine().Split(' ');
            l = int.Parse(s1[0]);// Entrada de dados para quantia de linhas da Matriz;
            c = int.Parse(s1[1]);// Entrada de dados para quantia de colunas da Matriz;
            numeros = new int[l, c]; // Matriz recebe os valores das linhas e colunas

            //Primeiro loop for para se ler as linhas da Matriz
            for (int i = 0; i < l; i++) {
                string[] s = Console.ReadLine().Split(' ');//Usando o vetor de string para ler os valores na horizontal
                //Segundo loop, será usado para ler os valores de cada coluna dentro da linha.
                for (int j = 0; j < c; j++) {
                    numeros[i, j] = int.Parse(s[j]);//A Matriz na posição 'i,j', irá recer o valor declarado no vetor 'string[] s' na posição 'j' do loop for
                }
            }

            
            //Declaração da variavél para achar números negativos dentro da Matriz
            int negativos = 0;
            //Primeiro loop for para passar pelas linhas
            for (int i = 0; i < l; i++) {
                //Segundo loop para passar pelas colunas
                for (int j = 0; j < c; j++) {
                    //Lógica para achar os números negativos dentro da Matriz
                    if (numeros[i, j] < 0) {
                        negativos = numeros[i, j];
                        Console.WriteLine(negativos); //Saída de dados
                    }
                }
            }
        }
    }
}