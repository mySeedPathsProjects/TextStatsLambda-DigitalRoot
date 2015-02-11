using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextStatsLambda_DigitalRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            TextStats("Lambda expressions are awesome. I can use this knowledge to pick up babes at the bar. Drunk chicks will think I'm super smart.");

            Console.ReadKey();
        }

        /// <summary>
        /// finds the digital root of a positive number 
        /// </summary>
        /// <param name="rootThisNumber">a positive integer including 0</param>
        /// <returns>integer between 0 and 9, the digital root of input number</returns>
        public static int DigitalRoot(string rootThisNumber)
        {
            //keep looping until digitalRoot is a single digit
            while (true)
            {
                int digitalRoot = 0;
                //convert each char in the string to an int and add together
                foreach (char number in rootThisNumber)
                {
                    digitalRoot += Convert.ToInt32(number.ToString());
                }
                //if digitalRoot is 10 or greater then process again
                if (digitalRoot >= 10)
                {
                    rootThisNumber = digitalRoot.ToString();
                }
                else
                {
                    //return digitalRoot when it's a single digit
                    return digitalRoot;
                }
            }
        }

        /// <summary>
        /// Prints stats of text input
        /// </summary>
        /// <param name="inputString">string to evaluate</param>
        public static void TextStats(string inputString)
        {
            //Number of Characters
            Console.WriteLine("Number of characters: " + inputString.Length);
            //Number of Words
            NumberOfWords(inputString);
            //Number of Vowels
            NumberOfVowels(inputString);
            //Number of Consonants
            NumberOfConsonants(inputString);
            //Number of Special Characters
            NumberOfSpecialCharacters(inputString);
            //Longest Word
            LongestWord(inputString);
            //Shortest Word
            ShortestWord(inputString);
        }

        /// <summary>
        /// Counts number of words in text
        /// </summary>
        /// <param name="inputString">string to evaluate</param>
        /// <returns>number of words</returns>
        public static int NumberOfWords(string inputString)
        {
            Console.WriteLine("Number of words: " + inputString.Split(' ').Length);
            return inputString.Replace("  ", " ").Split(' ').Length;
        }

        /// <summary>
        /// Counts number of vowels in text
        /// </summary>
        /// <param name="inputString">string to evaluate</param>
        /// <returns>number of vowels</returns>
        public static int NumberOfVowels(string inputString)
        {
            Console.WriteLine("Number of vowels: " + inputString.ToLower().Count(x => "aeiou".Contains(x)));
            return inputString.ToLower().Count(x => "aeiou".Contains(x));
        }

        /// <summary>
        /// Counts number of consonants in text
        /// </summary>
        /// <param name="inputString">string to evaluate</param>
        /// <returns>number of consonants</returns>
        public static int NumberOfConsonants(string inputString)
        {
            Console.WriteLine("Number of consonants: " + inputString.ToLower().Count(x => "bcdfghjklmnpqrstvwxyz".Contains(x)));
            return inputString.ToLower().Count(x => "bcdfghjklmnpqrstvwxyz".Contains(x));
        }

        /// <summary>
        /// Counts number of special characters in text
        /// </summary>
        /// <param name="inputString">string to evaluate</param>
        /// <returns>number of special characters</returns>
        public static int NumberOfSpecialCharacters(string inputString)
        {
            // .,?;'!@#$%^&*() and spaces are considered special characters
            Console.WriteLine("Number of special characters: " + inputString.ToLower().Count(x => " .,?;'!@#$%^&*()".Contains(x)));
            return inputString.ToLower().Count(x => " .,?;'!@#$%^&*()".Contains(x));
        }

        /// <summary>
        /// Finds longest word in text
        /// </summary>
        /// <param name="inputString">string to evaluate</param>
        /// <returns>longest word</returns>
        public static string LongestWord(string inputString)
        {
            Console.WriteLine("Longest word: " + inputString.Split(' ').OrderByDescending(x => x.Length).First());
            return inputString.Split(' ').OrderByDescending(x => x.Length).First();
        }

        /// <summary>
        /// Finds shortest word in text
        /// </summary>
        /// <param name="inputString">string to evaluate</param>
        /// <returns>shortest word</returns>
        public static string ShortestWord(string inputString)
        {
            Console.WriteLine("Shortest word: " + inputString.Split(' ').OrderBy(x => x.Length).First());
            return inputString.Split(' ').OrderBy(x => x.Length).First();
        }


    }
}
