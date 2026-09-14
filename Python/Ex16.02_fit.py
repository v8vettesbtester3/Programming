# Ex16.02  Curve fitting
# Find coefficients A, B, C and D for {x,y} data measurements,
# where model is y = A*x*x*x + B*x*x + C*x + D

import numpy as np

L = [] # list of x,y pairs

fn = input("Enter filename: ")
f = open(fn, 'r')
for line in f:
    vals = line.split()
    x = float(vals[0])
    y = float(vals[1])
    L.append((x,y))
f.close()

SumX6 = 0
SumX5 = 0
SumX4 = 0
SumX3 = 0
SumX2 = 0
SumX1 = 0
SumX0 = 0
SumYX3 = 0
SumYX2 = 0
SumYX1 = 0
SumYX0 = 0

if len(L) > 0:
    for i in range(len(L)):
        x = L[i][0]
        y = L[i][1]
        SumX6 += x*x*x*x*x*x
        SumX5 += x*x*x*x*x
        SumX4 += x*x*x*x
        SumX3 += x*x*x
        SumX2 += x*x
        SumX1 += x
        SumX0 += 1
        SumYX3 += y*x*x*x
        SumYX2 += y*x*x
        SumYX1 += y*x
        SumYX0 += y

    A = np.array([[SumX6, SumX5, SumX4, SumX3],
                  [SumX5, SumX4, SumX3, SumX2],
                  [SumX4, SumX3, SumX2, SumX1],
                  [SumX3, SumX2, SumX1, SumX0]])

    Y = np.array([SumYX3, SumYX2, SumYX1, SumYX0])

    print(A)
    print(Y)
    input("Enter to continue")

    X = np.linalg.solve(A, Y)

    print(X)
    
