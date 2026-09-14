'''
Python 02, Exercise 03

An object’s linear momentum is the product
of its mass and its velocity.

The object’s kinetic energy is one half of
its mass multiplied by the square of its
velocity:

E = 0.5 * m * v**2.

Write a Python program that inputs from the
user, the mass (in units of kg) and
velocity (in units of m / s) and then
calculates the momentum
(in units of kg m / s) and its
kinetic energy
(in units of Joules = kg m^2 / s^2).
Label the output:

Momentum (kg m / s) = … 
Kinetic energy (kg m^2 / s^2) = …


J. M. Hinckley
2024
'''

m = float(input("Enter mass (kg): "))
v = float(input("Enter speed (m/s): "))

p = m * v
e = 0.5 * m * v * v

print("Momentum (kg m / s) =", p)
print("Kinetic energy (kg m^2 / s^2) =", e)



