using System;
// No LINQ, Generics, etc (Challenge)


namespace Morse_Decoder.Files
{
    class Text
    {
        // TO DO: Add multiple Languages

        private readonly string introGreeting = "Welcome to [MORSE DECODER] (2021)";
        public string IntroGreeting { get => introGreeting; }



        private readonly string introExplanation = "Long ago the [Morse Code] was used in communication for various purposes, created around 1840 it uses electrical pulses to generate a short beep (represented as a point called \"dit\") and a long beep (represented by a dash called \"dah\") to quickly send important messages over long distances before the invention of radio communication. [Morse Code] played an important role during the war, today with satellite communication it just serves as an interesting thing from the past for those who like history.";
        public string IntroExplanation { get => introExplanation; }



        private readonly string introInstruction = "With this software RIGHT HERE you can translate any message from [Morse Code] to Text and vice versa using the International Morse Standard. You can also listen how your message will sound in the \"Text to Morse\" menu.";
        public string IntroInstruction { get => introInstruction; }



        private readonly string textInstruction = "Write below the text you want to turn into [Morse Code].\n - Try to use only letters from A to Z and numbers from 0 to 9.\n - Invalid letters will be displayed as [?]. ";
        public string TextInstruction { get => textInstruction; }



        private readonly string morseInstruction = "Write below the Morse Code you want to turn into text.\n - Each letter in Morse is separated by ONE SPACE, the words are separated by THREE SPACES.\n - The only characters allowed for Morse Code here are the dot [ . ] and the dash [ - ], also known as Dits and Dahs.\n - Dits are short beeps while Dahs are long beeps.\n - When sending the signal the pause between letters should be shorter than the pause between words.\n - The \"?\" symbol means it was an invalid letter.";
        public string MorseInstruction { get => morseInstruction; }



        public static void Title()
        {
            Console.WriteLine(" ██████   ██████    ███████    ███████████    █████████  ██████████                      ");
            Console.WriteLine("░░██████ ██████   ███░░░░░███ ░░███░░░░░███  ███░░░░░███░░███░░░░░█                      ");
            Console.WriteLine(" ░███░█████░███  ███     ░░███ ░███    ░███ ░███    ░░░  ░███  █ ░                       ");
            Console.WriteLine(" ░███░░███ ░███ ░███      ░███ ░██████████  ░░█████████  ░██████                         ");
            Console.WriteLine(" ░███ ░░░  ░███ ░███      ░███ ░███░░░░░███  ░░░░░░░░███ ░███░░█                         ");
            Console.WriteLine(" ░███      ░███ ░░███     ███  ░███    ░███  ███    ░███ ░███ ░   █                      ");
            Console.WriteLine(" █████     █████ ░░░███████░   █████   █████░░█████████  ██████████                      ");
            Console.WriteLine("░░░░░     ░░░░░    ░░░░░░░    ░░░░░   ░░░░░  ░░░░░░░░░  ░░░░░░░░░░                       ");
            Console.WriteLine(" ██████████   ██████████   █████████     ███████    ██████████   ██████████ ███████████  ");
            Console.WriteLine("░░███░░░░███ ░░███░░░░░█  ███░░░░░███  ███░░░░░███ ░░███░░░░███ ░░███░░░░░█░░███░░░░░███ ");
            Console.WriteLine(" ░███   ░░███ ░███  █ ░  ███     ░░░  ███     ░░███ ░███   ░░███ ░███  █ ░  ░███    ░███ ");
            Console.WriteLine(" ░███    ░███ ░██████   ░███         ░███      ░███ ░███    ░███ ░██████    ░██████████  ");
            Console.WriteLine(" ░███    ░███ ░███░░█   ░███         ░███      ░███ ░███    ░███ ░███░░█    ░███░░░░░███ ");
            Console.WriteLine(" ░███    ███  ░███ ░   █░░███     ███░░███     ███  ░███    ███  ░███ ░   █ ░███    ░███ ");
            Console.WriteLine(" ██████████   ██████████ ░░█████████  ░░░███████░   ██████████   ██████████ █████   █████");
            Console.WriteLine("░░░░░░░░░░   ░░░░░░░░░░   ░░░░░░░░░     ░░░░░░░    ░░░░░░░░░░   ░░░░░░░░░░ ░░░░░   ░░░░░ ");
        }



        // Very usefull linebreaker
        public static void Line(int lines)
        {
            for (int i = 0; i < lines; i++) { Console.WriteLine(); }
        }













        public void SecretShrek()
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
