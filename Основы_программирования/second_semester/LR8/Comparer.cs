using System;
using System.Collections.Generic;
using System.Text;

namespace OP_Laboratornaya8
{
    class Comparer : IComparer<IVectorable>
    {
        public int Compare(IVectorable vector1, IVectorable vector2)
        {
            if (vector1.GetNorm() == vector2.GetNorm())
            {
                return 0;
            }
            else if (vector1.GetNorm() >= vector2.GetNorm())
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
