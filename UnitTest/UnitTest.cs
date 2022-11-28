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
            Assert.Pass();
        }
    }
}