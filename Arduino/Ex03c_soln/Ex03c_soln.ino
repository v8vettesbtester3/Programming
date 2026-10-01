// Ex03c
// Experiment with a switch: toggle on/off
// solution is to stop blinking

#define LED 7
#define BUTTON 12

bool state = false; // false: LED off, true: LED on
bool switched = false;

void setup()
{
  pinMode(LED, OUTPUT);
  pinMode(BUTTON, INPUT);
  digitalWrite(LED, LOW);  // Turn off LED
  Serial.begin(9600);
}

void loop()
{
  if (digitalRead(BUTTON) == HIGH && !switched) {
    Serial.print(switched);
    switched = true;
    state = !state; // toggle: if on, turn off; if off, turn on
    Serial.println("  Switching");    
    if (state)
      digitalWrite(LED, HIGH);  // Turn on LED
    else
      digitalWrite(LED, LOW);	// Turn off LED
  }
  else if (digitalRead(BUTTON) == LOW && switched)
  {
    Serial.print(switched);
    Serial.println("  Resetting flag");
    switched = false;
  }
  else
  {
    // no operation
  }
}
