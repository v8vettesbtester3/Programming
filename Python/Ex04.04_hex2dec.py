'''
Python 04, Ex 04

Converting from base 16 to base 10.
Refer to the binary to decimal program in the slide deck, as a guide.
Create a Python program which can convert a number in base-16 to
its base-10 representation.
Input the base 16 number from the user.

J. M. Hinckley
2024
'''

while True:
    hexString = input("Enter a hexadecimal number ('z' to quit): ")
    if hexString == 'z':
        break
    
    decimal = 0
    exponent = len(hexString) - 1

    for digitString in hexString:
        if digitString == "0":
            digit = 0
        elif digitString == "1":
            digit = 1
        elif digitString == "2":
            digit = 2
        elif digitString == "3":
            digit = 3
        elif digitString == "4":
            digit = 4
        elif digitString == "5":
            digit = 5
        elif digitString == "6":
            digit = 6
        elif digitString == "7":
            digit = 7
        elif digitString == "8":
            digit = 8
        elif digitString == "9":
            digit = 9
        elif digitString == "A" or digitString == "a":
            digit = 10
        elif digitString == "B" or digitString == "b":
            digit = 11
        elif digitString == "C" or digitString == "c":
            digit = 12
        elif digitString == "D" or digitString == "d":
            digit = 13
        elif digitString == "E" or digitString == "e":
            digit = 14
        elif digitString == "F" or digitString == "f":
            digit = 15
            
        decimal = decimal + digit * 16**exponent
        exponent = exponent - 1

    print("The decimal value is:", decimal)
