using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
//using static CompLib.CompLib;
//using DataStructure;

namespace atcoder
{

    class algosiki
    {
        const int intMax = 1000000000;
        const long longMax = 2000000000000000000;
        public static void tasks_302()
        {
            var NXY = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var dp = new int[NXY[0]];
            dp[0] = NXY[1];
            dp[1] = NXY[2];
            for (int i = 2; i < NXY[0]; i++)
            {
                dp[i] = (dp[i - 1] + dp[i - 2]) % 100;
            }
            Console.WriteLine(dp[NXY[0] - 1]);
        }
        public static void tasks_303()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var dp = new int[N];
            for (int i = 0; i < N; i++)
            {
                dp[i] = intMax;
            }
            dp[0] = 0;
            for (int i = 0; i < N - 1; i++)
            {
                dp[i + 1] = Math.Min(dp[i + 1], dp[i] + A[i + 1]);
                if (i < N - 2)
                {
                    dp[i + 2] = Math.Min(dp[i + 2], dp[i] + 2 * A[i + 2]);
                }
            }
            Console.WriteLine(dp[N - 1]);
        }
        public static void tasks_304()
        {
            int N = int.Parse(Console.ReadLine());
            var dp = new long[N + 1];
            dp[0] = 1;
            dp[1] = 1;
            for (int i = 2; i <= N; i++)
            {
                dp[i] += dp[i - 1] + dp[i - 2];
            }
            Console.WriteLine(dp[N]);
        }
        public static void tasks_305()
        {
            int N = int.Parse(Console.ReadLine());
            var dp = new long[N + 1];
            dp[0] = 1;
            dp[1] = 1;
            if (N >= 2)
                dp[2] = 2;
            for (int i = 3; i <= N; i++)
            {
                dp[i] += dp[i - 1] + dp[i - 2] + dp[i - 3];
            }
            Console.WriteLine(dp[N]);
        }
        public static void tasks_306()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var dp = Enumerable.Repeat(intMax, NM[0]).ToArray();
            dp[0] = 0;
            for (int i = 0; i < NM[0]; i++)
            {
                for (int j = 1; j <= NM[1]; j++)
                {
                    if (i + j > NM[0] - 1) continue;
                    dp[i + j] = Math.Min(dp[i + j], dp[i] + j * A[i + j]);
                }
            }
            Console.WriteLine(dp[NM[0] - 1]);
        }
    }
}