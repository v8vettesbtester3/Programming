// Ex03c
// Experiment with a switch: toggle on/off

#define LED 7
#define BUTTON 12

bool state = false; // false: LED off, true: LED on

void setup()
{
  pinMode(LED, OUTPUT);
  pinMode(BUTTON, INPUT);
  digitalWrite(LED, LOW);  // Turn off LED
}

void loop()
{
  if (digitalRead(BUTTON) == HIGH) {
    state = !state; // toggle: if on, turn off; if off, turn on
    if (state)
      digitalWrite(LED, HIGH);  // Turn on LED
    else
      digitalWrite(LED, LOW);	// Turn off LED
  }
  delay(100);
}
