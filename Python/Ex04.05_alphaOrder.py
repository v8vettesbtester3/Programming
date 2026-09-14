'''
Python 04, Ex 05

Create a Python program which inputs two words on a single line.
Use the split function to separate the input string into two strings,
one for each word.

Compare the two strings to determine which one comes first
(in alphabetical order).

Print out the two strings in alphabetical order.

J. M. Hinckley
2024
'''

inLine = input("Enter two words: ")
L = inLine.split()
print("Put into alphabetical order:")
if L[0] < L[1]:
    print(L[0], L[1])
else:
    print(L[1], L[0])
    
