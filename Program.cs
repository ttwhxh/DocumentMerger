using System;
using System.IO;

namespace DocumentMerger
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Document Merger");

            do
            {
            Console.Write("First Text File: ");
            string first = Input();
            Console.Write("Second Text File: ");
            string second = Input();
            Console.WriteLine(" ");

            string filename = first + second + ".txt";
            try             {
                string firsttext = System.IO.File.ReadAllText(first + ".txt");
                string secondtext = System.IO.File.ReadAllText(second + ".txt");
                 StreamWriter sw = new StreamWriter(filename);

                string filetext = firsttext + " " + secondtext;

                File.WriteAllText(filename, filetext);

                int count = filetext.Length;
                
                Console.WriteLine("{0} was successfully saved. The document contains {1} characters.\n", filename, count);             }             catch (Exception e)             {                 Console.WriteLine("Error: " + e.Message);             }

            Console.Write("Would you like to merge two more files? (y/n): ");
            } while (Console.ReadLine().ToLower().Equals("y"));
        }

        static string Input()
        {
            string input = "";
            do
            {
                input = Console.ReadLine();
                if (IsValid(input)) return input;
                Console.Write("This file name does not exist. Please enter again: ");
            } while (true);
        }

        static bool IsValid(string input)
        {
            if (File.Exists(input + ".txt"))
            {
                return true;
            }
            return false;
        }
    }
}

