using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterDP
{
    internal class UnitExpression : InputExpression
    {
        public override void Interpret(Context context)
        {
            if (context.CanProceed)
            {
                int units = context.GetInput % 100;
                //Process further to get the unit digit
                units = units % 10;
                switch (units)
                {
                    case 1:
                        context.SetOutput += "One";
                        break;
                    case 2:
                        context.SetOutput += "Two";
                        break;
                    case 3:
                        context.SetOutput += "Three";
                        break;
                    case 4:
                        context.SetOutput += "Four";
                        break;
                    case 5:
                        context.SetOutput += "Five";
                        break;
                    case 6:
                        context.SetOutput += "Six";
                        break;
                    case 7:
                        context.SetOutput += "Seven";
                        break;
                    case 8:
                        context.SetOutput += "Eight";
                        break;
                    case 9:
                        context.SetOutput += "Nine";
                        break;
                    default:
                        context.SetOutput += String.Empty;
                        break;
                }
            }
        }
    }
}
