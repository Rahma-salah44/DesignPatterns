﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDP
{
    internal class Memento
    {
        private string state;
        public string State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }
    }
}
