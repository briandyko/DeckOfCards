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


        public int Hit(int value/*, string suit*/)
        {
            int newValue;
            Random rand = new Random();
            newValue = value + rand.Next(3, 9);

            return newValue;

                      
        }

        //public void isBusted()
        //{
        //    if (Hand == 21)
        //    {

        //    }
        //}


    }
}