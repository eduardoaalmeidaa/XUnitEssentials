using MathematicalOperations.Test;

namespace MathematicalOperations
{
    public class Operations
    {
        private readonly ICalculator _calculator;
        public Operations(ICalculator calculator)
        {
            _calculator = calculator;
        }

        public int ExecuteAddition(int num1, int num2)
        {
            return _calculator.Sum(num1, num2);
        }

        public int ExecuteSubtraction(int num1, int num2)
        {
            return _calculator.Subtract(num1, num2);
        }

        public int ExecuteMultapplication(int num1, int num2)
        {
            return _calculator.Multiply(num1, num2);
        }

        public int ExecuteDivision(int num1, int num2)
        {
            return _calculator.Division(num1, num2);
        }
    }
}
