using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_of_Cards
{
    class Program
    {
        //Game One: BlackJack

        static void Main(string[] args)
        {
            Hand hand = new Hand(3, 2);

            int handTotal = hand.ValueFirstCard + hand.ValueSecondCard;

            Console.WriteLine(handTotal);

            string response;

            do
            {

                Console.WriteLine("Would you like a hit?");

                response = Console.ReadLine().ToLower();

                if (response == "yes")
                {
                    handTotal = hand.Hit(handTotal);
                    //int newTotal = hand.Hit(handTotal);
                    //Console.WriteLine(newTotal);
                    Console.WriteLine(handTotal);
                    if (/*newTotal*/handTotal > 21)
                    {
                        Console.WriteLine("busted\n");
                    }

                    //need to have functionality for if you stay and dealer shows hand and dealer needs to hit.
                }

                else if (response == "no")
                {
                    Console.WriteLine("Let's see what the dealer's got.");
                    hand.DealerShows();
                    //need to have functionality for if dealer's hand is higher
                }
                else
                {
                    Console.WriteLine("make a valid choice");
                }
            }



            while (handTotal < 21 && response == "yes");


            Console.WriteLine("Thanks for playing!");




        }
        
    }
    }
  

