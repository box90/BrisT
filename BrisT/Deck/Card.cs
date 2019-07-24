using System;
using BrisT.Interfaces;

//https://en.wikipedia.org/wiki/Standard_52-card_deck#English_pattern_cards_and_nicknames

namespace BrisT.Deck
{
    public class Card : ICard
    {
        private int value { get; }
        private int points { get; }
        private string name { get;}
        public string set { get;}
        public Card(string s,int v)
        {
            this.value = v;
            this.set = s;

            switch (this.value)
            {
                case 1: this.points = 11;
                        this.name = "A";
                    break;
                case 3: this.points = 10;
                        this.name = "3"; 
                    break;
                case 8: this.points = 2;
                        this.name = "J";
                    break;
                case 9: this.points = 3;
                        this.name = "Q";
                    break;
                case 10:this.points = 4;
                        this.name = "K";
                    break;                
                default:    this.points = 0;
                            this.name = value.ToString();
                    break;
            }
        }


        public string CardName()
        {
            return (this.name + this.set);
        }

        public int CardValue()
        {
            return this.value;
        }

        public int CardPoints()
        {
            return this.points;
        }
    }
}