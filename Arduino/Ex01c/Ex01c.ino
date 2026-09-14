// Ex01c: Blinking LED wave, adjustable dwell, using for-loops

int dwellTime = 100;

void setup() {
  // put your setup code here, to run once:
  pinMode(2, OUTPUT);
  pinMode(3, OUTPUT);
  pinMode(4, OUTPUT);
  pinMode(5, OUTPUT);
  pinMode(6, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  for (int p = 2; p < 7; ++p){
    digitalWrite(p, HIGH);
    delay(dwellTime);
    digitalWrite(p, LOW);
  }

  for (int p = 5; p > 2; --p) {
    digitalWrite(p, HIGH);
    delay(dwellTime);
    digitalWrite(p, LOW);
  }
}
