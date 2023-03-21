using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratornaya_4
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
