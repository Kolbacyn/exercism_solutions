public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string[] parts = phoneNumber.Split(new string[] {"-"}, StringSplitOptions.None);
        bool isNY = parts[0] == "212";
        bool isFake = parts[1] == "555";
        string localNumber = parts[2];
        return (isNY, isFake, localNumber);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
