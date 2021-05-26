using System;
// No LINQ, Generics, etc (Challenge)


namespace Morse_Decoder.Files
{
    class Submenu : Menu
    {
        Text text = new Text();
        Decoders translator = new Decoders();


        protected internal void TextToMorse()
        {
            int exit = 1;
            while (exit == 1)
            {
                string userInput;

                // Instructions
                Text.Line(2);
                Console.WriteLine(text.TextInstruction);
                Console.Write("> ");

                // Translate user text
                userInput = Console.ReadLine();
                userInput = translator.Encode(userInput);

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



        private void PlayMorseSoundMenu(string morseCode)
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



        protected internal void MorseToText()
        {
            int exit = 1;
            while (exit == 1)
            {
                string userInput;

                // Instructions
                Text.Line(2);
                Console.WriteLine(text.MorseInstruction);
                Console.Write("> ");

                // Translate user Morse Code
                userInput = Console.ReadLine();
                userInput = translator.Decode(userInput);

                // Show result
                Text.Line(1);
                Console.WriteLine("Translation to text ready:");
                Console.Write("> ");
                Console.WriteLine(userInput);

                exit = GoBackMenu();
            }
        }



        protected internal int GoBackMenu()
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



        protected internal void About()
        {
            Text.Line(2);
            Console.WriteLine($"{text.IntroGreeting}");

            Text.Line(1);
            Console.WriteLine($"{text.IntroExplanation}");

            Text.Line(1);
            Console.WriteLine($"{text.IntroInstruction}");

            Text.Line(3);
            Console.WriteLine("[Press ENTER to go back]");
            Console.ReadLine();
            Text.Line(3);
        }


        protected internal void DictionaryOption()
        {
            Text.Line(2);
            Console.WriteLine("Letter to Morse Signals");
            Text.Line(1);

            translator.PrintDictionary();

            Text.Line(3);
            Console.WriteLine("[Press ENTER to go back]");
            Console.ReadLine();
            Text.Line(3);
        }



        // It's only possible to close the programm through this method
        protected internal void End()
        {
            Text.Line(2);
            Console.WriteLine("See you next time!");
            Console.WriteLine("==================");
            Text.Line(2);

            Environment.Exit(0);
        }








        // Shhhhhhh
        public void SecretMenu()
        {
            Text.Line(3);
            Console.WriteLine("ENTERING THE SECRET MENU");
            Console.WriteLine("========================");
            Text.Line(1);

            Console.WriteLine("Are you sure you want to proceed?");
            Console.WriteLine("[1] YES!");
            Console.WriteLine("[2] No.");

            int choice = UserPickOption(2);
            if (choice == 1) { text.SecretShrek(); }
        }


    }
}
