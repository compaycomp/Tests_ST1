using Xunit;
using Tests_ST1.Ping;

namespace Tests_ST1.Tests.PingTests
{
    public class CalculatorTest
    {
        [Fact]
        public void TestAdd()
        {
            int result = Calculator.Add(5, 3);
            int expected = 8;
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestSubtract()
        {
            int result = Calculator.Subtract(5, 3);
            int expected = 2;
            Assert.Equal(expected, result);
        }
    }
}
