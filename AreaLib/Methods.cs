namespace AreaLib
{
    public static class Methods
    {
        public static ShapeRegistry Registry { get; } = Initializer.InitializeShapeRegistry();
        private static string _lastError = string.Empty;
        
        public static string[] GetAvailableShapes()
        {
            return Registry.GetAvailableShapes();
        }

        public static double GetArea(string shapeName, double[] shapeParams)
        {
            _lastError = string.Empty;
            try
            {
                return Registry.GetArea(shapeName, shapeParams);
            }
            catch (Exception e)
            {
                _lastError = e.Message;
                return -1;
            }
        }

        public static string GetLastError()
        {
            return _lastError;
        }
    }
}