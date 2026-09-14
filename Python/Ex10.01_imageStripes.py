'''
Python 10, Ex 01

A program to demonstrate very simple
point operation of setting pixel color.

J. M. Hinckley
2024
'''

from images import Image
x = Image("smokey.gif")

print("Original image.  Close to continue.")

x.draw()

print("Modified image.  Close to save & end.")

red = (255, 0, 0)
green = (0, 255, 0)
blue = (0, 0, 255)
y = x.getHeight() // 2

for z in range(x.getWidth()):
    for a in range(0,12,3):
        x.setPixel(z, y+a-1, red)
        x.setPixel(z, y+a, green)
        x.setPixel(z, y+a+1, blue)

x.draw()

x.save("ModCat.gif")
