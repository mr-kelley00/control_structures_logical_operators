// Control Structures and Logical Operators, Ryan Kelley, 10/27/22, 12:32PM, v1.0
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
            /*
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
            */ 

            /*
            // if-else Statement 
            if (cardValue < 11)
            {
                Console.WriteLine("You have a card that is not a face card.");                      
            }
            else
            {
                Console.WriteLine("You have a card that is a face card.");                      
            }

            if (cardBack == 1)
            {
                Console.WriteLine("You have a card with a red back.");                   
            }
            else 
            {
                Console.WriteLine("You have a card with a blue back.");                   
            }

            // Pause the video, write an if-else statement using the cardSuit variable.  
            if (cardSuit == 1)
            {
                Console.WriteLine("You have a card that is a Clubs.");                   
            }
            else
            {
                Console.WriteLine("You have a card that is a Hearts, Diamonds, or Spades.");                   
            }
            */ 

            // if - else if - else 
            /*
             if (cardSuit == 1)
            {
                Console.WriteLine("You have a card that is a Clubs.");                   
            }
            else if (cardSuit == 2)
            {
                Console.WriteLine("You have a card that is a Spades.");                   
            }
            else if (cardSuit == 3)
            {
                Console.WriteLine("You have a card that is a Hearts.");                   
            }
            else if (cardSuit == 4)
            {
                Console.WriteLine("You have a card that is a Diamonds.");                   
            }                  
            else
            {
                Console.WriteLine("Your card suit was not properly detected, please restart the program and try again.");                   
            }
            // Pause the video, create an if-else if-else block using the Card Value.  Print exactly which face card, or print 2-10, or print an error. 
            if (cardValue == 14)
            {
                Console.WriteLine("You have a card that is an Ace card.");                      
            }
            else if (cardValue == 13)
            {
                Console.WriteLine("You have a card that is a King card.");                      
            }
            else if (cardValue == 12)
            {
                Console.WriteLine("You have a card that is a Queen card.");                      
            }
            else if (cardValue == 11)
            {
                Console.WriteLine("You have a card that is a Jack card.");                      
            }
            else if (cardValue < 11)
            {
                Console.WriteLine("You have a card that is a 2-10.");                      
            }
            else
            {
                Console.WriteLine("Your card value was not saved correctly.");                      
            }
            */ 

            // Logical Operators -- and or not 
            // AND && 
            /*
            if (cardValue > 10 && cardSuit == 1) // ALL conditions must be true for the statement to be true. 
            {
                Console.WriteLine("You have a face card that is a Club.");
            }
            else
            {
                Console.WriteLine("You do not have a face card that is a Club.");
            }

            // OR || 
            if (cardValue > 10 || cardSuit == 3) // ONE conditions must be true for the statement to be true. 
            {
                Console.WriteLine("You have a face card or a Hearts.");
            }
            else
            {
                Console.WriteLine("You do not have a face card or a Hearts.");
            }
            */ 

            // Pause the video, use one of the logical operators to fix the if - else if - else block that prints the card value. 
            if (cardValue > 14)
            {
                Console.WriteLine("Your card value is greater than 14, something wrong has occurred.  Please try again.");                      
            }
            else if (cardValue == 14)
            {
                Console.WriteLine("You have a card that is an Ace card.");                      
            }
            else if (cardValue == 13)
            {
                Console.WriteLine("You have a card that is a King card.");                      
            }
            else if (cardValue == 12)
            {
                Console.WriteLine("You have a card that is a Queen card.");                      
            }
            else if (cardValue == 11)
            {
                Console.WriteLine("You have a card that is a Jack card.");                      
            }
            else if (cardValue < 11 && cardValue > 1) // If the card value is less than 11 and greater than 1.  
            {
                Console.WriteLine("You have a card that is a 2-10.");                      
            }
            else
            {
                Console.WriteLine("Your card value was not saved correctly.  Please try again.");                      
            }

        }
    }
}
