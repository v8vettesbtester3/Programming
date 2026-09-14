'''
Python 01, Exercise 03

Write a Python program that inputs from the user the radius
of a sphere (floating point number), then calculates and
displays its volume.
The output should be labeled with the text “Volume = “,
followed by the numerical value.

J. M. Hinckley
2024
'''

radius = float(input("Enter radius: "))

vol = (4/3)*3.141592 * radius * radius * radius

print("Volume =",vol)
