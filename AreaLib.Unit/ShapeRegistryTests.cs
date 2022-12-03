using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLib.Unit
{
    internal class ShapeRegistryTests
    {
        [Test]
        public void RegisterShapeTest()
        {
            ShapeRegistry registry = new();
            Assert.That(registry.GetAvailableShapes(), Is.Empty);
        }
    }
}
