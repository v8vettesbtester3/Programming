// Ex 07 Piezo Buzzer
//
#include "freq.h"
#include "dur.h"
#include "song.h"

const int speedAPin = 0;  // analog pin
const int pitchAPin = 1;  // analog pin
const int piezoDPin = 11; // digital pin

void setup()
{
  pinMode(piezoDPin, OUTPUT);
  Serial.begin(9600);
}

void loop()
{
  // Loop over all of the notes of the song.
  for (int i = 0; i < numNotes; i++){

    // Adjust pitch using a frequency multiplier p
    int w = analogRead(pitchAPin);  // pitch adjustment
    float p = max(0.1, w / 63.0); // minimum value of p is 0.1

    // Adjust speed by dividing duration by a factor s
    int v = analogRead(speedAPin);  // speed adjustment
    float s = max(0.25,v / 50.0); // minimum value of s is 0.25

    // Display control factors
    Serial.print("Pitch: ");
    Serial.print(p);
    Serial.print("    Speed: ");
    Serial.println(s);


    // Play the note
    // if p == 1, then the song plays at normal pitch
    // if 0.1 <= p < 1, then the song plays at lower pitch
    // if p > 1, then the song plays at higher pitch
    tone(piezoDPin, p*frequency[f[i]]);

    // Continue playing for specified duration
    // if s == 1, the song plays at normal speed
    // if 0.25 <= s < 1, the song plays slower
    // if s > 1, the song play faster
    delay(duration[d[i]]/s);

    // Stop playing the note
    noTone(piezoDPin);

    // Wait a bit to start the next note
    delay(100/s);
  }

  // Wait a second before replaying the song
  delay(1000);
}
