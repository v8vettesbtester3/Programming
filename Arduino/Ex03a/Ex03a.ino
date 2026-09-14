// Ex03a
// Experiment with a switch

#define LED 7
#define BUTTON 12

void setup()
{
  pinMode(LED, OUTPUT);
  pinMode(BUTTON, INPUT);
}

void loop()
{
  if (digitalRead(BUTTON) == HIGH) {
  digitalWrite(LED, HIGH);  // Turn on LED
  delay(2000); // Wait for 2000 milliseconds
  digitalWrite(LED, LOW);	// Turn off LED
  }
}
