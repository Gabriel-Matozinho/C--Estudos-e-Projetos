using System;
using System.Globalization;
namespace Classe_Raio {
    internal class Program {
        static double Pi = 3.14;
        static void Main(string[] args) {
            Console.Write("Valor do Raio da esfera: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double volume = Volume(raio);
            Console.WriteLine(volume);
        }
        static double Volume(double r) {
            return (4.0 / 3.0) * (Pi * Math.Pow(r, 3));
        }        
    }
}