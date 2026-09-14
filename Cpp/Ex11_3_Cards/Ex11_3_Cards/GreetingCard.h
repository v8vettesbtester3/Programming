#pragma once
#include <string>
using namespace std;

class GreetingCard
{
private:
    double width;
    double height;
    string message;
    string color;
protected:
    double price;

public:
    // Constructor
    GreetingCard(double width, double height, const string& message, const string& color)
        : width(width), height(height), message(message), color(color), price(10.00) {}

    // Get methods
    double getWidth() const { return width; }
    double getHeight() const { return height; }
    const string& getMessage() const { return message; }
    const string& getColor() const { return color; }
    double getPrice() const { return price; }
};

