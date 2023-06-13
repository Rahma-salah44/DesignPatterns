using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDP
{
    internal class Receiver2 : IReceiver
    {
        int myNumber;
        public int MyNumber
        {
            get
            {
                return myNumber;
            }
            set
            {
                myNumber = value;
            }
        }
        public Receiver2()
        {
            myNumber = 75;
            Console.WriteLine("Receiver2 initialized with {0}", myNumber);
            Console.WriteLine("The objects of receiver2 cannot set beyond {0}", myNumber);
        }
        //PreProcessing tasks
        public void OptionalTasksPriorProcessing()
        {
            Console.WriteLine("Receiver2.OptionalTaskPriorProcessing");
        }
        //PostProcessing tasks
        public void OptionalTasksPostProcessing()
        {
            Console.WriteLine("Receiver2.OptionalTaskPostProcessing");
        }
        public void Add2WithNumber()
        {
            int presentNumber = this.MyNumber;
            this.MyNumber = this.MyNumber + 2;
            Console.WriteLine("{0}+2={1}", presentNumber, this.MyNumber);
        }

        public void Remove2FromNumber()
        {
            int presentNumber = this.MyNumber;
            //We started with number 75. We'll not decrease further.
            if (presentNumber > 75)
            {
                this.MyNumber = this.MyNumber - 2;
                Console.WriteLine("{0}-2={1}", presentNumber, this.MyNumber);
            }
            else
            {
                Console.WriteLine("Nothing more to undo...");
            }
        }
    }
}
