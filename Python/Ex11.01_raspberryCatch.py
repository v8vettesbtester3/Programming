import pygame
from pygame.locals import *
from sys import exit
import random

# parameter definitions
score = 0
screen_width = 600
screen_height = 400
spoon_x = 300
spoon_y = screen_height - 100

#-------------------------------------------------

# Template defining a raspberry

class Raspberry:
    def __init__(self):         # initialization of a Raspberry
        self.x = random.randint(10, screen_width) # random horizontal pos.
        self.y = 0              # start at top
        self.dy = random.randint(1,5) # random step size

    def update(self):           # update position each cycle of game loop
        self.y += self.dy       # move down a bit
        if self.y > spoon_y:    # is rasp past the spoon?
            self.y = 0          # yes, go back to top
            self.x = random.randint(10, screen_width) # random horizontal pos.
        self.x += random.randint(-5, 5) # random lateral offset (jiggle)
        if self.x < 10:         # close to left side?
            self.x = 10         # hard limit at 10 on left side
        if self.x > screen_width - 20: # close to right side?
            self.x = screen_width - 20 # hard limit on right, too.
        screen.blit(raspberry_image, (self.x, self.y)) # update pygame with new
                                                       # location

    def is_caught(self):        # is the raspberry in the spoon?
        a = self.y >= spoon_y   # True if raspberry is at or below spoon.
        b = self.x >= spoon_x   # True if raspberry is at or right of spoon.
        c = self.x <= spoon_x + 50 # True if raspberry is at or left of sp. bowl
        return a and b and c

#-------------------------------------------------

# Main program        
        
clock = pygame.time.Clock()
rasps = [Raspberry(),Raspberry(),Raspberry()] # instantiate 3 Raspberries

pygame.init()   # initialize pygame module

# Set up the game
screen = pygame.display.set_mode((screen_width, screen_height))
pygame.display.set_caption('Raspberry Catching')
spoon = pygame.image.load('spoon.jpg').convert()
raspberry_image = pygame.image.load('raspberry.jpg').convert()

#--------------------------------------------

# some game loop functions

def update_spoon():
    global spoon_x
    global spoon_y
    spoon_x, _ = pygame.mouse.get_pos() # get location of cursor, ignore y
    screen.blit(spoon,(spoon_x, spoon_y))   # update game object

def check_for_catch():
    global score
    for r in rasps:         # loop over each raspberry
        if r.is_caught():   # is the raspberry caught?
            score += 1      # increment score

def display(message):
    font = pygame.font.Font(None,36)
    text = font.render(message, 1, (10,10,10))
    screen.blit(text, (0,0))    # update game object

#--------------------------------------------

# The game loop.

while True:

    # gracefully end by pressing "X" in window corner
    for event in pygame.event.get():
        if event.type == QUIT:
            exit()

    screen.fill((255,255,255))  # setting background color (white)

    # update each raspberry
    for r in rasps: # loop over raspberries
        r.update()  # run Raspberry update function

    update_spoon()                  # move spoon: run spoon update function
    check_for_catch()               # did catch one?
    display("Score: " + str(score)) # show new score
    pygame.display.update()         # redraw display with updated game objects
    clock.tick(30)                  # for every second 30 frames shown





    








    
