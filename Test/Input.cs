using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        //Handles the text input for Assessment 1
        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public string manualTextInput()
        {
            Console.WriteLine("Enter user input: ");

            string text = Console.ReadLine();

            return text;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string fileTextInput(string filename, string filepath)
        {
            
            

            try
            {
                string text = File.ReadAllText(filepath + "\\" + filename);
                return text;
            }
            catch (Exception NoFile)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(NoFile.Message);
                string text = null;
                return text;

            }
        }
    }
}
