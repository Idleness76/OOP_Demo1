using NUnit.Framework;

namespace Tests.GeneratorTests
{
  [TestFixture]
  public class When_the_Generator_is_Started : Given_a_Generator
  {
    [SetUp]
    public override void SetUp()
    {
      base.SetUp();
      SUT.Start();
    }

    [Test]
    public void Then_IsRunning_is_true()
    {
      Assert.That(SUT.IsRunning, Is.True);
    }
  }
}