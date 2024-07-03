using Enumerate02.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerate02.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }

        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); //Já a instancia para não começar nula

        public Worker() 
        {        
        }

        public Worker(string name, WorkerLevel level, double basesalary,Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = basesalary;
            Department = department;
            //Não se instancia Listas em construtores - só em alguns casos
        }

        public void AddContract(HourContract contract) // Método para adicionar os dados dos trabalharoes no contrato
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)// Método para remover os dados dos trabalharoes no contrato
        {
            Contracts.Remove(contract);
        }

        public double Income(int year,int month)
        {
            double sum = BaseSalary; // Sálario base mensal, caso coloque um mes onde não houve contrato de trabalho o valor do sálario será o base
            foreach(HourContract contract in Contracts)// laço de repetição para percorrer a lista contratato da classe 'HourContract'
            {
                if(contract.Date.Year == year && contract.Date.Month == month)//Condição para verificar se na data selecionada houve contrato de serviço
                {
                    sum += contract.TotalValue();//Caso tenha contrato será acrescido no valor do salário base o valor das horas x o valor hora de serviço
                }
            }
            return sum; 
        }

    }
}
