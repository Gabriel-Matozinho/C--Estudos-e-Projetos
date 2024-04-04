using System;
using System.Globalization;

namespace Basico_Classes {
    internal class Program {
        static void Main(string[] args) {

            /*
            Pessoa x, y;
            x = new Pessoa();
            y = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            x.nome = Console.ReadLine();
            Console.Write("Idade: ");
            x.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            y.nome = Console.ReadLine();
            Console.Write("Idade: ");
            y.idade = int.Parse(Console.ReadLine());

            if (x.idade > y.idade) {
                Console.WriteLine($"{x.nome}");
            }
            else {
                Console.WriteLine($"{y.nome}");
            }
            */

            Funcionario x, y;
            x = new Funcionario();
            y = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            x.nome = Console.ReadLine();
            Console.Write("Salário: ");
            x.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            y.nome = Console.ReadLine();
            Console.Write("Salário: ");
            y.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario_medio = (x.salario + y.salario) / 2;

            Console.Write($"Salário médio: {salario_medio.ToString("F2")}",CultureInfo.InvariantCulture);
        }
    }
}