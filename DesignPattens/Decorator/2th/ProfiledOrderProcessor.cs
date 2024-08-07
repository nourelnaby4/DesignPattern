using System.Diagnostics;

namespace DesignPattens.Decorator._2th;

public class ProfiledOrderProcessor : IOrderProcessor
{
    private IOrderProcessor _processor { get; set; }
    public ProfiledOrderProcessor(IOrderProcessor processor) { 
        _processor = processor;
    }

    public void Process(Order order)
    {
        var stopwatch = Stopwatch.StartNew();

        _processor.Process(order);

        stopwatch.Stop();

        Console.WriteLine($"Processing time: {stopwatch.ElapsedMilliseconds} ms");

    }
}
