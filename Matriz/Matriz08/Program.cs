namespace Matriz08 {
    internal class Program {
        static void Main(string[] args) {

            int m, n;// Declaração de variáveis para o número de linhas e colunas da matriz
            int[,] matriz;// Declaração da matriz bidimensional

            // Leitura da primeira linha de entrada e separação dos valores
            string[] s1 = Console.ReadLine().Split(' ');
            m = int.Parse(s1[0]);
            n = int.Parse(s1[1]);
            matriz = new int[m, n];

            // Loop para leitura e preenchimento da matriz
            for(int i = 0; i < m; i++) {
                string[] s = Console.ReadLine().Split(' ');// Leitura de uma linha da matriz e separação dos valores
                for(int j = 0; j < n; j++) {
                    matriz[i,j] = int.Parse(s[j]);// Conversão de cada valor para inteiro e armazenamento na matriz
                }
            }

            // Solicitação do valor a ser procurado na matriz
            Console.Write("Escolha o valor: ");
            int x = int.Parse(Console.ReadLine());// Leitura e conversão do valor para inteiro

            // Loop para procurar o valor x na matriz
            for(int i = 0; i < m; i++) {
                for(int j = 0; j < n; j++) {
                    if(matriz[i,j] == x) {// Verificação se o valor na posição atual é igual a x
                        Console.WriteLine("Posição " + i + "," + j + ":");
                        if(j > 0) {
                            Console.WriteLine("Esquerda: " + matriz[i, j -1]);
                            // Verificação e impressão do valor à esquerda, se houver
                        }
                        if(i > 0) {
                            Console.WriteLine("Acima: " + matriz[i-1,j]);
                            // Verificação e impressão do valor acima, se houver
                        }
                        if(j < n - 1) {
                            Console.WriteLine("Direita: " + matriz[i,j + 1]);
                            // Verificação e impressão do valor à direita, se houve
                        }
                        if(i < m - 1) {
                            Console.WriteLine("Baixo: " + matriz[i+1,j]);
                            // Verificação e impressão do valor abaixo, se houver
                        }
                    }
                }
            }
        }
    }
}
