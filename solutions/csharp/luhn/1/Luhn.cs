public static class Luhn
{
    public static bool IsValid(string number)
    {
        var digits = new List<int>();
        foreach (char ch in number)
        {
            if (Char.IsWhiteSpace(ch))
                continue;
            if (!Char.IsDigit(ch))
                return false;
            digits.Add(ch - '0');
        }

        if (digits.Count <= 1)
            return false;

        int sum = 0;
        bool doubleFlag = false;

        for (int i = digits.Count -1; i >= 0; i--)
        {
            int digit = digits[i];
            if (doubleFlag)
            {
                digit *= 2;
                if (digit > 9)
                    digit -= 9;
            }
            sum += digit;
            doubleFlag = !doubleFlag;
        }
        return sum % 10 == 0;
    }
}