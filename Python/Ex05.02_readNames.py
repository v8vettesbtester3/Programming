'''
Python 05, Ex 02

Create a Python program which opens the file that you created
in the previous problem, for reading.
Use the technique of “for L in f:” to loop over the lines in the file.
Print each name from the file.
Then close the file.

J. M. Hinckley
2024
'''

f = open("test01.txt", 'r')
for L in f:
    print(L)
f.close()
