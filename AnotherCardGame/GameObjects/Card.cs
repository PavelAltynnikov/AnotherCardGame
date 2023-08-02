using AnotherCardGame.GameObjects.Characteristics;

namespace AnotherCardGame.GameObjects;

public class Card : BattleObject
{
    public Card(string name, int strength, Elemental elemental, Alignment alignment) : base(name, elemental, alignment)
    {
        Strength = strength;
    }

    public int Strength { get; }
}