using System;
using Demo.Patterns.Strategy;

namespace Tests.StrategyTests
{
  [TestFixture]
  public class Given_a_PointOfSaleSystem
  {
    [Test]
    public void Then_the_best_discount_is_chosen_for_the_order()
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

      var sut = new PointOfSale
      {
        Discounts =
        {
          new HighestPriceItemDiscount{Percentage=0.5m},
          new WholeOrderDiscount{Percentage=0.15m},
        }
      };

      Assert.That(5.0m, Is.EqualTo(sut.GetBestDiscount(order)));
    }
  }
}
