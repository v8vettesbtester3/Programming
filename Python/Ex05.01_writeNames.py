'''
Python 05, Ex 01

Create a Python program which opens a file for output.
Write some person’s full name (first name and last name) to the file.
Then, on a second line, write another person’s full name.
Then close the file.

J. M. Hinckley
2024
'''

f = open("test01.txt", 'w')
f.write("Bob Smith\nLucy Jones")
f.close()
