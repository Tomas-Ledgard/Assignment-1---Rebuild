//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {



            Console.WindowWidth = 148;

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(@"
 ▄█     █▄   ▄██████▄     ▄████████ ████████▄          ▄████████ ███▄▄▄▄      ▄████████  ▄█       ▄██   ▄      ▄████████    ▄████████    ▄████████ 
███     ███ ███    ███   ███    ███ ███   ▀███        ███    ███ ███▀▀▀██▄   ███    ███ ███       ███   ██▄   ███    ███   ███    ███   ███    ███ 
███     ███ ███    ███   ███    ███ ███    ███        ███    ███ ███   ███   ███    ███ ███       ███▄▄▄███   ███    █▀    ███    █▀    ███    ███ 
███     ███ ███    ███  ▄███▄▄▄▄██▀ ███    ███        ███    ███ ███   ███   ███    ███ ███       ▀▀▀▀▀▀███   ███         ▄███▄▄▄      ▄███▄▄▄▄██▀ 
███     ███ ███    ███ ▀▀███▀▀▀▀▀   ███    ███      ▀███████████ ███   ███ ▀███████████ ███       ▄██   ███ ▀███████████ ▀▀███▀▀▀     ▀▀███▀▀▀▀▀   
███     ███ ███    ███ ▀███████████ ███    ███        ███    ███ ███   ███   ███    ███ ███       ███   ███          ███   ███    █▄  ▀███████████ 
███ ▄█▄ ███ ███    ███   ███    ███ ███   ▄███        ███    ███ ███   ███   ███    ███ ███▌    ▄ ███   ███    ▄█    ███   ███    ███   ███    ███ 
 ▀███▀███▀   ▀██████▀    ███    ███ ████████▀         ███    █▀   ▀█   █▀    ███    █▀  █████▄▄██  ▀█████▀   ▄████████▀    ██████████   ███    ███ 
                         ███    ███                                                     ▀                                               ███    ███ ");

            Console.BackgroundColor = ConsoleColor.Black; // Reset Font And Background Color
            Console.ForegroundColor = ConsoleColor.White; // To Default Coloring


            // Setting the folder path for text files to be stored.

            string folder = Environment.CurrentDirectory;
            var filepath = System.IO.Directory.GetParent(folder).Parent.Parent.Parent.Parent + "\\TxtFiles";

            Console.WriteLine("\nYou must place your text file(s) in the following location: \n" + filepath + "\n");

            while (true)
            {
                //Local list of integers to hold the first five measurements of the text
                List<int> parameters = new List<int>();

                //Create 'Input' object
                //Get either manually entered text, or text from a file

                string Text = "";

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("1: Enter Text Manually / 2: Read From File. -> ");
                string option = Console.ReadLine();


                var Input = new Input();

                if (option == "1")
                {

                    Text = Input.manualTextInput();

                }
                else if (option == "2")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Please Enter Filename including '.txt.' -> ");

                    string filename = Console.ReadLine();

                    Text = Input.fileTextInput(filename, filepath);

                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Option Invalid!\nYou must enter either 1 or 2!");
                    Console.ForegroundColor = ConsoleColor.White;
                    option = "Invalid";
                }

                if (option != "Invalid")
                {

                    //Create an 'Analyse' object
                    //Pass the text input to the 'analyseText' method

                    var Analyse = new Analyse();

                    var Analysed = Analyse.analyseText(Text);

                    //Receive a list of integers back

                    var Report = new Report();

                    var Reported = Report.OuputToConsole(Analysed);

                    //Report the results of the analysis


                    //TO ADD: Get the frequency of individual letters?                                                
                }
            }
        }
    }
}
