using Enumerate01.Entities;
using System;
using Enumerate01.Entities.Enums;

namespace Enumerate01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Order order = new Order();
            Console.Write("Digite o ID: ");
            order.Id = int.Parse(Console.ReadLine());
            order.Moment = DateTime.Now;
            Console.Write("Status do pedido: ");
            order.Status = (OrderStatus)Enum.Parse(typeof(OrderStatus),"Delivered");
            Console.WriteLine(order);
        }
    }
}
