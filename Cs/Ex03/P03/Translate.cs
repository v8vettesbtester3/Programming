using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace P03
{
    // Translate a number from one base to another
    internal class Translate
    {
        static public string Bin2Dec(string inputVal)
        {
            // Convert input string (binary rep of number)
            // to return string (decimal rep of number)
            string retVal = "";

            string bitString = inputVal;
            int val = 0;
            int exp = bitString.Length - 1;
            for (int i = 0; i < bitString.Length; i++)
            {
                int digit = Convert.ToInt32(bitString.Substring(i, 1));
                val += digit * (int)Math.Pow(2, exp);
                exp--;
            }
            retVal = val.ToString();

            return retVal;
        }

        static public string Dec2Bin(string inputVal)
        {
            // Convert input string (decimal rep of number)
            // to return string (binary rep of number)
            string retVal = "";

            if (inputVal == "0")
            {
                retVal = inputVal;
            }
            else
            {
                int inputInt = Convert.ToInt32(inputVal);
                while (inputInt > 0)
                {
                    int remainder = inputInt % 2;
                    inputInt = inputInt / 2;
                    retVal = remainder.ToString() + retVal;
                }
            }

            return retVal;
        }

        static public string Dec2Hex(string inputVal)
        {
            // Convert input string (decimal rep of number)
            // to return string (hexadecimal rep of number)
            string retVal = "";

            if (inputVal == "0")
            {
                retVal = inputVal;
            }
            else
            {
                int inputInt = Convert.ToInt32(inputVal);
                while (inputInt > 0)
                {
                    int remainder = inputInt % 16;
                    inputInt = inputInt / 16;
                    retVal = Dec2HexDigit(remainder) + retVal;
                }
            }

            return retVal;
        }

        static public string Hex2Dec(string inputVal)
        {
            // Convert input string (hexadecimal rep of number)
            // to return string (decimal rep of number)
            string retVal = "";

            string hexString = inputVal;
            int val = 0;
            int exp = hexString.Length - 1;
            for (int i = 0; i < hexString.Length; i++)
            {
                int digit = HexDigit2Dec(hexString.Substring(i, 1));
                val += digit * (int)Math.Pow(16, exp);
                exp--;
            }
            retVal = val.ToString();

            return retVal;
        }

        static public string Bin2Hex(string inputVal)
        {
            // Convert input string (binary rep of number)
            // to return string (hexadecimal rep of number)
            string retVal = "";

            string decString = Bin2Dec(inputVal);
            string hexString = Dec2Hex(decString);

            retVal = hexString;

            return retVal;
        }

        static public string Hex2Bin(string inputVal)
        {
            // Convert input string (hexadecimal rep of number)
            // to return string (binary rep of number)
            string retVal = "";

            string decString = Hex2Dec(inputVal);
            string binString = Dec2Bin(decString);

            retVal = binString;

            return retVal;
        }

        private static string Dec2HexDigit(int decVal)
        {
            // valid inputs: [0-15]
            // returns corresponding hexadecimal digit
            string retVal = "";
            if (decVal >= 0 && decVal < 10)
            {
                retVal = decVal.ToString();
            }
            else if (decVal == 10) retVal = "A";
            else if (decVal == 11) retVal = "B";
            else if (decVal == 12) retVal = "C";
            else if (decVal == 13) retVal = "D";
            else if (decVal == 14) retVal = "E";
            else if (decVal == 15) retVal = "F";
            return retVal;
        }

        private static int HexDigit2Dec(string hexDigit)
        {
            // valid inputs [0-9, A-F]
            // returns corresponding decimal value
            int retVal = 0;
            if (hexDigit == "0") retVal = 0;
            else if (hexDigit == "1") retVal = 1;
            else if (hexDigit == "2") retVal = 2;
            else if (hexDigit == "3") retVal = 3;
            else if (hexDigit == "4") retVal = 4;
            else if (hexDigit == "5") retVal = 5;
            else if (hexDigit == "6") retVal = 6;
            else if (hexDigit == "7") retVal = 7;
            else if (hexDigit == "8") retVal = 8;
            else if (hexDigit == "9") retVal = 9;
            else if (hexDigit == "A") retVal = 10;
            else if (hexDigit == "B") retVal = 11;
            else if (hexDigit == "C") retVal = 12;
            else if (hexDigit == "D") retVal = 13;
            else if (hexDigit == "E") retVal = 14;
            else if (hexDigit == "F") retVal = 15;
            return retVal;
        }

    }
}
