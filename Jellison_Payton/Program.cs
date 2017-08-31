using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jellison_Payton
{
    class Program
    {
        static void Main(string[] args)
        {
            int remaining = 100;
            int bet = 0;
            uxNewGame();
            bool[] cardsUsed = bool [52];
            uxShuffle();
            uxDealing();

            int uxNewGame()
            {
                Console.WriteLine("========== New Game ==========");
                Console.WriteLine("You have: $" + remaining);
                Console.Write("How much do you bet: ");
                bet = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You bet $" + bet);
                uxCreateDeck();
                return bet;
            }

            void uxShuffle()
            {

            }

            void uxDealing()
            {

            }

            void uxCreateDeck()
            {
                Dictionary<string, int> DeckList = new Dictionary<string, int>();

                DeckList.Add("AH", 1);
                DeckList.Add("2H", 2);
                DeckList.Add("3H", 3);
                DeckList.Add("4H", 4);
                DeckList.Add("5H", 5);
                DeckList.Add("6H", 6);
                DeckList.Add("7H", 7);
                DeckList.Add("8H", 8);
                DeckList.Add("9H", 9);
                DeckList.Add("10H", 10);
                DeckList.Add("JH", 10);
                DeckList.Add("QH", 10);
                DeckList.Add("KH", 10);

                DeckList.Add("AS", 1);
                DeckList.Add("2S", 2);
                DeckList.Add("3S", 3);
                DeckList.Add("4S", 4);
                DeckList.Add("5S", 5);
                DeckList.Add("6S", 6);
                DeckList.Add("7S", 7);
                DeckList.Add("8S", 8);
                DeckList.Add("9S", 9);
                DeckList.Add("10S", 10);
                DeckList.Add("JS", 10);
                DeckList.Add("QS", 10);
                DeckList.Add("KS", 10);

                DeckList.Add("AC", 1);
                DeckList.Add("2C", 2);
                DeckList.Add("3C", 3);
                DeckList.Add("4C", 4);
                DeckList.Add("5C", 5);
                DeckList.Add("6C", 6);
                DeckList.Add("7C", 7);
                DeckList.Add("8C", 8);
                DeckList.Add("9C", 9);
                DeckList.Add("10C", 10);
                DeckList.Add("JC", 10);
                DeckList.Add("QC", 10);
                DeckList.Add("KC", 10);

                DeckList.Add("AD", 1);
                DeckList.Add("2D", 2);
                DeckList.Add("3D", 3);
                DeckList.Add("4D", 4);
                DeckList.Add("5D", 5);
                DeckList.Add("6D", 6);
                DeckList.Add("7D", 7);
                DeckList.Add("8D", 8);
                DeckList.Add("9D", 9);
                DeckList.Add("10D", 10);
                DeckList.Add("JD", 10);
                DeckList.Add("QD", 10);
                DeckList.Add("KD", 10);
            }
        }
    }
}
