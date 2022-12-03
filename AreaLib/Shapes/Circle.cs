namespace AreaLib.Shapes
{
    internal class Circle : IShape
    {
        public double ComputeArea(double[] shapeParams)
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
