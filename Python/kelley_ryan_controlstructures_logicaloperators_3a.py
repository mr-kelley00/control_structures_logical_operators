#Control Structures and Logical Operators, Ryan Kelley, 10/19/22, 12:50PM, v0.2

# Card Attributes 
cardSuit = 0 # 1 = Clubs, 2 = Spades, 3 = Hearts, 4 = Diamonds 
cardValue = 0 # 2-10, Jack = 11, Queen = 12, King = 13, Ace = 14
cardBack = 0 # 1 = Red, 2 = Blue 

# Collect User Input 
cardSuit = int(input("Please enter the card suit, 1 = Clubs, 2 = Spades, 3 = Hearts, 4 = Diamonds.\n"))
cardValue = int(input("Please enter the card value, 2-10, Jack = 11, Queen = 12, King = 13, Ace = 14.\n"))
cardBack = int(input("Please enter the color of the card back, either 1 = Red or 2 = Blue.\n"))

# Validate User Input 
print(f"Your card suit is {cardSuit}, it has a value of {cardValue} and the back is {cardBack}.\n")

# Control Structures -- Allows the program to make decisions. 
# if Statement 
if cardValue > 10: # cardValue > 10 is a CONDITIONAL STATEMENT.  If True, run code, if False, skip code.
    print("You have a Jack, Queen, King, or Ace.\n")

if cardSuit == 3: 
    print("Your card is a Hearts.\n")

if cardBack != 1:
    print("Your card is Blue.\n")

# if-else Statement 
if cardValue <= 10: 
    print("Your card is 10 or less.\n")
else: 
    print("Your card is Jack or higher.\n")

if cardBack == 1: 
    print("The back of the card is Red.\n")
else: 
    print("The back of the card is Blue.\n")

# if-elif-else Statements 
if cardSuit == 1: 
    print("Your card is a Club.\n")
elif cardSuit == 2: 
    print("Your card is a Spades.\n")
elif cardSuit == 3: 
    print("Your card is a Hearts.\n")
else:
    print("Your card is a Diamonds.\n")

if cardValue > 10:
    print("You have a face card.\n")
elif cardValue >= 2:
    print("You have a card between 2 and 10.\n")
else: # USE THIS AS THE "OH $%#!@! SOMETHING WENT WRONG." STATEMENT 
    print("There was an error with your card value, please start over.\n")

