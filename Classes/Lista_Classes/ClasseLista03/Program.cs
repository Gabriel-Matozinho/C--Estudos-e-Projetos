using System.Globalization;

namespace ClasseLista03 {
    internal class Program {
        static void Main(string[] args) {

            // Lista de empregados
            List<Empregados> empregados = new List<Empregados>();
            Console.Write("Quantos empregados serão registrados: ");
            int RegistroEmpregados = int.Parse(Console.ReadLine());

            // Loop para registrar os empregados
            for(int i = 1; i <= RegistroEmpregados; i++) {
                Console.WriteLine($"Empregado: #{i}");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                empregados.Add(new Empregados(id,nome,salario));
                Console.WriteLine();
            }
            Console.WriteLine();

            // Aumento de salário para um empregado específico
            Console.Write("Entre com o Id do empregado que terá o salário aumentado: ");
            int acharId = int.Parse(Console.ReadLine());

            Empregados emp = empregados.Find(x => x.Id == acharId);
            if(acharId != null) {
            Console.Write("Entre com a porcentagem: ");
            double p = double.Parse(Console.ReadLine());
            emp.AumentarSalario(p);                 
            }
            else {
                Console.WriteLine("Este Id não existe");
            }

            // Exibição dos empregados em ordem crescente de ID
            Console.WriteLine("Atualização das listas de empregados");
            foreach(Empregados obj in empregados.OrderBy(e => e.Id)) {
                Console.WriteLine(obj);
            }
        }
    }
}
