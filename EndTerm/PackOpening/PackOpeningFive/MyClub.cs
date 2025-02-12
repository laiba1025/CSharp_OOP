using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public Double AverageRating()
        {
            double sum = 0;
            if (cards.Count == 0)
            {
                return 0;
            }
            /*foreach (Card c in cards)
            {
                sum = sum + c.Rating();

            }*/
            
            for (int i = 0; i < cards.Count; i++)
            {
                sum = sum + cards[i].Rating();

            }
            return (sum / cards.Count);
        }
        public int EnglishPlayerCount()
        {
            int sum = 0;
            foreach (Card c in cards)
            {
                if(c.GetPlayer().Nat() == Nation.ENGLAND)
                {
                    sum++;
                }
            }
            return sum;
        }
        public List<string> AllEnglishPlayers()
        {
            List<string> list = new List<string>();
            foreach (Card c in cards)
            {
                if (c.GetPlayer().Nat() == Nation.ENGLAND)
                {
                    list.Add(c.GetPlayer().Name());
                }
            }
            return list;
        }
        public bool ExpensivePlayer()
        {
            bool l = false; 
            foreach (Card c in cards)
            {
                if(c.Cost() > 1000000)
                {
                    l = true;

                }

            }
            return l;

        }
        public (bool, string) BestSpanishPlayer()
        {
            bool l = false;
            int elem = 0;
            int MAX = 0;
            string empty = "";
            for (int i = 0; i < cards.Count; i++)
            {
                if (cards[i].GetPlayer().Nat() == Nation.SPAIN)
                {
                    l = true;
                    MAX = cards[i].Rating();
                    //elem = cards[i].GetPlayer().Name();
                    elem = i;

                }

            }
            if (l)
            {
                return (l, cards[elem].GetPlayer().Name());
            }
            else
            {
                return (l, empty);
            }



        }
        public (bool, int) MostExpensiveSpecialCost()
        {
            bool l = false;
            int max = 0;
            for (int i = 0;i < cards.Count;i++)
            {
                if (cards[i].Type() != None.Instance())
                {
                 
                  //  l = true;
                    if (max < cards[i].Cost())
                    {
                        l = true;
                        max = cards[i].Cost();
                    }

                }
                

            }
            return (l, max);
        }
    }
}
