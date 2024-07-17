class Position
{
    public Area area;
    public int columnIndex;
    public int rowIndex;    // always zero when area is stock 
}

enum Area
{
    tableau,
    foundation,
    stock,
}