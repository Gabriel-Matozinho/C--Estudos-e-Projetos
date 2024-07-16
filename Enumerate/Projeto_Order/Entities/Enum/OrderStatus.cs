namespace Projeto_Order.Entities.Enum
{
    // Define um enum para representar o status do pedido
    enum OrderStatus: int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3,
    }
}
