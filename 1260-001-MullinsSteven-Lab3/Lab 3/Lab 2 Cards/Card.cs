/**
*--------------------------------------------------------------------
* File name: Card.cs
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
using System.Text;
using System.Threading.Tasks;


namespace Lab_2_Cards
{
    internal class Card
    {
        private Face _face;
        private Suit _suit;

        // Default Constructor - Prints an Ace of Spades.
        public Card()
        {
            SetFace(Face.Ace);
            SetSuit(Suit.Spades);
        }

        // Parameterized Constructor
        public Card(int n)
        {
            SetFace((Face)Enum.GetValues(typeof(Face)).GetValue(n % 13));
            SetSuit((Suit)Enum.GetValues(typeof(Suit)).GetValue(n % 4));
        }

        // Copy Constructor
        public Card(Card Card)
        {
            SetFace(Card.GetFace());
            SetSuit(Card.GetSuit());

        }


        //TO STRING
        /// <summary>
        /// Prints the card into a nice, readable format.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string cardToString = $"The {_face} of {_suit}.";
            return cardToString;
        }

        // SETTERS
        public void SetFace(Face face)
        {
            _face = face;
        }
        public void SetSuit(Suit suit)
        {
            _suit = suit;

        }

        // GETTERS
        public Face GetFace()
        {
            return _face;
        }

        public Suit GetSuit()
        {
            return _suit;
        }

    }

}

