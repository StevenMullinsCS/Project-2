/**
*--------------------------------------------------------------------
* File name: Deck.cs
* Project name: 1260-001-MullinsSteven-Project2
*--------------------------------------------------------------------
* Author’s name and email: Steven Mullins, mullinssa@etsu,edu
* Course-Section: 1260-001
* Creation Date: 2/6/2023
* -------------------------------------------------------------------
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lab_2_Cards
{
    internal class Deck
    {
        private Face _face;
        private Suit _suit;


        Card[] deckCards = new Card[52]; //Creates an array of 52 cards.

        int nextCards = 0; // Tells code where it is in the deck of cards.

        public Deck() // Constructor
        {
            for(int i = 0; i < 52; i++) // Loops and creates 52 cards for the deck.
            {
                Card card = new Card(i);
                deckCards[i] = card;
            }
            nextCards = 0;
        }


        public Deck(Deck otherDeck) // Copy constructor
        {
            deckCards = new Card[52];
            for (int i = 0; i < 52; i++)
            {
                deckCards[i] = new Card(otherDeck.deckCards[i]);

            }
        }
    


        public Card DealCards() // This method deals out the cards for the deck.
        {
            if (nextCards > 51)
            {
                nextCards = 0;
                Card singleCard1 = deckCards[nextCards];
                nextCards++;
                return singleCard1;
            }
            else
            {
                Card oneCard = deckCards[nextCards];
                nextCards++;
                return oneCard;
            }
        }

        public Hand DealHand(int handsize) // Deals a hand of a set number of cards cards.
        {
           
           
           

            Hand dealtHand = new Hand(handsize);
            if(nextCards > 51)
            {
                nextCards = 0;
            }

            for (int i = 0; i < handsize; i++)
            {

                Card card = DealCards();
                dealtHand.AddACard(card);
                 
                
            }
            


            return dealtHand;
        }


        public void ShuffleDeck() // Shuffles the Deck of cards using a random array.
        {
            Card[] shuffleDeck = new Card[52];
            Random rand = new Random();
            for(int i = 0; i < 52; i++)
            {
                int randomCards = rand.Next(deckCards.Length);
                shuffleDeck[i] = deckCards[randomCards];
                
            }
            deckCards = shuffleDeck;
            nextCards = 0;

        }
        public static void ShowDeck()
        {
            for (int i = 1; i < 53; i++)
            {
                Card Deck = new Card(i);
                Console.WriteLine(Deck.ToString());

            }
        }

    }

}
