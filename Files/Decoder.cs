using System;
// No LINQ

namespace Morse_Decoder.Files
{
    public class Decoder
    {
        // . = dit
        // - = dah
        public static string[] morseBip = {

        "  ", //

        ".-", //A
        "-...", //B
        "-.-.", //C
        "-..", //D
        ".", //E
        "..-.", //F
        "--.", //G
        "....", //H
        "..", //I
        ".---", //J
        "-.-", //K
        ".-..", //L
        "--", //M
        "-.", //N
        "---", //O
        ".--.", //P
        "--.-", //Q
        ".-.", //R
        "...", //S
        "-", //T
        "..-", //U
        "...-", //V
        ".--", //W
        "-..-", //X
        "-.--", //Y
        "--..", //Z

        ".----", //1
        "..---", //2
        "...--", //3
        "....-", //4
        ".....", //5
        "-....", //6
        "--...", //7
        "---..", //8
        "----.", //9
        "-----", //0

        ".-.-.-", //.
        "--..--", // ,
        "..--..", // ?
        ".----.", // '
        "-.-.--", // !
        "-..-.", // /
        "-.--.", // (
        "-.--.-", // )
        ".-...", // &
        "---...", // :
        "-.-.-.", // ;
        "-...-", // =
        ".-.-.", // +
        "-....-", // -
        "..--.-", // _
        ".-..-.", // "
        "...-..-", // $
        ".--.-.", // @
        "..-.-", // ¿
        "--...-", // ¡

        ".-",".-",".-",".-",".-", // As
        ".",".",".",".", // Es
        "..","..","..","..", // Is
        "---","---","---","---","---", // Os
        "..-","..-","..-","..-", // Us
        "-.-." // Ç

        };
        public static char[] letters = {
        ' ',

        'A',
        'B',
        'C',
        'D',
        'E',
        'F',
        'G',
        'H',
        'I',
        'J',
        'K',
        'L',
        'M',
        'N',
        'O',
        'P',
        'Q',
        'R',
        'S',
        'T',
        'U',
        'V',
        'W',
        'X',
        'Y',
        'Z',

        '1',
        '2',
        '3',
        '4',
        '5',
        '6',
        '7',
        '8',
        '9',
        '0',

        '.',
        ',',
        '?',
        '\'',
        '!',
        '/',
        '(',
        ')',
        '&',
        ':',
        ';',
        '=',
        '+',
        '-',
        '_',
        '"',
        '$',
        '@',
        '¿',
        '¡',

        'Á','À','Â','Ã','Ä',
        'É','È','Ê','Ë',
        'Í','Ì','Î','Ï',
        'Ó','Ò','Ô','Õ','Ö',
        'Ú','Ù','Û','Ü',
        'Ç'

        };



        // ----------------



        public static char MorseToText(string bip)
        {
            for (int i = 0; i < morseBip.Length; i++)
            {
                if (bip == morseBip[i]) return letters[i];
            }
            return '?';
        }



        public static string TextToMorse(char letter)
        {
            for (int i = 0; i < letters.Length; i++)
            {
                if (letter == letters[i]) return morseBip[i];
            }
            return "[?]";
        }



        // ----------------



        public static string Decode(string morseCode)
        {
            morseCode = morseCode.ToUpper().Trim();
            string[] words = morseCode.Split(new[] { "   ", " / " }, StringSplitOptions.None);
            string decoded = "";

            for (int i = 0; i < words.Length; i++)
            {
                string[] letters = words[i].Split(' ');

                for (int j = 0; j < letters.Length; j++)
                {
                    letters[j] = Decoder.MorseToText(letters[j]).ToString();
                    decoded += letters[j];
                }

                if (i < words.Length - 1) decoded += " ";
            }

            return decoded;
        }



        public static string Encode(string textMessage)
        {
            textMessage = textMessage.ToUpper().Trim();
            string[] words = textMessage.Split(' ');
            string encoded = "";

            for (int i = 0; i < words.Length; i++)
            {
                char[] letters = words[i].ToCharArray();

                for (int j = 0; j < letters.Length; j++)
                {
                    string morseSignal = Decoder.TextToMorse(letters[j]);
                    encoded += morseSignal;
                    if (j < letters.Length - 1) encoded += " ";
                }

                if (i < words.Length - 1) encoded += "   ";
            }

            return encoded;
        }






    }
}
