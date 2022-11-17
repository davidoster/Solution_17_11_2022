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
                // check if the c is less than 65 or more than 122 and amend accordingly
                // english characters, upper and lower
                // numbers 0 - 9
                result += ReturnEnglishLetterOrNumber(isLetterAndDigit);
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
