// Importa enumerações definidas no projeto
using Projeto_Work.Entities.Enums;
// Importa funcionalidades básicas do .NET
using System;
// Importa funcionalidades de formatação cultural
using System.Globalization;
// Importa funcionalidades de coleções genéricas
using System.Collections.Generic;

namespace Projeto_Work.Entities
{
     class Worker
    {
        // Propriedades do trabalhador
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }

        // Lista de contratos de trabalho, já inicializada para evitar nulos
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        // Construtor padrão
        public Worker()
        {
        }

        // Construtor com parâmetros para inicialização das propriedades
        public Worker(string name,WorkerLevel level,double basesalary,Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = basesalary;
            Department = department;
            // Não é necessário inicializar a lista de contratos aqui
        }

        // Método para adicionar um contrato à lista
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        // Método para remover um contrato da lista
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        // Método para calcular a renda total em um determinado mês e ano
        public double Income(int year,int month)
        {
            // Começa com o salário base
            double sum = BaseSalary;
            // Percorre todos os contratos
            foreach(HourContract contract in Contracts)
            {
                // Verifica se o contrato é do ano e mês especificados
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    // Adiciona o valor total do contrato à soma
                    sum += contract.TotalValue();
                }
            }
            // Retorna a soma total
            return sum;
        }
    }
}