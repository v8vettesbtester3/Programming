'''
This function will encrypt the given string by first reversing the string then by rotating the
the characters in the string forward by 10 letters based on the ASCII table. It will then return
the encrypted string
'''
def encrypt(text):
    result = ""
    s=10
    # Reverses the string
    text = text[::-1]
    # transverse the plain text
    for i in range(len(text)):
        char = text[i]
        # Encrypt uppercase characters in plain text
        if (char.isupper()):
            result += chr((ord(char) + s - 65) % 26 + 65)
        # Encrypt lowercase characters in plain text
        else:
            result += chr((ord(char) + s - 97) % 26 + 97)
    return result

'''
This function will decrypt the given string by first rotating the
the characters in the string backward by 10 letters based on the ASCII table then by reversing the
string. The function then will return the decrypted string.
'''
def decrypt(text):
    result = ""
    s=10
    # transverse the plain text
    for i in range(len(text)):
        char = text[i]
        # Encrypt uppercase characters in plain text
        if (char.isupper()):
            result += chr((ord(char) - s + 65) % 26 + 65)
        # Encrypt lowercase characters in plain text
        else:
            result += chr((ord(char) - (s + 12) + 97) % 26 + 97)
    #Reverses the string
    result = result[::-1]
    return result

'''
The main program
'''
'''
To read plain text from an input file and encrypt it. Then write the encrypted
text to an output file.
'''
iFile = open("plainText.txt", "r") #open file as read
oFile = open("encryptedText.txt", "w")#open file as write
print ("Encrypted:\n")
for text in iFile:
    newTxt = encrypt(text.strip()) #use .strip to remove the newline character
    print (newTxt)
    oFile.write(newTxt + '\n')
iFile.close()
oFile.close()
'''
To read encrypted text from an input file and decrypt it. Then print the decrypted
text to the screen
'''
print ("\nDecrypted:\n")
iFile = open("encryptedText.txt", "r")
for text in iFile:
    print(decrypt(text.strip()))
