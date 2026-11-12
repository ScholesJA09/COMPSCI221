using System;

namespace COMPSCI221
{
    class Stack<T>
    {
        public int maxSize { get; set; }
        public int topOfStack { get; set; }
        public T[] array { get; set; }

        public Stack(int size)
        {
            maxSize = size;
            array = new T[maxSize];
            topOfStack = -1;
        }

        public void Push(T value)
        {
            if (topOfStack == maxSize - 1)
            {
                throw new Exception("Stack is full.");
            }
            else
            {
                topOfStack++;
                array[topOfStack] = value;
            }
        }

        public T Pop()
        {
            if (topOfStack == -1)
            {
                throw new Exception("Stack is empty.");
            }
            else
            {
                T temp = array[topOfStack];
                topOfStack--;
                return temp;
            }
        }

        public T Peek()
        {
            if (topOfStack == -1)
            {
                throw new Exception("Stack is empty.");
            }
            else
            {
                return array[topOfStack];
            }
        }

        public int Size
        {
            get => topOfStack + 1;
        }
    }
}
