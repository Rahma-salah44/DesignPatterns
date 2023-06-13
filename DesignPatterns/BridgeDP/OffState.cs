using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDP
{
    internal class OffState : IState
    {
        public void MoveState()
        {
            Console.Write("Off State");
        }
    }
}
