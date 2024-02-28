using System;
using System.Globalization;


namespace ConversorDolar {
    internal class Program {
        static void Main(string[] args) {


            Console.Write("Qual é a cotação do dólar: ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = ConversorDeMoeda.Convercao(quantia, cotacao);

            Console.WriteLine($"Valor a ser pago em reais = {resultado.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}