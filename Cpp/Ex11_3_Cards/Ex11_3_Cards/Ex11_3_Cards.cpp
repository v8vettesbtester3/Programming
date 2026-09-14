// Ex11_3_Cards.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>
#include "GreetingCard.h"
#include "CustomCard.h"

using namespace std;

int main()
{
    // Instantiate a GreetingCard
    GreetingCard greetingCard(5.0, 7.0, "Happy Birthday!", "Blue");

    // Print field values of GreetingCard
    cout << "Greeting Card Details:" << endl;
    cout << "Width: " << greetingCard.getWidth() << endl;
    cout << "Height: " << greetingCard.getHeight() << endl;
    cout << "Message: " << greetingCard.getMessage() << endl;
    cout << "Color: " << greetingCard.getColor() << endl;
    cout << "Price: $" << greetingCard.getPrice() << endl << endl;

    // Ask user for input to create CustomCard
    cout << "Enter details for Custom Card:" << endl;
    double customWidth, customHeight;
    string customMessage, customColor, customImage, customFont;

    cout << "Width: ";
    cin >> customWidth;
    cout << "Height: ";
    cin >> customHeight;
    cout << "Message: ";
    cin.ignore(); // Clear the newline character from the buffer
    getline(cin, customMessage);
    cout << "Color: ";
    cin >> customColor;
    cout << "Image: ";
    cin >> customImage;
    cout << "Font: ";
    cin >> customFont;

    // Instantiate a CustomCard using user-supplied values
    CustomCard customCard(customWidth, customHeight, customMessage, customColor, customImage, customFont);

    // Print field values of CustomCard
    cout << "\nCustom Card Details:" << endl;
    cout << "Width: " << customCard.getWidth() << endl;
    cout << "Height: " << customCard.getHeight() << endl;
    cout << "Message: " << customCard.getMessage() << endl;
    cout << "Color: " << customCard.getColor() << endl;
    cout << "Image: " << customCard.getImage() << endl;
    cout << "Font: " << customCard.getFont() << endl;
    cout << "Price: $" << customCard.getPrice() << endl;

    return 0;
}
