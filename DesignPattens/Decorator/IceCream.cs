namespace DesignPattens.Decorator;

//Execute
public class DecoratorPatten
{
    public void Run()
    {
        var order = new BasicIceCream();
        order = new Strawberry(order);
        order = new Banana(order);
        Console.WriteLine(order);
    }
}

// Decorator
public abstract class IceCream
{
    public abstract string Describtion {  get; }

    public abstract decimal CalculatTotal();
}

// Component
public  class BasicIceCream : IceCream
{
    public override string Describtion => "Basic Ice Cream";

    public override decimal CalculatTotal() => 3.5m;

    public override string ToString()
    {
        return $"{Describtion} : {CalculatTotal()}";
    }
}


// Additianal
public class Strawberry : BasicIceCream
{
    public IceCream _order { get; set; }

    public override string Describtion => $"{_order.Describtion} + Strawberry";

    public Strawberry(IceCream order)
    {
        _order = order; 
    }

    public override decimal CalculatTotal()=> _order.CalculatTotal() + 4.6m;
}


public class Banana : BasicIceCream
{
    public IceCream _order { get; set; }

    public override string Describtion => $"{_order.Describtion} + Banana";

    public Banana(IceCream order)
    {
        _order = order;
    }

    public override decimal CalculatTotal() => _order.CalculatTotal() + 10.6m;
}