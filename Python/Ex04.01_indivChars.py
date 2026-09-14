'''
Python 04, Ex 01

Accessing individual characters in a string.
Create a Python program that asks the user to input their full name.
Then, it prints that name in reverse order.

J. M. Hinckley
2024
'''

fullName = input("Enter your name: ")

print("In reverse order:")

# Loop from end to start of string.
for i in range(len(fullName)):
    print(fullName[-(i+1)], end="")
