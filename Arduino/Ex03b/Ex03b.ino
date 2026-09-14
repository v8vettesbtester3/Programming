// Ex03b
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
  }
  else {
    digitalWrite(LED, LOW);	// Turn off LED
  }
}
