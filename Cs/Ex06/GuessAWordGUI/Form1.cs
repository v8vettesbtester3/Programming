using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuessAWordGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string originalWord;
        string selectedWord;
        string guessedWord = "";
        string guess;
        char letter;
        int pos;
        char tempChar;
        int foundCount = 0;
        bool letterInWord;
        private void SelectButton_Click(object sender, EventArgs e)
        {
            string[] words = { "apricot", "elephant", "tigress", "fortunate", "impossible", "historical", "colorful", "science" };
            Random RandomClass = new Random();
            int randomNumber;
            randomNumber = RandomClass.Next(0, words.Length);
            selectedWord = words[randomNumber];
            originalWord = selectedWord;
            for (int a = 0; a < selectedWord.Length; ++a)
                guessedWord = guessedWord + "*";
            outLabel.Text = String.Format("Word: {0}", guessedWord);
                outLabel.Text += "\nGuess a letter >> ";
            submitButton.Visible = true;
            guessBox.Visible = true;
            selectButton.Visible = false;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            letter = Convert.ToChar(guessBox.Text.Substring(0, 1));
            guessBox.Text = "";
            letterInWord = false;
            for (pos = 0; pos < selectedWord.Length; ++pos)
            {
                tempChar = Convert.ToChar(selectedWord.Substring(pos, 1));
                if (tempChar == letter)
                {
                    guessedWord = guessedWord.Substring(0, pos) + letter + guessedWord.Substring(pos + 1, (guessedWord.Length - 1 - pos));
                    selectedWord = selectedWord.Substring(0, pos) + '?' + selectedWord.Substring(pos + 1, (guessedWord.Length - 1 - pos)); 
                    ++foundCount;
                    letterInWord = true;
                }
            }
            if (letterInWord)
                  outLabel2.Text = String.Format("Yes! {0} is in the word", letter);
            else
                 outLabel2.Text = String.Format("Sorry. {0} is not in the word", letter);
            outLabel.Text = String.Format("Word: {0}", guessedWord);
            outLabel.Text += "\nGuess a letter >> ";
            if (foundCount == selectedWord.Length)
            {
                outLabel3.Text = String.Format("Good job! Word was {0}", originalWord);
                outLabel.Visible = false;
                submitButton.Visible = false;
                guessBox.Visible = false;
            }
        }
    }
}
