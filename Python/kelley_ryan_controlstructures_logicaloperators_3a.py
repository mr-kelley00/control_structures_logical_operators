#Control Structures and Logical Operators, Ryan Kelley, 10/19/22, 12:50PM, v0.2

# Card Attributes 
cardSuit = 0 # 1 = Clubs, 2 = Spades, 3 = Hearts, 4 = Diamonds 
cardValue = 0 # 2-10, Jack = 11, Queen = 12, King = 13, Ace = 14
cardBack = "" # Red or Blue 

# Collect User Input 
cardSuit = int(input("Please enter the card suit, 1 = Clubs, 2 = Spades, 3 = Hearts, 4 = Diamonds.\n"))
cardValue = int(input("Please enter the card value, 2-10, Jack = 11, Queen = 12, King = 13, Ace = 14.\n"))
cardBack = input("Please enter the color of the card back, either Red or Blue.\n")

# Validate User Input 
print(f"Your card suit is {cardSuit}, it has a value of {cardValue} and the back is {cardBack}.\n")