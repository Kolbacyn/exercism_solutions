public enum Allergen
{
    Eggs,
    Peanuts,
    Shellfish,
    Strawberries,
    Tomatoes,
    Chocolate,
    Pollen,
    Cats
}

public class Allergies
{
    private readonly int mask;
    
    public Allergies(int mask)
    {
        this.mask = mask;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        int allergenBit = 1 << (int)allergen;
        return (mask & allergenBit) != 0;
    }

    public Allergen[] List()
    {
        List<Allergen> allergies = new List<Allergen>();
        foreach (Allergen allergen in Enum.GetValues(typeof(Allergen)))
        {
            if (IsAllergicTo(allergen))
                allergies.Add(allergen);
        }
        return allergies.ToArray();
    }
}