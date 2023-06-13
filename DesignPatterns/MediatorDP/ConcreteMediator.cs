using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MediatorDP
{
    internal class ConcreteMediator : IMediator
    {
        private Friend friend1, friend2, boss;
        public Friend Friend1
        {
            set { this.friend1 = value; }
        }
        public Friend Friend2
        {
            set { this.friend2 = value; }
        }
        public Friend Boss
        {
            set { this.boss = value; }
        }
        public void Send(Friend fromFriend, Friend toFriend, string msg)
        {
            if (toFriend.Status == "On")
            {
                Console.WriteLine(String.Format("[{0}->{1}] : {2} Last message posted {3}", fromFriend.Name, toFriend.Name, msg,
           DateTime.Now));
                System.Threading.Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine(String.Format("[{0}->{1}] : {2}, you cannot post messages now. {3} is offline.", fromFriend.Name, toFriend.Name, fromFriend.Name, toFriend.Name));
            }
        }
    }
}
