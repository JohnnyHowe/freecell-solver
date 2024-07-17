using static Cards;

namespace freecell_solver_tester;

[TestClass]
public class CardTester
{
    [TestMethod]
    public void TestIsRedDiamond()
    {
        Assert.IsTrue(d1.IsRed());
    }

    [TestMethod]
    public void TestIsRedHeart()
    {
        Assert.IsTrue(h1.IsRed());
    }

    [TestMethod]
    public void TestIsRedSpade()
    {
        Assert.IsFalse(s6.IsRed());
    }

    [TestMethod]
    public void TestIsRedClub()
    {
        Assert.IsFalse(c2.IsRed());
    }
}