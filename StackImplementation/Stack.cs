using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation
{
    public class Stack<T>
    {
        private T[] s;
        private int currentStackIndex;

        public Stack(int N)
        {
            if (N < 0)
                throw new ArgumentOutOfRangeException("N");

            s = new T[N];
            currentStackIndex = 0;
        }

        public void push(T x)
        {
            if (currentStackIndex + 1 >= s.Length)
            {
                throw new InvalidOperationException("Stack overflow");
            }

            s[currentStackIndex++] = x;
        }

        public T pop()
        {
            if (currentStackIndex == 0)
                throw new InvalidOperationException("Stack underflow");

            T value = s[--currentStackIndex];
            s[currentStackIndex] = default(T);
            return value;
        }

        public T peek()
        {
            T value = s[currentStackIndex];
            return value;
        }

        public int length()
        {
            return s.Length;
        }

        public int freeSpaces()
        {
            return s.Length - currentStackIndex;
        }
    }
}
