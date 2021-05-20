using System;
using Morse_Decoder.Decoders;
// No LINQ

namespace Morse_Decoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Text.Greeting);

            string macaco1 = Decoder.Decode(".... . -.--   .--- ..- -.. .");
            string macaco2 = Decoder.Decode("... --- ...");

            Console.WriteLine($"Resultado 01: {macaco1}.\n");
            Console.WriteLine($"Resultado 02: {macaco2}.\n");


            var agoravai = ".---";

            Console.WriteLine(Decoder.MorseToText(".---"));


        }





    }
}
