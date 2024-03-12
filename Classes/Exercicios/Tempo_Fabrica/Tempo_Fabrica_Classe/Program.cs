
namespace Tempo_Fabrica_Classe {
    internal class Program {
        static void Main(string[] args) {

            SegundoParaHora x = new SegundoParaHora();

            Console.WriteLine("Tempo de Fabrica: ");
            double tempo = double.Parse(Console.ReadLine());

            double hor = x.RestHor(tempo);
            double resm = x.RestMin(tempo);
            double seg = x.Segundos();
            Console.WriteLine($"{hor}, {resm}, {seg}");
        }
    }
}