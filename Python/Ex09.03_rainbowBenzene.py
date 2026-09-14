# Python program to draw  
# Rainbow Benzene 
# using Turtle Programming
'''
Python 09, Ex 03

Write a Python Turtle program which draws a polygonal-design

J. M. Hinckley
2024
'''

import turtle as t

#t = Turtle()

colors = ['red', 'purple', 'blue', 'green', 'orange', 'yellow',
          'aquamarine', 'violet red', 'blue2', 'chartreuse2',
          'light sky blue', 'RosyBrown2']

##colors = ['#0080c0', '#0ab612', '#daf327', '#ed0707',
##                   '#e70ed1', '#0a1beb', '#5c8a98', '#c94f2c',
##                   '#3d32c2', '#ffffff', '#ff80c0', '#80ff80']

t.speed(0)

numSides = 0
while numSides < 2 or numSides > len(colors):
    msg = "Enter number of sides, between 2 and " + str(len(colors)) + ": "
    numSides = int(input(msg))
    
t.Screen().bgcolor('black')

t.goto(0,0)

for x in range(360): 
    t.pencolor(colors[x%numSides]) 
    #t.pencolor(colors[0]) 
    t.width(x/100 + 1) 
    t.forward(x)
    angle = 360 / numSides + 1
    t.left(angle) 
