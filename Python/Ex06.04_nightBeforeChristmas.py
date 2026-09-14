'''
Python 06, Ex 04

Using a dictionary.
A file concordance tracks the unique words in a file and their frequencies.
Write a Python program that inputs a text file and prints (outputs) the
unique words in alphabetical order.
The program should omit any punctuation characters and convert all letters
to lowercase.  

For example, if the file was the following line of text:
“Not a creature was stirring, not even a mouse;” the output would be:

a               2
creature    1
even         1
mouse      1
not            2
stirring      1
was          1

The program should also report the most frequently occurring word(s).
For the above example, that would be:

2 occurrences of:
a
not

Run your program inputting the attached file nbc.txt (Night Before Christmas).


J. M. Hinckley
2024
'''

f = open("nbc.txt", 'r')
L = []
for line in f:
    words = line.split()
    for x in words:
        x = x.lower()
        L.append(x)
f.close()

# Remove the punctuattion characters
#print(L)
prList = []
for w in L:
    prword = ""
    for c in w:
        if c >= 'a' and c <= 'z':
            prword += c

    if prword != "":
        prList.append(prword)

# Count the occurrences of each word
#print(prList)
d = {}
for w in prList:
    if w not in d:
        d[w] = 1
    else:
        d[w] += 1

# Print the words and their counts in alpha order
for w in sorted(d.keys()):
    print(w, d[w])

# Find the maximum count value and a correspsonding word
maxval = -1
keymax = -1
for w in d.keys():
    if d[w] > maxval:
        maxval = d[w]
        keymax = w

# Find all words occurring with this maximum frequency
# (more than one word may occur most frequently)
# Print out the result of the most frequent word(s).
for w in d.keys():
    if d[w] == maxval:
        print("\nMost frequently occurring word is:",w)
        print("# occurrences:", d[w])

              

