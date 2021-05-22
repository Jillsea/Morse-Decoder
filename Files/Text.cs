using System;
// No LINQ


namespace Morse_Decoder.Files
{
    public class Text
    {
        private static string greeting = "Welcome to [MORSE DECODER 2021]";
        public static string Greeting { get => greeting; }

        //

        private static string explanation = "Long ago the [Morse Code] was used in communication for various purposes, created around 1840 it used electrical pulses to generate a short beep (represented as a point called \"dit\") and a long beep (represented by a dash called \"dah\") to quickly send important messages over long distances before the invention of radio communication. Morse code played an important role during the war, today with satellite communication it has just become an interesting thing from the distant past for those who like history.";
        public static string Explanation { get => explanation; }

        //

        private static string instruction = "With [MORSE DECODER 2021] you can translate any message from Morse to Text and vice versa using the International Morse Standard. You can also listen how your message would sound (Work in Progress).";
        public static string Instruction { get => instruction; }

        //

        private static string textInstruction = "Write below the text you want to turn into Morse Code.\n - Try to use only letters from A to Z and numbers from 0 to 9.\n - Invalid letters will be show as [?]. ";
        public static string TextInstruction { get => textInstruction; }

        //

        private static string morseInstruction = "Write below the Morse Code you want to turn into text.\n - Each letter in Morse is separated by ONE SPACE, the words are separated by THREE SPACES.\n - The only characters allowed for Morse are the dot [ . ] and the dash [ - ], also known as Dits and Dahs.\n - Dits are short beeps while Dahs are long beeps.\n - When sending the signal the pause between letters should be shorter than the pause between words.\n - The \"?\" symbol means it was an invalid letter.";
        public static string MorseInstruction { get => morseInstruction; }

        //




        public static void Line(int lines)
        {
            for (int i = 0; i < lines; i++) { Console.WriteLine(); }
        }








        public static void SecretMenu()
        {
            Line(3);
            Console.WriteLine("ENTERING THE SECRET MENU");
            Console.WriteLine("========================");
            Line(1);

            Console.WriteLine("Are you sure you want to proceed?");
            Console.WriteLine("[1] YES!");
            Console.WriteLine("[2] No.");

            int choice = Menu.UserPickOption(2);
            if (choice == 1) { SecretShrek(); }
        }

        public static void SecretShrek()
        {
            Line(3);

            Console.WriteLine($"######################################################################################");
            Console.WriteLine($"#                                                                                    #");
            Console.WriteLine($"#                            ,.--------._                                            #");
            Console.WriteLine($"#                           /            ''.                                         #");
            Console.WriteLine($"#                         ,'                     |                   /               #");
            Console.WriteLine($"#               /' |     /                   Y    | __'             ( YY        // ) #");
            Console.WriteLine($"#               '_'|    /           z#####z   Y  //                  Y YY      // /  #");
            Console.WriteLine($"#                 YY  #####        ##------'.  Y//                    Y_YY||||//_/   #");
            Console.WriteLine($"#                  YY/-----Y     /          '.  Y                      Y/ _  _ Y     #");
            Console.WriteLine($"#                   Y|      Y   |   ,,--..       Y                    Y/|(O)(O)|     #");
            Console.WriteLine($"#                   | ,.--._ Y  (  | ##   Y)      Y                  Y/ |      |     #");
            Console.WriteLine($"#                   |(  ##  )/   Y `-....-//       |///////////////_Y/  Y      /     #");
            Console.WriteLine($"#                     '--'.'      Y                Y              //     |____|      #");
            Console.WriteLine($"#                  /'    /         ) --.            Y            ||     /      Y     #");
            Console.WriteLine($"#               ,..|     Y.________/    `-..         Y   Y       Y|     Y 0  0 /     #");
            Console.WriteLine($"#            _,##/ |   ,/   /   Y           Y         Y   Y       U    / Y_//_/      #");
            Console.WriteLine($"#          :###.-  |  ,/   /     Y        /' ''Y      .Y        (     /              #");
            Console.WriteLine($"#         /####|   |   (.___________,---',/    |       |Y=._____|  |_/               #");
            Console.WriteLine($"#        /#####|   |     Y__|__|__|__|_,/             |####Y    |  ||                #");
            Console.WriteLine($"#       /######Y   Y      Y__________/                /#####|   Y  ||                #");
            Console.WriteLine($"#      /|#######`. `Y                                /#######Y   | ||                #");
            Console.WriteLine($"#     /++Y#########Y  Y                      _,'    _/#########Y | ||                #");
            Console.WriteLine($"#    /++++|#########|  Y      .---..       ,/      ,'##########.Y|_||  Donkey By     #");
            Console.WriteLine($"#   //++++|#########Y.  Y.              ,-/      ,'########,+++++YY_YY Hard'96       #");
            Console.WriteLine($"#  /++++++|##########Y.   '._        _,/       ,'######,''++++++++Y                  #");
            Console.WriteLine($"# |+++++++|###########|       -----.'        _'#######'++++++++++ +Y                 #");
            Console.WriteLine($"# |+++++++|############Y.     YY     //      /#######/++++ S@yaN +++Y                #");
            Console.WriteLine($"#      ________________________YY___//______________________________________         #");
            Console.WriteLine($"#     / ____________________________________________________________________)        #");
            Console.WriteLine($"#    / /              _                                             _                #");
            Console.WriteLine($"#    | |             | |                                           | |               #");
            Console.WriteLine($"#     Y Y            | | _           ____           ____           | |  _            #");
            Console.WriteLine($"#      Y Y           | ||  |        / ___)         / _  )          | | / )           #");
            Console.WriteLine($"#  _____) )          | | | |        | |           (  __ /          | |< (            #");
            Console.WriteLine($"# (______/           |_| |_|        |_|             _____)         |_|  _)           #");
            Console.WriteLine($"#                                                                           19.08.02 #");
            Console.WriteLine($"######################################################################################");

            Console.ReadLine();
        }
    }
}
