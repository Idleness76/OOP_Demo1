namespace Demo.Patterns.Strategy
{
  public class HighestPriceItemDiscount : IDiscountStrategy
  {
    public decimal Percentage { get; set; }
    public decimal GetDiscount(Order order)
    {
      return order.Items.Max(i => i.Price) * Percentage;
    }
  }
}
