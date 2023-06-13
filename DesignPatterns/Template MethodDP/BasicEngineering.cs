using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_MethodDP
{
    internal abstract class BasicEngineering
    {
        public void Papers()
        {
            //Common Papers:
            Math();
            SoftSkills();
            if (IsAdditionalPapersNeeded())
            {
                AdditionalPapers();
            }
            SpecialPaper();
        }
        private void Math()
        {
            Console.WriteLine("Mathematics");
        }
        private void SoftSkills()
        {
            Console.WriteLine("SoftSkills");
        }
        private void AdditionalPapers()
        {
            Console.WriteLine("AdditionalPapers are needed in this stream.");
        }
        public abstract void SpecialPaper();
        //A hook method-Additional Papers not needed.
        public virtual bool IsAdditionalPapersNeeded()
        {
            return true;
        }
    }
}
