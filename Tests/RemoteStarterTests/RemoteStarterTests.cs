using Demo;
using NUnit.Framework;

namespace Tests.RemoteStarterTests
{
  [TestFixture]
  public class RemoteStarterTests
  {
    [Test]
    public void TestCarStarter()
    {
      var sut = new Car(new ElectricControlModule());
      var starter = new RemoteStarter(sut);
      starter.Start();
      Assert.That(sut.IsRunning, Is.True);
      starter.Stop();
      Assert.That(sut.IsRunning, Is.False);
    }

    [Test]
    public void TestGeneratorStarter()
    {
      var sut = new Generator();
      var starter = new RemoteStarter(sut);
      starter.Start();
      Assert.That(sut.IsRunning, Is.True);
      starter.Stop();
      Assert.That(sut.IsRunning, Is.False);
    }
  }
}