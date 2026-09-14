'''
Python 07, Ex 02

Write a program that mimics a non-directive psychotherapy session.

J. M. Hinckley
2024
'''

import random

hedges = ("Please tell me more.",
          "Many of my patients tell me the same thing.",
          "Please continue.")

qualifiers = ("Why do you say that ",
              "You seem to think that ",
              "Can you explain why ")

replacements = {"I":"you", "me":"you", "my":"your",
                "we":"you", "us":"you", "mine":"yours"}

def reply(sentence):
    # Builds and returns a reply to a sentence
    probability = random.randint(1,4)
    ##print(probability, end = " ")
    if probability == 1:
        return random.choice(hedges)
    else:
        return random.choice(qualifiers)+changePerson(sentence)

def changePerson(sentence):
    # Replaces first person pronouns with second person pronouns
    words = sentence.split()
    ##print(words)
    ##print(f'%-10s %-15s' % ('word', 'get(word,word)'))
    replyWords = []
    for word in words:
        ##print(f'%-10s %-15s' % (word, replacements.get(word, word)))
        replyWords.append(replacements.get(word, word))
    ##print(replyWords)
    return " ".join(replyWords)

##print(changePerson('I left my house today.'))
##for i in range(10):
##    print(reply('I left my house today.'))

def main():
    # Handles interaction between patient and doctor
    print("\nGood morning, I hope that you are well today.")
    print("What can I do for you?")
    while True:
        sentence = input("\n>>")
        if sentence.upper() == "QUIT":
            print("Have a nice day!")
            break
        print(reply(sentence))

# The entry point for execution
if __name__ == "__main__":
    main()
