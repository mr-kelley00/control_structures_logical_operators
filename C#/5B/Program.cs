// Control Structures and Logical Operators, Ryan Kelley, 10/18/22, 8:58AM, v0.1
using System;

namespace ControlStructuresLogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare and Define Variables 
            string cardBack; 
            int cardValue; // 2-10 or J = 11, Q = 12, K = 13, A = 14 
            int cardSuit; // 0 = Clubs, 1 = Diamonds, 2 = Hearts, 3 = Spades

            // Collect User Input 
            Console.WriteLine("Please enter the card back, either Blue or Red.");
            cardBack = Console.ReadLine();
            
            Console.WriteLine("Please enter the card value. 2-10 or J = 11, Q = 12, K = 13, A = 14.");
            cardValue = Convert.ToInt32(Console.ReadLine()); 
            
            Console.WriteLine("Please enter the card suit, 0 = Clubs, 1 = Diamonds, 2 = Hearts, 3 = Spades");
            cardSuit = Convert.ToInt32(Console.ReadLine());

            // Validate User Input 
            Console.WriteLine("Your card back is " + cardBack + ". It has a value of " + cardValue + " and the suit number is " + cardSuit + ".");
            Console.WriteLine(string.Format("Your card back is {0}. It has a value of {1} and the suit is {2}.", cardBack, cardValue, cardSuit));
            
            // Control Structures 
            // if Statements 
            if (cardValue < 11 ) 
            {
                Console.WriteLine("You do not have a face card!");
            }

            if (cardSuit == 2)
            {
                Console.WriteLine("Your card is a Heart.");
            }
            
            // if-else Statement 
            if (cardValue > 10)
            {
                Console.WriteLine("You have a face card.");
            }
            else
            {
                Console.WriteLine("You do not have a face card.");           
            }

            // Make your own if-else statement using the cardSuit variable.  
            if (cardSuit != 3)
            {
                Console.WriteLine("You do not have a Spades card.");
            }
            else 
            {
                Console.WriteLine("You do have a Spades card.");
            }
            
            // if - else if - else Statement 
            if (cardValue > 13)
            {
                Console.WriteLine("You have an Ace.");                
            }
            else if (cardValue > 10)
            {
                Console.WriteLine("Your card is either a Jack, Queen, or King.");
            }
            else 
            {
                Console.WriteLine("Your card is a 10 or less.");
            }

        }
    }
}
