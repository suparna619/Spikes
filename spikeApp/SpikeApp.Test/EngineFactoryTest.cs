using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using spikeApp;

namespace SpikeApp.Test
{
    class EngineFactoryTest
    {
        [Test]
        public void ShouldGetMaxSpeedForV4EngineAs100Kmph()
        {
            IEngine newEngine = EngineFactory.GetCarEngine("1");
            var newCar = new Car(newEngine);
            Assert.AreEqual("Maximum speed of engine V4 is 100", newCar.GetSpecifications());
        }

        [Test]
        public void ShouldGetMaxSpeedForV8EngineAs200Kmph()
        {
            IEngine newEngine = EngineFactory.GetCarEngine("2");
            var newCar = new Car(newEngine);
            Assert.AreEqual("Maximum speed of engine V8 is 200", newCar.GetSpecifications());
        }

        [Test]
        public void ShouldGetMaxSpeedForGLXEngineAs80Kmph()
        {
            IEngine newEngine = EngineFactory.GetCarEngine("3");
            var newCar = new Car(newEngine);
            Assert.AreEqual("Maximum speed of engine GLX is 80", newCar.GetSpecifications());
        }
    }
}
