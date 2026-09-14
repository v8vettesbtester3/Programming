'''
Python 08, Ex 01

Develop a program that calculates the factorial of a number, using recursion.
The user supplies a positive integer and the program will calculate and print
its factorial.

J. M. Hinckley
2024
'''

def Fact(x):
    if x == 1 or x == 0:
        return 1
    else:
        return x * Fact(x-1)

def main():
    z = int(input("Enter an integer >= 0 (-1 to quit): "))
    while z != -1:
        f = Fact(z)
        print(z,"! = ",f,sep="")
        z = int(input("Enter an integer >= 0 (-1 to quit): "))
    print("Done.")

if __name__ == "__main__":
    main()
        
