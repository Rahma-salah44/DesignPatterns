
namespace CommandDP
{
    internal class Receiver1 : IReceiver
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
        public Receiver1()
        {
            myNumber = 10;
            Console.WriteLine("Receiver1 initialized with {0}", myNumber);
            Console.WriteLine("The objects of receiver1 cannot set beyond {0}", myNumber);
        }
        public void OptionalTasksPriorProcessing()
        {
            Console.WriteLine("Receiver1.OptionalTaskPriorProcessing");
        }
        //PostProcessing tasks
        public void OptionalTasksPostProcessing()
        {
            Console.WriteLine("Receiver1.OptionalTaskPostProcessing\n");
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
            //We started with number 10. We'll not decrease further.
            if (presentNumber > 10)
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
