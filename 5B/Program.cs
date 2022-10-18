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
            int cardValue; 
            int cardSuit; // 0 = Clubs, 1 = Diamonds, 2 = Hearts, 3 = Spades

            // Collect User Input 
            Console.WriteLine("Please enter the card back, either Blue or Red.");
            Console.WriteLine("Please enter the card value. 2-10 or J = 11, Q = 12, K = 13, A = 14.");
            Console.WriteLine("Please enter the card suit, 0 = Clubs, 1 = Diamonds, 2 = Hearts, 3 = Spades");
            cardBack = Console.ReadLine();
            cardValue = Convert.ToInt32(Console.ReadLine()); 
            cardSuit = Convert.ToInt32(Console.ReadLine());
        }
    }
}
