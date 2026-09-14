// Ex02a
// Experiment with PWM

int d = 500;                  // Delay between loop cycles
const int NUM_LEDS = 5;       // Number of LEDs
int pin[] = {3, 5, 6, 9, 10}; // Define which PWM pins will be used.
double alpha = -1;            // Intensity value to LEDs
double da = 32.0;             // Increment in intensity per loop
char receivedChar;            // Character received from the serial input

void setup() {
  for (int i = 0; i < NUM_LEDS; i++){
    pinMode(pin[i], OUTPUT);  // set the pin to be output
  }
  
  Serial.begin(9600);         // start the serial monitor/plotter
}

void loop() {

    for (int i = 0; i < NUM_LEDS; i++){
      // The value written to the output is alpha, 
      // subject to hard limits of 0, 255.
      int a = max(min((int)alpha,255),0);

      // Display the signal sent to the first LED
      if (i == 0)  Serial.println(a);

      // Write the value as "analog" to the pin.
      // Small value of "a" (near 0) corresponds to small PWM duty cycle
      // Large value of "a" (near 255) corresponds to large PWM duty cycle
      analogWrite(pin[i], a);
    }
    
    
    delay(d);                 // Delay before looping


  // Optionally, modify the intensity
  if (Serial.available() > 0) {

    receivedChar = Serial.read();

    // Change the intensity
    if (receivedChar == '+') {
      alpha += da;
      // After passing 255, cycle back to low intensity
      if (alpha > 255) alpha = -1;  
    }
    else if (receivedChar == '-') {
      alpha -= da;
      // After passing 0, cycle back to high intensity
      if (alpha < 0) alpha = 255;  
    }
  }
}
