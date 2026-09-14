// LED binary number display
//
// define digital output pins
#define DATA 6
#define LATCH 8
#define CLOCK 10
// define digital input pin
#define PAUSE 4

void setup()
{
  pinMode(DATA, OUTPUT);
  pinMode(LATCH, OUTPUT);
  pinMode(CLOCK, OUTPUT);
  pinMode(PAUSE, INPUT);
  Serial.begin(9600);
}

void loop()
{
  int i;
  int pause;
  for (i = 0; i < 256; i++) {
    while (pause = digitalRead(PAUSE) == 0) {
      // stay here while switch is pressed
      delay(100);
    }
    
    // continue counting only if switch not pressed.
    //ground latchPin and hold low for as long as you are transmitting
    digitalWrite(LATCH, LOW);

    // reference: 
    // https://www.arduino.cc/reference/tr/language/functions/advanced-io/shiftout/
    shiftOut(DATA, CLOCK, MSBFIRST, i);

    //return the latch pin high to signal chip that it
    //no longer needs to listen for information
    digitalWrite(LATCH, HIGH);
    
    Serial.println(i);   
    delay(100); // Wait for 100 millisecond(s)
  }
}
