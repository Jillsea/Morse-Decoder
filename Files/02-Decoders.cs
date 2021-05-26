using System;
// No LINQ, Generics, etc (Challenge)
// There's no dictionary here because I'm not using the Generics library

namespace Morse_Decoder.Files
{
    class Decoders
    {

        // Not using dictionaries
        private readonly string[] morseBip = {

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
        private readonly char[] letters = {
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



        internal string Decode(string morseCode)
        {
            // Fix the string if needed  
            morseCode = morseCode
                .ToUpper()
                .Trim();

            // Split the string into words
            string[] words = morseCode.Split(new[] { "   ", " / " }, StringSplitOptions.None);
            string decoded = "";

            // This loop deals with each word
            for (int i = 0; i < words.Length; i++)
            {
                string[] letters = words[i].Split(' ');

                // This internal loop deals with each letter from each word
                for (int j = 0; j < letters.Length; j++)
                {
                    letters[j] = MorseToText(letters[j]).ToString();
                    decoded += letters[j];
                }

                if (i < words.Length - 1) decoded += " ";
            }

            return decoded;
        }


        // Almost the same as above but with Chars
        // It was too confusing when it was a single method to encode/decode
        internal string Encode(string textMessage)
        {
            textMessage = textMessage
                .ToUpper()
                .Trim();

            string[] words = textMessage.Split(' ');
            string encoded = "";

            for (int i = 0; i < words.Length; i++)
            {
                char[] letters = words[i].ToCharArray();

                for (int j = 0; j < letters.Length; j++)
                {
                    string morseSignal = TextToMorse(letters[j]);
                    encoded += morseSignal;
                    if (j < letters.Length - 1) encoded += " ";
                }

                if (i < words.Length - 1) encoded += "   ";
            }

            return encoded;
        }



        // The 'translators' used in each letter
        private char MorseToText(string bip)
        {
            for (int i = 0; i < morseBip.Length; i++)
            {
                if (bip == morseBip[i]) return letters[i];
            }
            return '?';
        }



        private string TextToMorse(char letter)
        {
            for (int i = 0; i < letters.Length; i++)
            {
                if (letter == letters[i]) return morseBip[i];
            }
            return "[?]";
        }





    }
}
