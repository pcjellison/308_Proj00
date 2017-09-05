using System;
using System.Collections;
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
            int numDealtPlayer = 2;
            int numDealtDealer = 2;
            char surrender = 'n';
            char hitOrStand = 's';
            int handValue;
            int dealerHandValue;
            int wins = 0;
            int losses = 0;
            int ties = 0;

            Random rand = new Random();
            Deck deck = new Deck();
            deck.createDeck();
            User player = new User();
            Dealer dealer = new Dealer();
            List<Card> playerHand = new List<Card>();
            List<Card> dealerHand = new List<Card>();

            uxNewGame();
            void uxNewGame()
            {
                playerHand.Clear();
                dealerHand.Clear();
                Console.WriteLine("========== New Game ==========");
                Console.WriteLine("You have: $" + remaining);
                Console.WriteLine("How much do you bet: ");
                bet = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You bet $" + bet);
                handValue = 0;
                dealerHandValue = 0;
                numDealtPlayer = 2;
                numDealtDealer = 2;
                uxDealing();
            }

            void uxDealing()
            {
                for (int i = 0; i < numDealtPlayer; i++)
                {
                    Card card = Draw();
                    player.Add(card);
                }
                playerHand = player.GetHand;
                uxDisplay(playerHand);
            }


            void uxDisplay(List<Card> hand)
            {
                Console.Write("Your hand: ");
                for (int i = 0; i < hand.Count; i++)
                {
                    Console.Write(hand[i].Rank + hand[i].Suit + " ");
                    handValue += hand[i].Value;
                }
                if (handValue > 20)
                {
                    uxGameOver();
                }
                Console.WriteLine(",  Hand Value: " + handValue);
                Console.Write("Do you want to surrender <Y or N>? : ");
                string surr = Console.ReadLine();
                if (surr == "Y" || surr == "y")
                {
                    uxGameOver();
                }
                else
                {
                    Console.Write("Will you HIT or STAND <H or S>? : ");
                    string ans = Console.ReadLine();

                    if (ans == "h" || ans == "H")
                    {
                        uxPlayerHit();
                    }
                    else
                    {
                        uxPlayerStand();
                    }
                }

            }

            void uxDealerDealing()
            {
                for (int i = 0; i < numDealtDealer; i++)
                {
                    Card card = Draw();
                    dealer.Add(card);
                }
                dealerHand = dealer.GetHand;
            }

            void uxPlayerHit()
            {
                numDealtPlayer = 1;
                if (handValue < 21 && dealerHandValue < 21)
                {
                    uxDealing();
                }
                else
                {
                    uxGameOver();
                }
            }

            void uxPlayerStand()
            {
                Console.WriteLine(" ");
                Console.WriteLine("Now, Dealer's turn");
                uxDealerDealing();
                Console.WriteLine("Dealer's Hand: ");
                if (dealerHand.Count == 2)
                {
                    Console.Write(dealerHand[0].Rank + dealerHand[0].Suit + " ");
                    Console.Write(" XX");
                    for (int i = 0; i < dealerHand.Count; i++)
                    {
                        dealerHandValue += dealerHand[i].Value;
                    }

                    if (dealerHandValue >= 17)
                    {
                        uxPlayerHit();
                    }
                    else
                    {
                        uxPlayerStand();
                    }
                    numDealtDealer = 1;
                }
                else
                {
                    for (int i = 0; i < dealerHand.Count; i++)
                    {
                        Console.Write(dealerHand[i].Rank + dealerHand[i].Suit + " ");
                        dealerHandValue += dealerHand[i].Value;
                    }
                    Console.WriteLine(",  Hand Value: " + dealerHandValue);
                }
            }

            void uxGameOver()
            {
                
                double award = bet;
                int tempBet = bet;
                if (handValue == 21)
                {
                    award = (Convert.ToDouble(tempBet) * 2.5);
                }
                if (handValue == 21 && dealerHandValue != 21)
                {
                    Console.WriteLine("You won and Got $" + award + " from Dealer");
                    wins++;
                    Console.WriteLine("You Won " + wins + " times, Lost " + losses + " times, and Tied " + ties + " times");
                    tempBet = Convert.ToInt32(award);
                    remaining += tempBet;
                    bet = 0;
                }
                else if(handValue > 21)
                {
                    Console.WriteLine("You Bust");
                    losses++;
                    Console.WriteLine("Dealer won and Got $" + bet + " from User");
                    Console.WriteLine("You Won " + wins + " times, Lost " + losses + " times, and Tied " + ties + " times");
                    remaining -= bet;
                    bet = 0;
                }
                else if (dealerHandValue > 21)
                {
                    Console.WriteLine("Dealer Busted");
                    wins++;
                    Console.WriteLine("You won and Got $" + bet + " from Dealer");
                    Console.WriteLine("You Won " + wins + " times, Lost " + losses + " times, and Tied " + ties + " times");
                    remaining += bet;
                    bet = 0;
                }
                else
                {

                    if(handValue > dealerHandValue)
                    {
                        Console.WriteLine("You won and Got $" + bet + " from Dealer");
                        wins++;
                        Console.WriteLine("You Won " + wins + " times, Lost " + losses + " times, and Tied " + ties + " times");
                        remaining += bet;
                        bet = 0;
                    }
                    else if (dealerHandValue > handValue)
                    {
                        Console.WriteLine("Dealer won and Got $" + bet + " from User");
                        losses++;
                        Console.WriteLine("You Won " + wins + " times, Lost " + losses + " times, and Tied " + ties + " times");
                        remaining -= bet;
                        bet = 0;
                    }
                    else
                    {
                        Console.WriteLine("Stand Off");
                        Console.WriteLine("You Won " + wins + " times, Lost " + losses + " times, and Tied " + ties + " times");
                    }
                }
                uxContinue();
            }

            void uxContinue()
            {
                Console.WriteLine("More Game <Y or N>? : ");
                string ans = Console.ReadLine();

                if(ans == "y" || ans == "Y")
                {
                    uxNewGame();
                }
            }
                
                //shuffles and draws card
             Card Draw()
             {
                int cardNum = rand.Next(1, 53);
                return deck.Deal(cardNum);
              }
            }
        }
    }