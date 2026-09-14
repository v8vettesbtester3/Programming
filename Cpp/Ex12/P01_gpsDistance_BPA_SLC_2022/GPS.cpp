#pragma once
#include "GPS.h"
void GPS::SetLatitude(double latitude)
{
	this->latitude = latitude;
}
void GPS::SetLongitude(double longitude)
{
	this->longitude = longitude;
}
double GPS::GetLatitude()
{
	return this->latitude;
}
double GPS::GetLongitude()
{
	return this->longitude;
}
GPS::GPS(ifstream& stream)
{
	double lat, lng = 0;
	stream >> lat >> lng;
	SetLatitude(lat);
	SetLongitude(lng);
}
void GPS::Display()
{
	cout << setw(W) << this->GetLatitude() << ", " << setw(W) << this->GetLongitude();
}
double GPS::GetDistance(GPS* other)
{
	// Calculate longitude/latitude differences
	double latDif = (other->GetLatitude() - this->GetLatitude()) * M_PI / 180.0;
	double lonDif = (other->GetLongitude() - this->GetLongitude()) * M_PI / 180.0;
	// Convert latitude to radians
	double radLat1 = (this->GetLatitude() * M_PI) / 180.0;
	double radLat2 = (other->GetLatitude() * M_PI) / 180.0;
	// Perform Haversine distance calculation
	double sineA = pow(sin(latDif / 2), 2) + pow(sin(lonDif / 2), 2) * cos(radLat1) *
		cos(radLat2);
	double sineC = 2 * asin(sqrt(sineA));
	return R * sineC;
}