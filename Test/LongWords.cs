using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CMP1903M_Assessment_1_Base_Code
{
    class LongWords
    {
        public string GetLongWords(string stdin)
        {
            List<char> words = new List<char>();
            try
            {
                // Remove punctuation from the input and add to a list

                foreach (char character in stdin)
                {
                    if (char.IsPunctuation(character))
                    {

                        // do nothing
                    }
                    else
                    {
                        words.Add(character);
                    }
                }

                // Convert the list to an array and rebuild the string so it can be passed on to the next function

                char[] my_string = words.ToArray();
                string BuiltString = new string(my_string);
                string[] nopuncwords = BuiltString.Split(' ');
                List<string> newwords = new List<string>();

                // Find all words longer than seven characters

                foreach (string string_ in nopuncwords)
                {
                    if (string_.Length > 7)
                    {
                        newwords.Add(string_);
                    }
                }

                // Pass the data to the writetofile method

                var Writer = new WriteToText();
                Writer.writetofile(newwords.ToArray());
                return stdin;
            }

            // Realistically the only error possible here is if the input happens to be null, or no data passed in. With the current setup it will loop back to the beginning of the program

            catch (Exception ex) {
                string stdout = "Error occured: " + ex.Message;
                return stdout;
            }
        }

    }
}
