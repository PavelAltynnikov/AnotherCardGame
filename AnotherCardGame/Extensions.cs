namespace AnotherCardGame;

public class Enum<T> where T : struct, IConvertible
{
    public static T PickRandom()
    {
        Array values = Enum.GetValues(typeof(T));
        var random = new Random();
        return (T)(values.GetValue(random.Next(values.Length)) ?? throw new InvalidOperationException());
    }
}
