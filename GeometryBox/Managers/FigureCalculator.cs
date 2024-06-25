using GeometryBox.Interfaces;

namespace GeometryBox.Managers
{
    public class FigureCalculator : IFigureCalculator
    {
        /// <summary>
        /// Used to get shape square in compile time without knowing which shape it is
        /// </summary>
        /// <param name="shape"></param>
        public double GetShapeSquare(IShape shape)
        {
            return shape.GetArea();
        }
    }
}
