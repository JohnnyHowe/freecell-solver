namespace JonathonOH.Freecell;
public class Position
{
    public Area area;
    public int columnIndex;
    public int rowIndex;    // always zero when area is stock 
}

public enum Area
{
    tableau,
    foundation,
    stock,
}