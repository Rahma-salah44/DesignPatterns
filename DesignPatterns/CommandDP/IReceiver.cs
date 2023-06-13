using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDP
{
    internal interface IReceiver
    {
        //It will add 2 with a number
        void Add2WithNumber();
        //It will substract 2 from a number
        void Remove2FromNumber();
        //Optional methods
        //PreProcessing tasks
        void OptionalTasksPriorProcessing();
        //PostProcessing tasks
        void OptionalTasksPostProcessing();
    }
}
