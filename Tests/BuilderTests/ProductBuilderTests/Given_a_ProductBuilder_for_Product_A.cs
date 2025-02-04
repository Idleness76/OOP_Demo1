using Demo.Patterns.Builder;

namespace Tests.BuilderTests.ProductBuilderTests
{
  [TestFixture]
  public class Given_a_ProductBuilder_for_Product_A
  {
    private ProductBuilder _sut = ProductBuilder.ForProductA();

    [Test]
    public void Then_Build_returns_Product_A()
    {
      Assert.That(_sut.Build()!.Name, Is.EqualTo("Product A"));
      Assert.That(_sut.Build()!.LeftComponent, Is.InstanceOf<Component1>());
      Assert.That(_sut.Build()!.RightComponent, Is.InstanceOf<Component2>());
    }

  }
}
