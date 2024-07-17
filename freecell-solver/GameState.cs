
namespace JonathonOH.Freecell;
public class GameState
{
    public readonly List<List<Card>> tableau;
    public readonly List<List<Card>> foundation;
    public readonly List<List<Card>> stock;

    public GameState(List<List<Card>> tableau, List<List<Card>> foundation, List<List<Card>> stock)
    {
        // todo throw error when arguments invalid
        this.tableau = tableau;
        this.foundation = foundation;
        this.stock = stock;
    }

    public override string ToString()
    {
        return "hoes";
    }

    public static List<List<Card>> GetEmptyTableau() { return GetEmptyArea(8); }
    public static List<List<Card>> GetEmptyFoundation() { return GetEmptyArea(8); }
    public static List<List<Card>> GetEmptyStock() { return GetEmptyArea(8); }

    private static List<List<Card>> GetEmptyArea(int columns)
    {
        List<List<Card>> cards = new List<List<Card>>();
        for (int i = 0; i < columns; i++) cards.Add(new List<Card>());
        return cards;
    }
}