using System;
using System.Threading;

namespace Morse_Decoder.Files
{
    class Sounds
    {
        // beep beep
        // I really need to learn how to properly use .wav files in NET 5.0

        static int beepTone = 500;
        static int beepDuration = 100; // Miliseconds



        // Sound """library"""
        public static void PlayDot()
        {
            Console.Beep(beepTone, beepDuration);
        }

        public static void PlayDash()
        {
            Console.Beep(beepTone, beepDuration * 3);
        }

        public static void PlayEmptySpace()
        {
            Thread.Sleep(beepDuration * 5);
        }

        public static void PlayLetterError()
        {
            Console.Beep(beepTone / 3, beepDuration / 2);
        }



        // Main Sound Method
        public static void PlayMorse(string morseCode)
        {
            char[] morseSounds = morseCode.ToCharArray();

            for (int i = 0; i < morseSounds.Length; i++)
            {
                switch (morseSounds[i])
                {
                    case ' ':
                        PlayEmptySpace();
                        break;

                    case '.':
                        PlayDot();
                        break;

                    case '-':
                        PlayDash();
                        break;

                    default:
                        PlayLetterError();
                        break;
                }
            }
        }








    }
}
