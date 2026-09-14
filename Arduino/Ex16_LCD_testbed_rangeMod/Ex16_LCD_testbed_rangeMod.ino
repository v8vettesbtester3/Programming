// Ex16_LCD_testbed_rangeMod: 
//
// Extension of Ex16_LCD_testbed to include operation of an HC-SR04 ultrasonic sensor to
// measure and display the distance to an object.
//
// Various examples using LCD, the serial monitor for both output and input,
// and various sensors.
//
// The purpose of this program is to exhibit using a liquid crystal display (LCD)
// A secondary purpose is to show how to use the serial monitor for various
// kinds of user input in addition to output from the microprocessor.  
//
// The LCD and serial monitor together constitute a rudimentary
// user I/O system.  This system is used to present four different types of operation:
// 1. Display a physical quantity measured with a sensor.  The ambient temperature is measured and displayed.
//    The sensor is repeatedly read and its value displayed, in a loop.
// 2. Display the value of pi to a user-specified number of decimal places.
//    The number of decimal places to display is input from the serial monitor,
//    exhibiting how to input multi-digit integers rather than single characters through the monitor.
// 3. Display either the binary or hexadecimal value of a decimal integer, also
//    exhibiting how to input multi-digit integers rather than single characters through the monitor.
// 4. Display custom characters which have been specified here using bit patterns.
//
// This is a menu-driven program.  Presentation and reading of the user's menu selection, 
// exhibits how to input single characters through the monitor.
//
//
// Structure of this program:
//
// A. Circuit Characteristics Definitions
//    lcd : LiquidCrystal_I2C 
//    SCALE : const int 
//
// B. Menu and Operations
//    tasks       : String[]
//    numTasks    : size_t
//    menuKeys    : char[]
//    operations  : void (*[])()
//    idxShowMenu : const int 
//    noOperation : char 
//    state       : char 
//    printMenu() : void
//
// C. Input Functions
//    readCharSerial()  : char 
//    readIntSerial()   : unsigned int 
//
// D. Circuit and Display Functions
//    displayTemperature(float, char) : void 
//    measureAndDisplayTemperature()  : void 
//    displayPi()                     : void 
//    displayBinHex()                 : void 
//    displayCustomChars()            : void 
//
// E. Setup and Loop 
//    setup() : void 
//    loop()  : void 




//==================================================
//==================================================
//    A. Circuit Characteristics Definitions
//==================================================
//==================================================

// Library for controlling the LCD
#include <LiquidCrystal_I2C.h>

// Format: (Address, Width, Height)
LiquidCrystal_I2C lcd(0x27, 16, 2);

// define digital input/output pins
const int TRIGGER = 2;
const int ECHO = 3;
const int SCALE = 4;
const int BUZZER = 5;
const int LED_BLUE = 10;
const int LED_GREEN = 11;
const int LED_YELLOW = 12;
const int LED_RED = 13;

// Distance thresholds
float zone1 = 5.0;   // distance <= zone1, red LED on
                     // distance > zone1, red LED off
float zone2 = 10.0;  // distance <= zone2, > zone1, yellow LED on
                     // distance > zone2, yellow LED off
float zone3 = 15.0;  // distance <= zone3, > zone2, green LED on
                     // distance > zone3, green LED off, blue LED on



//==================================================
//==================================================
//    B. Menu and Operations
//==================================================
//==================================================

// ---------------- Globals ------------------------

// Different tasks to be represented as menu items
String tasks[] = {"show the menu", "measure temperature", "display pi",
                  "display bin, hex", "display custom characters", "measure distance",
                  "set ranges"};

// Number of items in the menu
size_t numTasks = sizeof(tasks) / sizeof(tasks[0]); // number of tasks

// Array of characters: User inputs to select a menu item.
// Should be lower case alphabetical characters
char menuKeys[] = {'m', 't', 'p', 'b', 'c', 'd', 'r'}; // enter character to make menu selection

// Array of function pointers: Functions corresponding to each menu item.
// Each function should return void and take no parameters.
// Menu Item    Function
// ---------------------------------------------------
//      m       void printMenu()
//      t       void measureAndDisplayTemperature()
//      p       void displayPi()
//      b       void displayBinHex()
//      c       void displayCustomChars()
//      d       void measureAndDisplayDistance()
//      r       void setRanges()
void (*operations[])() {printMenu, measureAndDisplayTemperature, displayPi,
                        displayBinHex, displayCustomChars, measureAndDisplayDistance,
                        setRanges};

// Index of the show menu task
const int idxShowMenu = 0;



// State-machine controls
char noOperation = 'X';   // "No-operation" code
char state = noOperation; // State of operation



//==================================================
// Print the menu on the serial monitor.
//==================================================

void printMenu() {
      Serial.println("MENU:");
      for (int i = 0; i < numTasks; i++) {
        Serial.print(menuKeys[i]);
        Serial.print(": ");
        Serial.println(tasks[i]);
      }
      state = noOperation; // change back to noOperation so menu display is not repeated
}



//==================================================
//==================================================
//    C. Input Functions
//==================================================
//==================================================



//==================================================
// Read a character from the serial monitor.
// If COMMAND_MODE == CONTINUOUS, 
//    this function will return whether or not a character is read.
// If COMMAND_MODE == SINGLESTEP,
//    this function will return only when a character matching a menu item is input.

// Start a forever-loop:
//    If a character is present in the input window,
//        Read that character.
//        If that character matches one of the keys in the menu,
//          Return the character
//        Otherwise, keep looping, reading characters from the input window
//==================================================

char readCharSerial() {
  // Specify how commands are processed.
  // Precompiler directives are used instead of constants because the
  // structure of the code is required to be different for the two 
  // different values of COMMAND_MODE.
#define CONTINUOUS 0  // Temperature and custom character functions run continuously
#define SINGLESTEP 1  // All functions execute once per menu command
#define COMMAND_MODE CONTINUOUS


  char retVal = '\0';
  while (true) {
    if (Serial.available() > 0) {
      // Send button has been pressed after entering a character.
  
      // Debugging: show what is happening.
      //Serial.println("Serial.available() > 0"); // for debugging
  
      // Read a character from the input box of the serial monitor.
      // If the user has entered multiple characters in the input box,
      // then read the first character of that sequence.  Following
      // characters will be read the next time the program executes 
      // a Serial.read() or Serial.parseInt() function call.
      retVal = Serial.read();
      
      // Debugging: show what was read (or zero if non-numerical)
      //Serial.print("Character read: ");         // for debugging
      //Serial.println(retVal);                   // for debugging

      // Check whether the input character matches one of the menu item keys.
      // Leave the forever while-loop when a valid menu item key is read.
      
      bool valid = false; // set true if retVal equals an element of menuKeys
      for (int i = 0; i < numTasks; i++) {
        if (retVal == menuKeys[i]) {
          valid = true; // found the valid task
          #if COMMAND_MODE == SINGLESTEP
            break;  // leave for-loop
          #elif COMMAND_MODE == CONTINUOUS
            return retVal;
          #endif
        }
      }
      
      if (valid) break; // leave forever while-loop, if a valid input was read
      #if COMMAND_MODE == CONTINUOUS
        else return noOperation;
      #endif
      // Otherwise, either some other character  was read, so keep looping.

      // Debugging: show what is happening.
      //Serial.println("Looping");                // for debugging
    }
    #if COMMAND_MODE == SINGLESTEP
      delay(100); // wait 0.1 second before looping again.
    #elif COMMAND_MODE == CONTINUOUS
      return noOperation;
    #endif
  }
  return retVal;
}



//==================================================
// Read an integer from the serial monitor.
// Return only after a positive integer is actually read.

// This function reads any positive (> 0) integer, from 
// 1 to 65535, from the input box of the serial monitor.

// Start a forever-loop:
//    If a string of characters is present in the input window,
//        Read that string and convert it to an integer
//        If the string was not numerical, the resulting integer is set to zero
//        If the resulting integer is greater than zero,
//          Return the integer
//        Otherwise, keep looping, reading characters from the input window
//==================================================

unsigned int readIntSerial() {
  unsigned int retVal = 0;
  while (true) {
    if (Serial.available() > 0) {
      // Send button has been pressed after entering a multi-character string.

      // Debugging: show what is happening.
      //Serial.println("Serial.available() > 0"); // for debugging

      // Convert the multi-character string to an unsigned integer.
      // If the string contains non-numerals, parseInt() returns zero.
      retVal = Serial.parseInt();

      // Debugging: show what was read (or zero if non-numerical)
      //Serial.print("Character read: ");         // for debugging
      //Serial.println(retVal);                   // for debugging

      // Leave loop when a positive integer is read
      if (retVal != 0) break;
      
      // Otherwise, either zero or a non-numerical string
      // was read, so keep looping.

      // Debugging: show what is happening.
      //Serial.println("Looping");                // for debugging
    }
    delay(100); // wait 0.1 second before looping again.
  }
  return retVal;
}


  
  



//==================================================
//==================================================
//    D. Circuit and Display Functions
//==================================================
//==================================================



//==================================================
//    Measuring and Displaying Temperature
//==================================================

// Display the temperature
void displayTemperature(float f, char unit) {
  int k = (int) round(f);     // Round input to nearest integer
  lcd.clear();                // Clear the display buffer.
  lcd.setCursor(0,0);         // Set cursor (Col, Row)
  lcd.print("The temp is:");  // "The temp is:" at (0,0)
  lcd.setCursor(0,1);         // Set cursor (Col, Row)
  char* line = new char[9];   // Dynamically allocate memory
  sprintf(line,"%3d deg %c",k,unit);  // format output
  lcd.print(line);            // temperature value at (0,1)
  free(line);                 // release dynamically allocated memory
}


void measureAndDisplayTemperature() {
  // Measure
  int doDegF;
  float sensor = analogRead(0); 
  float voltage = (sensor*5000)/1024; // convert raw sensor val to mV
  voltage = voltage - 500;            // remove offset
  float degC = voltage / 10.0;        // convert mV to deg C

  // Display
  if (doDegF = digitalRead(SCALE) != 0) {
    // switch not pressed, show deg F
    float degF = 1.8 * degC + 32;       // convert to deg F
    displayTemperature(degF, 'F');
    Serial.println(degF);               // display T in deg F
  }
  else {
    // switch pressed, show deg C
    displayTemperature(degC, 'C');
    Serial.println(degC);               // display T in deg C
  }
}



//==================================================
//    Displaying pi
//==================================================

// Display pi to specified number of decimal places.
void displayPi() {
  const double pi = 3.141592654;
  lcd.clear();
  // On the Arduino Uno a double is implemented as a 32-bit float,
  // so there are only 6 or 7 significant decimal digits.
  int numDP = -1;
  do {
    Serial.println("Enter number of decimal places (0-7).");
    numDP = readIntSerial();
    if (numDP >= 0 && numDP <= 7) {
      lcd.print(pi,numDP);
    }
  } while (numDP < 0 || numDP > 7);
  state = noOperation; // change back to noOperation so menu display is not repeated
}



//==================================================
//    Displaying Binary and Hexadecimal Values
//==================================================

// Display the binary and hexadecimal representations of a number
void displayBinHex() {
  lcd.clear();
  unsigned int value = 8192;
  while (value > 8191) {
    Serial.println("Enter a positive base-10 integer <= 8191.");
    value = readIntSerial();
    Serial.print("Value read in: ");
    Serial.println(value);
  }

  lcd.setCursor(0,0);
  lcd.print("B: ");
  lcd.print(value,BIN); // display value in binary
  lcd.setCursor(0,1);
  lcd.print("H: ");
  lcd.print(value,HEX); // display value in hexadecimal
  
  state = noOperation; // change back to noOperation so menu display is not repeated
}



//==================================================
//    Displaying Custom Characters
//==================================================

void displayCustomChars(){
  static int col = 0;
  static int row = 0;
  static int chPair = 0;  // 0 for first 2 chars, 1 for second 2 chars
  
  lcd.setCursor(col,row);

  static int charIdx = 0;
  ++charIdx %= 2; // toggle between the two characters
  lcd.write(byte(charIdx+2*chPair));  // 0 <-> 1 (chPair = 0) OR 2 <-> 3 (chPair = 1)

  // set row, col for next time this is called.
  ++col %= 16;  // cycles over range [0,15]
  if (col == 0) {
    ++row %= 2; // whenever at first column, advance the row number
    if (row == 0) {
      ++chPair %= 2;  // whenever at top row, switch the character pair
    }
  }
  
  return;
}



//==================================================
//    Measuring and Displaying Distance
//==================================================

// All LEDs off
void allLEDsOff() {
  digitalWrite(LED_RED, LOW);
  digitalWrite(LED_YELLOW, LOW);
  digitalWrite(LED_GREEN, LOW);
  digitalWrite(LED_BLUE, LOW);
}

void buzzerOff() {
  noTone(BUZZER);
}

// Display the distance
void displayDistance(float x) {

  // Display on LCD
  // On the Arudino Uno, sprintf() does not support floating-point values using
  // %f format specifier.  
  // Instead, use dtostrf() to convert float to string, then display the string.
  
  char s[10]; // string to hold string representation of distance (cm)
  int decimalPlaces = 2;  // Round to specified number of decimal places.
  dtostrf(x,                // float value to convert to string
          4+decimalPlaces,  // total width of string
          decimalPlaces,    // number of digits after decimal point
          s);               // string buffer

  lcd.clear();                // Clear the display buffer.
  lcd.setCursor(0,0);         // Set cursor (Col, Row)
  lcd.print("The distance is:");  // "The distance is:" at (0,0)
  lcd.setCursor(0,1);         // Set cursor (Col, Row)
  char* line = new char[10];  // Dynamically allocate memory
  sprintf(line,"%s cm",s);    // format output
  lcd.print(line);            // temperature value at (0,1)
  free(line);                 // release dynamically allocated memory


  // Display on LEDs and run the buzzer
  allLEDsOff();
  buzzerOff();
  
  if (x > zone3) {
    // blue LED on, others off
    digitalWrite(LED_BLUE, HIGH);
  }
  else if (x > zone2) {
    // green LED on, others off
    digitalWrite(LED_GREEN, HIGH);
    //tone(BUZZER, 200);
  }
  else if (x > zone1) {
    // yellow LED on, others off
    digitalWrite(LED_YELLOW, HIGH);
    //tone(BUZZER, 800);
  }
  else {
    // red LED on, others off
    digitalWrite(LED_RED, HIGH);
    //tone(BUZZER, 3200);
  }

  if (x <= zone3) {
    const float lowFreq = 50.0;
    const float highFreq = 3200.0;
    const float closeDist = 2.0;
    float f = lowFreq + (highFreq - lowFreq)*(zone3 - x)/(zone3 - closeDist);
    tone(BUZZER, f);
  }
}


void measureAndDisplayDistance() {
  // Measure
  // 1. Trigger the pulse
  digitalWrite(TRIGGER, LOW);
  delayMicroseconds(2); // Wait a bit
  digitalWrite(TRIGGER, HIGH);
  delayMicroseconds(10); // 10us pulse
  digitalWrite(TRIGGER, LOW);

  // 2. Measure echo time
  long duration = pulseIn(ECHO, HIGH); // Time in microseconds

  // 3. Calculate distance in cm
  float distance = (duration * 0.034) / 2;

  // Display
  displayDistance(distance);
  Serial.println(distance);               // display distance in cm
}



//==================================================
//    Set Ranges
//==================================================

void setRanges() {
    float z;
  do {
    Serial.println("Enter distance (cm) to zone1 - zone2 threshold.");
    z = (float)readIntSerial();
  } while (z <= 0);
  zone1 = z;
  do {
    Serial.println("Enter distance (cm) to zone2 - zone3 threshold.");
    z = (float)readIntSerial();
  } while (z <= zone1+0.1);
  zone2 = z;
  do {
    Serial.println("Enter distance (cm) to zone3 - zone4 threshold.");
    z = (float)readIntSerial();
  } while (z <= zone2+0.1);
  zone3 = z;

  lcd.setCursor(0,0);
  lcd.print("Z1: ");
  lcd.print((int)zone1); // display value of distance (cm) to zone1 - zone2 threshold.
  lcd.setCursor(8,0);
  lcd.print("Z2: ");
  lcd.print((int)zone2); // display value of distance (cm) to zone2 - zone3 threshold.
  lcd.setCursor(0,1);
  lcd.print("Z3: ");
  lcd.print((int)zone3); // display value of distance (cm) to zone3 - zone4 threshold.

  
  state = noOperation; // change back to noOperation so menu display is not repeated
}




//==================================================
//==================================================
//    E. Setup and Loop
//==================================================
//==================================================

void setup()
{
  // Initialize the LCD
  lcd.init();

  // Define custom characters
  byte custChar1[8] ={  B00000,
                        B01010,
                        B01010,
                        B00000,
                        B00100,
                        B10001,
                        B01110,
                        B00000 };
  
  byte custChar2[8] ={  B00000,
                        B01010,
                        B00000,
                        B01010,
                        B00000,
                        B01010,
                        B00000,
                        B01010 };
  
  byte custChar3[8] ={  B00000,
                        B10000,
                        B01000,
                        B00100,
                        B00010,
                        B00001,
                        B00000,
                        B00000 };
  
  byte custChar4[8] ={  B00000,
                        B00001,
                        B00010,
                        B00100,
                        B01000,
                        B10000,
                        B00000,
                        B00000 };

  lcd.createChar(0,custChar1);
  lcd.createChar(1,custChar2);
  lcd.createChar(2,custChar3);
  lcd.createChar(3,custChar4);


  // Turn on the backlight.
  lcd.backlight();

  // Clear the LCD
  lcd.clear();

  pinMode(TRIGGER, OUTPUT);
  pinMode(ECHO, INPUT);
  pinMode(SCALE, INPUT);
  pinMode(BUZZER, OUTPUT);
  pinMode(LED_RED, OUTPUT);
  pinMode(LED_YELLOW, OUTPUT);
  pinMode(LED_GREEN, OUTPUT);
  pinMode(LED_BLUE, OUTPUT);
  Serial.begin(9600);

  // Initial instruction: how to show the menu
  Serial.print("Enter '");
  Serial.print(menuKeys[idxShowMenu]);
  Serial.print("' to ");
  Serial.print(tasks[idxShowMenu]);
  Serial.println(".");
}

void loop()
{  
  // Read a command from the serial monitor
  char command = readCharSerial();
  if (command != noOperation) {
    state = command;
    lcd.clear();  // Clear the LCD
    allLEDsOff(); // turn off all LEDs
    buzzerOff();  // sound off
  }

  // Execute the selected command
  for (int i = 0; i < numTasks; i++) {
    if (state == menuKeys[i]) {
      operations[i]();
      break;
    }
  }
  
  delay(250); // wait 0.5 second before looping again.
}
