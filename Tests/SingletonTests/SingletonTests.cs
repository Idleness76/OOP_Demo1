using Demo.Patterns.Singleton;
using NUnit.Framework;

namespace Tests.SingletonTests
{
  [TestFixture]
  public class SingletonTests
  {
    [Test]
    public void Singleton_Instance_always_returns_the_same_object()
    {
      var instance1 = Singleton.Instance;
      var instance2 = Singleton.Instance;
      Assert.That(instance1.Value, Is.EqualTo(instance2.Value));
      Console.WriteLine($"{instance1.Value} == {instance2.Value}");
    }
  }
}