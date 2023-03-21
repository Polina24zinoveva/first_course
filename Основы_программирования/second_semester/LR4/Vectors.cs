using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratornaya_4
{
    class Vectors
    {
        public static ArrayVector Sum(IVectorable vector1, IVectorable vector2)
        {
            ArrayVector result = new ArrayVector(vector1.Length);
            if (vector1.Length != vector2.Length)
            {
                try
                {
                    throw new Exception("Error while executing program:\n" + "Длины векторов должны совпадать!");

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                for (int i = 0; i < vector1.Length; i++)
                {
                    result[i] = vector1[i] + vector2[i];
                }
                Console.WriteLine(result);
            }
            return result;

        }



        public static int Scalar(IVectorable vector1, IVectorable vector2)
        {
            int result = 0;
            if (vector1.Length != vector2.Length)
            {
                try
                {
                    throw new Exception("Error while executing program:\n" + "Длины векторов должны совпадать!");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                for (int i = 0; i < vector1.Length; i++)
                {
                    result += vector1[i] * vector2[i];
                }
                Console.WriteLine(result);
            }
            return result;
        }

        public static double GetNorm2(IVectorable vector)
        {
            return vector.GetNorm();
        }
    }
}
