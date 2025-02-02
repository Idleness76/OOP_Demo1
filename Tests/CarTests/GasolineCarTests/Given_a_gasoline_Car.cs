using Demo;
using NUnit.Framework;

namespace Tests.CarTests.GasolineCarTests
{
    [TestFixture]
    public abstract class Given_a_hybrid_Car
    {
        protected Car SUT { get; set; }

        [SetUp]
        public virtual void Setup()
        {
            SUT = new Car(new IceControlModule());
        }
    }
}
