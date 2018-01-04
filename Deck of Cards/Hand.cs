using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_of_Cards
{
    class Hand
    {
        public int ValueFirstCard { get; set; }
        public int ValueSecondCard { get; set; }
        public int Value { get; set; }


        public Hand(int valueFirstCard, int valueSecondCard)
        {
            this.ValueFirstCard = valueFirstCard;
            this.ValueSecondCard = valueSecondCard;

        }



        public int Hit(int handTotal)
        {
            Random newCard = new Random();
            int hitCard = newCard.Next(1, 10);
            int hitTotal = handTotal + hitCard;

            return hitTotal;                
        }

        public void DealerShows(int dealersHandTotal)
        {
            Random dealer = new Random();
            dealersHandTotal = dealer.Next(8, 21);
            Console.WriteLine("The dealer's hand is " + dealersHandTotal);
        }

        


        

    }
}