// Ex 6
// Battery tester


//-----------------------------------------------
// Global constants and variables

// pin selection for LED control
const int goodBatteryLED = 2;	// green
const int fairBatteryLED = 4;	// yellow
const int poorBatteryLED = 6;	// red


int ledDelay = 1000; // delay (ms) between analog voltage readings


// Voltage reading samples for running average
const int numSamples = 50;  // number of readings in running avg
int a[numSamples];          // array of readings
int idx = 0;                // index to array for next reading


// Calibration terms
// Derived from least-squares fit
float A = 4.61088516e-09;
float B = -5.58831626e-06;
float C = 6.22984983e-03;
float D = 2.22709662e-01;


//-----------------------------------------------
void setup () {
  pinMode(goodBatteryLED, OUTPUT);
  pinMode(fairBatteryLED, OUTPUT);
  pinMode(poorBatteryLED, OUTPUT);
  Serial.begin(9600);
  for (int i = 0; i < numSamples; i++)
  {
    a[i] = 0;
  }
}


//-----------------------------------------------
// Calculate the mean value of the array a
unsigned int meanValA() {
  unsigned int avg = 0; // maximum value = 2**16-1 = 65535
  for (int i = 0; i < numSamples; i++)
  {
    avg = avg + a[i];
  }
  avg = avg / numSamples;
  return avg;
}


//-----------------------------------------------
void loop() {
  int x = analogRead(0);  // read the voltage
  a[idx] = x;             // store reading in array
  ++idx %= numSamples;    // increment index, modulo number of samples

  // Calculate voltage, using fit curve
  float voltage = ((A * x + B) * x + C) * x + D;


  Serial.print(x);          // display the analog reading
  Serial.print("  ");
  Serial.print(meanValA()); // display the average reading
  Serial.print("  ");
  Serial.println(voltage);  // display the voltage

  if (voltage >= 3.0) {
    // Good battery
    digitalWrite(goodBatteryLED, HIGH);
    delay(ledDelay);
    digitalWrite(goodBatteryLED, LOW);
  }
  else if (voltage < 3.0 && voltage >= 1.5) {
    // Fair battery
    digitalWrite(fairBatteryLED, HIGH);
    delay(ledDelay);
    digitalWrite(fairBatteryLED, LOW);
  }
  else if (voltage < 1.5 && voltage > 0) {
    // Old battery
    digitalWrite(poorBatteryLED, HIGH);
    delay(ledDelay);
    digitalWrite(poorBatteryLED, LOW);
  }
}
