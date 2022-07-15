using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructure
{
    public class PriorityQueue<T> where T : IComparable<T>
    {
        private readonly T[] _array;
        private readonly IComparer _comparer;
        public int Count {get; private set;} = 0;
        public T Root => _array[0];

        public PriorityQueue(int capacity, IComparer comparer = null)
        {
            _array = new T[capacity];
            _comparer = comparer;
        }
        //要素追加
        public void Push(T item)
        {
            _array[this.Count] = item;
            Count += 1;
            var n = Count - 1;
            while(n != 0)
            {
                var parent = (n - 1) / 2;
                if(Compare(_array[n], _array[parent]) > 0)
                {
                    Swap(n, parent);
                    n = parent;
                }
                else
                {
                    break;
                }
            }
        }
        //優先度の一番高いものの取り出し
        public T Pop()
        {
            Swap(0, this.Count - 1);
            Count -= 1;

            var parent = 0;
            while(true)
            {
                var chiled = 2 * parent + 1;
                if(chiled > Count - 1) break;
                if(chiled < Count - 1 && Compare(_array[chiled], _array[chiled + 1]) < 0) chiled += 1;
                if(Compare(_array[parent], _array[chiled]) < 0)
                {
                    Swap(parent, chiled);
                    parent = chiled;
                }
                else
                {
                    break;
                }
            }
            return _array[Count];
        }
        //すべての値を取り出し
        //引数１：True　Pop（）, False　値を取り出だけ
        public IEnumerable<T> GetAllElements(bool withPop = true)
        {
            int count = Count;
            for(int i = 0; i < count; i++)
            {
                if(withPop) yield return Pop();
                else yield return _array[count - i - 1];
            }
        }
        // 引数同士を比較
        private int Compare(T a, T b)
        {
            if(_comparer == null) return a.CompareTo(b);
            return _comparer.Compare(a, b);
        }
        //引数２箇所の入れ替え
        private void Swap(int a, int b)
        {
            var temp = _array[a];
            _array[a] = _array[b];
            _array[b] = temp;
        }
    }
}