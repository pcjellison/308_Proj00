using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jellison_Payton
{
    class User
    {
        public List<Card> cards = new List<Card>();
        public int Num_Cards { set; get; }
        public int Score { set; get; }
        public string result { set; get; }

        public User ()
        {
            
        }

        public void Add(Card card)
        {
            cards.Add(card);
        }

        public List<Card> GetHand
        {
            get
            {
                return cards;
            }
        }
    }
}
