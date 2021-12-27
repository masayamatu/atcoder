using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DataStructure
{
    public class SegmentTree<T>
    {
        public int N{get; private set;}
        private T[] _tree;
        private readonly Func<T, T, T> _updateMethod;
        private readonly T _initValue;

        public SegmentTree(IEnumerable<T> items, Func<T, T, T> updateMethod,T initValue)
        {
            T[] array = items.ToArray();
            _updateMethod = updateMethod;
            _initValue = initValue;

            N = 1;
            while(N < array.Length) N *= 2;

            _tree = Enumerable.Repeat(initValue, 2 * N - 1).ToArray();

            for(int i = 0; i < array.Length; i++)
            {
                _tree[N + i - 1] = array[i];
            }
            for(int i = N - 2; i >= 0; i--)
            {
                _tree[i] = _updateMethod(_tree[2 * i + 1], _tree[2 * i + 2]);
            }
        }
        public void Update(int i, T x)
        {
            i = N + i - 1;
            _tree[i] = x;
            while(i > 0)
            {
                i = (i - 1) / 2;
                _tree[i] = _updateMethod(_tree[2 * i + 1], _tree[2 * i + 2]);
            }
        }
        public T Execute(int a, int b) => Execute(a, b, 0, 0, N);

        private T Execute(int a, int b, int k, int l, int r)
        {
            if(r <= a || b <= l) return _initValue;
            if(a <= l && r <= b) return _tree[k];
            var vl = Execute(a, b, 2 * k + 1, l, (l + r) / 2);
            var vr = Execute(a, b, 2 * k + 2, (l + r)/ 2, r);
            return _updateMethod(vl, vr);
        }
    }
}