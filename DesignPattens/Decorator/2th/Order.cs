namespace DesignPattens.Decorator._2th;

public class Order
{
    private List<OrderLine> _line = new();

    public IEnumerable<OrderLine> Lines => _line.AsReadOnly();

    public void AddLine(int itemId, double quantity ,decimal unitPrice)
    {
        _line.Add(new OrderLine { ItemId = itemId, Quantity = quantity, UnitPrice = unitPrice });
    }
}
