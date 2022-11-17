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
                // check if the c is less than X or more than Y and amend accordingly
                result += ReturnEnglishLetter(isLetterAndDigit);
            }
            return result;
        }

        private static char ReturnEnglishLetter(bool isLetterAndDigit)
        {
            int asciiCode = _random.Next(122);
            char c = Convert.ToChar(asciiCode);
            if (isLetterAndDigit)
            {
                while (!Char.IsLetterOrDigit(c))
                {
                    asciiCode = _random.Next(122);
                    c = Convert.ToChar(asciiCode);
                }
            }
            else
            {
                while (!Char.IsLetter(c))
                {
                    asciiCode = _random.Next(122);
                    c = Convert.ToChar(asciiCode);
                }

            }
            return c;
        }
    }
}
