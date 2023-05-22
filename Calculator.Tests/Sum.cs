namespace Calculator.Tests
{
    public class Sum
    {
        [Fact]
        public void SumTwoNumbers()
        {
            var n1 = 1;
            var n2 = 2;
            var result = Calculator.Sum(n1, n2);
            Assert.Equal(3, result);
        }
    }
}