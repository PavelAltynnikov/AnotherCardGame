using AnotherCardGame.GameObjects.Characteristics;

namespace AnotherCardGame.GameObjects;

public class Card
{
    public Card(string name, int strength, Elemental elemental, Alignment alignment)
    {
        Name = name;
        Strength = strength;
        Elemental = elemental;
        Alignment = alignment;
    }

    public string Name { get; }

    public int Strength { get; }

    public Elemental Elemental { get; }

    public Alignment Alignment { get; }
}