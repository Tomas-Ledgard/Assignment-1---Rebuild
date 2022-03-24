using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> analyseText(string input)
        {
            //List of integers to hold the first five measurements:
            //1. Number of sentences
            //2. Number of vowels
            //3. Number of consonants
            //4. Number of upper case letters
            //5. Number of lower case letters
            List<int> values = new List<int>();
            //Initialise all the values in the list to '0'
            if (input != null)
            {
                for (int i = 0; i < 6; i++)
                {
                    values.Add(0);
                }

                char[] Vowels = { 'a', 'e', 'i', 'o', 'u' }; // Simple character array used to determine wether a character in the input is a vowel or consonant.

                for (int i = 0; i < input.Length; i++) // Loops through the entirety of the inputted string or .txt file.
                {
                    if (input[i] == '.') // Sentences.
                    {
                        values[0] = values[0] + 1; // Add 1 to the counter.
                    }

                    if (Char.IsLetter(input[i]))
                    {

                        values[5] = values[5] + 1; // Total characters (Not including punctuation or whitespaces).

                        if (Vowels.Contains(Char.ToLower(input[i]))) //Vowels.
                        {
                            values[1] = values[1] + 1; // Add 1 to the counter.
                        }
                        else //Consonants.
                        {
                            values[2] = values[2] + 1; // Add 1 to the counter.
                        }

                        if (Char.IsUpper(input[i])) //Uppercase.
                        {
                            values[3] = values[3] + 1; // Add 1 to the counter.
                        }
                        else //Lowercase.
                        {
                            values[4] = values[4] + 1; // Add 1 to the counter.
                        }
                    }
                }
            }
            return values;
        }
    }
}

