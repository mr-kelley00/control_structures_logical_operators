# Control Structures and Logical Operators, Ryan Kelley, 10/24/22, 10:49AM, v0.6 

# Card Variables 
backColor = 0 # 1 = Red, 2 = Blue 
cardValue = 0 # 2-10, Jack = 11, Queen = 12, King = 13, Ace = 14
cardSuit = 0 # 1 = Club, 2 = Spade, 3 = Heart, 4 = Diamond 

# Collect User Input -- Allow user to type information based on their cards. 
# Most common way is using input()
backColor = int(input("Please enter the card back, 1 for Red and 2 for Blue.\n")) 
cardValue = int(input("Please enter 2-10, Jack = 11, Queen = 12, King = 13, Ace = 14.\n")) 
cardSuit = int(input("Please enter the card suit. 1 = Club, 2 = Spade, 3 = Heart, 4 = Diamond \n")) 

# Validate User Input -- Is the information being saved as expected? 
print(f"Your card back color is {backColor}, it has a value of {cardValue} and the suit value is {cardSuit}.\n")

# Control Structures 
# if Statement 
if cardValue > 10: # Conditional Expression, determine if true or false. If True, execute code. 
    print("Your card is either a Jack, Queen, King, or Ace.\n")    

if backColor == 1: 
    print("Your card back is red.\n")

# Pause the video, wrote your own if statement.  If the card is a Club, print it on the screen. 
if cardSuit == 1: 
    print("Your card is a Club.\n")

# if-else Statement 
if cardValue > 10: # Conditional Expression, determine if true or false. If True, execute code. 
    print("Your card is either a Jack, Queen, King, or Ace.\n")    
else: 
    print("Your card is a 2 through 10.\n")

if backColor == 1: 
    print("Your card back is red.\n")
else: 
    print("Your card back color is blue.\n")


if cardSuit == 1: 
    print("Your card is a Club.\n")
else: 
    print("Your card is a Spades, Hearts, or Diamonds.\n")

# Pause the video and add an else block to the two if statements on 35 and 39.  

# if-elif-else Statement 
if cardSuit == 1: 
    print("You have a Club.\n")
elif cardSuit == 2: 
    print("You have a Spade.\n")
elif cardSuit == 3: 
    print("You have a Heart.\n")
elif cardSuit == 4: 
    print("You have a Diamond.\n")
else: 
    print("Your card suit could not be determined, please restart.\n")

# Generally, use the else: block as an error message. 
