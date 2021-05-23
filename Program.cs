using System;
using Morse_Decoder.Files;
// No LINQ

namespace Morse_Decoder
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                // Show all the options to the user
                Menu.MainMenu();

                // User choose an option
                int option = Menu.UserPickOption(5);

                // Run selected option
                Menu.RunOptions(option);
            }

        }
    }
}