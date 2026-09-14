#include <iostream>
#include <string>
using namespace std;

string square(double x) {
    string s = to_string(x) + "**2 = " + to_string(x*x);
    return s;
}
string cube(double x) {
    string s = to_string(x) + "**3 = " + to_string(x * x * x);
    return s;
}
string quad(double x) {
    string s = to_string(x) + "**4 = " + to_string(x * x * x * x);
    return s;
}
void print(string (*f)(double), double x) {
    cout << f(x) << endl;
}


int main() {
    string (*functionPtr)(double) = nullptr;

    double num;
    cout << "Enter a number: ";
    cin >> num;

    int sel = -1;
    while (sel < 0) {
        cout << "1: square " << endl;
        cout << "2: cube " << endl;
        cout << "3: fourth power " << endl;
        cout << "0: exit " << endl;
        cin >> sel;
        if (sel > 3) sel = -1;
        if (sel == 0) break;
        switch (sel) {
        case 1:
            functionPtr = &square;
            break;
        case 2:
            functionPtr = &cube;
            break;
        case 3:
            functionPtr = &quad;
            break;
        default:
            ;
        }
    }

    print(functionPtr, num);

    return 0;
}
