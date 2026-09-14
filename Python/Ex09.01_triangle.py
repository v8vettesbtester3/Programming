# triangle.py
'''
Python 09, Ex 01

Develop a program that draws right triangles, using Turtle graphics.

J. M. Hinckley
2024
'''

from turtle import Turtle

t = Turtle()

ans = input("Enter x, y for starting position, 'quit' for end: ")
#ans = input("Enter x, y for starting position: ")
while ans != 'quit':
    L = ans.split(',')
    x = int(L[0])
    y = int(L[1])
    t.penup()
    t.goto(x,100+y)
    t.pendown()
    t.width(2)
    t.pencolor("red")
    t.setheading(270)
    t.forward(100)
    t.width(4)
    t.pencolor("blue")
    t.left(90)
    t.forward(100)
    t.width(6)
    t.pencolor("green")
    t.goto(0+x,100+y)
    ans = input("Enter x, y for starting position, 'quit' for end: ")
    #ans = 'quit'
t.penup()
