using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDP
{
    internal interface IMediator
    {
        void Send(Friend fromFriend, Friend toFriend, string msg);
    }
}
