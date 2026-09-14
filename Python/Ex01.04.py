'''
Python 01, Exercise 04

Write a Python program that outputs a rectangular
multiplication table from 1X1 to 10X10.
Control the format of the data in each line so that
each number is allocated 4 columns, right justified.

J. M. Hinckley
2024
'''

for row in range(10):
    y = row + 1
    for col in range(10):
        x = col + 1
        z = x * y
        print(f'{z:>4}', end = '')
    print()
    
