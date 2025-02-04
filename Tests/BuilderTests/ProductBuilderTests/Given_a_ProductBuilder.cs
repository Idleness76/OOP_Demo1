using Demo.Patterns.Builder;

namespace Tests.BuilderTests.ProductBuilderTests
{
  [TestFixture]
  public class Given_a_ProductBuilder
  {
    private ProductBuilder _sut = new ProductBuilder();

    [Test]
    public void Then_Build_returns_null()
    {
      Assert.That(_sut.Build(), Is.Null);
    }

    [Test]
    public void Then_ForProduct_returns_the_expected_Product()
    {
      var productA = ProductBuilder.ForProduct("A").WithLeftComponent(new Component3()).WithRightComponent(new Component2()).Build()!;
      Assert.That(productA.Name, Is.EqualTo("Product A"));
      Assert.That(productA.LeftComponent, Is.InstanceOf<Component3>());
      Assert.That(productA.RightComponent, Is.InstanceOf<Component2>());

      var productB = ProductBuilder.ForProduct("B").WithLeftComponent(new Component2()).WithRightComponent(new Component1()).Build()!;
      Assert.That(productB.Name, Is.EqualTo("Product B"));
      Assert.That(productB.LeftComponent, Is.InstanceOf<Component2>());
      Assert.That(productB.RightComponent, Is.InstanceOf<Component1>());

      Assert.That(() => ProductBuilder.ForProduct("C"), Throws.ArgumentException);
    }

  }
}
