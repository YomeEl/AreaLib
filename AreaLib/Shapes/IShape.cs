using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLib.Shapes
{
    public interface IShape
    {
        double Area(double[] shapeParams);
    }
}
