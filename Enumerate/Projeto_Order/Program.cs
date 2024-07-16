using Projeto_Order.Entities.Enum;
using Projeto_Order.Entities;
using System;
using System.Globalization;

namespace Projeto_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Entrada de dados do cliente
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            // Entrada de dados do pedido
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = (OrderStatus)Enum.Parse(typeof(OrderStatus),Console.ReadLine());

            // Criação do cliente e do pedido
            Client client = new Client(clientName,email,birthDate);
            Order order = new Order(DateTime.Now,status,client);

            // Entrada de dados dos itens do pedido
            Console.Write("How many items to this order: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine());

                Product product = new Product(productName,productPrice);

                Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(productQuantity,productPrice,product);
                order.AddItem(orderItem);
            }

            // Exibição do resumo do pedido
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}
