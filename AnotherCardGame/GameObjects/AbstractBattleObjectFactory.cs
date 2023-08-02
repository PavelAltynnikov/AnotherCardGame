namespace AnotherCardGame.GameObjects;

public abstract class AbstractBattleObjectFactory
{
    private readonly Random _random = new();
    private readonly List<string> _names;

    protected AbstractBattleObjectFactory(List<string> names)
    {
        _names = names;
    }

    public List<BattleObject> GetRandomItems(int amount)
    {
        var cards = new List<BattleObject>();

        for (var i = 0; i < amount; i++)
        {
            cards.Add(GetRandomItem());
        }

        return cards;
    }

    public abstract BattleObject GetRandomItem();


    protected string ChooseRandomName()
    {
        int randomIndex = _random.Next(_names.Count);
        return _names[randomIndex];
    }
}