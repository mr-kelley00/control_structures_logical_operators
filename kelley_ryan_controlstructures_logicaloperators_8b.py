# Control Structures and Logical Operators, ryan Kelley, 10/18/22, 1:50pm, v0.1

# Card Variables 
backColor = ""
cardValue = 0 # 2-10, Jack = 11, Queen = 12, King = 13, Ace = 14
cardSuit = 0 # 1 = Clubs, 2 = Spades, 3 = Hearts, 4 = Diamonds 

# User Input 
backColor = input("Please enter the color of the card back, Red or Blue.\n")
cardValue = int(input("Please enter the card value # 2-10, Jack = 11, Queen = 12, King = 13, Ace = 14.\n"))
cardSuit = int(input("Please enter the card suit: 1 = Clubs, 2 = Spades, 3 = Hearts, 4 = Diamonds.\n")) 

# Validate Data 
print(f"Your card back is {backColor}, it has a value of {cardValue} and the suit is {cardSuit}.\n")

# Control Structures 
# if Statement 

if cardValue > 6: 
    print("Ooh lah lah, that's a good card!\n")

if backColor == "Red":
    print("Your card back is red, like Kool-Aid.\n")

if cardSuit <= 2: 
    print("You have a Club or Spade.")



