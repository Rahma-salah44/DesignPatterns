using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDP
{
    internal class Television : ElectronicGoods
    {
        public override void MoveToCurrentState()
        {
            Console.Write("\n Television is functioning at : ");
            state.MoveState();
        }
    }
}
