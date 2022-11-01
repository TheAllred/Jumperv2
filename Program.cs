// See https://aka.ms/new-console-template for more information
using System;

namespace Jumper // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calls the director to begin and manage the game.
            director directorClass = new director();
            directorClass.guessingLoop();

        }
    }
}