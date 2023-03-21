using System;
using System.Collections.Generic;
using System.Text;


namespace OP_Laboratornaya8
{
    public interface IVectorable
    {
        int this[int index]
        {
            get;
            set;
        }

        int Length
        {
            get;
        }

        double GetNorm();
        int CompareTo(IVectorable vector);
        object Clone();
    }
}