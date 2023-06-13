using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CommandDP
{
    internal class AdditionCommand : ICommand
    {
        private IReceiver receiver;
        public AdditionCommand(IReceiver recv)
        {
            receiver = recv;
        }
        public void Do()
        {
            receiver.OptionalTasksPriorProcessing();
            receiver.Add2WithNumber();
            receiver.OptionalTasksPostProcessing();
        }
        public void UnDo()
        {
            Console.WriteLine("Trying undoing addition...");
            receiver.Remove2FromNumber();
            Console.WriteLine("Undo request processed.");
        }
    }
}
