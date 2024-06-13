using System.Globalization;
namespace Empregado {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("How many employees will be registered: ");
            int n = int.Parse(Console.ReadLine());

            List<Empregado> empregados = new List<Empregado>();

            for (int i = 0; i < n; i++) {

                Console.WriteLine($"Emplyoee #{i+1}");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                empregados.Add(new Empregado(id,nome,salario));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int acharId = int.Parse(Console.ReadLine());

            Empregado emp = empregados.Find(x => x.Id == acharId);
            if(emp != null) {
                Console.Write("Enter the percentage: ");
                double porcentagem = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                emp.aumentarSalario(porcentagem);
            }

            else {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach(Empregado obj in empregados) {
                Console.WriteLine(obj);
            }
        }
    }
}