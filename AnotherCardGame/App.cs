// TODO
// [x] Написать Card
// [x] Написать CardFactory
// Написать Enemy
// Написать EnemyFactory
// Написать Round
// Написать Game
// Написать Controller

using AnotherCardGame.GameObjects;

var cardsNames = GetCardsNames();
var cardFactory = new CardFactory(cardsNames);

var card = cardFactory.GetRandomCard();
Console.WriteLine(card.Name);
Console.WriteLine(card.Strength);
Console.WriteLine(card.Elemental);
Console.WriteLine(card.Alignment.Value);

List<string> GetCardsNames()
{
    // Давайте представим, что эти имена приходят из файла или DB или ещё откуда.
    // В данном случае из jojo.fandom.com
    return new List<string>
    {
        "Дурак",
        "Маг",
        "Верховная Жрица",
        "Императрица",
        "Император",
        "Верховный Жрец",
        "Любовники",
        "Колесница",
        "Сила",
        "Отшельник",
        "Колесо Фортуны",
        "Справедливость",
        "Повешенный",
        "Смерть",
        "Умеренность",
        "Дьявол",
        "Башня",
        "Звезда",
        "Луна",
        "Солнце",
        "Суд",
        "Мир",
    };
}