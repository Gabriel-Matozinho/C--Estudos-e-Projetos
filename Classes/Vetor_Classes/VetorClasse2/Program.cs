namespace VetorClasse02 {
    internal class Program {
        static void Main(string[] args) {


            //Entrada do vetor já declarando a quantia de vagas de quartos
            Aluguel[] aluguel = new Aluguel[10];

            //Entrada de dados para a quantia de vagas de quartos a serem alugados
            Console.Write("Quantos quartos serão alugados: ");
            int QuantiaDeQuartosAlugados = int.Parse(Console.ReadLine());

            //Laço de repetição
            for(int i = 1; i <= QuantiaDeQuartosAlugados; i++) { 
                //Saída de dados
                Console.WriteLine($"Rent #{i}");
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                aluguel[quarto] = new Aluguel(nome,email);
            }
            Console.WriteLine();
            Console.WriteLine("Busy rooms");
            for(int i = 0; i < 10; i++) {
                if(aluguel[i] != null) {//Condicional para verificar dentro do vetor quais são as posições que não estão com valores nulos 
                    Console.WriteLine(i + ": " + aluguel[i]); //Saida de dados com o override Tostring da classe 'aluguel'
                }
            }
        }
    }
}

