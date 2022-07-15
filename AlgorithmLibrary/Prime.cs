using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructure
{
    public static class Prime
    {
        public static bool IsPrime(long n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static List<int> GetPrimes(int n)
        {
            var primeList = new List<int>();
            var prime = new int[n + 1];
            for (int i = 2; i <= n; i++)
            {
                int temp = i;
                int id = 2;
                while (temp <= n)
                {
                    prime[temp]++;
                    temp = i * id;
                    id++;
                }
            }
            for (int i = 1; i <= n; i++)
            {
                if (prime[i] == 1)
                {
                    primeList.Add(i);
                }
            }
            return primeList;
        }
    }
}