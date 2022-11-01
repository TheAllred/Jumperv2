// See https://aka.ms/new-console-template for more information
using System;

namespace Jumper // Note: actual namespace depends on the project name.
{
    public class director
    {

        private wordManager wordManager1 = new wordManager();
        private bool solved = false;

        public director()
        {
            // when the game starts, pick a new word.
            wordManager1.generateHint();
        }

        public void guessingLoop()
        {

            // Repeat the loop until the game ends
            while (solved == false)
            {

                wordManager1.makeAGuess();
                solved = wordManager1.checkIfSolved();
                // Console.Write(solved);
            }

        }



    }
}