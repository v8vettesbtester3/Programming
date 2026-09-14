// Ex05
// Traffic light control

// Define pins to which buttons and lights are connected
int pinSwL = 13;      // left switch
int pinSwR = 3;       // right switch
int pinRedL = 12;     // left red LED
int pinYellowL = 11;  // left yellow LED
int pinGreenL = 10;   // left green LED
int pinRedR = 2;      // right red LED
int pinYellowR = 1;   // right yellow LED
int pinGreenR = 0;    // right green LED

int yellowBlinkTime = 500;  // 0.5 sec for y
bool trafficR2L = true;     // traffic starts running from Right to Left
int flowTime = 10000;       // amount of time (ms) to let traffic flow
int changeDelay = 2000;     // amount of time (ms) between color changes

void setup()
{
  // set up digital i/o pins
  pinMode(pinRedL, OUTPUT);   // LEDs are output
  pinMode(pinRedR, OUTPUT);
  pinMode(pinYellowL, OUTPUT);
  pinMode(pinYellowR, OUTPUT);
  pinMode(pinGreenL, OUTPUT);
  pinMode(pinGreenR, OUTPUT);
  pinMode(pinSwL, INPUT);     // switches are input
  pinMode(pinSwR, INPUT);
  
  // set initial LED states based on traffic running from Right to Left
  // L side: stop
  // R side: go
  digitalWrite(pinRedL, HIGH);
  digitalWrite(pinYellowL, LOW);
  digitalWrite(pinGreenL, LOW);
  digitalWrite(pinRedR, LOW);
  digitalWrite(pinYellowR, LOW);
  digitalWrite(pinGreenR, HIGH);
  
}


// Change the LEDs to allow traffic to move in other direction
void changeLights(int r0, int y0, int g0, int r1, int y1, int g1) {
  // r0, y0, g0 are the R, G, B LED pins on the side that is to be stopped.

  // r1, y1, g1 are the R, G, B LED pins on the side that is to start moving.

  // In this design, the yellow light blinks before the red light changes to green.
  
  delay(flowTime);	          // give time for traffic to flow

  // On side that is stopping.
  digitalWrite(g0, LOW);      // change lights from green to yellow
  digitalWrite(y0, HIGH);
  delay(changeDelay);
  digitalWrite(y0, LOW);
  digitalWrite(r0, HIGH);
  
  delay(changeDelay);         // pause with red lights on in both directions

  // On side that is starting to move
  digitalWrite(y1, HIGH);     // blink yellow light
  delay(yellowBlinkTime);
  for (int a = 0; a < 4; a++){	
    digitalWrite(y1, LOW);
    delay(yellowBlinkTime);
    digitalWrite(y1, HIGH);
    delay(yellowBlinkTime);
  }
  digitalWrite(y1, LOW);
  digitalWrite(r1, LOW);      // change lights from red to green
  digitalWrite(g1, HIGH);
}



void loop()
{
  if (digitalRead(pinSwR) == HIGH) {
    // Switch on the right is pressed.
    
    if (trafficR2L == false) {
      // Currently, traffic is moving from left to right

      // Change the lights
      changeLights(pinRedL,     // stop traffic from the left
                   pinYellowL,
                   pinGreenL,
                   pinRedR,     // start traffic from the right
                   pinYellowR,
                   pinGreenR);

      trafficR2L = true; // change traffic flow flag R -> L
    }
  }
    
  if (digitalRead(pinSwL) == HIGH) {
    if (trafficR2L == true) {
      // Currently, traffic is moving from right to left

      // Change the lights
      changeLights(pinRedR,     // stop traffic from the right
                   pinYellowR,
                   pinGreenR,
                   pinRedL,     // start traffic from the left
                   pinYellowL,
                   pinGreenL);
                   
      trafficR2L = false; // change traffic flow flag L -> R
    }
  }
}
