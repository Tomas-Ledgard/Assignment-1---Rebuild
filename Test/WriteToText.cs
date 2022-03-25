using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CMP1903M_Assessment_1_Base_Code
{
    class WriteToText
    {
        public string writetofile(string[] words) {

            // Define location of folder to output text file to.

            string folder = Environment.CurrentDirectory;
            var filepath = System.IO.Directory.GetParent(folder).Parent.Parent.Parent + "\\Output.txt";

            // Try write the long words to the file

            try
            {
                using (FileStream fs = File.Create(filepath))
                {
                    foreach (string character in words)
                    {
                        byte[] info = new UTF8Encoding(true).GetBytes(character + "\n");
                        fs.Write(info, 0, info.Length);
                    }
                }
            
            // Give the user a notification regarding success

                Console.ForegroundColor = ConsoleColor.Green;
                string result = "Successfully outputted long words to: " + filepath;
                Console.WriteLine(result);
                Console.ForegroundColor = ConsoleColor.White;
                return result;
            }

            // If an error occurs, notify the user that the method failed

            catch (Exception failed) {
                Console.ForegroundColor = ConsoleColor.Red;
                string result = "Failed to output long words to: " + filepath + " -> " + failed.Message;
                Console.WriteLine(result);
                Console.ForegroundColor = ConsoleColor.White;
                return result;
            }
        }
    }
}
