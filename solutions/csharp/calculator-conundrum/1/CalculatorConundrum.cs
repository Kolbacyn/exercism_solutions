public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string? operation)
    {
        if (operation == null)
            throw new ArgumentNullException(nameof(operation));
        if (operation == string.Empty)
            throw new ArgumentException("Operation cannot be empty", nameof(operation));
        try
        {
            return operation switch
            {
                "+" => $"{operand1} {operation} {operand2} = {operand1 + operand2}",
                "*" => $"{operand1} {operation} {operand2} = {operand1 * operand2}",
                "/" => 
                    operand2 == 0 ?
                    "Division by zero is not allowed." :
                    $"{operand1} {operation} {operand2} = {operand1 / operand2}",
                _ => throw new ArgumentOutOfRangeException("Invalid operation", nameof(operation))
            };
        }
        catch (DivideByZeroException)
        {
            return "Division by zero is not allowed.";
        }
    }
}
