using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterDP
{
    internal abstract class InputExpression
    {
        public abstract void Interpret(Context context);
    }
}
