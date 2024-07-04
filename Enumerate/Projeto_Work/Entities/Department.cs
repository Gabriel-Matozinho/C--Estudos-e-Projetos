namespace Projeto_Work.Entities
{
    internal class Department
    {
        // Propriedade para o nome do departamento
        public string Name { get; set; }

        // Construtor padrão
        public Department()
        {
        }

        // Construtor com parâmetro para inicialização do nome
        public Department(string name)
        {
            Name = name;
        }
    }
}