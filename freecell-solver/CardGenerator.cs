using System.Collections;

namespace JonathonOH.Freecell
{
    public class CardGenerator : IEnumerable<Card>
    {
        private List<Card> cards;

        public CardGenerator(int seed)
        {
            cards = new List<Card>();
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                for (int character = 0; character < 13; character++)
                {
                    cards.Add(new Card(suit, character));
                }
            }
            Shuffle(cards, seed);
        }

        private static void Shuffle<T>(List<T> list, int seed)
        {
            // Fisher-Yates shuffle algorithm
            Random rng = new Random(seed);
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<Card> GetEnumerator()
        {
            return cards.GetEnumerator();
        }

        public static GameState FromSeed(int seed)
        {
            IEnumerator<Card> cardGenerator = new CardGenerator(seed).GetEnumerator();

            List<List<Card>> tableau = new List<List<Card>>();
            for (int slotIndex = 0; slotIndex < 8; slotIndex++) tableau.Add(new List<Card>());

            int index = 0;
            while (cardGenerator.MoveNext())
            {
                tableau[index++ % 8].Add(cardGenerator.Current);
            }

            List<List<Card>> foundation = new List<List<Card>>();
            for (int slotIndex = 0; slotIndex < 4; slotIndex++) foundation.Add(new List<Card>());

            return new GameState(tableau, foundation, GameState.GetEmptyStock());
        }
    }
}