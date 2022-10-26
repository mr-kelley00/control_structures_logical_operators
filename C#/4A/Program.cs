// Control Structures and Logical Operators, Ryan Kelley, 10/19/22, 1:49PM, v0.1
using System;

namespace ControlStructuresLogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Card Attribute Values
            int cardValue = 0; // 2-10, Jack = 11, Queen = 12, King = 13, Ace = 14
            int cardSuit = 0; // 1 = Clubs, 2 = Spades, 3 = Hearts, 4 = Diamonds
            int cardBack = 0; // 1 = Red, 2 = Blue 

            // Collect User Input 
            Console.WriteLine("Please enter the card value, 2-10, Jack = 11, Queen = 12, King = 13, Ace = 14.");
            cardValue = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Please enter the card suit: Clubs, Diamonds, Hearts, or Spades.");
            cardSuit = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Is the back of the card blue?  If yes, enter 1.  If no, enter 0.");
            cardBack = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Your card is " + cardSuit + " and has a value of " + cardValue + "and the back color value is" + cardBack + ".");
            Console.WriteLine(string.Format("Your card back is {0}. It has a value of {1} and the suit value is {2}.", cardBack, cardValue, cardSuit));


        }
    }
}
