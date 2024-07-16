namespace Projeto_Order.Entities
{
    internal class OrderItem
    {
        // Propriedades do item do pedido
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        // Construtor padrão
        public OrderItem()
        {
        }

        // Construtor com parâmetros para inicializar as propriedades
        public OrderItem(int quantity,double price,Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        // Método para calcular o subtotal do item (quantidade * preço)
        public double SubTotal()
        {
            return Quantity * Price;
        }

        // Sobrescrita do método ToString para exibir informações do item do pedido
        public override string ToString()
        {
            return Product.Name
                + ", $"
                + Price.ToString("F2")
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + SubTotal().ToString("F2");
        }
    }
}
