using AnotherCardGame.GameObjects.Characteristics;

namespace AnotherCardGame.GameObjects;

public abstract class BattleObject
{
    protected BattleObject(string name, Elemental elemental, Alignment alignment)
    {
        Name = name;
        Elemental = elemental;
        Alignment = alignment;
    }

    public string Name { get; }

    public Elemental Elemental { get; }

    public Alignment Alignment { get; }

    public override string ToString()
    {
        return $"{nameof(Name)}: {Name};\t{nameof(Elemental)}: {Elemental};\t{nameof(Alignment)}: {Alignment};";
    }
}