using Projeto_Order.Entities.Enum;
using System.Globalization;
using System.Text;

namespace Projeto_Order.Entities
{
    internal class Order
    {
        // Propriedades do pedido
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        // Construtor padrão
        public Order()
        {
        }

        // Construtor com parâmetros para inicializar as propriedades
        public Order(DateTime moment,OrderStatus status,Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        // Método para adicionar um item ao pedido
        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        // Método para remover um item do pedido
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        // Método para calcular o total do pedido somando os subtotais dos itens
        public double Total()
        {
            double sum = 0.0;
            foreach(OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        // Sobrescrita do método ToString para exibir informações do pedido
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");
            foreach(OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2",CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
