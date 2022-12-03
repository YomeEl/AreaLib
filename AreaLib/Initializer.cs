using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLib
{
    internal static class Initializer
    {
        public static ShapeRegistry InitializeShapeRegistry()
        {
            ShapeRegistry shapeRegistry = new();
            shapeRegistry.RegisterShape<Shapes.Circle>();
            shapeRegistry.RegisterShape<Shapes.Triangle>();
            return shapeRegistry;
        }
    }
}
