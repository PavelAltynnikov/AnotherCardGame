using System.Text;
using AnotherCardGame.GameObjects;

namespace AnotherCardGame;

public class IOController
{
    public int AskUserToSelectMove()
    {
        const string question = 
            "Что вы будете делать?\n" +
            "1. Сражаться.\n" +
            "2. Договариваться.\n" +
            "3. Выброшу карту и получу одну из колоды.\n";
        int[] moves = { 1, 2, 3 };

        const string hint = "Ваш ответ не распознан, вам нужно ввести одну из этих цифр: 1, 2, 3.\n";

        while (true)
        {
            Console.WriteLine(question);
            Console.Write("Ответ: ");
            var answer = Console.ReadLine();

            if (int.TryParse(answer, out int number) && moves.Contains(number))
            {
                return number;
            }

            Console.WriteLine(hint);
        }
    }

    public Card AskUserToSelectCard(List<Card> cards)
    {
        var cardsNames = cards.Select(c => c.Name).ToArray();

        var question = $"Какую карту вы будете использовать?\n{CreateCardsList(cards)}";
        var hint = $"Ваш ответ не распознан, вам нужно выбрать номер одной из карт: {string.Join("; ", cardsNames)}\n";

        while (true)
        {
            Console.WriteLine(question);
            Console.Write("Ответ: ");
            string? answer = Console.ReadLine();

            if (int.TryParse(answer, out int number) && number >= 0 && number < cards.Count)
            {
                return cards[number - 1];
            }

            Console.WriteLine(hint);
        }
    }

    private string CreateCardsList(List<Card> cards)
    {
        var cardsList = new StringBuilder();

        for (int i = 0; i < cards.Count; i++)
        {
            cardsList.AppendLine($"{i + 1}. {cards[i]}");
        }

        return cardsList.ToString();
    }
}