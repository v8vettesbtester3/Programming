# p01410c.py

'''

Continue the targeting "game".

Make a copy of your p01410b.py program to p01410c.py.  Then continue development
as follows.

1. Change the input of the user's 'x' to end the program, into a query for
   the trajectory angle.  If the user enters 'x', break out of the "forever"
   loop, as before.  Otherwise, convert the user's input to a float, which is
   the angle of the ray's trajectory, in degrees.

2. Draw the ray, from the origin, in the direction of the user's angle.  Make
   the ray as long as the distance from the origin to the center of the dot.

3. After drawing the ray, return the turtle to the origin.

'''

import turtle as t
import math as m
import random as r

# drawing scale
scale = 200

# draw origin cross
xmin=-1.0*scale
xmax=1.0*scale
ymin=xmin
ymax = xmax

t.setpos(xmin,0)
t.pendown()
t.setpos(xmax,0)
t.penup()
t.setpos(0,ymin)
t.pendown()
t.setpos(0,ymax)
t.penup()
t.setpos(0,0)

radius = float(input("Enter target radius: "))
draw_radius = scale * radius


while True:
    # randomly pick coordinates of target
    distTarget = 0.0
    while distTarget < 1.25*radius:
        x = 4.0 * (r.random()-0.5)
        y = 4.0 * (r.random()-0.5)
        distTarget = m.sqrt(x*x + y*y)

    # draw the target
    draw_x = scale * x
    draw_y = scale * y


    
    t.penup()
    t.setpos(draw_x, draw_y)
    t.pendown()
    t.dot(2*draw_radius,"yellow")
    t.penup()
    t.setpos(0,0)

    # enter gamma angle
    resp = input("Enter angle of trajectory (deg), (x to exit): ")
    if resp == 'x':
        break   
    gamma = float(resp)
    if gamma < 0:
        gamma += 360

    # draw gamma ray
    t.setpos(0,0)
    t.pendown()
    t.setheading(gamma)
    t.forward(scale*distTarget)
    t.penup()
    t.setpos(0,0)
