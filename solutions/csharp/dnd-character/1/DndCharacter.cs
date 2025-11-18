public class DndCharacter
{
    private static Random random = new Random();
    public int Strength { get; set; }
    public int Dexterity { get; set; }
    public int Constitution { get; set; }
    public int Intelligence { get; set; }
    public int Wisdom { get; set; }
    public int Charisma { get; set; }
    public int Hitpoints { get; set; }

    public static int Modifier(int score) =>
        (int)Math.Floor((score - 10) / 2.0);

    public static int Ability() 
    {
        List<int> rolls = new List<int>();
        for (int i = 0; i < 4; i++)
        {
            int roll = random.Next(1,7);
            rolls.Add(roll);
        }
        rolls.Sort();
        return rolls.Sum() - rolls[0]; 
    }

    public static DndCharacter Generate()
    {
        var character = new DndCharacter
        {
            Strength = Ability(),
            Dexterity = Ability(),
            Constitution = Ability(),
            Intelligence = Ability(),
            Wisdom = Ability(),
            Charisma = Ability()
        };
        character.Hitpoints = 10 + Modifier(character.Constitution);
        return character;
    }
}
