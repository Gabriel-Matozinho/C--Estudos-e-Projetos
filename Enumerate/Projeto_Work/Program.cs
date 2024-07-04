using Projeto_Work.Entities;
using Projeto_Work.Entities.Enums;
using System;
using System.Globalization;

namespace Projeto_Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lê o nome do departamento do console
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            // Lê o nome do trabalhador do console
            Console.Write("Name: ");
            string name = Console.ReadLine();
            // Lê o nível do trabalhador do console e converte para enum
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = (WorkerLevel)Enum.Parse(typeof(WorkerLevel),Console.ReadLine());
            // Lê o salário base do trabalhador do console
            Console.Write("Base salary: ");
            double basesalary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            // Cria um novo departamento
            Department dept = new Department(deptName);
            // Cria um novo trabalhador com os dados lidos
            Worker worker = new Worker(name,level,basesalary,dept);

            // Lê a quantidade de contratos do trabalhador
            Console.Write("How many contracts to this worker: ");
            int n = int.Parse(Console.ReadLine());

            // Loop para ler os dados de cada contrato
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                // Lê a data do contrato
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                // Lê o valor por hora do contrato
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                // Lê a duração do contrato em horas
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                // Cria um novo contrato de trabalho
                HourContract contract = new HourContract(date,valuePerHour,hours);
                // Adiciona o contrato ao trabalhador
                worker.AddContract(contract);
            }

            Console.WriteLine();
            // Lê o mês e ano para calcular a renda
            Console.Write("Enter month and year to calculate income (MM/YYYY) ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0,2));
            int year = int.Parse(monthAndYear.Substring(3));
            // Exibe os dados do trabalhador e a renda calculada
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year,month));
        }
    }
}