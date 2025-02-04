using Demo.Patterns.Builder;

namespace Tests.BuilderTests.ProductBuilderTests
{
  [TestFixture]
  public class Given_a_ProductBuilder_for_Product_B
  {
    private ProductBuilder _sut = ProductBuilder.ForProductB();

    [Test]
    public void Then_Build_returns_Product_B()
    {
      Assert.That(_sut.Build()!.Name, Is.EqualTo("Product B"));
      Assert.That(_sut.Build()!.LeftComponent, Is.InstanceOf<Component2>());
      Assert.That(_sut.Build()!.RightComponent, Is.InstanceOf<Component3>());
    }

  }
}
