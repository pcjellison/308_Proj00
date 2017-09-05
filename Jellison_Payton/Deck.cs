using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// FINISHED
/// Creates deck, shuffles, and deals(removes from deck)
/// </summary>
namespace Jellison_Payton
{
    public class Deck
    {
        List<Card> deckList = new List<Card>();
        public Deck()   //create deck
        {

        }

        public void createDeck()
        {
            deckList.Clear();
            int num = 1;
            while (num < 53)
            {
                for (int i = 0; i < 4; i++)  //For suit creation
                {

                    for (int j = 1; j < 14; j++)  //creates 13 cards for each suit
                    {
                        Card c = new Card();        //creates new card
                                                    //Assigns suits
                        if (i == 0)
                        {
                            c.Suit = "S";
                            c.Number = num;
                        }
                        else if (i == 1)
                        {
                            c.Suit = "C";
                            c.Number = num;
                        }
                        else if (i == 2)
                        {
                            c.Suit = "D";
                            c.Number = num;
                        }
                        else if (i == 3)
                        {
                            c.Suit = "H";
                            c.Number = num;
                        }
                        //Assigns Rank (Ace through King) and Point Value
                        if (j > 1 && j < 11)
                        {
                            int temp = j;
                            c.Value = j;
                            c.Rank = temp.ToString();
                            num++;
                        }
                        else if (j == 1)
                        {
                            c.Value = 11;
                            c.Rank = "A";
                            num++;
                        }
                        else if (j == 11)
                        {
                            c.Value = 10;
                            c.Rank = "J";
                            num++;
                        }
                        else if (j == 12)
                        {
                            c.Value = 10;
                            c.Rank = "Q";
                            num++;
                        }
                        else if (j == 13)
                        {
                            c.Value = 10;
                            c.Rank = "K";
                            num++;
                        }
                        deckList.Add(c);    //Adds card to the deck
                    }
                }
            }
        }

        public Card Deal (int num)
        {
            foreach(Card c in deckList)
            {
                if(c.Number == num)
                {
                    deckList.Remove(c);
                    return c;
                }
            }
            Console.WriteLine("Card not Found");
            return null;
        }
    }
}
