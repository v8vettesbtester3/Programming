'''
Python 06, Ex 02

Using lists and dictionaries.
There are three commonly used averages for a set of numbers.
a. Mean: sum all numbers and divide by the number of values.
b. Median: half of the numbers are less than this value, half are larger
   than this value.
c. Mode: this is the most frequently occurring value in the set of numbers.


Write a Python program  which reads the numbers in a provided file into a list.
The program is to have three functions, each of which take a list of numbers
as its parameter:

The first function calculates and returns the mean value of the input list
of numbers.
The second function calculates and returns the mode of the input list
of numbers.
The third function calculates and returns the median of the input list
of numbers.

To calculate the mode, you will need to use a dictionary to hold the data.

J. M. Hinckley
2024
'''

def mean(lyst):
    """Returns the mean of a list of numbers."""
    sum = 0
    for number in lyst:
        sum += number
    if len(lyst) == 0:
        return 0
    else:
        return sum / len(lyst)

def mode(lyst):
    """Returns the mode of a list of numbers."""
    # Obtain the set of unique numbers and their
    # frequencies, saving these associations in
    # a dictionary
    theDictionary = {}
    for number in lyst:
        freq = theDictionary.get(number, None)
        if freq == None:
            # number entered for the first time
            theDictionary[number] = 1
        else:
            # number already seen, increment its freq
            theDictionary[number] = freq + 1

    # Find the mode by obtaining the maximum freq
    # in the dictionary and determining its key
    if len(theDictionary) == 0:
        return 0
    else:
        theMaximum = max(theDictionary.values())
        for key in theDictionary:
            if theDictionary[key] == theMaximum:
                return key

def median(lyst):
    """Returns the median of a list of numbers."""
    # Create a copy of lyst before sorting
    numbers = []
    for number in lyst:
        numbers.append(number)
    # Sort the list and return the number at its midpoint
    numbers.sort()
    if len(numbers) == 0:
        return 0
    else:
        midpoint = len(numbers) // 2
        if len(numbers) % 2 == 1:
            return numbers[midpoint]
        else:
            return (numbers[midpoint] + numbers[midpoint - 1]) / 2

#import statistics

def main():
    """Tests the functions."""
    fn = input("Enter the name of the input data file: ")
    f = open(fn,'r')
    # one number per line
    L = []
    for line in f:
        L.append(int(line))
    f.close()

    # The purpose of this exercise is NOT to run methods from the
    # statistics module.  So don't do this:
    # print("Mode:", statistics.mode(L))
    # print("Median:", statistics.median(L))
    # print("Mean:", statistics.mean(L))

    # The purpose of this exercise is to practice working with
    # lists and dictionaries.  So, write your own functions for
    # mean, median and mode:
    print("Mode:", mode(L))
    print("Median:", median(L))
    print("Mean:", mean(L))

# The entry point for program execution
if __name__ == "__main__":
    main()
     
    
        
