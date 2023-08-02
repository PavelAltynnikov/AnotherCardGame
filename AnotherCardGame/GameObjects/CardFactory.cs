using AnotherCardGame.GameObjects.Characteristics;

namespace AnotherCardGame.GameObjects;

public class CardFactory : AbstractBattleObjectFactory
{
    private readonly Random _random = new();

    public CardFactory(List<string> names) : base(names) { }

    public override Card GetRandomItem()
    {
        return new Card(
            ChooseRandomName(),
            ChooseRandomStrength(),
            Enum<Elemental>.PickRandom(),
            new Alignment(
                Enum<Moral>.PickRandom(),
                Enum<Ethics>.PickRandom()
            )
        );
    }

    private int ChooseRandomStrength()
    {
        return _random.Next(1, 20);
    }
}