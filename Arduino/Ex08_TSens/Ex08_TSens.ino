//// Quick-read temperature measurement
//
struct T_range {
  int pin;	// output pin for temperature range
  float T_F; // temperature (F) at upper limit of range
};
T_range range0 = {2, 50.0};		// T <= 50F, blue LED on
T_range range1 = {3, 80.0};		// 50 < T <= 80, green LED on
T_range range2 = {4, 120.0};	// 80 < T <= 120, yellow LED on
const int pinHot = 5;			    // 120 < T, red LED on


void setup()
{
  pinMode(range0.pin, OUTPUT);
  pinMode(range1.pin, OUTPUT);
  pinMode(range2.pin, OUTPUT);
  pinMode(pinHot, OUTPUT);
  Serial.begin(9600);
}

void loop()
{
  // Read the temperature sensor and convert to deg F
  float sensor = analogRead(0); 
  float voltage = (sensor*5000)/1024; // convert raw sensor val to mV
  voltage = voltage - 500;	          // remove offset
  float degC = voltage / 10.0;        // convert mV to deg C
  float degF = 1.8 * degC + 32;       // convert to deg F
  Serial.println(degF);               // display T in deg F
  
  // Light LEDs according to temperature degF
  if (degF <= range0.T_F) {
    digitalWrite(range0.pin, HIGH);
    delay(1000);
    digitalWrite(range0.pin, LOW);
  }
  else if (range0.T_F < degF && degF <= range1.T_F) {
    digitalWrite(range1.pin, HIGH);
    delay(1000);
    digitalWrite(range1.pin, LOW);
  }
  else if (range1.T_F < degF && degF <= range2.T_F) {
    digitalWrite(range2.pin, HIGH);
    delay(1000);
    digitalWrite(range2.pin, LOW);
  }
  else {
    digitalWrite(pinHot, HIGH);
    delay(1000);
    digitalWrite(pinHot, LOW);
  }
}
