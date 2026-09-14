#define btnSTART 2 
#define swHIT 3       // This pin is associated with External Interrupt 1
#define ledTrigger 4

volatile int bounceCount = 0;

void setup() {
  // setup the switches and LED
  pinMode(btnSTART, INPUT_PULLUP);
  pinMode(swHIT, INPUT);
  pinMode(ledTrigger, OUTPUT);

  // If you don't use pin 3, you will need to change the 1 below to the new interrupt number
  attachInterrupt(1, bounce, RISING);
  // By using RISING, we capture everytime the pin transisions from LOW to HIGH
  
  // Turn off the LED
  digitalWrite(ledTrigger, HIGH);

  // Start the Serial port
  Serial.begin(9600);
  
  Serial.println("Arduino Switch Debounce");
  Serial.println();
}

// All the interrupt routine needs to do is increment bounceCount
// By keeping this routine small we maximize the chances of catching every bounce
void bounce() {
  bounceCount++;
}

void loop() {

  Serial.println("Press START button when ready");
  Serial.println("When the LED lights, the test is ready.");
  Serial.println();

  // Wait for the START button
  while (digitalRead(btnSTART)) {}

  // Then wait for it to be released
  delay(10);
  while (!digitalRead(btnSTART)) {}
  delay(1000);

  // Start the testing
  bounceCount = 0;

  // Light the LED
  digitalWrite(ledTrigger, LOW);
  Serial.println("Ready for testing...");

  // Wait for the switch to close
  while (bounceCount == 0) {}

  // If you are here, the switch was thrown
  // Wait a second to collect the bounces

  delay(1000);

  // Output the results

  digitalWrite(ledTrigger, HIGH);
  Serial.print("The switch bounced ");
  Serial.print(bounceCount-1);
  Serial.println(" times.");
  Serial.println();
}
