# p01410d.py

'''

Continue the targeting "game".

Make a copy of your p01410c.py program to p01410d.py.  Then continue development
as follows.

1. After drawing a yellow target dot, calculate the angle, in degrees,
   from the x-axis to the target dot.  Use your coordinates x and y for the
   center of the dot as arguments to the arctangent function.  Refer as needed
   to
   https://docs.python.org/release/<version>/library/math.html#
   
   Be sure to handle the special case where the absolute value of (x) is very small.
   Save this angle in the variable beta.

2. Since you want to determine whether the ray hits any part of the target,
   you will need to determine the angular range subtended at the origin
   by the target.  This means that you can count a hit, if the ray strikes the
   target anywhere, not just right in its center.

   Calculate the angle alpha (in degrees) between the line from the origin to
   the center of the dot and the line from the origin to the edge of the dot.
   Carefully draw the geometry on paper to figure out the trigonometric function
   for alpha.

3. Test whether the angle of the user's ray (gamma) is between beta - alpha
   and beta + alpha.

   A. If it is, mark the dot green and increment the count of hits.  You will
      need to go to the top of the program and initialize a hit counter.

   B. If it is not, mark the dot red and increment the count of misses.  You will
      need to go to the top of the program and initialize a miss counter.

4. At a convenient point in the "forever" loop, output the current value of
   number of hits and number of misses.

'''

import turtle as t
import math as m
import random as r

beta = 0

# init counts
numHits = 0
numMiss = 0

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
    # print results so far
    print("Hits:",numHits,"\tMisses:",numMiss, "\tBeta = ", format(beta,'.1f'))
    
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


    # mark target if gamma ray intersects it

    # angle to target center
    if abs(x) > 0.001:
        beta = m.degrees(m.atan2(y,x))
        if beta < 0:
            beta += 360
    elif y >= 0.0:
        beta = 90.0
    else:
        beta = 270.0

    # distance to target center
    distTarget = m.sqrt(x*x + y*y)

    # half angular width of target
    alpha = m.degrees(m.asin(radius / distTarget))

    # test whether within angular target
    t.setpos(draw_x, draw_y)
    if gamma < beta + alpha and gamma > beta - alpha:
        # hit: redraw dot
        t.dot(2*draw_radius,"green")
        numHits += 1
    else:
        t.dot(2*draw_radius,"red")
        numMiss += 1
        
    t.setpos(0,0)
