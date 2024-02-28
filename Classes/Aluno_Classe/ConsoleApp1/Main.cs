using System.Globalization;
using System;
using Aluno_Classe;

namespace AlunoPrincipal {
    internal class Principal {
        static void Main(string[] args) {

            Aluno aluno = new Aluno();

            Console.Write("Nome do Aluno: ");

            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");

            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Nota Final = {aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture)}");

            if (aluno.Aprovado()) {
                Console.WriteLine("Aprovado");
            }
            else {
                Console.WriteLine("Reprovado");
                Console.WriteLine($"Faltam : {aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)}, pontos");
            }
        }
    }
}