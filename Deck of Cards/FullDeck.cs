using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_of_Cards
{
    class FullDeck
    {
        public int NumberOfCards { get; set; }
        public string Value { get; set; }
        public string Suit { get; set; }
        public bool IsAvailable { get; set; }
        public object[] Card { get; set; }




        public FullDeck()
        {
            string ace = "one";
            string two = "two";
            string three = "three";
            string four = "four";
            string five = "five";
            string six = "six";
            string seven = "seven";
            string eight = "eight";
            string nine = "nine";
            string ten = "ten";
            string jack = "eleven";
            string queen = "twelve";
            string king = "thirteen";

        }

        public FullDeck(string value, string suit)
        {
            this.Value = value;
            this.Suit = suit;
            
        }


    }
}