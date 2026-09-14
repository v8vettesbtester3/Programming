'''
Python 05, Ex 04

Create a Python program which opens the file that you created
in the previous problem, for reading.
Input a single digit from the user (0-9).
Read the data from the file.
For each datum that you read, if the number ends in the user’s digit,
print that number to the screen.

J. M. Hinckley
2024
'''

f = open('test.txt', 'r')
allText = f.read()
f.close()
valList = allText.split()

# get a digit from user
n = int(input("Enter a single digit: "))

for v in valList:
    if v[-1] == str(n):
        print(v)
