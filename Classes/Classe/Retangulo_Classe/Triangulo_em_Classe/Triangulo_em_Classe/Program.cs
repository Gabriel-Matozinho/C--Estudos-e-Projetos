using System;
using System.Globalization;
namespace Triangulo_em_Classe {
    internal class Program {
        static void Main(string[] args) 
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do primeiro Triangulo:");
            x.A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do segundo Triangulo:");
            y.A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Área de X: {x.Area().ToString("F2")}");
            Console.WriteLine($"Área de Y: {y.Area().ToString("F2")}");

            if(x.Area() > y.Area()) {
                Console.WriteLine($"Maior área: {x.Area().ToString("F2")}");
            }
            else {
                Console.WriteLine($"Maior área: {y.Area().ToString("F2")}");
            }

        }
    }
}