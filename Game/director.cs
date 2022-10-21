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
            wordManager1.generateHint();
        }

        public void guessingLoop()
        {
            while (solved == false)
            {

                wordManager1.makeAGuess();
                solved = wordManager1.checkIfSolved();
                // Console.Write(solved);
            }

        }



    }
}