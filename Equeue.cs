using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuby_5
{
    
    internal class equeue<T>
    {
        private T[] data;
        private int head, tail, csize, MaxSize;

        public equeue(int Size)
        {
            data = new T[Size];
            head = 0;
            tail = -1;
            csize = 0;
            MaxSize = Size;

        }

        public T Dequeue()//remove
        {
            head++;

            csize--;
            return data[head - 1];
        }

        public void Enqueue(T item)//add
        {
            tail++;

            data[tail % MaxSize] = item;
            csize++;



        }

        public bool Isfull()
        {
            if (csize == MaxSize) return true;
            return false;
        }

        public bool IsEmpty()
        {
            if (csize == 0) { return true; }
            return false;
        }

        public int Gsize()//count
        {
            return csize;
        }

    }
}
