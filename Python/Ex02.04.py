'''
Python 02, Exercise 04

Write a Python program that calculates the number of minutes in the following:
in an hour,
in a day
in a week
in a year (365.25 days).
Then input the user’s age (in whole years) and calculate and display
their age in minutes.

J. M. Hinckley
2024
'''

minPerDay = 60 * 24
print("Number of minutes per day:",minPerDay)

minPerWk = minPerDay * 7
print("Number of minutes per week:", minPerWk)

minPerYr = minPerDay * 365.25
print("Number of minutes per year:", minPerYr)

ageYrs = int(input("\nEnter your age in whole years: "))
ageMins = ageYrs * minPerYr

print("On your",ageYrs,"birthday, you were",ageMins,"minutes old.")
