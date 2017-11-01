using System;
using System.Collections.Generic;

namespace cards
{
    public class Deck
    {
        public List<Card> Cards = new List<Card>();

        public Deck()
        {
            Reset();
        }
        public void Reset()
        {
            string[] stringval = { "A", "K", "Q", "J", "10", "9", "8", "7", "6", "5", "4", "3", "2" };
            string[] suit = { "Clubs", "Diamonds", "Hearts", "Clubs" };
            foreach (string s in suit)
            {
                for (int i = 0; i <= stringval.Length; i++)
                {
                    Card newcard = new Card(stringval[i], s, i);
                }
            }
        }
        public Card Deal()
        {
            Card TopCard = Cards[0];
            Cards.Remove(TopCard);
            Console.WriteLine("The top card is a {0} of {1}", TopCard.stringVal, TopCard.suit);
            return TopCard;
        }
        public void Shuffle()
        {
            List<Card> NewDeck = new List<Card>();
            Random rand = new Random();
            for (int i = 0; i < 52; i++)
            {
                int j = rand.Next(0, Cards.Count);
                NewDeck.Add(Cards[j]);
                Cards.RemoveAt(j);
            }
            Cards = NewDeck;
        }
    }
}