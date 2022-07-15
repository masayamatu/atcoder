using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
namespace atcoder
{
    public class Deque<T>
    {
        T[] buf;
        int offset, count, capacity;
        public int Count { get { return count; } }
        public Deque(int cap) { buf = new T[capacity = cap]; }
        public Deque() { buf = new T[capacity = 16]; }

        // for debug
        public T[] Items
        {
            get
            {
                var a = new T[count];
                for (int i = 0; i < count; i++)
                {
                    a[i] = this[i];
                }
                return a;
            }
        }

        public void Init()
        {
            count = 0;
        }

        public T this[int index]
        {
            get { return buf[getIndex(index)]; }
            set { buf[getIndex(index)] = value; }
        }
        private int getIndex(int index)
        {
            if (index >= capacity)
                throw new IndexOutOfRangeException("out of range");
            var ret = index + offset;
            if (ret >= capacity)
                ret -= capacity;
            return ret;
        }
        public void PushFront(T item)
        {
            if (count == capacity) Extend();
            if (--offset < 0) offset += buf.Length;
            buf[offset] = item;
            ++count;
        }
        public T PopFront()
        {
            if (count == 0)
                throw new InvalidOperationException("collection is empty");
            --count;
            var ret = buf[offset++];
            if (offset >= capacity) offset -= capacity;
            return ret;
        }
        public void PushBack(T item)
        {
            if (count == capacity) Extend();
            var id = count++ + offset;
            if (id >= capacity) id -= capacity;
            buf[id] = item;
        }
        public T PopBack()
        {
            if (count == 0)
                throw new InvalidOperationException("collection is empty");
            return buf[getIndex(--count)];
        }
        public void Insert(int index, T item)
        {
            if (index > count) throw new IndexOutOfRangeException();
            this.PushFront(item);
            for (int i = 0; i < index; i++)
                this[i] = this[i + 1];
            this[index] = item;
        }
        public T RemoveAt(int index)
        {
            if (index < 0 || index >= count) throw new IndexOutOfRangeException();
            var ret = this[index];
            for (int i = index; i > 0; i--)
                this[i] = this[i - 1];
            this.PopFront();
            return ret;
        }
        private void Extend()
        {
            T[] newBuffer = new T[capacity << 1];
            if (offset > capacity - count)
            {
                var len = buf.Length - offset;
                Array.Copy(buf, offset, newBuffer, 0, len);
                Array.Copy(buf, 0, newBuffer, len, count - len);
            }
            else Array.Copy(buf, offset, newBuffer, 0, count);
            buf = newBuffer;
            offset = 0;
            capacity <<= 1;
        }
    }
}