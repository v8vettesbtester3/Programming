'''
Python 05, Ex 05

Write a Python program that records the time, each time that it is run.
This is a program that does the following:

 1. Checks for the existence of a subdirectory named Log
     (use the function os.path.exists() ).
     
 2. If Log does not exist, create a subdirectory named Log
     (use the function mkdir() ).
     
 3. Change the current working directory to Log
     (use the function chdir() ).
     
 4. Gets a list of all of the files in the directory Log
     (use the functions getcwd() and listdir() ).
     
 5. For each filename in this list, if its filename ends in “.log”,
     and it is a file (use the function isfile() ),
     add the first part of the filename (before “.log”) to a second list.
     
 6. For each string in the second list, if it is numeric
     (use the string function isnumeric() ),
     convert the string to an integer and add it to a third list.
     
 7. Find the largest integer in the third list.
 
 8. Create the name of a new file to be created.
     Add 1 to the largest integer found in the previous step.
     Create the filename as the string concatenation of
     str(LargestInteger + 1) + “.log”.
     
 9. Open a new file for writing, using this filename.
 
10. In the file, write the value of LargestInteger + 1
     and the current date and time.
     
11. Close the file.

J. M. Hinckley
2024
'''

import os
import datetime

# 1. Check for the existence of a subdirectory named "Log".
if not os.path.exists("Log"):
    # The subdirectory Log does not exist.
    # 2. Make it.
    os.mkdir("Log")


# 3. Change the current working directory to Log
os.chdir("Log")


# 4. Get a list of all of the files in the directory Log
currentDirectoryPath = os.getcwd()
L1 = os.listdir(currentDirectoryPath)


# 5. For each filename in this list, if its filename ends in “.log”,
#     and it is a file (use the function isfile() ),
#     add the first part of the filename (before “.log”) to a second list.
L2 = []
for fn in L1:
    if os.path.isfile(fn):
        if fn[-4:] == ".log":
            L2.append(fn[:-4])


# 6. For each string in the second list, if it is numeric
#     (use the string function isnumeric() ),
#     convert the string to an integer and add it to a third list.
L3 = []
for s in L2:
    if s.isnumeric():
        L3.append(int(s))


# 7. Find the largest integer in the third list.
maxint = 0
for i in L3:
    if i > maxint:
        maxint = i


# 8. Create the name of a new file to be created.
#     Add 1 to the largest integer found in the previous step.
#     Create the filename as the string concatenation of
#     str(LargestInteger + 1) + “.log”.
fn = str(maxint + 1) + ".log"


# 9. Open a new file for writing, using this filename.
f = open(fn, "w")


# 10. In the file, write the value of LargestInteger + 1
#     and the current date and time.
x = datetime.datetime.now()
f.write(str(x))


# 11. Close the file.
f.close()



            
