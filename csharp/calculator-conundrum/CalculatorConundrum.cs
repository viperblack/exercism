using System;

public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string operation)
    {
        if (operand2 == 0)
        {
            return "Division by zero is not allowed.";
        }
        else
        {
            String stringCalc = String.Format("{0} {1} {2} = ", operand1, operation, operand2);
            switch (operation)
            {
                case "+":
                    return stringCalc + (operand1 + operand2).ToString();
                case "*":
                    return stringCalc + (operand1 * operand2).ToString();
                case "/":
                    return stringCalc + (operand1 / operand2).ToString();
                case null:
                    throw new ArgumentNullException();
                case "":
                    throw new ArgumentException();
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
