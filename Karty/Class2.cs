using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karty
{
    class Deck
    {
        List<Card> cards = new List<Card>();
        
        
        public void PrintCards()
        {
            for (int i = 0; i < cards.Length; i++)
                Console.WriteLine(cards[i].Name);
        }
    }
}
