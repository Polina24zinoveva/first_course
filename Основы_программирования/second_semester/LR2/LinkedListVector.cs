﻿using System;
using System.Text;

namespace OP_Ladoratornaya2
{
    public class LinkedListVector
    {
        public class Node
        {
            public int value = 0;
            public Node next = null;

            public Node(int value)
            {
                this.value = value;
            }
        }


        private Node head = null;

        public LinkedListVector(int dlina)
        {
            if (dlina < 0)
            {
                try
                {
                    throw new ArgumentException("Длина не может быть меньше 0");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            for (int i = 0; i < dlina; i++)
            {
                AddToTail(0);
            }
        }

        public LinkedListVector()
        {
            for (int i = 0; i < 5; i++)
            {
                AddToTail(0);
            }
        }

        public int this[int index]
        {
            get
            {
                Node nthElement = GoToNthElement(index);
                return nthElement.value;
            }
            set
            {
                Node nthElement = GoToNthElement(index);
                nthElement.value = value;
            }
        }

        private Node GoToNthElement(int index)
        {
            if (index < 0)
            {
                throw new IndexOutOfRangeException("Error while executing program:\n" + "Индекс не может быть меньше 0. Запрошенный индекс: " + index);
            }

            else if (head == null)
            {
                throw new IndexOutOfRangeException("Error while executing program:\n" + "Неверный индекс: " + index);
            }

            Node iterator = head;
            int count = 0;
            while (iterator != null && count != index)
            {
                iterator = iterator.next;
                count++;
            }

            if (iterator == null || count != index)
            {
                throw new IndexOutOfRangeException("Error while executing program:\n" + "Неверный индекс: " + index + ". Размер вектора: " + count);
            }
            return iterator;

        }

        public double GetNorm()
        {
            Node iterator = head;
            int sum = 0;
            while (iterator != null)
            {
                sum += iterator.value * iterator.value;
                iterator = iterator.next;
            }
            
            double result = Math.Sqrt(sum);
            return result;
        }

        public int Length
        {
            get
            {
                Node iterator = head;
                int count = 0;
                while (iterator != null)
                {
                    iterator = iterator.next;
                    count++;
                }
                return count;
            }
        }


        public void AddToHead(int value)
        {
            if (head == null)
            {
                head = new Node(value);
                return;
            }

            Node newHead = new Node(value);
            newHead.next = head;
            head = newHead;
        }

        public void AddToTail(int value)
        {
            if (head == null)
            {
                head = new Node(value);
                return;
            }

            Node iterator = head;
            while (iterator.next != null)
            {
                iterator = iterator.next;
            }
            Node tail = new Node(value);
            iterator.next = tail;
        }

        public void RemoveFromHead()
        {
            if (head == null)
            {
                return;
            }

            head = head.next;
        }

        public void RemoveFromTail()
        {
            if (head == null)
            {
                return;
            }

            if (head.next == null)
            {
                head = null;
            }

            Node iterator = head;
            while (iterator.next.next != null)
            {
                iterator = iterator.next;
            }

            iterator.next = null;
        }

        public void AddAtPosition(int index, int value)
        {
            if (index == 0)
            {
                AddToHead(value);
            }
            else
            {
                Node previous = GoToNthElement(index - 1);
                Node newNode = new Node(value);
                newNode.next = previous.next;
                previous.next = newNode;
            }
        }
        
        //public void AddAtPosition(int index, int value)
        //{
        //    if (index == 0)
        //    {
        //        AddToHead(value);
        //    }

        //    else
        //    {
        //        Node previous = this[index - 1];
        //        Node newNode = new Node(value);
        //        newNode.next = previous.next;
        //        previous.next = newNode;
        //    }
            
        //}

        public void RemoveAtPosition(int index)
        {
            if (index == 0)
            {
                RemoveFromHead();
            }

            else
            {
                Node previous = GoToNthElement(index - 1);
                //Node previous = this[index - 1];
                if (previous.next == null)
                {
                    try
                    {
                        throw new IndexOutOfRangeException("Error while executing program:\n" + "Неверный индекс: " + index);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else
                {
                    previous.next = previous.next.next;

                }
            }          
        }

        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("[");
            Node iterator = head;
            while (iterator != null)
            {
                sb.Append(iterator.value).Append(", ");
                iterator = iterator.next;
            }
            sb.Append("]");
            return sb.ToString();
        }

        // public void Print()
        // {
        //     Console.Write("[");
        //     Node iterator = head;
        //     while (iterator != null)
        //     {
        //         Console.Write(iterator.value + " ");
        //         iterator = iterator.next;
        //     }
        //     Console.WriteLine("]");
        // }

    }
}
