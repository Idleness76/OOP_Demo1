using System;
using Demo.Patterns.Strategy;

namespace Tests.StrategyTests
{
  [TestFixture]
  public class Given_a_HighestPriceItemDiscount
  {
    [Test]
    public void Then_the_discount_is_based_on_the_highest_priced_item()
    {
      var order = new Order
      {
        Items =
        {
          new OrderItem {Quantity=2, Price=10.0m},
          new OrderItem {Quantity=1, Price=5.0m},
          new OrderItem {Quantity=3, Price=2.5m},
        }
      };
      var sut = new HighestPriceItemDiscount { Percentage = 0.5m };
      Assert.That(5.0m, Is.EqualTo(sut.GetDiscount(order)));
    }
  }
}
