
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

    public string GetAsciiBoard()
    {
        string s = "";
        for (int i = 0; i < foundation.Count; i++)
        {
            List<Card> slot = foundation[i];
            if (slot.Count == 0)
            {
                s += "---";
            }
            else
            {
                s += slot[slot.Count - 1].ToString().PadRight(3);
            }
            if (i < foundation.Count - 1) s += " ";
        }
        s += "|";
        for (int i = 0; i < stock.Count; i++)
        {
            List<Card> slot = stock[i];
            if (slot.Count == 0)
            {
                s += "---";
            }
            else
            {
                s += slot[slot.Count - 1].ToString().PadRight(3);
            }
            if (i < stock.Count - 1) s += " ";
        }
        for (int rowIndex = 0; rowIndex < tableau.Max(slot => slot.Count); rowIndex++)
        {
            s += "\n";
            for (int slotIndex = 0; slotIndex < tableau.Count; slotIndex++)
            {
                if (rowIndex < tableau[slotIndex].Count)
                {
                    s += tableau[slotIndex][rowIndex].ToString().PadRight(3);
                }
                else
                {
                    s += "   ";
                }
                if (slotIndex < tableau.Count - 1) s += " ";
            }
        }
        return s;
    }

    public static List<List<Card>> GetEmptyTableau() { return GetEmptyArea(8); }
    public static List<List<Card>> GetEmptyFoundation() { return GetEmptyArea(8); }
    public static List<List<Card>> GetEmptyStock() { return GetEmptyArea(4); }

    private static List<List<Card>> GetEmptyArea(int columns)
    {
        List<List<Card>> cards = new List<List<Card>>();
        for (int i = 0; i < columns; i++) cards.Add(new List<Card>());
        return cards;
    }

    public string GetCSharpString()
    {
        return $"GameState({GetCSharpString(tableau)}, {GetCSharpString(foundation)}, {GetCSharpString(stock)})";
    }

    private static string GetCSharpString(List<List<Card>> cards)
    {
        string s = "new List<List<Card>> { ";
        for (int slotIndex = 0; slotIndex < cards.Count; slotIndex++)
        {
            s += GetCSharpString(cards[slotIndex]);
            if (slotIndex < cards.Count - 1) s += ", ";
        }
        s += " }";
        return s;
    }

    private static string GetCSharpString(List<Card> cards)
    {
        string s = "new List<Card> {";
        for (int cardIndex = 0; cardIndex < cards.Count; cardIndex++)
        {
            s += cards[cardIndex];
            if (cardIndex < cards.Count - 1) s += ",";
        }
        s += "}";
        return s;
    }
}