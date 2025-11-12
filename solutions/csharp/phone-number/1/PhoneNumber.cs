using System;
using System.Text.RegularExpressions;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        string digitsOnly = Regex.Replace(phoneNumber, @"\D", "");
        if (digitsOnly.Length == 11 && digitsOnly.StartsWith("1"))
        {
            digitsOnly = digitsOnly.Substring(1);
        }
        if (digitsOnly.Length != 10)
        {
            throw new ArgumentException("Invalid phone number format");
        }
        if (!Regex.IsMatch(digitsOnly, @"^[2-9]\d{2}[2-9]\d{6}$"))
        {
            throw new ArgumentException("Phone number does not conform to NANP format");
        }
        return digitsOnly;
    }
}