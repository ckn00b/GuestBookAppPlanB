using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace ClassLibrary
{
    public class Utils
    {
        public static void DisplayTitle()
        {
            Console.WriteLine("Guest Book");
        }
        public static void MainMenu()
        {
            Console.WriteLine("\n1. Add Entry \n2. Exit");
        }

        public static string GetChoice()
        {
            Console.WriteLine("Please enter your option: ");
            string choice = Console.ReadLine();
            return choice;
        }

        
    }
}
