public class Card
{
    public Card(Suit suit, int value)
    {
        if (value > 12) throw new ArgumentException($"Cannot make card with value of {value}. Max value is 12 !");

        this.suit = suit;
        this.value = value;
    }

    public readonly int value;
    public readonly Suit suit;

    /// <summary>
    /// Is the suit a heart or diamond?
    /// </summary>
    /// <returns></returns>
    public bool IsRed()
    {
        return suit == Suit.heart || suit == Suit.diamond;
    }

    public override string ToString()
    {
        return $"{suit.ToString()[0]}{value}";
    }

    public override int GetHashCode()
    {
        return ToString().GetHashCode();
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        return GetHashCode() == obj.GetHashCode();
    }
}

public enum Suit
{
    diamond,
    heart,
    club,
    spade,
}