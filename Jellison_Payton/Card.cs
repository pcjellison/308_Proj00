using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jellison_Payton
{
    public class Card
    {
        public string Suit { set; get; }
        public string Rank { set; get; }
        public int Value { set; get; }
        public int Number { set;  get; }

        public Card ()
        {
            Value = -1;
            Suit = "";
            Rank = "";
            Number = -1;
        }
    }
}
