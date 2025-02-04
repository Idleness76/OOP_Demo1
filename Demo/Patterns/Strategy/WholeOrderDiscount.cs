namespace Demo.Patterns.Strategy
{
  public class WholeOrderDiscount : IDiscountStrategy
  {
    public decimal Percentage { get; set; }
    public decimal GetDiscount(Order order)
    {
      return order.Items.Sum(i => i.Quantity * i.Price) * Percentage;
    }
  }
}
