using GeometryBox.Interfaces;

namespace GeometryBox.Managers
{
    public class FigureCalculator : IFigureCalculator
    {
        /// <summary>
        /// Used to get shape square in compile time without knowing which shape it is
        /// </summary>
        /// <param name="shape"></param>
        /*
         * Насколько я понимаю данное решение реализует определение площади в рамках compile-time,
         * так как не требуется знать фигуру, а только что она реализует интерфейс фигуры.
         * Если же реализовывать для run-time, то надо было бы делать алгоритм
         * определения какая фигура задается по введеному количеству параметров, 
         * что требует договоренностей, так как 1 значение может быть как кругом, так и квадратом.
         */
        public double GetShapeSquare(IShape shape)
        {
            return shape.GetArea();
        }
    }
}
