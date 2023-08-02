using AnotherCardGame.GameObjects.Characteristics;

namespace AnotherCardGame.GameObjects;

public class EnemyFactory : AbstractBattleObjectFactory
{
    private readonly Random _random = new();

    public EnemyFactory(List<string> names) : base(names) { }

    public override Enemy GetRandomItem()
    {
        return new Enemy(
            ChooseRandomName(),
            ChooseRandomHealth(),
            Enum<Elemental>.PickRandom(),
            new Alignment(
                Enum<Moral>.PickRandom(),
                Enum<Ethics>.PickRandom()
            )
        );
    }

    private int ChooseRandomHealth()
    {
        return _random.Next(1, 20);
    }
}