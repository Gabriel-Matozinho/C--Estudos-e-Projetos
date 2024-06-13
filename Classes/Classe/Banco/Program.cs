using System.Globalization;
using System.Security.Cryptography;
namespace Teste {
    internal class Banco {
        static void Main(string[] args) {


            DadosBancarios conta;

            Console.WriteLine("dados da conta: ");
            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá deposito inicial (s/n)? ");
            char op = char.Parse(Console.ReadLine().ToUpper());
            if(op == 'S' || op == 's') {
                Console.Write("Entre o valor de depósito inicial: ");
                double deposito = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                conta = new DadosBancarios(numero,nome,deposito);
            }
            else {
                conta = new DadosBancarios(numero,nome);
            }

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre um valor para deposito: ");
            double dep = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            conta.Deposito(dep);
            Console.WriteLine("Dados da conta atualizado:");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            double saq = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            conta.Saque(saq);
            Console.WriteLine("Dados da conta atualizado:");
            Console.WriteLine(conta);


        }
    }
}
