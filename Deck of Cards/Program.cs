using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Hand hand = new Hand(3, 2);

            int handTotal = hand.ValueFirstCard + hand.ValueSecondCard;
            int hitTotal;

            do
            {

                Random newCard = new Random();

            int hitCard = newCard.Next(1, 10);

            hitTotal = handTotal + hitCard;

            hand.Hit(hitCard);
            
                Console.WriteLine(hitTotal);


                if (hitTotal > 21)
                {

                    Console.WriteLine("bust");
                }

                else
                {
                    Console.WriteLine("Would you like another hit?");
                }

                string response = Console.ReadLine().ToLower();

                if (response == "yes")
                {
                    /*Console.WriteLine(*/hitTotal += hand.Hit(hitCard)/*)*/;
                   
                    if(hitTotal > 21)
                        {
                    Console.WriteLine("real busted");
                        }
                    break;
                }
                else if (response == "no")
                        {
                    Console.WriteLine("Let's see what the dealer's got.");
                }
                else
                {
                    Console.WriteLine("make a valid choice");
                }

            }
            while (hitTotal < 21);


            Console.WriteLine("busted");
        }
        }
    }

