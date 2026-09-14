'''
Python 03, Exercise 04

Write a Python program that uses the for-else loop structure to provide
a distinction between ending the loop by breaking out of it and ending it
by reaching the end of the specified range.

Input a long string from the keyboard and a single character for which to search.
If the character is found, print the index of its first occurrence.
If the character is not found, print a statement saying that a match was not
found.

J. M. Hinckley
2025
'''

# Input a long string
s = input ("Enter a long string: ")
ch = input("\nEnter a character to find: ") # and the target character
for idx in range(len(s)):  # loop over the number of characters in the string
    if s[idx] == ch: # check for a match
        print("Found first matching character at position: ", idx)
        break

else:
    # comes here if the for-loop did not break
    print("Did not find a match.")
    
