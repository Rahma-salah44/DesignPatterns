﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterDP
{
    internal class TensExpression : InputExpression
    {
        public override void Interpret(Context context)
        {
            if (context.CanProceed)
            {
                int tens = context.GetInput % 100;
                //Process further by dividing it by 10
                tens = tens / 10;
                switch (tens)
                {
                    case 1:
                        context.SetOutput += "One Ten and";
                        break;
                    case 2:
                        context.SetOutput += "Twenty";
                        break;
                    case 3:
                        context.SetOutput += "Thirty";
                        break;
                    case 4:
                        context.SetOutput += "Forty";
                        break;
                    case 5:
                        context.SetOutput += "Fifty";
                        break;
                    case 6:
                        context.SetOutput += "Sixty";
                        break;
                    case 7:
                        context.SetOutput += "Seventy";
                        break;
                    case 8:
                        context.SetOutput += "Eighty";
                        break;
                    case 9:
                        context.SetOutput += "Ninety";
                        break;

                    default:
                        context.SetOutput += String.Empty;
                        break;
                }
            }
        }
    }
}
