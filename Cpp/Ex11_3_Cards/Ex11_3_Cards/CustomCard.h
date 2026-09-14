#pragma once
#include "GreetingCard.h"
using namespace std;

class CustomCard :
    public GreetingCard
{
private:
    string image;
    string font;

public:
    // Constructor
    CustomCard(double width, double height, const string& message, const string& color,
        const string& image, const string& font)
        : GreetingCard(width, height, message, color), image(image), font(font) {
        // Set custom price $5.00 more than the superclass price
        GreetingCard::price += 5.00;
    }

    // Get methods
    const string& getImage() const { return image; }
    const string& getFont() const { return font; }

    // Set methods
    void setImage(const string& newImage) { image = newImage; }
    void setFont(const string& newFont) { font = newFont; }
};

