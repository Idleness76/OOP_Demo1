using Demo;
using NUnit.Framework;

namespace Tests.CarTests.HybridCarTests
{
    [TestFixture]
    public class When_the_Car_is_Started : Given_a_hybrid_Car
    {
        [SetUp]
        public void SetUp()
        {
            base.Setup();
            var startable = (IStartable)SUT;
            startable.Start();
        }

        [Test]
        public void Then_the_result_should_be_true()
        {
            Assert.That(SUT.IsRunning, Is.True);
        }
    }
}
