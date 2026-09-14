// note durations

const unsigned long quarter_note = 500; // ms per quarter note

const int numDur = 8;
const unsigned long duration[numDur] = {
	// duration				        note		            idx
	quarter_note / 4,	    // sixteenth note	      0
	quarter_note / 2, 	  // eighth note		      1
	3 * quarter_note / 4,	// dotted eighth note	  2
	quarter_note, 		    // quarter note		      3
	3 * quarter_note / 2,	// dotted quarter note  4
	quarter_note * 2,	    // half note		        5
	3 * quarter_note,	    // dotted half note	    6
	quarter_note * 4,	    // whole note		        7
};
