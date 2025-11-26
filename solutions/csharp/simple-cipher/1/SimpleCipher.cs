using System;
using System.Text;

public class SimpleCipher
{
    private readonly string key;
    private static readonly Random random = new Random();
    
    public SimpleCipher()
    {
        var sb = new StringBuilder();
        for (int i = 0; i < 100; i++)
        {
            sb.Append((char)('a' + random.Next(26)));
        }
        key = sb.ToString();
    }

    public SimpleCipher(string key)
    {
        if (string.IsNullOrEmpty(key) || !IsLowercaseAlphabetic(key))
        {
            throw new ArgumentException("Key must be a non-empty string or lowercase letters.");
        }
        this.key = key;
    }
    
    public string Key 
    {
        get
        { return key; }
    }

    public string Encode(string plaintext)
    {
        return Process(plaintext, encode:true);
    }

    public string Decode(string ciphertext)
    {
        return Process(ciphertext, encode:false);
    }

    private string Process(string text, bool encode)
    {
        var res = new StringBuilder();
        for (int i = 0; i < text.Length; i++)
        {
            char c = text[i];
            if (char.IsLetter(c) && char.IsLower(c))
            {
                int textPos = c - 'a';
                int keyPos = key[i % key.Length] - 'a';
                int shifted = encode ? (textPos + keyPos) % 26 : (textPos - keyPos + 26) % 26;
                res.Append((char)(shifted + 'a'));
            }
            else
            {
                res.Append(c);
            }
        }
        return res.ToString();
    }

    private bool IsLowercaseAlphabetic(string s)
    {
        foreach (var ch in s)
        {
            if (ch < 'a' || ch > 'z')
            {
                return false;
            }
        }
        return true;
    }
}