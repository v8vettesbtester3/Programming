// Ex02b
// Experiment with PWM

int d = 2;                    // delay between changes in intensity
const int NUM_LEDS = 5;       // number of LEDs
int pin[] = {3, 5, 6, 9, 10}; // Define which PWM pins will be used.
double sharpness = 10.0;      // Wave sharpness
double offset[NUM_LEDS];      // Phase offset for each LED
double skew = 1;              // Phase skew: try 1, -1, 0, 2.5
double spd = 2.0;             // Wave speed
double alpha = 0.0;           // phase angle
double da = spd * 2 * PI / 360.0;  // increment in phase angle per cycle.

void setup() {
  for (int i = 0; i < NUM_LEDS; i++){
    pinMode(pin[i], OUTPUT);  // set the pin to be output
    offset[i] = skew * i * 2 * PI / NUM_LEDS;
  }
  
  Serial.begin(9600);         // start the serial monitor/plotter
}

void loop() {
  
    for (int i = 0; i < NUM_LEDS; i++){

      // A periodic function with phase offset between LEDs
      // Gives the appearance of traveling waves for most values of skew.
      int a = (int)(255 * pow(0.5*(sin(alpha + offset[i]) + 1),sharpness));
      
      // Display the signal sent to the first LED
      if (i == 0)  Serial.println(a);
      
      // Write the value as "analog" to the pin.
      // Small value of "a" (near 0) corresponds to small PWM duty cycle
      // Large value of "a" (near 255) corresponds to large PWM duty cycle
      analogWrite(pin[i], a);
    }
    
    
    delay(d);       // Delay before looping


    alpha += da;    // Change the intensity
}
