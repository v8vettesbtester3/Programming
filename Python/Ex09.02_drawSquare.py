'''
Python 09, Ex 02

Write a Python Turtle graphics program that draws a series of squares.
For this program, write a function that draws a square.
The function takes parameters for the x, y coordinates of the
location of the square and a parameter for the length of
a side of the square.

In your main function, define a list of three tuples,
each tuple being the parameter values for one of the squares.
This will define three squares for your program to draw.
Then loop over the list of parameter tuples, for each one,
pass the values of the given tuple to your square-drawing function,
which draws a square as specified by the parameters.

J. M. Hinckley
2024
'''

from turtle import Turtle

def drawBox(t, x, y, length):
    t.up()
    t.goto(x,y)
    t.setheading(270)
    t.down()
    for count in range(4):
        t.forward(length)
        t.left(90)


t = Turtle()

Boxes = [(100, 100, 25), (200, 50, 47), (-50, -50, 20)]

for b in range(len(Boxes)):
    x = Boxes[b][0]
    y = Boxes[b][1]
    length = Boxes[b][2]
    drawBox(t, x, y, length)


