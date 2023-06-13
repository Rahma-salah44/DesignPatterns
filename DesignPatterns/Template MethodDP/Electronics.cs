using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_MethodDP
{
    internal class Electronics : BasicEngineering
    {
        public override void SpecialPaper()
        {
            Console.WriteLine("Digital Logic and Circuit Theory");
        }
        //Using the hook method
        public override bool IsAdditionalPapersNeeded()
        {
            return false;
        }
    }
}
