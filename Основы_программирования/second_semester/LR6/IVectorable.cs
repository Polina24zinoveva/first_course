using System;
using System.Collections.Generic;
using System.Text;

namespace OP_Laboratornaya6
{
    interface IVectorable
    {
        public int this[int index]
        {
            get;
            set;
        }

        public int Length
        {
            get;
        }

        public double GetNorm();
    }
}
