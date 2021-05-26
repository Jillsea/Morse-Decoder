using System;
// No LINQ, Generics, etc (Challenge)

namespace Morse_Decoder.Files
{
    class Menu
    {

        // Main Method
        public void RunMainMenu()
        {
            while (true)
            {
                MainMenu();

                int option = UserPickOption(5);
                RunOptions(option);
            }
        }



        private void MainMenu()
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



        // This method MAKES SURE the user picks a valid option
        // Public+Static because can be used anywhere
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



        private void RunOptions(int option)
        {
            Submenu submenu = new Submenu();

            switch (option)
            {
                case 1:
                    submenu.TextToMorse();
                    break;

                case 2:
                    submenu.MorseToText();
                    break;

                case 3:
                    submenu.About();
                    break;

                case 4:
                    submenu.End();
                    break;

                case 5:
                    submenu.SecretMenu();
                    break;

                // Adicionar depois uma forma de printar na tela todas letras tipo "S = ---" para quem quiser ver o dicionario completo.

                default:
                    Console.WriteLine("How you got here?!");
                    break;
            }
        }





    }
}
