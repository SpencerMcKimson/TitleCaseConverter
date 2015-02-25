using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TitleCaseConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            //set file to read
            System.IO.StreamReader inputFile = new System.IO.StreamReader(args[0]);
            System.IO.StreamWriter outputFile = System.IO.File.AppendText(@"C:\Users\kgbtest01\Documents\AllGroupsNew.txt");

            while((line = inputFile.ReadLine()) != null)
            {
                if(Regex.IsMatch(line, "^[a-zA-Z0-9.!-,_\\s]*$"))
                {
                    Console.WriteLine(line);
                    System.Globalization.TextInfo textInfo = new System.Globalization.CultureInfo("en-US", false).TextInfo;
                    outputFile.WriteLine(textInfo.ToTitleCase(textInfo.ToLower(line)));
                    continue;
                }

                else
                    outputFile.WriteLine(line);
            }
        }
    }
}
