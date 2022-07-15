using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructure
{
    public static class MyMath
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
        public static long gcd(long C, long D)
        {
            long tempC = C;
            long tempD = D;

            long r = tempD % tempC;
            while (r != 0)
            {
                tempD = tempC;
                tempC = r;
                r = tempD % tempC;
            }
            return tempC;
        }
        public static long lcm(long C, long D)
        {
            long tempC = C;
            long tempD = D;

            long r = tempD % tempC;
            while (r != 0)
            {
                tempD = tempC;
                tempC = r;
                r = tempD % tempC;
            }
            long lcm = (long)Math.Floor(((decimal)C * D) / tempC);
            return lcm;
        }
        public static long pow(long x, long n, long mod = 100000007)
        {
            long ret = 1;
            while (n > 0)
            {
                if ((n & 1) > 0) ret *= x;
                ret %= mod;
                x *= x;
                x %= mod;
                n = n >> 1;
            }
            return ret;
        }
        public static long[,] Transpose(long[,] A)
        {
            long[,] AT = new long[A.GetLength(1), A.GetLength(0)];
            for (int i = 0; i < A.GetLength(1); i++)
            {
                for (int j = 0; j < A.GetLength(0); j++)
                {
                    AT[i, j] = A[j, i];
                }
            }
            return AT;
        }
        public static long[,] MatrixMultiplication(long[,] A, long[,] B, long mod = 1000000007)
        {
            long[,] C = new long[A.GetLength(0), B.GetLength(1)];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    for (int k = 0; k < A.GetLength(1); k++)
                    {
                        C[i, j] += A[i, k] * B[k, j];
                        C[i, j] %= mod;
                    }
                }
            }
            return C;
        }
        public static long[,] MathrixPow(long[,] A, long n, long mod = 1000000007)
        {
            long[,] P = A;
            long[,] Q = new long[A.GetLength(0), A.GetLength(1)];
            bool flag = false;
            for (int i = 0; i < 60; i++)
            {
                if ((n & ((long)1 << i)) > 0)
                {
                    if (!flag)
                    {
                        Q = P;
                        flag = true;
                    }
                    else
                    {
                        Q = MatrixMultiplication(Q, P, mod);
                    }
                }
                P = MatrixMultiplication(P, P, mod);
            }
            return Q;

        }
    }
}