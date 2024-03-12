using System.Globalization;

namespace Lista04 {
    internal class Program {
        static void Main(string[] args) {
            // Declaração e entrada de dados em relação ao tamanho da lista
            int n = int.Parse(Console.ReadLine());

            // Lista terá o tamanho do valor da variável 'n'
            List<double> numeros = new List<double>();

            //Lista receberá os valores na horizontal
            string[] s = Console.ReadLine().Split(' ');

            //Laço de repetição
            for (int i = 0; i<n; i++) {
                //Conversão de valor string na horizontal para double na horizontal e adição a lista
                numeros.Add(double.Parse(s[i],CultureInfo.InvariantCulture));
            }

            //Metodos .sun() para somar os valores dentro da lista
            double total = numeros.Sum();

            //Media Aritmética
            double media = total / n;

            //Saída de dados da média aritmética
            Console.WriteLine(media.ToString("F3",CultureInfo.InvariantCulture));

            //Laço de repetição
            for (int i = 0;i<n; i++) {
                //Condição para a saída de dados apresentar apenas os valores abaixo da média 
                if(media > numeros[i]) {
                    //usando uma variável local para deixar o código mais limpo
                    double resultados = numeros[i];  
                    //Saída de dados
                    Console.WriteLine(resultados.ToString("F1",CultureInfo.InvariantCulture));
                }
            }
        }
    }
}