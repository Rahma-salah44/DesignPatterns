using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    internal class Message
    {
        public string Text;
        public MessagePriority Priority;
        public Message(string msg, MessagePriority p)
        {
            Text = msg;
            this.Priority = p;
        }
    }
    public enum MessagePriority
    {
        Normal,
        High
    };

}
