/*
C++ 06, Ex 03

Numerical methods:  
A pipe is to be carried around the right-angled corner of two intersecting hallways.  
Calculate the length of the longest pipe that can be carried level around the right-angled corner.  
Disregard the diameter of the pipe (you may treat it as a line, or a pipe with zero diameter).  
Calculate your results as a table, varying the widths of the hallways. 
Let the first hallway range from 4 feet wide to 12 feet wide, in increments of 1 foot.  
Let the second hallway range from 4 feet wide up to (and equal to) the width of the first hallway.  
This will entail 45 calculations of the solution Length = AB + BC = W1 / sin(theta) + W2 / cos(theta), 
0 < theta < 90 degrees.

Output your results in a formatted table, using format 10.3f.  
Print 10 spaces in the positions of the table which do not contain numerical values 
(below the diagonal in the above chart).

J. M. Hinckley
2024
*/
#include <iostream>
#include <iomanip>
#include <cmath>
#include <limits>
using namespace std;

int main() {
    const int min_width = 4;
    const int max_width = 12;
    const int num_widths = max_width - min_width + 1;

    // Print table header
    std::cout << std::setw(10) << "Width 1";
    for (int width1 = min_width; width1 <= max_width; width1++) {
        std::cout << std::setw(10) << width1;
    }
    std::cout << std::endl;

    // Calculate and print the results
    for (int width2 = min_width; width2 <= max_width; width2++) {
        std::cout << std::setw(10) << width2;
        for (int width1 = min_width; width1 <= max_width; width1++) {
            if (width2 <= width1) {
                // Calculate angle in radians
                //double theta = atan(static_cast<double>(width2) / width1); // wrong
                
                /*
                // theta in terms of w1, w2 obtained by taking derivative of length with repsect to theta
                double w1w2 = static_cast<double>(width1) / static_cast<double>(width2);
                double w1w2_3 = pow(w1w2, (1.0 / 3.0));
                double theta = atan(w1w2_3);
                double length = width1 / sin(theta) + width2 / cos(theta);
                */

                // Find length and theta by iterating over all values of theta and finding minimum length
                double length = numeric_limits<double>::max();
                for (int i = 0; i <= 9000; i++) // loop over values of theta
                {
                    double theta = static_cast<double>(i) * 0.01 * 3.141592 / 180.0;    // in radians
                    double L = width1 / sin(theta) + width2 / cos(theta);
                    if (L < length) {
                        length = L;
                    }
                }

                std::cout << std::fixed << std::setprecision(3) << std::setw(10) << length;
            }
            else {
                // Print spaces for invalid combinations
                std::cout << std::setw(10) << " ";
            }
        }
        std::cout << std::endl;
    }

    return 0;
}
