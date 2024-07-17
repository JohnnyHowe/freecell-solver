class Move
{
    public required Position origin;
    public required Position destination;

    public bool IsNonMove()
    {
        throw new NotImplementedException();
    }
}