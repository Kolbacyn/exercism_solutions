using System.Text;

public static class RunLengthEncoding
{
    public static string Encode(string input)
    {
        if (string.IsNullOrEmpty(input))
            return "";

        var encoded = new StringBuilder();
        int count = 1;
        char prev = input[0];

        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] == prev)
                count++;
            else
            {
                if (count > 1)
                    encoded.Append(count).Append(prev);
                else
                    encoded.Append(prev);
                prev = input[i];
                count = 1;
            }
        }

        if (count > 1)
            encoded.Append(count).Append(prev);
        else
            encoded.Append(prev);
        return encoded.ToString();
    }

    public static string Decode(string input)
    {
        if (string.IsNullOrEmpty(input))
            return "";

        var decoded = new StringBuilder();
        int i = 0;

        while (i < input.Length)
        {
            int count = 0;
            while (i < input.Length && char.IsDigit(input[i]))
            {
                count = count * 10 + (input[i] - '0');
                i++;
            }

            if (count == 0) count = 1;

            if (i < input.Length)
            {
                char c = input[i];
                decoded.Append(new string(c, count));
                i++;
            }
        }
        return decoded.ToString();
    }
}
