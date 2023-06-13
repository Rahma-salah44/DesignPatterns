using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDP
{
    internal interface IIterator
    {
        void First();//Reset to first element
        string Next();//Get next element
        bool IsDone();//End of collection check
        string CurrentItem();//Retrieve Current Item
    }
}
