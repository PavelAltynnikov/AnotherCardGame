using AnotherCardGame.GameObjects.Characteristics;

namespace AnotherCardGame.GameObjects;

public class CardFactory
{
    private readonly Random _random = new();
    private readonly List<string> _names;

    public CardFactory(List<string> names)
    {
        _names = names;
    }

    public List<Card> GetRandomCards(int amount)
    {
        var cards = new List<Card>();

        for (var i = 0; i < amount; i++)
        {
            cards.Add(GetRandomCard());
        }

        return cards;
    }

    public Card GetRandomCard()
    {
        return new Card(
            ChooseRandomName(),
            ChooseRandomForce(),
            Enum<Elemental>.PickRandom(),
            new Alignment(
                Enum<Moral>.PickRandom(),
                Enum<Ethics>.PickRandom()
            )
        );
    }


    private string ChooseRandomName()
    {
        int randomIndex = _random.Next(_names.Count);
        return _names[randomIndex];
    }

    private int ChooseRandomForce()
    {
        return _random.Next(1, 20);
    }
}