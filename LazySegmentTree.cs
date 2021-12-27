using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DataStructure
{
    public class LazySegmentTree
    {
        private int sz;
        private int[] _seg;
        private int[] _lazy;
        private void Push(int k)
        {
            if(k < sz)
            {
                _lazy[k * 2] = Math.Max(_lazy[k * 2], _lazy[k]);
                _lazy[k * 2 + 1] = Math.Max(_lazy[k * 2 + 1], _lazy[k]);
            }
            _seg[k] = Math.Max(_seg[k], _lazy[k]);
            _lazy[k] = 0;
        }
        private void Update(int a, int b, int x, int k, int l, int r)
        {
            Push(k);
            if(r <= a || b <= l) return;
            if(a <= l && r <= b)
            {
                _lazy[k] = x;
                Push(k);
                return;
            }
            Update(a, b, x, k * 2, l, (l + r) >> 1);
            Update(a, b, x, k * 2 + 1, (l + r) >> 1, r);
            _seg[k] = Math.Max(_seg[k * 2], _seg[k * 2 + 1]);
        }
        private int RangeMax(int a, int b, int k, int l, int r)
        {
            Push(k);
            if(r <= a || b <= l) return 0;
            if(a <= l && r <= b) return _seg[k];
            int lc = RangeMax(a, b, k * 2, l, (l + r) >> 1);
            int rc = RangeMax(a, b, k * 2 + 1, (l + r) >> 1, r);
            return Math.Max(lc, rc);
        }
        public LazySegmentTree(int N)
        {
            sz = 1;
            while(sz < N)
            {
                sz *= 2;
            }
            _seg = new int[sz * 2];
            _lazy = new int[sz * 2];
        }
        public void Update(int l, int r, int x)
        {
            Update(l, r, x, 1, 0, sz);
        }
        public int RangeMax(int l, int r)
        {
            return RangeMax(l, r, 1, 0, sz);
        }
    }
}