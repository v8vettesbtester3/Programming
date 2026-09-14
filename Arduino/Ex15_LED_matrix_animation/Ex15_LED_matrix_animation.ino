// Ex15 LED matrix animation
//
// define digital output pins
#define DATA 6
#define LATCH 8
#define CLOCK 10

short binary[] = {1, 2, 4, 8, 16, 32, 64, 128};

short img1[8][8] = {        // both eyes closed
  {0, 0, 0, 1, 1, 0, 0, 0},
  {0, 0, 1, 1, 1, 1, 0, 0},
  {0, 1, 0, 0, 0, 0, 1, 0},
  {1, 0, 0, 1, 1, 0, 0, 1},
  {1, 1, 1, 0, 0, 1, 1, 1},
  {1, 0, 0, 0, 0, 0, 0, 1},
  {0, 1, 1, 1, 1, 1, 1, 0},
  {1, 0, 0, 0, 0, 0, 0, 1}
};

short img2[8][8] = {        // right eye open
  {0, 0, 0, 1, 1, 0, 0, 0},
  {0, 0, 1, 1, 1, 1, 0, 0},
  {0, 1, 0, 0, 0, 0, 1, 0},
  {1, 0, 0, 1, 1, 1, 1, 1},
  {1, 1, 1, 0, 0, 1, 1, 1},
  {1, 0, 0, 0, 0, 1, 1, 1},
  {0, 1, 1, 1, 1, 1, 1, 0},
  {1, 0, 0, 0, 0, 0, 0, 1}
};

short img3[8][8] = {        // both eyes open
  {0, 0, 0, 1, 1, 0, 0, 0},
  {0, 0, 1, 1, 1, 1, 0, 0},
  {0, 1, 0, 0, 0, 0, 1, 0},
  {1, 1, 1, 1, 1, 1, 1, 1},
  {1, 1, 1, 0, 0, 1, 1, 1},
  {1, 1, 1, 0, 0, 1, 1, 1},
  {0, 1, 1, 1, 1, 1, 1, 0},
  {1, 0, 0, 0, 0, 0, 0, 1}
};

short img4[8][8] = {        // left eye open
  {0, 0, 0, 1, 1, 0, 0, 0},
  {0, 0, 1, 1, 1, 1, 0, 0},
  {0, 1, 0, 0, 0, 0, 1, 0},
  {1, 1, 1, 1, 1, 0, 0, 1},
  {1, 1, 1, 0, 0, 1, 1, 1},
  {1, 1, 1, 0, 0, 0, 0, 1},
  {0, 1, 1, 1, 1, 1, 1, 0},
  {1, 0, 0, 0, 0, 0, 0, 1}
};


int getInput() {
  // Get an integer input from the user
  int value = 0; // value entered by user
  int z = 0; // digit
  Serial.flush();
  while (Serial.available() == 0) {
    // Do nothing until something comes into the serial buffer.
  }

  // one character of serial data is available, begin calculating
  while (Serial.available() > 0) {
    z = Serial.read();
    if (z == 10) break; // if it is newline, you're done.
    // move any previous digit to the next column on the left
    // e.g. 1 becomes 10, while there is data in the buffer
    value *= 10;
    // read the next number in the buffer and subtract the character '0'
    // from it to convert it to the actual integer number.
    z = z - '0';
    // add this digit into the accumulating value
    value += z;
    // allow a short delay for any more numbers to come into Serial.available()
    delay(5);
  }

  return value;
}

void setup()
{
  pinMode(DATA, OUTPUT);  // set up the 74HC595 pins
  pinMode(LATCH, OUTPUT);
  pinMode(CLOCK, OUTPUT);
  Serial.begin(9600);
}

void loop()
{
  int sel = 0;
  while (sel < 1 || sel > 3) {
    Serial.println("Enter:\n1 for single LED\n2 for X\n3 for image");
    sel = getInput();
  }

  Serial.print("Selected number ");
  Serial.println(sel);

  int row = 0;
  int col = 0;
  int i, j;
  int idxY;
  int idxX;
  int dirY;  // +1: move up, -1: move down
  int dirX;  // +1: move right, -1: move left
  int shift;
  int cyc;


  switch (sel) {

    //------------------------------------------------------------
    case 1:
      row = 0;
      while (row < 1 || row > 8) {
        Serial.println("Enter the row number (1-8): ");
        row = getInput();
      }

      col = 0;
      while (col < 1 || col > 8) {
        Serial.println("Enter the column number (1-8): ");
        col = getInput();
      }

      idxY = row - 1;
      idxX = col - 1;
      dirY = 1;  // +1: move up, -1: move down
      dirX = 1;  // +1: move right, -1: move left

      for (cyc = 0; cyc < 100; cyc++) {


        //ground latchPin and hold low for as long as you are transmitting
        digitalWrite(LATCH, LOW);

        shiftOut(DATA, CLOCK, MSBFIRST, binary[idxY]); // row
        shiftOut(DATA, CLOCK, MSBFIRST, ~binary[idxX]); // column

        //return the latch pin high to signal chip that it
        //no longer needs to listen for information
        digitalWrite(LATCH, HIGH);

        delay(100);

        // row, col indices for next step
        // bounce off edges
        if (idxX >= 7) dirX = -1;
        if (idxX <= 0) dirX = +1;
        if (idxY >= 7) dirY = -1;
        if (idxY <= 0) dirY = +1;

        idxX += dirX;
        idxY += dirY;

      }
      break;

    //------------------------------------------------------------

    case 2:

      for (j = 0; j < 800; j++) {
        shift = (j / 8) % 8;

        // SW - NE line
        for (i = 0; i < 8; i++) {
          //ground latchPin and hold low for as long as you are transmitting
          digitalWrite(LATCH, LOW);

          shiftOut(DATA, CLOCK, MSBFIRST, binary[i]); // rows
          shiftOut(DATA, CLOCK, MSBFIRST, ~binary[i] >> shift); // columns

          //return the latch pin high to signal chip that it
          //no longer needs to listen for information
          digitalWrite(LATCH, HIGH);

          delay(1);
        }

        // NW - SE line
        for (i = 0; i < 8; i++) {
          //ground latchPin and hold low for as long as you are transmitting
          digitalWrite(LATCH, LOW);

          shiftOut(DATA, CLOCK, MSBFIRST, binary[7 - i]); // rows
          shiftOut(DATA, CLOCK, MSBFIRST, ~binary[i] >> shift); // columns

          //return the latch pin high to signal chip that it
          //no longer needs to listen for information
          digitalWrite(LATCH, HIGH);

          delay(1);
        }
      }

      break;


    //------------------------------------------------------------
    case 3:
      for (j = 0; j < 1500; j++) {
        cyc = (j / 300) % 4;
        for (row = 0; row < 8; row++) {
          for (col = 0; col < 8; col++) {
            if ((img1[row][col] == 1 && cyc == 0) ||  // both eyes closed
                (img2[row][col] == 1 && cyc == 1) ||  // right eye open
                (img3[row][col] == 1 && cyc == 2) ||  // both eyes open
                (img4[row][col] == 1 && cyc == 3))    // left eye open
            {
              digitalWrite(LATCH, LOW);
              shiftOut(DATA, CLOCK, MSBFIRST, binary[row]); // row
              shiftOut(DATA, CLOCK, MSBFIRST, ~binary[col]); // column
              digitalWrite(LATCH, HIGH);
            }
          }
        }
      }

      break;

    //------------------------------------------------------------

    default:
      break;


  }


}
