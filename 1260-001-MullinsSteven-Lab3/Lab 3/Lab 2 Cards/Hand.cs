/**
*--------------------------------------------------------------------
* File name: Hand.cs
* Project name: 1260-001-MullinsSteven-Project2
*--------------------------------------------------------------------
* Author’s name and email: Steven Mullins, mullinssa@etsu.edu
* Course-Section: CSCI-1260-001
* Creation Date:
* -------------------------------------------------------------------
*/using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_Cards
{
    internal class Hand
    {
        private int _handSize;
        private int _cardsInHand = 0;
        private Card[] _gameHand;
        public Hand() 
        {
            _handSize = 5;
            _cardsInHand = 0;
            _gameHand = new Card[_handSize];
                Console.WriteLine(_gameHand.ToString());
        }

        public Hand(int handSize)
        {
            _gameHand= new Card[_handSize];
            _cardsInHand = handSize;
            
        }


        public Hand(Hand existingHand)
        {

            Card[] copyHand = new Card[_gameHand.Length];

            for (int i = 0; i < _gameHand.Length; i++)
            {
                copyHand[i] = _gameHand[i];
            }
        }





        public override string ToString()
        {
            string output = "";

            foreach (Card card in _gameHand)
            {
                

                    output += card.ToString() + "\n";
                
            }
            return output;
        }


        public void AddACard(Card card)
        {
            
            
            for(int i = 0; i < _handSize; i++) 
            { 

                _gameHand[i] = card;

            }
            
            
        }



    }
}
