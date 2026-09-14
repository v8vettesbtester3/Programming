'''
Python 03, Exercise 05

Write a Python program that uses the while-else loop structure to provide
a distinction between ending the loop by breaking out of it and ending it
when the continue-condition is false.  This essentially provides two
conditional tests for leaving the while-loop.

Input the contents of a text file.  Remove the newline characters from the input
and concatenate each read line. Search the aggregated string for the target
string.  If found, stop reading the file and print a statement that the
target string was found in the file text.

J. M. Hinckley
2025
'''

# Input a target string (being searched for)
target = input("Enter the target string: ")

# Read the contents of a file, looking for the first occurrence
# of the target string.  The target string may span two lines.
s = ""
f = open('a.txt', 'r')
a=f.readline()
while a != "":
    if a[-1] == '\n':
        a = a[:-1]
    print("a =",a)
    s += a
    print("s =",s)
    if target in s:
        print("Found",target,"in",s)
        break
    a=f.readline()
else:
    print("Did not find",target,"in the entire file contents.")
f.close()

