# p01410b.py

'''
Continue the targeting "game".

Make a copy of your p01410a.py program to p01410b.py.  Then continue development
as follows.

1. Ask the user for the target radius and input the value.  This is the radius
   of the dots that will be drawn, in world coordinates.

2. Calculate the value of the radius in the view coordinates.

3. Start a "forever" while loop.  This will be used to repeatedly draw yellow
   target dots.

4. Generate a pseudo-random value for the view x coordinate of the center
   of the dot, in the range of [-2.0, 2.0).  Find out how to use the
   pseudo-random number generator at
   https://docs.python.org/release/<version>x/library/random.html#

5. Generate a pseudo-random value for the view y coordinate of the center
   of the dot, in the range of [-2.0, 2.0).

6. Calculate the distance from the origin of the world view to the center of
   the dot.  To calculate the distance, you will need to use the Pythagorean
   theorem.  This will involve using the square-root function.  Learn how to
   use this at
   https://docs.python.org/release/<version>/library/math.html#
   
   If this distance is less than 125% of the dot radius, calculate
   another pair of coordinates (x,y) for the dot.  This keeps the dot away
   from the origin.

7. Convert your coordinates from world to view coordinates.

8. Draw a yellow dot at this location, having the radius that you specified
   above.

9. Input a response from the user, before going on.  If the user types an 'x',
   exit the program.  Otherwise, return the turtle to the origin.

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

#t.speed(0)

t.setpos(xmin,0)
t.pendown()
t.setpos(xmax,0)
t.penup()
t.setpos(0,ymin)
t.pendown()
t.setpos(0,ymax)
t.penup()
t.setpos(0,0)

radius = 2.0
while radius >= 1.0 or radius <= 0.0:
    radius = float(input("Enter target radius (0,1): "))
    
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
    resp = input("(x to exit): ")
    if resp == 'x':
        break   
        
    t.setpos(0,0)
