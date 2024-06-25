namespace GeometryBox.Shapes
{
    public class Triangle : BaseShape
    {
        private double[] _sides;

        public Triangle(double a, double b, double c) 
        {
            if (IsReal(a, b, c))
            {
                _sides = new double[3] { a, b, c };
            }
        }

        /// <summary>
        /// Method to get triangle area
        /// </summary>
        public override double GetArea()
        {
            var sorted = _sides = _sides.OrderBy(side => side).ToArray();
            double a = sorted[0];
            double b = sorted[1];
            double c = sorted[2];
            double p = (a + b + c) / 2;
            _square = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return _square;
        }

        /// <summary>
        /// Check if triangle is Right
        /// </summary>
        public bool IsRightAngled()
        {
            var sorted = _sides.OrderBy(side => side).ToArray();
            var isRight = Math.Pow(sorted[0], 2) + Math.Pow(sorted[1], 2) == Math.Pow(sorted[2], 2);
            return isRight;
        }

        /// <summary>
        /// Check if triangle can exist
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        private bool IsReal(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Triangle sides cannot be lower than 0");
            }

            if (a + b > c && a + c > b && b + c > a)
            {
                return true; 
            }

            throw new ArgumentException($"Triangle with sides [{a}, {b}, {c}] cannot exist");
        }

        public override string ToString()
        {
            return $"Triangle with sides a={_sides[0]}, b={_sides[1]}, c={_sides[2]}";
        }
    }
}
