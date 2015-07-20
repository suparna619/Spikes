using System.Runtime.Versioning;
using NUnit.Framework;

namespace SpikeApp.Test
{
    [TestFixture]
    class CarTest
    {
        [Test]
        public void ShouldCreateCar()
        {
            Assert.AreEqual(2,2);
            Assert.AreNotEqual(2,4);
            
        }
    }
}
