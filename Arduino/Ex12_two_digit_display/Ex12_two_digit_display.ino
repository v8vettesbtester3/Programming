// Single digit, 7-segment LED display
//
// define digital output pins
#define DATA 6
#define LATCH 8
#define CLOCK 10
// define digital input pin
#define PAUSE 4

// Specify whether base 10 or base 16 counting
//#define BASE 10
#define BASE 16


byte A = 255-2;
byte B = 255-1;
byte C = 255-8;
byte D = 255-16;
byte E = 255-32;
byte F = 255-64;
byte G = 255-128;
byte DP = 255-4;

byte digits[16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};

void setup()
{
  pinMode(DATA, OUTPUT);  // set up the 74HC595 pins
  pinMode(LATCH, OUTPUT);
  pinMode(CLOCK, OUTPUT);
  pinMode(PAUSE, INPUT);
  Serial.begin(9600);

  digits[0] = A & B & C & D & E & F;      // 0
  digits[1] = B & C;                      // 1
  digits[2] = A & B & G & E & D;          // 2
  digits[3] = A & B & G & C & D;          // 3
  digits[4] = F & G & B & C;              // 4
  digits[5] = A & F & G & C & D;          // 5
  digits[6] = A & F & G & C & D & E;      // 6
  digits[7] = A & B & C;                  // 7
  digits[8] = A & B & C & D & E & F & G;  // 8
  digits[9] = A & B & C & D & F & G;      // 9
  digits[10] = A & B & C & E & F & G;      // A
  digits[11] = C & D & E & F & G;          // B
  digits[12] = A & D & E & F;              // C
  digits[13] = B & C & D & E & G;          // D
  digits[14] = A & D & E & F & G;          // E
  digits[15] = A & E & F & G;              // F
}

void loop()
{
  int i,j,k,pause;

  for (k = 0; k < BASE*BASE; k++) {
    
    Serial.println(k);
    
    //ground latchPin and hold low for as long as you are transmitting
    digitalWrite(LATCH, LOW);

    j = k / BASE;	// tens or 16s
    i = k % BASE;	// units

    shiftOut(DATA, CLOCK, MSBFIRST, digits[j]);
    shiftOut(DATA, CLOCK, MSBFIRST, digits[i]);

    //return the latch pin high to signal chip that it
    //no longer needs to listen for information
    digitalWrite(LATCH, HIGH);

    delay(250);
    
    while (pause = digitalRead(PAUSE) == 0) {
      // stay here while switch is pressed
      delay(100);
    }
  }

  
}
