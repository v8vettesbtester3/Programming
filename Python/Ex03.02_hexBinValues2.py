'''
Python 03, Exercise 02

Create a Python program that tests your ability to interpret binary
and hexadecimal numbers.

a. Ask the user to choose to be presented with either binary or hexadecimal
   values.
b. The program randomly picks a number between 0 and 255.
c. Initialize a counter of the number of user’s attempts to zero.
d. Print this value in the chosen base.
   For example if the randomly picked number is 27 and hexadecimal
   representation was chosen, print 0x1B, which is the hex representation of 27.
e. Increment the number of attempts by 1.
f. Input the user’s answer for the base-10 value of the presented number.
   For example, the program prints 0x1B and the user is then asked to
   enter what they think this is in base 10 (it’s 27).
g. If the answer is correct, print
   “Congratulations, you answered in “, <number of attempts>,” tries”.
h. Otherwise, when the answer is not correct, print “Nope.  “
   and ask the user to again input their answer.
i. The game continues until the correct answer is provided, whereupon the number of attempts is displayed.

J. M. Hinckley
2024
'''

import random

tryCount = 0
b = -1
while b != 0 and b != 1:
    b = int(input("Enter 0 for binary or 1 for hex: "))

numToGuess = random.randint(0, 255)


if b == 0:
    # binary
    print(bin(numToGuess))
else:
    # hex
    print(hex(numToGuess))

    
guess = -1
while guess != numToGuess:
    tryCount += 1
    guess = int(input("Enter your answer in base 10: "))
    if guess == numToGuess:
        break
    else:
        print("Nope.  ",end="")

print("Congratulations, you answered correctly, in",tryCount," attempts.")



