// Regional_CPlusPlus.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

/* Student ID: for graders */
#include <iostream>
#include <string>
#include <cctype> // For isdigit
#include <iomanip> // For std::fixed and std::setprecision
#include <algorithm> // For std::transform
using namespace std;
// Function to handle input validation
void getInput(
	string& firstName,
	string& lastName,
	string& make,
	string& model,
	string& licensePlate,
	int& speed,
	int& speedLimit,
	bool& inSchoolZone,
	bool& inConstructionZone
) {
	string tempInput;
	bool validInput;
	/* SC1 */
	/* a-i */
	// Validate and prompt for first name
	validInput = false;
	while (!validInput) {	// SC1a
		cout << "Enter first name: ";
		getline(cin, firstName);
		validInput = !firstName.empty();
		if (!validInput) {
			cout << "First name cannot be blank. Please try again." << endl;
		}
	}
	// Validate and prompt for last name
	validInput = false;
	while (!validInput) {	// SC1b
		cout << "Enter last name: ";
		getline(cin, lastName);
		validInput = !lastName.empty();
		if (!validInput) {
			cout << "Last name cannot be blank. Please try again." << endl;
		}
	}
	// Validate and prompt for make of the car
	validInput = false;
	while (!validInput) {	// SC1c
		cout << "Enter car make: ";
		getline(cin, make);
		validInput = !make.empty();
		if (!validInput) {
			cout << "Make of the car cannot be blank. Please try again." << endl;
		}
	}
	// Validate and prompt for model of the car
	validInput = false;
	while (!validInput) {	// SC1d
		cout << "Enter car model: ";
		getline(cin, model);
		validInput = !model.empty();
		if (!validInput) {
			cout << "Model of the car cannot be blank. Please try again." << endl;
		}
	}
	// Validate and prompt for license plate number
	validInput = false;
	while (!validInput) {	// SC1e
		cout << "License plate number (1 to 8 characters): ";
		getline(cin, licensePlate);
		validInput = !licensePlate.empty() && licensePlate.length() <= 8;
		if (!validInput) {
			cout << "License plate number must be between 1 and 8 characters. Please try again." << endl;
		}
	}
	// Validate and prompt for speed
	validInput = false;
	while (!validInput) {	// SC1f
		cout << "Enter speed (non-negative integer): ";
		getline(cin, tempInput);
		bool isInteger = true;
		validInput = !tempInput.empty() && !(tempInput[0] == '-' && tempInput.size() ==
			1);
		// Check if input is a valid integer
		if (validInput) {
			for (char c : tempInput) {
				if (!isdigit(c)) {
					isInteger = false;
					break;
				}
			}
			validInput = isInteger;
		}
		if (validInput) {
			speed = stoi(tempInput);
			if (speed >= 0) {
				validInput = true;
			}
			else {
				validInput = false;
			}
		}
		if (!validInput) {
			cout << "Invalid input. Please enter a valid non-negative integer for speed." <<
				endl;
		}
	}
	// Validate and prompt for speed limit
	validInput = false;
	while (!validInput) {	// SC1g
		cout << "Enter speed limit (non-negative integer): ";
		getline(cin, tempInput);
		bool isInteger = true;
		validInput = !tempInput.empty() && !(tempInput[0] == '-' && tempInput.size() ==
			1);
		// Check if input is a valid integer
		if (validInput) {
			for (char c : tempInput) {
				if (!isdigit(c)) {
					isInteger = false;
					break;
				}
			}
			validInput = isInteger;
		}
		if (validInput) {
			speedLimit = stoi(tempInput);
			if (speedLimit >= 0) {
				validInput = true;
			}
			else {
				validInput = false;
			}
		}
		if (!validInput) {
			cout << "Invalid input. Please enter a valid non-negative integer for speed limit." <<
				endl;
		}
	}
	// Validate and prompt for school zone status
	validInput = false;
	while (!validInput) {	// SC1h
		cout << "Is the infraction in a school zone (true or false)? ";
		getline(cin, tempInput);
		if (tempInput == "true") {
			inSchoolZone = true;
			validInput = true;
		}
		else if (tempInput == "false") {
			inSchoolZone = false;
			validInput = true;
		}
		else {
			cout << "Invalid input. Please enter 'true' or 'false' for school zone status." << endl;
		}
	}
	// Validate and prompt for construction zone status
	validInput = false;
	while (!validInput) {	// SC1i
		cout << "is the infraction in a construction zone (true or false)? ";
		getline(cin, tempInput);
		if (tempInput == "true") {
			inConstructionZone = true;
			validInput = true;
		}
		else if (tempInput == "false") {
			inConstructionZone = false;
			validInput = true;
		}
		else {
			cout << "Invalid input. Please enter 'true' or 'false' for construction zone status."
				<< endl;
		}
	}
	cout << "Ticket entry created." << endl;
}
int main() {
	// Variables to hold user input
	string firstName, lastName, make, model, licensePlate;
	int speed, speedLimit;
	double fine = 0.0;
	bool inSchoolZone, inConstructionZone;
	string anotherTicket;
	do
	{
		// Get and validate inputs
		getInput(firstName, lastName, make, model, licensePlate, speed, speedLimit,
			inSchoolZone, inConstructionZone);
		// Calculate the fine based on the inputs
		int difference = speed - speedLimit;
		if (difference > 0) {
			fine = difference * 20.0;
		}
		else {
			fine = 0.0;
		}
		// Apply multipliers for school zone and construction zone infractions
		if (inSchoolZone) {
			fine *= 2.0; // Double for school zone
		}
		if (inConstructionZone) {
			fine *= 3.0; // Triple for construction zone
		}
		/* SC2 */
		/* a-i */
		// Display the fine and user information with two decimal points
		cout << fixed << setprecision(2); // Set precision for currency formatting
		cout << "\nName: " << firstName << " " << lastName << endl;	// SC2a
		cout << "Car Make: " << make << endl;						// SC2b
		cout << "Car Model: " << model << endl;						// SC2c
		cout << "License Plate: " << licensePlate << endl;			// SC2d
		cout << "Speed: " << speed << " mph" << endl;				// SC2e
		cout << "Speed Limit: " << speedLimit << " mph" << endl;	// SC2f
		cout << "School Zone: " << (inSchoolZone ? "true" : "false") << endl;	// SC2g
		cout << "Construction Zone: " << (inConstructionZone ? "true" : "false") << endl;	// SC2h
		cout << "Ticket Cost: $" << fine << endl;					// SC2i
		/* SC3 */
		// Ask the user if they want to enter another ticket
		cout << "\nWould you like to enter another ticket? (yes or no): ";	// SC3a
		getline(cin, anotherTicket);
		// Convert input to lowercase
		transform(anotherTicket.begin(), anotherTicket.end(), anotherTicket.begin(), ::tolower);	// SC3b
	} while (anotherTicket == "yes");
	return 0;
}