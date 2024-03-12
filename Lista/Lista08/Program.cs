using System.ComponentModel.Design;
using System.Globalization;

namespace Lista08 {
    internal class Program {
        static void Main(string[] args) {

            //Entrada e declaração do valor da variável 'n'
            int n = int.Parse(Console.ReadLine());

            //Declaração das listas
            List<double> altura = new List<double>();
            List<char> sexo = new List<char>();

            //Loop para adicionar as alturas e so sexos nas respectivas listas
            for(int i = 0; i < n; i++) {
                string[] s = Console.ReadLine().Split(' ');
                altura.Add(double.Parse(s[0],CultureInfo.InvariantCulture));
                sexo.Add(char.Parse(s[1].ToUpper()));
            }

            //Declarações de variáveis para dar inicio a lógica matemática
            double maiorAltura = 0.0;//Para achar o maior comece sempre com o 0
            double menorAltura = altura[0];//Para achar o menor de inicio om o primeiro valor da lista
            double somaAlturaMulher = 0.0;
            int mulher = 0;
            int homens = 0;

            //Implementação da lógica matemática
            for (int i = 0;i < n;i++) {

                //Maior altura
                if(altura[i] > maiorAltura) {
                    maiorAltura = altura[i];
                }
                //Menor Altura
                if(altura[i] < menorAltura) {
                    menorAltura = altura[i];
                }
                //Somando a altura feminia
                if(sexo[i] == 'F') {
                    somaAlturaMulher += altura[i];
                    mulher++;
                }
                //Quantia de homens 
                if(sexo[i] == 'M') {
                    homens++;
                }
            }

            //Media da altura das pessoas do sexo feminino
            double mulherMedia = somaAlturaMulher / mulher;

            //Saída de dados
            Console.WriteLine($"Menor altura: {menorAltura.ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Maior altura: {maiorAltura.ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Media das alturas das mulheres: {mulherMedia.ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Numero de homens: {homens}");
        }
    }
}
