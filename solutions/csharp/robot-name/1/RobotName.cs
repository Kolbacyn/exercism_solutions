using System.Text;

public class Robot
{
    private static HashSet<string> usedNames = new HashSet<string>();
    private static Random random = new Random();

    private string name;
    
    public string Name
    {
        get
        {
            if (name == null)
            {
                name = GenerateUniqueName();
                usedNames.Add(name);
            }
            return name;
        }
    }

    public void Reset()
    {
        if (name != null)
        {
            usedNames.Remove(name);
            name = null;
        }
    }

    public static string GenerateUniqueName()
    {
        const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string newName;
        do
        {
            var sb = new StringBuilder(5);
            for (int i = 0; i < 2; i++)
            {
                sb.Append(letters[random.Next(letters.Length)]);
            }
            for (int i = 0; i < 3; i++)
            {
                sb.Append(random.Next(10));
            }
            newName = sb.ToString();
        } while (usedNames.Contains(newName));
        return newName;
    }
}