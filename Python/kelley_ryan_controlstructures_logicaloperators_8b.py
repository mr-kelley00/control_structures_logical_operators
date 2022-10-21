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

# if-else Statement 
if cardValue >= 11:
    print("Your card is either a Jack, Queen, King, or Ace.\n")
else: 
    print("Your card is a 2 through 10.\n")

if cardSuit == 1:
    print("Your card is a Club.\n")
else: 
    print("Your card is either Hearts, Diamonds, or Spades.\n")

# if-elif-else Statement 
if cardValue > 10:
    print("You have a face card.\n")
elif cardValue >= 5:
    print("Your card value is greater than 5 but less than 11.\n")
else: # else is generally used as "OH NO, SOMETHING'S WRONG!"
    print("Your card value is less than 5.\n")

# Logical Operators -- and or 
# "Sale today!  Buy at least 10 items or spend $200 and get 10% off!"
if cardValue > 10 or cardSuit == 1: # ONE CONDITION MUST BE TRUE 
    print("Your card is a Jack, Queen, King, Ace OR it is a club.\n")
# If using or make the condition most likely to be TRUE the first condition. 

if cardSuit == 3 and cardValue == 14: # ALL CONDITIONS MUST BE TRUE. 
    print("Your card is the Ace of Hearts.\n")
# If using and, put the condition most likely to be FALSE first.  

# Logical not -- Pretend it doesn't exist for right now. 

# Monday, 10/24 -- for and while loops 





