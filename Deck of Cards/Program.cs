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
            Random first = new Random();
            Random second = new Random();


            int cardOne = first.Next(1, 10);
            int cardTwo = second.Next(1, 10);
             
            Hand hand = new Hand(cardOne, cardTwo);

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
                    Console.WriteLine(handTotal);
                    //if (handTotal > 21)
                    //{
                    //    Console.WriteLine("Busted! Dealer Wins!!!\n");
                    //}

                    //need to have functionality for if you stay and dealer shows hand and dealer needs to hit.
                }

                else if (response == "no")
                {
                    Console.WriteLine("Let's see what the dealer's got.");
                    Hand dealersHand = new Hand(4, 7);
                    int dealersHandTotal = dealersHand.ValueFirstCard + dealersHand.ValueSecondCard;
                    hand.DealerShows(dealersHandTotal);

                    if (dealersHandTotal >= handTotal)
                    {
                        Console.WriteLine("Dealer wins.");
                    }
                    else if (dealersHandTotal < handTotal || dealersHandTotal <= 16)
                    {
                        dealersHand.Hit(dealersHandTotal);
                    }
                    else if (dealersHandTotal < handTotal)
                    {
                        Console.WriteLine("You win all the money! Congrats!");
                    }

                    else
                    {
                        Console.WriteLine("make a valid choice");
                    }
                }

            }

            while (handTotal < 21 && response != "no");

            
            Console.WriteLine("Thanks for playing!");




        }
        
    }
    }
  

