using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_of_Cards
{
    class Hand
    {
        //public int NumberOfCards { get; set; }
        public int ValueFirstCard { get; set; }
        //public string SuitFirstCard { get; set; }
        public int ValueSecondCard { get; set; }
        //public string SuitSecondCard { get; set; }
        //public bool IsBusted { get; set; }
        //public object[] FirstCard { get; set; }
        //public object[] SecondCard { get; set; }
        public int Value { get; set; }
        //public string Suit { get; set; }





        public Hand(int valueFirstCard,/* string suitFirstCard,*/ int valueSecondCard /*string suitSecondCard*/)
        {
            this.ValueFirstCard = valueFirstCard;
            //this.SuitFirstCard = suitFirstCard;
            this.ValueSecondCard = valueSecondCard;
            //this.SuitSecondCard = suitSecondCard;

        }

        //public Hand(object[] firstCard)
        //{
        //    this.FirstCard = firstCard[2];
        //}

        //public FullDeck(string value, string suit)
        //{
        //    this.Value = value;
        //    this.Suit = suit;
            
        //}


        public int Hit(int handTotal/*, string suit*/)
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