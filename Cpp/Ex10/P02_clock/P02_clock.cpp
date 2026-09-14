// P02_clock.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
/*
C++ 10, Ex 02

Develop a C++ program that implements a clock.
The first three fields are for the current time. The next three are for an alarm time.  
The setters and getters take hour, minute, second arguments.  
There are three functions to increment each.  
The method printTime shows the time on a 12-hour clock, 
whereas printTime24 shows it on a 24-hour clock.  
The method setAlarm takes hour, minute, second parameters and sets the value 
of the alarm time (second three fields, above). 
The function checkAlarm outputs an alarm message if

alarm time <= current time <= alarm time + 1 minute.

Check the alarm every time the seconds are incremented.

J. M. Hinckley
2024
*/
#include <iostream>
#include <iomanip>
using namespace std;

class clockType {
private:
    int hr; // Current hour
    int min; // Current minute
    int sec; // Current second

    int alarmHr; // Alarm hour
    int alarmMin; // Alarm minute
    int alarmSec; // Alarm second

public:
    // Constructor to initialize time and alarm time to 00:00:00
    clockType() : hr(0), min(0), sec(0), alarmHr(0), alarmMin(0), alarmSec(0) {}

    // Set the current time
    void setTime(int hours, int minutes, int seconds) {
        hr = (hours >= 0 && hours < 24) ? hours : 0;
        min = (minutes >= 0 && minutes < 60) ? minutes : 0;
        sec = (seconds >= 0 && seconds < 60) ? seconds : 0;
    }

    // Set the alarm time
    void setAlarm(int hours, int minutes, int seconds) {
        alarmHr = (hours >= 0 && hours < 24) ? hours : 0;
        alarmMin = (minutes >= 0 && minutes < 60) ? minutes : 0;
        alarmSec = (seconds >= 0 && seconds < 60) ? seconds : 0;
    }

    // Get the current time
    void getTime(int& hours, int& minutes, int& seconds) const {
        hours = hr;
        minutes = min;
        seconds = sec;
    }

    // Increment seconds
    void incrementSeconds() {
        sec++;
        if (sec > 59) {
            sec = 0;
            incrementMinutes();
        }
        checkAlarm();
    }

    // Increment minutes
    void incrementMinutes() {
        min++;
        if (min > 59) {
            min = 0;
            incrementHours();
        }
    }

    // Increment hours
    void incrementHours() {
        hr++;
        if (hr > 23) {
            hr = 0;
        }
    }

    // Print time in 12-hour format
    void printTime() const {
        int displayHr = hr % 12;
        if (displayHr == 0) displayHr = 12;
        cout << (displayHr < 10 ? "0" : "") << displayHr << ":"
            << (min < 10 ? "0" : "") << min << ":"
            << (sec < 10 ? "0" : "") << sec
            << (hr < 12 ? " AM" : " PM") << endl;
    }

    // Print time in 24-hour format
    void printTime24() const {
        cout << (hr < 10 ? "0" : "") << hr << ":"
            << (min < 10 ? "0" : "") << min << ":"
            << (sec < 10 ? "0" : "") << sec << endl;
    }

    // Check if current time matches the alarm time
    void checkAlarm() const {
        int totalSec = 60 * (60 * hr + min) + sec;
        int totalAlarmSec = 60 * (60 * alarmHr + alarmMin) + alarmSec;
        if (totalSec < totalAlarmSec) totalSec += 24 * 60 * 60;
        
        if (totalSec - totalAlarmSec < 60)
        {
            cout << "Alarm! Time to wake up!" << endl;
        }
    }
}; 


int main()
{
    clockType myClock;

    int hours, minutes, seconds;

    // Set initial time
    cout << "Set the initial time (hours minutes seconds): ";
    cin >> hours >> minutes >> seconds;
    myClock.setTime(hours, minutes, seconds);

    // Set alarm time
    cout << "Set the alarm time (hours minutes seconds): ";
    cin >> hours >> minutes >> seconds;
    myClock.setAlarm(hours, minutes, seconds);

    // Display options
    char option;
    do {
        cout << "\nCurrent Time (12-hour format): ";
        myClock.printTime();
        cout << "Current Time (24-hour format): ";
        myClock.printTime24();

        cout << "\nOptions:\n";
        cout << "i: Increment time by 1 second\n";
        cout << "q: Quit\n";
        cout << "Choose an option: ";
        cin >> option;

        if (option == 'i') {
            myClock.incrementSeconds();
        }
    } while (option != 'q');

    return 0;
}
