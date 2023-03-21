using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratornaya4
{
    class Counter
    {
        public int min, max, value;

        public Counter()
        {

        }

        public Counter(int max, int min, int value)
        {
            this.max = max;
            this.min = min;
            this.value = value;
        }

        public void Increase()
        {
            if (value == max)
            {
                value = min;
            }
            else
            {
                value++;
            }
        }

        public void Decrease()
        {
            if (value == min)
            {
                value = max;
            }
            else
            {
                value--;
            }
        }

        public void State()
        {
            Console.WriteLine(value);
        }

        
    }
}
