'''
Python 05, Ex 03

Create a Python program which opens a file for output.
Then create a 10 x 10 multiplication table and write it out to the file.
Finally, close the file.

J. M. Hinckley
2024
'''

f = open("test.txt", "w")
for i in range(10):
    for j in range(10):
        v = (i+1) * (j + 1)
        f.write(str(v) + ' ')   # must be a string for output
    f.write('\n')
f.close()
