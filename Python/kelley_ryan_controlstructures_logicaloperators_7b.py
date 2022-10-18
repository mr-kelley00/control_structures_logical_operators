# Control Structures and Logical Operators, Ryan Kelley, 10/18/22, 11:45AM, v0.0

# Card Variables
cardSuit = 0 # 0 = Spades, 1 = Clubs, 2 = Hearts, 3 = Diamonds
cardBack = "" # Blue or Red 
cardValue = 0 # 2-10, Jack = 11, Queen = 12, King = 13, Ace = 14

# Input Card Data
cardSuit = int(input("Please enter the card suit: 0 = Spades, 1 = Clubs, 2 = Hearts, 3 = Diamonds\n"))
cardValue = int(input("Pleas enter the card value: 2-10, Jack = 11, Queen = 12, King = 13, Ace = 14.\n"))
cardBack = input("Please enter the card back color: Blue or Red.\n")

# Verify Information 
print(f"The card suit is {cardSuit} and has a value of {cardValue}.  The card back is {cardBack}.")

# if Statement 
if cardBack == "Blue":
    print("The wheels on the bus go round and round.\n")

if cardValue > 5: 
    print("Your card is worth at least 5 points.\n")

if cardSuit < 3:
    print("You did not win.\n")

# if-else Statement: 

if cardBack == "Red":
    print("Your card back is red.\n")   
else:
    print("Your card back is blue.\n")

if cardValue > 10: 
    print("You have a Jack, Queen, King, or Ace card.\n")
else: 
    print("You have a 2 through 10 card.\n")

