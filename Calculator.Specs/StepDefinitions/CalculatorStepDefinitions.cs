using Calculator;

namespace MyManualTests.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private Double firstNumber;
        private Double secondNumber;
        private Double thirdNumber;

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            firstNumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            secondNumber = number;
        }

        [When("the two number are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            thirdNumber = Calculator.Calculator.Sum(firstNumber, secondNumber);
        }

        [Then("the result will be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            Assert.Equal(thirdNumber, result);
        }
    }
}