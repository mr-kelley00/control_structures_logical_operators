# Control Structures and Logical Operators, Ryan Kelley, 10/20/22, 11:30AM, v0.5

# Card Variables
cardSuit = 0 # 0 = Spades, 1 = Clubs, 2 = Hearts, 3 = Diamonds
cardValue = 0 # 2-10, Jack = 11, Queen = 12, King = 13, Ace = 14
cardBack = "" # Blue or Red 

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

# if-elif-else Statement 
# Make the most common conditon the FIRST statement!
if cardValue == 14:
    print("You have an Ace!\n")
elif cardValue == 13:
    print("You have a King!\n")
elif cardValue == 12:
    print("You have a Queen!\n")
elif cardValue == 11:
    print("You have a Jack!\n")
else:
    print("You have a 2 through 10 card.\n")

# Logical Operators 
# "If you buy at least three items or one item worth $100 or more, get 10% off."

# Logical and -- ALL CONDITIONS MUST BE TRUE 
if cardValue > 10 and cardSuit == 1:
    print("You have a Club face card.\n")

# Logical or -- ONE CONDITION MUST BE TRUE 
if cardValue <= 11 or cardSuit == 0:
    print("You have a non-face card or a Spades card.\n")

# Logical not -- RETURNS THE OPPOSITE VALUE 
if not cardValue > 3:
    print("You do not have a 2.\n")

# Loops -- Continue on Monday, 10/24/22 


