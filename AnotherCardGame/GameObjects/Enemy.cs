using AnotherCardGame.GameObjects.Characteristics;

namespace AnotherCardGame.GameObjects;

public class Enemy : BattleObject
{
    public Enemy(string name, int health, Elemental elemental, Alignment alignment) : base(name, elemental, alignment)
    {
        Health = health;
    }

    public int Health { get; }
}