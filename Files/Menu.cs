using System;
// No LINQ, Generics, etc (Challenge)

namespace Morse_Decoder.Files
{
    class Menu
    {

        // Main Method
        public static void RunMainMenu()
        {
            while (true)
            {
                MainMenu();

                int option = UserPickOption(5);
                RunOptions(option);
            }
        }



        private static void MainMenu()
        {
            Text.Line(2);
            Text.Title();
            Text.Line(2);


            Console.WriteLine($"Pick an option by typing it's number then press ENTER:");
            Console.WriteLine($"[1] Text to Morse. (Encode)");
            Console.WriteLine($"[2] Morse to Text. (Decode)");
            Console.WriteLine($"[3] What's \"Morse Code\".");
            Console.WriteLine($"[4] Show me the Morse symbols.");
            Console.WriteLine($"[5] Close.");
        }



        // This method makes sure the user picks a valid option
        public static int UserPickOption(int maxOptions)
        {
            int option = 0;
            int invalidInput = 0;

            // Keep running until a valid input is used
            bool unlock = false;
            while (unlock == false)
            {
                Console.Write("> ");
                string userOption = Console.ReadLine();

                // Checks if user input was a number
                if (int.TryParse(userOption, out int number))
                {
                    option = int.Parse(userOption);
                }
                else
                {
                    Console.WriteLine("Only numbers are valid.");
                }

                // Checks if the number was valid
                if (option > 0 && option <= maxOptions)
                {
                    unlock = true;
                }
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

            // Just a joke in case the user tries too many invalid inputs
            if (invalidInput > 6)
            {
                Console.WriteLine($"\nWow {invalidInput} tries until you finally picked a valid option in this menu WHAT A SMART GUY YOU MUST BE.\n");
            }

            return option;
        }



        private static void RunOptions(int option)
        {
            switch (option)
            {
                case 1:
                    Submenu.TextToMorse();
                    break;

                case 2:
                    Submenu.MorseToText();
                    break;

                case 3:
                    About();
                    break;

                case 4:
                    End();
                    break;

                case 5:
                    Text.SecretMenu();
                    break;

                // Adicionar depois uma forma de printar na tela todas letras tipo "S = ---" para quem quiser ver o dicionario completo.

                default:
                    Console.WriteLine("How you got here?!");
                    break;
            }
        }



        public static void About()
        {
            Text.Line(2);
            Console.WriteLine($"{Text.IntroGreeting}");

            Text.Line(1);
            Console.WriteLine($"{Text.IntroExplanation}");

            Text.Line(1);
            Console.WriteLine($"{Text.IntroInstruction}");

            Text.Line(3);
            Console.WriteLine("[Press ENTER to go back]");
            Console.ReadLine();
            Text.Line(3);
        }



        // It's only possible to close the programm through this method
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
