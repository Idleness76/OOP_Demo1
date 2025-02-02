using Demo;
using NUnit.Framework;

namespace Tests.CarTests.GasolineCarTests
{
    [TestFixture]
    public class When_the_Car_is_Stopped : Given_a_hybrid_Car
    {
        [SetUp]
        public void SetUp()
        {
            base.Setup();
            SUT.Stop();
        }

        [Test]
        public void Then_the_result_should_be_true()
        {
            Assert.That(SUT.IsRunning, Is.False);
        }
    }
}
