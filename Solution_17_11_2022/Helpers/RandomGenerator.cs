using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_16_11_2022.Helpers
{
    internal class RandomGenerator
    {
        private static Random _random = new Random();

        public static int GenerateInteger(int maxValue)
        {
            return _random.Next(maxValue);
        }

        public static double GenerateDouble(int maxValue)
        {
            return _random.NextDouble() * maxValue;
        }

        public static string GenerateString(int noOfCharacters, bool isLetterAndDigit = false)
        {
            string result = "";
            for (int i = 0; i < noOfCharacters; i++)
            {
                // english characters, upper and lower
                // numbers 0 - 9

                // Step 1a. Find english upper letters min = 65, max = 90 
                // Step 1b. Find english lower letters min = 97, max = 122
                // Step 1c. Find number min = 48, max = 57

                // Step 2. If we need only letters the first letter needs to be capital (upper)
                if(!isLetterAndDigit) // == false, only letters
                {
                    // produces letters with the first letter as capital
                    if (i == 0)
                    {
                        result += ReturnARandomCharacterBetween(65, 90); // upper
                    }
                    else
                    {
                        result += ReturnARandomCharacterBetween(97, 122); // lower
                    }
                } // false == !true
                
                // Step 3. If we need letters and numbers,
                // Step 3a. first character needs to be a letter (upper or lower)
                // Step 3b. second characters needs to be a letter (upper or lower)
                // Step 3c. all the rest of the characters (except character 0 and 1) need to be numbers
                else
                {
                    if(i == 0 || i == 1)
                    {
                        result += ReturnARandomCharacterBetween(65, 90);
                    }
                    else
                    {
                        result += ReturnARandomCharacterBetween(48, 57);
                    }
                }
            }
            return result;
        }

        private static char ReturnEnglishLetterOrNumber(bool isLetterAndDigit)
        {
            int asciiCode = _random.Next(122 + 1);
            char c = Convert.ToChar(asciiCode);

            if (isLetterAndDigit) // true == letter or digit
            {
                while (!Char.IsLetterOrDigit(c)) // για όσο δεν βρίσκω χαρακτήρα ή αριθμό φτιάξε νέο
                {
                    asciiCode = _random.Next(122 + 1);
                    c = Convert.ToChar(asciiCode);
                }
            }
            else // false == only letter
            {
                while (!Char.IsLetter(c)) // για όσο δεν βρίσκω χαρακτήρα φτιάξε νέο
                {
                    asciiCode = _random.Next(122 + 1);
                    c = Convert.ToChar(asciiCode);
                }

            }
            return c;
        }

        private static char ReturnARandomCharacterBetween(int min, int max)
        {
            char c = new Char();

            // min 65, max 91
            c = Convert.ToChar(_random.Next(min, max + 1));
            return c;
        }
    }
}
