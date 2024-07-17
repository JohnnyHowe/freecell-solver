namespace JonathonOH.Freecell;
public class Move
{
    public required Position origin;
    public required Position destination;

    /// <summary>
    /// Would doing this move (regardless of whether it's legal or not) result in the same game state?
    /// </summary>
    public bool IsNonMove()
    {
        if (origin.area != destination.area) return false;
        if (origin.columnIndex != destination.columnIndex) return false;
        return true;
    }
}