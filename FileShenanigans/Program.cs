using System;
using System.IO;
using System.Reflection;

namespace FileShenanigans
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercise 101 
             * 
             * Problem:
             *  Your game has been in production for a few months. And you have some super chill users
             *  recently, a support ticket came in about a user who's Save Data has been corrupted.
             *  
             * Mission Details: 
             *  In order to fix the corrupted data, your Tech Support team has provided the Save File that came attached with the bug report (SaveData.txt)
             *  Any corruption will show up as an empty line. We will want to replace those empty lines with "FIXED" to patch up the save data.  
             *  The goal is to Save a new version of the SaveData so we don't overwrite the original and the Engineering teams can continue to analyze the problem!
             *  
             *  The Script below was started by your Tech Support to find the empty lines and fix them, but there are some errors causing problems and it's not working as expected.
             *  
             *  Objective:
             *   Fix the script below to make it work correctly according to the Mission Details above!
             *  
             *  Hint: here is a useful doc on reading and looping through lines of a file: 
             *  https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-read-a-text-file-one-line-at-a-time
             */

            int counter = 0;

            string line;

            // Get the current Assembly/Project Directory location and add the SaveData File to the path
            string filePath = Path.Combine( Path.GetDirectoryName( Assembly.GetEntryAssembly().Location), "SaveData.txt");

            // Read the file and store it in a variable
            StreamReader file = new StreamReader(@"c:\test.txt"); // TODO - We're not sure how to get the existing file's path, boss.

            // Variable represents the new file
            StreamWriter newFile = new("NewSaveData.txt");

            while ((line = file.ReadLine()) != null)
            {
                if (line == !? )
                {
                    // TODO - Set the line to "Fixed"?
                }

                newFile.WriteLine(line);
                counter++;
            }

            file.Close();
            Console.WriteLine("There were {0} lines.", counter);
            Console.WriteLine("There were {0} EMPTY lines.", counter); // TODO - Showing the wrong counter here?
        }
    }
}
