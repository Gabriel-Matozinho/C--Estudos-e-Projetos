namespace Projeto_Order.Entities
{
    internal class Product
    {
        // Propriedades do produto
        public string Name { get; set; }
        public double Price { get; set; }

        // Construtor padrão
        public Product()
        {
        }

        // Construtor com parâmetros para inicializar as propriedades
        public Product(string name,double price)
        {
            Name = name;
            Price = price;
        }
    }
}
