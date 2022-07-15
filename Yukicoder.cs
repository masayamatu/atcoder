using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using DataStructure;
using System.Runtime.CompilerServices;
using System.Text;

namespace atcoder
{
    class Yukicoder
    {
        const int intMax = 1000000000;
        const long longMax = 2000000000000000000;
        public static void No1946()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var A = new int[NM[1]];
            if (NM[1] != 0)
                A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var cnt = new int[NM[0] + 1];
            var open = new bool[NM[0] + 1];
            for (int i = 0; i < NM[1]; i++)
            {
                open[A[i]] = true;
            }
            cnt[1] = 1;
            for (int i = 2; i <= NM[0]; i++)
            {
                int idx = 2;
                cnt[i]++;
                while (idx <= Math.Sqrt(i))
                {
                    if (i % idx == 0)
                    {
                        cnt[i / idx]++;
                        if (idx != Math.Sqrt(i))
                            cnt[idx]++;
                    }

                    idx++;
                }
            }
            int ans = 0;
            for (int i = NM[0]; i >= 0; i--)
            {
                if ((open[i] && cnt[i] % 2 == 0) || (!open[i] && cnt[i] % 2 == 1))
                {
                    ans++;
                    int idx = 2;
                    while (idx <= Math.Sqrt(i))
                    {
                        if (i % idx == 0)
                        {
                            cnt[i / idx]--;
                            if (idx != Math.Sqrt(i))
                                cnt[idx]--;
                        }
                        idx++;
                    }
                }
            }
            Console.WriteLine(ans);
        }
        public static void No1944()
        {
            var NXY = Console.ReadLine().Split().Select(long.Parse).ToArray();
            int N = (int)NXY[0];
            long X = NXY[1];
            long Y = NXY[2];
            var R = Console.ReadLine().Split().Select(long.Parse).ToArray();
            if (N == 1)
            {
                if (R[0] * R[0] == X * X + Y * Y) Console.WriteLine("Yes");
                else Console.WriteLine("No");
            }
            else
            {
                long sum = 0;
                long min = longMax;
                for (int i = 0; i < N; i++)
                {
                    sum += R[i] * 2;
                    min = Math.Min(min, R[i]);
                }
                double d = Math.Sqrt(X * X + Y * Y);
                if (d <= sum - min)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
        }
        public static void No1927()
        {
            int N = int.Parse(Console.ReadLine());
            String S = Console.ReadLine();
            long mod = 998244353;
            var list = new List<int>();
            int cnt = 0;
            for (int i = 0; i < N; i++)
            {
                if (S[i] == 'A' || S[i] == 'B') cnt++;
            }
            var comb = new Comb(N, mod);
            long ans = comb.nCk(N, cnt);
            Console.WriteLine(ans);
        }
        public static void No1904()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long all = 0;
            for (int i = 1; i <= N; i++)
            {
                if (i == 1) all = i;
                else all *= i;
            }
            var list = new long[N + 1];
            for (int i = 0; i < N; i++)
            {
                list[A[i]]++;
            }
            long p = 1;
            for (int i = 0; i <= N; i++)
            {
                if (list[i] > 0)
                {
                    for (long j = 1; j <= list[i]; j++)
                    {
                        p *= j;
                    }
                }
            }
            Console.WriteLine(all / p);
        }
        public static void No1895()
        {
            int T = int.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                var LR = Console.ReadLine().Split().Select(long.Parse).ToArray();
                Console.WriteLine(solve(LR[0], LR[1]));
            }
            long solve(long l, long r)
            {
                long check(long x)
                {
                    if (x == 0) return 0;
                    long ok = 0;
                    long ng = 1000000001;
                    while (Math.Abs(ok - ng) > 1)
                    {
                        long mid = (ok + ng) / 2;
                        if (mid * mid <= x) ok = mid;
                        else ng = mid;
                    }
                    long ret = ok;
                    ok = 0;
                    ng = 1000000001;
                    while (Math.Abs(ok - ng) > 1)
                    {
                        long mid = (ok + ng) / 2;
                        if (2 * mid * mid <= x) ok = mid;
                        else ng = mid;
                    }
                    ret += ok;
                    return ret;
                }
                long ret = check(r) - check(l - 1);
                return ret % 2;
            }
        }
        public static void No1894()
        {
            int T = int.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int N = int.Parse(Console.ReadLine());
                String S = Console.ReadLine();
                var stack = new Stack<char>();
                for (int i = S.Length - 1; i >= 0; i--)
                {
                    stack.Push(S[i]);
                    if (stack.Count > 2)
                    {
                        if (stack.ElementAt(1) == 'B' && stack.ElementAt(0) == 'A' && stack.ElementAt(2) == 'B')
                        {
                            stack.Pop();
                            stack.Pop();
                        }
                    }
                }
                String ans = "";
                while (stack.Count > 0)
                {
                    ans += stack.Pop();
                }
                Console.WriteLine(ans);
            }
        }
        public static void No1890()
        {
            var NQ = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var P = new List<int>();
            int idx = 0;
            for (int i = 0; i < NQ[0]; i++)
            {
                int temp = 1;
                for (int j = 0; j < A[i]; j++)
                {
                    P.Add(temp);
                    idx++;
                    temp++;
                }
            }
            var sum = new long[P.Count + 1];
            for (int i = 1; i <= P.Count; i++)
            {
                sum[i] = sum[i - 1] + P[i - 1];
            }
            while (NQ[1]-- > 0)
            {
                int S = int.Parse(Console.ReadLine());
                int l = 0;
                int r = P.Count;
                while (r - l > 1)
                {
                    int mid = (l + r) / 2;
                    if (sum[mid] >= S)
                    {
                        r = mid;
                    }
                    else
                    {
                        l = mid;
                    }
                }
                if (sum[r] < S) Console.WriteLine(-1);
                else Console.WriteLine(r);
            }
        }
        public static void No1884()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var list = new List<long>();
            int cnt = 0;
            for (int i = 0; i < N; i++)
            {
                if (A[i] > 0)
                {
                    list.Add(A[i]);
                }
                else
                {
                    cnt++;
                }
            }
            list = list.OrderBy(a => a).ToList();
            var diff = new List<long>();
            for (int i = 0; i < list.Count - 1; i++)
            {
                diff.Add(list[i + 1] - list[i]);
            }
            if (diff.Contains(0))
            {
                if (list[0] == list[list.Count - 1])
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
                return;
            }
            else if (diff.Count == 0)
            {
                Console.WriteLine("Yes");
                return;
            }
            long gcd = diff[0];
            for (int i = 1; i < diff.Count; i++)
            {
                gcd = MyMath.gcd(gcd, diff[i]);
            }
            long need = 0;
            foreach (var d in diff)
            {
                need += (d / gcd) - 1;
            }
            if (need <= cnt)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

    }
}