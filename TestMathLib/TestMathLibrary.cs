using System;
using TestingMathLibrary;
using Xunit;

namespace TestMathLib
{
    public class TestMathLibrary
    {
        [Theory] // allows for mult test attempts
        [InlineData(1,2,3)]
        [InlineData(6,2,8)]
        [InlineData(-1,-2,-3)]
        [InlineData(0,0,0)]
        [InlineData(200, 500,700)]
        [InlineData(int.MaxValue, int.MinValue, -1)]
        public void TestAdd(int i, int j, int ans)
        {
            var mathLib = new MathLib();
            Assert.Equal(ans, mathLib.Addition(i, j));


        }
        [Theory]
        [InlineData(-1, 0, -1)]
        [InlineData(10,5,5)]
        [InlineData(int.MinValue, int.MaxValue,1)]
        [InlineData(-2,-3,1)]
        public void TestSubtract(int i, int j, int ans)
        {
            var mathLib = new MathLib();
            Assert.Equal(ans, mathLib.Subtraction(i, j));

        }

        [Theory]
        [InlineData(0,1,0)]
        [InlineData(1,5,5)]
        [InlineData(5,4,20)]
        [InlineData(int.MaxValue,1,int.MaxValue)]
        public void TestMultiply(int i, int j, int ans)
        {
            var mathLib = new MathLib();
            Assert.Equal(ans, mathLib.Multiply(i, j));
        }


        [Theory]
        [InlineData(1,0,0)]
        [InlineData(0,1,0)]
        [InlineData(200,50,4)]
        [InlineData(int.MinValue,int.MaxValue,-1)]
        public void TestDivid(int i, int j, int ans)
        {
            var mathLib = new MathLib();
            if(j == 0)// only want this to go through if j is equal to 0
            {
// we expect an exception to be thrown, what exc we think will be thrown, lamda expresiion to call your method
                Assert.ThrowsAny<DivideByZeroException>(() => mathLib.Divide(i, j));
                return;
// need return 
            }
            Assert.Equal(ans, mathLib.Divide(i, j));
        }

    }
}
