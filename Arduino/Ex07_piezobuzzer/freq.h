// frequencies in cycles per second (Hz)
// from https://en.wikipedia.org/wiki/Piano_key_frequencies
// Starts with C3, goes up
const int numF = 36;
const unsigned int frequency[numF] = {
//f	note	idx
131, // C3	0
139, // C#3	1
147, // D3	2
156, // D#3	3
165, // E3	4
175, // F3	5
185, // F#3	6
196, // G3	7
208, // G#3	8
220, // A3	9
233, // A#3	10
247, // B3	11
262, // C4 (middle C) 12
277, // C#4	13
294, // D4	14
311, // D#4	15
330, // E4	16
349, // F4	17
370, // F#4	18
392, // G4	19
415, // G#4	20
440, // A4	21
466, // A#4	22
494, // B4	23
523, // C5	24
554, // C#5	25
587, // D5	26
622, // D#5	27
659, // E5	28
698, // F5	29
740, // F#5	30
784, // G5	31
831, // G#5	32
880, // A5	33
932, // A#5	34
988, // B5	35
};
