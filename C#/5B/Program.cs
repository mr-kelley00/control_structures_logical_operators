// Control Structures and Logical Operators, Ryan Kelley, 10/18/22, 8:58AM, v0.1
using System;

namespace ControlStructuresLogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare and Define Variables 
            int cardBack = 0; // 1 = Red, 2 = Blue 
            int cardValue = 0; // 2-10 or J = 11, Q = 12, K = 13, A = 14 
            int cardSuit = 0; // 1 = Clubs, 2 = Diamonds, 3 = Hearts, 4 = Spades

            // Collect User Input 
            Console.WriteLine("Please enter the card back, either 1 = Red or 2 = Blue.");
            cardBack = Convert.ToInt32(Console.ReadLine()); 
            
            Console.WriteLine("Please enter the card value. 2-10 or J = 11, Q = 12, K = 13, A = 14.");
            cardValue = Convert.ToInt32(Console.ReadLine()); 
            
            Console.WriteLine("Please enter the card suit, 1 = Clubs, 2 = Diamonds, 3 = Hearts, 4 = Spades");
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

            if (cardSuit == 0)
            {
                Console.WriteLine("You have a Clubs.");                
            }
            else if (cardSuit == 1)
            {
                Console.WriteLine("You have a Diamonds.");                
                
            }
            else if (cardSuit == 2)
            {
                Console.WriteLine("You have a Hearts.");                
                
            }
            else if (cardSuit == 3)
            {
                Console.WriteLine("You have a Spades.");                
                
            }
            else 
            {
                Console.WriteLine("Your card suit was not correctly identified. Please start over.");
            }



        }
    }
}
