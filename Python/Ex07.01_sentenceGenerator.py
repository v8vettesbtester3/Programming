'''
Python 07, Ex 01

Develop a program that creates sentences.

J. M. Hinckley
2024
'''

import random

# vocabulary: words in four different parts of speech
f = open("nouns.txt", 'r')
s = f.read()
nouns = s.split()
f = open("verbs.txt", 'r')
s = f.read()
verbs = s.split()
f = open("articles.txt", 'r')
s = f.read()
articles = s.split()
f = open("prepositions.txt", 'r')
s = f.read()
prepositions = s.split()

def sentence():
    # builds and returns a sentence
    return nounPhrase() + " " + verbPhrase()

def nounPhrase():
    # builds and returns a noun phrase
    return random.choice(articles) + " " + random.choice(nouns)

def verbPhrase():
    # builds and returns a verb phrase
    return random.choice(verbs) + " " + nounPhrase() + \
           " " + prepositionalPhrase()

def prepositionalPhrase():
    # builds and returns a prepositional phrase
    return random.choice(prepositions) + " " + nounPhrase()

##print("Nouns:\n",nouns)
##print("\n\nVerbs:\n",verbs)
##print("\n\nArticles:\n",articles)
##print("\n\nPrepositions:\n",prepositions)

##print("Noun phrases:")
##for i in range(5):
##    print(nounPhrase())

##print("Prepositional phrases:")
##for i in range(5):
##    print(prepositionalPhrase())

##print("Verb phrases:")
##for i in range(5):
##    print(verbPhrase())

def main():
    # allows the user to input the number of sentences to generate
    number = int(input("\nEnter # of sentences: "))
    for count in range(number):
        print(sentence())

if __name__ == "__main__":
    main()
