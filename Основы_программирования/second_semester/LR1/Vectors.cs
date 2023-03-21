using System;
using System.Collections.Generic;
using System.Text;

namespace Лабораторная_1__2_семестр_
{
    class Vectors
    {
        public static ArrayVector Sum(ArrayVector vector1, ArrayVector vector2)
        {
            if (vector1.GetRazmer() != vector2.GetRazmer())
            {
                throw new Exception("Длины векторов должны совпадать!");
            }
            ArrayVector result = new ArrayVector(vector1.GetRazmer());
            for (int i = 0; i < vector1.GetRazmer(); i++)
            {
                result.SetElement(i, vector1.GetElement(i) + vector2.GetElement(i));
            }
            return result;
        }

        public static int Scalar(ArrayVector vector1, ArrayVector vector2)
        {
            if (vector1.GetRazmer() != vector2.GetRazmer())
            {
                throw new Exception("Длины векторов должны совпадать!");
            }
            int result = 0;
            for (int i = 0; i < vector1.GetRazmer(); i++)
            {
                result += vector1.GetElement(i) * vector2.GetElement(i);
            }
            return result;
        }

        public static ArrayVector NumberMult(ArrayVector vector, int n)
        {
            ArrayVector result = new ArrayVector(vector.GetRazmer());
            for (int i = 0; i < vector.GetRazmer(); i++)
            {
                result.SetElement(i, vector.GetElement(i) * n);
            }
            return result;
        }

        public static double GetNorm(ArrayVector vector)
        {
            return vector.GetNorm();
        }
    }
}
