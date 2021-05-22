using System;
// No LINQ

namespace Morse_Decoder.Files
{
    class Menu
    {
        public static void Introduction()
        {
            Console.WriteLine($"{Text.Greeting}");

            Text.Line(1);
            Console.WriteLine($"{Text.Explanation}");

            Text.Line(1);
            Console.WriteLine($"{Text.Instruction}");
        }


        public static void MainMenu()
        {
            Text.Line(2);
            Console.WriteLine($"=========");
            Text.Line(2);

            Console.WriteLine($"Pick an option, type its number and press ENTER:");
            Console.WriteLine($"[1] Text to Morse (Encode)");
            Console.WriteLine($"[2] Morse to Text (Decode)");
            Console.WriteLine($"[3] Close");
        }


        // This method makes sure the user picks a valid option
        public static int UserPickOption(int maxOptions)
        {
            int option = 0;
            int invalidInput = 0;

            bool unlock = false;
            while (unlock == false)
            {
                Console.Write("> ");
                string userOption = Console.ReadLine();
                if (int.TryParse(userOption, out int number))
                {
                    option = int.Parse(userOption);
                }
                else
                {
                    Console.WriteLine("Only numbers are valid.");
                }


                if (option > 0 && option <= maxOptions) { unlock = true; }
                else if (invalidInput < 5)
                {
                    Console.WriteLine("Pick a valid option please...");
                    invalidInput++;
                }
                else
                {
                    Console.WriteLine("CAN YOU PLEASE... TYPE A VALID NUMBER... SERIOUSLY...");
                    invalidInput++;
                }
            }

            if (invalidInput > 6) { Console.WriteLine($"\nWow {invalidInput} tries until you finally picked a valid option in this menu WHAT A SMART GUY YOU MUST BE.\n"); }

            return option;
        }


        private static void TextToMorse()
        {
            int exit = 1;

            while (exit == 1)
            {
                string userInput;

                Text.Line(2);
                Console.WriteLine(Text.TextInstruction);
                Console.Write("> ");

                userInput = Console.ReadLine();

                Text.Line(1);
                Console.WriteLine("Morse translation ready:");
                Console.Write("> ");
                Console.WriteLine(Decoder.Encode(userInput));

                exit = GoBackMenu();
            }
        }


        private static void MorseToText()
        {
            int exit = 1;

            while (exit == 1)
            {
                string userInput;

                Text.Line(2);
                Console.WriteLine(Text.MorseInstruction);
                Console.Write("> ");

                userInput = Console.ReadLine();

                Text.Line(1);
                Console.WriteLine("Text translation ready:");
                Console.Write("> ");
                Console.WriteLine(Decoder.Decode(userInput));

                exit = GoBackMenu();
            }
        }


        public static int GoBackMenu()
        {
            Text.Line(2);
            Console.WriteLine("Do you want to create a new message?");
            Console.WriteLine("[1] Yes.");
            Console.WriteLine("[2] No. Take me to the Main Menu.");
            Console.WriteLine("[3] No. Exit Program.");

            int goBack = UserPickOption(3);
            if (goBack == 3) { End(); }

            return goBack;
        }


        public static void RunOptions(int option)
        {
            switch (option)
            {
                case 1:
                    TextToMorse();
                    break;

                case 2:
                    MorseToText();
                    break;

                case 3:
                    End();
                    break;

                case 4:
                    Text.SecretMenu();
                    break;

                default:
                    Console.WriteLine("How you got here?!");
                    break;
            }
        }


        public static void End()
        {
            Text.Line(2);
            Console.WriteLine("See you next time!");
            Console.WriteLine("==================");
            Text.Line(2);

            Environment.Exit(0);
        }










    }
}
