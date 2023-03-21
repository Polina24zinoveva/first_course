using System;
using System.Collections.Generic;
using System.Text;

namespace OP_Laboratornaya7
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
        public int CompareTo(IVectorable vector);
        public object Clone();
    }
}
