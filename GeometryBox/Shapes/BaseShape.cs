using GeometryBox.Interfaces;

namespace GeometryBox.Shapes
{
    public abstract class BaseShape : IShape
    {
        public double _square;

        public abstract double GetArea();
    }
}
