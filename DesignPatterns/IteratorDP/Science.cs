using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDP
{
    internal class Science : ISubjects
    {
        private LinkedList<string> Subjects;
        public Science()
        {
            Subjects = new LinkedList<string>();
            Subjects.AddFirst("Maths");
            Subjects.AddFirst("Comp. Sc.");
            Subjects.AddFirst("Physics");
        }
        public IIterator CreateIterator()
        {
            return new ScienceIterator(Subjects);
        }
    }
}
