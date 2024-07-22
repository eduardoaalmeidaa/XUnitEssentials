namespace MathematicalOperations.Test
{
    public interface ICalculator
    {
        int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        int Division(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
