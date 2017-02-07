using Xunit;
using Triangle_Test.Services;

namespace Triangle_Test.Test
{
    public class Test
    {
        Triangle t = new Triangle();
        Program p = new Program();


        /// <summary>
        /// SUCCESS TEST CASEA
        /// </summary>

        [Fact]
        public void EquilateralTriangleSuccess()
        {
            Assert.Equal("Equilateral triangle", t.calculateTriangle(3, 3, 3));
        }

        [Fact]
        public void IsoscelestriangleSuccess()
        {
            Assert.Equal("Isosceles triangle", t.calculateTriangle(2, 2, 1));
        }

        [Fact]
        public void ScalenetriangleSuccess()
        {
            Assert.Equal("Scalene triangle", t.calculateTriangle(3, 4, 5));
        }



        /// <summary>
        /// FAILURE TEST CASEA
        /// </summary>

        [Fact]
        public void OnlyPositiveValuesFailure()
        {
            Assert.Equal("Invalid inputs", t.calculateTriangle(-1, 3, 3));
        }

        [Fact]
        public void NoZeroValueInputsFailure()
        {
            Assert.Equal("Invalid inputs", t.calculateTriangle(0, 3, 3));
        }

        [Fact]
        public void InequalityTestFailure()
        {
            Assert.Equal("Invalid inputs", t.calculateTriangle(1, 3, 6));
        }
    }
}
