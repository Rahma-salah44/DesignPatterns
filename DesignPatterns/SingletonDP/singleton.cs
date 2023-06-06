using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDP
{

    //public sealed class singleton   //sealed to stop derivation to make sure no child instance will access the parent property
    //{

    //    private static volatile singleton instance;   //static ==> single access point      volatile ==> for multi threads now the last up to date value
    //    private int numberOfInstance = 0;
    //    private static object lockObj = new object();
    //    private singleton()
    //    {
    //        numberOfInstance++;
    //        Console.WriteLine("Number of instances {0}", numberOfInstance);
    //    }

    //    public static singleton Instance
    //    {
    //        get
    //        {
    //            if (instance == null)

    //                lock (lockObj)
    //                {
    //                    if (instance == null)
    //                        instance = new singleton();    //Double check
    //                }

    //            return instance;
    //        }
    //    }
    //}



    //--------------------------------------without using sealed ----------------------------------------------------------
    public class singleton   //sealed to stop derivation to make sure no child instance will access the parent property
    {

        private static volatile singleton instance;   //static ==> single access point      volatile ==> for multi threads now the last up to date value
        private int numberOfInstance = 0;
        private static object lockObj = new object();
        private singleton()
        {
            numberOfInstance++;
            Console.WriteLine("Number of instances {0}", numberOfInstance);
        }

        public static singleton Instance
        {
            get
            {
                if (instance == null)

                    lock (lockObj)
                    {
                        if (instance == null)
                            instance = new singleton();    //Double check
                    }

                return instance;
            }
        }
        public class NestedDerived : singleton { }
    }
}




