using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)

        public string OuputToConsole(List<int> Values)
        {

            try
            {
                string test = ("Sentences = " + Values[0] + "\nVowels = " + Values[1] + "\nConsonants = " + Values[2] + "\nUppercase = " + Values[3] + "\nLowercase = " + Values[4] + "\nTotal Characters = " + Values[5]);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(test);
                return test;
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                string ErrorMessage = "Please enter a valid file path.";
                Console.WriteLine(ErrorMessage);
                return ErrorMessage;
            }
        }
    }
}
