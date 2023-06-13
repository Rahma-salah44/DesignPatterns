using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StateDP
{
    internal class Off : IPossibleStates
    {
        TV tvContext;
        public Off(TV context)
        {
            Console.WriteLine(" TV is Off now.");
            this.tvContext = context;
        }
        //Users can press any of these buttons at this state-On, Off or Mute
        //TV is Off now, user is pressing On button
        public void PressOnButton(TV context)
        {
            Console.WriteLine("You pressed On button. Going from Off to On state");

            tvContext.CurrentState = new On(context);
        }
        //TV is Off already, user is pressing Off button again
        public void PressOffButton(TV context)
        {
            Console.WriteLine("You pressed Off button. TV is already in Off state");
        }
        public void PressMuteButton(TV context)
        {
            Console.WriteLine("You pressed Mute button. TV is already in Off state, so Mute operation will not work.");
        }
    }
}
