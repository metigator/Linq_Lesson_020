using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQTut20
{
    public class Deck
    {
        private static Random rnd = new Random();
        public IEnumerable<Card> FillDeck()
        { 
                for (int i = 0; i < 52; i++)
                {
                    Card.Suites suite = (Card.Suites)(Math.Floor((decimal)i / 13));
                    int val = i % 13 + 2;
                    yield return (new Card(val, suite));
                } 
        }

        internal IEnumerable<Card> GetSample()
        {
            yield return FillDeck().Single(x => x.Value == 11 && x.Suite == Card.Suites.CLUBS);
            yield return FillDeck().Single(x => x.Value == 9 && x.Suite == Card.Suites.DIAMONDS);
            yield return FillDeck().Single(x => x.Value == 4 && x.Suite == Card.Suites.HEARTS);
            yield return FillDeck().Single(x => x.Value == 10 && x.Suite == Card.Suites.SPADES);
            yield return FillDeck().Single(x => x.Value == 3 && x.Suite == Card.Suites.HEARTS);
            yield return FillDeck().Single(x => x.Value == 6 && x.Suite == Card.Suites.HEARTS);
        }

        public IEnumerable<Card> Shuffle()
        { 
            return FillDeck().OrderBy(x=>rnd.Next());
        }

    }

}
