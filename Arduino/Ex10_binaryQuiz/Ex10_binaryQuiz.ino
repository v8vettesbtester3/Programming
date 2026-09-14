// LED binary number quiz
//
// define digital output pins
#define DATA 6
#define LATCH 8
#define CLOCK 10

int number = 0; // value displayed on LEDs
int answer = 0; // value entered by player

void displayNumber(byte a) {
  // sends a byte to be displayed on the LEDs
    //ground latchPin and hold low for as long as you are transmitting
    digitalWrite(LATCH, LOW);

    // reference: 
    // https://www.arduino.cc/reference/tr/language/functions/advanced-io/shiftout/
    shiftOut(DATA, CLOCK, MSBFIRST, a);

    //return the latch pin high to signal chip that it
    //no longer needs to listen for information
    digitalWrite(LATCH, HIGH);  
}


void getAnswer() {
  // receive answer from the player
  int z = 0;
  Serial.flush();
  while (Serial.available() == 0) {
    // do nothing until something comes into the serial buffer
  }

  // one character of serial data is available, begin calculating
  while (Serial.available() > 0) {
    z = Serial.read();
    if (z == 10) break; // if it is newline, you're done. 
    // move any previous digit to the next column on the left
    // e.g. 1 becomes 10, while there is data in the buffer
    answer *= 10;
    // read the next number in the buffer and subtract the character '0'
    // from it to convert it to the actual integer number.
    z = z - '0';
    // add this digit into the accumulating value
    answer += z;
    // allow a short delay for any more numbers to come into Serial.available()
    delay(5);
  }
  Serial.print("You entered: ");
  Serial.println(answer);
}


void checkAnswer() {
  // check the answer from the player and show the results
  if (answer == number) { // correct
    Serial.print("Correct! ");
  }
  else {  // not correct
    Serial.print("Incorrect, ");
  }
  Serial.print(answer,BIN);
  Serial.print(" equals ");
  Serial.println(number);
  Serial.println();
  answer = 0;
  delay(10000); // time to view the results
}


void setup()
{
  pinMode(DATA, OUTPUT);  // set up the 74HC595 pins
  pinMode(LATCH, OUTPUT);
  pinMode(CLOCK, OUTPUT);
  Serial.begin(9600);
  randomSeed(analogRead(0));  // initialize the random number generator
  displayNumber(0); // clear the LEDs
}

void loop()
{
  number = random(256);   // random integer in the range [0,255]
  displayNumber(number);
  Serial.println("What is the binary number in base 10? ");
  getAnswer();
  checkAnswer();
}
