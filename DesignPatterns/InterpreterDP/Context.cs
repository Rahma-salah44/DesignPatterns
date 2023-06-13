using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterDP
{
    internal class Context
    {
        private int getInput;
        private string getStringInput;
        //We are printing it in the word form i.e. in String representation
        private string setOutput;
        //Flag-whether it is a valid input or not
        private bool canProceed = false;
        public bool CanProceed
        {
            get { return canProceed; }
        }
        //Using properties to get the input(readonly)
        public int GetInput
        {
            get { return getInput; }
        }
        //Using properties to get and set output
        public string SetOutput
        {
            get { return setOutput; }
            set { setOutput = value; }
        }
        //Our constructor
        public Context(string input)
        {
            this.getStringInput = input;
        }
        public int ValidateUserInputBeforeProceedings(string inputString)
        {
            if (int.TryParse(inputString, out getInput))
            {
                Console.WriteLine("You have entered {0}", getInput);
                //Some basic validations
                if ((getInput < 100) || (getInput > 999))
                {
                    Console.WriteLine("Please enter a number between 100 and 999 and try again.");
                    //Just returning a 4-digit negative number to indicate a wrong input
                    return -9999;
                }
            }
            canProceed = true;
            return getInput;
        }

    }
}

