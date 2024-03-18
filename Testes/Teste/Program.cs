using System.Globalization;

namespace Teste {
    internal class Program {
        static void Main(string[] args) {
            
            //Passe a quantia de planetas
            int planetas  = int.Parse(Console.ReadLine());

            //Trabalhando com listas
            //Listas para os nomes dos planetas
            List<string> nome = new List<string>();
            //Listas para distancia media do sol
            List<double> distancia = new List<double>();
            //Listas para densidade relativa média
            List<double> densidade = new List<double>();

            //Loop para passar os dados na horizontal
            for (int i = 0; i < planetas; i++) {
                string[] s = Console.ReadLine().Split(' ');
                nome.Add(s[0]);
                distancia.Add(double.Parse(s[1],CultureInfo.InvariantCulture));
                densidade.Add(double.Parse(s[2],CultureInfo.InvariantCulture));
            }

            //loop para lógica matemática da questão
            double soma = 0.0;
            int cont = 0;
            for (int i = 0;i < planetas; i++) {
                if (distancia[i] > 3.0 || densidade[i] < 2.5) {
                    soma++;                    
                }
            }
            double media = soma / 11 * 100;

            //Saída de dados
            Console.WriteLine(media.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}