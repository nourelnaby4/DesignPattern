namespace DesignPattens.Decorator._2th;

public class DesignPattern2th
{
    public void Run()
    {
        var order = new Order();
        order.AddLine(1, 5, 1000);
        order.AddLine(6, 3, 2500);
        order.AddLine(3, 4, 1200);

        IOrderProcessor processor = new OrderProcessor();

        processor = new QueueOrderProcessor(processor);
        processor = new ProfiledOrderProcessor(processor);

        processor.Process(order);


        Console.ReadKey();
    }
}
