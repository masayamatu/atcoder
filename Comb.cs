using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
namespace atcoder
{
    public class Comb
    {
        private  long[] fact_;
        private  long[] fact_inv_;
        private  long[] inv_;
        private long mod = 1000000007;
        
        public Comb(int SIZE)
        {
            fact_ = Enumerable.Repeat((long)1, SIZE + 1).ToArray();
            fact_inv_ = Enumerable.Repeat((long)1, SIZE + 1).ToArray();
            inv_ = Enumerable.Repeat((long)1, SIZE + 1).ToArray();
            for(int i = 2; i < SIZE + 1; i++)
            {
                fact_[i] = fact_[i - 1] * i % mod;
                inv_[i] = mod -inv_[mod % i] * (mod / i) % mod;
                fact_inv_[i] = fact_inv_[i - 1] * inv_[i] % mod;
            }
        }
        public long nCk(int n, int k)
        {
            return fact_[n] * (fact_inv_[k] * fact_inv_[n - k] % mod) % mod;
        }
        public long nHk(int n, int k)
        {
            return nCk(n + k - 1, k);
        }
        public long fact(int n)
        {
            return fact_[n];
        }
        public long fact_inv(int n)
        {
            return fact_inv_[n];
        }
        public long inv(int n)
        {
            return inv_[n];
        }


    }
}