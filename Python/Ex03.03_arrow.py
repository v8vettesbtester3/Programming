'''
Python 03, Exercise 03

Write a Python program which calculates where an arrow will land when shot into the air.  Inputs need to be:
initial angle of trajectory (0 degrees is horizontal, 90 degrees is straight up)
target distance, in units of m.

Loop over values of the initial speed (units of m/s).
In each iteration, calculate how far away from the starting point it lands.
From your series of outputs from each iteration, find out what the
initial speed needs to be to land within 0.5 m of the center of the target.

J. M. Hinckley
2024
'''

from math import sin, cos, pi, radians

# theta is angle of initial trajectory (degrees)
theta = float(input("Enter initial trajectory between 0 and 90 degrees: "))

# distance to the target (m)
d = float(input("Enter a distance for the target (m): "))

# initial value of v0 (speed) (m / s)
v0 = 1

# gravitational acceleration (m / s^2)
g = 9.8

# time increment per iteration
dt = 0.1

# loop over value of speed
while True:
    # simulate motion y (height) as a function of time t
    # equations of motion:
    # x = v0 * cos(theta) * t
    # y = v0 * sin(theta) * t - (1/2) * g * t^2

    # loop over values of time (t)
    t = 0
    while True:
        t = t + dt  # time step

        # calculate y for this value of t
        y = v0 * sin(radians(theta)) * t - 0.5 * g * t * t

        # did it hit the ground?
        if y <= 0:
            # yes it has hit
            # calculate x for this value of t
            x = v0 * cos(radians(theta)) * t
            break  # stop looping over time

    # check distance
    # did it overshoot, more than 0.5 m?
    if x > d + 0.5:
        # too far.  So decrease v0.
        v0 = v0 * 0.9999

    # did it undershoot, more than 0.5 m?
    elif x < d - 0.5:
        # not far enough.  So increase v0.
        v0 = v0 * 1.0001

    # otherwise it must have hit
    else:
        # on target. So leave loop over v0.  v0 is our solution.
        break

# show result
print("Final distance (m): ", round(x,1), "Initial speed (m/s):", round(v0,1))
