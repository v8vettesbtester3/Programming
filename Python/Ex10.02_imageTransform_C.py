"""
File: transform.py
Project 7.12

Defines a transform function that represents a general
pattern for traversing an image and modifying its pixels.

Tests this function by using it to define grayscale and
black and white functions.
"""

from images import Image

 
def transform(image, function, Q):
    """Traverses the image and resets each pixel with the result
    of applying the function to it."""
    for y in range(image.getHeight()):
        for x in range(image.getWidth()):
            image.setPixel(x,y,function(image.getPixel(x,y), Q))


def passThru(triple, Q):
    return triple


def color2gray(triple, Q):
    # Converts a pixel to grayscale.
    (r, g, b) = triple
    r = int(r * 0.299)
    g = int(g * 0.587)
    b = int(b * 0.114)
    lum = r + g + b
    return (lum, lum, lum)


def threshold(triple, Q):
    # thresholding
    (r, g, b) = triple
    # assume r = g = b
    if r < Q:
        r = 0
        g = 0
        b = 0
    else:
        r = 255
        g = 255
        b = 255
    return (r, g, b)


##def contrast(triple, Q):
##    # increase contrast
##    (r, g, b) = triple
##    # assume r = g = b
##    xlo = Q[0]
##    xhi = Q[1]
##    if r < xlo:
##        r = 0
##        g = 0
##        b = 0
##    elif r > xhi:
##        r = 255
##        g = 255
##        b = 255
##    else:
##        r = 255 * (r - xlo)/ (xhi - xlo)
##        g = r
##        b = r
##    return (r, g, b)


##def falseColor(triple, Q):
##    # create false color image
##    LUT = [(255,0,0),       # red
##           (255, 201, 14),  # orange
##           (255,255,0),     # yellow
##           (0,255,0),       # green
##           (0,255,255),     # cyan
##           (0,0,255),       # blue
##           (68,0,255),      # violet
##           (255,0,255)      # magenta
##           ]
##    (r, g, b) = triple
##    # assume r = g = b
##    foundIt = False
##    for i in range(len(Q)):
##        if r < Q[i]:
##            r = LUT[i%len(LUT)][0]
##            g = LUT[i%len(LUT)][1]
##            b = LUT[i%len(LUT)][2]
##            foundIt = True
##            break
##    if foundIt == False:
##            r = LUT[0][0]
##            g = LUT[0][1]
##            b = LUT[0][2]
##    return (r, g, b)


def noOperation():
    pass
            
        
            
COMMANDS = {0:("QUIT",noOperation),
            1:("Original", noOperation),
            2:("Grayscale", passThru),
            3:("Thresholding", threshold),
##            4:("Contrast", contrast),
##            5:("False Color", falseColor),
            }
    


def pointOperation(opCode, image, Q):
    
    transform(image, color2gray, Q) # convert from color to grayscale

    (_,f) = COMMANDS[opCode]        # get the selected point operation function
    
    transform(image, f, Q)          # run the point operation


def printMenu():
    print("\n\nPoint Operation Menu")
    print("--------------------")
    for (k,v) in COMMANDS.items():
        cmd = v[0]
        print(k,'\t',cmd)

    
def acceptCommand():
    op = int(input("Enter command: "))
    if op in COMMANDS.keys():
        return op
    else:
        print("Invalid command.")
        return acceptCommand()

    

def runCommand(opCode, image):
    (operation,_) = COMMANDS[opCode]
    #print("A: opCode, operation =", opCode, operation)
    
    if operation == "QUIT":
        print("Done.")
        return

    elif operation == "Original":       # original color image
        print("Close the image to proceed.")
        image.draw()
        return

    elif operation == "Grayscale":      # gray scale
        Q = 0

    elif operation == "Thresholding":   # thresholding
        Q = int(input("Enter threshold: "))
            
##    elif operation == "Contrast":       # contrast
##        xlo = int(input("Enter low limit: "))
##        xhi = int(input("Enter high limit: "))
##        Q = (xlo, xhi)
        
##    elif operation == "False Color":    # false color
##        v = input("Enter equipotential, <enter> when finished ")
##        Q = ()
##        while v != "":
##            Q = Q + (int(v),)
##            v = input("Enter equipotential, <enter> when finished ")

    #print("B: Q =", Q)
    
    print("Processing image.")
    pointOperation(opCode, image, Q)
    
    print("Showing processed image.")
    print("Close the image to proceed.")
    image.draw()
    return
        

        

def main():
    filename = input("Enter the image file name: ")
    try:
        while True:
            image = Image(filename)
            printMenu()
            #print("C: calling acceptCommand()")
            opCode = acceptCommand()
            #print("D: calling runCommand()")
            runCommand(opCode, image)
            #print("E: returned from runCommand()")
            if COMMANDS[opCode][0] == "QUIT":
                #print("F: quitting")
                break

    except KeyboardInterrupt:
        print("\nProgram closed.")
    
    
if __name__ == "__main__":
    main()

