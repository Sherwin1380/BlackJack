using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Threading;

namespace BJGU
{
    class DECK
    {
        public CARD[] cardDeck;

        //Create new deck and shuffle
        public void SetUpDeck()
        {
            //crete a deck with 52 cards
            cardDeck = new CARD[52];

            string[] face = new string[] { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            string[] suit = new string[] { "Spades", "Harts", "Clubs", "Diamonds" };
            int[] score = new int[13];
            int d = 0;

            for (int z = 0; z < 4; z++)
            {
                for (int i = 0; i < 13; i++)
                {
                    if (i < 10)
                    {
                        score[i] = i + 1;
                    }
                    else
                    {
                        score[i] = 10;
                    }
                    cardDeck[d] = new CARD(face[i], suit[z], score[i]);
                    d = d + 1;
                }
            }

            //shufffle the deck, swap 100 cards
            for (int i = 0; i < 100; i++)
            {
                ShuffleDeck();
            }


        }

        //shuffle 2 cards, swap 2 cards
        void ShuffleDeck()
        {
            Random random = new Random();
            int shuffleRandom3 = random.Next(0, 52);
            int shuffleRandom4 = random.Next(0, 52);
            CARD shuffleTemp2;

            Thread.Sleep(20);

            shuffleTemp2 = cardDeck[shuffleRandom3];
            cardDeck[shuffleRandom3] = cardDeck[shuffleRandom4];
            cardDeck[shuffleRandom4] = shuffleTemp2;
        }

        //show card
        public string ShowFirstCards(int y)
        {
            string Card = $"{cardDeck[y].Face}  {cardDeck[y].Suit} score = {cardDeck[y].Score}";
            return Card;
        }

        //show value of selected card
        public int CardValue(int y)
        {
            int cardvalue = cardDeck[y].Score;
            return cardvalue;
        }
    }
}
