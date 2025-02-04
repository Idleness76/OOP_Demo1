using Demo;
using NUnit.Framework;

namespace Tests.GeneratorTests
{
  [TestFixture]
  public abstract class Given_a_Generator
  {
    protected Generator SUT { get; set; }

    [SetUp]
    public virtual void SetUp()
    {
      SUT = new Generator();
    }
  }
}