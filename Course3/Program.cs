using Course;
using Course3.Entidades;
using Course3.Entidades.Enums;

class Program
{
    static void Main(string[] args)
    {
        Order order = new Order
        {
            Id = 1080,
            Moment = DateTime.Now,
            Status = Course3.Entidades.Enums.OrderStatus.PendingPayment
        };

        Console.WriteLine(order);
        string txt = OrderStatus.PendingPayment.ToString();

        Console.WriteLine(txt);
    }
}