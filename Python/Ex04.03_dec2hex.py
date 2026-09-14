'''
Python 04, Ex 03

Converting from base 10 to base 16.
Refer to the decimal to binary program in the slide deck, as a guide.
Create a Python program which can convert a number in base-10 to
its base-16 representation.
Input the base 10 number from the user.

J. M. Hinckley
2024
'''

while True:
    decimal = int(input("Enter a decimal integer (< 0 to quit): "))
    if decimal < 0:
        break

    if decimal == 0:
        print("The hexadecimal representation is:", 0)
    else:
        hexString = ""
        while decimal > 0:
            remainder = decimal % 16
            # Convert remainder to a hex digit as a string
            hexDigit = ""
            if remainder < 10:
                hexDigit = str(remainder)
            elif remainder == 10:
                hexDigit = "A"
            elif remainder == 11:
                hexDigit = "B"
            elif remainder == 12:
                hexDigit = "C"
            elif remainder == 13:
                hexDigit = "D"
            elif remainder == 14:
                hexDigit = "E"
            elif remainder == 15:
                hexDigit = "F"
                
            decimal = decimal // 16

            hexString = str(hexDigit) + hexString

            #print("%5d%8d%12s" % (decimal, remainder, hexString))
        print("The hexadecimal representation is:", hexString)
