'''
Python 02, Exercise 05

Light travels at a speed of 3 * 10**8 m / s in a vacuum.
A light-year is the distance that light travels in one year.
Write a Python program that calculates and displays the distance of a
light-year in units of meters.

J. M. Hinckley
2024
'''

speed = 3e8   # speed of light (m/s)

secPerDay = 60 * 60 * 24
dayPerYr = 365.25

secPerYr = secPerDay * dayPerYr

lightYear = secPerYr * speed  # in units of meters = s * m/s

print("One light year =", lightYear,"meters.")
print(f"One light year = {lightYear:.2e} meters.")
print(f"One light year = {lightYear*0.001:.2e} km.")
print(f"One light year = {lightYear*0.001*0.621371:.2e} miles.")
