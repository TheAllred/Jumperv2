// See https://aka.ms/new-console-template for more information
using System;

namespace Jumper // Note: actual namespace depends on the project name.
{

    public class parachute
    {
        public TerminalService terminalServiceParachute = new TerminalService();
        List<string> parachuteList = new List<string>();
        private string head = "  O  ";
        public parachute()
        {
            parachuteList.Add(@" --- ");
            parachuteList.Add(@"/   \");
            parachuteList.Add(@"-----");
            parachuteList.Add(@"\    /");
            parachuteList.Add(@" \  / ");
        }
        public void displayParachute()
        {
            foreach (string line in parachuteList)
            {
                terminalServiceParachute.WriteLineText(line);
            }
        }
        public void displayJumper()
        {
            terminalServiceParachute.WriteLineText(@" ");
            terminalServiceParachute.WriteLineText(head);
            terminalServiceParachute.WriteLineText(@" /|\ ");
            terminalServiceParachute.WriteLineText(@" / \ ");
            terminalServiceParachute.WriteLineText(@" ");
            terminalServiceParachute.WriteLineText(@"_____ ");
        }
        public void removeParachute()
        {
            parachuteList.RemoveAt(0);

            if (parachuteList.Count < 1)
            {
                deadJumper();

            }
        }
        public bool isParachuteGone()
        {
            bool gone = false;
            if (parachuteList.Count < 1)
            {
                gone = true;

            }
            return gone;
        }

        public void deadJumper()
        {
            head = "  X  ";
            displayJumper();
            terminalServiceParachute.WriteLineText("Oh no! The parachute failed and the jumper died!");
        }

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