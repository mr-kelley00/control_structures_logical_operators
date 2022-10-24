# Control Structures and Logical Operators, Ryan Kelley, 10/24/22, 10:28AM, v0.3 

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