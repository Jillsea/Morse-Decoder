using System;
// No LINQ, Generics, etc (Challenge)


namespace Morse_Decoder.Files
{
    class Submenu : Menu
    {
        internal static void TextToMorse()
        {
            int exit = 1;
            while (exit == 1)
            {
                string userInput;

                // Instructions
                Text.Line(2);
                Console.WriteLine(Text.TextInstruction);
                Console.Write("> ");

                // Translate user text
                userInput = Console.ReadLine();
                userInput = Decoder.Encode(userInput);

                // Show result
                Text.Line(1);
                Console.WriteLine("Translation to Morse ready:");
                Console.Write("> ");
                Console.WriteLine(userInput);

                // Offer to play the Morse Code sounds
                PlayMorseSoundMenu(userInput);

                exit = GoBackMenu();
            }
        }



        private static void PlayMorseSoundMenu(string morseCode)
        {
            Text.Line(2);
            Console.WriteLine("Play the Morse Code as a sound");
            Console.WriteLine("[1] Yes.");
            Console.WriteLine("[2] No.");

            int playMorse = UserPickOption(2);

            if (playMorse == 1)
            {
                while (playMorse == 1)
                {
                    Text.Line(1);
                    Console.WriteLine("Now Playing:");
                    Console.Write($"> {morseCode}");
                    Sounds.PlayMorse(morseCode);

                    Text.Line(2);
                    Console.WriteLine("Play again?");
                    Console.WriteLine("[1] Yes.");
                    Console.WriteLine("[2] No.");

                    playMorse = UserPickOption(2);
                }
            }
        }



        internal static void MorseToText()
        {
            int exit = 1;
            while (exit == 1)
            {
                string userInput;

                // Instructions
                Text.Line(2);
                Console.WriteLine(Text.MorseInstruction);
                Console.Write("> ");

                // Translate user Morse Code
                userInput = Console.ReadLine();
                userInput = Decoder.Decode(userInput);

                // Show result
                Text.Line(1);
                Console.WriteLine("Translation to text ready:");
                Console.Write("> ");
                Console.WriteLine(userInput);

                exit = GoBackMenu();
            }
        }



        private static int GoBackMenu()
        {
            Text.Line(2);
            Console.WriteLine("Do you want to translate another message?");
            Console.WriteLine("[1] Yes.");
            Console.WriteLine("[2] No. Take me to the Main Menu.");
            Console.WriteLine("[3] No. Exit Program.");

            int goBack = UserPickOption(3);
            if (goBack == 3)
            {
                End();
            }

            return goBack;
        }




    }
}
