using JonathonOH.Freecell;

namespace freecell_solver_tester;

[TestClass]
public class MoveTester
{
    [TestMethod]
    public void TestIsNonMoveRegular()
    {
        Assert.IsFalse(new Move()
        {
            origin = new Position { area = Area.tableau, columnIndex = 0 },
            destination = new Position { area = Area.tableau, columnIndex = 2 },
        }.IsNonMove());
    }
}