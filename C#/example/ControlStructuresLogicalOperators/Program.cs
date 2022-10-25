// Control Structures and Logical Operators, Ryan Kelley, 10/25/22, 10:18AM, v0.2
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

           
        }
    }
}
