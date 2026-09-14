#include <iostream>
#include <vector>
#include <fstream>
#include <string>
#include <iomanip>
#include "GPS.h"
using namespace std;
const string inputFilePath = "coordinates_data.txt";
const string outputFilePath = "distances.txt";
void sortDistances(vector<GPS*>& locs, GPS* curLoc)
{
	for (int j = 0; j < locs.size() - 1; j++) {	// Correction to BPA solution.  This outer loop is needed.
		for (int i = 0; i < locs.size() - 1 - j; i++)
		{
			if (curLoc->GetDistance(locs[i]) > curLoc->GetDistance(locs[i + 1]))
			{
				std::swap(locs[i], locs[i + 1]);
			}
		}
	}
}
int main()
{
	ifstream inputFile(inputFilePath);
	ofstream outputFile(outputFilePath);
	if (inputFile.is_open())
	{
		vector<GPS*> locs = vector<GPS*>();
		GPS* curLoc = new GPS(inputFile);
		while (!inputFile.eof())
		{
			GPS* tgtLoc = new GPS(inputFile);
			cout << "Haversine Distance to ";
			tgtLoc->Display();
			cout << " from ";
			curLoc->Display();
			cout << " : " << setw(W) << curLoc->GetDistance(tgtLoc) << "km" <<

				endl;

			locs.push_back(tgtLoc);
		}
		sortDistances(locs, curLoc);
		cout << endl << "Closest to furthest..." << endl;
		outputFile << curLoc->GetLatitude() << "," << curLoc->GetLongitude() <<

			endl;

		for (int i = 0; i < locs.size(); i++)
		{
			locs[i]->Display();
			cout << " : " << setw(W) << curLoc->GetDistance(locs[i]) << "km" <<

				endl;

			outputFile << locs[i]->GetLatitude() << "," << locs[i]->GetLongitude()

				<< "," << curLoc->GetDistance(locs[i]) << endl;

		}
	}
	else
	{
		cout << "Error reading file." << endl;
	}
	inputFile.close();
	outputFile.close();
	system("pause");
	return 0;
}