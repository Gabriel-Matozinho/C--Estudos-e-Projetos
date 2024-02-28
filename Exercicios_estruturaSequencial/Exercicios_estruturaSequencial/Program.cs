using System;
using System.Globalization;

namespace eX_estruturaSequencial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int x, y, soma;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            soma = x + y;
            Console.WriteLine($"SOMA = {soma}");
            Console.ReadLine();
            */

            /*
            double r, area ,pi = 3.14159;

            Console.Write("Valor do raio da circunferência: ");
            r = double.Parse(Console.ReadLine());
            area = pi * Math.Pow(r, 2);
            Console.WriteLine($"O Valor da área é {area.ToString("F4")}", CultureInfo.InvariantCulture);
            Console.ReadLine();
            */

            /*
            int a, b, c, d,resultado;

            Console.Write("Digite o 1º valor: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite o 2º valor: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Digite o 3º valor: ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Digite o 4º valor: ");
            d = int.Parse(Console.ReadLine());
            resultado = (a * b) - (c * d);
            Console.WriteLine($"DIFERENCA = {resultado}");
            Console.ReadLine();
            */

            /*
            string nf;
            int ht;
            double rht,salario;

            Console.Write("Número do código do funcionário: ");
            nf = Console.ReadLine();
            Console.Write("Valor recebido por hora de trabalho: ");
            ht = int.Parse(Console.ReadLine());
            Console.Write("Valor recebido por hora de trabalho: ");
            rht = double.Parse(Console.ReadLine());
            salario = (double)ht * rht;
            Console.WriteLine($"NUMBER = {nf}");
            Console.WriteLine($"SALARY = R${salario.ToString("F2")}");
            Console.ReadLine();
            */

            /*
            string codigo1, codigo2;
            int peca1, peca2;
            double valor1, valor2, tot;

            codigo1 = Console.ReadLine();
            peca1 = int.Parse(Console.ReadLine());
            valor1 = double.Parse(Console.ReadLine());

            codigo2 = Console.ReadLine();
            peca2 = int.Parse(Console.ReadLine());
            valor2 = double.Parse(Console.ReadLine());

            tot = ((double)peca1 * valor1) + ((double)peca2 * valor2);

            Console.WriteLine($"VALOR A PAGAR: {tot}");
            */

            double a, b, c, triangulo, circulo, trapezio, quadrado, retangulo;

            string[] vet = Console.ReadLine().Split(' ');
            a = double.Parse(vet[0]);
            b = double.Parse(vet[1]);
            c = double.Parse(vet[2]);

            triangulo = a * c / 2.0;
            circulo = 3.14159 * c * c;
            trapezio = (a + b) / 2.0 * c;
            quadrado = b * b;
            retangulo = a * b;
            Console.WriteLine($"TRIANGULO: {triangulo.ToString("F3")}");
            Console.WriteLine($"CIRCULO: {circulo.ToString("F3")}");
            Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3")}");
            Console.WriteLine($"QUADRADO: {quadrado.ToString("F3")}");
            Console.WriteLine($"retangulo: {retangulo.ToString("F3")}");
            Console.ReadLine();

        }
    }
}