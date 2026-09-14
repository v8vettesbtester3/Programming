'''
Python 02, Exercise 01

Write a Python program that asks you to enter
a floating point number.
The program is to calculate its square root
(must import the math module) and outputs
the result using the round function to display
no more than two digits after the decimal point.

J. M. Hinckley
2024
'''

import math
x = float(input("Enter a number: "))
y = math.sqrt(x)

print("Square root is",round(y,2))


