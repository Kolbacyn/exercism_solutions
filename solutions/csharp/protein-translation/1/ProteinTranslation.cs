public static class ProteinTranslation
{
    private static readonly Dictionary<string, string> codonMap = new Dictionary<string, string>
    {
        {"AUG", "Methionine"},
        {"UUU", "Phenylalanine"},
        {"UUC", "Phenylalanine"},
        {"UUA", "Leucine"},
        {"UUG", "Leucine"},
        {"UCU", "Serine"},
        {"UCC", "Serine"},
        {"UCA", "Serine"},
        {"UCG", "Serine"},
        {"UAU", "Tyrosine"},
        {"UAC", "Tyrosine"},
        {"UGU", "Cysteine"},
        {"UGC", "Cysteine"},
        {"UGG", "Tryptophan"},
        {"UAA", "STOP"},
        {"UAG", "STOP"},
        {"UGA", "STOP"}
    };
    
    public static string[] Proteins(string strand)
    {
        var proteins = new List<string>{};
        for (int i = 0; i < strand.Length; i += 3)
        {
            if (i + 3 > strand.Length)
            {
                break;
            }
            string codon = strand.Substring(i, 3);

            if (!codonMap.ContainsKey(codon))
                throw new ArgumentException("Invalid codon: " + codon);

            string protein = codonMap[codon];
            if (protein == "STOP")
                break;
            proteins.Add(protein);       
        }
        return proteins.ToArray();
    }
}