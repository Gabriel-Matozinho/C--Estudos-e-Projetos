using System;

namespace Matriz02 {
    internal class Program {
        static void Main(string[] args) {

            //Declaração das variáveis do valor inteiro e da Matriz
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n,n]; //Aqui a Matriz vai receber o valor inteiro 'n' duaz vezes pois será uma Matriz quadrada, isso é, linhas e colunas do mesmo tamanho

            //Primeiro loop para passar pelas linhas
            for (int i = 0; i < n; i++) {
                string[] s = Console.ReadLine().Split(' ');// Leitura dos valores na horizontal atraves do vetor de string[]
                //Segundo loop para passar pelas colunas
                for(int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(s[j]);//A Matriz na posição 'i,j' irá receber o valor inteiro passado no vetor de string[] no valor da posição 'j'
                }
            }

            //Somando os valores de cada linha da matriz
            //Primeiro loop para passar pelas linhas
            for (int i = 0;i < n; i++) {
                //Declara aqui a variável 'soma' pois a cada interação do segundo loop o valor dela volta para 0, assim podendo somar a proxima linha sem interferencia do valor da linha de cima
                //Segundo loop para passar pelas colunas
                int soma = 0;
                for (int j = 0; j < n;j++) {
                    //Logica para a soma da linha da Matriz
                    soma = soma + mat[i,j];                    
                }
                Console.WriteLine(soma);//Saída de dados
            }            
        }
    }
}