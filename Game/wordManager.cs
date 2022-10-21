// See https://aka.ms/new-console-template for more information
using System;

namespace Jumper // Note: actual namespace depends on the project name.
{
    public class wordManager
    {
        public TerminalService terminalService1 = new TerminalService();
        public parachute parachuteClass = new parachute();
        public wordList wordList = new wordList();
        public string _hiddenWord = "elephant";


        List<string> DashList = new List<string>();
        char[] letterList = { };

        public wordManager()
        {
            _hiddenWord = wordList.generateRandomWord();
        }

        public void generateHint()
        {
            for (int i = 0; i < _hiddenWord.Length; i++)
            {
                DashList.Add("_ ");
            }
        }
        public void displayHint()
        {
            foreach (string dash in DashList)
            { terminalService1.WriteText(dash); }
            terminalService1.WriteLineText(" ");

        }
        public void makeAGuess()
        {
            string letter = "";

            parachuteClass.displayParachute();
            parachuteClass.displayJumper();
            displayHint();
            while (letter.Length != 1)
            {
                letter = terminalService1.ReadText("Guess a letter: ");
            }

            bool _correct = _hiddenWord.Contains(letter);
            if (_correct)
            {
                int letterIndex = _hiddenWord.IndexOf(letter);
                int lastLetterIndex = _hiddenWord.LastIndexOf(letter);
                if (letterIndex == lastLetterIndex)
                {
                    DashList.RemoveAt(letterIndex);
                    DashList.Insert(letterIndex, letter + " ");
                }
                else
                {
                    bool multipleLetters = true;
                    while (multipleLetters)
                    {
                        DashList.RemoveAt(letterIndex);
                        DashList.Insert(letterIndex, letter + " ");
                        int newLetterIndex = _hiddenWord.IndexOf(letter, letterIndex + 1);
                        DashList.RemoveAt(newLetterIndex);
                        DashList.Insert(newLetterIndex, letter + " ");
                        if (newLetterIndex == lastLetterIndex)
                        {
                            multipleLetters = false;
                        }
                    }
                }
            }
            if (!_correct)
            {
                parachuteClass.removeParachute();
            }



        }

        public bool checkIfSolved()
        {

            bool solved = false;
            if (parachuteClass.isParachuteGone())
            {
                terminalService1.WriteLineText("The word was" + " " + _hiddenWord + ".");
                // terminalService1.WriteText(_hiddenWord);
                solved = true;
            }
            else if (DashList.Contains("_ "))
            { solved = false; }
            else
            {
                solved = true;
                parachuteClass.doVictoryDance();
                displayHint();
                terminalService1.WriteLineText("You guessed the word and the jumper landed safely!");
            }

            return solved;
        }
    }
}




