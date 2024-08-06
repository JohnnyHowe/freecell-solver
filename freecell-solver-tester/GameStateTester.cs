using System.Net;
using JonathonOH.Freecell;
using static JonathonOH.Freecell.Cards;

namespace freecell_solver_tester;

[TestClass]
public class GameStateTester
{
    [TestMethod]
    public void TestToCSharpString()
    {
        GameState gameState = new GameState(
            new List<List<Card>> {
                new List<Card> {d1, d3, s1},
                new List<Card> {d5, d8, s2},
                new List<Card> {s6, d10, s3},
                new List<Card> {},
                new List<Card> {h9, h10},
                new List<Card> {},
                new List<Card> {d9},
                new List<Card> {},
            },
            new List<List<Card>> {
                new List<Card> {h1, h2},
                new List<Card> {},
                new List<Card> {},
                new List<Card> {},
            },
            new List<List<Card>> {
                new List<Card> {s12},
                new List<Card> {},
                new List<Card> {d11},
                new List<Card> {},
            }
        );
        string expected = "GameState(new List<List<Card>> { new List<Card> {d1,d3,s1}, new List<Card> {d5,d8,s2}, new List<Card> {s6,d10,s3}, new List<Card> {}, new List<Card> {h9,h10}, new List<Card> {}, new List<Card> {d9}, new List<Card> {} }, new List<List<Card>> { new List<Card> {h1,h2}, new List<Card> {}, new List<Card> {}, new List<Card> {} }, new List<List<Card>> { new List<Card> {s12}, new List<Card> {}, new List<Card> {d11}, new List<Card> {} })";
        Console.WriteLine(gameState.GetCSharpString());
        Assert.AreEqual(expected, gameState.GetCSharpString());
    }
}