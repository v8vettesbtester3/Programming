import os
import os.path

QUIT = "7"
COMMANDS = ("1", "2", "3", "4", "5", "6", "7")
MENU = """1 List the current directory
2 Move up
3 Move down
4 Number of files in the directory
5 Size of the directory in bytes
6 Search for a filename
7 Quit the program"""

def main():
    while True:
        print(os.getcwd())
        print(MENU)
        command = acceptCommand()
        runCommand(command)
        if command == QUIT:
            print("Done.")
            break

def acceptCommand():
    'Inputs and returns a legitimate command number'
    command = input("Enter a number: ")
    if command in COMMANDS:
        return command
    else:
        print("Error: command not recognized")
        # recursion:
        return acceptCommand()

def runCommand(command):
    if command == "1":
        listCurrentDir()
    elif command == "2":
        moveUp()
    elif command == "3":
        moveDown()
    elif command == "4":
        print("The total number of files is:", countFiles())
    elif command == "5":
        print("The total number of bytes is:", countBytes())
    elif command == "6":
        target = input("Enter the search string: ")
        fileList = findFiles(target)
        if not fileList:
            print("String not found")
        else:
            for x in fileList:
                print(x)

def listCurrentDir():
    dirName = os.getcwd()
    L = os.listdir(dirName)
    for x in L:
        print(x)

def moveUp():
    os.chdir("..");

def moveDown():
    newDir = input("Enter the subdirectory name: ")
    newPath = os.getcwd() + os.sep + newDir;
    if os.path.exists(newPath) and os.path.isdir(newDir):
        os.chdir(newDir)
    else:
        print("Error: named directory does not exist.")

def countFiles():
    count = 0
    dirName = os.getcwd()
    L = os.listdir(dirName)
    for x in L:
        if os.path.isfile(x):
            count += 1
        else:
            os.chdir(x)
            count += countFiles()
            os.chdir("..")
    return count

def countBytes():
    count = 0
    dirName = os.getcwd()
    L = os.listdir(dirName)
    for x in L:
        if os.path.isfile(x):
            count += os.path.getsize(x)
        else:
            os.chdir(x)
            count += countBytes()
            os.chdir("..")
    return count

def findFiles(target):
    # Returns a list of the filenames that contain
    # the target string in the cwd and all subdirectories
    files = []
    dirName = os.getcwd()
    L = os.listdir(dirName)
    for x in L:
        if os.path.isfile(x):
            #count += 1
            if target in x:
                fullPath = dirName + os.sep + x
                files.append(fullPath)
        else:
            os.chdir(x)
            #print("LOOKING IN",os.getcwd())
            #count += countFiles()
            M = findFiles(target) # list of files from subdir
            files.extend(M)
            os.chdir("..")
    return files
        


if __name__ == "__main__":
    main()
