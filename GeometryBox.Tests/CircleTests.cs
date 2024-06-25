namespace GeometryBox.Tests
{
    public class CircleTests
    {
        [Theory]
        [InlineData(1, 3.1415926535897931)]
        [InlineData(5, 78.539816339744831)]
        [InlineData(1.45, 6.6051985541725395)]
        [InlineData(4.63, 67.346007555739035)]
        [InlineData(0, 0)]
        [InlineData(0.0001, 3.1415926535897931E-08)]
        public void Circle_GetSquare_ReturnExpected(double rad, double expected)
        {
            var circle = new Circle(rad);

            var square = circle.GetArea();

            Assert.Equal(square, expected);
        }

        [Theory]
        [InlineData(-0.00001)]
        [InlineData(-1.3)]
        [InlineData(-5)]
        [InlineData(-7)]
        public void Circles_Constructor_ThrowArgsExeption(double rad)
        {
            Circle circle;

            var exc = Assert.Throws<ArgumentException>(() =>  circle = new Circle(rad));

            Assert.Equal("Radius cannot be lower than 0", exc.Message);
        }
    }
}