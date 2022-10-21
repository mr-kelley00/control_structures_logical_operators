# Control Structures and Logical Operators, Ryan Kelley, 10/21/22, 8:58AM, v0.2

# Variables and Data Types 
cardValue = 0 # 2-10, J = 11, Q = 12, K = 13, A = 14
cardSuit = 0 # 1 = Clubs, 2 = Spades, 3 = Hearts, 4 = Diamonds 
cardBack = 0 # 1 = Red, 2 = Blue 

# Collect User Input 
# input() defaults to saving data as a STRING.  If you need another type, need to convert it. 
cardValue = int(input("Please enter the card value.  Use 2-10, J = 11, Q = 12, K = 13, A = 14.\n"))
cardSuit = int(input("Please enter the card suit.  1 = Clubs, 2 = Spades, 3 = Hearts, 4 = Diamonds.\n"))
cardBack = int(input("Please enter the card back color.  1 = Red, 2 = Blue \n"))

# Validate User Input 
print(f"Your card value is {cardValue}, the suit number is {cardSuit} and the back color is {cardBack}.\n")




