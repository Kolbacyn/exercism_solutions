abstract class Character
{
    protected string CharacterType { get; }
    protected Character(string characterType)
    {
        CharacterType = characterType ?? throw new ArgumentNullException(nameof(characterType));
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable() => false;

    public override string ToString()
    {
        return $"Character is a {CharacterType}";
    }
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target) => target.Vulnerable() ? 10 : 6;
}

class Wizard : Character
{
    private bool spellPrepared;
    
    public Wizard() : base("Wizard")
    {
        spellPrepared = false;
    }

    public override bool Vulnerable() => !spellPrepared;

    public override int DamagePoints(Character target) => spellPrepared ? 12 : 3;

    public void PrepareSpell()
    {
        spellPrepared = true;
    }
}
