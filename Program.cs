using System;
using Morse_Decoder.Files;
// No LINQ, Generics, etc (Challenge)
// [All the code won't use most common libraries on purpose]
// v1.1

namespace Morse_Decoder
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu runApp = new Menu();
            runApp.RunMainMenu();

        }
    }
}