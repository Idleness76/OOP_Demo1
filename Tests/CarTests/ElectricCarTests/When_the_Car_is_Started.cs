using Demo;
using NUnit.Framework;

namespace Tests.CarTests.ElectricCarTests
{
    [TestFixture]
    public class When_the_Car_is_Started : Given_an_electric_Car
    {
        [SetUp]
        public void SetUp()
        {
            base.Setup();
            SUT.Start();
        }

        [Test]
        public void Then_the_result_should_be_true()
        {
            Assert.That(SUT.IsRunning, Is.True);
        }
    }
}
