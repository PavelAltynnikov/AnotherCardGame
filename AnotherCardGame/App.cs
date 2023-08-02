// TODO
// [x] Написать Card
// [x] Написать CardFactory
// [x] Написать Enemy
// [x] Написать EnemyFactory
// Написать Round
// Написать Game
// Написать Controller

using AnotherCardGame.GameObjects;

var cardsNames = GetCardsNames();
var cardFactory = new CardFactory(cardsNames);

var card = cardFactory.GetRandomItem();
Console.WriteLine(card.Name);
Console.WriteLine(card.Strength);
Console.WriteLine(card.Elemental);
Console.WriteLine(card.Alignment.Value);

var enemyNames = GetEnemyNames();
var enemyFactory = new EnemyFactory(enemyNames);

var enemy = enemyFactory.GetRandomItem();
Console.WriteLine(enemy.Name);
Console.WriteLine(enemy.Health);
Console.WriteLine(enemy.Elemental);
Console.WriteLine(enemy.Alignment.Value);

List<string> GetCardsNames()
{
    // Давайте представим, что эти имена приходят из файла или DB или ещё откуда.
    // В данном случае из https://jojo.fandom.com/ru/wiki/%D0%9A%D0%B0%D1%80%D1%82%D1%8B_%D0%A2%D0%B0%D1%80%D0%BE
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

List<string> GetEnemyNames()
{
    // Давайте представим, что эти имена приходят из файла или DB или ещё откуда.
    // В данном случае из https://heroesofthestorm.blizzard.com/ru-ru/heroes
    return new List<string>
    {
        "Дробитель",
        "Мэй",
        "Смертокрыл",
        "Кахира",
        "Андуин",
        "Империй",
        "Орфея",
        "Мал'Ганис",
        "Мефисто",
        "Вайтмейн",
        "Ирель",
        "Декард",
        "Феникс",
        "Майев",
        "Блэйз",
        "Хандзо",
        "Алекстраза",
        "Крысавчик",
        "Ана",
        "Кел'Тузад",
        "Гаррош",
        "Стуков",
        "Малтаэль",
        "D.Va",
        "Гэндзи",
        "Кассия",
        "Пробиус",
        "Лусио",
        "Валира",
        "Зул'джин",
        "Рагнарос",
        "Вариан",
        "Самуро",
        "Заря",
        "Аларак",
        "Ауриэль",
        "Гул'дан",
        "Медив",
        "Хроми",
        "Трейсер",
        "Дехака",
        "Зул",
        "Ли-Мин",
        "Седогрив",
        "Лунара",
        "Чо",
        "Галл",
        "Артанис",
        "Лейтенант Моралес",
        "Рексар",
        "Каразим",
        "Леорик",
        "Мясник",
        "Джоанна",
        "Кель'тас",
        "Сильвана",
        "Потерявшиеся викинги",
        "Тралл",
        "Джайна",
        "Азмодан",
        "Ануб'арак",
        "Чэнь",
        "Регар",
        "Загара",
        "Мурчаль",
        "Светик",
        "Ли Ли",
        "Тайкус",
        "Абатур",
        "Артас",
        "Диабло",
        "Иллидан",
        "Керриган",
        "Малфурион",
        "Мурадин",
        "Назибо",
        "Нова",
        "Рейнор",
        "Сержант Кувалда",
        "Соня",
        "Тираэль",
        "Тиранда",
        "Утер",
        "Валла",
        "Зератул",
        "E.T.C.",
        "Фалстад",
        "Газлоу",
        "Стежок",
        "Тассадар",
    };
}
