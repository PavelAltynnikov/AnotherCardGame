namespace AnotherCardGame.GameObjects.Characteristics;

public class Alignment
{
    public Alignment(Moral moral, Ethics ethics)
    {
        Moral = moral;
        Ethics = ethics;
    }

    public Moral Moral { get; }

    public Ethics Ethics { get; }

    public int Value => (int)Moral * (int)Ethics;
}