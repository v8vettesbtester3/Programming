'''
Python 08, Ex 02

Develop a program that calculates the nth term (one-based indexing)
in the Fibonacci sequence, which is 1, 1, 2, 3, 5, 8, 13, 21, 34, 55,...,
using recursion.
The user supplies a positive index and the program will calculate
and print the corresponding term of the Fibonacci sequence.

J. M. Hinckley
2024
'''

def Fib(x):
    if x == 0 or x == 1:
        return 1
    else:
        return Fib(x-1) + Fib(x-2)

def main():
    z = int(input("Enter the index of an element (>= 1)(0 to quit): "))
    while z != 0:
        f = Fib(z-1)
        if z%10 == 1:
            print(z,"st Fib value = ",f,sep="")
        elif z%10 == 2:
            print(z,"nd Fib value = ",f,sep="")
        elif z%10 == 3:
            print(z,"rd Fib value = ",f,sep="")
        else:
            print(z,"th Fib value = ",f,sep="")
        z = int(input("Enter the index of an element (>= 1)(0 to quit): "))

    print("Done.")
            

if __name__ == "__main__":
    main()
        
