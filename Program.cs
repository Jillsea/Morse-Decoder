using System;
using System.Media;
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

                // Menu Controls
                int option = Menu.UserPickOption(5);

                // Encode-Decode
                Menu.RunOptions(option);
            }


        }
    }
}

// SystemSound.Beep.Play();