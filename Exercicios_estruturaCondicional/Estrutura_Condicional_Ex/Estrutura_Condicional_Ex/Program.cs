using System;

namespace Estrutura_Condicional_Ex {
    internal class Program {
        static void Main(string[] args) {
            /*
            int numero;

            Console.Write("Digite o valor: ");
            numero = int.Parse(Console.ReadLine());
            if (numero < 0){
                Console.WriteLine("NEGATIVO");
            }
            else {
                Console.WriteLine("POSITIVO");
            }
            Console.ReadLine();
            */

            /*
            int numero;

            Console.Write("Digite um valor: ");
            numero = int.Parse(Console.ReadLine());
            if(numero % 2 == 0) {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
            Console.ReadLine();
            */

            /*
            string[] valores = Console.ReadLine().Split(' ');
            int a  = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);
            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("SÃO MULTIPLOS");
            }
            else {
                Console.WriteLine("Não são multiplos");
            }
            Console.ReadLine();
            */


            /*
            string[] hora = Console.ReadLine().Split(' ');
            int horainicial = int.Parse(hora[0]);
            int horafinal = int.Parse(hora[1]);
            int horajogada;

            if(horainicial < horafinal)
            {
                horajogada = horafinal - horainicial;
            }

            else
            {
                horajogada = 24 - horainicial + horafinal;
            }
            Console.WriteLine("O jogo durou " + horajogada + " hora(s)");
            Console.ReadLine();
            */


            /*
            string[] tabela = Console.ReadLine().Split(' ');
            int codigo = int.Parse(tabela[0]);
            int quantidade = int.Parse(tabela[1]);
            double resultado;

            if(codigo == 1)
            {
                resultado = quantidade * 4.0;
            }
            else if(codigo == 2)
            {
                resultado = quantidade * 4.5;
            }
            else if(codigo == 3) 
            {
                resultado = quantidade * 5.0;
            }
            else if(codigo == 3)
            {
                resultado = quantidade * 2.0;
            }
            else
            {
                resultado = quantidade * 1.5;
            }
            Console.WriteLine("Total: R$ " + resultado);
            Console.ReadLine();
            */

            /*

            double valor = double.Parse(Console.ReadLine());

            if (valor < 0.0 || valor > 100.0)
            {
                Console.WriteLine(" Fora do intervalor");
            }
             else if(valor < 25.0)
            {
                Console.WriteLine("Intervalo([0,25] ");
            }
            else if(valor < 50.0)
            {
                Console.WriteLine("Intervalo([25,50] ");
            }
            else if (valor < 75.0)
            {
                Console.WriteLine("Intervalo([50,75] ");
            }
            else
            {
                Console.WriteLine("Intervalo((75,100] ");
            }
            Console.ReadLine();
            */


            string[] cartesiano = Console.ReadLine().Split(' ');
            double x = double.Parse(cartesiano[0]);
            double y = double.Parse(cartesiano[1]);

            if (x == 0.0 && y == 0.0) {
                Console.WriteLine("Origem");
            }
            else if (x > 0.0 && y > 0.0) {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y >= 0.0) {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y < 0.0) {
                Console.WriteLine("Q3");
            }
            else {
                Console.WriteLine("Q4");
            }
            Console.ReadLine();

        }
    }
}
