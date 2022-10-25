// Control Structures and Logical Operators, Ryan Kelley, 10/25/22, 10:51AM, v0.4
using System;

namespace ControlStructuresLogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare and Define Variables and Data Types 
            // C# Variables use this format: datatype variablename; 
            int cardBack = 0; // 1 = Red, 2 = Blue  
            int cardValue = 0; // 2-10, Jack = 11, Queen = 12, King = 13, Ace = 14
            int cardSuit = 0; // 1 = Clubs, 2 = Spades, 3 = Hearts, 4 = Diamonds 

            // Collect User Input 
            Console.WriteLine("Please enter the card back color, 1 = red and 2 = blue.");
            cardBack = Convert.ToInt32(Console.ReadLine()); // By default, Console.ReadLine() stores as a string.  

            Console.WriteLine("Please enter the card value: 2-10, Jack = 11, Queen = 12, King = 13, Ace = 14");
            cardValue = Convert.ToInt32(Console.ReadLine()); // By default, Console.ReadLine() stores as a string.  

            Console.WriteLine("Please enter the card suit: 1 = Clubs, 2 = Spades, 3 = Hearts, 4 = Diamonds.");
            cardSuit = Convert.ToInt32(Console.ReadLine()); // By default, Console.ReadLine() stores as a string.  

            // Validate User Input -- Make sure the user is typing is being saved correctly.  
            // Console.WriteLine("Your card back is " + cardBack + ". It has a value of " + cardValue + " and the suit number is " + cardSuit + ".");
            Console.WriteLine(string.Format("Your card back is {0}. It has a value of {1} and the suit number is {2}.", cardBack, cardValue, cardSuit));

            // Control Structures -- Allow the program to make decisions or change flow / sequence of events. 
            // if Statement 
            if (cardValue > 10) // (cardValue > 10) is a CONDITIONAL EXPRESSION -- Is it True or False? 
            {
                Console.WriteLine("You have a face card, either a Jack, Queen, King, or Ace!");                
            }

            if (cardSuit == 1)
            {
                Console.WriteLine("You have a Club.");                   
            }
            
            // Pause the video, write your own if statement using the cardBack variable. 
            if (cardBack == 1)
            {
                Console.WriteLine("You have a card with a red back.");                   
            }
           
        }
    }
}
