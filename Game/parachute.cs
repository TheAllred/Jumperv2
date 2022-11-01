// See https://aka.ms/new-console-template for more information
using System;

namespace Jumper // Note: actual namespace depends on the project name.
{

    public class parachute
    {
        public TerminalService terminalServiceParachute = new TerminalService();
        List<string> parachuteList = new List<string>();
        private string head = "  O  ";

        // Store the full parachute and fill it each time a new parachute is made. 
        public parachute()
        {
            
            parachuteList.Add(@" --- ");
            parachuteList.Add(@"/   \");
            parachuteList.Add(@"-----");
            parachuteList.Add(@"\    /");
            parachuteList.Add(@" \  / ");
        }
        // Loop through the parachute so that it displays correctly
        public void displayParachute()
        {
            foreach (string line in parachuteList)
            {
                terminalServiceParachute.WriteLineText(line);
            }
        }
        // displays the jumper...
        public void displayJumper()
        {
            terminalServiceParachute.WriteLineText(@" ");
            terminalServiceParachute.WriteLineText(head);
            terminalServiceParachute.WriteLineText(@" /|\ ");
            terminalServiceParachute.WriteLineText(@" / \ ");
            terminalServiceParachute.WriteLineText(@" ");
            terminalServiceParachute.WriteLineText(@"_____ ");
        }

        // removes line from parachute. one line at a time.
        public void removeParachute()
        {
            parachuteList.RemoveAt(0);

            if (parachuteList.Count < 1)
            {
                deadJumper();

            }
        }

        // check if the parachute has run out.
        public bool isParachuteGone()
        {
            bool gone = false;
            if (parachuteList.Count < 1)
            {
                gone = true;

            }
            return gone;
        }

// Display game lost message
        public void deadJumper()
        {
            head = "  X  ";
            displayJumper();
            terminalServiceParachute.WriteLineText("Oh no! The parachute failed and the jumper died!");
        }
// display game won message
        public void doVictoryDance()
        {
            terminalServiceParachute.WriteLineText(@" ");
            terminalServiceParachute.WriteLineText(@"\ O / ");
            terminalServiceParachute.WriteLineText(@"  | ");
            terminalServiceParachute.WriteLineText(@" / \ ");
            terminalServiceParachute.WriteLineText(@" ");
            terminalServiceParachute.WriteLineText(@"_____ ");

        }




    }
}