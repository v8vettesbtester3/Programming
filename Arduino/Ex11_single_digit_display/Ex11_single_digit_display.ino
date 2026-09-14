// Single digit, 7-segment LED display
//
// define digital output pins
#define DATA 6
#define LATCH 8
#define CLOCK 10

// set up an array to draw only one output of the 595 low 
// at a time
byte singleBitLow[] = 
{255-1, 255-2, 255-4, 255-8, 
 255-16, 255-32, 255-64, 255-128};

byte A = 255-2;
byte B = 255-1;
byte C = 255-8;
byte D = 255-16;
byte E = 255-32;
byte F = 255-64;
byte G = 255-128;
byte DP= 255-4;

byte digit[16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};

void setup()
{
  pinMode(DATA, OUTPUT);  // set up the 74HC595 pins
  pinMode(LATCH, OUTPUT);
  pinMode(CLOCK, OUTPUT);
  Serial.begin(9600);

  digit[0] = A & B & C & D & E & F;      // 0
  digit[1] = B & C;                      // 1
  digit[2] = A & B & G & E & D;          // 2
  digit[3] = A & B & G & C & D;          // 3
  digit[4] = F & G & B & C;              // 4
  digit[5] = A & F & G & C & D;          // 5
  digit[6] = A & F & G & C & D & E;      // 6
  digit[7] = A & B & C;                  // 7
  digit[8] = A & B & C & D & E & F & G;  // 8
  digit[9] = A & B & C & D & F & G;      // 9
  digit[10] = A & B & C & E & F & G;     // A
  digit[11] = C & D & E & F & G;         // B
  digit[12] = A & D & E & F;             // C
  digit[13] = B & C & D & E & G;         // D
  digit[14] = A & D & E & F & G;         // E
  digit[15] = A & E & F & G;             // F
}

void loop()
{
  int i;
//  for (i = 0; i < 8; i++) {
//        //ground latchPin and hold low for as long as you are transmitting
//    digitalWrite(LATCH, LOW);
//
//    // reference: 
//    // https://www.arduino.cc/reference/tr/language/functions/advanced-io/shiftout/
//    shiftOut(DATA, CLOCK, MSBFIRST, singleBitLow[i]);
//
//    //return the latch pin high to signal chip that it
//    //no longer needs to listen for information
//    digitalWrite(LATCH, HIGH);
//
//    delay(2000);
//  }

  for (i = 0; i < 16; i++) {
        //ground latchPin and hold low for as long as you are transmitting
    digitalWrite(LATCH, LOW);

    // reference: 
    // https://www.arduino.cc/reference/tr/language/functions/advanced-io/shiftout/
    shiftOut(DATA, CLOCK, MSBFIRST, digit[i]);

    //return the latch pin high to signal chip that it
    //no longer needs to listen for information
    digitalWrite(LATCH, HIGH);

    delay(2000);
  }

  
}
