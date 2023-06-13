using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDP
{
    internal class Invoker
    {
        ICommand commandToBePerformed;
        public void SetCommand(ICommand command)
        {
            this.commandToBePerformed = command;
        }
        public void ExecuteCommand()
        {
            commandToBePerformed.Do();
        }
        public void UndoCommand()
        {
            commandToBePerformed.UnDo();
        }
    }
}
