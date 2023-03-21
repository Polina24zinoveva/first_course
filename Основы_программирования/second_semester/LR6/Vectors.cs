using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OP_Laboratornaya6
{
    class Vectors
    {
        public void OutputVector(IVectorable[] vectors, Stream vectors_)          // запись вектора в байтовый поток
        {
            for (int j = 0; j < vectors.Length; j++)                              //идем по всем векторам
            {
                byte[] lengThisVector = BitConverter.GetBytes(vectors[j].Length); //в байтовый массив записываем вектор переведенный в байты
                vectors_.Write(lengThisVector, 0, lengThisVector.Length);         //копируем из arr1 в vectors_p arr1.Length кол-во байтов 
                for (int i = 0; i < vectors[j].Length; i++)                       //идем по всем эл-м каждого вектора
                {
                    byte[] arr2 = BitConverter.GetBytes(vectors[j][i]);           //в байтовый массив записываем каждый эл-т вектора переведенный в байты
                    vectors_.Write(arr2, 0, arr2.Length);                         //копируем из arr2 в vectors_p arr2.Length кол-во байтов 
                }
            }
        }
        public IVectorable[] InputVector(Stream vectors)// чтение вектора из байтового потока
        {
            if (vectors.Length == 0)
            {
                throw new Exception("Массив векторов не содержит вектора");
            }
            else
            {
                vectors.Seek(0, SeekOrigin.Begin);                        //перемещаемся по потоку с 0 индекса
                List<IVectorable> list = new List<IVectorable>();         //создаем список векторов типа IVectorable
                while (vectors.Position != vectors.Length)                //пока позиция вектора != кол-ву векторов
                {
                    byte[] lengThisVector = new byte[4];                            //создаем байтовый массив на 4 ??????
                    vectors.Read(lengThisVector, 0, 4);                             //считываем из байтового массива ???????????????
                    IVectorable vector = new ArrayVector(BitConverter.ToInt32(lengThisVector, 0)); //создаем вектор типа IVectorable ???????????
                    for (int i = 0; i < vector.Length; i++)               //идем по всем эл-м каждого вектора
                    {
                        //lengThisVector = new byte[4];                               //обнуляем байтовый массив на 4 ячейки
                        vectors.Read(lengThisVector, 0, 4);                         //добавляем в массив из vectors значения из 4 ячейки(1цифру, т.к int32 = 4 байтп)
                        vector[i] = BitConverter.ToInt32(lengThisVector, 0);        //преобразовываем 4 эл-та байтового массива в цифру 
                    }
                    list.Add(vector);                                     //добавляем в список векторов вектор
                }
                IVectorable[] newVectors = list.ToArray();                //преобразуем список в массив
                return newVectors;

            }
        }
        public void WriteVector(IVectorable[] vectors, TextWriter vectors_)  // запись вектора в символьный поток
        {
            for (int i = 0; i < vectors.Length; i++)
            {
                for (int j = 0; j < vectors[i].Length; j++)
                {
                    vectors_.Write(vectors[i][j] + " ");
                }
                vectors_.WriteLine();
            }
        }

        public IVectorable[] ReadVector(TextReader vectors) // чтение вектора из символьного потока
        {
            string vector;                                                  //строка вектор
            List<IVectorable> list = new List<IVectorable>();               //создаем список
            while ((vector = vectors.ReadLine()) != null)                   //пока вектор != null
            {
                string[] res = vector.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);    //массив строк = делим вектор на эл-ты, исключая элементы массива, содержащие пустые строки, из результата.
                IVectorable newVector = new ArrayVector(res.Length);        //создаем новый вектор типа IVectorable
                for (int i = 0; i < res.Length; i++)                        //идем по всем эл-м вектора
                {
                    newVector[i] = Convert.ToInt32(res[i]);                 //записываем в i индекс newVector эл-т, преобразованный в int
                }
                list.Add(newVector);                                        //добавляем newVector в список
            }
            IVectorable[] newVectors = list.ToArray();                      //преобразуем список в массив
            return newVectors;
        }
    }
}
