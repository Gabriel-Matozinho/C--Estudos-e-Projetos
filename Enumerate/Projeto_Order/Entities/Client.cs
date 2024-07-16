namespace Projeto_Order.Entities
{
    internal class Client
    {
        // Propriedades do cliente
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        // Construtor padrão
        public Client()
        {
        }

        // Construtor com parâmetros para inicializar as propriedades
        public Client(string name,string email,DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        // Sobrescrita do método ToString para exibir informações do cliente
        public override string ToString()
        {
            return Name
                + ", ("
                + BirthDate.ToString("dd/MM/yyyy")
                + ") - "
                + Email;
        }
    }
}
