// P02_boxProblem.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
/*
C++ 06, Ex 02

Suppose that you have been given a flat cardboard of some given area, to make an open 
box by cutting a square from each corner and folding the sides.

Your objective is to determine the dimensions, that is, the length and width, 
and the side of the square to be cut from the corners so that the resulting box is of maximum volume.

Write a program that loops over the area of the flat cardboard, starting at 10 square inches 
and going up to 100 square inches in steps of 5 sq in, (e.g. 10, 15, 20, … 90, 95 ,100). 
For each area, the program then outputs the length and width of the cardboard and the 
length of the side of the square to be cut from the corner so that the resulting box 
is of maximum volume. Finally, the program outputs the volume of the box.  
Calculate your answer to three decimal places.

Your program should contain a function that takes as input the length and width of 
the cardboard and returns the side of the square that should be cut to maximize the volume. 
The function also returns this maximum volume.

J. M. Hinckley
2024
*/

#include <iostream>
#include <iomanip>
#include <fstream>
using namespace std;

void f(double length, double width, double& xAtMaxVol, double& maxVolume) {
	const int numSteps = 10000;
	double stepSize = __min(length / 2, width / 2) / numSteps;
	maxVolume = -1.0;
	xAtMaxVol = -1.0;
	for (int i = 0; i < numSteps; i++) {
		double x = (i + 1) * stepSize;
		double volume = x * (length - 2 * x) * (width - 2 * x);
		//cout << fixed << setprecision(4)  << x << "  " << volume << endl;
		if (volume > maxVolume) {
			maxVolume = volume;
			xAtMaxVol = x;
		}
	}
}

int main()
{
	ofstream g;
	g.open("box.txt");
	double A;
	cout << setw(10) << "A" << " "
		<< setw(10) << "Xsoln" << " " << setw(10) << "Lsoln" << " " << setw(10) << "Wsoln" << " " << setw(10) << "Vmax" << endl;

	for (int i = 2; i <= 20; i++) {
		A = i * 5.0;


		double L, W, X, V;
		//cout << "Enter Length: ";
		//cin >> L;
		//cout << "Enter Width: ";
		//cin >> W;
		// loop over length
		double Lmax = sqrt(A);
		int Lsteps = 20;
		double Vmax = -1.0;
		double Xsoln = -1.0;
		double Lsoln = -1.0;
		double Wsoln = -1.0;
		for (int idxL = 1; idxL <= Lsteps; idxL++)
		{
			L = Lmax * idxL / Lsteps;
			W = A / L;

			f(L, W, X, V);

			//cout << "X = " << X << endl;
			//cout << "V = " << V << endl;
			if (V > Vmax) {
				Vmax = V;
				Xsoln = X;
				Lsoln = L - 2 * Xsoln;
				Wsoln = W - 2 * Xsoln;
			}
		}
		cout << fixed << setprecision(3) << setw(10) << A << " "
			<< setw(10) << Xsoln << " " << setw(10) << Lsoln << " " << setw(10) << Wsoln << " " << setw(10) << Vmax << endl;
		g << fixed << setprecision(3) << setw(10) << A << " "
			<< setw(10) << Xsoln << " " << setw(10) << Lsoln << " " << setw(10) << Wsoln << " " << setw(10) << Vmax << endl;
	}
	g.close();
}
