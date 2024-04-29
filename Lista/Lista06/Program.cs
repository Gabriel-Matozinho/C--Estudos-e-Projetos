using System.Xml.Serialization;

namespace Lista06 {
    internal class Program {
        static void Main(string[] args) {

            //Entrada dados declaração das iterações do loop
            int n = int.Parse(Console.ReadLine());

            //Declaração das listas
            List<string> Nome = new List<string>();
            List<int> Idade = new List<int>();           

            //Loop de repetição
            for (int i = 0; i < n; i++) {
                //Vetore para passar os valores na horizontal
                string[] s = Console.ReadLine().Split(' ');
                Nome.Add(s[0]);                
                Idade.Add(int.Parse(s[1]);
            }

            int maiorIdade = Idade[0];
            string nome = Nome[0];
            for(int i = 0; i < n; i++) {
                if(Idade[i] > maiorIdade) {
                    maiorIdade = Idade[i];
                    nome = Nome[i];
                }
            }
            Console.WriteLine($"Pessoa mais velha: {nome}");
        }
    }
}
