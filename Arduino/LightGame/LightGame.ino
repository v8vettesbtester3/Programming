// Light Game

const int btnSTART = 3; // This pin is associated with External Interrupt 1

const int pinRed = 13;
const int pinYellow = 12;
const int pinGreen = 11; 
const int pinBlue = 10;
const int pinBeep = 2;
int wins;
int losses;
int LED[] = {pinRed, pinYellow, pinGreen, pinBlue};
long selectedLED;
long testLED;
int pauseTime = 300;

volatile int bounceCount = 0;

void setup() {
  // setup the switch, buzzer and LEDs
  pinMode(btnSTART, INPUT);
  pinMode(LED[0], OUTPUT);
  pinMode(LED[1], OUTPUT);
  pinMode(LED[2], OUTPUT);
  pinMode(LED[3], OUTPUT);
  pinMode(pinBeep, OUTPUT);

  // Setup the switch monitor line
  attachInterrupt(1, bounce, RISING);
  
  // Turn off the LEDs
  digitalWrite(LED[0], HIGH);
  digitalWrite(LED[1], HIGH);
  digitalWrite(LED[2], HIGH);
  digitalWrite(LED[3], HIGH);
  
  wins = 0;
  losses = 0;

  // Start the Serial port
  Serial.begin(9600);
  
  Serial.println("Arduino Light Game");
  Serial.println();
}

// All the interrupt routine needs to do is increment bounceCount
void bounce() {
  bounceCount++;
}

void loop() {

  Serial.println("\n\nPress START button when ready");
  Serial.println();

  // Wait for the START button
  while (digitalRead(btnSTART)) {}

  // Then wait for it to be released
  delay(10);
  while (!digitalRead(btnSTART)) {}
  
  testLED = random(0,4);
  switch(testLED){
    case 0:
  	Serial.println("RED");
    break;
    case 1:
    Serial.println("YELLOW");
    break;
    case 2:
    Serial.println("GREEN");
    break;
    case 3:
    Serial.println("BLUE");
    break;
  }
  
  delay(pauseTime);

  // Start the testing
  bounceCount = 0;

  // Light the LED
  selectedLED = random(0,4);
  digitalWrite(LED[selectedLED], LOW);
  delay(pauseTime);
  while(selectedLED != testLED) {
  	digitalWrite(LED[selectedLED], HIGH);
    if (bounceCount > 0) {
      	// beep because wrong light
		tone(pinBeep, 440, 500);
    	losses++;
    	Serial.println("Wrong color");
  		bounceCount = 0;
    }
  	selectedLED = random(0,4);
  	digitalWrite(LED[selectedLED], LOW);
    delay(pauseTime);
  }
  
  if (bounceCount == 0) {
    // beep
    tone(pinBeep, 440, 500);
    losses++;
    Serial.println("Be faster");
  }
  else {
    // light all LEDs
  	digitalWrite(LED[0], LOW);
  	digitalWrite(LED[1], LOW);
  	digitalWrite(LED[2], LOW);
  	digitalWrite(LED[3], LOW);
    delay(2000);
    wins++;
    Serial.println("Got it");
  }
  digitalWrite(LED[0], HIGH);
  digitalWrite(LED[1], HIGH);
  digitalWrite(LED[2], HIGH);
  digitalWrite(LED[3], HIGH);
  Serial.print("Wins/Losses: ");
  Serial.print(wins);
  Serial.print("/");
  Serial.println(losses);
  
}
