

using Lab_2_Cards;
/**
*--------------------------------------------------------------------
* File name: Program.cs
* Project name: Lab 3 - Cards
*--------------------------------------------------------------------
* Author’s name and email: Steven Mullins, mullinssa@etsu,edu
* Course-Section: 1260-001
* Creation Date: 2/6/2023
* -------------------------------------------------------------------
*/

namespace Lab_2_Cards
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The normal deck of cards is as follows:");

            Deck deckOfCards = new Deck();
            for (int i = 0; i < 52; i++) // Creates the deck in Main.
            {

                Console.WriteLine(deckOfCards.DealCards());

            }

            Console.WriteLine($"\nYouve been dealt a hand of 7 cards! The hand consists of\n" +
                $"\n" + deckOfCards.DealHand(7).ToString()); // Deals the first hand of cards off the original deck


            Console.WriteLine("Shuffling the Deck...");



            deckOfCards.ShuffleDeck(); //Shuffles the deck
            Console.WriteLine("The shuffled deck is as follows:");
            for (int i = 0; i < 52; i++)
            {

                Console.WriteLine(deckOfCards.DealCards()); // Prints the newly shuffled deck of cards.

            }
            Deck copyDeck = new Deck(deckOfCards);



            Console.WriteLine("\n\nYouve been dealt a new hand! This one consists of\n");
            Console.WriteLine($"NEW HAND:{copyDeck.DealHand(7).ToString()}\n");
            Console.WriteLine($"HAND 2: SECOND HAND:{copyDeck.DealHand(7)}");
            // Deals the user 2 hands of cards.





            //   PROJECT 2 CODE STARTS HERE

            Console.WriteLine("How many cards would you like in each hand?");
            int handSize = int.Parse(Console.ReadLine());
            Console.WriteLine("How many hands are being dealt?");
            int handsToDeal = int.Parse(Console.ReadLine());

            for(int i = 0; i < handsToDeal; i++)
            {
                
                Hand playerHand = new Hand(handSize);
                Console.WriteLine($"Player {i + 1}'s hand:\n" + playerHand.ToString());
            }

            


            
            
        }
        // SHOW DECK
        /// <summary>
        /// This method prints out the entire deck of cards.
        /// </summary>
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


