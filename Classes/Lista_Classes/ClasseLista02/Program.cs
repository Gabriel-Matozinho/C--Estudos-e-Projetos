using ClasseLista02;
using System;
using System.Collections.Generic;

    internal class Program {
        static void Main(string[] args) {

            List<Aluguel> alugueis = new List<Aluguel>(10);
            Console.Write("Quantos quartos serão alugados: ");
        
            int QuartosAlugados = int.Parse(Console.ReadLine());

            for(int i = 1; i <= QuartosAlugados; i++) {
                Console.WriteLine($"Aluguel #{i}");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                // Adiciona o aluguel à lista
                alugueis.Add(new Aluguel(nome,email,quarto));
            }

            Console.WriteLine("\nQuartos alugados:");
            for(int i = 0; i < alugueis.Count; i++) {
            // Verifica se há um aluguel na posição
            if(alugueis[i] != null) {
                Console.WriteLine($"{alugueis[i].Room}: {alugueis[i]}");
            }
        }
            
    }
}

