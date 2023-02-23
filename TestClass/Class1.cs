using NUnitDemonstration;
using NUnit.Framework;

namespace TestClass
{
    public class TriangleTest
    {
        [TestFixture]
        public class TriangleTest1
        {
            [Test]

            public void ValidTriangle_Input_60and60and60_OutputvalidTriangle()
            {

                int firstAngle = 60;
                int secondAngle = 400;
                int thirdAngle = 60;

                String expected = "The triangle is valid.";

                String Actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                Assert.AreEqual(expected, Actual);
            }
        }
    }
}