using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AreaLib
{
    public class ShapeRegistry
    {
        private Dictionary<string, Type> _shapes;

        public ShapeRegistry()
        {
            _shapes = new Dictionary<string, Type>();
        }

        public void RegisterShape<T>(string? name) where T : IShape
        {
            throw new NotImplementedException();
        }

        public string[] GetAvailableShapes()
        {
            throw new NotImplementedException();
        }

        public void GetArea(string shapeName)
        {
            throw new NotImplementedException();
        }
    }
}
