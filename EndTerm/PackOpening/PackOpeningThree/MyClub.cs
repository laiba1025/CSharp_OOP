using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackOpening
{
    public class MyClub
    {
        public List<Card> cards = new List<Card>();

        public void JoinMyClub(Card card)
        {
            cards.Add(card);
        }
        public double AverageRating()
        {
            double cnt = 0;
            if (cards.Count == 0)
            {
              return 0;
            }

            for (int i = 0; i < cards.Count; i++)
            {
                cnt = cnt + cards[i].Rating();
            }

            return (cnt / cards.Count);
        }

        public int EnglishPlayerCount()
        {
            int count = 0;

            foreach (Card c in cards)
            {
                if (c.GetPlayer().Nat() == Nation.ENGLAND)
                {
                    count++;
                }
               
            }
            return count;
        }

        public List<string> AllEnglishPlayers()
        {
            List<string> names = new List<string>();
            foreach (Card c in cards) 
            {
                if (c.GetPlayer().Nat() == Nation.ENGLAND)
                {
                    names.Add(c.GetPlayer().Name());
                }
            }
            return names;
        }
        public (bool, string) BestSpanishPlayer()
        {
            bool l = false;
            int max = 0;
            int elem = 0;
            for (int c = 0; c < cards.Count; c++)
            {
                if (cards[c].GetPlayer().Nat() == Nation.SPAIN)
                {
                         max = cards[c].Rating();
                        l = true;
                        elem = c;
                    
                }
            }

            if (l)
            {
                return (l, cards[elem].GetPlayer().Name());
            }
            else
            {
                return (l, "");
            }
        }

        public bool ExpensivePlayer()
        {
           bool l = false;

           foreach (Card c in cards) 
            {
                if (c.Cost() > 1000000)
                {
                    l = true;
                }
           }
           return l;
        }
        
    }
}
