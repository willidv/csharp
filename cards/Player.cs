using System;
using System.Collections.Generic;

namespace cards
{
    public class Player
    {
        public string Name;
        public List<Card> Hand = new List<Card>();

        public Player(string a, List<Card> b)
        {
            Name = a;
            Hand = b;
        }
        public void Draw(Deck currentdeck)
        {
            Hand.Add(currentdeck.Deal());
        }
        public Card Discard(int i)
        {
            if (i < Hand.Count)
            {
                Card discard_card = Hand[i];
                Hand.Remove(discard_card);
                return discard_card;
            }
            else
            {
                return null;
            }
        }
    }
}