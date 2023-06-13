using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDP
{
    internal class Boss : Friend
    {
        public Boss(IMediator mediator, string name) : base(mediator)
        {
            this.Name = name;
            this.Status = "On";
        }

        //Message will go to the intended friend.
        public void Send(Friend intendedFriend, string msg)
        {
            mediator.Send(this, intendedFriend, msg);
        }
    }
}
