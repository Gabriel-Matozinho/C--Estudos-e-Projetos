using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empregados_Classe_Lista {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Quantos empregados deverão ser registrados: ");
            int empregadosRegistrado = int.Parse(Console.ReadLine());

            List<Empregados>lista = new List<Empregados>();

            for (int i = 0; i < empregadosRegistrado; i++) {
                Console.WriteLine($"Empregados #{i+1}");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                lista.Add(new Empregados(id,nome,salario));
                Console.WriteLine();
            }

            Console.Write("Entre com o id do empregado que irá receber o aumento de salário: ");
            int buscarId = int.Parse(Console.ReadLine());

            Empregados emp = lista.Find(x => x.Id == buscarId);
            if(emp != null) {
                Console.Write("Entre com a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                emp.AumentoSalario(porcentagem);
                Console.WriteLine();
            }

            else {
                Console.WriteLine("Esse id não existe");
            }

            Console.WriteLine("Atualização da lista dos empregados");
            foreach(Empregados obj in lista) {
                Console.WriteLine(obj);
            }
        }
    }
}
