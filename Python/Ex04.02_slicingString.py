'''
Python 04, Ex 02

Slicing a string.
Create a Python program which asks the user to
input their first and last name.
Then, it prints that name, giving the last name,
a comma and space, then the first name.

J. M. Hinckley
2024
'''

fullName = input("Enter your first and last name (e.g. Bob Smith): ")

nameList = fullName.split(' ')

if len(nameList) > 1:
    print("Last name, first name: ", nameList[1],", ", nameList[0], sep="")
elif len(nameList) == 1:
    if len(nameList[0]) > 0:
        print("Single name input:", nameList[0])
    else:
        print("No name input.")
