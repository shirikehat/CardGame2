﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Deck
    {
        private Card[] cards;

        public Deck()
        {
            cards = new Card[52];
            int index = 0;
            for(int i=1;  i<=4; i++)
            {
                for(int j=1; j<=13; j++)
                {
                    cards[index]= new Card(j,i);
                    index++;
                }
            }
        }

        public Card Peek() 
        { 
            return null;
        }

        public void Shuffle() 
        {

        }
        public Card Deal() { return null; }

        public void Reset() { }
    }
}
