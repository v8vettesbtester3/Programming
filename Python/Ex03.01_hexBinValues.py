'''
Python 03, Exercise 01

Using bin() and hex() to represent numbers in binary and hexadecimal forms.

Write a Python program which outputs a 3-column list with 10 rows to show
the decimal (base 10) value of a number (column 1), the binary (base 2) value
of the same number (column 2) and the hexadecimal (base 16) value of the
same number.

Right justify all three columns, making the first column 4 characters wide,
the second column 10 characters wide and the third column six characters wide.
The numbers should increment by 5 from one row to the next, so your values
will be 5, 10, 15,..., 45, 50.


Use a for-loop to loop over the values in the first column,
taking steps of 5 with each iteration.

J. M. Hinckley
2024
'''

for x in range (5, 55, 5):
    print(f'{x:>4}{bin(x):>10}{hex(x):>6}')
    
