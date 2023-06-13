using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDP
{
    internal class Originator
    {
        private string state;
        Memento myMemento;
        public string State
        {
            get { return state; }
            set
            {
                state = value;
                Console.WriteLine("Current State : {0}", state);
            }
        }

        public Memento GetTheMemento()
        {
            //Creating a memento with the current state
            myMemento = new Memento();
            myMemento.State = state;
            return myMemento;
        }

        public void RevertToState(Memento previousMemento)
        {
            Console.WriteLine("Restoring to previous state...");
            this.state = previousMemento.State;
            Console.WriteLine("Current State : {0}", state);
        }
    }
}
