using NUnit.Framework;
using NUnit.Framework.Legacy;
using NUnitDemonstration;

namespace TestClass
{
    public class Class1
    {
        [Test]

        public void TriangleTestOutput()
        {
            //arrange
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 60;

            string expected = "The triangle is valid.";
            // Adegbesan Adeoluwatomiwa wrote this code

            //act

            string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);


            //assert
            ClassicAssert.AreEqual(expected, actual);
        }
    }
}
