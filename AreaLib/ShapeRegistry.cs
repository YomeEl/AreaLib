using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using AreaLib.Shapes;

namespace AreaLib
{
    public class ShapeRegistry
    {
        private Dictionary<string, Type> _shapes;

        public ShapeRegistry()
        {
            _shapes = new Dictionary<string, Type>();
        }

        public void RegisterShape<T>(string? name = null) where T : IShape
        {
            throw new NotImplementedException();
        }

        public string[] GetAvailableShapes()
        {
            throw new NotImplementedException();
        }

        public double GetArea(string shapeName)
        {
            throw new NotImplementedException();
        }
    }
}
