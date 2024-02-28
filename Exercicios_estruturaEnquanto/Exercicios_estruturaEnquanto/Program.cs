using System;

namespace Exercicios_estruturaEnquanto{
    class Program { 
        static void Main(string[] args) {
            /*
             Console.Write("Digite a senha: ");
             int senha = int.Parse(Console.ReadLine());

             while (senha!= 2002) {
                 Console.WriteLine("Senha incorreta");
                 Console.WriteLine("Tente novamente");
                 Console.Write("Digite a senha: ");
                 senha = int.Parse(Console.ReadLine());
             }
             Console.WriteLine("Senha correta");
             Console.ReadLine();
            */

            /*
            string[] cartersiano = Console.ReadLine().Split(' ');
            int x = int.Parse(cartersiano[0]);
            int y = int.Parse(cartersiano[1]);
            while (x != 0 || y != 0) {
                if (x > 0 && y > 0) {
                    Console.WriteLine("Q1");
                }
                else if (x < 0 && y > 0) {
                    Console.WriteLine("Q2");
                }
                else if (x < 0 && y < y) {
                    Console.WriteLine("q3");
                }
                else {
                    Console.WriteLine("Q4");
                }
                cartersiano = Console.ReadLine().Split(' ');
                x = int.Parse(cartersiano[0]);
                y = int.Parse(cartersiano[1]);
            }
            */

            /*
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            Console.WriteLine("Digite o combustivel desejado: ");
            Console.WriteLine("01.Alcool");
            Console.WriteLine("02.Gasolina");
            Console.WriteLine("03.Diesel");

            int codigo = int.Parse(Console.ReadLine());
            

            while (codigo != 4) {
                if (codigo < 0 || codigo > 4) {
                    Console.WriteLine("Digite um valor valido: ");
                    Console.WriteLine("01.Alcool");
                    Console.WriteLine("02.Gasolina");
                    Console.WriteLine("03.Diesel");
                }
                else if (codigo == 1) {
                    alcool++;
                }
                else if (codigo == 2) {
                    gasolina++;
                }
                else{
                    diesel++;
                }
                codigo = int.Parse(Console.ReadLine());                
            }
            Console.WriteLine("Muito Obrigado");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " +  diesel);
            Console.ReadLine();
            */
        }
    }
}
