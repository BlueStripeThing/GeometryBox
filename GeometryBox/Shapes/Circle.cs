namespace GeometryBox.Shapes
{
    public class Circle : BaseShape
    {
        private double _radius;

        public Circle(double rad)
        {
            if (rad < 0)
            {
                throw new ArgumentException("Radius cannot be lower than 0");
            }

            _radius = rad;
        }

        /// <summary>
        /// Method to get circle's area
        /// </summary>
        /// <returns></returns>
        public override double GetArea()
        {
            _square = Math.PI * _radius * _radius;
            return _square;
        }

        public override string ToString()
        {
            return $"Circle with radius {_radius}";
        }
    }
}
