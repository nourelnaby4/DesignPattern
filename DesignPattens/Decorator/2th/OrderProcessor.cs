namespace DesignPattens.Decorator._2th;

public class OrderProcessor : IOrderProcessor
{
    public void Process(Order order)
    {
        Thread.Sleep(Random.Shared.Next(1000,3000));

        Console.WriteLine("Order has been proccessed");
    }
}
