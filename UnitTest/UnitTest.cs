using AS2223_4G_INF_IngrassiaSamuele_Figure;

namespace UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCircle()
        {
            Circle shape = new Circle(5);

            Assert.That(Math.Round(shape.Area, 2), Is.EqualTo(78.54));
            Assert.That(Math.Round(shape.Perimeter, 2), Is.EqualTo(31.42));
        }

        [Test]
        public void TestSquare()
        {
            Square shape = new Square(5);

            Assert.That(shape.Area, Is.EqualTo(25));
            Assert.That(shape.Perimeter, Is.EqualTo(20));
        }

        [Test]
        public void TestRectangle()
        {
            Rectangle shape = new Rectangle(5, 10);


            Assert.That(shape.Area, Is.EqualTo(50));
            Assert.That(shape.Perimeter, Is.EqualTo(30));

        }
    }
}