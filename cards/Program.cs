using System;
using System.Collections.Generic;
namespace cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Player David = new Player("David", new List<Card>());
            Deck F = new Deck();
            David.Draw(F);
            David.Discard(1);
        }
    }
}
