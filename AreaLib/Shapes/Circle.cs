using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLib.Shapes
{
    internal class Circle : IShape
    {
        public double Area(double[] shapeParams)
        {
            if (shapeParams is null || shapeParams.Length != 1)
            {
                throw new ArgumentException("Wrong params count!", nameof(shapeParams));
            }

            double radius = shapeParams[0];
            double area = Math.PI * radius * radius;

            return area;
        }
    }
}
