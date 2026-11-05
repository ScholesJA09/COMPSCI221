using System.Data;

namespace COMPSCI221
{
    public static class LE9
    {
        static void Main()
        {
            Order order1 = new Order(1234, 29.99, OrderStatus.New, OrderType.DineIn);
            Order order2 = new Order(2345, 39.99, OrderStatus.New, OrderType.TakeOut);
            Order order3 = new Order(3456, 19.99, OrderStatus.New, OrderType.Delivery);
            Order order4 = new Order(4567, 43.99, OrderStatus.New, OrderType.DineIn);
            Order order5 = new Order(5678, 14.99, OrderStatus.New, OrderType.TakeOut);
            Order order6 = new Order(6789, 59.99, OrderStatus.New, OrderType.Delivery);
            Order order7 = new Order(7890, 49.99, OrderStatus.New, OrderType.TakeOut);

            order1.Status = OrderStatus.Preparing;
            order3.Status = OrderStatus.Ready;
            order4.Status = OrderStatus.Ready;
            order5.Status = OrderStatus.Cancelled;
            order6.Status = OrderStatus.Completed;
            order7.Status = OrderStatus.Ready;

            Order[] orders = { order1, order2, order3, order4, order5, order6, order7 };

            for (int i = 0; i < orders.Length; i++)
            {
                Console.WriteLine(orders[i]);
            }
        }
    }
}