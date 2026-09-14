'''
Python 06, Ex 01

Write a program which uses a loop of five iterations to
input integers from the keyboard.

As each number is input, append it to a list and print
the list so that you see the progression of the list
growing as each value is added to it.

J. M. Hinckley
2024
'''

L = []

for i in range(5):
    x = int(input("Enter value: "))
    L.append(x)
    print(L)
