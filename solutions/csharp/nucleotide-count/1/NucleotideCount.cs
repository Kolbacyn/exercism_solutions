public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        Dictionary<char, int> quantity = new Dictionary<char, int>
        {
            {'A', 0},
            {'C', 0},
            {'G', 0},
            {'T', 0}
        };

        for (int i = 0; i < sequence.Length; i++)
        {
            switch (sequence[i])
            {
                case 'G':
                    quantity['G'] += 1;
                    break;
                case 'T':
                    quantity['T'] += 1;
                    break;
                case 'A':
                    quantity['A'] += 1;
                    break;
                case 'C':
                    quantity['C'] += 1;
                    break;
                default:
                    throw new ArgumentException("Invalid nucleotide");
            }
        }
        return quantity;
    }
}