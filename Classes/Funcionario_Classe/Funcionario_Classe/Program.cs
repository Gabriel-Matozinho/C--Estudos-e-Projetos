using System;
namespace Funcionario_Classe {
    internal class Program {
        static void Main(string[] args) {
            Funcionario f = new Funcionario();


            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine($"Funcionario: {f}");

            Console.WriteLine();
            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            double por = double.Parse(Console.ReadLine());
            f.AumentarSalario(por);

            Console.WriteLine();
            Console.WriteLine($"Dados Atualizados: {f}");

        }
    }
}