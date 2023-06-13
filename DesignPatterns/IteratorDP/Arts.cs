using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDP
{
    internal class Arts : ISubjects
    {
        private string[] Subjects;
        public Arts()
        {
            Subjects = new[] { "Bengali", "English" };
        }
        public IIterator CreateIterator()
        {
            return new ArtsIterator(Subjects);
        }
    }
}
