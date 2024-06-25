namespace GeometryBox.Tests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(2, 3, 4, 2.9047375096555625)]
        [InlineData(3, 4, 5, 6)]
        [InlineData(1.34, 2.13, 3.10, 1.1684344309266999)]
        [InlineData(41.3, 56.1, 73.4, 1150.7279539491515)]
        [InlineData(3.1, 4.1, 5.1, 6.3541733333298343)]
        [InlineData(0.01, 0.02, 0.025, 9.4991775959816623E-05)]
        public void Triangle_GetSquare_ReturnExpected(double a, double b, double c, double expected)
        {
            var triangle = new Triangle(a, b, c);

            var square = triangle.GetArea();

            Assert.Equal(square, expected);
        }

        [Theory]
        [InlineData(3, 4, 5)]
        [InlineData(30, 40, 50)]
        public void Triangle_IsRightAngled_ReturnTrue(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);

            var isRightAngle = triangle.IsRightAngled();

            Assert.True(isRightAngle);
        }

        [Theory]
        [InlineData(2, 3, 4)]
        [InlineData(2, 3, 4.5)]
        [InlineData(3, 4, 5.00001)]
        [InlineData(2.99999, 4, 5.00001)]
        [InlineData(10, 15, 20)]
        public void Triangle_IsRightAngled_ReturnFalse(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);

            var isRightAngle = triangle.IsRightAngled();

            Assert.False(isRightAngle);
        }

        [Theory]
        [InlineData(-2, 3, 4)]
        [InlineData(2, -3.23, 4.5)]
        [InlineData(3, 4, -5.00001)]
        [InlineData(-2.99999, -4, -5.00001)]
        [InlineData(-0.0000001, 15, 3)]
        public void Triangle_Constructor_ThrowArgsException_CannotBeLower0(double a, double b, double c)
        {
            Triangle triangle;

            var exc = Assert.Throws<ArgumentException>(() => triangle = new Triangle(a, b, c));

            Assert.Equal("Triangle sides cannot be lower than 0", exc.Message);
        }

        [Theory]
        [InlineData(1, 3, 1)]
        [InlineData(0.1, 1, 2)]
        [InlineData(3, 2, 1)]
        [InlineData(3, 4, 7.00001)]
        [InlineData(6.5, 7.6, 14.5)]
        public void Triangle_Constructor_ThrowArgsException_CannotExist(double a, double b, double c)
        {
            Triangle triangle;

            var exc = Assert.Throws<ArgumentException>(() => triangle = new Triangle(a, b, c));

            Assert.Equal($"Triangle with sides [{a}, {b}, {c}] cannot exist", exc.Message);
        }
    }
}
