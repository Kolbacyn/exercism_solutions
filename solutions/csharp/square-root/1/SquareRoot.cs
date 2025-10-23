public static class SquareRoot
{
    public static int Root(int number)
    {
        if (number < 0) throw new ArgumentException("Cannot compute square root for a negative numbers");

        if (number == 0 || number == 1)
            return number;

        double tolerance = 0.00001;
        double guess = number / 2.0;
        double result;

        while (true)
        {
            result = 0.5 * (guess + number / guess);

            if (Math.Abs(guess - result) < tolerance)
                break;

            guess = result;
        }

        return (int)result;
    }
}
