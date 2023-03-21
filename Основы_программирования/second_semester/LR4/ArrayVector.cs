using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratornaya_4
{
    class ArrayVector : IVectorable
    {
        private int[] coordinates;

        public ArrayVector(int razmer)
        {
            coordinates = new int[razmer];
        }

        public ArrayVector()
        {
            coordinates = new int[5];
        }

        public int this[int index]
        {
            get
            {
                if ((index < 0) && (index >= coordinates.Length))
                {
                    throw new Exception("Неправильный индекс!");
                }
                else
                {
                    return coordinates[index];
                }
            }
            set
            {
                if ((index < 0) && (index >= coordinates.Length))
                {
                    throw new Exception("Неправильный индекс!");
                }
                else
                {
                    coordinates[index] = value;
                }

            }
        }
        public int Length
        {
            get
            {
                return coordinates.Length;
            }
        }

        public double GetNorm()
        {
            int sum = 0;
            for (int i = 0; i < coordinates.Length; i++)
            {
                sum += coordinates[i] * coordinates[i];
            }
            double result = Math.Sqrt(sum);
            return result;
        }
        override public String ToString()
        {
            return coordinates.Length + " " + "[" + string.Join(" ", coordinates) + "]";
        }

    }
}
