'''
Python 06, Ex 03

Simple plotting.
Create a Python program which uses a dictionary to record the frequency
of occurrence of numerical values read from a file.
After generating this information, the program is to write the
values and their frequencies out to a text file, in ascending order of the
keys.
For example, suppose your input file of numerical values was as follows:
5
3
6
3
1
9
1
3

Your dictionary would be {‘5’:1, ‘3’:3, ‘6’:1, ‘1’:2, ‘9’:1}.
This would be written to the output text file as:
1   2
3   3
5   1
6   1
9   1


J. M. Hinckley
2024
'''

fn = input("Enter the name of the input data file: ")
f = open(fn,'r')
# one number per line
L = []
for line in f:
    L.append(int(line))
f.close()


# fill the dictionary
theDictionary = {}
for number in L:
    freq = theDictionary.get(number, None)
    if freq == None:
        # number entered for the first time
        theDictionary[number] = 1
    else:
        # number already seen, increment its freq
        theDictionary[number] = freq + 1

# sort the dictionary by keys
keyList = list(theDictionary.keys())
keyList.sort()
# dictionary comprehension
sorted_dictionary = {i:theDictionary[i] for i in keyList} 

# output to a file
fn = input("Enter the name of the output data file: ")
f = open(fn, 'w')
for key in sorted_dictionary:
    f.write(str(key) + " " + str(sorted_dictionary[key]) + '\n')

f.close()
            



