namespace VetorClasse02 {
    internal class Program {
        static void Main(string[] args) {

            Aluguel[] aluguel = new Aluguel[10];
            Console.Write("Quantos quartos serão alugados: ");
            int QuantiaDeQuartosAlugados = int.Parse(Console.ReadLine());

            for(int i = 1; i <= QuantiaDeQuartosAlugados; i++) {
                Console.WriteLine($"Rent #{i}");
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                aluguel[i] = new Aluguel(nome,email,quarto);
            }
            Console.WriteLine();
            Console.WriteLine("Busy rooms");
            for(int i = 0; i < 10; i++) {
                if(aluguel[i] != null) {
                    Console.WriteLine(i + ": " + aluguel[i]);
                }
            }
        }
    }
}

