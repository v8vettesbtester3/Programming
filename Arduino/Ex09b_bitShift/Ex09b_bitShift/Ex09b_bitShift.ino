// Bit shift
//
// define digital output pins
#define DATA 6    // SER
#define LATCH 8   // RCLK
#define CLOCK 10  // SRCLK
// define digital input pin
//#define PAUSE 4

void setup()
{
  pinMode(DATA, OUTPUT);
  pinMode(LATCH, OUTPUT);
  pinMode(CLOCK, OUTPUT);
//  pinMode(PAUSE, INPUT);
  Serial.begin(9600);

  digitalWrite(CLOCK, LOW); // SRCLK
  digitalWrite(DATA, LOW);  // SER
  digitalWrite(LATCH, LOW); // RCLK

//  digitalWrite(CLOCK, HIGH); // SRCLK
//  delay(50); // Wait for 50 millisecond(s)
//  digitalWrite(CLOCK, LOW); // SRCLK
//  digitalWrite(DATA, HIGH);  // SER
//  delay(50); // Wait for 50 millisecond(s)
//  digitalWrite(CLOCK, HIGH); // SRCLK
//  delay(50); // Wait for 50 millisecond(s)
//  digitalWrite(CLOCK, LOW); // SRCLK
//  digitalWrite(DATA, LOW);  // SER
    
 
  


}

void loop()
{
  int i;
//  int pause;
//  for (i = 0; i < 8; i++) {
//    while (pause = digitalRead(PAUSE) == 0) {
//      // stay here while switch is pressed
//      delay(100);
//    }
    
    // continue counting only if switch not pressed.
    //ground latchPin and hold low for as long as you are transmitting
//    digitalWrite(LATCH, LOW);
//
//    digitalWrite(DATA, 1);
//    
//    digitalWrite(LATCH, HIGH);

    

    // reference: 
    // https://www.arduino.cc/reference/tr/language/functions/advanced-io/shiftout/
    //shiftOut(DATA, CLOCK, MSBFIRST, i);

    //return the latch pin high to signal chip that it
    //no longer needs to listen for information
    //digitalWrite(LATCH, HIGH);
    
    //Serial.println(i);   
  digitalWrite(CLOCK, HIGH); // SRCLK
  delay(50); // Wait for 50 millisecond(s)
  digitalWrite(CLOCK, LOW); // SRCLK
  digitalWrite(DATA, HIGH);  // SER
  delay(50); // Wait for 50 millisecond(s)
  digitalWrite(CLOCK, HIGH); // SRCLK
  delay(50); // Wait for 50 millisecond(s)
  digitalWrite(CLOCK, LOW); // SRCLK
  digitalWrite(DATA, LOW);  // SER
    


    
    for (i = 0; i < 8; i++){
  digitalWrite(CLOCK, LOW); // SRCLK
   digitalWrite(LATCH, HIGH); // RCLK
    delay(100); // Wait for 100 millisecond(s)
  digitalWrite(CLOCK, HIGH); // SRCLK
   digitalWrite(LATCH, LOW); // RCLK
    delay(100); // Wait for 100 millisecond(s)
    }
  //}
}
