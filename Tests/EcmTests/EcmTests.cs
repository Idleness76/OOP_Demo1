using Demo;
using NUnit.Framework;

namespace Tests.EcmTests

{
  [TestFixture]
  public class EcmTests
  {
    private void TestEcm(EngineControlModule sut)
    {
      sut.Start();
      Assert.That(sut.IsRunning, Is.True);
      sut.Stop();
      Assert.That(sut.IsRunning, Is.False);
    }

    [Test]
    public void TestIceControlModule()
    {
      TestEcm(new IceControlModule());
    }

    [Test]
    public void TestElectricControlModule()
    {
      TestEcm(new ElectricControlModule());
    }

    [Test]
    public void TestHybridControlModule()
    {
      TestEcm(new HybridControlModule());
    }
  }

}
