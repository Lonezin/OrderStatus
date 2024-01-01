using Course.Entities;
using Course.Entities.Enums;

namespace Course
{
    class Program
    {
        static void Main (string[] args)
        { 
            Order order = new Order{
                Id = 10,
                Moment = DateTime.Now,
                Status = OrderStatus.PedingPayment
            };
            System.Console.WriteLine(order);
        }
    }
}


