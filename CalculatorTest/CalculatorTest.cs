using AutoFixture;
using FluentAssertions;
using Moq;

namespace MathematicalOperations.Test
{
    public class CalculatorTest
    {
        private readonly Fixture _fixture;
        private readonly Operations _operacoes;
        private readonly Mock<ICalculator> _calculatorMock = new Mock<ICalculator>();

        public CalculatorTest()
        {
            _operacoes = new Operations(_calculatorMock.Object);
            _fixture = new Fixture();
        }

        [Fact]
        public void Sum_WhenTwoNumbersAreGiven_ShouldSumCorrectly_ByCalling_The_SumMethod()
        {
            //Arrange
            int num1 = _fixture.Create<int>();
            int num2 = _fixture.Create<int>();
            var expected = num1 + num2;

            _calculatorMock
               .Setup(x => x.Sum(num1, num2))
               .Returns(expected);

            //Act
            var result = _operacoes.ExecuteAddition(num1, num2);

            //Assert
            result.Should().Be(expected);

            _calculatorMock.Verify(x => x.Sum(num1, num2), Times.Once());
        }

        [Fact]
        public void Subtract_WhenTwoNumbersAreGiven_ShouldSubtractCorrectly_ByCalling_The_SubtractMethod()
        {
            //Arrange
            int num1 = _fixture.Create<int>();
            int num2 = _fixture.Create<int>();
            var expected = num1 + num2;

            _calculatorMock
                .Setup(x => x.Subtract(num1, num2))
                .Returns(expected);

            //Act
            var result = _operacoes.ExecuteSubtraction(num1, num2);

            //Assert
            result.Should().Be(expected);

            _calculatorMock.Verify(x => x.Subtract(num1, num2), Times.Once());
        }

        [Fact]
        public void Multiply_WhenTwoNumbersAreGiven_ShouldMultiplyCorrectly_ByCalling_The_MultiplyMethod()
        {
            //Arrange
            int num1 = _fixture.Create<int>();
            int num2 = _fixture.Create<int>();
            var expected = num1 + num2;

            _calculatorMock
                .Setup(x => x.Multiply(num1, num2))
                .Returns(expected);

            //Act
            var result = _operacoes.ExecuteMultapplication(num1, num2);

            //Assert
            result.Should().Be(expected);

            _calculatorMock.Verify(x => x.Multiply(num1, num2), Times.Once());
        }

        [Fact]
        public void Division_WhenTwoNumbersAreGiven_ShouldDivisionCorrectly_ByCalling_The_DivisionMethod()
        {
            //Arrange
            int num1 = _fixture.Create<int>();
            int num2 = _fixture.Create<int>();
            var expected = num1 + num2;

            _calculatorMock
                .Setup(x => x.Division(num1, num2))
                .Returns(expected);

            //Act
            var result = _operacoes.ExecuteDivision(num1, num2);

            //Assert
            result.Should().Be(expected);

            _calculatorMock.Verify(x => x.Division(num1, num2), Times.Once());
        }
    }
}