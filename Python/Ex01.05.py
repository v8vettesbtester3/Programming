'''
Python 01, Exercise 05

Write a Python program that outputs a list of
integers from 1 to 10, and their squares and cubes.
The output should start like this:
1     1     1
2     4     8 , etc.
Control the format to use 6 columns per number,
right justified.

J. M. Hinckley
2024
'''

for row in range(10):
    x = row + 1
    a = x
    b = x*x
    c = x**3
    print(f'{a:>6}{b:>6}{c:>6}')
