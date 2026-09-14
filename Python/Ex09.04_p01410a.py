# p01410a.py

'''
Start a targeting "game" which uses turtle graphics.

When done, the "game" will draw a yellow dot on the screen and ask you
to enter a trajectory angle.

When you enter an angle, a ray is drawn from the origin, outward, at your angle.

If the ray hits the dot, the dot turns green.  If the ray misses the dot, the
dot turns red.

The program keeps track the number of hits and misses.

This improves your ability to estimate angles by sight.



1. Import the turtle module

2. Draw a horizontal line and a vertical line that cross at the origin.  These
   will represent the x and y axes.

   A. The x-axis line goes from [-1,0] to [1,0] in world coordinates and from
      [-200,0] to [200,0] in view coordinates.

   B. The y-axis line goes from [0,-1] to [0,1] in world coordinates and from
      [-200,0] to [200,0] in view coordinates.



Refer to https://docs.python.org/release/<version>/library/turtle.html# for
information on using turtle graphics.

'''

import turtle as t


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
