using System.Xml.Linq;

namespace NUnitDemonstration
{
    public static class Triangle
    {
        public static string ValidTriangle(int firstAngle, int secondAngle, int thirdAngle)
        {
            // Adegbesan Adeoluwatomiwa wrote this code

            string result;
            if ((firstAngle + secondAngle + thirdAngle) == 180) // changed the operator signs
            {
                result = "The triangle is valid.";
            }
            else
            {
                result = "The triangle is NOT valid.";
            }
            return result;
        }
    }
}
