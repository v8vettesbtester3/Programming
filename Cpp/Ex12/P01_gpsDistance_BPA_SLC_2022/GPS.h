#pragma once
#pragma once
#include <math.h>
#include <fstream>
#include <iostream>
#include <string>
#include <iomanip>
using namespace std;
#define M_PI 3.14159265358979323846
#define R 6371
#define W 8
class GPS
{
public:
	GPS(ifstream& stream);
	double GetDistance(GPS* other);
	void SetLongitude(double longitude);
	void SetLatitude(double latitude);
	double GetLongitude();
	double GetLatitude();
	void Display();
private:
	double longitude;
	double latitude;
};