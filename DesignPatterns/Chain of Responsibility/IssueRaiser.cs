using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    internal class IssueRaiser
    {
        public IReceiver setFirstReceiver;
        public IssueRaiser(IReceiver firstReceiver)
        {
            this.setFirstReceiver = firstReceiver;
        }
        public void RaiseMessage(Message message)
        {
            if (setFirstReceiver != null)
                setFirstReceiver.HandleMessage(message);
        }
    }
}
