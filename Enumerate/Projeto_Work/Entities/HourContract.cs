using System;

namespace Projeto_Work.Entities
{
     class HourContract
    {
        // Propriedades do contrato de trabalho
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        // Construtor padrão
        public HourContract()
        {
        }

        // Construtor com parâmetros para inicialização das propriedades
        public HourContract(DateTime date,double valuePerHour,int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        // Método para calcular o valor total do contrato
        public double TotalValue()
        {
            return ValuePerHour * (double)Hours;
        }
    }
}