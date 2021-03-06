using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using DataStructure;
using System.Runtime.CompilerServices;
using System.Text;

namespace atcoder
{
    class Solve_archive1
    {
        const int intMax = 1000000000;
        const long longMax = 2000000000000000000;
        public static void ABC144_B()
        {
            int N = int.Parse(Console.ReadLine());
            bool flag = false;
            for (int i = 1; i < 10; i++)
            {
                if (N % i == 0 && N / i < 10)
                {
                    flag = true;
                }
            }
            if (flag == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        public static void ABC150_B()
        {
            int N = int.Parse(Console.ReadLine());
            String S = Console.ReadLine();
            char[] charS = S.ToCharArray();
            int count = 0;
            for (int i = 0; i < charS.Length; i++)
            {
                if (charS[i] == 'A' && i < charS.Length - 2)
                {
                    if (charS[i + 1] == 'B' && charS[i + 2] == 'C')
                    {
                        count += 1;
                        i += 2;
                    }
                }
            }
            Console.WriteLine(count);
        }
        public static void ABC122_B()
        {
            String S = Console.ReadLine();
            char[] charS = S.ToCharArray();
            int count = 0;
            int max = 0;
            for (int i = 0; i < charS.Length; i++)
            {
                if (charS[i] == 'A' || charS[i] == 'T' || charS[i] == 'C' || charS[i] == 'G')
                {
                    count += 1;
                }
                else
                {
                    count = 0;
                }
                max = Math.Max(max, count);
            }
            Console.WriteLine(max);
        }
        public static void ABC136_B()
        {
            int N = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= N; i++)
            {
                char[] num = Convert.ToString(i).ToCharArray();
                if (num.Length % 2 == 1)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        public static void ABC106_B()
        {
            int N = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= N; i += 2)
            {
                int temp = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        temp++;
                    }
                }
                if (temp == 8)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        public static void ABC120_B()
        {
            String[] strNum = Console.ReadLine().Split();
            int A = int.Parse(strNum[0]);
            int B = int.Parse(strNum[1]);
            int K = int.Parse(strNum[2]);
            List<int> p = new List<int>();
            for (int i = 1; i <= Math.Min(A, B); i++)
            {
                if (A % i == 0 && B % i == 0)
                {
                    p.Add(i);
                }
            }
            Console.WriteLine(p[p.Count - 1 - (K - 1)]);
        }
        public static void ABC057_C()
        {
            long N = long.Parse(Console.ReadLine());
            int min = 100;
            for (long i = 1; i <= Math.Sqrt(N); i++)
            {
                int temp = 100;
                if (N % i == 0)
                {
                    char[] B = Convert.ToString(N / i).ToCharArray();
                    char[] A = Convert.ToString(i).ToCharArray();
                    temp = Math.Max(A.Length, B.Length);
                }
                min = Math.Min(min, temp);
            }
            Console.WriteLine(min);
        }
        public static void ABC095_C()
        {
            String[] read = Console.ReadLine().Split();
            int A = int.Parse(read[0]);
            int B = int.Parse(read[1]);
            int C = int.Parse(read[2]);
            int X = int.Parse(read[3]);
            int Y = int.Parse(read[4]);
            int sum = 0;
            if (C < (A + B) / 2)
            {
                int numC = Math.Min(X, Y) * 2;
                sum += numC * C;
                if (X > Y)
                {
                    sum += A * (X - numC / 2);
                }
                else
                {
                    sum += B * (Y - numC / 2);
                }
                sum = Math.Min(sum, Math.Max(X, Y) * 2 * C);
            }
            else
            {
                sum = Math.Min(A * X + B * Y, Math.Max(X, Y) * 2 * C);
            }
            Console.WriteLine(sum);
        }
        public static void MSB2019_D()
        {
            int N = int.Parse(Console.ReadLine());
            char[] charS = Console.ReadLine().ToCharArray();
            int[] intS = new int[N];
            for (int i = 0; i < N; i++)
            {
                intS[i] = Convert.ToInt32(charS[i]);
            }
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                int indexI = Array.IndexOf(intS, i + 48);
                if (indexI == -1)
                {
                    continue;
                }
                for (int j = 0; j < 10; j++)
                {
                    int indexJ = Array.IndexOf(intS, j + 48, indexI + 1);
                    if (indexJ == -1)
                    {
                        continue;
                    }
                    for (int k = 0; k < 10; k++)
                    {
                        int indexK = Array.IndexOf(intS, k + 48, indexJ + 1);
                        if (indexK >= 0)
                        {
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
        public static void ABC128_C()
        {
            String[] read = Console.ReadLine().Split();
            int N = int.Parse(read[0]);
            int M = int.Parse(read[1]);
            List<List<int>> s = new List<List<int>>();
            int ans = 0;
            for (int i = 0; i < M; i++)
            {
                String[] read2 = Console.ReadLine().Split();
                s.Add(new List<int>());
                for (int j = 1; j <= int.Parse(read2[0]); j++)
                {
                    s[i].Add(int.Parse(read2[j]));
                }
            }
            List<int> p = new List<int>();
            String[] read3 = Console.ReadLine().Split();
            for (int i = 0; i < M; i++)
            {
                p.Add(int.Parse(read3[i]));
            }
            for (int i = 0; i < Math.Pow(2, N); i++)
            {
                bool[] switches = new bool[N];
                bool[] lights = new bool[M];
                for (int j = 0; j < N; j++)
                {
                    switches[j] = ((i >> j) & 1) == 1;
                }
                for (int j = 0; j < M; j++)
                {
                    int count = 0;
                    for (int k = 0; k < s[j].Count; k++)
                    {
                        if (switches[s[j][k] - 1] == true)
                        {
                            count++;
                        }
                    }
                    if (count % 2 == p[j])
                    {
                        lights[j] = true;
                    }
                }
                for (int j = 0; j < lights.Length; j++)
                {
                    if (lights[j] == false)
                    {
                        break;
                    }
                    else if (j == lights.Length - 1)
                    {
                        ans++;
                    }
                }
            }
            Console.WriteLine(ans);
        }
        public static void ABC147_C()
        {
            int N = int.Parse(Console.ReadLine());
            var data = new Tuple<int, int>[N][];

            for (int i = 0; i < N; i++)
            {
                int tempN = int.Parse(Console.ReadLine());
                data[i] = new Tuple<int, int>[tempN];
                for (int j = 0; j < tempN; j++)
                {
                    var read = Console.ReadLine().Split();
                    data[i][j] = Tuple.Create(int.Parse(read[0]), int.Parse(read[1]));
                }
            }
            int ans = 0;
            for (int i = 1; i < (1 << N); i++)
            {
                bool[] katei = new bool[N];
                for (int j = 0; j < N; j++)
                {
                    katei[j] = ((i >> j) & 1) == 1;
                }
                bool flag = true;
                for (int j = 0; j < N; j++)
                {
                    if (katei[j])
                    {
                        for (int k = 0; k < data[j].Length; k++)
                        {
                            int temp = data[j][k].Item1 - 1;
                            if (katei[temp] != (data[j][k].Item2 == 1))
                            {
                                flag = false;
                            }

                        }
                    }
                }
                if (flag)
                {
                    ans = Math.Max(ans, katei.Count(x => x));
                }
            }
            Console.WriteLine(ans);
        }
        public static void ABC145_C()
        {
            int N = int.Parse(Console.ReadLine());
            var point = new Tuple<int, int>[N];
            double sum = 0;
            double ave = 0;
            for (int i = 0; i < N; i++)
            {
                var read = Console.ReadLine().Split();
                point[i] = Tuple.Create(int.Parse(read[0]), int.Parse(read[1]));
            }
            var allpattern = CompLib.next_permutation(Enumerable.Range(1, N)).ToArray();
            for (int i = 0; i < allpattern.Length; i++)
            {
                for (int j = 0; j < N - 1; j++)
                {
                    sum += Math.Sqrt(Math.Pow(point[allpattern[i][j] - 1].Item1 - point[allpattern[i][j + 1] - 1].Item1, 2) + Math.Pow(point[allpattern[i][j] - 1].Item2 - point[allpattern[i][j + 1] - 1].Item2, 2));
                }
            }
            ave = sum / (double)allpattern.Length;
            Console.WriteLine(ave);
        }
        public static void ABC150_C()
        {
            int N = int.Parse(Console.ReadLine());
            String[] a = Console.ReadLine().Split();
            String[] b = Console.ReadLine().Split();
            var allpattern = CompLib.next_permutation(Enumerable.Range(1, N)).ToArray();
            int countA = 0;
            int countB = 0;
            int count = 0;
            for (int i = 0; i < allpattern.Length; i++)
            {
                count++;
                bool aflag = true;
                bool bflag = true;
                for (int j = 0; j < N; j++)
                {
                    if (int.Parse(a[j]) != allpattern[i][j])
                    {
                        aflag = false;
                    }
                    if (int.Parse(b[j]) != allpattern[i][j])
                    {
                        bflag = false;
                    }
                }
                if (aflag)
                {
                    countA = count;
                }
                if (bflag)
                {
                    countB = count;
                }
            }
            Console.WriteLine(Math.Abs(countA - countB));
        }
        public static void ABC054_C()
        {
            var read = Console.ReadLine().Split();
            int N = int.Parse(read[0]);
            int M = int.Parse(read[1]);
            var edge = new bool[N][];
            for (int i = 0; i < N; i++)
            {
                edge[i] = new bool[N];
            }
            int count = 0;
            for (int i = 0; i < M; i++)
            {
                var query = Console.ReadLine().Split();
                edge[int.Parse(query[0]) - 1][int.Parse(query[1]) - 1] = true;
                edge[int.Parse(query[1]) - 1][int.Parse(query[0]) - 1] = true;
            }
            var allpattern = CompLib.next_permutation(Enumerable.Range(1, N)).ToArray();
            for (int i = 0; i < allpattern.Length; i++)
            {
                if (allpattern[i][0] != 1)
                {
                    break;
                }
                bool flag = true;
                for (int j = 0; j < N - 1; j++)
                {
                    if (!edge[allpattern[i][j] - 1][allpattern[i][j + 1] - 1])
                    {
                        flag = false;
                    }
                }
                if (flag)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        public static void pk_A()
        {
            int N = int.Parse(Console.ReadLine());
            var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var cumlativesum = new CumulativeSum(read);
            var max = new long[N];
            for (int i = 1; i <= N; i++)
            {
                for (int j = 0; j < N - (i - 1); j++)
                {
                    long tempMax = cumlativesum.GetSum(j, j + i);
                    max[i - 1] = Math.Max(max[i - 1], tempMax);
                }
            }
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(max[i]);
            }
        }
        public static void JOI2009_1()
        {
            var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var yado = new int[read[0] - 1];
            var move = new int[read[1]];

            for (int i = 0; i < read[0] - 1; i++)
            {
                yado[i] = int.Parse(Console.ReadLine());
            }
            var cumYado = new CumulativeSum(yado);
            for (int i = 0; i < read[1]; i++)
            {
                move[i] = int.Parse(Console.ReadLine());
            }
            long sum = 0;
            int now = 1;
            for (int i = 0; i < read[1]; i++)
            {
                if (move[i] < 0) sum += cumYado.GetSum((now - 1) + move[i], (now - 1));
                else sum += cumYado.GetSum((now - 1), (now - 1) + move[i]);
                now += move[i];
            }
            Console.WriteLine(sum % 100000);
        }
        public static void JOI2011_1()
        {
            var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = int.Parse(Console.ReadLine());
            var fields = new char[read[0] + 1][];
            var cumsJ = new int[read[0] + 1][];
            var cumsO = new int[read[0] + 1][];
            var cumsI = new int[read[0] + 1][];
            fields[0] = new char[read[1] + 1];
            cumsJ[0] = new int[read[1] + 1];
            cumsO[0] = new int[read[1] + 1];
            cumsI[0] = new int[read[1] + 1];
            int sumJ = 0;
            int sumO = 0;
            int sumI = 0;
            for (int i = 1; i < read[0] + 1; i++)
            {
                var read2 = Console.ReadLine().ToCharArray();
                fields[i] = new char[read[1] + 1];
                cumsJ[i] = new int[read[1] + 1];
                cumsO[i] = new int[read[1] + 1];
                cumsI[i] = new int[read[1] + 1];
                for (int j = 1; j < read[1] + 1; j++)
                {
                    fields[i][j] = read2[j - 1];
                    if (fields[i][j] == 'J')
                    {
                        cumsJ[i][j] = cumsJ[i - 1][j] + cumsJ[i][j - 1] - cumsJ[i - 1][j - 1] + 1;
                        cumsO[i][j] = cumsO[i - 1][j] + cumsO[i][j - 1] - cumsO[i - 1][j - 1];
                        cumsI[i][j] = cumsI[i - 1][j] + cumsI[i][j - 1] - cumsI[i - 1][j - 1];

                    }
                    else if (fields[i][j] == 'O')
                    {
                        cumsJ[i][j] = cumsJ[i - 1][j] + cumsJ[i][j - 1] - cumsJ[i - 1][j - 1];
                        cumsO[i][j] = cumsO[i - 1][j] + cumsO[i][j - 1] - cumsO[i - 1][j - 1] + 1;
                        cumsI[i][j] = cumsI[i - 1][j] + cumsI[i][j - 1] - cumsI[i - 1][j - 1];

                    }
                    else
                    {
                        cumsJ[i][j] = cumsJ[i - 1][j] + cumsJ[i][j - 1] - cumsJ[i - 1][j - 1];
                        cumsO[i][j] = cumsO[i - 1][j] + cumsO[i][j - 1] - cumsO[i - 1][j - 1];
                        cumsI[i][j] = cumsI[i - 1][j] + cumsI[i][j - 1] - cumsI[i - 1][j - 1] + 1;
                    }
                }
            }
            for (int i = 0; i < N; i++)
            {
                var read3 = Console.ReadLine().Split().Select(int.Parse).ToArray();
                sumJ = cumsJ[read3[2]][read3[3]] + cumsJ[read3[0] - 1][read3[1] - 1] - cumsJ[read3[0] - 1][read3[3]] - cumsJ[read3[2]][read3[1] - 1];
                sumO = cumsO[read3[2]][read3[3]] + cumsO[read3[0] - 1][read3[1] - 1] - cumsO[read3[0] - 1][read3[3]] - cumsO[read3[2]][read3[1] - 1];
                sumI = cumsI[read3[2]][read3[3]] + cumsI[read3[0] - 1][read3[1] - 1] - cumsI[read3[0] - 1][read3[3]] - cumsI[read3[2]][read3[1] - 1];
                Console.WriteLine($"{sumJ} {sumO} {sumI}");
            }
        }
        public static void ABC106_D()
        {
            var nmq = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var count = new int[nmq[0]][];
            for (int i = 0; i < count.Length; i++)
            {
                count[i] = new int[nmq[0]];
            }
            for (int i = 0; i < nmq[1]; i++)
            {
                var lr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                count[lr[0] - 1][lr[1] - 1]++;
            }
            for (int l = 0; l < nmq[0]; l++)
            {
                for (int r = l + 1; r < nmq[0]; r++)
                {
                    count[l][r] += count[l][r - 1];
                }
            }
            for (int i = 0; i < nmq[2]; i++)
            {
                var pq = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int ans = 0;
                for (int l = pq[0] - 1; l < pq[1]; l++)
                {
                    ans += count[l][pq[1] - 1];
                }
                Console.WriteLine(ans);
            }
        }
        public static void GigaCode2019_D()
        {
            var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var fields = new long[read[0] + 1][];
            var cumsFields = new long[read[0] + 1][];
            fields[0] = new long[read[1] + 1];
            cumsFields[0] = new long[read[1] + 1];
            for (int i = 1; i <= read[0]; i++)
            {
                fields[i] = new long[read[1] + 1];
                cumsFields[i] = new long[read[1] + 1];
                var totikakaku = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 1; j <= read[1]; j++)
                {
                    fields[i][j] = totikakaku[j - 1];
                    cumsFields[i][j] = cumsFields[i - 1][j] + cumsFields[i][j - 1] - cumsFields[i - 1][j - 1] + fields[i][j];
                }
            }
            int ans = 0;
            for (int a = 1; a <= read[0]; a++)
            {
                for (int b = 1; b <= read[1]; b++)
                {
                    for (int c = a; c <= read[0]; c++)
                    {
                        for (int d = b; d <= read[1]; d++)
                        {
                            long tatemono = (c - a + 1) * (d - b + 1) * read[2];
                            long toti = cumsFields[c][d] - cumsFields[c][b - 1] - cumsFields[a - 1][d] + cumsFields[a - 1][b - 1];
                            int area = (c - a + 1) * (d - b + 1);
                            if (tatemono + toti > read[3])
                            {
                                break;
                            }
                            else
                            {
                                ans = Math.Max(ans, area);
                            }
                        }
                    }
                }
            }
            Console.WriteLine(ans);
        }
        public static void ABC014_C()
        {
            int n = int.Parse(Console.ReadLine());
            var color = new int[1000002];

            for (int i = 0; i < n; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                color[read[0]]++;
                color[read[1] + 1]--;
            }
            int max = color[0];
            for (int i = 1; i < 1000002; i++)
            {
                color[i] += color[i - 1];
                max = Math.Max(max, color[i]);
            }
            Console.WriteLine(max);
        }
        public static void ABC075_C()
        {
            var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var edge = new List<Tuple<int, int>>();
            var v = Enumerable.Range(1, read[0]);
            var dfs = new DepthFirstSearch<int>(v);
            for (int i = 0; i < read[1]; i++)
            {
                var ab = Console.ReadLine().Split().Select(int.Parse).ToArray();
                edge.Add(Tuple.Create(ab[0], ab[1]));
                dfs.Add(ab[0], ab[1]);
                dfs.Add(ab[1], ab[0]);

            }
            int count = 0;
            for (int i = 0; i < edge.Count; i++)
            {
                dfs.Remove(edge[i].Item1, edge[i].Item2);
                dfs.Remove(edge[i].Item2, edge[i].Item1);
                if (!dfs.IsExist(edge[i].Item1, edge[i].Item2)) count++;
                dfs.Add(edge[i].Item1, edge[i].Item2);
                dfs.Add(edge[i].Item2, edge[i].Item1);
            }
            Console.WriteLine(count);
        }
        public static void ABC120_D()
        {
            var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var bridge = new Tuple<int, int>[read[1]];
            for (int i = 0; i < read[1]; i++)
            {
                var ab = Console.ReadLine().Split().Select(int.Parse).ToArray();
                bridge[i] = Tuple.Create(ab[0], ab[1]);
            }
            var count = new long[read[1]];
            var v = Enumerable.Range(1, read[0]);
            var uf = new UnionFind<int>(v);
            count[bridge.Length - 1] = ((long)read[0] * (read[0] - 1)) / 2;
            for (int i = bridge.Length - 1; i >= 1; i--)
            {
                if (uf.IsSame(bridge[i].Item1, bridge[i].Item2))
                {
                    count[i - 1] = count[i];
                }
                else
                {
                    count[i - 1] = count[i] - (long)uf.Size(bridge[i].Item1) * (long)uf.Size(bridge[i].Item2);
                    uf.Unite(bridge[i].Item1, bridge[i].Item2);
                }
            }
            for (int i = 0; i < count.Length; i++)
            {
                Console.WriteLine(count[i]);
            }
        }
        public static void JOI7_F()
        {
            var nk = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var dijkstra = new Dijkstra(nk[0]);
            for (int i = 0; i < nk[1]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (read[0] == 1)
                {
                    dijkstra.Add(read[1] - 1, read[2] - 1, read[3]);
                    dijkstra.Add(read[2] - 1, read[1] - 1, read[3]);
                }
                else
                {
                    long[] cost = dijkstra.GetMinCost(read[1] - 1);
                    cost[read[2] - 1] = cost[read[2] - 1] == long.MaxValue ? -1 : cost[read[2] - 1];
                    Console.WriteLine(cost[read[2] - 1]);
                }
            }
        }

        public static void JOI14_B()
        {
            var n = int.Parse(Console.ReadLine());
            var cut = new int[n];
            var dp = new long[2100, 2100];
            for (int i = 0; i < 2100; i++)
            {
                for (int j = 0; j < 2100; j++)
                {
                    dp[i, j] = -1;
                }
            }
            for (int i = 0; i < n; i++)
            {
                cut[i] = int.Parse(Console.ReadLine());
            }
            long ans = 0;
            for (int i = 0; i < n; i++)
            {
                ans = Math.Max(ans, JOI14B_B_memo((i + 1) % n, (i + n - 1) % n, dp, cut, 1) + cut[i]);
            }
            Console.WriteLine(ans);
        }
        public static long JOI14B_B_memo(int l, int r, long[,] dp, int[] cut, int s)
        {
            if (dp[l, r] != -1) return dp[l, r];
            if (l == r)
            {
                if (s == 1) return dp[l, r] = 0;
                else return dp[l, r] = cut[l];
            }
            if (s == 1)
            {
                if (cut[l] > cut[r])
                {
                    return dp[l, r] = JOI14B_B_memo((l + 1) % cut.Length, r, dp, cut, 0);
                }
                else
                {
                    return dp[l, r] = JOI14B_B_memo(l, (r + cut.Length - 1) % cut.Length, dp, cut, 0);
                }
            }
            else
            {
                return dp[l, r] = Math.Max(JOI14B_B_memo((l + 1) % cut.Length, r, dp, cut, 1) + cut[l], JOI14B_B_memo(l, (r + cut.Length - 1) % cut.Length, dp, cut, 1) + cut[r]);
            }
        }
        /// <summary>
        /// 巡回セールスマン
        /// </summary>
        public static void square869120_G()
        {
            var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var distance = new (long distance, long time)[read[0], read[0]];
            var min = new Dictionary<int, int>();
            for (int i = 0; i < distance.GetLength(0); i++)
            {
                for (int j = 0; j < distance.GetLength(1); j++)
                {
                    distance[i, j] = (longMax, 0);
                }
            }
            for (int i = 0; i < read[1]; i++)
            {
                var readD = Console.ReadLine().Split();
                distance[int.Parse(readD[0]) - 1, int.Parse(readD[1]) - 1] = (long.Parse(readD[2]), long.Parse(readD[3]));
                distance[int.Parse(readD[1]) - 1, int.Parse(readD[0]) - 1] = (long.Parse(readD[2]), long.Parse(readD[3]));
            }
            var dp = new (long cost, long count)[1 << 17, 17];
            var res = sales(dp, distance, (1 << read[0]) - 1, 0);
            Console.WriteLine(res.Item1 == longMax ? "IMPOSSIBLE" : $"{res.Item1} {res.Item2}");
        }
        public static (long, long) sales((long, long)[,] dp, (long, long)[,] distance, int bit, int v)
        {
            if (bit == 0)
            {
                if (v == 0)
                {
                    return (0, 1);
                }
                else
                {
                    return (longMax, 0);
                }
            }
            if ((bit & (1 << v)) == 0)
            {
                return (longMax, 0);
            }
            //すでに訪れていた場合そのまま値を返す
            if (dp[bit, v].Item1 != 0) return dp[bit, v];
            (long, long) res = (longMax, 0);
            for (int u = 0; u < distance.GetLength(0); u++)
            {
                (long, long) temp = sales(dp, distance, bit ^ (1 << v), u);
                temp.Item1 += distance[u, v].Item1;
                if (temp.Item1 <= distance[u, v].Item2)
                {
                    if (res.Item1 > temp.Item1)
                    {
                        res = temp;
                    }
                    else if (res.Item1 == temp.Item1)
                    {
                        res.Item2 += temp.Item2;
                    }
                }
            }
            return dp[bit, v] = res;
        }
        public static void JOI13_D()
        {
            int n = int.Parse(Console.ReadLine());
            var read = Console.ReadLine().ToCharArray();
            var dp = new long[1 << 3, 1100];
            var resp = new int[1100];
            for (int i = 0; i < n; i++)
            {
                if (read[i] == 'J')
                {
                    resp[i + 1] = 1 << 0;
                }
                else if (read[i] == 'O')
                {
                    resp[i + 1] = 1 << 1;
                }
                else if (read[i] == 'I')
                {
                    resp[i + 1] = 1 << 2;
                }
            }
            dp[1, 0] = 1;
            for (int i = 0; i < n; i++)
            {
                for (int now = 0; now < 1 << 3; now++)
                {
                    for (int next = 0; next < 1 << 3; next++)
                    {
                        if ((now & next) > 0)
                        {
                            if ((next & resp[i + 1]) > 0)
                            {
                                dp[next, i + 1] += dp[now, i];
                                dp[next, i + 1] %= 10007;
                            }
                        }
                    }
                }
            }
            long ans = 0;
            for (int now = 0; now < 1 << 3; now++)
            {
                ans += dp[now, n];
                ans %= 10007;
            }
            Console.WriteLine(ans);
        }
        public static void Educational_DP_O()
        {
            int N = int.Parse(Console.ReadLine());
            var match = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < N; j++)
                {
                    match[i, j] = read[j];
                }
            }
            var dp = new long[1 << N];
            dp[0] = 1;
            for (int S = 1; S < 1 << N; S++)
            {
                var i = BitOperations.PopCount((uint)S);
                for (int j = 0; j < N; j++)
                {
                    if ((S >> j & 1) == 1 && match[i - 1, j] == 1)
                    {
                        dp[S] += dp[S ^ 1 << j];
                        dp[S] %= 1000000007;
                    }
                }
            }
            Console.WriteLine(dp[(1 << N) - 1]);

        }
        public static void JOI10_D()
        {
            int n = int.Parse(Console.ReadLine());
            var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var dp = new long[102, 22];
            dp[1, read[0]] = 1;
            for (int i = 1; i < n - 1; i++)
            {
                for (int j = 0; j <= 20; j++)
                {
                    if (dp[i, j] > 0)
                    {
                        int plus = j + read[i];
                        int minus = j - read[i];
                        if (plus <= 20)
                        {
                            dp[i + 1, plus] += dp[i, j];
                        }
                        if (minus >= 0)
                        {
                            dp[i + 1, minus] += dp[i, j];
                        }
                    }
                }
            }
            Console.WriteLine(dp[n - 1, read[n - 1]]);

        }
        public static void JOI11_D()
        {
            var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var A = new int[read[0]];
            for (int i = 0; i < read[1]; i++)
            {
                var read2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
                A[read2[0] - 1] = read2[1];
            }
            var dp = new long[read[0] + 1, 4, 4];
            dp[0, 0, 0] = 1;
            for (int i = 0; i < read[0]; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        var menu = new int[] { 1, 2, 3 };
                        foreach (var pasta in menu)
                        {
                            if (A[i] > 0 && pasta != A[i])
                            {
                                continue;
                            }
                            if (pasta != k || k != j)
                            {
                                dp[i + 1, pasta, j] += dp[i, j, k];
                                dp[i + 1, pasta, j] %= 10000;
                            }
                        }
                    }
                }
            }
            long ans = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    ans += dp[read[0], i, j];
                    ans %= 10000;
                }
            }
            Console.WriteLine(ans);
        }
        public static void JOI12_D()
        {
            var dn = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var day = new int[dn[0]];
            var huku = new (int, int, int)[dn[1]];
            for (int i = 0; i < dn[0]; i++)
            {
                day[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < dn[1]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                huku[i].Item1 = read[0];
                huku[i].Item2 = read[1];
                huku[i].Item3 = read[2];
            }
            var dp = new int[dn[0], dn[1]];

            for (int i = 0; i < dn[0] - 1; i++)
            {
                for (int j = 0; j < dn[1]; j++)
                {
                    if (huku[j].Item1 > day[i + 1] || day[i + 1] > huku[j].Item2) continue;
                    for (int k = 0; k < huku.GetLength(0); k++)
                    {
                        if (huku[k].Item1 > day[i] || day[i] > huku[k].Item2) continue;
                        dp[i + 1, j] = Math.Max(dp[i + 1, j], dp[i, k] + Math.Abs(huku[j].Item3 - huku[k].Item3));
                    }

                }
            }
            long ans = 0;
            for (int i = 0; i < dn[1]; i++)
            {
                ans = Math.Max(ans, dp[dn[0] - 1, i]);
            }
            Console.WriteLine(ans);
        }
        public static void JOI14_D()
        {
            var nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var distance = new int[nm[0]];
            var wether = new int[nm[1]];
            for (int i = 0; i < nm[0] + nm[1]; i++)
            {
                if (i < nm[0])
                {
                    distance[i] = int.Parse(Console.ReadLine());
                }
                else
                {
                    wether[i - nm[0]] = int.Parse(Console.ReadLine());
                }
            }
            var dp = new long[nm[1] + 1, nm[0] + 1];
            for (int i = 0; i < dp.GetLength(0); i++)
            {
                for (int j = 0; j < dp.GetLength(1); j++)
                {
                    dp[i, j] = longMax;
                }
            }
            dp[0, 0] = 0;
            for (int i = 0; i < nm[1]; i++)
            {
                for (int now = 0; now < nm[0]; now++)
                {
                    dp[i + 1, now + 1] = Math.Min(dp[i + 1, now + 1], dp[i, now] + distance[now] * wether[i]);
                    dp[i + 1, now] = Math.Min(dp[i + 1, now], dp[i, now]);
                }
            }
            long ans = longMax;
            for (int i = 0; i <= nm[1]; i++)
            {
                ans = Math.Min(ans, dp[i, nm[0]]);
            }
            Console.WriteLine(ans);
        }
        public static void educational_DP_A()
        {
            var N = int.Parse(Console.ReadLine());
            var h = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var dp = new int[N];
            dp[0] = 0;
            dp[1] = Math.Abs(h[1] - h[0]);
            for (int i = 2; i < N; i++)
            {
                dp[i] = Math.Min(dp[i - 1] + Math.Abs(h[i] - h[i - 1]), dp[i - 2] + Math.Abs(h[i] - h[i - 2]));
            }
            Console.WriteLine(dp[N - 1]);
        }
        public static void educational_DP_B()
        {
            var nk = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var h = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var dp = new int[nk[0]];
            for (int i = 0; i < nk[0]; i++)
            {
                dp[i] = 1000000000;
            }
            dp[0] = 0;
            dp[1] = Math.Abs(h[1] - h[0]);
            for (int i = 0; i < nk[0]; i++)
            {
                for (int j = 1; j <= nk[1]; j++)
                {
                    if (i - j < 0) continue;
                    dp[i] = Math.Min(dp[i], dp[i - j] + Math.Abs(h[i] - h[i - j]));
                }
            }
            Console.WriteLine(dp[nk[0] - 1]);
        }
        public static void educational_DP_C()
        {
            var N = int.Parse(Console.ReadLine());
            var A = new int[N, 3];
            var dp = new long[N, 3];
            for (int i = 0; i < N; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                A[i, 0] = read[0];
                A[i, 1] = read[1];
                A[i, 2] = read[2];
            }
            dp[0, 0] = A[0, 0];
            dp[0, 1] = A[0, 1];
            dp[0, 2] = A[0, 2];
            for (int i = 0; i < N - 1; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (j == k) continue;
                        dp[i + 1, k] = Math.Max(dp[i + 1, k], dp[i, j] + A[i + 1, k]);
                    }

                }
            }
            long ans = 0;
            for (int i = 0; i < 3; i++)
            {
                ans = Math.Max(ans, dp[N - 1, i]);
            }
            Console.WriteLine(ans);
        }
        public static void educational_DP_D()
        {
            var nw = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = nw[0];
            int W = nw[1];
            var A = new (long, long)[N + 1];
            for (int i = 0; i < N; i++)
            {
                var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
                A[i + 1].Item1 = read[0];
                A[i + 1].Item2 = read[1];
            }
            var dp = new long[N + 1, W + 1];
            for (int i = 1; i <= N; i++)
            {
                for (int j = 0; j <= W; j++)
                {
                    if (j >= A[i].Item1)
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i - 1, j - A[i].Item1] + A[i].Item2);
                    }
                    else
                    {
                        dp[i, j] = dp[i - 1, j];
                    }
                }
            }

            Console.WriteLine(dp[N, W]);
        }
        public static void educational_DP_E()
        {
            var nw = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long n = nw[0];
            long w = nw[1];
            var dp = new long[n + 1, 100001];
            var A = new (long, long)[n + 1];
            for (int i = 1; i < n + 1; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                A[i].Item1 = read[0];
                A[i].Item2 = read[1];
            }
            for (int i = 0; i < n + 1; i++)
            {
                for (int j = 0; j < 100001; j++)
                {
                    dp[i, j] = longMax;
                }
            }
            dp[0, 0] = 0;
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 0; j < 100001; j++)
                {
                    if (j - A[i].Item2 >= 0) dp[i, j] = Math.Min(dp[i - 1, j], dp[i - 1, j - A[i].Item2] + A[i].Item1);
                    else dp[i, j] = dp[i - 1, j];
                }
            }

            int ans = 100000;
            while (dp[n, ans] > w) ans--;
            Console.WriteLine(ans);
        }
        public static void ABC178_D()
        {
            int S = int.Parse(Console.ReadLine());
            var dp = new long[2001];
            for (int i = 0; i < 2001; i++)
            {
                dp[i] = 1;
            }
            dp[0] = 1;
            dp[1] = 0;
            dp[2] = 0;
            for (int i = 3; i <= S; i++)
            {
                dp[i] = (dp[i - 1] + dp[i - 3]) % 1000000007;
            }
            Console.WriteLine(dp[S]);
        }
        public static void educational_DP_F()
        {
            var read1 = " " + Console.ReadLine();
            var read2 = " " + Console.ReadLine();

            var dp = new int[read1.Length + 1, read2.Length + 1];

            for (int i = 1; i < read1.Length; i++)
            {
                for (int j = 1; j < read2.Length; j++)
                {
                    if (read1[i] == read2[j])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    }
                    else if (dp[i - 1, j] >= dp[i, j - 1])
                    {
                        dp[i, j] = dp[i - 1, j];
                    }
                    else
                    {
                        dp[i, j] = dp[i, j - 1];
                    }
                }
            }
            int len = dp[read1.Length - 1, read2.Length - 1];
            var ans = new char[len];
            var len1 = read1.Length - 1;
            var len2 = read2.Length - 1;
            while (len > 0)
            {
                if (read1[len1] == read2[len2])
                {
                    ans[len - 1] = read1[len1];
                    len1--;
                    len2--;
                    len--;
                }
                else if (dp[len1, len2] == dp[len1 - 1, len2])
                {
                    len1--;
                }
                else
                {
                    len2--;
                }
            }
            Console.WriteLine(new String(ans));
        }
        public static void educational_DP_G()
        {
            var nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var graph = new List<int>[nm[0]];
            var visited = new int[nm[0]];
            for (int i = 0; i < nm[0]; i++)
            {
                graph[i] = new List<int>();
            }
            for (int i = 0; i < nm[1]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                graph[read[0] - 1].Add(read[1] - 1);
            }
            var dp = new int[nm[0]];
            for (int i = 0; i < nm[0]; i++)
            {
                dp[i] = -1;
            }
            int func(int x)
            {
                if (dp[x] != -1) return dp[x];
                int ret = 0;
                foreach (var i in graph[x])
                {
                    ret = Math.Max(ret, func(i) + 1);
                }
                return dp[x] = ret;
            }
            int ans = 0;
            for (int i = 0; i < nm[0]; i++)
            {
                ans = Math.Max(ans, func(i));
            }
            Console.WriteLine(ans);
        }
        public static void educational_DP_J()
        {
            int n = int.Parse(Console.ReadLine());
            var sushi = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var dp = new double[n + 2, n + 2, n + 2];
            var cnt = new int[4];
            for (int i = 0; i < sushi.Length; i++)
            {
                cnt[sushi[i]]++;
            }
            for (int k = 0; k < n + 1; k++)
            {
                for (int j = 0; j < n + 1; j++)
                {
                    for (int i = 0; i < n + 1; i++)
                    {
                        int sum = i + j + k;
                        if (sum == 0) continue;
                        dp[i, j, k] = 1 * n / (double)sum;
                        if (i != 0) dp[i, j, k] += dp[i - 1, j, k] * i / (double)sum;
                        if (j != 0) dp[i, j, k] += dp[i + 1, j - 1, k] * j / (double)sum;
                        if (k != 0) dp[i, j, k] += dp[i, j + 1, k - 1] * k / (double)sum;

                    }
                }
            }
            Console.WriteLine(dp[cnt[1], cnt[2], cnt[3]]);


        }
        public static void educational_DP_K()
        {
            var nk = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var dp = new bool[nk[1] + 1];
            for (int i = 0; i <= nk[1]; i++)
            {
                int lose = 0;
                int cnt = 0;
                for (int j = 0; j < nk[0]; j++)
                {

                    if (i >= a[j])
                    {
                        cnt++;
                        if (dp[i - a[j]] == false) lose++;
                    }
                }
                if (cnt == 0) dp[i] = false;
                else if (lose > 0) dp[i] = true;
                else dp[i] = false;
            }
            if (dp[nk[1]]) Console.WriteLine("First");
            else Console.WriteLine("Second");

        }
        public static void educational_DP_L()
        {
            int N = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var visited = new int[N, N];
            var dp = new long[N, N];
            long rec(int l, int r, int turn)
            {
                if (l > r) return 0;
                if (visited[l, r] != 0) return dp[l, r];
                visited[l, r] = 1;
                long ret = 0;
                if (turn == 0)
                {
                    ret = -longMax;
                    ret = Math.Max(ret, rec(l + 1, r, 1) + a[l]);
                    ret = Math.Max(ret, rec(l, r - 1, 1) + a[r]);
                }
                else
                {
                    ret = longMax;
                    ret = Math.Min(ret, rec(l + 1, r, 0) - a[l]);
                    ret = Math.Min(ret, rec(l, r - 1, 0) - a[r]);

                }
                return dp[l, r] = ret;
            }
            rec(0, N - 1, 0);
            Console.WriteLine(dp[0, N - 1]);
        }
        public static void educational_DP_M()
        {
            var nk = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nk[0];
            int k = nk[1];
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var dp = new long[n, k + 1];
            dp[0, 0] = 1;
            var sum = new long[k + 1];
            sum[0] = 1;
            int mod = 1000000007;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    sum[j + 1] = (sum[j + 1] + sum[j]) % mod;
                }
                for (int j = k; j >= a[i] + 1; j--)
                {
                    sum[j] = (sum[j] - sum[j - a[i] - 1]) % mod;
                }
            }
            if (sum[k] < 0) sum[k] += mod;
            Console.WriteLine(sum[k]);
        }
        /// <summary>
        /// DP 和の通り数数え上げ
        /// </summary>
        public static void typical_dp_A()
        {
            var n = int.Parse(Console.ReadLine());
            var p = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var dp = new int[101, 100001];
            dp[0, 0] = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 100001; j++)
                {
                    dp[i + 1, j] = dp[i, j];
                    if (j >= p[i]) dp[i + 1, j] |= dp[i, j - p[i]];
                }
            }
            int sum = 0;
            for (int i = 0; i < 100001; i++)
            {
                if (dp[n, i] > 0) sum++;
            }
            Console.WriteLine(sum);
        }
        /// <summary>
        /// DP ゲーム
        /// </summary>
        public static void typical_dp_B()
        {
            var ab = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var b = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var dp = new int[ab[0] + 1, ab[1] + 1];
            for (int i = 0; i <= ab[0]; i++)
            {
                for (int j = 0; j <= ab[1]; j++)
                {
                    if ((ab[0] + ab[1] - i - j) % 2 == 0)
                    {
                        dp[i, j] = Math.Max(i > 0 ? dp[i - 1, j] + a[ab[0] - i] : 0, j > 0 ? dp[i, j - 1] + b[ab[1] - j] : 0);
                    }
                    else
                    {
                        if (i == 0 && j == 0) continue;
                        dp[i, j] = Math.Min(i > 0 ? dp[i - 1, j] : intMax, j > 0 ? dp[i, j - 1] : intMax);
                    }

                }
            }
            Console.WriteLine(dp[ab[0], ab[1]]);

        }
        /// <summary>
        /// 区DP　slime
        /// </summary>
        public static void educational_DP_N()
        {
            int N = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var sum = new long[N + 1];
            var dp = new long[N + 1, N + 1];
            for (int i = 0; i < N; i++)
            {
                sum[i + 1] = sum[i] + a[i];
            }
            for (int i = 0; i < dp.GetLength(0); i++)
            {
                for (int j = 0; j < dp.GetLength(1); j++)
                {
                    dp[i, j] = 0;
                }
            }
            for (int bet = 1; bet < N; bet++)
            {
                for (int l = 0; l < N - bet; l++)
                {
                    long temp = longMax;
                    for (int k = l; k < l + bet; k++)
                    {
                        //区間の合成に利用された最小コストを取得
                        temp = Math.Min(temp, dp[l, k] + dp[k + 1, l + bet]);
                    }
                    dp[l, l + bet] = temp + sum[l + bet + 1] - sum[l];
                }
            }

            Console.WriteLine(dp[0, N - 1]);


        }
        /// <summary>
        /// DP
        /// </summary>
        public static void ABC040_C()
        {
            int N = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var dp = new long[N];
            for (int i = 1; i < N; i++)
            {
                if (i >= 2)
                {
                    dp[i] = Math.Min(dp[i - 1] + Math.Abs(a[i] - a[i - 1]), dp[i - 2] + Math.Abs(a[i] - a[i - 2]));
                }
                else
                {
                    dp[i] = Math.Abs(a[1] - a[0]);
                }
            }
            Console.WriteLine(dp[N - 1]);
        }
        /// <summary>
        /// DP
        /// </summary>
        public static void ABC129_C()
        {
            var nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var stairs = new bool[nm[0] + 1];
            for (int i = 0; i < nm[1]; i++)
            {
                var temp = int.Parse(Console.ReadLine());
                stairs[temp] = true;
            }
            var dp = new long[nm[0] + 1];
            var mod = 1000000007;
            dp[0] = 1;
            for (int i = 1; i <= nm[0]; i++)
            {
                if (i < 2)
                {
                    if (!stairs[i]) dp[1] = 1;
                }
                else
                {
                    if (!stairs[i])
                    {
                        if (!stairs[i - 1] && !stairs[i - 2])
                        {
                            dp[i] = (dp[i - 1] + dp[i - 2]) % mod;
                        }
                        else if (!stairs[i - 1])
                        {
                            dp[i] = dp[i - 1] % mod;
                        }
                        else
                        {
                            dp[i] = dp[i - 2] % mod;
                        }
                    }
                    else
                    {
                        dp[i] = 0;
                    }
                }
            }
            Console.WriteLine(dp[nm[0]] % mod);
        }
        /// <summary>
        /// 累積和
        /// </summary>
        public static void ABC099_C()
        {
            int N = int.Parse(Console.ReadLine());
            var dp = new int[100001];

            for (int i = 0; i < 100001; i++)
            {
                dp[i] = intMax;
            }
            dp[0] = 0;
            dp[1] = 1;
            for (int i = 1; i < 100001; i++)
            {
                for (int k = 1; Math.Pow(6, k) <= i; k++)
                {
                    dp[i] = Math.Min(dp[i], dp[i - (int)Math.Round(Math.Pow(6, k), 0)] + 1);
                }
                for (int k = 1; Math.Pow(9, k) <= i; k++)
                {
                    dp[i] = Math.Min(dp[i], dp[i - (int)Math.Round(Math.Pow(9, k), 0)] + 1);
                }
                dp[i] = Math.Min(dp[i], dp[i - 1] + 1);
            }
            Console.WriteLine(dp[N]);
        }
        public static void ABC037_C()
        {
            var nk = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var sum = new long[nk[0] + 1];
            for (int i = 0; i < nk[0]; i++)
            {
                sum[i + 1] = sum[i] + a[i];
            }
            long ans = 0;
            for (int i = 0; i < nk[0] - nk[1] + 1; i++)
            {
                ans += sum[i + nk[1]] - sum[i];
            }
            Console.WriteLine(ans);
        }
        public static void typical_dp_C()
        {
            int K = int.Parse(Console.ReadLine());
            var R = new int[(int)Math.Pow(2, K)];
            for (int i = 0; i < Math.Pow(2, K); i++)
            {
                R[i] = int.Parse(Console.ReadLine());
            }
            var dp = new double[(int)Math.Pow(2, K) + 1, K + 1];
            for (int i = 0; i < 1 << K; i++)
            {
                dp[i, 0] = 1;
            }

            for (int j = 0; j < K; j++)
            {
                for (int i = 0; i < 1 << K; i++)
                {
                    double p = 0;
                    for (int l = 0; l < 1 << j; l++)
                    {
                        int candidate = ((i ^ 1 << j) & ~((1 << j) - 1)) + l;
                        p += dp[candidate, j] * 1.0 / (1 + Math.Pow(10.0, (R[candidate] - R[i]) / 400.0));
                    }
                    dp[i, j + 1] = p * dp[i, j];

                }
            }
            for (int i = 0; i < 1 << K; i++)
            {
                Console.WriteLine("{0:f9}", dp[i, K]);
            }
        }
        public static void typical_dp_D()
        {
            var nd = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long n = nd[0];
            long d = nd[1];
            int l = 0;
            int m = 0;
            int k = 0;
            double ans = 0;
            var dp = new double[2, 70, 70, 70];
            while (d % 2 == 0)
            {
                l++;
                d /= 2;
            }
            while (d % 3 == 0)
            {
                m++;
                d /= 3;
            }
            while (d % 5 == 0)
            {
                k++;
                d /= 5;
            }
            if (d > 1)
            {
                ans = 0.0;
                Console.WriteLine(ans);
                return;
            }
            dp[0, 0, 0, 0] = 1.0;
            for (int i = 0; i < n; i++)
            {
                int cur = i % 2;
                int tar = 1 ^ cur;
                for (int x = 0; x < 70; x++)
                {
                    for (int y = 0; y < 50; y++)
                    {
                        for (int z = 0; z < 40; z++)
                        {
                            if (x == 0 && y == 0 && z == 0)
                            {
                                //dp[tar, x, y, z] = 1;
                                //continue;
                            }
                            dp[tar, x, y, z] = 0;
                        }
                    }
                }
                for (int x = 0; x < 70; x++)
                {
                    for (int y = 0; y < 50; y++)
                    {
                        for (int z = 0; z < 40; z++)
                        {
                            if (dp[cur, x, y, z] == 0) continue;
                            dp[tar, x, y, z] += dp[cur, x, y, z] / 6.0;
                            dp[tar, Math.Min(69, x + 1), y, z] += dp[cur, x, y, z] / 6.0;
                            dp[tar, x, Math.Min(49, y + 1), z] += dp[cur, x, y, z] / 6.0;
                            dp[tar, Math.Min(69, x + 2), y, z] += dp[cur, x, y, z] / 6.0;
                            dp[tar, x, y, Math.Min(39, z + 1)] += dp[cur, x, y, z] / 6.0;
                            dp[tar, Math.Min(69, x + 1), Math.Min(49, y + 1), z] += dp[cur, x, y, z] / 6.0;

                        }
                    }
                }
            }
            for (int x = l; x < 70; x++)
            {
                for (int y = m; y < 50; y++)
                {
                    for (int z = k; z < 40; z++)
                    {
                        ans += dp[n % 2, x, y, z];
                    }
                }
            }
            Console.WriteLine(ans);

        }
        public static void typical_dp_E()
        {
            int D = int.Parse(Console.ReadLine());
            var N = Console.ReadLine().ToCharArray();
            var mod = 1000000007;
            var dp = new long[10005, 105, 2];
            dp[0, 0, 0] = 1;
            for (int i = 1; i <= N.Length; i++)
            {
                for (int j = 0; j < D; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        int now = N[i - 1] - '0';
                        if (now > k)
                        {
                            dp[i, (j + k) % D, 1] += (dp[i - 1, j, 0] + dp[i - 1, j, 1] % mod);
                            dp[i, (j + k) % D, 1] %= mod;
                        }
                        else if (now == k)
                        {
                            dp[i, (j + k) % D, 1] += dp[i - 1, j, 1];
                            dp[i, (j + k) % D, 0] += dp[i - 1, j, 0];
                            dp[i, (j + k) % D, 1] %= mod;
                            dp[i, (j + k) % D, 0] %= mod;
                        }
                        else
                        {
                            dp[i, (j + k) % D, 1] += dp[i - 1, j, 1];
                            dp[i, (j + k) % D, 1] %= mod;
                        }
                    }
                }
            }
            long ans = (dp[N.Length, 0, 0] + dp[N.Length, 0, 1] - 1 + mod) % mod;
            Console.WriteLine(ans);
        }
        public static void ABC029_D()
        {
            var N = Console.ReadLine().ToCharArray();
            var dp = new long[N.Length, N.Length + 1, 2];
            if (N[0] == '1')
            {
                dp[0, 1, 0] = 1;
                dp[0, 0, 1] = 1;
            }
            else
            {
                dp[0, 0, 0] = 1;
                dp[0, 1, 1] = 1;
                dp[0, 0, 1] = N[0] - '0' - 1;
            }
            for (int i = 0; i < N.Length - 1; i++)
            {
                int now = N[i + 1] - '0';
                for (int j = 0; j < N.Length; j++)
                {
                    if (now == 1)
                    {
                        dp[i + 1, j + 1, 0] += dp[i, j, 0];
                        dp[i + 1, j, 1] += dp[i, j, 0];
                    }
                    else
                    {
                        dp[i + 1, j, 0] += dp[i, j, 0];
                        if (now > 1)
                        {
                            dp[i + 1, j, 1] += (now - 1) * dp[i, j, 0];
                            dp[i + 1, j + 1, 1] += dp[i, j, 0];
                        }
                    }
                    dp[i + 1, j + 1, 1] += dp[i, j, 1];
                    dp[i + 1, j, 1] += dp[i, j, 1] * 9;
                }

            }
            long ans = 0;
            for (long i = 1; i <= N.Length; i++)
            {
                ans += i * (dp[N.Length - 1, i, 0] + dp[N.Length - 1, i, 1]);

            }
            Console.WriteLine(ans);
        }
        public static void ABC007_D()
        {
            var AB = Console.ReadLine().Split().Select(long.Parse).ToArray();

            var A = AB[0];
            var B = AB[1];

            long count(long x)
            {
                string strX = Convert.ToString(x);
                var dp = new long[strX.Length + 1, 2];
                dp[0, 0] = 1;
                for (int i = 0; i < strX.Length; i++)
                {
                    long count = 0;
                    for (int j = 0; j < 9; j++)
                    {
                        if (j == 4) continue;
                        if (j < strX[i] - '0') count++;
                    }
                    if (strX[i] == '4' || strX[i] == '9')
                    {
                        dp[i + 1, 0] = 0;
                    }
                    else
                    {
                        dp[i + 1, 0] = dp[i, 0];
                    }
                    dp[i + 1, 1] = count * dp[i, 0] + 8 * dp[i, 1];
                }
                return dp[strX.Length, 0] + dp[strX.Length, 1];
            }
            long ans = B - A + 1 - (count(B) - count(A - 1));
            Console.WriteLine(ans);
        }
        public static void ABC117_D()
        {
            var nk = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var A = new long[nk[0]];
            A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            int maxD = 5;
            var dp = new long[100, 2];
            for (int i = 0; i < dp.GetLength(0); i++)
            {
                for (int j = 0; j < dp.GetLength(1); j++)
                {
                    dp[i, j] = -1;
                }
            }
            dp[0, 0] = 0;
            for (int d = 0; d < maxD; d++)
            {
                long mask = (long)1 << (maxD - d - 1);
                int count = 0;
                for (int i = 0; i < nk[0]; i++)
                {
                    if ((A[i] & mask) > 0) count++;
                }
                long cost0 = mask * count;
                long cost1 = mask * (nk[0] - count);

                if (dp[d, 1] != -1)
                {
                    dp[d + 1, 1] = Math.Max(dp[d + 1, 1], dp[d, 1] + Math.Max(cost0, cost1));
                }

                if (dp[d, 0] != -1)
                {
                    if ((nk[1] & mask) > 0)
                    {
                        dp[d + 1, 1] = Math.Max(dp[d + 1, 1], dp[d, 0] + cost0);
                    }
                }

                if (dp[d, 0] != -1)
                {
                    if ((nk[1] & mask) > 0)
                    {
                        dp[d + 1, 0] = Math.Max(dp[d + 1, 0], dp[d, 0] + cost1);
                    }
                    else
                    {
                        dp[d + 1, 0] = Math.Max(dp[d + 1, 0], dp[d, 0] + cost0);
                    }
                }
            }
            Console.WriteLine(Math.Max(dp[maxD, 0], dp[maxD, 1]));
        }
        //TODO
        public static void JOI10_E()
        {
            var hwn = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int H = hwn[0];
            int W = hwn[1];
            int N = hwn[2];
            var fields = new char[H, W];

        }
        public static void educational_DP_S()
        {
            var k = Console.ReadLine().ToCharArray();
            int D = int.Parse(Console.ReadLine());
            var dp = new long[k.Length + 1, D + 1, 2];
            long mod = 1000000007;
            /*for(int i = 0; i < k[0] - '0'; i++)
            {
                dp[0, i, 1]++;
            }
            dp[0,k[0] - '0', 0] = 1;*/
            dp[0, 0, 0] = 1;

            for (int i = 0; i < k.Length; i++)
            {
                int now = k[i] - '0';
                for (int j = 0; j < D; j++)
                {
                    for (int x = 0; x < 10; x++)
                    {
                        if (x > now)
                        {
                            dp[i + 1, (j + x) % D, 1] += dp[i, j, 1];
                            dp[i + 1, (j + x) % D, 1] %= mod;

                        }
                        else if (x == now)
                        {
                            dp[i + 1, (j + x) % D, 1] += dp[i, j, 1];
                            dp[i + 1, (j + x) % D, 1] %= mod;
                            dp[i + 1, (j + x) % D, 0] += dp[i, j, 0];
                            dp[i + 1, (j + x) % D, 0] %= mod;
                        }
                        else
                        {
                            dp[i + 1, (j + x) % D, 1] += dp[i, j, 0];
                            dp[i + 1, (j + x) % D, 1] %= mod;
                            dp[i + 1, (j + x) % D, 1] += dp[i, j, 1];
                            dp[i + 1, (j + x) % D, 1] %= mod;
                        }
                    }
                }
            }
            long ans = dp[k.Length, 0, 1] + dp[k.Length, 0, 0];
            Console.WriteLine((ans - 1 + mod) % mod);
        }
        public static void educational_DP_P()
        {

            int N = int.Parse(Console.ReadLine());
            var graph = new List<int>[N];
            var dp = new long[N, 2];
            long mod = 1000000007;
            for (int i = 0; i < graph.Length; i++)
            {
                graph[i] = new List<int>();
            }
            for (int i = 0; i < N - 1; i++)
            {
                var xy = Console.ReadLine().Split().Select(int.Parse).ToArray();
                graph[xy[0] - 1].Add(xy[1] - 1);
                graph[xy[1] - 1].Add(xy[0] - 1);
            }
            void dfs(int now, int p = -1)
            {
                dp[now, 0] = dp[now, 1] = 1;
                foreach (var to in graph[now])
                {
                    if (to != p)
                    {
                        dfs(to, now);
                        dp[now, 0] *= ((dp[to, 0] + dp[to, 1]) % mod);
                        dp[now, 0] %= mod;
                        dp[now, 1] *= dp[to, 0];
                        dp[now, 1] %= mod;
                    }
                }
            }
            dfs(0);
            long ans = (dp[0, 1] + dp[0, 0]) % mod;
            Console.WriteLine(ans);
        }
        public static void ABC036_D()
        {
            int N = int.Parse(Console.ReadLine());
            var graph = new List<int>[N];
            for (int i = 0; i < graph.Length; i++)
            {
                graph[i] = new List<int>();
            }
            long mod = 1000000007;
            for (int i = 0; i < N - 1; i++)
            {
                var ab = Console.ReadLine().Split().Select(int.Parse).ToArray();
                graph[ab[0] - 1].Add(ab[1] - 1);
                graph[ab[1] - 1].Add(ab[0] - 1);
            }
            var dp = new long[N, 2];
            void dfs(int now, int pre)
            {
                dp[now, 0] = dp[now, 1] = 1;
                foreach (var next in graph[now])
                {
                    if (next == pre) continue;
                    dfs(next, now);
                    dp[now, 0] *= ((dp[next, 0] + dp[next, 1]) % mod);
                    dp[now, 0] %= mod;
                    dp[now, 1] *= dp[next, 0];
                    dp[now, 1] %= mod;
                }
            }
            dfs(0, -1);
            long ans = (dp[0, 0] + dp[0, 1]) % mod;
            Console.WriteLine(ans);
        }
        public static void typical_dp_N()
        {
            int N = int.Parse(Console.ReadLine());
            var graph = new List<int>[N];
            long mod = 1000000007;
            for (int i = 0; i < N; i++)
            {
                graph[i] = new List<int>();
            }
            var dp = new ValueTuple<long, long>[N];
            for (int i = 0; i < N - 1; i++)
            {
                var ab = Console.ReadLine().Split().Select(int.Parse).ToArray();
                graph[ab[0] - 1].Add(ab[1] - 1);
                graph[ab[1] - 1].Add(ab[0] - 1);
            }
            var visited = new int[N];
            ValueTuple<long, long> dfs(int now)
            {
                visited[now] = 1;
                var s = new Stack<ValueTuple<long, long>>();
                foreach (var next in graph[now])
                {
                    if (visited[next] != 1)
                    {
                        s.Push(dfs(next));
                    }
                }
                ValueTuple<long, long> ret = ValueTuple.Create(1, 0);
                if (s.Count() != 0)
                {
                    foreach (var a in s)
                    {
                        ret.Item1 *= a.Item1;
                        ret.Item1 %= mod;
                        Comb comb = new Comb((int)a.Item2);
                        ret.Item1 *= comb.fact_inv((int)a.Item2);
                        ret.Item1 %= mod;
                        ret.Item2 += a.Item2;
                    }
                    Comb combRet = new Comb((int)ret.Item2);
                    ret.Item1 *= combRet.fact((int)ret.Item2) % mod;
                }
                ret.Item2 += 1;
                return ret;
            }
            long ans = 0;
            for (int i = 0; i < N; i++)
            {
                ans += dfs(i).Item1;
                ans %= mod;
                visited = Enumerable.Repeat(0, N).ToArray();
            }
            Console.WriteLine(ans / 2);
        }
        public static void ABC219_A()
        {
            int X = int.Parse(Console.ReadLine());
            if (X >= 90)
            {
                Console.WriteLine("expert");
            }
            else if (X < 90 && X >= 70)
            {
                Console.WriteLine(90 - X);
            }
            else if (X < 70 && X >= 40)
            {
                Console.WriteLine(70 - X);
            }
            else if (X < 40)
            {
                Console.WriteLine(40 - X);
            }
        }
        public static void ABC219_B()
        {
            var S = new string[3];
            S[0] = Console.ReadLine();
            S[1] = Console.ReadLine();
            S[2] = Console.ReadLine();
            var a = Console.ReadLine().ToCharArray();
            string ans = "";
            for (int i = 0; i < a.Length; i++)
            {
                ans += S[a[i] - '0' - 1];
            }
            Console.WriteLine(ans);


        }
        public static void ABC219_C()
        {
            var S = Console.ReadLine();
            int N = int.Parse(Console.ReadLine());
            var name = new string[N];
            var list = new List<string>();
            var alphabet = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < N; i++)
            {
                name[i] = Console.ReadLine();
                var tempchar = name[i].ToCharArray();
                String temp = "";
                for (int j = 0; j < tempchar.Length; j++)
                {
                    int index = S.IndexOf(tempchar[j]);
                    temp += alphabet[index];
                }
                list.Add(temp);
            }
            list.Sort();
            foreach (var s in list)
            {
                string temp = "";
                foreach (var t in s)
                {
                    temp += S[alphabet.IndexOf(t)];
                }
                Console.WriteLine(temp);
            }
        }
        public static void ABC219_D()
        {
            int N = int.Parse(Console.ReadLine());
            var xy = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var ab = new int[N + 1, 2];

            for (int i = 1; i <= N; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();

                ab[i, 0] = read[0];
                ab[i, 1] = read[1];
            }
            //dp[i, j, k]・・・i 番目の弁当までで j個のたこ焼きとk個のたい焼きを購入しているときの最小の弁当の購入数
            var dp = new int[N + 1, 301, 301];
            for (int i = 0; i < dp.GetLength(0); i++)
            {
                for (int j = 0; j < dp.GetLength(1); j++)
                {
                    for (int k = 0; k < dp.GetLength(2); k++)
                    {
                        dp[i, j, k] = intMax;
                    }

                }
            }
            dp[0, 0, 0] = 0;//0番目の弁当ではたこ焼きもタイ焼きも０個で弁当の購入数ももちろん０

            for (int now = 1; now < dp.GetLength(0); now++)
            {
                for (int j = 0; j < dp.GetLength(1); j++)
                {
                    for (int k = 0; k < dp.GetLength(2); k++)
                    {
                        //now番目の弁当を買うときの遷移
                        dp[now, Math.Min(xy[0], j + ab[now, 0]), Math.Min(xy[1], k + ab[now, 1])] = Math.Min(dp[now, Math.Min(xy[0], j + ab[now, 0]), Math.Min(xy[1], k + ab[now, 1])], dp[now - 1, j, k] + 1);
                        //now番目の弁当を買わないときの遷移
                        dp[now, j, k] = Math.Min(dp[now, j, k], dp[now - 1, j, k]);
                    }
                }
            }

            if (dp[N, xy[0], xy[1]] == intMax)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(dp[N, xy[0], xy[1]]);
            }

        }
        public static void ABC126_C()
        {
            var nk = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var P = new double[nk[0]];
            for (int i = 0; i < nk[0]; i++)
            {
                int temp = i + 1;
                double tempP = 1 / (double)nk[0];
                while (temp < nk[1])
                {
                    temp *= 2;
                    tempP /= 2;
                }
                P[i] = tempP;
            }
            double sum = P.Sum();
            Console.WriteLine(sum);
        }
        public static void ABC127_C()
        {
            var nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var id = new (int, int)[nm[1]];
            var cards = new int[nm[0] + 2];
            for (int i = 0; i < nm[1]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                id[i].Item1 = read[0];
                id[i].Item2 = read[1];
                cards[id[i].Item1] += 1;
                cards[id[i].Item2 + 1] = -1;
            }

            for (int i = 1; i < nm[0] + 1; i++)
            {
                cards[i] += cards[i - 1];
            }
            var ans = 0;
            for (int i = 0; i < cards.Length; i++)
            {
                if (cards[i] == nm[1]) ans++;
            }
            Console.WriteLine(ans);
        }
        public static void ABC128_B()
        {
            int N = int.Parse(Console.ReadLine());
            var list = new Dictionary<string, List<(int, int)>>();
            for (int i = 0; i < N; i++)
            {
                var read = Console.ReadLine().Split();
                if (!list.ContainsKey(read[0]))
                {
                    list[read[0]] = new List<(int, int)>();
                    list[read[0]].Add((int.Parse(read[1]), i));
                }
                else
                {
                    list[read[0]].Add((int.Parse(read[1]), i));
                }
            }
            foreach (var l in list.OrderBy(c => c.Key))
            {
                foreach (var v in l.Value.OrderByDescending(c => c.Item1))
                {
                    Console.WriteLine(v.Item2 + 1);
                }
            }
        }
        public static void ABC130_C()
        {
            var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            double area = 0;
            bool multi = false;
            area = (double)read[0] * read[1] / 2;


            if (read[2] * 2 == read[0] && read[3] * 2 == read[1]) multi = true;

            if (multi)
            {
                Console.WriteLine($"{area:F6} {1}");
            }
            else
            {
                Console.WriteLine($"{area:F6} {0}");
            }
        }
        public static void ABC130_D()
        {
            var nk = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int r = 0;
            long ans = 0;
            long sum = 0;
            for (int i = 0; i < nk[0]; i++)
            {
                while (sum < nk[1])
                {
                    if (r == nk[0]) break;
                    else
                    {
                        sum += a[r];
                        r++;
                    }
                }
                if (sum < nk[1]) break;
                ans += (nk[0] - r + 1);
                sum -= a[i];
            }
            Console.WriteLine(ans);
        }
        /// <summary>
        /// ユークリッド互除法　最大公約数
        /// </summary>
        public static void ABC131_C()
        {
            var abcd = Console.ReadLine().Split().Select(long.Parse).ToArray();

            long num(long A, long C, long D)
            {
                var aNc = Math.Floor((decimal)A / C);
                var aNd = Math.Floor((decimal)A / D);

                long tempC = C;
                long tempD = D;

                long r = tempD % tempC;
                while (r != 0)
                {
                    tempD = tempC;
                    tempC = r;
                    r = tempD % tempC;
                }
                var CD = Math.Floor(((decimal)C * D) / tempC);

                var acd = Math.Floor((decimal)A / CD);
                var ret = A - aNc - aNd + acd;
                return (long)ret;
            }
            long ans = num(abcd[1], abcd[2], abcd[3]) - num(abcd[0] - 1, abcd[2], abcd[3]);
            Console.WriteLine(ans);
        }
        public static void ARC114_A()
        {
            int N = int.Parse(Console.ReadLine());
            var x = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var list = new List<long>();
            var prime = new long[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47 };
            long ans = longMax;
            for (long i = 0; i < 1 << prime.Length; i++)
            {
                var bit = new bool[prime.Length];
                var check = new bool[x.Length];
                for (int j = 0; j < prime.Length; j++)
                {
                    if (((i >> j) & 1) == 1) bit[j] = true;
                }
                long temp = 1;
                for (int j = 0; j < prime.Length; j++)
                {
                    if (bit[j]) temp *= prime[j];
                }
                for (int j = 0; j < x.Length; j++)
                {
                    for (int k = 0; k < prime.Length; k++)
                    {
                        if (x[j] % prime[k] == 0 && temp % prime[k] == 0)
                        {
                            check[j] = true;
                            break;
                        }
                    }
                }
                for (int j = 0; j < check.Length; j++)
                {
                    if (!check[j]) break;
                    else if (j == check.Length - 1) ans = Math.Min(ans, temp);
                }
            }
            Console.WriteLine(ans);

        }
        public static void ARC109_B()
        {
            long n = long.Parse(Console.ReadLine());
            long r = 2 * 1000000000;
            long l = 0;
            while (r - l > 1)
            {
                long mid = (l + r) / 2;
                long sum = (mid * (mid + 1)) / 2;
                if (sum > n + 1)
                {
                    r = mid;
                }
                else
                {
                    l = mid;
                }
            }
            long ans = n - l + 1;
            Console.WriteLine(ans);
        }
        public static void ARC122_C()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var dp = new long[N, 2];
            dp[0, 0] = dp[0, 1] = A[0];
            for (int i = 1; i < N; i++)
            {
                dp[i, 0] = dp[i - 1, 1] - A[i];

            }
        }
        public static void ARC126_A()
        {
            long N = long.Parse(Console.ReadLine());
            var test = new (long, long, long)[N];
            for (int i = 0; i < N; i++)
            {
                var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
                test[i].Item1 = read[0];
                test[i].Item2 = read[1];
                test[i].Item3 = read[2];
            }

            for (int i = 0; i < N; i++)
            {
                long ans = 0;
                //長さ3は偶数個しかつかえない
                if (test[i].Item2 % 2 != 0) test[i].Item2--;
                //長さ３×２＋長さ４
                if (test[i].Item2 >= test[i].Item3 * 2)
                {
                    ans += test[i].Item3;
                    test[i].Item2 -= test[i].Item3 * 2;
                    test[i].Item3 = 0;
                }
                else
                {
                    ans += test[i].Item2 / 2;
                    test[i].Item3 -= test[i].Item2 / 2;
                    test[i].Item2 %= 2;
                }
                //長さ２×２＋長さ３×２
                if (test[i].Item2 > 0)
                {
                    ans += Math.Min(test[i].Item1 / 2, test[i].Item2 / 2);
                    test[i].Item1 -= Math.Min(test[i].Item1, test[i].Item2);
                    test[i].Item2 -= Math.Min(test[i].Item1, test[i].Item2);
                }
                else if (test[i].Item3 > 0)
                {
                    //長さ４×２＋長さ２
                    if (test[i].Item3 >= test[i].Item1 * 2)
                    {
                        ans += test[i].Item1;
                        test[i].Item3 -= test[i].Item1 * 2;
                        test[i].Item1 = 0;
                    }
                    else
                    {
                        ans += test[i].Item3 / 2;
                        test[i].Item1 -= test[i].Item3 / 2;
                        test[i].Item3 %= 2;
                    }
                }
                //長さ２×３＋長さ４
                if (test[i].Item1 >= 3 && test[i].Item3 >= 1)
                {
                    ans += test[i].Item3;
                    test[i].Item1 -= test[i].Item3 * 3;
                    test[i].Item3 = 0;
                }
                //長さ２×５
                ans += test[i].Item1 / 5;
                Console.WriteLine(ans);
            }

        }
        public static void ARC104_A()
        {
            var ab = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int x = (ab[0] + ab[1]) / 2;
            int y = ab[0] - x;
            Console.WriteLine($"{x} {y}");

        }
        public static void ARC105_A()
        {
            var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long sum = read.Sum();
            var ok = false;
            for (int i = 0; i < 1 << 4; i++)
            {
                var bit = new bool[4];
                long eat = 0;
                for (int j = 0; j < 4; j++)
                {
                    if (((i >> j) & 1) == 1) bit[j] = true;
                }
                for (int j = 0; j < 4; j++)
                {

                    if (bit[j]) eat += read[j];
                }
                if (sum - eat == eat) ok = true;
            }
            if (ok) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
        //繰り返し二乗法
        public static void ARC106_A()
        {
            long N = long.Parse(Console.ReadLine());
            int A = 1;
            int ansA = 1;
            int ansB = 1;
            var ok = false;
            long pow(long x, int n)
            {
                long ret = 1;
                while (n > 0)
                {
                    if ((n & 1) > 0) ret *= x;
                    x *= x;
                    n = n >> 1;
                }
                return ret;
            }
            while (pow(3, A) <= N)
            {
                int B = 1;
                long sum = pow(3, A) + pow(5, B);
                while (pow(3, A) + pow(5, B) <= N)
                {
                    if (pow(3, A) + pow(5, B) == N)
                    {
                        ok = true;
                        ansA = A;
                        ansB = B;
                        break;
                    }
                    B++;
                }
                if (pow(3, A) + pow(5, B) == N)
                {
                    break;
                }
                A++;
            }
            if (ok) Console.WriteLine($"{ansA} {ansB}");
            else Console.WriteLine(-1);
        }
        public static void ARC107_A()
        {
            var abc = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long mod = 998244353;
            long sumC = ((abc[2] * (abc[2] + 1)) / 2) % mod;
            long sumB = ((abc[1] * (abc[1] + 1)) / 2) % mod;
            long sumA = ((abc[0] * (abc[0] + 1)) / 2) % mod;
            long ans = 1;
            ans = (sumC * sumB) % mod;
            ans *= sumA;
            ans %= mod;
            Console.WriteLine(ans);
        }
        public static void ARC104_B()
        {
            var ns = Console.ReadLine().Split();
            int N = int.Parse(ns[0]);
            String S = ns[1];
            int ans = 0;
            for (int i = 0; i < N; i++)
            {
                int countA = 0;
                int countC = 0;
                for (int j = i; j < N; j++)
                {
                    if (S[j] == 'A')
                    {
                        countA++;
                    }
                    else if (S[j] == 'T')
                    {
                        countA--;
                    }
                    else if (S[j] == 'C')
                    {
                        countC++;
                    }
                    else if (S[j] == 'G')
                    {
                        countC--;
                    }

                    if (countA == 0 && countC == 0)
                    {
                        ans++;
                    }

                }
            }
            Console.WriteLine(ans);

        }
        public static void ARC108_A()
        {
            var sp = Console.ReadLine().Split().Select(long.Parse).ToArray();
            bool ok = false;
            for (int i = 0; i < 10000000; i++)
            {
                if (i * (sp[0] - i) == sp[1])
                {
                    ok = true;
                    break;
                }
            }
            if (ok) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
        public static void ARC109_A()
        {
            var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int ans = 0;
            if (read[0] - read[1] == 1)
            {
                ans = read[2];
            }
            else if (read[2] * 2 < read[3] && read[1] >= read[0])
            {
                ans = Math.Abs(read[0] - read[1]) * read[2] * 2 + read[2];
            }
            else if (read[2] * 2 >= read[3] && read[1] >= read[0])
            {
                ans = Math.Abs(read[0] - read[1]) * read[3] + read[2];
            }
            else if (read[1] < read[0])
            {
                ans = Math.Min((read[0] - read[1] - 1) * 2 * read[2] + read[2], (read[0] - read[1] - 1) * read[3] + read[2]);
            }
            Console.WriteLine(ans);
        }
        public static void ARC110_A()
        {
            int N = int.Parse(Console.ReadLine());
            if (N == 2)
            {
                Console.WriteLine(3);
                return;
            }
            long s = 2;
            long ans = 0;
            for (int i = 3; i <= N; i++)
            {
                long tempA = s;
                long tempB = i;
                long r = tempA % tempB;
                while (r != 0)
                {
                    tempA = tempB;
                    tempB = r;
                    r = tempA % tempB;
                }
                ans = (s * i / tempB) + 1;
                s = ans - 1;
            }
            Console.WriteLine(ans);
        }
        public static void ARC112_A()
        {
            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                var lr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                long temp = lr[1] - 2 * lr[0] + 1;
                if (lr[0] == 0 && lr[1] == 0)
                {
                    Console.WriteLine(1);
                }
                else if (lr[0] == lr[1])
                {
                    Console.WriteLine(0);
                }
                else if (temp <= 0 || lr[1] + 1 < temp)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    long ans = (temp * (temp + 1)) / 2;
                    Console.WriteLine(ans);
                }
            }
        }
        public static void ARC113_A()
        {
            int K = int.Parse(Console.ReadLine());
            long ans = 0;
            for (int A = 1; A <= K; A++)
            {
                for (int B = 1; B <= K / A; B++)
                {
                    for (int C = 1; C <= K / (A * B); C++)
                    {
                        ans++;
                    }
                }
            }
            Console.WriteLine(ans);
        }
        public static void ARC116_A()
        {
            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                long N = long.Parse(Console.ReadLine());
                if (N % 2 == 1)
                {
                    Console.WriteLine("Odd");
                }
                else if (N % 4 == 0)
                {
                    Console.WriteLine("Even");
                }
                else if (N % 2 == 0)
                {
                    Console.WriteLine("Same");
                }

            }
        }
        public static void ARC117_A()
        {
            var AB = Console.ReadLine().Split().Select(int.Parse).ToArray();
            String seq = "";
            long sumA = 0;
            long sumB = 0;

            if (AB[0] > AB[1])
            {
                for (int i = 0; i < AB[0]; i++)
                {
                    seq += " " + (i + 1);
                    sumA += i + 1;
                }
                for (int i = 0; i < AB[1] - 1; i++)
                {
                    seq += " " + -(i + 1);
                    sumB -= (i + 1);
                }
                long temp = sumA + sumB;
                seq += " " + -temp;
                seq = seq.TrimStart(' ');
            }
            else if (AB[0] < AB[1])
            {
                for (int i = 0; i < AB[0] - 1; i++)
                {
                    seq += " " + (i + 1);
                    sumA += i + 1;
                }
                for (int i = 0; i < AB[1]; i++)
                {
                    seq += " " + -(i + 1);
                    sumB -= (i + 1);
                }
                long temp = sumA + sumB;
                seq += " " + (-temp);
                seq = seq.TrimStart(' ');
            }
            else
            {
                for (int i = 0; i < AB[0]; i++)
                {
                    seq += " " + (i + 1);
                }
                for (int i = 0; i < AB[0]; i++)
                {
                    seq += " " + -(i + 1);
                }
                seq = seq.TrimStart(' ');
            }
            Console.WriteLine(seq);
        }
        public static void ARC118_A()
        {
            var tN = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long t = tN[0];
            long N = tN[1];
            var not = new List<int>();
            int temp = 0;
            for (int i = 1; i <= 100; i++)
            {
                int a = (int)Math.Floor(i * (100 + t) / (double)100);
                if (a - temp > 1) not.Add(temp + 1);
                temp = a;
            }
            long M = N / not.Count();
            long index = N % not.Count();
            long ans = 0;

            if (N <= not.Count())
            {
                ans = not[(int)N - 1];
            }
            else if (index == 0)
            {
                ans = not[not.Count() - 1] + (100 + t) * (M - 1);
            }
            else
            {
                ans = not[(int)index - 1] + (100 + t) * (M);
            }
            Console.WriteLine(ans);
        }
        public static void ARC119_A()
        {
            long N = long.Parse(Console.ReadLine());
            long pow(long x, int n)
            {
                long ret = 1;
                while (n > 0)
                {
                    if ((n & 1) > 0) ret *= x;
                    x *= x;
                    n = n >> 1;
                }
                return ret;
            }
            long ans = longMax;
            int b = (int)Math.Log2(N);
            for (int i = b; 0 <= i; i--)
            {
                long a = N / pow(2, i);
                long c = N % (pow(2, i) * a);
                ans = Math.Min(ans, i + a + c);

            }
            Console.WriteLine(ans);
        }
        public static void ARC120_A()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long ans = 0;
            long sum = 0;
            long sumsum = 0;
            long max = 0;
            for (int i = 0; i < A.Length; i++)
            {
                max = Math.Max(max, A[i]);
                sum += A[i];
                sumsum += sum;
                ans = sumsum + max * (i + 1);
                Console.WriteLine(ans);
            }
        }
        public static void ARC123_A()
        {
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();

            long d = 2 * A[1] - A[0] - A[2];
            long ans = 0;

            if (d == 0)
            {
                ans = 0;
            }
            else if (d > 0)
            {
                ans = d;
            }
            else
            {
                if (-d % 2 == 0)
                {
                    ans = Math.Abs(d / 2);
                }
                else
                {
                    ans = Math.Abs((d - 1) / 2) + 1;
                }
            }

            Console.WriteLine(ans);

        }
        public static void ARC124_A()
        {
            var nk = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = nk[0];
            int K = nk[1];
            var lList = new List<(int, int)>();
            var rList = new List<(int, int)>();
            var card = new int[N];
            long mod = 998244353;
            for (int i = 0; i < K; i++)
            {
                var read = Console.ReadLine().Split();
                int num = int.Parse(read[1]) - 1;

                if (read[0] == "L")
                {
                    lList.Add((i, num));
                    card[num] = 1;
                }
                else
                {
                    rList.Add((i, num));
                    card[num] = 1;
                }
            }
            for (int i = 0; i < N; i++)
            {
                int temp = K;
                if (card[i] == 0)
                {
                    foreach (var l in lList)
                    {
                        if (i < (l.Item2))
                        {
                            temp--;
                        }
                    }
                    foreach (var r in rList)
                    {
                        if (i > (r.Item2))
                        {
                            temp--;
                        }
                    }
                    card[i] = temp;
                }
            }
            long ans = 1;

            for (int i = 0; i < N; i++)
            {
                ans *= (long)card[i];
                ans %= mod;
            }
            Console.WriteLine(ans);
        }
        public static void ARC124_B()
        {
            int N = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var b = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var x = new List<long>();
            long ans = 0;
            var ansList = new List<long>();

            for (int i = 0; i < a.Length; i++)
            {
                if (!x.Contains(a[0] ^ b[i]))
                    x.Add(a[0] ^ b[i]);
            }
            foreach (var i in x)
            {
                var c = new long[N];
                var ok = true;
                for (int j = 0; j < N; j++)
                {
                    c[j] = a[j] ^ i;
                }
                Array.Sort(c);
                Array.Sort(b);
                for (int j = 0; j < N; j++)
                {
                    if (c[j] != b[j]) ok = false;
                }
                if (ok)
                {
                    ans++;
                    ansList.Add(i);
                }
            }
            ansList.Sort();
            Console.WriteLine(ans);
            foreach (var i in ansList)
            {
                Console.WriteLine(i);
            }
        }
        public static void ARC125_A()
        {
            var nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = nm[0];
            int M = nm[1];
            var S = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var T = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var listS = S.ToList();
            listS.AddRange(listS);
            long ans = 0;
            ans += T.Length;
            int find = 0;
            if (S[0] == 0)
            {
                for (int i = N; i < listS.Count(); i++)
                {
                    if (listS[i] == 1)
                    {
                        find = (i - (N));
                        break;
                    }

                }
                for (int i = N; i >= 0; i--)
                {
                    if (listS[i] == 1) find = Math.Min(find, (N) - i);
                }
            }
            else if (S[0] == 1)
            {
                for (int i = N; i < listS.Count(); i++)
                {
                    if (listS[i] == 0)
                    {
                        find = (i - (N));
                        break;
                    }

                }
                for (int i = N; i >= 0; i--)
                {
                    if (listS[i] == 0) find = Math.Min(find, (N) - i);
                }
            }
            if (find == 0)
            {
                for (int i = 0; i < M; i++)
                {
                    if (S[0] != T[i])
                    {
                        Console.WriteLine(-1);
                        return;
                    }
                }
                Console.WriteLine(ans);
                return;
            }

            bool first = true;
            if (S[0] != T[0])
            {
                ans += find;
                first = false;
            }
            for (int i = 1; i < M; i++)
            {
                if (T[i] != T[i - 1] && first)
                {
                    ans += find;
                    first = false;
                }
                else if (T[i] != T[i - 1]) ans += 1;
            }
            Console.WriteLine(ans);
        }
        public static void ARC002_A()
        {
            int Y = int.Parse(Console.ReadLine());
            bool uruu = false;
            if (Y % 4 == 0)
            {
                uruu = true;
            }
            if (Y % 100 == 0)
            {
                uruu = false;
            }
            if (Y % 400 == 0)
            {
                uruu = true;
            }
            if (uruu) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
        public static void ARC057_A()
        {
            var AK = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long A = AK[0];
            long K = AK[1];
            long ans = 0;
            if (K == 0)
            {
                ans = 2000000000000 - A;
                Console.WriteLine(ans);
                return;
            }
            while (A < 2000000000000)
            {
                ans++;
                A += (A * K + 1);
            }
            Console.WriteLine(ans);
        }
        public static void ARC056_A()
        {
            var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long ans = 0;
            if (read[3] * read[0] < read[1])
            {
                ans = read[0] * read[2];
            }
            else
            {
                ans = read[2] / read[3] * read[1] + (read[2] % read[3]) * read[0];
                if (read[2] % read[3] != 0)
                    ans = Math.Min(ans, (read[2] / read[3] + 1) * read[1]);
            }
            Console.WriteLine(ans);
        }
        public static void ARC058_A()
        {
            var NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var D = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = NK[0];
            var noList = new List<int>();
            noList.AddRange(D);
            String ans = "";
            while (true)
            {
                var charN = Convert.ToString(N).ToCharArray();
                bool ok = true;
                for (int i = 0; i < charN.Length; i++)
                {
                    if (noList.Contains(charN[i] - '0'))
                    {
                        ok = false;
                        break;
                    }
                }
                if (ok)
                {
                    ans = new String(charN);
                    Console.WriteLine(ans);
                    return;
                }
                N++;
            }
        }
        public static void ARC059_A()
        {
            int N = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int ave = (int)Math.Round((decimal)a.Sum() / a.Length, 0);
            long cost = 0;
            for (int i = 0; i < N; i++)
            {
                cost += (long)Math.Pow(a[i] - ave, 2);
            }
            Console.WriteLine((cost));
        }
        public static void ARC060_A()
        {
            var NA = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = NA[0];
            int A = NA[1];
            var x = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var dp = new long[N + 1, N + 1, 2550];
            dp[0, 0, 0] = 1;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    for (int k = 0; k < 2550; k++)
                    {
                        dp[i + 1, j, k] += dp[i, j, k];
                        if (k - x[i] >= 0)
                        {
                            dp[i + 1, j + 1, k] += dp[i, j, k - x[i]];
                        }

                    }
                }
            }
            long ans = 0;
            for (int i = 1; i <= N; i++)
            {
                ans += dp[N, i, i * A];
            }
            Console.WriteLine(ans);
        }
        public static void ARC115_A()
        {
            var nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var S = new char[nm[0]][];
            int evenCount = 0;
            int oddCount = 0;
            for (int i = 0; i < nm[0]; i++)
            {
                S[i] = Console.ReadLine().ToCharArray();
                int temp = 0;
                for (int j = 0; j < nm[1]; j++)
                {
                    if (S[i][j] == '1') temp++;
                }
                if (temp % 2 == 0) evenCount++;
                else oddCount++;
            }
            long ans = (long)evenCount * oddCount;
            Console.WriteLine(ans);
        }
        public static void ARC121_A()
        {
            int N = int.Parse(Console.ReadLine());
            var point = new List<(int, long, long)>();
            for (int i = 0; i < N; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                point.Add((i, read[0], read[1]));
            }
            var list = new List<(int, long, long)>();
            var xOrder = point.OrderByDescending(a => a.Item2).ToList();
            var yOrder = point.OrderByDescending(a => a.Item3).ToList();
            list.Add(xOrder[0]);
            list.Add(xOrder[N - 1]);
            list.Add(xOrder[1]);
            list.Add(xOrder[N - 2]);
            list.Add(yOrder[0]);
            list.Add(yOrder[N - 1]);
            list.Add(yOrder[1]);
            list.Add(yOrder[N - 2]);
            list = list.Distinct().ToList();
            var dist = new List<long>();
            for (int i = 0; i < list.Count(); i++)
            {
                for (int j = i; j < list.Count(); j++)
                {
                    if (list[i].Item1 == list[j].Item1)
                    {
                        continue;
                    }
                    dist.Add(Math.Max(Math.Abs(list[i].Item2 - list[j].Item2), Math.Abs(list[i].Item3 - list[j].Item3)));
                }
            }
            dist = dist.OrderByDescending(x => x).ToList();
            Console.WriteLine(dist[1]);
        }
        public static void ARC122_A()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var dp = new long[N + 1, 2];
            long mod = 1000000007;

            var count = new long[N + 1, 2];
            count[0, 1] = 1;
            for (int i = 0; i < N; i++)
            {
                count[i + 1, 1] += (count[i, 0] + count[i, 1]) % mod;
                count[i + 1, 0] += count[i, 1];
                count[i + 1, 0] %= mod;
            }
            if (N == 1)
            {
                Console.WriteLine(A[0]);
                return;
            }
            dp[1, 0] = (A[0] - A[1]);
            dp[1, 1] = (A[0] + A[1]);
            for (int i = 1; i < N - 1; i++)
            {
                dp[i + 1, 1] += ((dp[i, 0] + (count[i, 0] * A[i + 1]) % mod));
                dp[i + 1, 1] %= mod;
                dp[i + 1, 1] += ((dp[i, 1] + (count[i, 1] * A[i + 1]) % mod));
                dp[i + 1, 1] %= mod;
                dp[i + 1, 0] += ((dp[i, 1] + mod - (count[i, 1] * A[i + 1]) % mod));
                dp[i + 1, 0] %= mod;
            }
            long ans = (dp[N - 1, 0] + dp[N - 1, 1]) % mod;
            Console.WriteLine(ans);

        }
        public static void ARC122_B()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            Array.Sort(A);
            var sum = new long[N];
            sum[0] = A[0];
            for (int i = 1; i < N; i++)
            {
                sum[i] = sum[i - 1] + A[i];
            }
            double ans = longMax;
            for (int i = 0; i < N; i++)
            {
                double x = A[i] / (double)2;
                var temp = N * x + sum[N - 1] - sum[i] - 2 * x * (N - i - 1);
                ans = Math.Min(ans, temp / N);
            }
            Console.WriteLine(ans);
        }
        public static void ARC127_A()
        {
            var N = Console.ReadLine();
            var charN = N.ToCharArray();
            long longN = long.Parse(N);
            long ans = 0;
            long p = 1;
            while (p <= longN)
            {
                long u = 1;
                while (p * u <= longN)
                {
                    long temp = longN - p * u + 1;
                    ans += Math.Min(u, temp);
                    u *= 10;
                }
                p *= 10;
                p++;
            }
            Console.WriteLine(ans);
        }
        public static void ABC132_C()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Array.Sort(A);
            int k = A[N / 2] - A[N / 2 - 1];
            Console.WriteLine(k);
        }
        public static void ABC133_C()
        {
            var LR = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long ans = longMax;
            for (long i = LR[0]; i < LR[1]; i++)
            {
                for (long j = i + 1; j <= LR[1]; j++)
                {
                    ans = Math.Min(ans, i * j % 2019);
                    if (ans == 0)
                    {
                        Console.WriteLine(0);
                        return;
                    }
                }
            }
            Console.WriteLine(ans);
        }
        public static void ABC134_C()
        {
            int N = int.Parse(Console.ReadLine());
            var A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }
            var list = A.ToList();
            list = list.OrderBy(x => x).ToList();
            for (int i = 0; i < N; i++)
            {
                if (A[i] == list[list.Count - 1])
                {
                    Console.WriteLine(list[list.Count - 2]);
                }
                else
                {
                    Console.WriteLine(list[list.Count - 1]);
                }
            }

        }
        public static void ABC135_C()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var B = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long ans = 0;
            for (int i = 0; i < N; i++)
            {
                long temp = Math.Min(A[i], B[i]);
                ans += temp;
                B[i] -= temp;
                if (B[i] > 0)
                {
                    temp = Math.Min(A[i + 1], B[i]);
                    ans += temp;
                    A[i + 1] -= temp;
                }
            }
            Console.WriteLine(ans);
        }
        public static void ABC136_C()
        {
            int N = int.Parse(Console.ReadLine());
            var H = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool ok = false;
            long max = 0;
            for (int i = 0; i < N; i++)
            {
                max = Math.Max(max, H[i]);
                if (max - H[i] > 1)
                {
                    ok = false;
                    break;
                }
                else
                {
                    ok = true;
                }
            }
            if (ok) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
        public static void ABC138_C()
        {
            int N = int.Parse(Console.ReadLine());
            var v = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Array.Sort(v);
            double ave = ((double)v[0] + v[1]) / 2;
            for (int i = 2; i < N; i++)
            {
                ave = ((double)v[i] + ave) / 2;
            }
            Console.WriteLine(ave);
        }
        public static void ABC065_B()
        {
            int N = int.Parse(Console.ReadLine());
            var a = new int[N];
            for (int i = 0; i < N; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            var pushed = new bool[N];
            int next = -1;
            long ans = 1;
            while (true)
            {
                if (pushed[0] == false)
                {
                    next = a[0] - 1;
                    if (a[0] == 2)
                    {
                        Console.WriteLine(1);
                        return;
                    }
                    pushed[0] = true;
                    ans = 1;
                }
                if (pushed[next])
                {
                    Console.WriteLine(-1);
                    return;
                }
                else if (a[next] == 2)
                {
                    ans++;
                    Console.WriteLine(ans);
                    return;
                }
                ans++;
                pushed[next] = true;
                next = a[next] - 1;
            }
        }
        public static void AGC029_A()
        {
            var charS = Console.ReadLine().ToCharArray();
            long ans = 0;
            long countB = 0;
            for (int i = 0; i < charS.Length; i++)
            {

                if (charS[i] == 'B')
                {
                    countB++;
                }
                else
                {
                    ans += countB;
                }
            }
            Console.WriteLine(ans);
        }
        public static void AGC040_A()
        {
            var charS = Console.ReadLine().ToCharArray();
            var a = new long[charS.Length + 1];
            long leftCount = 0;
            long rightCount = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (charS[i - 1] == '<')
                {
                    leftCount++;
                }
                else
                {
                    leftCount = 0;
                }
                a[i] = Math.Max(a[i], leftCount);
            }
            for (int i = a.Length - 2; i >= 0; i--)
            {
                if (charS[i] == '>')
                {
                    rightCount++;
                }
                else
                {
                    rightCount = 0;
                }
                a[i] = Math.Max(a[i], rightCount);
            }
            long ans = a.Sum();
            Console.WriteLine(ans);
        }
        public static void mitui2019_C()
        {
            int X = int.Parse(Console.ReadLine());
            int max = X;
            X %= 100;
            var list = new int[] { 1, 2, 3, 4, 5 };
            var count = 0;
            int id = 4;
            var ans = 0;
            while (X != 0 || id >= 0)
            {
                count += X / list[id];
                X %= list[id];
                if (count * 100 > max)
                {
                    ans = 0;
                    Console.WriteLine(ans);
                    return;
                }
                id--;
            }
            ans = 1;
            Console.WriteLine(ans);
        }
        public static void ABC042_B()
        {
            var NL = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var list = new List<string>();
            for (int i = 0; i < NL[0]; i++)
            {
                list.Add(Console.ReadLine());
            }
            list = list.OrderBy(x => x).ToList();
            String ans = "";
            for (int i = 0; i < list.Count(); i++)
            {
                ans += list[i];
            }
            Console.WriteLine(ans);
        }
        public static void ABC097_B()
        {
            int X = int.Parse(Console.ReadLine());
            var ans = 1;
            for (int i = 2; i <= 100; i++)
            {
                int p = 2;
                while (Math.Pow(i, p) <= X)
                {
                    ans = Math.Max(ans, (int)Math.Pow(i, p));
                    p++;
                }
            }
            Console.WriteLine(ans);
        }
        public static void AGC021_A()
        {
            var charN = Console.ReadLine().ToCharArray();
            long ans = 0;

            if (charN[0] - '0' != 9)
            {
                for (int i = 0; i < charN.Length; i++)
                {
                    ans += charN[i] - '0';
                }
                ans = Math.Max(ans, (charN[0] - '0' - 1) + (charN.Length - 1) * 9);

            }
            else
            {
                for (int i = 0; i < charN.Length; i++)
                {
                    ans += charN[i] - '0';
                }
                if (charN.Length > 1)
                {
                    ans = Math.Max(ans, 8 + 9 * (charN.Length - 1));
                }
            }
            Console.WriteLine(ans);
        }
        public static void ABC115_C()
        {
            var NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var h = new long[NK[0]];
            for (int i = 0; i < NK[0]; i++)
            {
                h[i] = long.Parse(Console.ReadLine());
            }
            Array.Sort(h);
            long min = longMax;
            for (int i = 0; i <= NK[0] - NK[1]; i++)
            {
                min = Math.Min(min, h[i + NK[1] - 1] - h[i]);
            }
            Console.WriteLine(min);
        }
        public static void ABC151_C()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var submit = new Dictionary<String, (int, int)>();
            long waCount = 0;
            long acCount = 0;
            for (int i = 0; i < NM[1]; i++)
            {
                var read = Console.ReadLine().Split();
                if (read[1] == "WA")
                {
                    if (!submit.ContainsKey(read[0]))
                    {
                        submit.Add(read[0], (0, 1));
                    }
                    else
                    {
                        if (submit[read[0]].Item1 != 1)
                            submit[read[0]] = (submit[read[0]].Item1, submit[read[0]].Item2 + 1);
                    }
                }
                else
                {
                    if (!submit.ContainsKey(read[0]))
                    {
                        submit.Add(read[0], (1, 0));
                    }
                    else
                    {
                        submit[read[0]] = (1, submit[read[0]].Item2);
                    }
                }
            }
            foreach (var value in submit.Values)
            {
                if (value.Item1 == 1)
                {
                    acCount++;
                    waCount += value.Item2;
                }
            }
            Console.WriteLine($"{acCount} {waCount}");
        }
        public static void ABC220_A()
        {
            var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int p = 1;
            int ans = 0;
            while (read[2] <= read[1])
            {
                if (read[0] <= read[2] && read[2] <= read[1])
                {
                    ans = read[2];
                    break;
                }
                read[2] *= p;
                p++;
            }
            if (ans == 0) Console.WriteLine(-1);
            else Console.WriteLine(ans);
        }
        public static void ABC220_B()
        {
            var k = int.Parse(Console.ReadLine());
            var AB = Console.ReadLine().Split();
            var A = AB[0].ToCharArray();
            var B = AB[1].ToCharArray();
            long ans = 0;
            long ka = 0;

            long kb = 0;
            for (int i = A.Length - 1; i >= 0; i--)
            {
                ka += (int)Math.Pow(k, i) * (A[(A.Length - 1) - i] - '0');
            }
            for (int i = B.Length - 1; i >= 0; i--)
            {
                kb += (int)Math.Pow(k, i) * (B[(B.Length - 1) - i] - '0');
            }
            ans = ka * kb;
            Console.WriteLine(ans);
        }
        public static void ABC220_C()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long X = long.Parse(Console.ReadLine());
            long sum = A.Sum();
            long count = A.Length;
            long d = X / sum;
            long ans = d * count;
            long r = X % sum;
            long temp = 0;
            long id = 1;
            while (r >= temp)
            {
                temp += A[id - 1];
                id++;
            }
            ans += (id - 1);
            Console.WriteLine(ans);
        }
        public static void ABC220_D()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var list = new List<int>();
            list.AddRange(A);
            var dp = new long[N + 1, 10, 10];
            dp[0, A[0], A[1]] = 1;
            long mod = 998244353;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        if (i + 2 < A.Length)
                        {
                            dp[i + 1, (j + k) % 10, A[i + 2]] += dp[i, j, k];
                            dp[i + 1, (j + k) % 10, A[i + 2]] %= mod;
                            dp[i + 1, (j * k) % 10, A[i + 2]] += dp[i, j, k];
                            dp[i + 1, (j * k) % 10, A[i + 2]] %= mod;
                        }
                        else
                        {
                            dp[i + 1, (j + k) % 10, 0] += dp[i, j, k];
                            dp[i + 1, (j + k) % 10, 0] %= mod;
                            dp[i + 1, (j * k) % 10, 0] += dp[i, j, k];
                            dp[i + 1, (j * k) % 10, 0] %= mod;
                        }

                    }
                }
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(dp[N - 1, i, 0]);
            }
        }
        public static void AGC012_A()
        {
            int N = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(long.Parse).ToArray();
            Array.Sort(a);
            long ans = 0;
            for (int i = N; i < 3 * N; i += 2)
            {
                ans += a[i];
            }
            Console.WriteLine(ans);
        }
        public static void AGC041_A()
        {
            var NAB = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long ans = 0;
            if (Math.Abs(NAB[1] - NAB[2]) % 2 == 0)
            {
                ans = Math.Abs(NAB[1] - NAB[2]) / 2;
            }
            else
            {
                ans = Math.Min(NAB[0] - NAB[2], NAB[1] - 1) + 1 + (NAB[2] - NAB[1] - 1) / 2;
            }
            Console.WriteLine(ans);
        }
        public static void ABC144_C()
        {
            long N = long.Parse(Console.ReadLine());
            long min = longMax;
            for (long i = 1; i <= Math.Sqrt(N); i++)
            {
                if (N % i == 0)
                {
                    min = Math.Min(min, i + N / i);
                }
            }
            long ans = min - 2;
            Console.WriteLine(ans);
        }
        public static void ABC100_C()
        {
            int N = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long ans = 0;
            for (int i = 0; i < a.Length; i++)
            {
                while (a[i] % 2 == 0)
                {
                    ans++;
                    a[i] /= 2;
                }
            }
            Console.WriteLine(ans);
        }
        public static void AGC019_A()
        {
            var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long N = long.Parse(Console.ReadLine());
            var list = new List<long>();
            list.Add(read[0] * 4);
            list.Add(read[1] * 2);
            list.Add(read[2] * 1);
            list = list.OrderBy(x => x).ToList();
            long ans = 0;
            if (list[0] > read[3] / 2)
            {
                ans += N / 2 * read[3];
                if (N % 2 != 0)
                    ans += list[0];
            }
            else
            {
                ans += N * list[0];
            }
            Console.WriteLine(ans);
        }
        public static void ABC087_C()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var B = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long ans = 0;
            for (int i = 0; i < N; i++)
            {
                int temp = 0;
                int sum = 0;
                while (temp <= i)
                {
                    sum += A[temp];
                    temp++;
                }
                for (int j = i; j < N; j++)
                {
                    sum += B[j];
                }
                ans = Math.Max(ans, sum);
            }
            Console.WriteLine(ans);
        }
        public static void ABC100_B()
        {
            var DN = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long ans = 0;
            if (DN[1] % 100 != 0)
            {
                ans = (long)Math.Pow(100, DN[0]) * DN[1];
            }
            else
            {
                ans = (long)Math.Pow(100, DN[0]) * (DN[1] + 1);
            }

            Console.WriteLine(ans);
        }
        public static void ABC106_C()
        {
            String S = Console.ReadLine();
            long K = long.Parse(Console.ReadLine());
            var charS = S.ToCharArray();
            char ans = '0';
            if (charS.Length >= K)
            {
                for (int i = 0; i < K; i++)
                {
                    if (charS[i] != '1')
                    {
                        break;
                    }
                    else if (i == K - 1)
                    {
                        ans = '1';
                        Console.WriteLine(ans);
                        return;
                    }
                }
            }
            for (int i = 0; i < charS.Length; i++)
            {
                if (charS[i] != '1')
                {
                    ans = charS[i];
                    break;
                }
                else
                {
                    ans = '1';
                }
            }
            Console.WriteLine(ans);
        }
        /// <summary>
        /// ユークリッド互除法
        /// </summary>
        public static void ABC103_C()
        {
            int N = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long gcd(long C, long D)
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
                var CD = (long)Math.Floor(((decimal)C * D) / tempC);
                return CD;
            }
            long ans = 0;
            gcd(1, 2);
            for (int i = 0; i < a.Length; i++)
            {
                ans += a[i] - 1;
            }
            Console.WriteLine(ans);
        }
        public static void ABC091_B()
        {
            int N = int.Parse(Console.ReadLine());
            var blueList = new Dictionary<String, int>();
            for (int i = 0; i < N; i++)
            {
                var temp = Console.ReadLine();
                if (!blueList.ContainsKey(temp))
                {
                    blueList.Add(temp, 1);
                }
                else
                {
                    blueList[temp]++;
                }
            }
            int M = int.Parse(Console.ReadLine());
            var redList = new Dictionary<String, int>();
            for (int j = 0; j < M; j++)
            {
                var temp = Console.ReadLine();
                if (!redList.ContainsKey(temp))
                {
                    redList.Add(temp, 1);
                }
                else
                {
                    redList[temp]++;
                }
            }
            long ans = 0;
            foreach (var key in blueList.Keys)
            {
                int plus = 0;
                int minus = 0;
                plus = blueList[key];
                if (redList.ContainsKey(key))
                {
                    minus = redList[key];
                }
                ans = Math.Max(ans, plus - minus);
            }
            Console.WriteLine(ans);

        }
        public static void ARC088_C()
        {
            var XY = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long temp = XY[0];
            long count = 1;
            while (temp <= XY[1] / 2)
            {
                temp *= 2;
                count++;
            }
            Console.WriteLine(count);
        }
        public static void ABC055_B()
        {
            int N = int.Parse(Console.ReadLine());
            long power = 1;
            long mod = 1000000007;
            for (int i = 2; i <= N; i++)
            {
                power *= i;
                power %= mod;
            }
            Console.WriteLine(power);
        }
        public static void ABC120_C()
        {
            var charS = Console.ReadLine().ToCharArray();
            int count1 = 0;
            int count0 = 0;
            for (int i = 0; i < charS.Length; i++)
            {
                if (charS[i] == '0')
                {
                    count0++;
                }
                else
                {
                    count1++;
                }
            }
            long ans = Math.Min(count0 * 2, count1 * 2);
            Console.WriteLine(ans);
        }
        public static void disco_B()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var sum = new long[N + 1];

            for (int i = 0; i < N; i++)
            {
                sum[i + 1] = sum[i] + A[i];
            }
            long ans = longMax;
            for (int i = 0; i < N; i++)
            {
                ans = Math.Min(ans, Math.Abs((sum[N] - sum[i]) - sum[i]));
            }
            Console.WriteLine(ans);
        }
        public static void ABC079_C()
        {
            var ABCD = Console.ReadLine().ToCharArray();
            var ans = new bool[3];
            for (int i = 0; i < 1 << 3; i++)
            {
                var bit = new bool[3];
                int sum = ABCD[0] - '0';
                for (int j = 0; j < 3; j++)
                {
                    if (((i >> j) & 1) == 1)
                    {
                        bit[j] = true;
                    }
                }
                for (int j = 0; j < 3; j++)
                {
                    if (bit[j])
                    {
                        sum += ABCD[j + 1] - '0';
                    }
                    else
                    {
                        sum -= ABCD[j + 1] - '0';
                    }
                }
                if (sum == 7)
                {
                    ans = bit;
                    break;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"{ABCD[i]}");
                if (i != 3)
                {
                    if (ans[i]) Console.Write("+");
                    else Console.Write("-");
                }
                else
                {
                    Console.WriteLine("=7");
                }
            }
        }
        public static void ABC093_C()
        {
            var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int ans = 0;
            Array.Sort(read);

            if (read[1] % 2 != read[0] % 2)
            {
                read[1]++;
                read[2]++;
                ans++;
            }
            ans += (read[1] - read[0]) / 2;
            ans += read[2] - read[1];
            Console.WriteLine(ans);
        }
        public static void codefes2017_C()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long sum = 1;
            long except = 1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0) except *= 2;
                sum *= 3;
            }

            long ans = sum - except;
            Console.WriteLine(ans);
        }
        public static void ABC121_C()
        {
            var NM = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var list = new List<(long, long)>();
            for (int i = 0; i < NM[0]; i++)
            {
                var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
                list.Add((read[0], read[1]));
            }
            list = list.OrderBy(x => x.Item1).ToList();
            long temp = 0;
            long ans = 0;
            foreach (var l in list)
            {
                if (l.Item2 + temp >= NM[1])
                {
                    ans += (NM[1] - temp) * l.Item1;
                    break;
                }
                else
                {
                    ans += l.Item2 * l.Item1;
                    temp += l.Item2;
                }
            }
            Console.WriteLine(ans);
        }
        public static void AGC004_A()
        {
            var ABC = Console.ReadLine().Split().Select(long.Parse).ToArray();
            Array.Sort(ABC);
            long ans = 0;
            if (ABC[0] % 2 == 0 || ABC[1] % 2 == 0 || ABC[2] % 2 == 0)
            {
                ans = 0;
            }
            else
            {
                ans = ABC[0] * ABC[1];
            }
            Console.WriteLine(ans);
        }
        public static void ABC046_B()
        {
            var NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long pow(long x, int n)
            {
                long ret = 1;
                while (n > 0)
                {
                    if ((n & 1) > 0) ret *= x;
                    x *= x;
                    n = n >> 1;
                }
                return ret;
            }
            long ans = NK[1];
            ans *= pow(NK[1] - 1, NK[0] - 1);
            Console.WriteLine(ans);
        }
        public static void codefes2016_B()
        {
            int N = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int ans = 0;
            for (int i = 0; i < N; i++)
            {
                if (a[a[i] - 1] - 1 == i)
                {
                    ans++;
                }
            }
            ans /= 2;
            Console.WriteLine(ans);
        }
        public static void ABC066_B()
        {
            var charS = Console.ReadLine().ToCharArray();
            long ans = 0;
            for (int i = 2; i < charS.Length; i += 2)
            {
                bool ok = true;
                for (int j = 0; j < (charS.Length - i) / 2; j++)
                {
                    if (charS[j] != charS[j + (charS.Length - i) / 2]) ok = false;
                }
                if (ok) ans = Math.Max(ans, charS.Length - i);
            }
            Console.WriteLine(ans);
        }
        public static void ABC075_B()
        {
            var HW = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var S = new char[HW[0]][];
            for (int i = 0; i < HW[0]; i++)
            {
                S[i] = Console.ReadLine().ToCharArray();
            }
            var dx = new int[] { -1, 0, 1 };
            var dy = new int[] { -1, 0, 1 };
            for (int i = 0; i < HW[0]; i++)
            {
                for (int j = 0; j < HW[1]; j++)
                {
                    var count = 0;
                    if (S[i][j] == '.')
                    {
                        foreach (var x in dx)
                        {
                            foreach (var y in dy)
                            {
                                if (x == 0 && y == 0) continue;
                                if (j + x >= 0 && j + x <= HW[1] - 1 && i + y >= 0 && i + y <= HW[0] - 1)
                                {
                                    if (S[i + y][j + x] == '#')
                                    {
                                        count++;
                                    }
                                }
                            }
                        }
                        S[i][j] = count.ToString()[0];
                    }
                }
            }
            for (int i = 0; i < HW[0]; i++)
            {
                for (int j = 0; j < HW[1]; j++)
                {
                    if (j == HW[1] - 1)
                    {
                        Console.WriteLine(S[i][j]);
                    }
                    else
                    {
                        Console.Write(S[i][j]);
                    }
                }
            }
        }
        public static void ABC221_A()
        {
            var AB = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long ans = (long)Math.Pow(32, Math.Abs(AB[0] - AB[1]));
            Console.WriteLine(ans);
        }
        public static void ABC221_B()
        {
            var charS = Console.ReadLine().ToCharArray();
            var charT = Console.ReadLine().ToCharArray();
            bool ok = false;
            if (new String(charS) == new String(charT)) ok = true;
            for (int i = 0; i < charT.Length - 1; i++)
            {
                var temp = new char[charT.Length];
                Array.Copy(charT, temp, charT.Length);
                var t = temp[i + 1];
                temp[i + 1] = temp[i];
                temp[i] = t;
                if (new String(charS) == new String(temp)) ok = true;
            }
            if (ok) Console.WriteLine("Yes");
            else Console.WriteLine(("No"));
        }
        public static void ABC221_C()
        {
            var charN = Console.ReadLine().ToCharArray();
            Array.Sort(charN);
            Array.Reverse(charN);
            long ans = 0;
            for (int i = 1; i < 1 << charN.Length; i++)
            {
                long tempA = 0;
                long tempB = 0;
                for (int j = 0; j < charN.Length; j++)
                {
                    if (((i >> j) & 1) == 1)
                    {
                        tempA = tempA * 10 + (charN[j] - '0');
                    }
                    else
                    {
                        tempB = tempB * 10 + (charN[j] - '0');
                    }
                }
                ans = Math.Max(ans, tempA * tempB);
            }
            Console.WriteLine(ans);

        }
        public static void ABC221_D()
        {
            long N = long.Parse(Console.ReadLine());
            var login = new List<long>();
            var logout = new List<long>();
            for (int i = 0; i < N; i++)
            {
                var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
                login.Add(read[0]);
                logout.Add(read[0] + read[1]);
            }
            login = login.OrderBy(x => x).ToList();
            logout = logout.OrderBy(x => x).ToList();
            var num = new long[N + 1];
            int count = 1;
            int outINdex = 0;
            int inINdex = 0;
            long now = login[inINdex];
            login.Add(longMax);
            inINdex++;
            while (outINdex < logout.Count)
            {
                if (login[inINdex] == logout[outINdex])
                {
                    num[count] += login[inINdex] - now;
                    now = login[inINdex];
                    inINdex++;
                    outINdex++;

                }
                else if (login[inINdex] < logout[outINdex])
                {
                    num[count] += login[inINdex] - now;
                    now = login[inINdex];
                    count++;
                    inINdex++;
                }
                else
                {
                    num[count] += logout[outINdex] - now;
                    now = logout[outINdex];
                    count--;
                    outINdex++;
                }
            }
            for (int i = 1; i < N + 1; i++)
            {
                if (i != N) Console.Write($"{num[i]} ");
                else Console.WriteLine(num[i]);
            }

        }
        public static void ABC098_B()
        {
            int N = int.Parse(Console.ReadLine());
            var S = Console.ReadLine();
            var ans = 0;
            for (int i = 0; i < N - 1; i++)
            {
                var a = S[0..i];
                var b = S[i..N];
                var list = new List<char>();
                var temp = 0;
                for (int j = 0; j < a.Length; j++)
                {
                    if (!list.Contains(a[j]))
                    {
                        list.Add(a[j]);
                    }
                }
                for (int j = 0; j < b.Length; j++)
                {
                    if (list.Contains(b[j]))
                    {
                        temp++;
                        list.Remove(b[j]);
                    }
                }
                ans = Math.Max(ans, temp);
            }
            Console.WriteLine(ans);
        }
        public static void ABC064_C()
        {
            int N = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var list = new Dictionary<string, int>();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] /= 400;
                if (a[i] == 0)
                {
                    if (!list.ContainsKey("gray"))
                    {
                        list.Add("gray", 1);
                    }
                }
                else if (a[i] == 1)
                {
                    if (!list.ContainsKey("brown"))
                    {
                        list.Add("brown", 1);
                    }
                }
                else if (a[i] == 2)
                {
                    if (!list.ContainsKey("green"))
                    {
                        list.Add("green", 1);
                    }
                }
                else if (a[i] == 3)
                {
                    if (!list.ContainsKey("water"))
                    {
                        list.Add("water", 1);
                    }
                }
                else if (a[i] == 4)
                {
                    if (!list.ContainsKey("blue"))
                    {
                        list.Add("blue", 1);
                    }
                }
                else if (a[i] == 5)
                {
                    if (!list.ContainsKey("yellow"))
                    {
                        list.Add("yellow", 1);
                    }
                }
                else if (a[i] == 6)
                {
                    if (!list.ContainsKey("orange"))
                    {
                        list.Add("orange", 1);
                    }
                }
                else if (a[i] == 7)
                {
                    if (!list.ContainsKey("red"))
                    {
                        list.Add("red", 1);
                    }
                }
                else if (a[i] >= 8)
                {
                    if (!list.ContainsKey("all"))
                    {
                        list.Add("all", 1);
                    }
                    else
                    {
                        list["all"]++;
                    }
                }
            }
            int min = 0;
            int max = 0;
            foreach (var l in list)
            {
                if (l.Key != "all")
                {
                    max += l.Value;
                    min++;
                }
            }
            if (list.ContainsKey("all"))
            {
                max += list["all"];
                if (list.Count == 1)
                {
                    min = 1;
                }
            }
            Console.WriteLine($"{min} {max}");
        }
        public static void ABC060_B()
        {
            var ABC = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var seen = new bool[101];
            int temp = 0;
            int p = 2;
            int A = ABC[0];
            while (true)
            {
                temp = A % ABC[1];
                if (seen[temp])
                {
                    Console.WriteLine("NO");
                    return;
                }
                else if (temp == ABC[2])
                {
                    Console.WriteLine("YES");
                    return;
                }
                else
                {
                    seen[temp] = true;
                }
                A = p * ABC[0];
                p++;
            }
        }
        public static void ABC072_C()
        {
            int N = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var numbers = new int[100001];
            int ans = 0;

            for (int j = 0; j < a.Length; j++)
            {
                numbers[a[j] + 1]++;
                numbers[a[j]]++;
                if (a[j] > 0)
                    numbers[a[j] - 1]++;
            }
            ans = numbers.Max();

            Console.WriteLine(ans);
        }
        public static void ABC057_B()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var students = new (int, int)[NM[0]];
            var points = new (int, int)[NM[1]];
            for (int i = 0; i < NM[0]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                students[i] = (read[0], read[1]);
            }
            for (int i = 0; i < NM[1]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                points[i] = (read[0], read[1]);
            }
            var ans = new int[NM[0]];
            for (int i = 0; i < NM[0]; i++)
            {
                int temp = intMax;
                for (int j = 0; j < NM[1]; j++)
                {
                    if (temp > Math.Abs(students[i].Item1 - points[j].Item1) + Math.Abs(students[i].Item2 - points[j].Item2))
                    {
                        temp = Math.Abs(students[i].Item1 - points[j].Item1) + Math.Abs(students[i].Item2 - points[j].Item2);
                        ans[i] = j + 1;
                    }
                }
            }
            for (int i = 0; i < NM[0]; i++)
            {
                Console.WriteLine(ans[i]);
            }
        }
        public static void ABC155_C()
        {
            int N = int.Parse(Console.ReadLine());
            var list = new Dictionary<String, int>();
            var max = 0;
            for (int i = 0; i < N; i++)
            {
                var read = Console.ReadLine();
                if (!list.ContainsKey(read))
                {
                    list.Add(read, 1);
                }
                else
                {
                    list[read]++;
                    max = Math.Max(max, list[read]);
                }
            }
            var ans = new List<String>();
            foreach (var l in list)
            {
                if (max == 0)
                {
                    ans.Add(l.Key);
                    continue;
                }
                if (l.Value == max)
                {
                    ans.Add(l.Key);
                }
            }
            ans = ans.OrderBy(x => x).ToList();
            foreach (var l in ans)
            {
                Console.WriteLine(l);
            }
        }
        public static void ABC107_B()
        {
            var HW = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var fields = new char[HW[0]][];
            for (int i = 0; i < HW[0]; i++)
            {
                fields[i] = Console.ReadLine().ToCharArray();
            }
            var removeH = new List<int>();
            var removeW = new List<int>();
            for (int i = 0; i < HW[0]; i++)
            {
                var ok = true;
                for (int j = 0; j < HW[1]; j++)
                {
                    if (fields[i][j] == '#')
                    {
                        ok = false;
                    }
                }
                if (ok) removeH.Add(i);
            }
            for (int i = 0; i < HW[1]; i++)
            {
                var ok = true;
                for (int j = 0; j < HW[0]; j++)
                {
                    if (fields[j][i] == '#')
                    {
                        ok = false;
                    }
                }
                if (ok) removeW.Add(i);
            }
            var result = new List<List<char>>();
            int temp = 0;
            for (int i = 0; i < HW[0]; i++)
            {
                if (removeH.Contains(i)) continue;
                result.Add(new List<char>());
                for (int j = 0; j < HW[1]; j++)
                {
                    if (removeW.Contains(j)) continue;
                    result[temp].Add(fields[i][j]);
                }
                temp++;
            }
            foreach (var h in result)
            {
                int count = 0;
                foreach (var w in h)
                {
                    if (count == h.Count() - 1)
                    {
                        Console.WriteLine(w);
                    }
                    else
                    {
                        Console.Write(w);
                    }
                    count++;
                }
            }
        }
        public static void ABC086_C()
        {
            int N = int.Parse(Console.ReadLine());
            var list = new List<(int min, int x, int y)>();
            for (int i = 0; i < N; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                list.Add((read[0], read[1], read[2]));
            }
            var ok = true;
            (int min, int x, int y) now = (0, 0, 0);
            for (int i = 0; i < list.Count(); i++)
            {
                var dif = Math.Abs(list[i].x - now.x) + Math.Abs(list[i].y - now.y);
                var difTime = Math.Abs(list[i].min - now.min);
                if (dif > difTime)
                {
                    ok = false;
                    break;
                }
                else if (dif % 2 == 0 && difTime % 2 == 1)
                {
                    ok = false;
                    break;
                }
                else if (dif % 2 == 1 && difTime % 2 == 0)
                {
                    ok = false;
                    break;
                }
                now = (list[i].min, list[i].x, list[i].y);
            }
            if (ok) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
        public static void ABC096_C()
        {
            var HW = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var fields = new char[HW[0]][];
            for (int i = 0; i < HW[0]; i++)
            {
                fields[i] = Console.ReadLine().ToCharArray();
            }
            var x = new int[] { -1, 0, 1 };
            var y = new int[] { -1, 0, 1 };
            var ok = true;
            for (int i = 0; i < HW[0]; i++)
            {
                for (int j = 0; j < HW[1]; j++)
                {
                    if (fields[i][j] == '#')
                    {
                        var check = false;
                        foreach (var dx in x)
                        {
                            foreach (var dy in y)
                            {
                                if ((dx == 1 && dy == 1) || (dx == -1 && dy == 1) || (dx == 1 && dy == -1) || (dx == -1 && dy == -1) || (dx == 0 && dy == 0))
                                {
                                    continue;
                                }
                                if (i + dy >= 0 && i + dy <= HW[0] - 1 && j + dx >= 0 && j + dx <= HW[1] - 1)
                                {
                                    if (fields[i + dy][j + dx] == '#')
                                    {
                                        check = true;
                                    }
                                }

                            }
                        }
                        if (check == false)
                        {
                            Console.WriteLine("No");
                            return;
                        }
                    }

                }
            }
            if (ok) Console.WriteLine("Yes");
        }
        public static void keyence2019_B()
        {
            var S = Console.ReadLine();
            for (int i = 0; i < S.Length; i++)
            {
                for (int j = i; j < S.Length; j++)
                {
                    String temp = "";
                    temp += S.Substring(0, i);
                    temp += S.Substring(j, S.Length - j);
                    if (temp == "keyence")
                    {
                        Console.WriteLine("YES");
                        return;
                    }
                }
            }
            Console.WriteLine("NO");
        }
        public static void ABC063_C()
        {
            int N = int.Parse(Console.ReadLine());
            var s = new int[N];
            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                s[i] = int.Parse(Console.ReadLine());
                sum += s[i];
            }
            if (sum % 10 != 0)
            {
                Console.WriteLine(sum);
            }
            else
            {
                int min = intMax;
                for (int i = 0; i < N; i++)
                {
                    if (s[i] % 10 != 0)
                    {
                        min = Math.Min(min, s[i]);
                    }
                }
                if (min != intMax)
                {
                    Console.WriteLine(sum - min);
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
        public static void ABC222_A()
        {
            var N = Console.ReadLine().ToCharArray();
            string temp = "";
            while (N.Length != 4)
            {
                temp = "0" + new string(N);
                N = temp.ToCharArray();
            }
            Console.WriteLine(new string(N));
        }
        public static void ABC222_B()
        {
            var NP = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = 0;
            for (int i = 0; i < NP[0]; i++)
            {
                if (a[i] < NP[1])
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        public static void ABC222_C()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var a = new char[2 * NM[0]][];
            var score = new (int, int)[2 * NM[0]];
            for (int i = 0; i < 2 * NM[0]; i++)
            {
                score[i] = (i, 0);
                a[i] = Console.ReadLine().ToCharArray();
            }
            for (int i = 0; i < NM[1]; i++)
            {
                for (int j = 0; j < 2 * NM[0]; j += 2)
                {
                    if (a[score[j].Item1][i] == 'G' && a[score[j + 1].Item1][i] == 'P' || a[score[j].Item1][i] == 'P' && a[score[j + 1].Item1][i] == 'C' || a[score[j].Item1][i] == 'C' && a[score[j + 1].Item1][i] == 'G')
                    {
                        score[j + 1].Item2++;
                    }
                    else if (a[score[j + 1].Item1][i] == 'G' && a[score[j].Item1][i] == 'P' || a[score[j + 1].Item1][i] == 'P' && a[score[j].Item1][i] == 'C' || a[score[j + 1].Item1][i] == 'C' && a[score[j].Item1][i] == 'G')
                    {
                        score[j].Item2++;
                    }
                }
                score = score.ToList().OrderByDescending(x => x.Item2).ThenBy(x => x.Item1).ToArray();
            }
            for (int i = 0; i < score.Length; i++)
            {
                Console.WriteLine(score[i].Item1 + 1);
            }
        }
        public static void ABC222_D()
        {
            int N = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var b = Console.ReadLine().Split().Select(int.Parse).ToArray();

            long mod = 998244353;
            int max = Math.Max(a.Max(), b.Max());
            var dp = new long[N + 1, max + 1];
            dp[0, 0] = 1;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < max; j++)
                {
                    //i番目jまでの累積和を計算しておく
                    dp[i, j + 1] += dp[i, j];
                }
                for (int j = a[i]; j <= b[i]; j++)
                {
                    //上で累積和を計算しているのでこれを利用してO(1)でi+1のjを更新可能
                    dp[i + 1, j] += dp[i, j];
                    dp[i + 1, j] %= mod;
                }
            }
            long ans = 0;
            for (int i = 0; i <= max; i++)
            {
                ans += dp[N, i];
                ans %= mod;
            }
            Console.WriteLine(ans);

        }
        public static void ARC073_C()
        {
            var NT = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var t = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long ans = 0;
            for (int i = 0; i < t.Length - 1; i++)
            {
                ans += Math.Min(t[i + 1] - t[i], NT[1]);
            }
            ans += NT[1];
            Console.WriteLine(ans);
        }
        public static void ABC088_C()
        {
            var grid = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < 3; j++)
                {
                    grid[i, j] = read[j];
                }
            }
            for (int i = 0; i <= 100; i++)
            {
                for (int j = 0; j <= 100; j++)
                {
                    for (int k = 0; k <= 100; k++)
                    {
                        var tempB = new int[] { grid[0, 0] - i, grid[0, 1] - i, grid[0, 2] - i };
                        bool ok = true;
                        for (int l = 1; l < 3; l++)
                        {
                            if (l == 1 && (tempB[0] != grid[l, 0] - j || tempB[1] != grid[l, 1] - j || tempB[2] != grid[l, 2] - j))
                            {
                                ok = false;
                            }
                            else if (l == 2 && (tempB[0] != grid[l, 0] - k || tempB[1] != grid[l, 1] - k || tempB[2] != grid[l, 2] - k))
                            {
                                ok = false;
                            }
                        }
                        if (ok)
                        {
                            Console.WriteLine("Yes");
                            return;
                        }
                    }
                }
            }
            Console.WriteLine("No");
        }
        public static void AGC003_A()
        {
            var s = Console.ReadLine().ToCharArray();
            int N = 0;
            int S = 0;
            int W = 0;
            int E = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'N')
                {
                    N++;
                }
                else if (s[i] == 'S')
                {
                    S++;
                }
                else if (s[i] == 'W')
                {
                    W++;
                }
                else if (s[i] == 'E')
                {
                    E++;
                }
            }
            if (N != 0 && S == 0 || N == 0 && S != 0 || E != 0 && W == 0 || E == 0 && W != 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
        }
        public static void diverta2019_B()
        {
            var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long count = 0;
            for (int i = 0; i <= read[3] / read[0]; i++)
            {
                for (int j = 0; j <= (read[3] - i * read[0]) / read[1]; j++)
                {
                    if ((read[3] - i * read[0] - j * read[1]) % read[2] == 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
        public static void ABC073_C()
        {
            int N = int.Parse(Console.ReadLine());
            var A = new Dictionary<long, int>();
            for (int i = 0; i < N; i++)
            {
                var read = long.Parse(Console.ReadLine());

                if (A.ContainsKey(read))
                {
                    A[read]++;
                }
                else
                {
                    A.Add(read, 1);
                }
            }
            var count = 0;
            foreach (var a in A)
            {
                if (a.Value % 2 != 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);

        }
        public static void ABC159_D()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var list = new long[N + 1];

            for (int i = 0; i < N; i++)
            {
                list[A[i]]++;
            }
            long all = 0;
            for (int i = 0; i <= N; i++)
            {
                if (list[i] > 0)
                    all += list[i] * (list[i] - 1) / 2;
            }
            for (int i = 0; i < N; i++)
            {
                long ans = 0;
                if (A[i] > 0)
                    ans = all - (list[A[i]] - 1);
                Console.WriteLine(ans);
            }
        }
        public static void ABC053_B()
        {
            var s = Console.ReadLine().ToCharArray();
            int indexA = intMax;
            int indexZ = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'A')
                {
                    indexA = Math.Min(indexA, i);
                }
                else if (s[i] == 'Z')
                {
                    indexZ = i;
                }
            }
            Console.WriteLine(indexZ - (indexA - 1));
        }
        public static void ABC157_C()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var sc = new (int, int)[NM[1]];
            var max = 0;
            for (int i = 0; i < NM[1]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                sc[i].Item1 = read[0];
                sc[i].Item2 = read[1];
                max = Math.Max(max, sc[i].Item1);
            }
            int ans = intMax;
            for (int i = 0; i < 1000; i++)
            {
                bool ok = true;
                var charI = Convert.ToString(i).ToCharArray();
                if (charI.Length != NM[0]) ok = false;
                for (int j = 0; j < sc.Length; j++)
                {

                    if (charI.Length >= sc[j].Item1 && sc[j].Item2 != (charI[sc[j].Item1 - 1] - '0'))
                    {
                        ok = false;
                    }

                }
                if (ok) ans = Math.Min(ans, i);
            }
            if (ans == intMax) ans = -1;
            Console.WriteLine(ans);
        }
        public static void AGC015_A()
        {
            var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long ans = 0;
            if ((read[0] != 1 && read[1] <= read[2]) || (read[0] == 1 && read[1] == read[2]))
            {
                ans = ((read[0] - 1) * read[2] + read[1]) - ((read[0] - 1) * read[1] + read[2]) + 1;
            }
            Console.WriteLine(ans);
        }
        public static void ARC128_A()
        {
            int N = int.Parse(Console.ReadLine());
            var v = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var ans = new StringBuilder();
            bool gold = true;
            for (int i = 0; i < N - 1; i++)
            {
                if (gold == true && v[i] > v[i + 1])
                {
                    ans.Append("1 ");
                    gold = false;
                }
                else if (i >= 1 && gold == false && v[i] <= v[i + 1])
                {
                    ans.Append("1 ");
                    gold = true;
                }
                else
                {
                    ans.Append("0 ");
                }
            }
            if (gold == false)
            {
                ans.Append("1");
                Console.WriteLine(ans);
            }
            else
            {
                ans.Append("0");
                Console.WriteLine(ans);
            }
        }
        public static void ARC128_B()
        {
            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
                Array.Sort(read);
                long count = longMax;
                var ok = false;

                if ((read[1] - read[0]) % 3 == 0)
                {
                    ok = true;
                    count = Math.Min(count, read[1]);
                }
                if ((read[2] - read[0]) % 3 == 0)
                {
                    ok = true;
                    count = Math.Min(count, read[2]);
                }
                if ((read[2] - read[1]) % 3 == 0)
                {
                    ok = true;
                    count = Math.Min(count, read[2]);
                }
                if (ok) Console.WriteLine(count);
                else Console.WriteLine(-1);
            }
        }
        public static void ARC086_C()
        {
            var NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var list = new Dictionary<int, int>();
            for (int i = 0; i < NK[0]; i++)
            {
                if (list.ContainsKey(A[i]))
                {
                    list[A[i]]++;
                }
                else
                {
                    list.Add(A[i], 1);
                }
            }
            list = list.OrderBy(x => x.Value).ToDictionary(key => key.Key, val => val.Value);
            long ans = 0;
            long now = list.Count();
            if (now > NK[1])
            {
                foreach (var l in list)
                {
                    ans += l.Value;
                    now--;
                    if (now == NK[1]) break;
                }
            }
            Console.WriteLine(ans);

        }
        public static void ABC223_C()
        {
            int N = int.Parse(Console.ReadLine());
            var A = new int[N];
            var B = new int[N];
            double time = 0;
            for (int i = 0; i < N; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                A[i] = read[0];
                B[i] = read[1];
                time += A[i] / (double)B[i];
            }
            time /= 2;
            double burnA = 0;
            double pretime = 0;
            double burned = 0;
            int index = 0;
            while (burnA < time)
            {
                burnA += A[index] / (double)B[index];
                if (index > 0)
                {
                    pretime += A[index - 1] / (double)B[index - 1];
                    burned += A[index - 1];
                }
                index++;
            }
            double ans = burned + (B[index - 1] * (time - pretime));
            Console.WriteLine(ans);
        }
        public static void ABC123_D()
        {
            int N = int.Parse(Console.ReadLine());
            var list = new List<(long, long)>();
            for (int i = 0; i < N; i++)
            {
                var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
                list.Add((read[0], read[1]));
            }
            long left = 0;
            long right = longMax;
            var t = new long[N];
            while (right - left > 1)
            {
                long mid = (right + left) / 2;
                bool ok = true;
                for (int i = 0; i < N; i++)
                {
                    if (mid < list[i].Item1) ok = false;
                    else t[i] = (mid - list[i].Item1) / list[i].Item2;
                }
                Array.Sort(t);
                for (int i = 0; i < N; i++)
                {
                    if (t[i] < i) ok = false;
                }
                if (ok) right = mid;
                else left = mid;
            }
            Console.WriteLine(right);


        }
        public static void ABC058_B()
        {
            var O = Console.ReadLine();
            var E = Console.ReadLine();
            String ans = "";
            int index = 0;
            while (index <= O.Length || index <= E.Length)
            {
                if (index < O.Length)
                    ans += O[index];
                if (index < E.Length)
                    ans += E[index];
                index++;
            }
            Console.WriteLine(ans);
        }
        public static void ABC148_D()
        {
            int N = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int now = 0;
            for (int i = 0; i < N; i++)
            {
                if (a[i] == now + 1)
                {
                    now++;
                }
            }
            int ans = 0;
            if (now != 0)
                ans = N - now;
            else ans = -1;
            Console.WriteLine(ans);
        }
        public static void ABC223_D()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var A = new int[NM[1]];
            var B = new int[NM[1]];
            var graph = new List<List<int>>();
            for (int i = 0; i < NM[0]; i++)
            {
                graph.Add(new List<int>());
            }
            var indeg = new int[NM[0]];
            for (int i = 0; i < NM[1]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                A[i] = read[0] - 1;
                B[i] = read[1] - 1;
                graph[A[i]].Add(B[i]);
                indeg[B[i]]++;
            }
            var heap = new PriorityQueue<int>(NM[0], Comparer<int>.Create((x, y) => (y - x)));
            for (int i = 0; i < NM[0]; i++)
            {
                if (indeg[i] == 0)
                {
                    heap.Push(i);
                }
            }
            var ans = new List<int>();
            while (heap.Count != 0)
            {
                int i = heap.Pop();
                ans.Add(i);
                foreach (var l in graph[i])
                {
                    indeg[l]--;
                    if (indeg[l] == 0)
                    {
                        heap.Push(l);
                    }
                }
            }
            if (ans.Count != NM[0])
            {
                Console.WriteLine(-1);
            }
            else
            {
                for (int i = 0; i < NM[0]; i++)
                {
                    if (i == NM[0] - 1)
                    {
                        Console.WriteLine(ans[i] + 1);
                    }
                    else
                    {
                        Console.Write($"{ans[i] + 1} ");
                    }
                }
            }
        }
        public static void AGC013_A()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            int count = 0;
            if (N == 1)
            {
                Console.WriteLine(1);
                return;
            }
            int index = 0;
            while (index < N - 1)
            {
                int tempUp = index;
                int tempDown = index;

                while (tempUp != N - 1 && A[tempUp] <= A[tempUp + 1])
                {
                    tempUp++;
                }
                while (tempDown != N - 1 && A[tempDown] >= A[tempDown + 1])
                {
                    tempDown++;
                }
                count++;
                index = Math.Max(tempDown, tempUp) + 1;
            }
            if (index < N) count++;
            Console.WriteLine(count);
        }
        public static void AGC006_A()
        {
            int N = int.Parse(Console.ReadLine());
            var s = Console.ReadLine();
            var t = Console.ReadLine();
            int ans = s.Length + t.Length;
            var temp = 0;
            for (int i = 0; i < Math.Min(s.Length, t.Length); i++)
            {
                bool ok = true;
                for (int j = 0; j <= i; j++)
                {
                    if (s[s.Length - 1 - i + j] != t[j])
                    {
                        ok = false;
                    }
                }
                if (ok) temp = Math.Max(temp, i + 1);
            }
            ans -= temp;
            Console.WriteLine(ans);
        }
        public static void ABC154_D()
        {
            var NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var p = Console.ReadLine().Split().Select(int.Parse).ToArray();
            double ans = 0;
            var sum = new double[NK[0] + 1];
            for (int i = 1; i <= NK[0]; i++)
            {
                sum[i] = sum[i - 1] + (((double)p[i - 1] + 1) * (p[i - 1])) / 2 / p[i - 1];
            }
            for (int i = 0; i < NK[0] - (NK[1] - 1); i++)
            {
                double temp = sum[NK[1] + i] - sum[i];
                ans = Math.Max(temp, ans);
            }
            Console.WriteLine(ans);
        }
        public static void ABC082_B()
        {
            var s = Console.ReadLine().ToCharArray();
            var t = Console.ReadLine().ToCharArray();
            Array.Sort(s);
            Array.Sort(t);
            Array.Reverse(t);

            bool ok = true;
            bool equal = true;
            for (int i = 0; i < Math.Min(s.Length, t.Length); i++)
            {
                if (((t[i] - 'a') - (s[i] - 'a')) < 0)
                {
                    ok = false;
                    equal = false;
                    break;
                }
                else if (((t[i] - 'a') - (s[i] - 'a')) > 0)
                {
                    equal = false;
                    break;
                }
            }
            if (!ok)
            {
                Console.WriteLine("No");
            }
            else if (ok && equal && s.Length >= t.Length)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
        }
        public static void ARC091_C()
        {
            var NM = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long ans = 0;
            if (NM[0] == 1 && NM[1] == 1)
            {
                ans = 1;
            }
            else if (NM[0] == 1)
            {
                ans = Math.Max(0, NM[1] - 2);
            }
            else if (NM[1] == 1)
            {
                ans = Math.Max(0, NM[0] - 2);
            }
            else
            {
                ans = Math.Max(0, NM[0] * NM[1] - ((NM[1] - 2) * 2 + NM[0] * 2));
            }
            Console.WriteLine(ans);
        }
        public static void ARC080_C()
        {
            int N = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int not2 = 0;
            int ok4 = 0;
            for (int i = 0; i < N; i++)
            {
                if (a[i] % 2 != 0)
                {
                    not2++;
                }
                else if (a[i] % 4 == 0)
                {
                    ok4++;
                }
            }
            if (ok4 >= not2)
            {
                Console.WriteLine("Yes");
            }
            else if (ok4 == (not2 - 1) && (ok4 + not2) == N)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        public static void ABC085_C()
        {
            var NY = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long max = NY[0] * 10000;
            long dx = max - NY[1];
            long count5 = 0;
            long count1 = 0;
            bool ok = false;
            for (int i = 0; i <= dx / 5000; i++)
            {
                if ((dx - 5000 * i) % 9000 == 0)
                {
                    count1 = (dx - 5000 * i) / 9000;
                    count5 = i;
                    if (count1 + count5 <= NY[0])
                    {
                        ok = true;
                        break;
                    }
                }
            }
            if (ok)
            {
                Console.WriteLine($"{NY[0] - count5 - count1} {count5} {count1}");
            }
            else if (dx == 0)
            {
                Console.WriteLine($"{NY[0]} 0 0");
            }
            else
            {
                Console.WriteLine("-1 -1 -1");
            }
        }
        public static void ABC043_B()
        {
            var s = Console.ReadLine().ToCharArray();
            var ans = new List<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != 'B')
                {
                    ans.Add(s[i]);
                }
                else
                {
                    if (ans.Count > 0)
                        ans.RemoveAt(ans.Count() - 1);
                }
            }
            Console.WriteLine(new String(ans.ToArray()));
        }
        public static void ARC099_C()
        {
            var NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int index = Array.IndexOf(A, 1);
            int ans = 0;
            ans += (NK[0] - 1) / (NK[1] - 1);
            if ((NK[0] - 1) % (NK[1] - 1) != 0)
            {
                ans++;
            }
            Console.WriteLine(ans);
        }
        public static void ABC224_A()
        {
            var S = Console.ReadLine();
            var er = S.Substring(S.Length - 2, 2);
            if (er == "er")
            {
                Console.WriteLine("er");
            }
            else
            {
                Console.WriteLine("ist");
            }
        }
        public static void ABC224_B()
        {
            var HW = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var fields = new long[HW[0], HW[1]];
            bool ok = true;
            for (int i = 0; i < HW[0]; i++)
            {
                var read = Console.ReadLine().Split().Select(long.Parse).ToArray();

                for (int j = 0; j < HW[1]; j++)
                {
                    fields[i, j] = read[j];
                }
            }
            for (int i = 0; i < HW[0]; i++)
            {

                for (int j = i + 1; j < HW[0]; j++)
                {
                    for (int l = 0; l < HW[1]; l++)
                    {
                        for (int m = l + 1; m < HW[1]; m++)
                        {
                            if (fields[i, l] + fields[j, m] > fields[j, l] + fields[i, m])
                            {
                                ok = false;
                            }
                        }
                    }

                }
            }
            if (ok)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
        public static void ABC224_C()
        {
            int N = int.Parse(Console.ReadLine());
            var list = new (long, long)[N];
            long ans = 0;
            for (int i = 0; i < N; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                list[i] = (read[0], read[1]);
            }
            for (int i = 0; i < N - 2; i++)
            {
                for (int j = i + 1; j < N - 1; j++)
                {
                    for (int k = j + 1; k < N; k++)
                    {
                        long a = Math.Abs((list[j].Item1 - list[i].Item1) * (list[k].Item2 - list[i].Item2) - (list[j].Item2 - list[i].Item2) * (list[k].Item1 - list[i].Item1));
                        if (a > 0)
                        {
                            ans++;
                        }
                    }
                }
            }
            Console.WriteLine(ans);
        }
        public static void ABC224_D()
        {
            int M = int.Parse(Console.ReadLine());
            var graph = new List<List<int>>();
            for (int i = 0; i <= 9; i++)
            {
                graph.Add(new List<int>());
            }
            for (int i = 0; i < M; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                graph[read[0]].Add(read[1]);
                graph[read[1]].Add(read[0]);
            }
            var p = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var s = new char[] { '9', '9', '9', '9', '9', '9', '9', '9', '9' };
            for (int i = 0; i < 8; i++)
            {
                s[p[i] - 1] = Convert.ToString(i + 1)[0];
            }
            String first = new string(s);
            var q = new Queue<String>();
            q.Enqueue(first);
            var dic = new Dictionary<String, int>();
            dic.Add(first, 0);
            while (q.Count > 0)
            {
                String temp = q.Dequeue();
                int empI = -1;
                for (int i = 1; i <= 9; i++)
                {
                    if (temp[i - 1] == '9') empI = i;
                }
                foreach (var u in graph[empI])
                {
                    var t = temp.ToCharArray();
                    t[empI - 1] = temp[u - 1];
                    t[u - 1] = '9';
                    String st = new string(t);
                    if (dic.ContainsKey(st)) continue;
                    dic.Add(st, dic[temp] + 1);
                    q.Enqueue(st);
                }
            }
            if (!dic.ContainsKey("123456789")) Console.WriteLine(-1);
            else Console.WriteLine(dic["123456789"]);
        }
        public static void ABC109_C()
        {
            var NX = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var x = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (NX[0] == 1)
            {
                Console.WriteLine(Math.Abs(NX[1] - x[0]));
                return;
            }
            long ans = gcd(Math.Abs(x[0] - NX[1]), Math.Abs(x[1] - NX[1]));
            for (int i = 2; i < NX[0]; i++)
            {
                ans = gcd(ans, Math.Abs(x[i] - NX[1]));
            }
            Console.WriteLine(ans);
            long gcd(long C, long D)
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
                //最小公倍数を返す
                //var CD = (long)Math.Floor(((decimal)C * D) / tempC);
                return tempC;
            }
        }
        public static void ABC116_C()
        {
            int N = int.Parse(Console.ReadLine());
            var h = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long ans = 0;
            bool allzero = false;
            while (!allzero)
            {
                allzero = true;
                bool flag = false;
                for (int i = 0; i < N; i++)
                {
                    if (h[i] != 0)
                    {
                        allzero = false;
                        if (!flag)
                        {
                            ans++;
                            flag = true;
                        }
                        h[i]--;
                    }
                    else
                    {
                        flag = false;
                    }
                }
            }
            Console.WriteLine(ans);
        }
        public static void ABC220_E()
        {
            var ND = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long mod = 998244353;
            var f = new long[ND[0] + 1];
            var g = new long[ND[0] + 1];
            var two = new long[ND[0] + 1];
            two[0] = 1;
            long test = mod * mod;
            for (int i = 1; i <= ND[0]; i++)
            {
                two[i] = two[i - 1] * 2;
                two[i] %= mod;
            }
            for (int i = 1; i <= ND[0]; i++)
            {
                int l = i - 1;
                int r = ND[1] - l;
                long leaf = 0;
                if (0 <= r && r <= i - 1)
                {
                    leaf = (long)two[Math.Max(l - 1, 0)] * two[Math.Max(r - 1, 0)];
                    leaf %= mod;
                    if (l != r)
                    {
                        leaf *= 2;
                        leaf %= mod;
                    }
                }
                g[i] = g[i - 1] + leaf;
                g[i] %= mod;
            }
            for (int i = 1; i <= ND[0]; i++)
            {
                f[i] = f[i - 1] * 2;
                f[i] %= mod;
                f[i] += g[i];
                f[i] %= mod;
            }
            Console.WriteLine((f[ND[0]] * 2) % mod);
            /*long pow(long x, int n)
            {
                long ret = 1;
                while(n > 0)
                {
                    if((n & 1) > 0) ret *= x;
                    x *= x;
                    n = n >> 1;
                }
                return ret;
            }*/
        }
        public static void codefes2017_B()
        {
            int N = int.Parse(Console.ReadLine());
            var D = Console.ReadLine().Split().Select(long.Parse).ToArray();
            int M = int.Parse(Console.ReadLine());
            var T = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var set = new Dictionary<long, int>();
            for (int i = 0; i < N; i++)
            {
                if (set.ContainsKey(D[i]))
                {
                    set[D[i]]++;
                }
                else
                {
                    set.Add(D[i], 1);
                }
            }
            var ok = true;
            for (int i = 0; i < M; i++)
            {
                if (set.ContainsKey(T[i]))
                {
                    if (set[T[i]] == 0)
                    {
                        ok = false;
                    }
                    else
                    {
                        set[T[i]]--;
                    }
                }
                else
                {
                    ok = false;
                }
            }
            if (ok) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
        public static void minna2019_C()
        {
            var KAB = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long ans = 0;
            if (KAB[0] <= KAB[1])
            {
                ans = KAB[0] + 1;
            }
            else if (KAB[2] - KAB[1] >= 2)
            {
                ans += (Math.Max(0, KAB[0] - KAB[1] + 1)) / 2 * Math.Abs(KAB[2] - KAB[1]) + KAB[1];
                if (Math.Abs(KAB[0] - KAB[1] + 1) % 2 != 0)
                {
                    ans++;
                }
            }
            else
            {
                ans += KAB[0] + 1;
            }
            Console.WriteLine(ans);
        }
        public static void ABC117_C()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var X = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long ans = 0;
            if (NM[0] >= NM[1])
            {
                Console.WriteLine(ans);
                return;
            }
            Array.Sort(X);
            var distance = new int[NM[1] - 1];
            for (int i = 0; i < NM[1] - 1; i++)
            {
                distance[i] = X[i + 1] - X[i];
            }
            Array.Sort(distance);
            ans = (X[NM[1] - 1] - X[0]);
            for (int i = 0; i < NM[0] - 1; i++)
            {
                ans -= distance[NM[1] - 2 - i];
            }
            Console.WriteLine(ans);
        }
        public static void AGC016_A()
        {
            String s = Console.ReadLine();
            int ans = 101;
            var alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            foreach (var a in alphabet)
            {
                int temp = 0;
                int cnt = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == a)
                    {
                        cnt = 0;
                        continue;
                    }
                    cnt++;
                    temp = Math.Max(temp, cnt);
                }
                ans = Math.Min(ans, temp);
            }
            Console.WriteLine(ans);
        }
        public static void AGC015_B()
        {
            var S = Console.ReadLine().ToCharArray();
            long ans = 0;
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == 'U')
                {
                    ans += (S.Length - 1) - i;
                    ans += i * 2;
                }
                else
                {
                    ans += i;
                    ans += (S.Length - 1 - i) * 2;
                }
            }
            Console.WriteLine(ans);
        }
        public static void ABC056_C()
        {
            long X = long.Parse(Console.ReadLine());
            int ans = 0;
            for (int i = 0; i < 1000000000; i++)
            {
                if ((i + 1) * i / 2 > X)
                {
                    ans = i;
                    break;
                }
                else if ((i + 1) * i / 2 == X)
                {
                    ans = i;
                    break;
                }
            }
            Console.WriteLine(ans);
        }
        public static void ABC049_B()
        {
            var HW = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var C = new char[HW[0]][];
            for (int i = 0; i < HW[0]; i++)
            {
                C[i] = Console.ReadLine().ToCharArray();
            }
            for (int i = 0; i < HW[0]; i++)
            {
                Console.WriteLine(C[i]);
                Console.WriteLine(C[i]);
            }

        }
        public static void ARC081_C()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            Array.Sort(A);
            Array.Reverse(A);
            var list = new Dictionary<long, long>();
            var edge = new List<long>();
            long ans = 0;
            for (int i = 0; i < N; i++)
            {
                if (list.ContainsKey(A[i]))
                {
                    list[A[i]]++;
                }
                else
                {
                    list.Add(A[i], 1);
                }
                if (list[A[i]] >= 2 && !edge.Contains(A[i]) || list[A[i]] == 4)
                {
                    edge.Add(A[i]);
                }
                if (edge.Count() == 2)
                {
                    ans = edge[0] * edge[1];
                }
            }
            Console.WriteLine(ans);
        }
        public static void ABC066_C()
        {
            int n = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var ans = new List<int>();
            if (n % 2 == 0)
            {
                ans.Add(a[0]);
                for (int i = 1; i < n; i++)
                {
                    if (i % 2 == 1)
                    {
                        ans.Insert(0, a[i]);
                    }
                    else
                    {
                        ans.Add(a[i]);
                    }
                }
            }
            else
            {
                ans.Add(a[0]);
                for (int i = 1; i < n; i++)
                {
                    if (i % 2 == 1)
                    {
                        ans.Add(a[i]);
                    }
                    else
                    {
                        ans.Insert(0, a[i]);
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (i != n - 1)
                    Console.Write($"{ans[i]} ");
                else
                    Console.WriteLine($"{ans[i]}");
            }
        }
        public static void ARC069_C()
        {
            var NM = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long ans = 0;
            long temp = Math.Min(NM[0], NM[1] / 2);
            ans += temp;
            NM[0] -= temp;
            NM[1] -= temp * 2;
            temp = NM[1] / 4;
            ans += temp;
            Console.WriteLine(ans);
        }
        public static void typical90_001()
        {
            var NL = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int K = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long left = 0;
            long right = NL[1];
            long pre = 0;
            while (right - left > 1)
            {
                long mid = (right + left) / 2;
                bool ok = true;
                long cut = 0;
                long temp = 0;
                for (int i = 0; i < NL[0]; i++)
                {
                    if (i == 0) temp = A[0];
                    else temp += A[i] - A[i - 1];
                    if (temp - pre >= mid)
                    {
                        pre = A[i];
                        cut++;
                    }
                    if (cut == K && NL[1] - temp >= mid)
                    {
                        break;
                    }
                    if ((i == NL[0] - 1 && cut < K) || NL[1] - temp < mid)
                    {
                        ok = false;
                    }
                }
                if (ok) left = mid;
                else right = mid;
                pre = 0;
            }
            Console.WriteLine(left);
        }
        public static void typical90_002()
        {
            int N = int.Parse(Console.ReadLine());
            if (N % 2 != 0)
            {
                return;
            }
            String S = "(";
            void dfs(String s)
            {
                if (s.Length == N)
                {
                    int left = 0;
                    int right = 0;
                    for (int i = 0; i < s.Length; i++)
                    {
                        if (s[i] == '(')
                        {
                            left++;
                        }
                        else
                        {
                            right++;
                        }
                        if (right > left)
                        {
                            return;
                        }
                        if (i == s.Length - 1 && right != left)
                        {
                            return;
                        }
                    }
                    Console.WriteLine(s);
                    return;
                }
                dfs(s + "(");
                dfs(s + ")");
            }
            dfs(S);
        }
        /// <summary>
        /// 木の直径
        /// </summary>
        public static void typical90_003()
        {
            int N = int.Parse(Console.ReadLine());
            var graph = new List<List<int>>();
            for (int i = 0; i < N + 1; i++)
            {
                graph.Add(new List<int>());
            }
            for (int i = 0; i < N - 1; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                graph[read[0]].Add(read[1]);
                graph[read[1]].Add(read[0]);
            }
            var d = new int[N + 1];
            void bfs(int s)
            {
                for (int i = 0; i < N + 1; i++)
                {
                    d[i] = intMax;
                }
                var q = new Queue<int>();
                q.Enqueue(s);
                d[s] = 0;
                int now;
                while (q.Count != 0)
                {
                    now = q.Dequeue();
                    foreach (var v in graph[now])
                    {
                        if (d[v] == intMax)
                        {
                            d[v] = d[now] + 1;
                            q.Enqueue(v);
                        }
                    }
                }
            }
            bfs(1);
            int tempMaxV = 0;
            int tempMax = 0;
            for (int i = 1; i <= N; i++)
            {
                if (d[i] == intMax) continue;
                if (tempMax < d[i])
                {
                    tempMax = d[i];
                    tempMaxV = i;
                }
            }
            bfs(tempMaxV);
            int max = 0;
            for (int i = 1; i <= N; i++)
            {
                max = Math.Max(max, d[i]);
            }
            Console.WriteLine(max + 1);
        }
        public static void typical90_004()
        {
            var HW = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var A = new long[HW[0]][];
            var rowSum = new long[HW[0]];
            var colSum = new long[HW[1]];
            for (int i = 0; i < HW[0]; i++)
            {
                A[i] = Console.ReadLine().Split().Select(long.Parse).ToArray();
                for (int j = 0; j < HW[1]; j++)
                {
                    rowSum[i] += A[i][j];
                    colSum[j] += A[i][j];
                }
            }
            for (int i = 0; i < HW[0]; i++)
            {
                var s = new StringBuilder();
                for (int j = 0; j < HW[1]; j++)
                {
                    if (j != HW[1] - 1)
                    {
                        s.Append($"{rowSum[i] + colSum[j] - A[i][j]} ");
                    }
                    else
                    {
                        s.Append($"{rowSum[i] + colSum[j] - A[i][j]}");
                    }
                }
                Console.WriteLine(s);
            }

        }
        public static void ABC225_A()
        {
            var s = Console.ReadLine().ToCharArray();
            int ans = 0;
            if (s[0] == s[1] && s[0] != s[2] || s[0] == s[2] && s[0] != s[1] || s[1] == s[2] && s[1] != s[0])
            {
                ans = 3;
            }
            else if (s[0] == s[1] && s[0] == s[2])
            {
                ans = 1;
            }
            else
            {
                ans = 6;
            }
            Console.WriteLine(ans);

        }
        public static void ABC225_B()
        {
            int N = int.Parse(Console.ReadLine());
            var graph = new List<List<int>>();
            for (int i = 0; i < N + 1; i++)
            {
                graph.Add(new List<int>());
            }
            for (int i = 0; i < N - 1; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                graph[read[0]].Add(read[1]);
                graph[read[1]].Add(read[0]);
            }
            var ok = false;
            foreach (var g in graph)
            {
                var list = new List<int>();
                foreach (var v in g)
                {
                    if (!list.Contains(v))
                        list.Add(v);
                }
                if (list.Count() == N - 1)
                    ok = true;
            }
            if (ok) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
        public static void ABC225_C()
        {
            var NM = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var B = new long[NM[0]][];
            for (int i = 0; i < NM[0]; i++)
            {
                B[i] = Console.ReadLine().Split().Select(long.Parse).ToArray();
            }
            var ok = true;
            if (NM[1] != 1 && NM[0] != 1)
            {
                for (int i = 0; i < NM[0] - 1; i++)
                {
                    for (int j = 0; j < NM[1] - 1; j++)
                    {
                        if (B[i + 1][j] - B[i][j] != 7)
                        {
                            ok = false;
                        }
                        if (B[i][j + 1] - B[i][j] != 1 || B[i][j] % 7 == 0)
                        {
                            ok = false;
                        }
                    }
                }
            }
            else if (NM[0] == 1 && NM[1] == 1)
            {
                bool temp = false;
                for (int i = 1; i < 8; i++)
                {
                    if ((B[0][0] - i) % 7 == 0)
                    {
                        temp = true;

                    }
                }
                if (!temp) ok = false;
            }
            else if (NM[1] == 1)
            {
                for (int i = 0; i < NM[0] - 1; i++)
                {
                    if (B[i + 1][0] - B[i][0] != 7)
                    {
                        ok = false;
                    }
                }
            }
            else if (NM[0] == 1)
            {
                for (int i = 0; i < NM[1] - 1; i++)
                {
                    if (B[0][i + 1] - B[0][i] != 1 || B[0][i] % 7 == 0)
                    {
                        ok = false;
                    }
                }
            }

            if (ok) Console.WriteLine("Yes");
            else Console.WriteLine("No");

        }
        public static void ABC225_D()
        {
            var NQ = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var front = new int[NQ[0] + 1];
            var back = new int[NQ[0] + 1];
            for (int i = 0; i < NQ[1]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (read[0] == 1)
                {
                    front[read[2]] = read[1];
                    back[read[1]] = read[2];
                }
                else if (read[0] == 2)
                {
                    back[read[1]] = 0;
                    front[read[2]] = 0;
                }
                else
                {
                    int x = read[1];
                    while (front[x] != 0)
                    {
                        x = front[x];
                    }
                    var ans = new List<int>();
                    ans.Add(x);
                    while (back[x] != 0)
                    {
                        ans.Add(back[x]);
                        x = back[x];
                    }
                    var sb = new StringBuilder();
                    sb.Append($"{ans.Count()} ");
                    for (int j = 0; j < ans.Count(); j++)
                    {
                        if (j != ans.Count() - 1)
                            sb.Append($"{ans[j]} ");
                        else sb.Append(ans[j]);
                    }
                    Console.WriteLine(sb);
                }
            }
        }
        public static void codefes2017final_B()
        {
            var S = Console.ReadLine().ToCharArray();
            var count = new Dictionary<char, int>();
            for (int i = 0; i < S.Length; i++)
            {
                if (!count.ContainsKey(S[i]))
                {
                    count.Add(S[i], 1);
                }
                else
                {
                    count[S[i]]++;
                }
            }
            bool ok = true;
            if (count.Count() == 1)
            {
                foreach (var a in count)
                {
                    if (a.Value > 1)
                    {
                        ok = false;
                    }
                }
            }
            else if (count.Count() == 2)
            {
                foreach (var a in count)
                {
                    if (a.Value > 1)
                    {
                        ok = false;
                    }
                }
            }
            else
            {

                if (Math.Abs(count.ElementAt(0).Value - count.ElementAt(1).Value) > 1 || Math.Abs(count.ElementAt(2).Value - count.ElementAt(1).Value) > 1 || Math.Abs(count.ElementAt(0).Value - count.ElementAt(2).Value) > 1)
                {
                    ok = false;
                }
            }
            if (ok) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
        public static void ABC136_D()
        {
            var S = Console.ReadLine().ToCharArray();
            var count = new int[S.Length];
            int rCount = 0;
            int lCount = 0;
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == 'R')
                {
                    rCount++;
                }
                else if (rCount > 0 && S[i] == 'L')
                {
                    int temp = 0;
                    while (i + temp < S.Length && S[i + temp] != 'R')
                    {
                        lCount++;
                        temp++;
                    }
                    count[i - 1] = (int)Math.Ceiling(rCount / (decimal)2) + lCount / 2;
                    count[i] = rCount / 2 + (int)Math.Ceiling(lCount / (decimal)2);
                    rCount = 0;
                    lCount = 0;
                }
            }
            var sb = new StringBuilder();
            for (int i = 0; i < S.Length; i++)
            {
                if (i != S.Length - 1)
                {
                    sb.Append($"{count[i]} ");
                }
                else
                {
                    sb.Append(count[i]);
                }
            }
            Console.WriteLine(sb);
        }
        public static void AGC043_A()
        {
            var HW = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var s = new char[HW[0]][];
            for (int i = 0; i < HW[0]; i++)
            {
                s[i] = Console.ReadLine().ToCharArray();
            }
            var dp = new int[HW[0], HW[1]];
            for (int i = 0; i < HW[0]; i++)
            {
                for (int j = 0; j < HW[1]; j++)
                {
                    dp[i, j] = intMax;
                }
            }
            if (s[0][0] == '#')
            {
                dp[0, 0] = 1;
            }
            else
            {
                dp[0, 0] = 0;
            }
            for (int i = 0; i < HW[0]; i++)
            {
                for (int j = 0; j < HW[1]; j++)
                {
                    if (i == 0 && j == 0) continue;
                    int up = intMax;
                    int left = intMax;
                    if (i - 1 >= 0 && s[i - 1][j] == '.' && s[i][j] == '#')
                    {
                        up = dp[i - 1, j] + 1;
                    }
                    else if (i - 1 >= 0)
                    {
                        up = dp[i - 1, j];
                    }
                    if (j - 1 >= 0 && s[i][j - 1] == '.' && s[i][j] == '#')
                    {
                        left = dp[i, j - 1] + 1;
                    }
                    else if (j - 1 >= 0)
                    {
                        left = dp[i, j - 1];
                    }
                    dp[i, j] = Math.Min(up, left);
                }
            }
            Console.WriteLine(dp[HW[0] - 1, HW[1] - 1]);
        }
        public static void ABC048_B()
        {
            var abx = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long ans = 0;
            if (abx[0] % abx[2] == 0)
            {
                ans = abx[1] / abx[2] - (abx[0] / abx[2] - 1);
            }
            else
            {
                ans = abx[1] / abx[2] - (abx[0] / abx[2]);
            }

            Console.WriteLine(ans);
        }
        public static void ABC141_D()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long sum = A.Sum();
            var pqueue = new PriorityQueue<long>(NM[0]);
            for (int i = 0; i < A.Length; i++)
            {
                pqueue.Push(A[i]);
            }
            for (int i = 1; i <= NM[1]; i++)
            {
                long temp = pqueue.Pop();
                sum -= (temp - temp / 2);
                pqueue.Push(temp / 2);
            }
            Console.WriteLine(sum);
        }
        public static void ABC076_C()
        {
            var S = Console.ReadLine().ToCharArray();
            var T = Console.ReadLine().ToCharArray();
            bool flag = false;
            if (T.Length == 1 && S.Length == 1 && S[0] == T[0])
            {
                flag = true;
            }
            for (int i = S.Length - 1; i >= 0; i--)
            {

                if (S[i] == '?' || S[i] == T[T.Length - 1])
                {
                    int temp = 0;
                    while (S[i - temp] == T[T.Length - 1 - temp] || S[i - temp] == '?')
                    {
                        if (temp == T.Length - 1)
                        {
                            for (int j = i - temp; j <= i - temp + T.Length - 1; j++)
                            {
                                S[j] = T[j - (i - temp)];
                            }
                            flag = true;
                            break;
                        }
                        temp++;
                        if (flag || i - temp < 0) break;
                    }
                }
                if (flag) break;
            }
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == '?') S[i] = 'a';
            }
            if (flag)
                Console.WriteLine(new String(S));
            else Console.WriteLine("UNRESTORABLE");
        }
        public static void ABC103_B()
        {
            var S = Console.ReadLine().ToCharArray();
            var T = Console.ReadLine().ToCharArray();
            var flag = false;
            if (new String(S) == new string(T)) flag = true;
            for (int i = 1; i <= S.Length; i++)
            {
                String temp = new String(S[(S.Length - i)..(S.Length)]) + new String(S[0..(S.Length - i)]);
                if (temp == new String(T))
                {
                    flag = true;
                }
            }
            if (flag) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
        public static void ABC226_A()
        {
            double X = double.Parse(Console.ReadLine());
            int ans = (int)Math.Round(X, MidpointRounding.AwayFromZero);
            Console.WriteLine(ans);
        }
        public static void ABC226_B()
        {
            var N = long.Parse(Console.ReadLine());
            var dictionary = new Dictionary<String, int>();
            for (int i = 0; i < N; i++)
            {
                var read = Console.ReadLine();
                if (!dictionary.ContainsKey(read))
                {
                    dictionary.Add(read, 1);
                }
            }
            Console.WriteLine(dictionary.Count());
        }
        public static void ABC226_C()
        {
            var N = long.Parse(Console.ReadLine());
            var graph = new List<List<long>>();
            for (int i = 0; i < N; i++)
            {
                graph.Add(new List<long>());
            }
            var T = new long[N];
            for (int i = 0; i < N; i++)
            {
                var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
                T[i] = read[0];
                for (int j = 0; j < read[1]; j++)
                {
                    graph[i].Add(read[2 + j] - 1);
                }
            }
            var master = new bool[N];
            long ans = 0;
            dfs(N - 1);
            Console.WriteLine(ans);
            long dfs(long now)
            {
                master[now] = true;
                foreach (var next in graph[(int)now])
                {
                    if (master[next]) continue;
                    dfs(next);
                }
                ans += T[now];
                return ans;
            }
        }
        public static void typical90_006()
        {
            var NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var S = Console.ReadLine();
            var table = new int[S.Length, 26];
            for (int i = 0; i < S.Length; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    table[i, j] = S.Length;
                }
            }
            for (int i = S.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (S[i] - 'a' == j)
                    {
                        table[i, j] = i;
                    }
                    else
                    {
                        if (i < S.Length - 1)
                            table[i, j] = table[i + 1, j];
                    }
                }
            }
            var sb = new StringBuilder();
            int now = 0;
            for (int i = 0; i < NK[1]; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    int next = table[now, j];
                    int max = S.Length - next - 1 + (i + 1);
                    if (max >= NK[1])
                    {
                        sb.Append((char)('a' + j));
                        now = next + 1;
                        break;
                    }
                }
            }
            Console.WriteLine(sb);
        }
        public static void typical90_007()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            Array.Sort(A);
            var Q = int.Parse(Console.ReadLine());
            for (int i = 0; i < Q; i++)
            {
                long B = long.Parse(Console.ReadLine());
                int l = 0;
                int r = A.Length - 1;
                while (r - l > 1)
                {
                    int mid = (l + r) / 2;
                    if (A[mid] > B)
                    {
                        r = mid;
                    }
                    else
                    {
                        l = mid;
                    }
                }
                Console.WriteLine(Math.Min(Math.Abs(A[l] - B), Math.Abs(A[r] - B)));
            }
        }
        public static void typical90_008()
        {
            int N = int.Parse(Console.ReadLine());
            var S = Console.ReadLine();
            var dp = new long[S.Length + 1, 8];
            long mod = 1000000007;
            dp[0, 0] = 1;
            for (int i = 0; i < S.Length; i++)
            {
                for (int j = 0; j <= 7; j++)
                {
                    if (j != 7 && S[i] == "atcoder"[j])
                    {
                        dp[i + 1, j + 1] += dp[i, j];
                        dp[i + 1, j + 1] %= mod;
                        dp[i + 1, j] += dp[i, j];
                        dp[i + 1, j] %= mod;
                    }
                    else
                    {
                        dp[i + 1, j] += dp[i, j];
                        dp[i + 1, j] %= mod;
                    }
                }
            }
            Console.WriteLine(dp[S.Length, 7]);
        }
        public static void typical90_010()
        {
            int N = int.Parse(Console.ReadLine());
            var one = new long[N + 1];
            var two = new long[N + 1];
            for (int i = 1; i <= N; i++)
            {
                var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
                if (read[0] == 1)
                {
                    one[i] = read[1];
                }
                else
                {
                    two[i] = read[1];
                }
            }
            for (int i = 0; i < N; i++)
            {
                one[i + 1] += one[i];
            }
            for (int i = 0; i < N; i++)
            {
                two[i + 1] += two[i];
            }
            int Q = int.Parse(Console.ReadLine());
            for (int i = 0; i < Q; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                long sumOne = one[read[1]] - one[read[0] - 1];
                long sumTwo = two[read[1]] - two[read[0] - 1];
                Console.WriteLine($"{sumOne} {sumTwo}");
            }

        }
        public static void ABC050_B()
        {
            int N = int.Parse(Console.ReadLine());
            var T = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long sum = T.Sum();
            int M = int.Parse(Console.ReadLine());
            for (int i = 0; i < M; i++)
            {
                var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
                long ans = sum;
                ans += read[1] - T[read[0] - 1];
                Console.WriteLine(ans);
            }
        }
        public static void ABC127_D()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var list = new (int, long)[NM[1]];
            long sumA = A.Sum();
            Array.Sort(A);
            for (int i = 0; i < NM[1]; i++)
            {
                var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
                list[i] = (((int)read[0], read[1]));
            }
            list = list.OrderByDescending(x => x.Item2).ToArray();
            long start = 0;
            for (int i = 0; i < NM[1]; i++)
            {
                for (int j = 0; j < list[i].Item1; j++)
                {
                    if (j + start > NM[0] - 1)
                    {
                        break;
                    }
                    if (list[i].Item2 - A[j + start] > 0)
                    {
                        sumA += list[i].Item2 - A[j + start];
                    }
                }
                start += list[i].Item1;
            }
            Console.WriteLine(sumA);
        }
        public static void ABC226_D()
        {
            int N = int.Parse(Console.ReadLine());
            var point = new (long, long)[N];
            for (int i = 0; i < N; i++)
            {
                var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
                point[i] = (read[0], read[1]);
            }
            var set = new HashSet<(long, long)>();
            for (int i = 0; i < N - 1; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    var dx = point[i].Item1 - point[j].Item1;
                    var dy = point[i].Item2 - point[j].Item2;
                    if (dx == 0)
                    {
                        set.Add((0, 1));
                    }
                    else if (dy == 0)
                    {
                        set.Add((1, 0));
                    }
                    else
                    {
                        var g = gcd(dx, dy);
                        set.Add((dx / g, dy / g));
                    }

                }
            }
            long ans = 0;
            ans = set.Count() * 2;
            Console.WriteLine(ans);

            long gcd(long C, long D)
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
                //最小公倍数を返す
                //var CD = (long)Math.Floor(((decimal)C * D) / tempC);
                return tempC;
            }
        }
        public static void typical90_012_sub()
        {
            var HW = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int Q = int.Parse(Console.ReadLine());
            var field = new int[HW[0], HW[1]];
            for (int i = 0; i < Q; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (read[0] == 1)
                {
                    field[read[1] - 1, read[2] - 1] = 1;
                }
                else
                {
                    var visit = new int[HW[0], HW[1]];
                    dfs(read[1] - 1, read[2] - 1, visit, (read[3] - 1, read[4] - 1));
                    if (visit[read[3] - 1, read[4] - 1] == 1 && field[read[3] - 1, read[4] - 1] == 1)
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No");
                    }
                }
            }
            void dfs(int y, int x, int[,] visit, (int, int) goal)
            {
                if (field[y, x] == 0)
                {
                    return;
                }
                visit[y, x] = 1;
                if (y == goal.Item1 && x == goal.Item2 && field[goal.Item1, goal.Item2] == 1)
                {
                    return;
                }
                var move = new (int, int)[] { (-1, 0), (0, -1), (1, 0), (0, 1) };
                foreach (var d in move)
                {
                    if (y + d.Item1 >= 0 && y + d.Item1 < HW[0] && x + d.Item2 >= 0 && x + d.Item2 < HW[1])
                    {
                        if (visit[y + d.Item1, x + d.Item2] == 0)
                        {
                            dfs(y + d.Item1, x + d.Item2, visit, goal);
                        }
                    }
                }
            }
        }
        public static void typical90_012()
        {
            var HW = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int Q = int.Parse(Console.ReadLine());
            var uf = new UnionFind<(int, int)>();
            var field = new int[HW[0], HW[1]];
            for (int i = 0; i < Q; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (read[0] == 1)
                {
                    if (!uf.Contains((read[1] - 1, read[2] - 1)))
                    {
                        uf.Add((read[1] - 1, read[2] - 1));
                    }
                    field[read[1] - 1, read[2] - 1] = 1;
                    var move = new (int, int)[] { (-1, 0), (0, -1), (1, 0), (0, 1) };
                    foreach (var d in move)
                    {
                        if (read[1] - 1 + d.Item1 >= 0 && read[1] - 1 + d.Item1 < HW[0] && read[2] - 1 + d.Item2 >= 0 && read[2] - 1 + d.Item2 < HW[1])
                        {
                            if (field[read[1] - 1 + d.Item1, read[2] - 1 + d.Item2] == 1)
                            {
                                uf.Unite((read[1] - 1, read[2] - 1), (read[1] - 1 + d.Item1, read[2] - 1 + d.Item2));
                            }
                        }
                    }
                }
                else
                {
                    if (uf.Contains((read[1] - 1, read[2] - 1)) && uf.Contains((read[3] - 1, read[4] - 1)))
                    {
                        if (uf.IsSame((read[1] - 1, read[2] - 1), (read[3] - 1, read[4] - 1)))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No");
                    }
                }
            }
        }
        public static void typical90_013()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var graph = new Dijkstra(NM[0] + 1);
            for (int i = 0; i < NM[1]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                graph.Add(read[0], read[1], read[2]);
                graph.Add(read[1], read[0], read[2]);
            }
            var d = graph.GetMinCost(1);
            var n = graph.GetMinCost(NM[0]);
            for (int i = 1; i <= NM[0]; i++)
            {
                var temp = d[i] + n[i];
                Console.WriteLine(temp);
            }
        }
        public static void typical90_014()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var B = Console.ReadLine().Split().Select(long.Parse).ToArray();
            Array.Sort(A);
            Array.Sort(B);
            long ans = 0;
            for (int i = 0; i < N; i++)
            {
                ans += Math.Abs(A[i] - B[i]);
            }
            Console.WriteLine(ans);
        }
        public static void typical90_016()
        {
            var N = int.Parse(Console.ReadLine());
            var ABC = Console.ReadLine().Split().Select(long.Parse).ToArray();
            Array.Sort(ABC);
            long temp = 0;
            long ans = intMax;
            for (int i = 0; i < 9999; i++)
            {
                for (int j = 0; j < 9999; j++)
                {
                    temp = ABC[2] * i + ABC[1] * j;
                    if (temp > N) continue;
                    if ((N - temp) % ABC[0] == 0)
                    {
                        ans = Math.Min(ans, i + j + (N - temp) / ABC[0]);
                    }
                }
            }
            Console.WriteLine(ans);
        }
        public static void ABC227_A()
        {
            var NKA = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int temp = NKA[1];
            int now = NKA[2] - 1;
            int ans = 0;
            while (temp > 0)
            {
                now++;
                temp--;
                if (now > NKA[0]) now = 1;
                if (temp == 0) ans = now;
            }

            Console.WriteLine(ans);
        }
        public static void ABC227_B()
        {
            int N = int.Parse(Console.ReadLine());
            var S = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var check = new int[N];
            for (int i = 1; i < 1000; i++)
            {
                for (int j = 1; j < 1000; j++)
                {
                    for (int k = 0; k < N; k++)
                    {
                        if (4 * i * j + 3 * i + 3 * j == S[k])
                        {
                            check[k] = 1;
                        }
                    }
                }
            }
            int ans = N - check.Sum();
            Console.WriteLine(ans);
        }
        public static void ABC227_C()
        {
            long N = long.Parse(Console.ReadLine());
            long count = 0;
            for (int i = 1; i <= Math.Sqrt(N); i++)
            {
                for (int j = i; j <= Math.Sqrt(N / i); j++)
                {
                    long k = N / (i * j);
                    count += k;
                    count -= Math.Min((j - 1), k);

                }
            }
            Console.WriteLine(count);
        }
        public static void ABC227_D()
        {
            var NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            Array.Sort(A);
            long l = 0;
            long r = longMax / (long)NK[1];
            while (r - l > 1)
            {
                long mid = (l + r) / 2;
                long sum = 0;
                for (int i = 0; i < NK[0]; i++)
                {
                    sum += Math.Min(A[i], mid);
                }
                if (sum >= mid * (long)NK[1])
                {
                    l = mid;
                }
                else
                {
                    r = mid;
                }
            }
            Console.WriteLine(l);
        }
        public static void typical90_018()
        {
            long T = long.Parse(Console.ReadLine());
            var LXY = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var Q = int.Parse(Console.ReadLine());
            for (int i = 0; i < Q; i++)
            {
                double E = double.Parse(Console.ReadLine());
                double angle = Math.PI * 360 * (E / T) / 180.0;
                (double, double, double) point = (0, -LXY[0] / 2 * Math.Sin(angle), LXY[0] / 2 - (LXY[0] / 2) * Math.Cos(angle));
                double hd = Math.Sqrt(Math.Pow(LXY[1], 2) + Math.Pow(point.Item2 - LXY[2], 2));
                double ans = 180 * Math.Atan2(point.Item3, hd) / Math.PI;
                Console.WriteLine(ans);
            }
        }
        public static void typical90_020()
        {
            var abc = Console.ReadLine().Split().Select(long.Parse).ToArray();
            if (abc[0] < pow(abc[2], (int)abc[1]))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            long pow(long x, int n)
            {
                long ret = 1;
                while (n > 0)
                {
                    if ((n & 1) > 0) ret *= x;
                    x *= x;
                    n = n >> 1;
                }
                return ret;
            }
        }
        /// <summary>
        /// 強連結成分分解
        /// </summary>
        public static void typical90_021()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var G = new List<List<int>>();
            var H = new List<List<int>>();
            var I = new List<int>();
            long count = 0;
            for (int i = 0; i < NM[0]; i++)
            {
                G.Add(new List<int>());
                H.Add(new List<int>());
            }
            var visit = new int[NM[0]];
            for (int i = 0; i < NM[1]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                G[read[0] - 1].Add(read[1] - 1);
                H[read[1] - 1].Add(read[0] - 1);
            }
            for (int i = 0; i < NM[0]; i++)
            {
                if (visit[i] == 0)
                {
                    dfs(i);
                }
            }
            I.Reverse();
            for (int i = 0; i < NM[0]; i++)
            {
                visit[i] = 0;
            }
            long ans = 0;
            foreach (var i in I)
            {
                if (visit[i] == 1) continue;
                count = 0;
                dfs2(i);
                ans += count * (count - 1) / 2;
            }
            Console.WriteLine(ans);
            void dfs(int now)
            {
                visit[now] = 1;
                foreach (var i in G[now])
                {
                    if (visit[i] == 0) dfs(i);
                }
                I.Add(now);
            }
            void dfs2(int now)
            {
                visit[now] = 1;
                count++;
                foreach (var i in H[now])
                {
                    if (visit[i] == 0) dfs2(i);
                }

            }
        }
        public static void kyoto2021_A()
        {
            int N = int.Parse(Console.ReadLine());
            var S = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long T = long.Parse(Console.ReadLine());
            Array.Sort(S);
            long ans = 1;
            long temp = 0;
            long index = 0;
            while (index < N)
            {
                if (index > 0 && S[index] / T > temp)
                {
                    ans++;
                }
                temp = S[index] / T;
                index++;
            }
            Console.WriteLine(ans);
        }
        public static void kyoto2021_B()
        {
            int N = int.Parse(Console.ReadLine());
            var field = new bool[N][];
            for (int i = 0; i < N; i++)
            {
                field[i] = new bool[N];
            }
            for (int i = 0, j = N - 1; i < N - 1; i += 2, j -= 2)
            {
                for (int k = 0; k < j; k++)
                {
                    field[i][k] = true;
                    field[i + k][j - 1] = true;
                }

            }
            foreach (var a in field)
            {
                Console.WriteLine(new string(a.Select(x => x ? '#' : '.').ToArray()));
            }

        }
        public static void typical90_022()
        {
            var ABC = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long temp = gcd(ABC[0], ABC[1]);
            temp = gcd(temp, ABC[2]);
            long ans = ABC[0] / temp - 1 + ABC[1] / temp - 1 + ABC[2] / temp - 1;
            Console.WriteLine(ans);

            long gcd(long C, long D)
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
                //最小公倍数を返す
                //var CD = (long)Math.Floor(((decimal)C * D) / tempC);
                return tempC;
            }
        }
        public static void typical90_024()
        {
            var NK = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var B = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long minus = 0;
            long plus = 0;
            var ok = false;
            for (int i = 0; i < NK[0]; i++)
            {
                if (A[i] > B[i])
                {
                    minus += A[i] - B[i];
                }
                else
                {
                    plus += B[i] - A[i];
                }
            }
            if (NK[1] >= plus + minus && (NK[1] - plus - minus) % 2 == 0)
            {
                ok = true;
            }
            if (ok) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
        public static void typical90_026()
        {
            int N = int.Parse(Console.ReadLine());
            var graph = new List<List<int>>();
            for (int i = 0; i < N; i++)
            {
                graph.Add(new List<int>());
            }
            for (int i = 0; i < N - 1; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                graph[read[0] - 1].Add(read[1] - 1);
                graph[read[1] - 1].Add(read[0] - 1);
            }
            var flag = new int[N];
            var visit = new int[N];
            dfs(0, 1);
            void dfs(int now, int num)
            {
                flag[now] = num;
                visit[now] = 1;
                foreach (var i in graph[now])
                {
                    if (num == 1 && visit[i] == 0)
                    {
                        dfs(i, 0);
                    }
                    else if (num == 0 && visit[i] == 0)
                    {
                        dfs(i, 1);
                    }
                }
            }
            var list1 = new List<int>();
            var list2 = new List<int>();
            for (int i = 0; i < N; i++)
            {
                if (flag[i] == 1)
                {
                    list1.Add(i + 1);
                }
                else
                {
                    list2.Add(i + 1);
                }

            }
            var sb = new StringBuilder();
            if (list1.Count() > list2.Count())
            {
                for (int i = 0; i < N / 2; i++)
                {
                    sb.Append($"{list1[i]} ");
                }
            }
            else
            {
                for (int i = 0; i < N / 2; i++)
                {
                    sb.Append($"{list2[i]} ");
                }
            }
            Console.WriteLine(sb.ToString().TrimEnd());
        }
        public static void typical90_027()
        {
            int N = int.Parse(Console.ReadLine());
            var list = new List<String>();
            var num = new List<int>();
            for (int i = 0; i < N; i++)
            {
                var read = Console.ReadLine();
                if (!list.Contains(read))
                {
                    num.Add(i + 1);
                    list.Add(read);
                }
            }

            foreach (var i in num)
            {
                Console.WriteLine(i);
            }
        }
        public static void typical90_028()
        {
            var N = int.Parse(Console.ReadLine());
            var list = new (int, int, int, int)[N];
            var field = new int[1001, 1001];
            for (int i = 0; i < N; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                field[read[1], read[0]]++;
                field[read[3], read[0]]--;
                field[read[1], read[2]]--;
                field[read[3], read[2]]++;
            }
            for (int i = 0; i < 1001; i++)
            {
                for (int j = 1; j < 1001; j++)
                {
                    field[i, j] += field[i, j - 1];
                }
            }
            for (int i = 1; i < 1001; i++)
            {
                for (int j = 0; j < 1001; j++)
                {
                    field[i, j] += field[i - 1, j];
                }
            }
            var ans = new int[N + 1];
            for (int i = 0; i < 1001; i++)
            {
                for (int j = 0; j < 1001; j++)
                {
                    ans[field[i, j]]++;
                }
            }
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(ans[i]);
            }
        }
        public static void typical90_029()
        {
            var WN = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var seg = new LazySegmentTree(WN[0]);
            for (int i = 0; i < WN[1]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int height = seg.RangeMax(read[0] - 1, read[1]) + 1;
                seg.Update(read[0] - 1, read[1], height);
                Console.WriteLine(height);
            }
        }
        public static void ABC228_C()
        {
            var NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var list = new List<(int, int)>();
            for (int i = 0; i < NK[0]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                list.Add((i, read[0] + read[1] + read[2]));
            }
            list = list.OrderBy(x => x.Item2).ToList();
            int border = list[NK[0] - NK[1]].Item2;
            var indexlist = new int[NK[0]];
            for (int i = 0; i < NK[0]; i++)
            {
                indexlist[list[i].Item1] = i;
            }
            for (int i = 0; i < NK[0]; i++)
            {
                int index = indexlist[i];
                if (index >= NK[0] - NK[1])
                {
                    Console.WriteLine("Yes");
                }
                else if (list[index].Item2 + 300 >= border)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }

        }
        public static void ABC228_D()
        {
            int Q = int.Parse(Console.ReadLine());
            int N = (int)Math.Pow(2, 20) + 1;
            var a = new long[N];
            Array.Fill(a, -1);
            var set = new Set<int>();

            for (int i = 0; i < N; i++)
            {
                set.Add(i);
            }

            for (int i = 0; i < Q; i++)
            {
                var tx = Console.ReadLine().Split().Select(long.Parse).ToArray();

                if (tx[0] == 1)
                {
                    int h = (int)(tx[1] % N);
                    int temp = set.LowerBound(h);
                    if (temp >= set.Count) temp = 0;
                    int index = set[temp];
                    a[index] = tx[1];
                    set.RemoveAt(temp);

                }
                else
                {
                    Console.WriteLine(a[tx[1] % N]);
                }
            }
        }
        public static void typical90_030()
        {
            var NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long ans = 0;
            var cnt = new int[1 << 24];
            for (int i = 2; i <= NK[0]; i++)
            {
                if (cnt[i] >= 1) continue;
                for (int j = i; j <= NK[0]; j += i)
                {
                    cnt[j]++;
                }
            }
            for (int i = 0; i <= NK[0]; i++)
            {
                if (cnt[i] >= NK[1]) ans++;
            }
            Console.WriteLine(ans);
        }
        public static void typical90_031()
        {
            int N = int.Parse(Console.ReadLine());
            var W = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var B = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var grundy = new int[55, 1555];
            init();
            int xor = 0;
            for (int i = 0; i < N; i++)
            {
                if (i == N)
                {
                    i += 0;
                }
                xor ^= grundy[W[i], B[i]];
            }
            if (xor != 0) Console.WriteLine("First");
            else Console.WriteLine("Second");
            void init()
            {
                for (int i = 0; i <= 50; i++)
                {
                    for (int j = 0; j <= 1500; j++)
                    {
                        var mex = new int[1555];
                        if (i >= 1)
                        {
                            mex[grundy[i - 1, j + i]] = 1;
                        }
                        if (j >= 2)
                        {
                            for (int k = 1; k <= (j / 2); k++)
                            {
                                mex[grundy[i, j - k]] = 1;
                            }
                        }
                        for (int k = 0; k < 1555; k++)
                        {
                            if (mex[k] == 0)
                            {
                                grundy[i, j] = k;
                                break;
                            }
                        }
                    }
                }
            }
        }
        public static void typical90_019()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var dp = Enumerable.Range(0, 2 * N).Select(y => (new long[2 * N]).Select(x => longMax).ToArray()).ToArray();
            for (int i = 0; i < 2 * N - 1; i++)
            {
                dp[i][i + 1] = Math.Abs(A[i] - A[i + 1]);
            }
            for (int i = 3; i < 2 * N; i += 2)
            {
                for (int j = 0; j < 2 * N - i; j++)
                {
                    int l = j, r = j + i;
                    for (int k = l; k <= r - 1; k++)
                    {
                        dp[l][r] = Math.Min(dp[l][r], dp[l][k] + dp[k + 1][r]);
                    }
                    dp[l][r] = Math.Min(dp[l][r], dp[l + 1][r - 1] + Math.Abs(A[l] - A[r]));
                }
            }
            Console.WriteLine(dp[0][2 * N - 1]);
        }
        public static void ABC094_C()
        {
            int N = int.Parse(Console.ReadLine());
            var X = Console.ReadLine().Split().Select(int.Parse).ToList();

            int m = N / 2;
            var sortedX = X.OrderBy(x => x).ToList();
            for (int i = 0; i < N; i++)
            {
                if (X[i] < sortedX[m])
                {
                    Console.WriteLine(sortedX[m]);
                }
                else
                {
                    Console.WriteLine(sortedX[m - 1]);
                }
            }
        }
        public static void typical90_032()
        {
            int N = int.Parse(Console.ReadLine());
            var A = new int[N][];
            for (int i = 0; i < N; i++)
            {
                A[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
            int M = int.Parse(Console.ReadLine());
            var check = new int[N, N];
            for (int i = 0; i < M; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                check[read[0] - 1, read[1] - 1] = 1;
                check[read[1] - 1, read[0] - 1] = 1;
            }
            int ans = intMax;
            var p = Enumerable.Range(0, N).ToArray();
            do
            {
                var ok = true;
                int temp = 0;
                for (int i = 0; i < N - 1; i++)
                {
                    if (check[p[i], p[i + 1]] == 1)
                    {
                        ok = false;
                    }
                    temp += A[p[i]][i];
                }
                temp += A[p[N - 1]][N - 1];
                if (ok) ans = Math.Min(ans, temp);
            } while (NextPermutation.Next_Permutation(p));
            if (ans == intMax) Console.WriteLine(-1);
            else Console.WriteLine(ans);
        }
        public static void typical90_033()
        {
            var HW = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int ans = 0;
            if (HW[0] == 1 || HW[1] == 1) ans = HW[0] * HW[1];
            else ans = (int)Math.Ceiling((decimal)HW[0] / 2) * (int)Math.Ceiling((decimal)HW[1] / 2);
            Console.WriteLine(ans);
        }
        public static void typical90_055()
        {
            var NPQ = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long ans = 0;
            for (int i = 0; i < NPQ[0]; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    for (int k = 0; k < j; k++)
                    {
                        for (int l = 0; l < k; l++)
                        {
                            for (int m = 0; m < l; m++)
                            {
                                if (A[i] * A[j] % NPQ[1] * A[k] % NPQ[1] * A[l] % NPQ[1] * A[m] % NPQ[1] == NPQ[2]) ans++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(ans);

        }
        public static void typical90_034()
        {
            var NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var a = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var list = new Dictionary<long, int>();
            int index = 0, cnt = 0;
            int ans = 0;
            for (int i = 0; i < NK[0]; i++)
            {
                while (index < NK[0])
                {
                    if (!list.ContainsKey(a[index]) && cnt == NK[1]) break;
                    if (!list.ContainsKey(a[index]))
                    {
                        cnt++;
                        list.Add(a[index], 1);
                    }
                    else
                    {
                        list[a[index]]++;
                    }
                    index++;
                }
                ans = Math.Max(ans, index - i);
                if (index == NK[0]) break;
                if (list[a[i]] == 1)
                {
                    cnt--;
                    list.Remove(a[i]);
                }
                else
                {
                    list[a[i]]--;
                }
            }
            Console.WriteLine(ans);

        }
        public static void typical90_038()
        {
            var AB = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long ans = gcd(AB[0], AB[1]);
            if (ans != -1)
                Console.WriteLine(ans);
            else
            {
                Console.WriteLine("Large");
            }
            long gcd(long C, long D)
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
                long CD = 0;
                if (D / tempC <= (long)1000000000000000000 / C)
                {
                    CD = C / tempC;
                    CD *= D;
                }
                else
                {
                    CD = -1;
                }

                return CD;
            }
        }
        public static void typical90_036()
        {
            var NQ = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var point = new (long, long)[NQ[0]];
            for (int i = 0; i < NQ[0]; i++)
            {
                var read = Console.ReadLine().Split().Select(long.Parse).ToArray();

                point[i] = (read[0], read[1]);
            }
            long minX = longMax;
            long minY = longMax;
            long maxX = 0;
            long maxY = 0;
            for (int i = 0; i < NQ[0]; i++)
            {
                var tempX = point[i].Item1 + point[i].Item2;
                var tempY = point[i].Item2 - point[i].Item1;
                point[i].Item1 = tempX;
                point[i].Item2 = tempY;
                minX = Math.Min(minX, point[i].Item1);
                minY = Math.Min(minY, point[i].Item2);
                maxX = Math.Max(maxX, point[i].Item1);
                maxY = Math.Max(maxY, point[i].Item2);

            }
            for (int i = 0; i < NQ[1]; i++)
            {
                int q = int.Parse(Console.ReadLine());
                long temp1 = Math.Abs(point[q - 1].Item1 - minX);
                long temp2 = Math.Abs(point[q - 1].Item1 - maxX);
                long temp3 = Math.Abs(point[q - 1].Item2 - maxY);
                long temp4 = Math.Abs(point[q - 1].Item2 - minY);
                long ans = Math.Max(temp1, Math.Max(temp2, Math.Max(temp3, temp4)));
                Console.WriteLine(ans);
            }
        }
        /// <summary>
        /// セグメント木dp
        /// </summary>
        public static void typical90_037()
        {
            var WN = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var spice = new (long, long, long)[WN[1]];
            var dp = new long[505, 10005];
            var seg = new SegmentTree<long>[505];
            for (int i = 0; i < WN[1]; i++)
            {
                var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
                spice[i] = (read[0], read[1], read[2]);
            }
            for (int i = 0; i <= WN[1]; i++)
            {
                for (int j = 0; j < dp.GetLength(1); j++)
                {
                    dp[i, j] = -1;
                }
                seg[i] = new SegmentTree<long>(Enumerable.Repeat((long)-1, WN[0]), (x, y) => Math.Max(x, y), -1);
            }
            dp[0, 0] = 0;
            seg[0].Update(0, 0);
            for (int i = 1; i <= WN[1]; i++)
            {
                for (int j = 0; j <= WN[0]; j++)
                {
                    dp[i, j] = dp[i - 1, j];
                }
                for (int j = 0; j <= WN[0]; j++)
                {
                    int l = Math.Max(0, j - (int)spice[i - 1].Item2), r = Math.Max(0, j - (int)spice[i - 1].Item1 + 1);
                    if (l == r) continue;
                    long val = seg[i - 1].Execute(l, r);
                    if (val != -1)
                    {
                        dp[i, j] = Math.Max(dp[i, j], val + spice[i - 1].Item3);
                    }
                }
                for (int j = 0; j <= WN[0]; j++)
                {
                    seg[i].Update(j, dp[i, j]);
                }
            }
            Console.WriteLine(dp[WN[1], WN[0]]);

        }
        public static void test()
        {
            var nq = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var n = nq[0];
            var q = nq[1];
            var tree = new SegmentTree<int>(Enumerable.Repeat(int.MaxValue, n), (x, y) => Math.Min(x, y), int.MaxValue);
            var results = new List<int>();
            for (int i = 0; i < q; i++)
            {
                var inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                if (inputs[0] == 0)
                {
                    tree.Update(inputs[1], inputs[2]);
                }
                else if (inputs[0] == 1)
                {
                    var result = tree.Execute(inputs[1], inputs[2] + 1);
                    results.Add(result);
                }
            }

            foreach (var item in results) Console.WriteLine(item);

        }
        /// <summary>
        /// 木dp
        /// </summary>
        public static void typical90_039()
        {
            int N = int.Parse(Console.ReadLine());
            var graph = new List<List<int>>();
            var dp = new long[N];
            var path = new (int, int)[N];
            for (int i = 0; i < N; i++)
            {
                graph.Add(new List<int>());
            }
            for (int i = 0; i < N - 1; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                path[i] = (read[0] - 1, read[1] - 1);
                graph[read[0] - 1].Add(read[1] - 1);
                graph[read[1] - 1].Add(read[0] - 1);
            }
            dfs(0, -1);
            long ans = 0;
            for (int i = 0; i < N; i++)
            {
                long r = Math.Min(dp[path[i].Item1], dp[path[i].Item2]);
                ans += r * (N - r);
            }
            Console.WriteLine(ans);
            void dfs(int now, int pre)
            {
                dp[now] = 1;
                foreach (var i in graph[now])
                {
                    if (i != pre)
                    {
                        dfs(i, now);
                        dp[now] += dp[i];
                    }
                }
            }
        }
        public static void ABC148_E()
        {
            long N = long.Parse(Console.ReadLine());
            long ans = 0;
            long temp = 10;
            if (N % 2 == 0)
            {
                while (temp <= N)
                {
                    ans += N / temp;
                    temp *= 5;
                }
            }
            Console.WriteLine(ans);
        }
        public static void ABC054_B()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var A = new char[NM[0]][];
            var B = new char[NM[1]][];
            for (int i = 0; i < NM[0] + NM[1]; i++)
            {
                if (i < NM[0])
                {
                    A[i] = Console.ReadLine().ToCharArray();
                }
                else
                {
                    B[i - NM[0]] = Console.ReadLine().ToCharArray();
                }
            }
            for (int i = 0; i <= NM[0] - NM[1]; i++)
            {
                for (int j = 0; j <= NM[0] - NM[1]; j++)
                {
                    bool ok = true;
                    for (int k = 0; k < NM[1]; k++)
                    {
                        for (int l = 0; l < NM[1]; l++)
                        {
                            if (A[i + k][j + l] != B[k][l])
                            {
                                ok = false;
                            }
                        }
                    }
                    if (ok)
                    {
                        Console.WriteLine("Yes");
                        return;
                    }
                }
            }
            Console.WriteLine("No");

        }
        /// <summary>
        /// 素因数分解　素因数列挙
        /// </summary>
        public static void ABC142_D()
        {
            var AB = Console.ReadLine().Split().Select(long.Parse).ToArray();
            int ans = 0;
            var list = enumpr(gcd(AB[0], AB[1]));
            ans = list.Count() + 1;
            Console.WriteLine(ans);
            long gcd(long C, long D)
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
            List<long> enumpr(long n)
            {
                var list = new List<long>();
                for (long i = 2; i < Math.Sqrt(n); i++)
                {
                    while (n % i == 0)
                    {
                        if (!list.Contains(i))
                            list.Add(i);
                        n /= i;
                    }
                }
                if (n > 1) list.Add(n);
                return list;
            }
        }
        public static void programking2_B()
        {
            int N = int.Parse(Console.ReadLine());
            var D = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long mod = 998244353;

            var p = new int[N + 1];
            D.ToList().ForEach(x => p[x]++);
            BigInteger ans = 1;
            if (D[0] != 0 || p[0] != 1)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = 1; i <= N; i++)
            {
                ans *= BigInteger.ModPow(p[i - 1], p[i], mod);
                ans %= mod;
            }
            Console.WriteLine(ans);
        }
        public static void ABC229_A()
        {
            var a = new char[2][];
            a[0] = Console.ReadLine().ToCharArray();
            a[1] = Console.ReadLine().ToCharArray();
            if (a[0][0] == '.' && a[1][1] == '.' || a[0][1] == '.' && a[1][0] == '.')
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
        }
        public static void ABC229_B()
        {
            var AB = Console.ReadLine().Split();
            var A = AB[0].ToArray();
            var B = AB[1].ToCharArray();
            var ok = true;
            for (int i = 0; i < Math.Min(A.Length, B.Length); i++)
            {
                if ((A[A.Length - 1 - i] - '0') + (B[B.Length - 1 - i] - '0') > 9)
                {
                    ok = false;
                }

            }
            if (ok) Console.WriteLine("Easy");
            else Console.WriteLine("Hard");

        }
        public static void ABC229_C()
        {
            var NW = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var cheese = new (long, long)[NW[0]];
            for (int i = 0; i < NW[0]; i++)
            {
                var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
                cheese[i] = (read[0], read[1]);
            }
            cheese = cheese.ToList().OrderByDescending(x => x.Item1).ToArray();
            long temp = 0;
            long ans = 0;
            for (int i = 0; i < NW[0]; i++)
            {
                if (cheese[i].Item2 <= NW[1] - temp)
                {
                    ans += cheese[i].Item1 * cheese[i].Item2;
                    temp += cheese[i].Item2;
                }
                else
                {
                    ans += cheese[i].Item1 * (NW[1] - temp);
                    temp += NW[1] - temp;
                }
                if (temp == NW[1]) break;
            }
            Console.WriteLine(ans);
        }
        public static void ABC229_D_sub()
        {
            var S = Console.ReadLine();
            int K = int.Parse(Console.ReadLine());
            int[,] dp = new int[200005, 200005];
            if (S[0] == 'X')
            {
                dp[0, 0] = 1;
            }
            for (int i = 1; i < S.Length; i++)
            {
                for (int j = 0; j <= K; j++)
                {
                    if (S[i] == 'X')
                    {
                        dp[i, j] = dp[i - 1, j] + 1;
                    }
                    else
                    {
                        if (j >= 1)
                            dp[i, j] = dp[i - 1, j - 1] + 1;
                    }
                }
            }
            long ans = 0;
            for (int i = 0; i <= K; i++)
            {
                ans = Math.Max(ans, dp[S.Length, i]);
            }
            Console.WriteLine(ans);


        }
        public static void ABC229_D()
        {
            var S = Console.ReadLine();
            int K = int.Parse(Console.ReadLine());
            int temp = 0;
            int index = 0;
            int ans = 0;
            int count = 0;
            for (int i = 0; i < S.Length; i++)
            {
                while (index < S.Length && temp <= K)
                {
                    if (S[index] == '.' && temp == K)
                    {
                        break;
                    }
                    if (S[index] == '.')
                    {
                        temp++;
                    }
                    count++;
                    index++;
                }
                ans = Math.Max(ans, count);
                if (S[i] == '.')
                {
                    temp--;
                }
                count--;
            }
            Console.WriteLine(ans);
        }
        public static void ABC229_E()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var graph = new List<List<int>>();
            for (int i = 0; i < NM[0]; i++)
            {
                graph.Add(new List<int>());
            }
            for (int i = 0; i < NM[1]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                graph[read[0] - 1].Add(read[1] - 1);
            }
            var uf = new UnionFind<int>(Enumerable.Range(0, NM[0]));
            long ans = 0;
            var ansList = new List<long>();
            for (int i = NM[0] - 1; i >= 1; i--)
            {
                ans++;
                foreach (var v in graph[i])
                {
                    if (!uf.IsSame(i, v))
                    {
                        uf.Unite(i, v);
                        ans--;
                    }
                }
                ansList.Add(ans);
            }
            ansList.Reverse();
            var sb = new StringBuilder();
            foreach (var i in ansList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(0);

        }
        public static void ABC229_H()
        {
            int N = int.Parse(Console.ReadLine());
            var S = new char[N][];
            var B = 0;
            var W = 0;
            var upB = 0;
            var upW = 0;
            for (int i = 0; i < N; i++)
            {
                S[i] = Console.ReadLine().ToCharArray();
                for (int j = 0; j < N; j++)
                {
                    if (S[i][j] == 'B')
                    {
                        B++;
                    }
                    else if (S[i][j] == 'W')
                    {
                        W++;
                    }
                }
            }
            for (int i = 1; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (S[i - 1][j] == '.' && S[i][j] == 'B')
                    {
                        upB++;
                    }
                    else if (S[i - 1][j] == '.' && S[i][j] == 'W')
                    {
                        upW++;
                    }
                }
            }
            var takahashi = Math.Min(upW, B);
            var snuke = Math.Min(upB, W);
            bool saki = true;
            while (true)
            {
                if (saki && takahashi == 0)
                {
                    Console.WriteLine("Snuke");
                }
                else if (!saki && snuke == 0)
                {
                    Console.WriteLine("Takahashi");
                }

            }
        }
        public static void ABC125_D()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long sum = 0;
            long minus = 0;
            long min = longMax;
            for (int i = 0; i < N; i++)
            {
                sum += Math.Abs(A[i]);
                if (A[i] < 0)
                {
                    minus++;
                }
                min = Math.Min(min, Math.Abs(A[i]));

            }
            if (minus % 2 == 0)
            {
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine(sum - 2 * min);
            }
        }
        public static void ABC160_D()
        {
            var NXY = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var distance = new int[NXY[0], NXY[0]];
            for (int i = 0; i < NXY[0]; i++)
            {
                for (int j = i + 1; j < NXY[0]; j++)
                {
                    distance[i, j] = Math.Abs(i - j);
                }
            }
            int cut = NXY[2] - NXY[1] - 1;
            for (int i = 0; i < NXY[1]; i++)
            {
                for (int j = NXY[2] - 1; j < NXY[0]; j++)
                {
                    distance[i, j] -= cut;
                }
                for (int j = NXY[2] - 1; j >= NXY[1]; j--)
                {
                    distance[i, j] = Math.Min(distance[i, j], NXY[1] - 1 - i + 1 + NXY[2] - 1 - j);
                }
            }
            for (int i = NXY[1]; i < NXY[2] - 1; i++)
            {
                for (int j = NXY[2] - 1; j < NXY[0]; j++)
                {
                    if (i - NXY[1] < NXY[2] - i)
                    {
                        distance[i, j] = Math.Min(distance[i, j], i - (NXY[1] - 1) + 1 + j - NXY[2] + 1);
                    }
                }
                for (int j = NXY[2] - 1; j >= i; j--)
                {
                    distance[i, j] = Math.Min(distance[i, j], i - (NXY[1] - 1) + 1 + (NXY[2] - 1 - j));
                }
            }
            var ans = new int[NXY[0]];
            for (int i = 0; i < NXY[0]; i++)
            {
                for (int j = i + 1; j < NXY[0]; j++)
                {
                    ans[distance[i, j]]++;
                }
            }
            for (int i = 1; i < NXY[0]; i++)
            {
                Console.WriteLine(ans[i]);
            }
        }
        public static void diverta2019_C()
        {
            int N = int.Parse(Console.ReadLine());
            var list = new List<String>();
            int ans = 0;
            int acount = 0;
            int bcount = 0;
            int abcount = 0;
            for (int i = 0; i < N; i++)
            {
                list.Add(Console.ReadLine());
                for (int j = 0; j < list[i].Length - 1; j++)
                {
                    if (list[i][j] == 'A' && list[i][j + 1] == 'B')
                    {
                        ans++;
                    }

                }
                if (list[i][0] == 'B' && list[i][list[i].Length - 1] == 'A')
                {
                    abcount++;
                }
                else if (list[i][0] == 'B')
                {
                    bcount++;
                }
                else if (list[i][list[i].Length - 1] == 'A')
                {
                    acount++;
                }
            }
            if (acount > 0 || bcount > 0)
            {
                ans += abcount + Math.Min(acount, bcount);
            }
            else
            {
                ans += Math.Max(abcount - 1, 0);
            }


            Console.WriteLine(ans);
        }
        public static void ABC051_C()
        {
            var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sx = read[0];
            int sy = read[1];
            int tx = read[2];
            int ty = read[3];
            String ans = "";

            if (sy <= ty)
            {
                ans = make("U", ty - sy);
                if (sx <= tx)
                {
                    ans += make("R", tx - sx);
                }
                else
                {
                    ans += make("L", tx - sx);
                }
                ans += make("D", ty - sy);
                if (sx <= tx)
                {
                    ans += make("L", tx - sx);
                }
                else
                {
                    ans += make("R", tx - sx);
                }

                //2回目
                if (sx <= tx)
                {
                    ans += "L";
                }
                else
                {
                    ans += "R";
                }
                ans += make("U", ty - sy + 1);
                if (sx <= tx)
                {
                    ans += make("R", tx - sx + 1);
                }
                else
                {
                    ans += make("L", tx - sx + 1);
                }
                ans += "D";
                if (sx <= tx)
                {
                    ans += "R";
                }
                else
                {
                    ans += "L";
                }
                ans += make("D", ty - sy + 1);
                if (sx <= tx)
                {
                    ans += make("L", tx - sx + 1);
                }
                else
                {
                    ans += make("R", tx - sx + 1);
                }
                ans += "U";
            }
            else
            {
                ans = make("D", ty - sy);
                if (sx <= tx)
                {
                    ans += make("R", tx - sx);
                }
                else
                {
                    ans += make("L", tx - sx);
                }
                ans += make("U", ty - sy);
                if (sx <= tx)
                {
                    ans += make("L", tx - sx);
                }
                else
                {
                    ans += make("R", tx - sx);
                }

                //2回目
                if (sx <= tx)
                {
                    ans += "L";
                }
                else
                {
                    ans += "R";
                }
                ans += make("D", ty - sy + 1);
                if (sx <= tx)
                {
                    ans += make("R", tx - sx + 1);
                }
                else
                {
                    ans += make("L", tx - sx + 1);
                }
                ans += "U";
                if (sx <= tx)
                {
                    ans += "R";
                }
                else
                {
                    ans += "L";
                }
                ans += make("U", ty - sy + 1);
                if (sx <= tx)
                {
                    ans += make("L", tx - sx + 1);
                }
                else
                {
                    ans += make("R", tx - sx + 1);
                }
                ans += "D";
            }
            Console.WriteLine(ans);
            String make(String s, int n)
            {
                var sb = new StringBuilder();
                for (int i = 0; i < n; i++)
                {
                    sb.Append(s);
                }
                return sb.ToString();
            }
        }
        public static void ABC080_D()
        {
            var HW = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var fields = new int[HW[0], HW[1]];
            int x = 0;
            int y = 0;
            bool start = true;
            for (int i = 0; i < N; i++)
            {
                while (a[i] > 0)
                {
                    if (start)
                    {
                        fields[y, x] = i + 1;
                        x++;
                        if (x == HW[1])
                        {
                            y++;
                            x = HW[1] - 1;
                            start = false;
                        }
                    }
                    else
                    {
                        fields[y, x] = i + 1;
                        x--;
                        if (x == -1)
                        {
                            y++;
                            x = 0;
                            start = true;
                        }
                    }
                    a[i]--;
                }
            }
            for (int i = 0; i < HW[0]; i++)
            {
                for (int j = 0; j < HW[1]; j++)
                {
                    if (j == HW[1] - 1)
                        Console.WriteLine(fields[i, j]);
                    else Console.Write($"{fields[i, j]} ");
                }
            }
        }
        public static void AGC055_A()
        {
            int N = int.Parse(Console.ReadLine());
            String S = Console.ReadLine();
            var ans = Enumerable.Repeat(0, 3 * N).ToArray();
            var A = new char[3] { 'A', 'B', 'C' };
            int index = 1;
            var selected = new bool[3 * N];
            var one = new List<int>();
            var two = new List<int>();
            var three = new List<int>();
            do
            {
                for (int i = 0; i < N; i++)
                {
                    if (S[i] == A[0] && !selected[i])
                    {
                        one.Add(i);
                    }
                }
                for (int i = N; i < 2 * N; i++)
                {
                    if (S[i] == A[1] && !selected[i])
                    {
                        two.Add(i);
                    }
                }
                for (int i = 2 * N; i < 3 * N; i++)
                {
                    if (S[i] == A[2] && !selected[i])
                    {
                        three.Add(i);
                    }
                }
                for (int i = 0; i < Math.Min(one.Count(), Math.Min(two.Count(), three.Count())); i++)
                {
                    ans[one[i]] = index;
                    ans[two[i]] = index;
                    ans[three[i]] = index;
                    selected[one[i]] = true;
                    selected[two[i]] = true;
                    selected[three[i]] = true;
                }
                one.Clear();
                two.Clear();
                three.Clear();
                index++;
            } while (NextPermutation.Next_Permutation(A));
            for (int i = 0; i < 3 * N; i++)
            {
                if (i != 3 * N)
                {
                    Console.Write(ans[i]);
                }
                else
                {
                    Console.WriteLine(ans[i]);
                }
            }

        }
        public static void typical90_044()
        {
            var NQ = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            int shift = 0;
            var index = Enumerable.Range(0, NQ[0]).ToArray();
            for (int i = 0; i < NQ[1]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (read[0] == 1)
                {
                    var read1 = read[1] - 1 - shift;
                    while (read1 < 0)
                    {
                        read1 += NQ[0];
                    }
                    var read2 = read[2] - 1 - shift;
                    while (read2 < 0)
                    {
                        read2 += NQ[0];
                    }
                    var temp = index[read1];
                    index[read1] = index[read2];
                    index[read2] = temp;
                }
                else if (read[0] == 2)
                {
                    shift++;
                }
                else
                {
                    var temp = read[1] - 1 - shift;
                    while (temp < 0)
                    {
                        temp += NQ[0];
                    }
                    Console.WriteLine(A[index[temp]]);
                }

            }
        }
        public static void typical90_042()
        {
            int K = int.Parse(Console.ReadLine());
            long mod = 1000000007;
            var dp = new long[K + 1];
            dp[0] = 1;
            if (K % 9 != 0)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = 1; i <= K; i++)
            {
                int limit = Math.Min(i, 9);
                for (int j = 1; j <= limit; j++)
                {
                    dp[i] += dp[i - j];
                    dp[i] %= mod;
                }
            }
            Console.WriteLine(dp[K]);
        }
        /// <summary>
        /// 経路探索、bfs
        /// </summary>
        public static void typical90_043()
        {
            var HW = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var start = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var goal = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var field = new char[HW[0]][];
            for (int i = 0; i < HW[0]; i++)
            {
                field[i] = Console.ReadLine().ToCharArray();
            }
            var dp = new int[HW[0], HW[1], 4];
            for (int i = 0; i < HW[0]; i++)
            {
                for (int j = 0; j < HW[1]; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        dp[i, j, k] = intMax;
                    }
                }
            }
            var move = new (int, int)[4] { (-1, 0), (1, 0), (0, 1), (0, -1) };

            var q = new Queue<(int, int, int)>();
            for (int i = 0; i < 4; i++)
            {
                q.Enqueue((start[0] - 1, start[1] - 1, i));
                dp[start[0] - 1, start[1] - 1, i] = 0;

            }

            while (q.Count() != 0)
            {
                (int, int, int) now = q.Dequeue();
                int index = 0;
                foreach (var i in move)
                {
                    int ny = now.Item1 + i.Item1, nx = now.Item2 + i.Item2, cost = dp[now.Item1, now.Item2, now.Item3];
                    if (ny >= 0 && ny < HW[0] && nx >= 0 && nx < HW[1] && field[ny][nx] != '#')
                    {
                        if (index != now.Item3)
                        {
                            if (dp[ny, nx, index] > cost + 1)
                            {
                                dp[ny, nx, index] = cost + 1;
                                q.Enqueue((ny, nx, index));
                            }
                        }
                        else
                        {
                            if (dp[ny, nx, index] > cost)
                            {
                                dp[ny, nx, index] = cost;
                                q.Enqueue((ny, nx, index));
                            }
                        }
                    }
                    index++;
                }


            }
            int ans = intMax;
            for (int i = 0; i < 4; i++)
            {
                ans = Math.Min(ans, dp[goal[0] - 1, goal[1] - 1, i]);
            }
            Console.WriteLine(ans);

        }
        public static void typical90_045()
        {
            var NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var point = new (long, long)[NK[0]];
            for (int i = 0; i < NK[0]; i++)
            {
                var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
                point[i] = (read[0], read[1]);
            }
            var d = new long[NK[0], NK[0]];
            for (int i = 0; i < NK[0]; i++)
            {
                for (int j = 0; j < NK[0]; j++)
                {
                    d[i, j] = (point[i].Item1 - point[j].Item1) * (point[i].Item1 - point[j].Item1) + (point[i].Item2 - point[j].Item2) * (point[i].Item2 - point[j].Item2);
                }
            }
            var cost = new long[1 << NK[0]];

            for (int i = 0; i < 1 << NK[0]; i++)
            {
                for (int j = 0; j < NK[0]; j++)
                {
                    for (int k = 0; k < NK[0]; k++)
                    {
                        if (((i >> j) & 1) == 1 && ((i >> k) & 1) == 1)
                        {
                            cost[i] = Math.Max(cost[i], d[j, k]);
                        }
                    }
                }
            }

            var dp = new long[NK[1] + 1, 1 << NK[0]];
            for (int i = 0; i < dp.GetLength(0); i++)
            {
                for (int j = 0; j < dp.GetLength(1); j++)
                {
                    dp[i, j] = longMax;
                }
            }
            dp[0, 0] = 0;
            for (int i = 1; i <= NK[1]; i++)
            {
                for (int j = 1; j < 1 << NK[0]; j++)
                {
                    for (int k = j; k != 0; k = (k - 1) & j)
                    {
                        dp[i, j] = Math.Min(dp[i, j], Math.Max(dp[i - 1, j - k], cost[k]));
                    }
                }
            }

            Console.WriteLine(dp[NK[1], (1 << NK[0]) - 1]);
        }
        public static void ABC230_A()
        {
            int N = int.Parse(Console.ReadLine());
            String ans = "AGC0";
            if (N >= 42)
            {
                ans += Convert.ToString(N + 1);
            }
            else if (N < 10)
            {
                ans += "0";
                ans += Convert.ToString(N);
            }
            else
            {
                ans += Convert.ToString(N);
            }
            Console.WriteLine(ans);
        }
        public static void ABC230_B()
        {
            var S = Console.ReadLine();
            var sb = new StringBuilder();
            for (int i = 0; i < 100000; i++)
            {
                sb.Append("oxx");
            }
            string T = sb.ToString();
            if (T.Contains(S))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        public static void ABC230_C_sub()
        {
            var NAB = Console.ReadLine().Split().Select(long.Parse).ToArray();
            /*NAB[0]--;
            NAB[1]--;
            NAB[2]--;*/
            long wstart = Math.Max(1 - NAB[1], 1 - NAB[2]);
            long wend = Math.Min(NAB[0] - NAB[1], NAB[0] - NAB[2]);
            long bstart = Math.Max(1 - NAB[1], NAB[2] - NAB[0]);
            long bend = Math.Min(NAB[0] - NAB[1], NAB[2] - 1);
            var PQRS = Console.ReadLine().Split().Select(long.Parse).ToArray();
            /*PQRS[0]--;
            PQRS[1]--;
            PQRS[2]--;
            PQRS[3]--;*/
            var field = new int[PQRS[1] - PQRS[0] + 1, PQRS[3] - PQRS[2] + 1];
            (long, long) start1 = (0, NAB[1] + wstart + PQRS[0] - 1 - PQRS[2]);
            //(long, long) end1 = (NAB[1] + wend - PQRS[0], NAB[2] + wend - PQRS[0]);
            (long, long) start2 = (0, (NAB[2] - 1) - bstart + (NAB[2] - 1 + bstart - (PQRS[0] - 1)) - (PQRS[2] - 1));
            //(long, long) end2 = (NAB[1] + bend - PQRS[0], NAB[2] - bend - PQRS[0]);

            /*for(int i = 0; i < field.GetLength(0); i++)
            {
                for(int j = 0; j < field.GetLength(1); j++)
                {
                    if(i == start1.Item1 && j == start1.Item2)
                    {
                        field[i, j] = 1;
                    }
                    else if (i >= 1 && j >= 1 && field[i - 1, j - 1] == 1 && i <= end1.Item1 && j <= end1.Item2)
                    {
                        field[i, j] = 1;
                    }
                    if(i == start2.Item1 && j == start2.Item2)
                    {
                        field[i, j] = 1;
                    }
                    else if(i >= 1 && j >= 1 && j <= field.GetLength(1) - 2 && field[i - 1, j + 1] == 1 && i <= end2.Item1 && j >= end2.Item2)
                    {
                        field[i, j] = 1;
                    }
                }
            }*/
            while (start1.Item1 < field.GetLength(0) && start1.Item2 < field.GetLength(1))
            {
                field[start1.Item1, start1.Item2] = 1;
                start1.Item1++;
                start1.Item2++;
            }
            while (start2.Item1 < field.GetLength(0) && start2.Item2 >= 0)
            {
                field[start2.Item1, start2.Item2] = 1;
                start2.Item1++;
                start2.Item2--;
            }

            for (int i = 0; i < field.GetLength(0); i++)
            {
                var sb = new StringBuilder();
                for (int j = 0; j < field.GetLength(1); j++)
                {

                    if (j < field.GetLength(1) - 1)
                    {
                        if (field[i, j] == 1)
                        {
                            sb.Append("#");
                        }
                        else
                        {
                            sb.Append(".");
                        }
                    }
                    else
                    {
                        if (field[i, j] == 1)
                        {
                            sb.Append("#");
                            Console.WriteLine(sb.ToString());
                        }
                        else
                        {
                            sb.Append(".");
                            Console.WriteLine(sb.ToString());
                        }
                    }
                }
            }

        }
        public static void ABC230_C()
        {
            var NAB = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long N = NAB[0];
            long A = NAB[1];
            long B = NAB[2];
            var PQRS = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long P = PQRS[0];
            long Q = PQRS[1];
            long R = PQRS[2];
            long S = PQRS[3];
            var field = new int[Q - P + 1, S - R + 1];
            for (long i = P; i <= Q; i++)
            {
                for (long j = R; j <= S; j++)
                {
                    if (Math.Abs(i - A) == Math.Abs(j - B))
                    {
                        field[i - P, j - R] = 1;
                    }
                }
            }
            for (int i = 0; i < field.GetLength(0); i++)
            {
                var sb = new StringBuilder();
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (j < field.GetLength(1) - 1)
                    {
                        if (field[i, j] == 1)
                        {
                            sb.Append("#");
                        }
                        else
                        {
                            sb.Append(".");
                        }
                    }
                    else
                    {
                        if (field[i, j] == 1)
                        {
                            sb.Append("#");
                            Console.WriteLine(sb.ToString());
                        }
                        else
                        {
                            sb.Append(".");
                            Console.WriteLine(sb.ToString());
                        }
                    }
                }
            }
        }
        public static void ABC230_D()
        {
            var ND = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var kabe = new (int, int)[ND[0]];
            for (int i = 0; i < ND[0]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                kabe[i] = (read[0], read[1]);
            }
            kabe = kabe.ToList().OrderBy(x => x.Item2).ToArray();
            int ans = 0;
            long tempR = -1;
            for (int i = 0; i < ND[0]; i++)
            {
                if (tempR < kabe[i].Item1)
                {
                    tempR = kabe[i].Item2 + ND[1] - 1;
                    ans++;
                }
            }
            Console.WriteLine(ans);
        }
        public static void ABC230_E()
        {
            long N = long.Parse(Console.ReadLine());
            long ans = 0;
            for (long i = 1; i <= N;)
            {
                long x = N / i;
                long ni = N / x + 1;
                ans += x * (ni - i);
                i = ni;
            }
            Console.WriteLine(ans);

        }
        public static void ABC113_C()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var list = new Dictionary<String, Set<int>>();
            var PY = new (int, int)[NM[1]];
            for (int i = 0; i < NM[1]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                PY[i] = (read[0], read[1]);
                var P = read[0].ToString("000000");
                if (!list.ContainsKey(P))
                {
                    list.Add(P, new Set<int>());
                    list[P].Add(read[1]);
                }
                else
                {
                    list[P].Add(read[1]);
                }
            }
            for (int i = 0; i < NM[1]; i++)
            {
                String id = "";
                id += PY[i].Item1.ToString("000000");
                id += list[id].LowerBound(PY[i].Item2 + 1).ToString("000000");
                Console.WriteLine(id);
            }
        }
        public static void ABC094_D()
        {
            int n = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Array.Sort(a);
            int l = 0;
            int r = n;
            while (r - l > 1)
            {
                int mid = (l + r) / 2;
                if (a[mid] > a[n - 1] / 2)
                {
                    r = mid;
                }
                else
                {
                    l = mid;
                }
            }
            int choose = l;
            if (a[n - 1] - a[l + 1] == a[n - 1] / 2)
            {
                choose = l + 1;
            }
            else if (Math.Abs(a[l] - a[n - 1] / 2) > Math.Abs(a[l + 1] - a[n - 1] / 2))
            {
                choose = l + 1;
            }
            Console.WriteLine($"{a[n - 1]} {a[choose]}");
        }
        public static void ABC110_C()
        {
            var S = Console.ReadLine().ToCharArray();
            var T = Console.ReadLine().ToCharArray();
            var lists = new Dictionary<char, char>();
            var listt = new Dictionary<char, char>();
            bool ok = true;
            for (int i = 0; i < S.Length; i++)
            {
                if (lists.ContainsKey(S[i]) || listt.ContainsKey(T[i]))
                {
                    if (lists.ContainsKey(S[i]) && T[i] != lists[S[i]])
                    {
                        ok = false;
                        break;
                    }
                    if (listt.ContainsKey(T[i]) && S[i] != listt[T[i]])
                    {
                        ok = false;
                        break;
                    }

                }
                else if (S[i] != T[i])
                {
                    lists.Add(S[i], T[i]);
                    listt.Add(T[i], S[i]);
                }
            }
            if (ok)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        public static void ABC049_C()
        {
            String S = Console.ReadLine();
            var list = new String[4];
            list[0] = "maerd";
            list[1] = "remaerd";
            list[2] = "esare";
            list[3] = "resare";
            var sb = new StringBuilder();
            var ok = true;
            for (int i = S.Length - 1; i >= 0; i--)
            {
                sb.Append(S[i]);
                if (sb.Length == 5)
                {
                    if (sb.ToString() == list[0] || sb.ToString() == list[2])
                    {
                        sb.Clear();
                    }
                }
                else if (sb.Length == 6)
                {
                    if (sb.ToString() == list[3])
                    {
                        sb.Clear();
                    }
                }
                else if (sb.Length == 7)
                {
                    if (sb.ToString() == list[1])
                    {
                        sb.Clear();
                    }
                }
                else if (sb.Length > 7)
                {
                    ok = false;
                    break;
                }
            }
            if (ok) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
        public static void keyence2020_B()
        {
            int N = int.Parse(Console.ReadLine());
            var robo = new (int, int)[N];
            for (int i = 0; i < N; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                robo[i] = (read[0] - read[1], read[0] + read[1]);
            }
            robo = robo.ToList().OrderBy(x => x.Item2).ToArray();
            var ans = 0;
            long temp = -longMax;
            for (int i = 0; i < N; i++)
            {
                if (temp <= robo[i].Item1)
                {
                    ans++;
                    temp = robo[i].Item2;
                }
            }
            Console.WriteLine(ans);
        }
        public static void AGC056_A()
        {
            int N = int.Parse(Console.ReadLine());
            if (N == 6)
            {
                Console.WriteLine("###...");
                Console.WriteLine("...###");
                Console.WriteLine("###...");
                Console.WriteLine("...###");
                Console.WriteLine("###...");
                Console.WriteLine("...###");
            }
            else if (N == 7)
            {
                Console.WriteLine("##..#..");
                Console.WriteLine("##..#..");
                Console.WriteLine("..##.#.");
                Console.WriteLine("..##.#.");
                Console.WriteLine("##....#");
                Console.WriteLine("..##..#");
                Console.WriteLine("....###");
            }
            else
            {
                int M = N - 3;
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if (i >= M)
                        {
                            if (j >= M) Console.Write("#");
                            else Console.Write(".");
                        }
                        else
                        {
                            if (j < M)
                            {
                                int k = (i - j + M) % M;
                                if (k == 0 || k == 1 || k == 3) Console.Write("#");
                                else Console.Write(".");
                            }
                            else Console.Write(".");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
        public static void ABC084_C()
        {
            int N = int.Parse(Console.ReadLine());
            var list = new (int, int, int)[N];
            for (int i = 0; i < N - 1; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                list[i] = (read[0], read[1], read[2]);
            }
            for (int i = 0; i < N - 1; i++)
            {
                var ans = 0;
                ans += list[i].Item2 + list[i].Item1;
                for (int j = i + 1; j < N - 1; j++)
                {
                    int wait = 0;
                    if (ans > list[j].Item2)
                    {
                        wait = (list[j].Item3 - (ans - list[j].Item2) % list[j].Item3) % list[j].Item3;
                    }
                    else
                    {
                        wait = list[j].Item2 - ans;
                    }
                    ans += wait + list[j].Item1;
                }
                Console.WriteLine(ans);
            }
            Console.WriteLine(0);
        }
        public static void codefes2016C_B()
        {
            var KT = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int ans = 0;
            Array.Sort(a);
            ans = Math.Max(a[KT[1] - 1] - (KT[0] - a[KT[1] - 1]) - 1, 0);
            Console.WriteLine(ans);
        }
        public static void ABC107_C()
        {
            var NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var x = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long ans = longMax;
            for (int i = 0; i <= NK[0] - NK[1]; i++)
            {
                ans = Math.Min(ans, Math.Abs(x[i]) + Math.Abs(x[i + NK[1] - 1] - x[i]));
                ans = Math.Min(ans, Math.Abs(x[i + NK[1] - 1]) + Math.Abs(x[i + NK[1] - 1] - x[i]));
            }
            Console.WriteLine(ans);
        }
        public static void ARC131_B()
        {
            var HW = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var field = new char[HW[0]][];
            for (int i = 0; i < HW[0]; i++)
            {
                field[i] = Console.ReadLine().ToCharArray();
            }
            var move = new (int, int)[] { (-1, 0), (1, 0), (0, -1), (0, 1) };
            for (int i = 0; i < HW[0]; i++)
            {
                for (int j = 0; j < HW[1]; j++)
                {
                    var list = new List<char>();
                    list.Add('1');
                    list.Add('2');
                    list.Add('3');
                    list.Add('4');
                    list.Add('5');
                    if (field[i][j] == '.')
                    {
                        foreach (var v in move)
                        {
                            if (i + v.Item1 >= 0 && i + v.Item1 < HW[0] && j + v.Item2 >= 0 && j + v.Item2 < HW[1])
                            {
                                if (field[i + v.Item1][j + v.Item2] != '.')
                                {
                                    list.Remove(field[i + v.Item1][j + v.Item2]);
                                }
                            }

                        }
                        field[i][j] = list[0];
                    }
                }
            }
            for (int i = 0; i < HW[0]; i++)
            {
                var sb = new StringBuilder();
                for (int j = 0; j < HW[1]; j++)
                {
                    sb.Append(field[i][j]);
                }
                Console.WriteLine(sb.ToString());
            }
        }
        public static void ARC131_A()
        {
            var A = int.Parse(Console.ReadLine());
            var B = int.Parse(Console.ReadLine());
            String ans = "";
            var temp = B / 2;
            if (B % 2 == 0)
            {

                ans += Convert.ToString(A) + Convert.ToString(temp);
            }
            else if (B == 1)
            {
                ans += '5' + Convert.ToString(A);
            }
            else
            {

                var temp2 = (B % 10 - 1) / 2;
                temp = (int)Math.Floor((decimal)B / 2);
                ans += Convert.ToString(temp) + '5' + Convert.ToString(A);

            }
            Console.WriteLine(ans);
        }
        public static void AGC011_B()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            Array.Sort(A);
            int ans = N;
            long sum = 0;
            int index = 0;
            for (int i = 0; i < N - 1; i++)
            {
                sum += A[i];
                if (sum * 2 < A[i + 1])
                {
                    index = i + 1;
                }
            }
            Console.WriteLine(ans - index);
        }
        /// <summary>
        /// ユークリッド
        /// </summary>
        public static void AGC018_A()
        {
            var NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Array.Sort(A);
            var list = new List<int>();
            long temp = A[0];
            if (A[NK[0] - 1] < NK[1])
            {
                Console.WriteLine("IMPOSSIBLE");
                return;
            }
            else
            {
                for (int i = 0; i < NK[0] - 1; i++)
                {
                    if (A[i] == NK[1])
                    {
                        Console.WriteLine("POSSIBLE");
                        return;
                    }
                    temp = gcd(temp, A[i + 1]);
                }
            }
            if (NK[1] % temp == 0)
            {
                Console.WriteLine("POSSIBLE");
            }
            else
            {
                Console.WriteLine("IMPOSSIBLE");
            }
            long gcd(long C, long D)
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
        }
        public static void ABC134_D()
        {
            int N = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var A = new int[N + 1];
            for (int i = 1; i < N + 1; i++)
            {
                A[i] = a[i - 1];
            }

            var b = new int[N + 1];
            for (int i = N; i >= 1; i--)
            {
                var count = 0;
                for (int j = i * 2; j <= N; j += i)
                {
                    if (b[j] > 0) count++;
                }
                if (count % 2 != A[i]) b[i] = 1;
            }
            var ans = new List<int>();
            for (int i = 1; i <= N; i++)
            {
                if (b[i] > 0) ans.Add(i);
            }
            Console.WriteLine(ans.Count());
            if (ans.Count() == 0) return;
            var sb = new StringBuilder();
            foreach (var i in ans)
            {
                sb.Append($"{i} ");
            }
            Console.WriteLine(sb.ToString().TrimEnd());
        }
        public static void ARC067_C()
        {
            int N = int.Parse(Console.ReadLine());
            var list = new Dictionary<int, int>();

            while (N > 1)
            {
                int temp = N;
                for (int i = 2; i <= Math.Sqrt(N); i++)
                {
                    while (temp > 0 && temp % i == 0)
                    {
                        if (!list.ContainsKey(i))
                        {
                            list.Add(i, 1);
                        }
                        else
                        {
                            list[i]++;
                        }
                        temp /= i;
                    }
                }
                if (temp != 1)
                {
                    if (!list.ContainsKey(temp))
                    {
                        list.Add(temp, 1);
                    }
                    else
                    {
                        list[temp]++;
                    }
                }

                N--;
            }
            long ans = 1;
            foreach (var i in list)
            {
                ans *= (i.Value + 1);
                ans %= 1000000007;
            }
            Console.WriteLine(ans);
        }
        public static void ABC133_D()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var sum = A.Sum();
            var dam = new long[N];
            dam[0] = sum;
            for (int i = 1; i < N; i += 2)
            {
                dam[0] -= 2 * A[i];
            }

            for (int i = 1; i < N; i++)
            {
                dam[i] = 2 * A[i - 1] - dam[i - 1];
            }
            var sb = new StringBuilder();
            for (int i = 0; i < N; i++)
            {
                sb.Append($"{dam[i]} ");
            }
            Console.WriteLine(sb.ToString().TrimEnd());
        }
        public static void ARC066_C()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var list = new Dictionary<int, int>();
            long mod = 1000000007;
            for (int i = 0; i < N; i++)
            {
                if (!list.ContainsKey(A[i]))
                {
                    list.Add(A[i], 1);
                }
                else
                {
                    list[A[i]]++;
                    if (A[i] == 0 && list[A[i]] > 1)
                    {
                        Console.WriteLine(0);
                        return;
                    }
                    else if (list[A[i]] > 2)
                    {
                        Console.WriteLine(0);
                        return;
                    }
                }
            }
            long ans = 0;
            if (N % 2 == 0)
            {
                ans = pow(2, list.Count());
            }
            else
            {
                ans = pow(2, list.Count() - 1);
            }
            Console.WriteLine(ans);
            long pow(long x, int n)
            {
                long ret = 1;
                while (n > 0)
                {
                    if ((n & 1) > 0)
                    {
                        ret *= x;
                        ret %= mod;
                    }
                    x *= x;
                    x %= mod;
                    n = n >> 1;
                }
                return ret;
            }
        }
        public static void ABC085_D()
        {
            var NH = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var attack = new (int, int)[NH[0]];
            for (int i = 0; i < NH[0]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                attack[i] = (read[0], read[1]);
            }
            attack = attack.ToList().OrderBy(x => x.Item1).Reverse().ToArray();
            var max = attack[0].Item1;
            attack = attack.ToList().OrderByDescending(x => x.Item2).ToArray();
            long ans = 0;
            for (int i = 0; i < NH[0]; i++)
            {
                if (max <= attack[i].Item2)
                {
                    NH[1] -= attack[i].Item2;
                    ans++;
                    if (NH[1] <= 0) break;
                }
            }
            if (NH[1] > 0)
            {
                if (NH[1] % max == 0)
                {
                    ans += NH[1] / max;
                }
                else
                {
                    ans += (int)Math.Floor(NH[1] / (decimal)max) + 1;
                }
            }
            Console.WriteLine(ans);
        }
        public static void typical90_046()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var B = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var C = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var listA = new Dictionary<int, long>();
            var listB = new Dictionary<int, long>();
            var listC = new Dictionary<int, long>();
            for (int i = 0; i < N; i++)
            {
                if (!listA.ContainsKey(A[i] % 46))
                {
                    listA.Add(A[i] % 46, 1);
                }
                else
                {
                    listA[A[i] % 46]++;
                }
                if (!listB.ContainsKey(B[i] % 46))
                {
                    listB.Add(B[i] % 46, 1);
                }
                else
                {
                    listB[B[i] % 46]++;
                }
                if (!listC.ContainsKey(C[i] % 46))
                {
                    listC.Add(C[i] % 46, 1);
                }
                else
                {
                    listC[C[i] % 46]++;
                }
            }
            long ans = 0;
            for (int i = 0; i < 46; i++)
            {
                for (int j = 0; j < 46; j++)
                {
                    for (int k = 0; k < 46; k++)
                    {
                        if ((i + j + k) % 46 == 0)
                        {
                            if (listA.ContainsKey(i) && listB.ContainsKey(j) && listC.ContainsKey(k))
                                ans += listA[i] * listB[j] * listC[k];
                        }
                    }
                }
            }
            Console.WriteLine(ans);
        }
        public static void typical90_048()
        {
            var NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var score = new (int, int)[NK[0]];
            var list = new List<int>();
            for (int i = 0; i < NK[0]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                list.Add(read[1]);
                list.Add(read[0] - read[1]);
            }
            long ans = 0;
            list = list.OrderByDescending(x => x).ToList();
            for (int i = 0; i < NK[1]; i++)
            {
                ans += list[i];
            }
            Console.WriteLine(ans);
        }
        public static void typical90_050()
        {
            var NL = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var dp = new long[NL[0] + 1];
            dp[0] = 1;
            for (int i = 1; i < NL[0] + 1; i++)
            {
                if (i >= NL[1])
                {
                    dp[i] = dp[i - 1] + dp[i - NL[1]];
                    dp[i] %= 1000000007;
                }
                else
                {
                    dp[i] = dp[i - 1];
                }
            }
            Console.WriteLine(dp[NL[0]]);
        }
        /// <summary>
        /// 半分全列挙
        /// </summary>
        public static void typical90_051()
        {
            var NKP = Console.ReadLine().Split().Select(long.Parse).ToArray();
            int N = (int)NKP[0];
            int K = (int)NKP[1];
            long P = NKP[2];
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var list = new Dictionary<long, List<long>>();
            int mid = N / 2;
            for (int i = 0; i < 1 << mid; i++)
            {
                long cnt1 = 0, cnt2 = 0;
                for (int j = 0; j < mid; j++)
                {
                    if ((1 & (i >> j)) == 1)
                    {
                        cnt1 += A[j];
                        cnt2 += 1;
                    }
                }
                if (!list.ContainsKey(cnt2))
                {
                    list.Add(cnt2, new List<long>());
                    list[cnt2].Add(cnt1);
                }
                else if (cnt2 != 0)
                {
                    list[cnt2].Add(cnt1);
                }
            }
            var list2 = new Dictionary<long, List<long>>();
            for (int i = 0; i < 1 << (N - mid); i++)
            {
                long cnt1 = 0, cnt2 = 0;
                for (int j = 0; j < N - mid; j++)
                {
                    if ((1 & (i >> j)) == 1)
                    {
                        cnt1 += A[mid + j];
                        cnt2 += 1;
                    }
                }
                if (!list2.ContainsKey(cnt2))
                {
                    list2.Add(cnt2, new List<long>());
                    list2[cnt2].Add(cnt1);
                }
                else if (cnt2 != 0)
                {
                    list2[cnt2].Add(cnt1);
                }
            }
            for (int i = 0; i <= N; i++)
            {
                if (list.ContainsKey(i))
                    list[i] = list[i].OrderBy(x => x).ToList();
                if (list2.ContainsKey(i))
                    list2[i] = list2[i].OrderBy(x => x).ToList();

            }
            long ans = 0;
            for (int h = 0; h <= Math.Min(K, mid); h++)
            {
                for (int i = 0; i < list[h].Count(); i++)
                {
                    if (list2.ContainsKey(K - h))
                    {
                        long rest = P - list[h].ElementAt(i) + 1;
                        int l = 0, r = list2[K - h].Count();
                        while (r - l > 1)
                        {
                            int m = (r + l) / 2;
                            if (list2[K - h].ElementAt(m) > rest)
                            {
                                r = m;
                            }
                            else
                            {
                                l = m;
                            }
                        }
                        if (l == 0 && list2[K - h][0] < rest)
                        {
                            ans += 1;
                        }
                        else if (l != 0)
                        {
                            ans += l + 1;
                        }
                    }

                }
            }
            Console.WriteLine(ans);
        }
        public static void typical90_052()
        {
            int N = int.Parse(Console.ReadLine());
            var dice = new int[N][];
            long ans = 1;

            for (int i = 0; i < N; i++)
            {
                dice[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
                ans *= dice[i].Sum();
                ans %= 1000000007;
            }
            Console.WriteLine(ans);
        }
        public static void typical90_058()
        {
            var NK = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var list = new List<int>();
            String temp = Convert.ToString(NK[0]);

            for (int i = 0; i < 100000; i++)
            {
                int itemp = 0;
                for (int j = 0; j < Convert.ToString(i).Length; j++)
                {
                    itemp += (Convert.ToString(i)[j] - '0');
                }
                list.Add((i + itemp) % 100000);
            }
            var time = Enumerable.Repeat(-1, 100000).ToList();
            int pos = (int)NK[0], cnt = 0;
            while (time[pos] == -1)
            {
                time[pos] = cnt;
                pos = list[pos];
                cnt++;
            }
            int cycle = cnt - time[pos];
            if (NK[1] >= time[pos])
            {
                NK[1] = (NK[1] - time[pos]) % cycle + time[pos];
            }
            int ans = -1;
            for (int i = 0; i < 100000; i++)
            {
                if (time[i] == NK[1]) ans = i;
            }
            Console.WriteLine(ans);
        }
        public static void typical90_056()
        {
            var NS = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var huku = new (int, int)[NS[0]];
            for (int i = 0; i < NS[0]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                huku[i] = (read[0], read[1]);
            }
            var dp = new bool[NS[0] + 1, NS[1] + 1];
            dp[0, 0] = true;
            for (int i = 0; i < NS[0]; i++)
            {
                for (int j = 0; j < NS[1]; j++)
                {
                    if (dp[i, j] && j + huku[i].Item1 <= NS[1])
                    {
                        dp[i + 1, j + huku[i].Item1] = true;
                    }
                    if (dp[i, j] && j + huku[i].Item2 <= NS[1])
                    {
                        dp[i + 1, j + huku[i].Item2] = true;
                    }
                }
            }
            var sb = new StringBuilder();
            int now = NS[1];
            for (int i = NS[0]; i >= 1; i--)
            {
                if (now - huku[i - 1].Item1 >= 0 && dp[i - 1, now - huku[i - 1].Item1])
                {
                    sb.Append("A");
                    now -= huku[i - 1].Item1;
                }
                else if (now - huku[i - 1].Item2 >= 0 && dp[i - 1, now - huku[i - 1].Item2])
                {
                    sb.Append("B");
                    now -= huku[i - 1].Item2;
                }

            }
            var ans = sb.ToString().ToCharArray();
            Array.Reverse(ans);
            if (ans.Length == NS[0])
                Console.WriteLine(new String(ans));
            else Console.WriteLine("Impossible");
        }
        public static void AGC036_A()
        {
            long S = long.Parse(Console.ReadLine());
            long x1 = S;
            long y1 = 0;
            long x2 = 0;
            long y2 = 0;
            if (x1 <= 1000000000)
            {
                y2 = 1;
            }
            else
            {
                x1 = (long)Math.Ceiling(Math.Sqrt(S));
                y2 = (long)Math.Ceiling((decimal)S / x1);
                x2 = 1;
                y1 = x1 * y2 - S;
            }
            Console.WriteLine($"0 0 {x1} {y1} {x2} {y2}");
        }
        /// <summary>
        /// s
        /// </summary>
        public static void typical90_067()
        {
            var NK = Console.ReadLine().Split();
            int K = int.Parse(NK[1]);
            long temp10 = 0;
            String temp = Convert.ToString(NK[0]);
            while (K > 0)
            {
                temp10 = to10(Convert.ToString(temp));
                String temp9 = to9(temp10);
                temp = temp9;
                K--;
            }
            if (temp != "")
                Console.WriteLine(temp);
            else Console.WriteLine(0);
            long to10(String N)
            {
                long ans = 0, x = 1, size = N.Length;
                for (int i = (int)size - 1; i >= 0; i--)
                {
                    ans += 1 * (N[i] - '0') * x;
                    x *= 8;
                }
                return ans;
            }
            String to9(long N)
            {
                String ans = "";
                while (N > 0)
                {
                    if (N % 9 != 8)
                        ans = (N % 9) + ans;
                    else ans = '5' + ans;
                    N /= 9;
                }
                return ans;
            }
        }
        public static void disco2020_C()
        {
            var HWK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int H = HWK[0];
            int W = HWK[1];
            int K = HWK[2];
            var field = new char[H][];
            var ans = new int[H, W];
            int index = 0;
            for (int i = 0; i < H; i++)
            {
                field[i] = Console.ReadLine().ToCharArray();
            }
            var cnt = new int[H];
            for (int i = 0; i < H; i++)
            {

                for (int j = 0; j < W; j++)
                {
                    if (field[i][j] == '#') cnt[i]++;
                }
            }
            var list = new List<int>();
            for (int i = 0; i < H; i++)
            {
                if (cnt[i] >= 1) list.Add(i);
            }
            for (int i = 0; i < list.Count(); i++)
            {
                int v1 = 0, v2 = H - 1;
                if (i >= 1) v1 = list.ElementAt(i - 1) + 1;
                if (i < list.Count() - 1) v2 = list.ElementAt(i);
                Solve(v1, v2);
            }
            for (int i = 0; i < H; i++)
            {
                var sb = new StringBuilder();
                for (int j = 0; j < W; j++)
                {
                    sb.Append($"{ans[i, j]} ");
                }
                Console.WriteLine(sb.ToString().TrimEnd());
            }

            void Solve(int cl, int cr)
            {
                var p = new List<int>();
                for (int i = cl; i <= cr; i++)
                {
                    for (int j = 0; j < W; j++)
                    {
                        if (field[i][j] == '#') p.Add(j);
                    }
                }
                p = p.OrderBy(x => x).ToList();

                for (int i = 0; i < p.Count(); i++)
                {
                    int v1 = 0, v2 = W - 1;
                    if (i >= 1) v1 = p.ElementAt(i - 1) + 1;
                    if (i < p.Count() - 1) v2 = p.ElementAt(i);
                    index++;

                    for (int j = cl; j <= cr; j++)
                    {
                        for (int k = v1; k <= v2; k++)
                        {
                            ans[j, k] = index;
                        }
                    }

                }
            }
        }
        public static void ABC151_D()
        {
            var HW = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var S = new char[HW[0], HW[1]];
            var list = new List<(int, int)>();
            for (int i = 0; i < HW[0]; i++)
            {
                var read = Console.ReadLine().ToCharArray();
                for (int j = 0; j < HW[1]; j++)
                {
                    S[i, j] = read[j];
                    if (S[i, j] == '.')
                    {
                        list.Add((i, j));
                    }
                }
            }
            var ans = 0;
            foreach (var v in list)
            {
                ans = Math.Max(ans, bfs(v.Item1, v.Item2));
            }

            Console.WriteLine(ans);


            int bfs(int y, int x)
            {
                var q = new Queue<(int, int)>();
                q.Enqueue((y, x));
                int temp = 0;
                var cnt = new int[HW[0], HW[1]];
                for (int i = 0; i < HW[0]; i++)
                {
                    for (int j = 0; j < HW[1]; j++)
                    {
                        cnt[i, j] = intMax;
                    }
                }
                cnt[y, x] = 0;
                var move = new (int, int)[4] { (-1, 0), (1, 0), (0, 1), (0, -1) };
                while (q.Count() != 0)
                {
                    var now = q.Dequeue();
                    foreach (var v in move)
                    {
                        int ny = now.Item1 + v.Item1, nx = now.Item2 + v.Item2;
                        if (ny >= 0 && ny < HW[0] && nx >= 0 && nx < HW[1])
                        {
                            if (S[ny, nx] == '.' && cnt[ny, nx] > cnt[now.Item1, now.Item2] + 1)
                            {
                                q.Enqueue((ny, nx));
                                cnt[ny, nx] = cnt[now.Item1, now.Item2] + 1;
                                if (temp < cnt[ny, nx])
                                {
                                    temp = cnt[ny, nx];
                                }
                            }
                        }
                    }
                }
                return temp;
            }
        }
        public static void ABC167_D()
        {
            var NK = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var list = new List<int>();

            var start = 0;
            int start_i = 0;
            int index = 1;
            var journey = new int[(int)NK[0]];

            while (journey[start] == 0)
            {
                journey[start] = index;
                list.Add(A[start] - 1);
                start = A[start] - 1;
                index++;
            }


            start_i = journey[start] - 1;
            int cycle = list.Count() - start_i;

            if (NK[1] < list.Count())
            {
                Console.WriteLine(list[(int)NK[1] - 1] + 1);
            }
            else
            {

                long temp = (NK[1] - (long)start_i - 1) % cycle;
                Console.WriteLine(list[(int)temp + start_i] + 1);

            }
        }
        public static void ABC231_A()
        {
            int D = int.Parse(Console.ReadLine());
            Console.WriteLine((double)D / 100);
        }
        public static void ABC231_B()
        {
            int N = int.Parse(Console.ReadLine());
            var list = new Dictionary<String, int>();
            for (int i = 0; i < N; i++)
            {
                var read = Console.ReadLine();
                if (!list.ContainsKey(read))
                {
                    list.Add(read, 1);
                }
                else
                {
                    list[read]++;
                }
            }
            list = list.OrderByDescending(x => x.Value).ToDictionary(key => key.Key, val => val.Value);
            Console.WriteLine(list.ElementAt(0).Key);
        }
        public static void ABC231_C()
        {
            var NQ = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Array.Sort(A);
            for (int i = 0; i < NQ[1]; i++)
            {
                int x = int.Parse(Console.ReadLine());
                int l = 0;
                int r = NQ[0] - 1;
                while (r - l > 1)
                {
                    int mid = (l + r) / 2;
                    if (A[mid] > x)
                    {
                        r = mid;
                    }
                    else
                    {
                        l = mid;
                    }
                }
                if (l < NQ[0] - 1 && A[l + 1] < x) l++;
                else if (A[l] == x) l--;
                if (A[0] > x) Console.WriteLine(NQ[0]);
                else Console.WriteLine(NQ[0] - (l + 1));
            }
        }
        public static void ABC231_D()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var list = new Dictionary<int, int>();
            var ok = true;
            var uf = new UnionFind<int>();
            for (int i = 0; i < NM[1]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (list.ContainsKey(read[0]) && list.ContainsKey(read[1]))
                {
                    if (uf.IsSame(read[0], read[1]))
                    {
                        ok = false;
                    }
                }
                if (!list.ContainsKey(read[0]))
                {
                    list.Add(read[0], 1);
                    uf.Add(read[0]);
                }
                else
                {
                    list[read[0]]++;
                }
                if (!list.ContainsKey(read[1]))
                {
                    list.Add(read[1], 1);
                    uf.Add(read[1]);
                }
                else
                {
                    list[read[1]]++;
                }
                uf.Unite(read[0], read[1]);
            }
            int one = 0;
            int two = 0;

            foreach (var i in list)
            {
                if (i.Value == 1) one++;
                if (i.Value == 2) two++;
                if (i.Value > 2)
                {
                    ok = false;
                }
            }
            if (two == NM[0] - 2 && one > 2) ok = false;
            if (two > NM[0] || one > NM[0] || two + one > NM[0]) ok = false;
            if (ok) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
        public static void ABC231_D_()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var list = new (int, int)[NM[0]];
            for (int i = 0; i < NM[0]; i++)
            {
                list[i] = (-1, -1);
            }
            for (int i = 0; i < NM[1]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                read[0]--;
                read[1]--;
                if (list[read[0]].Item1 == -1 && list[read[1]].Item2 == -1)
                {
                    list[read[0]].Item1 = 1;
                    list[read[1]].Item1 = 1;
                }
                else if (list[read[0]].Item2 == -1 && list[read[1]].Item2 == -1)
                {

                }
            }
        }
        public static void ABC231_E_sub()
        {
            var NX = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long ans = longMax;
            var bai = A[1] / A[0];
            for (int i = 0; i < NX[0]; i++)
            {
                long temp = 0;
                long cnt = 0;
                if (NX[1] % A[i] == 0)
                {
                    temp = NX[1];
                }
                else
                {
                    temp = Math.Abs(NX[1] - ((long)Math.Ceiling((decimal)NX[1] / A[i]) * A[i])) + A[i] * (long)Math.Ceiling((decimal)NX[1] / A[i]);
                }
                int index = i;
                while (temp != 0)
                {
                    cnt += temp / A[index];
                    temp %= A[index];
                    index--;
                }
                ans = Math.Min(ans, cnt);
            }
            Console.WriteLine(ans);
        }
        public static void ABC231_E()
        {
            var NX = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var memo = new Dictionary<long, long>();

            long dfs(long x, int beg)
            {
                if (memo.ContainsKey(x) && memo.ElementAt(memo.Count - 1).Key != x) return memo[x];
                if (beg == A.Length - 1) return x / A[A.Length - 1];
                if (x == 0) return 0;
                long crr = A[beg], nxt = A[beg + 1];
                long r = x % nxt / crr;
                long ans = dfs(x / nxt * nxt, beg + 1) + r;
                if (r > 0) ans = Math.Min(ans, dfs((long)Math.Ceiling((decimal)x / nxt) * nxt, beg + 1) + (nxt / crr - r));
                if (!memo.ContainsKey(x))
                    memo.Add(x, ans);
                return ans;
            }

            Console.WriteLine(dfs(NX[1], 0));
        }
        public static void ABC231_F()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var B = Console.ReadLine().Split().Select(int.Parse).ToArray();

        }
        public static void tenka2019_C()
        {
            int N = int.Parse(Console.ReadLine());
            var S = Console.ReadLine();
            int wcnt = 0;
            int bcnt = 0;
            for (int i = S.Length - 1; i >= 0; i--)
            {
                if (S[i] == '.')
                {
                    wcnt++;
                }
                else if (S[i] == '#')
                {
                    bcnt++;
                }
            }
            int lb = 0;
            int lh = 0;
            int ans = wcnt;

            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == '#')
                {
                    lb++;
                }
                else
                {
                    lh++;
                }
                ans = Math.Min(ans, lb + wcnt - lh);
            }
            Console.WriteLine(ans);

        }
        public static void codefes2017C_C()
        {
            String s = Console.ReadLine();
            int l = 0;
            int r = s.Length - 1;
            var ok = true;
            int cnt = 0;
            while (r > l)
            {
                if (s[l] != s[r])
                {
                    if (s[l] != 'x' && s[r] != 'x')
                    {
                        ok = false;
                        break;
                    }
                    else if (s[l] == 'x')
                    {
                        l++;
                        cnt++;
                    }
                    else
                    {
                        r--;
                        cnt++;
                    }
                }
                else
                {
                    l++;
                    r--;
                }
            }
            if (ok) Console.WriteLine(cnt);
            else Console.WriteLine(-1);
        }
        public static void ARC102_C()
        {
            var NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long ans = 0;
            long cnt0 = 0;
            for (int i = 1; i <= NK[0]; i++)
            {

                if (i % NK[1] == 0) cnt0++;
            }
            ans += cnt0 * cnt0 * cnt0;
            long cnt2 = 0;
            if (NK[1] % 2 == 0)
            {
                for (int i = 1; i <= NK[0]; i++)
                {
                    if (i % NK[1] == NK[1] / 2) cnt2++;
                }
            }
            ans += cnt2 * cnt2 * cnt2;
            Console.WriteLine(ans);
        }
        public static void ABC231_E_sub2()
        {
            var NX = Console.ReadLine().Split().Select(long.Parse).ToArray();
            int N = (int)NX[0];
            long X = NX[1];
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();

            var cnt = new long[N];
            for (int i = A.Length - 1; i >= 0; i--)
            {
                //i番目の硬貨でi桁円目を支払う時の枚数
                cnt[i] = X / A[i];
                X %= A[i];
                //次の硬貨への倍数を格納(i番目の硬貨何枚でi + 1番目の硬貨に相当するか)
                if (i - 1 >= 0) A[i] /= A[i - 1];
            }
            //dp[i, j] i番目の硬貨まででi桁目までの支払い方を決めたときの枚数
            //         j = 0 おつりが出ないように払った時
            //         j = 1 おつりが出るように繰り上げて支払うとき
            var dp = new long[N + 1, 2];
            for (int i = 0; i < dp.GetLength(0); i++)
            {
                for (int j = 0; j < dp.GetLength(1); j++)
                {
                    dp[i, j] = longMax;
                }
            }

            dp[0, 0] = 0;
            //i番目でおつりがでるかでないかから
            //i + 1番目でおつりがでるかでないかへの遷移を考え最小枚数を記録
            for (int i = 0; i < N; i++)
            {
                long up = 0;
                if (i != N - 1)
                {
                    //i番目の硬貨でi桁目円を払う最大数
                    up = A[i + 1];
                }
                else
                {
                    //一番大きい硬貨では次の効果への繰り上げは考えない
                    //大きい値を格納すれば計算時にMinではじかれる
                    up = longMax;
                }
                //i + 1番目の硬貨でi + 1桁円目をおつりがでないように払った時の枚数
                // かつ　i 番目の硬貨でおつりが出ないように払っているとき
                dp[i + 1, 0] = Math.Min(dp[i + 1, 0], dp[i, 0] + cnt[i]);
                //前からの繰り上げがあるときupを超えないことを確認
                if (cnt[i] + 1 < up)
                {
                    //i + 1番目の硬貨でi + 1桁円目をおつりがでないように払った時の枚数
                    // かつ　i 番目の硬貨でおつりが出るように払っているとき
                    dp[i + 1, 0] = Math.Min(dp[i + 1, 0], dp[i, 1] + cnt[i] + 1);
                }
                //i番目の硬貨での支払がある時でないと繰り上がりはおこらない
                if (cnt[i] > 0)
                {
                    //i + 1番目の硬貨でi + 1桁円目をおつりがでるように払った時の枚数
                    // かつ　i 番目の硬貨でおつりが出ないように払っているとき
                    dp[i + 1, 1] = Math.Min(dp[i + 1, 1], dp[i, 0] + (up - cnt[i]));
                }
                //i + 1番目の硬貨でi + 1桁円目をおつりがでるように払った時の枚数
                // かつ　i 番目の硬貨でおつりが出るように払っているとき
                dp[i + 1, 1] = Math.Min(dp[i + 1, 1], dp[i, 1] + (up - (cnt[i] + 1)));
            }
            Console.WriteLine(dp[N, 0]);
        }
        public static void ABC064_D()
        {
            int N = int.Parse(Console.ReadLine());
            var S = Console.ReadLine();
            int lcnt = 0;
            int rcnt = 0;
            var sb = new StringBuilder();
            sb.Append(S);
            for (int i = 0; i < N; i++)
            {
                if (S[i] == '(')
                {
                    lcnt++;
                }
                else if (S[i] == ')')
                {
                    rcnt++;
                }
                if (rcnt > lcnt)
                {
                    sb.Insert(0, "(");
                    lcnt++;
                }
                else if (i == N - 1 && rcnt < lcnt)
                {
                    for (int j = 0; j < lcnt - rcnt; j++)
                    {
                        sb.Append(")");
                    }
                }
            }
            Console.WriteLine(sb.ToString());
        }
        /// <summary>
        /// ワーシャルフロイド
        /// </summary>
        public static void ABC079_D()
        {
            var HW = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var c = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < 10; j++)
                {
                    c[i, j] = read[j];
                }
            }
            for (int k = 0; k < 10; k++)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        c[i, j] = Math.Min(c[i, j], c[i, k] + c[k, j]);
                    }
                }
            }
            var f = new int[HW[0], HW[1]];
            int cost = 0;
            for (int i = 0; i < HW[0]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < HW[1]; j++)
                {
                    f[i, j] = read[j];
                    if (f[i, j] != -1 && f[i, j] != 1)
                    {
                        cost += c[f[i, j], 1];
                    }
                }
            }
            Console.WriteLine(cost);
        }
        public static void ABC084_D()
        {
            int Q = int.Parse(Console.ReadLine());
            var prime = new int[100001];
            for (int i = 2; i <= 100000; i++)
            {
                int temp = i;
                int multi = 2;
                while (temp <= 100000)
                {
                    prime[temp]++;
                    temp = i * multi;
                    multi++;
                }
            }
            var primesum = new int[100001];
            int cnt = 0;
            for (int i = 2; i <= 100000; i++)
            {
                if (i % 2 == 1 && prime[i] < 2 && prime[(i + 1) / 2] < 2)
                {
                    cnt++;
                }
                primesum[i] = cnt;
            }
            for (int i = 0; i < Q; i++)
            {
                int ans = 0;
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                ans = primesum[read[1]] - primesum[read[0] - 1];
                Console.WriteLine(ans);
            }
        }
        public static void AGC005_A()
        {
            var X = Console.ReadLine();
            var ans = X.Length;
            int tcnt = 0;
            int scnt = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] == 'S')
                {
                    scnt++;
                }
                else if (scnt > 0 && X[i] == 'T')
                {
                    ans -= 2;
                    scnt--;
                }
                else if (X[i] == 'T')
                {
                    tcnt++;
                }
            }
            Console.WriteLine(ans);
        }
        public static void ABC161_D()
        {
            int K = int.Parse(Console.ReadLine());
            int cnt = 1;
            var lunlun = new Queue<long>();
            for (int i = 1; i < 10; i++)
            {
                lunlun.Enqueue(i);
            }
            long temp = 0;
            while (cnt <= K)
            {
                temp = lunlun.Dequeue();
                if (temp % 10 != 0)
                {
                    lunlun.Enqueue(temp * 10 + temp % 10 - 1);
                }
                lunlun.Enqueue(temp * 10 + temp % 10);
                if (temp % 10 != 9)
                {
                    lunlun.Enqueue(temp * 10 + temp % 10 + 1);
                }
                cnt++;
            }
            Console.WriteLine(temp);
        }
        public static void ABC153_E()
        {
            var HN = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var attack = new (int, int)[HN[1]];
            for (int i = 0; i < HN[1]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                attack[i] = (read[0], read[1]);
            }
            var dp = new int[HN[1] + 1, HN[0] + 1];
            for (int i = 0; i < dp.GetLength(0); i++)
            {
                for (int j = 0; j < dp.GetLength(1); j++)
                {
                    dp[i, j] = intMax;
                }
            }
            dp[0, 0] = 0;
            for (int i = 0; i < HN[1]; i++)
            {
                for (int j = 0; j <= HN[0]; j++)
                {
                    dp[i + 1, j] = Math.Min(dp[i + 1, j], dp[i, j]);
                    dp[i + 1, Math.Min(HN[0], j + attack[i].Item1)] = Math.Min(dp[i + 1, Math.Min(HN[0], j + attack[i].Item1)], dp[i + 1, j] + attack[i].Item2);
                }
            }

            Console.WriteLine(dp[HN[1], HN[0]]);
        }
        /// <summary>
        /// 組み合わせ(mod)
        /// </summary>
        public static void ABC156_D()
        {
            var nab = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long mod = 1000000007;
            long ans = pow(2, nab[0]) - 1;
            long nCa = nCk(nab[0], nab[1]);
            long nCb = nCk(nab[0], nab[2]);
            ans = ans - nCa - nCb;
            while (ans < 0)
            {
                ans += mod;
            }

            Console.WriteLine(ans);

            long pow(long x, long n)
            {
                long ret = 1;
                while (n > 0)
                {
                    if ((n & 1) > 0) ret *= x;
                    x *= x;
                    x %= mod;
                    ret %= mod;
                    n = n >> 1;
                }
                return ret;
            }

            long nCk(long n, long k)
            {
                if (n < k) return 0;
                if (n == k) return 1;

                long x = 1;
                long y = 1;
                for (long i = 0; i < k; i++)
                {
                    x = x * (n - i);
                    x %= mod;
                }
                for (long i = 0; i < k; i++)
                {
                    y = y * (i + 1);
                    y %= mod;
                }
                y = pow(y, 1000000007 - 2);
                long ret = x * y;
                ret %= mod;
                return ret;
            }
        }
        public static void ABC088_D()
        {
            var HW = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var s = new char[HW[0], HW[1]];
            int black = 0;
            for (int i = 0; i < HW[0]; i++)
            {
                var read = Console.ReadLine().ToCharArray();
                for (int j = 0; j < HW[1]; j++)
                {
                    s[i, j] = read[j];
                    if (s[i, j] == '#') black++;
                }
            }
            var move = new (int, int)[4] { (-1, 0), (1, 0), (0, -1), (0, 1) };
            var cnt = new int[HW[0], HW[1]];
            for (int i = 0; i < HW[0]; i++)
            {
                for (int j = 0; j < HW[1]; j++)
                {
                    cnt[i, j] = intMax;
                }
            }
            var q = new Queue<(int, int)>();
            q.Enqueue((0, 0));
            cnt[0, 0] = 0;
            while (q.Count() != 0)
            {
                var now = q.Dequeue();
                foreach (var v in move)
                {
                    int ny = now.Item1 + v.Item1;
                    int nx = now.Item2 + v.Item2;
                    if (ny >= 0 && ny < HW[0] && nx >= 0 && nx < HW[1] && s[ny, nx] != '#')
                    {
                        if (cnt[ny, nx] == intMax)
                        {
                            cnt[ny, nx] = cnt[now.Item1, now.Item2] + 1;
                            q.Enqueue((ny, nx));
                        }
                    }
                }
            }
            if (cnt[HW[0] - 1, HW[1] - 1] == intMax) Console.WriteLine(-1);
            else Console.WriteLine(HW[0] * HW[1] - black - cnt[HW[0] - 1, HW[1] - 1] - 1);
        }
        public static void ABC145_D()
        {
            var XY = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long mod = 1000000007;
            if ((XY[0] + XY[1]) % 3 != 0)
            {
                Console.WriteLine(0);
                return;
            }

            long n = (2 * XY[1] - XY[0]) / 3;
            if (n < 0)
            {
                Console.WriteLine(0);
                return;
            }
            long m = (XY[0] - n) / 2;
            if (m < 0)
            {
                Console.WriteLine(0);
                return;
            }
            long ans = nCk(n + m, n);
            Console.WriteLine(ans);
            long nCk(long n, long k)
            {
                if (n < k) return 0;
                if (n == k) return 1;

                long x = 1;
                long y = 1;
                for (long i = 0; i < k; i++)
                {
                    x = x * (n - i);
                    x %= mod;
                }
                for (long i = 0; i < k; i++)
                {
                    y = y * (i + 1);
                    y %= mod;
                }
                y = pow(y, 1000000007 - 2);
                long ret = x * y;
                ret %= mod;
                return ret;
            }
            long pow(long x, long n)
            {
                long ret = 1;
                while (n > 0)
                {
                    if ((n & 1) > 0) ret *= x;
                    x *= x;
                    x %= mod;
                    ret %= mod;
                    n = n >> 1;
                }
                return ret;
            }
        }
        public static void ABC112_D()
        {
            var NM = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long ans = 1;
            if (NM[0] == 1)
            {
                Console.WriteLine(NM[1]);
                return;
            }
            for (long i = 1; i <= NM[1] / (NM[0] - 1); i++)
            {
                long temp = NM[1] - i * (NM[0] - 1);
                if (temp == 0) continue;
                if (temp % i == 0)
                {
                    ans = Math.Max(ans, i);
                }
            }
            Console.WriteLine(ans);
        }
        public static void diverta20192_B()
        {
            int N = int.Parse(Console.ReadLine());
            var list = new Dictionary<(int, int), int>();
            var ball = new (int, int)[N];
            for (int i = 0; i < N; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                ball[i] = (read[0], read[1]);
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i == j) continue;
                    int dx = ball[i].Item1 - ball[j].Item1;
                    int dy = ball[i].Item2 - ball[j].Item2;
                    if (!list.ContainsKey((dx, dy)))
                    {
                        list.Add((dx, dy), 1);
                    }
                    else
                    {
                        list[(dx, dy)]++;
                    }
                }
            }
            int ans = 0;
            if (list.Count() > 1)
            {
                ans = N - list.Values.Max();
            }
            else
            {
                ans = 1;
            }
            Console.WriteLine(ans);
        }
        public static void ABC160_E()
        {
            var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var p = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var q = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var r = Console.ReadLine().Split().Select(long.Parse).ToArray();
            Array.Sort(p);
            p = p.Reverse().ToArray();
            Array.Sort(q);
            q = q.Reverse().ToArray();
            Array.Sort(r);
            r = r.Reverse().ToArray();
            var list = new List<long>();
            for (int i = 0; i < read[0]; i++)
            {
                list.Add(p[i]);
            }
            for (int i = 0; i < read[1]; i++)
            {
                list.Add(q[i]);
            }
            list = list.OrderBy(x => x).ToList();
            for (int i = 0; i < Math.Min(list.Count(), read[4]); i++)
            {
                if (list[i] < r[i])
                {
                    list[i] = r[i];
                }
            }
            long ans = list.Sum();
            Console.WriteLine(ans);
        }
        public static void ARC067_D()
        {
            var NAB = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var X = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long ans = 0;
            for (int i = 0; i < NAB[0] - 1; i++)
            {
                if ((X[i + 1] - X[i]) * NAB[1] > NAB[2])
                {
                    ans += NAB[2];
                }
                else
                {
                    ans += (X[i + 1] - X[i]) * NAB[1];
                }
            }
            Console.WriteLine(ans);
        }
        public static void ABC217_D()
        {
            var LQ = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var set = new Set<int>();
            set.Add(0);
            set.Add(LQ[0]);
            for (int i = 0; i < LQ[1]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int ans = 0;
                if (read[0] == 1)
                {
                    set.Add(read[1]);
                }
                else
                {
                    int index = set.LowerBound(read[1]);
                    ans = set[index] - set[index - 1];
                    Console.WriteLine(ans);
                }
            }
        }
        public static void APC001_B()
        {
            int N = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var b = Console.ReadLine().Split().Select(long.Parse).ToArray();
            bool ok = true;
            if (a.Sum() > b.Sum())
            {
                ok = false;
            }
            long asum = 0;
            long bcan = 0;
            for (int i = 0; i < N; i++)
            {
                if (a[i] < b[i])
                {
                    bcan += (b[i] - a[i]) / 2;
                }
                else
                {
                    asum += a[i] - b[i];
                }
            }
            if (asum > bcan)
            {
                ok = false;
            }
            if (ok) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
        public static void AGC023_A()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var sum = new long[N + 1];
            var list = new Dictionary<long, long>();
            for (int i = 0; i < N; i++)
            {
                sum[i + 1] = sum[i] + A[i];
                if (!list.ContainsKey(sum[i + 1]))
                {
                    list.Add(sum[i + 1], 1);
                }
                else
                {
                    list[sum[i + 1]]++;
                }
            }
            long ans = 0;
            foreach (var v in list)
            {
                if (v.Key == 0)
                {
                    ans += v.Value;
                }
                if (v.Value > 1)
                {
                    ans += (v.Value - 1) * v.Value / 2;
                }
            }
            Console.WriteLine(ans);
        }
        public static void diverta2019_D()
        {
            long N = long.Parse(Console.ReadLine());
            long ans = 0;
            for (int i = 1; i <= Math.Sqrt(N); i++)
            {
                if (((N - i) / i) != 0 && N / ((N - i) / i) == N % ((N - i) / i))
                {
                    ans += (N - i) / i;
                }
            }
            Console.WriteLine(ans);
        }
        public static void ABC114_C()
        {
            int N = int.Parse(Console.ReadLine());
            int ans = 0;
            dfs("3");
            dfs("5");
            dfs("7");
            Console.WriteLine(ans);
            void dfs(String n)
            {
                int three = 0;
                int five = 0;
                int seven = 0;
                if (long.Parse(n) > N)
                {
                    return;
                }
                for (int i = 0; i < n.Length; i++)
                {
                    if (n[i] == '3')
                    {
                        three++;
                    }
                    else if (n[i] == '5')
                    {
                        five++;
                    }
                    else
                    {
                        seven++;
                    }
                }
                if (three > 0 && five > 0 && seven > 0)
                {
                    ans++;
                }
                dfs(n + '3');
                dfs(n + '5');
                dfs(n + '7');
            }
        }
        public static void ABC152_D()
        {
            int N = int.Parse(Console.ReadLine());
            long ans = 0;
            var table = new long[10, 10];
            for (int i = 1; i <= N; i++)
            {
                String num = Convert.ToString(i);
                int first = num[0] - '0';
                int last = num[num.Length - 1] - '0';
                table[first, last]++;
            }
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    ans += table[i, j] * table[j, i];
                }
            }
            Console.WriteLine(ans);
        }
        public static void codefes2016A_C()
        {
            String s = Console.ReadLine();
            long K = long.Parse(Console.ReadLine());
            var ans = new char[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != 'a' && K >= (26 - (s[i] - 'a')))
                {
                    ans[i] = 'a';
                    K -= (26 - (s[i] - 'a'));
                }
                else
                {
                    ans[i] = s[i];
                }
            }
            if (K > 0)
            {
                ans[ans.Length - 1] = Convert.ToChar((ans[ans.Length - 1] + K % 26));
            }
            Console.WriteLine(new String(ans));
        }
        public static void ABC216_D()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var a = new Stack<int>[NM[1]];
            a = a.Select(x => new Stack<int>()).ToArray();
            var top = new List<int>[NM[0] + 1];
            top = top.Select(x => new List<int>()).ToArray();
            var s = new Stack<int>();
            for (int i = 0; i < NM[1]; i++)
            {
                int k = int.Parse(Console.ReadLine());
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                read = read.Reverse().ToArray();
                for (int j = 0; j < read.Length; j++)
                {
                    a[i].Push(read[j]);
                }
                int color = a[i].Peek();
                top[color].Add(i);
                if (top[color].Count() == 2)
                {
                    s.Push(color);
                }
            }
            int cnt = 0;
            while (s.Count != 0)
            {
                int now = s.Pop();
                cnt++;
                int one = top[now].ElementAt(0);
                int two = top[now].ElementAt(1);
                top[now].RemoveAt(0);
                top[now].RemoveAt(0);
                a[one].Pop();
                if (a[one].Count != 0)
                {
                    int ncolor = a[one].Peek();
                    top[ncolor].Add(one);
                    if (top[ncolor].Count == 2)
                    {
                        s.Push(ncolor);
                    }
                }
                a[two].Pop();
                if (a[two].Count != 0)
                {
                    int ncolor = a[two].Peek();
                    top[ncolor].Add(two);
                    if (top[ncolor].Count == 2)
                    {
                        s.Push(ncolor);
                    }
                }
            }
            if (cnt == NM[0]) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
        public static void ABC129_D()
        {
            var HW = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var f = new char[HW[0]][];
            for (int i = 0; i < HW[0]; i++)
            {
                f[i] = Console.ReadLine().ToCharArray();
            }
            var tate = new int[HW[0]][];
            tate = tate.Select(x => new int[HW[1]]).ToArray();
            var yoko = new int[HW[0]][];
            yoko = yoko.Select(x => new int[HW[1]]).ToArray();
            for (int i = 0; i < HW[0]; i++)
            {
                int index = 0;
                while (index < HW[1])
                {
                    int temp = index;
                    while (index != HW[1] && f[i][index] != '#')
                    {
                        index++;
                    }
                    for (int j = temp; j < index; j++)
                    {
                        yoko[i][j] = index - temp;
                    }
                    while (index != HW[1] && f[i][index] != '.')
                    {
                        index++;
                    }
                }
            }
            for (int i = 0; i < HW[1]; i++)
            {
                int index = 0;
                while (index < HW[0])
                {
                    int temp = index;
                    while (index != HW[0] && f[index][i] != '#')
                    {
                        index++;
                    }
                    for (int j = temp; j < index; j++)
                    {
                        tate[j][i] = index - temp;
                    }
                    while (index != HW[0] && f[index][i] != '.')
                    {
                        index++;
                    }
                }
            }
            int ans = 0;
            for (int i = 0; i < HW[0]; i++)
            {
                for (int j = 0; j < HW[1]; j++)
                {
                    if (f[i][j] != '#')
                        ans = Math.Max(ans, tate[i][j] + yoko[i][j] - 1);
                }
            }
            Console.WriteLine(ans);
        }
        public static void ARC068_D()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Array.Sort(A);
            var list = new Dictionary<int, int>();
            for (int i = 0; i < N; i++)
            {
                if (!list.ContainsKey(A[i]))
                {
                    list.Add(A[i], 1);
                }
                else
                {
                    list[A[i]]++;
                }
            }
            list = list.OrderBy(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
            if (list.Count % 2 == 0)
            {
                Console.WriteLine(list.Count() - 1);
            }
            else
            {
                Console.WriteLine(list.Count());
            }
        }
        public static void AGC034_B()
        {
            String s = Console.ReadLine();
            long cnt = 0;
            var bc = new List<char>();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (bc.Count != 0 && bc[bc.Count() - 1] == 'C' && s[i] == 'B')
                {
                    bc.Add('B');
                }
                else if (bc.Count() != 0 && bc[bc.Count() - 1] == 'B' && s[i] == 'C')
                {
                    bc.Add('C');
                }
                else if (bc.Count() == 0 && s[i] == 'C')
                {
                    bc.Add('C');
                }
                else if (s[i] == 'A' && bc.Count % 2 == 0)
                {
                    cnt += (long)bc.Count / 2;
                }
                else
                {
                    bc.Clear();
                    if (s[i] == 'C')
                    {
                        bc.Add('C');
                    }
                }
            }
            Console.WriteLine(cnt);
        }
        public static void JOI006_D()
        {
            int N = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            var card = Enumerable.Range(1, 2 * N).ToArray();
            var temp = Enumerable.Range(1, 2 * N).ToArray();
            for (int i = 0; i < m; i++)
            {
                int read = int.Parse(Console.ReadLine());
                if (read == 0)
                {
                    var topharf = new int[N];
                    var downharf = new int[N];
                    for (int j = 0; j < 2 * N; j++)
                    {
                        if (j < N)
                        {
                            topharf[j] = temp[j];
                        }
                        else
                        {
                            downharf[j - N] = temp[j];
                        }
                    }
                    for (int j = 0; j < 2 * N; j++)
                    {
                        if (j % 2 == 0)
                        {
                            temp[j] = topharf[j / 2];
                        }
                        else
                        {
                            temp[j] = downharf[j / 2];
                        }
                    }
                }
                else
                {
                    var harf = new int[read];
                    for (int j = 0; j < read; j++)
                    {
                        harf[j] = temp[j];
                    }
                    for (int j = 0; j < 2 * N; j++)
                    {
                        if (j < 2 * N - read)
                        {
                            temp[j] = temp[j + read];
                        }
                        else
                        {
                            temp[j] = harf[j - (2 * N - read)];
                        }
                    }
                }
            }
            for (int i = 0; i < 2 * N; i++)
            {
                Console.WriteLine(temp[i]);
            }
        }
        public static void ABC232_A()
        {
            String s = Console.ReadLine();
            int ans = (s[0] - '0') * (s[2] - '0');
            Console.WriteLine(ans);
        }
        public static void ABC232_B()
        {
            var s = Console.ReadLine();
            var t = Console.ReadLine();
            var ok = true;
            for (int i = 0; i < s.Length; i++)
            {
                int temp = (((t[0] - s[0]) + 26) % 26);
                if (i >= 1)
                {
                    if (((s[i] + temp % 26) <= 'z' && (s[i] + temp % 26) != t[i]))
                    {
                        ok = false;
                    }
                    else if ((s[i] + temp % 26) > 'z' && ('a' + (s[i] + temp % 26 - 'z' - 1)) != t[i])
                    {
                        ok = false;
                    }
                }
            }
            if (ok) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
        public static void ABC232_C()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var A = new int[NM[0], NM[0]];
            var B = new int[NM[0], NM[0]];
            for (int i = 0; i < NM[1]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                A[read[0] - 1, read[1] - 1] = 1;
                A[read[1] - 1, read[0] - 1] = 1;
            }
            for (int i = 0; i < NM[1]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                B[read[0] - 1, read[1] - 1] = 1;
                B[read[1] - 1, read[0] - 1] = 1;
            }
            var P = Enumerable.Range(0, NM[0]).ToArray();

            do
            {
                var ok = true;
                for (int i = 0; i < NM[0]; i++)
                {
                    for (int j = 0; j < NM[0]; j++)
                    {
                        if (i == j) continue;
                        if (A[i, j] == 1 && B[P[i], P[j]] == 0)
                        {
                            ok = false;
                        }
                        if (A[i, j] == 0 && B[P[i], P[j]] == 1)
                        {
                            ok = false;
                        }
                    }
                }
                if (ok)
                {
                    Console.WriteLine("Yes");
                    return;
                }

            } while (NextPermutation.Next_Permutation(P));
            Console.WriteLine("No");

        }
        /// <summary>
        /// 経路探索、bfs
        /// </summary>
        public static void ABC232_D()
        {
            var HW = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var f = new char[HW[0]][];
            var cnt = new int[HW[0], HW[1]];
            for (int i = 0; i < HW[0]; i++)
            {
                f[i] = Console.ReadLine().ToCharArray();
            }
            cnt[0, 0] = 1;
            var q = new Queue<(int, int)>();
            q.Enqueue((0, 0));
            var move = new (int, int)[2] { (1, 0), (0, 1) };
            int ans = 1;
            while (q.Count != 0)
            {
                var now = q.Dequeue();
                foreach (var v in move)
                {
                    int ny = now.Item1 + v.Item1;
                    int nx = now.Item2 + v.Item2;
                    if (ny >= 0 && ny < HW[0] && nx >= 0 && nx < HW[1] && f[ny][nx] != '#' && cnt[ny, nx] < cnt[now.Item1, now.Item2] + 1)
                    {
                        cnt[ny, nx] = Math.Max(cnt[ny, nx], cnt[now.Item1, now.Item2] + 1);
                        q.Enqueue((ny, nx));
                        ans = Math.Max(ans, cnt[ny, nx]);
                    }
                }
            }
            Console.WriteLine(ans);
        }
        public static void ABC232_E()
        {
            var HWK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int H = HWK[0];
            int W = HWK[1];
            int K = HWK[2];
            var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int x1 = read[0];
            int y1 = read[1];
            int x2 = read[2];
            int y2 = read[3];
            //long ans = 0;
            for (int i = 0; i < K; i++)
            {
                //int yoko = 1;
                if (i > 0 && i % 2 == 0)
                {

                }
            }
        }
        public static void ABC115_D()
        {
            var NX = Console.ReadLine().Split().Select(long.Parse).ToArray();

            var paty = new long[NX[0] + 1];
            var bread = new long[NX[0] + 1];
            var burger = new long[NX[0] + 1];
            paty[0] = 1;
            for (int i = 0; i < NX[0]; i++)
            {
                paty[i + 1] = paty[i] * 2 + 1;
                bread[i + 1] = bread[i] * 2 + 2;
            }
            for (int i = 0; i <= NX[0]; i++)
            {
                burger[i] = paty[i] + bread[i];
            }
            Console.WriteLine(eat((int)NX[0], NX[1]));
            long eat(int N, long X)
            {
                if (N == 0)
                {
                    if (X > 0) return 1;
                    else return 0;
                }
                if (X <= burger[N - 1] + 1)
                {
                    return eat(N - 1, X - 1);
                }
                else
                {
                    return paty[N - 1] + 1 + eat(N - 1, X - burger[N - 1] - 2);
                }
            }

        }
        public static void ABC228_A()
        {
            var STX = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (STX[1] - STX[0] < 0)
            {
                STX[1] += 24;
            }
            if (STX[2] - STX[0] < 0)
            {
                STX[2] += 24;
            }
            if (STX[0] <= STX[2] && STX[2] < STX[1])
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        public static void panasonic2020_D()
        {
            int N = int.Parse(Console.ReadLine());
            var s = new[] { "a" };
            for (int i = 2; i <= N; i++)
            {
                s = s.SelectMany(Nexts).ToArray();
            }
            s = s.OrderBy(x => x).ToArray();
            foreach (var a in s)
            {
                Console.WriteLine(a);
            }
            IEnumerable<string> Nexts(string x)
            {
                var maxChar = (char)(x.Max() + 1);
                for (char i = 'a'; i <= maxChar; i++)
                {
                    yield return x + i;
                }
            }
        }
        public static void ABC196_D()
        {
            var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int H = read[0];
            int W = read[1];
            int A = read[2];
            int B = read[3];
            int ans = 0;
            dfs(0, 0, A, B);
            Console.WriteLine(ans);

            void dfs(int i, int bit, int a, int b)
            {
                //全箇所敷き詰められたらans +1;
                if (i == H * W)
                {
                    ans++;
                    return;
                }
                //当該箇所がすでに埋まっていれば何もせず次の箇所へ
                if (((bit >> i) & 1) == 1)
                {
                    dfs(i + 1, bit, a, b);
                    return;
                }
                //以下当該箇所が空いているとき

                //Bのタイルが余っているとき当該箇所をのbitを１にして次へ
                if (b > 0)
                {
                    dfs(i + 1, bit | (1 << i), a, b - 1);
                }
                //Aのタイルが余っているとき
                if (a > 0)
                {
                    //一つ横が空いていれば横向きに敷き詰め
                    if (i % W != W - 1 && (bit & (1 << i + 1)) == 0)
                    {
                        dfs(i + 1, bit | (1 << i) | (1 << (i + 1)), a - 1, b);
                    }
                    //一つ下が空いていれば縦向きに敷き詰め
                    if (i + W < H * W)
                    {
                        dfs(i + 1, bit | (1 << i) | (1 << (i + W)), a - 1, b);
                    }
                }

            }
        }
        public static void tenka1_C_sub()
        {
            int N = int.Parse(Console.ReadLine());
            var A = new long[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = long.Parse(Console.ReadLine());
            }
            Array.Sort(A);
            var list1 = new List<long>();
            var list2 = new List<long>();
            list1.Add(A[A.Length - 1]);
            list2.Add(A[0]);
            int l = 0;
            int r = A.Length - 2;
            while (list1.Count() < A.Length)
            {
                long dl = 0;
                long dr = 0;
                if (list1.Count() % 2 == 1)
                {
                    dl = Math.Abs(A[l] - list1[0]);
                    dr = Math.Abs(A[l] - list1[list1.Count() - 1]);
                    if (dl < dr)
                    {
                        list1.Add(A[l]);
                    }
                    else if (list1.Count() == 1)
                    {
                        list1.Add(A[l]);
                    }
                    else
                    {
                        list1.Insert(0, A[l]);
                    }
                    l++;
                }
                else
                {
                    dl = Math.Abs(A[r] - list1[0]);
                    dr = Math.Abs(A[r] - list1[list1.Count() - 1]);
                    if (dl < dr)
                    {
                        list1.Add(A[r]);
                    }
                    else
                    {
                        list1.Insert(0, A[r]);
                    }
                    r--;
                }
            }
            l = 1;
            r = A.Length - 1;
            while (list2.Count() < A.Length)
            {
                long dl = 0;
                long dr = 0;
                if (list2.Count() % 2 == 0)
                {
                    dl = Math.Abs(A[l] - list2[0]);
                    dr = Math.Abs(A[l] - list2[list2.Count() - 1]);
                    if (dl < dr)
                    {
                        list2.Add(A[l]);
                    }
                    else
                    {
                        list2.Insert(0, A[l]);
                    }
                    l++;
                }
                else
                {
                    dl = Math.Abs(A[r] - list2[0]);
                    dr = Math.Abs(A[r] - list2[list2.Count() - 1]);
                    if (dl < dr)
                    {
                        list2.Add(A[r]);
                    }
                    else if (list2.Count() == 1)
                    {
                        list2.Add(A[r]);
                    }
                    else
                    {
                        list2.Insert(0, A[r]);
                    }
                    r--;
                }
            }

            long sum1 = 0;
            long sum2 = 0;
            for (int i = 0; i < A.Length - 1; i++)
            {
                sum1 += Math.Abs(list1[i + 1] - list1[i]);
                sum2 += Math.Abs(list2[i + 1] - list2[i]);
            }
            Console.WriteLine(Math.Max(sum1, sum2));
        }
        public static void tenka1_C()
        {
            int N = int.Parse(Console.ReadLine());
            var A = new long[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = long.Parse(Console.ReadLine());
            }
            Array.Sort(A);
            var list1 = new long[N];
            var list2 = new long[N];
            int l = 0;
            int r = N - 1;
            for (int i = 1; i < N; i += 2)
            {
                list1[i] = A[l++];
                list2[i] = A[r--];
            }
            l = N - 1;
            r = 0;
            for (int i = 2; i < N; i += 2)
            {
                list1[i] = A[l--];
                list2[i] = A[r++];
            }
            list1[0] = A[l];
            list2[0] = A[r];
            long sum1 = 0;
            long sum2 = 0;
            for (int i = 0; i < A.Length - 1; i++)
            {
                sum1 += Math.Abs(list1[i + 1] - list1[i]);
                sum2 += Math.Abs(list2[i + 1] - list2[i]);
            }
            Console.WriteLine(Math.Max(sum1, sum2));

        }
        public static void ARC100_C()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long med = 0;
            var B = new long[N];
            for (int i = 0; i < N; i++)
            {
                B[i] = A[i] - i;
            }
            Array.Sort(B);
            if (N % 2 == 0)
            {
                med = (B[N / 2 - 1] + B[N / 2]) / 2;
            }
            else
            {
                med = B[N / 2];
            }
            long ans = 0;
            for (int i = 0; i < N; i++)
            {
                ans += Math.Abs(A[i] - (med + i));
            }
            Console.WriteLine(ans);

        }
        public static void ABC196_A()
        {
            var ab = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var cd = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(ab[1] - cd[0]);
        }
        public static void ABC233_A()
        {
            var XY = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int ans = (int)Math.Ceiling(((decimal)XY[1] - XY[0]) / 10);
            if (ans > 0)
                Console.WriteLine(ans);
            else Console.WriteLine(0);
        }
        public static void ABC233_B()
        {
            var LR = Console.ReadLine().Split().Select(int.Parse).ToArray();
            String s = Console.ReadLine();
            String pre = s.Substring(0, LR[0] - 1);
            String reverse = s.Substring(LR[0] - 1, (LR[1] - LR[0] + 1));
            String suf = s.Substring(LR[1], s.Length - LR[1]);
            String ans = pre + new String(reverse.Reverse().ToArray()) + suf;
            Console.WriteLine(ans);
        }
        public static void ABC233_C()
        {
            var NX = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var a = new long[NX[0]][];
            Dictionary<long, int>[] list = new Dictionary<long, int>[NX[0]];
            for (int i = 0; i < NX[0]; i++)
            {
                var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
                a[i] = new long[read[0]];
                list[i] = new Dictionary<long, int>();
                for (int j = 0; j < read[0]; j++)
                {
                    a[i][j] = read[j + 1];
                    if (!list[i].ContainsKey(read[j + 1]))
                    {
                        list[i].Add(read[j + 1], 1);
                    }
                    else
                    {
                        list[i][read[j + 1]]++;
                    }
                }
            }
            long ans = 0;
            foreach (var v in list[0])
            {
                for (int i = 0; i < list[1].Count(); i++)
                {
                    dfs(1, i, v.Key, v.Value);
                }
            }
            Console.WriteLine(ans);
            void dfs(int d, int idx, long temp, long cnt)
            {
                if (idx > list[d].Count()) return;
                if (d == NX[0] - 1 && temp * list[d].ElementAt(idx).Key == NX[1])
                {
                    ans += cnt * list[d].ElementAt(idx).Value;
                    return;
                }
                else if (d == NX[0] - 1 && temp * list[d].ElementAt(idx).Key != NX[1])
                {
                    return;
                }
                else if (temp * list[d].ElementAt(idx).Key > NX[1])
                {
                    return;
                }
                else
                {
                    for (int i = 0; i < list[d + 1].Count(); i++)
                    {
                        dfs(d + 1, i, temp * list[d].ElementAt(idx).Key, cnt * list[d].ElementAt(idx).Value);
                    }
                }
            }
        }
        public static void ABC233_D()
        {
            var NK = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var sum = new long[NK[0] + 1];
            long ans = 0;
            for (int i = 0; i < NK[0]; i++)
            {
                sum[i + 1] = sum[i] + A[i];
            }
            var list = new Dictionary<long, long>();
            for (int r = 1; r <= NK[0]; r++)
            {
                if (!list.ContainsKey(sum[r - 1]))
                {
                    list.Add(sum[r - 1], 1);
                }
                else
                {
                    list[sum[r - 1]]++;
                }
                if (list.ContainsKey(sum[r] - NK[1]))
                    ans += list[sum[r] - NK[1]];
            }
            Console.WriteLine(ans);
        }
        public static void ABC233_E()
        {
            String s = Console.ReadLine();
            var keta = new long[s.Length + 1];
            for (int i = 0; i < s.Length; i++)
            {
                keta[i + 1] = (keta[i] + (s[i] - '0'));
            }
            var ans = new long[s.Length];
            long temp = 0;
            for (int i = 0; i < s.Length; i++)
            {
                temp += keta[s.Length - i];
                ans[s.Length - i - 1] = temp % 10;
                temp /= 10;
            }
            if (temp == 0) Console.WriteLine(string.Join("", ans));
            else Console.WriteLine($"{temp}{string.Join("", ans)}");
        }
        public static void ARC132_A()
        {
            int n = int.Parse(Console.ReadLine());
            var R = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var C = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int q = int.Parse(Console.ReadLine());
            for (int i = 0; i < q; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (R[read[0] - 1] + C[read[1] - 1] > n)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(".");
                }
            }
        }
        public static void ARC132_B()
        {
            int n = int.Parse(Console.ReadLine());
            var p = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int one = 0;
            for (int i = 0; i < n; i++)
            {
                if (p[i] == 1)
                {
                    one = i;
                }
            }
            int ans = intMax;
            if (one == n - 1 && p[0] == n)
            {
                ans = 1;
            }
            else if (one == n - 1 && p[0] < p[1])
            {
                ans = 3;
            }
            else if (one == 0 && p[1] == n)
            {
                ans = 2;
            }
            else if (one == 0 && p[n - 1] == n)
            {
                ans = 0;
            }
            else if (p[0] < p[1] && p[one] < p[one + 1])
            {
                ans = Math.Min(one, n - one + 2);
            }
            else
            {
                ans = Math.Min(one + 2, (n - one));
            }
            Console.WriteLine(ans);
        }
        public static void ABC045_C()
        {
            var S = Console.ReadLine();
            long ans = 0;
            for (int i = 0; i < (1 << (S.Length - 1)); i++)
            {
                var bit = new bool[S.Length - 1];
                for (int j = 0; j < S.Length - 1; j++)
                {
                    if ((1 & (i >> j)) == 1)
                    {
                        bit[j] = true;
                    }
                }
                var temp = S;
                int cnt = 0;
                for (int j = 0; j < S.Length - 1; j++)
                {
                    if (bit[j])
                    {
                        temp = temp.Insert(j + 1 + cnt, "+");
                        cnt++;
                    }
                }
                var calc = temp.Split("+");
                ans += calc.Sum(a => Convert.ToInt64(a));
            }
            Console.WriteLine(ans);
        }
        public static void AGC038_A()
        {
            var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var field = new int[read[0], read[1]];
            for (int i = 0; i < read[0]; i++)
            {
                for (int j = 0; j < read[1]; j++)
                {
                    if (i >= read[3] && j < read[2])
                    {
                        field[i, j] = 1;
                    }
                    if (i < read[3] && j >= read[2])
                    {
                        field[i, j] = 1;
                    }
                }
            }
            for (int i = 0; i < read[0]; i++)
            {
                var sb = new StringBuilder();
                for (int j = 0; j < read[1]; j++)
                {
                    sb.Append(field[i, j]);
                }
                Console.WriteLine(sb);
            }
        }
        public static void ARC097_C()
        {
            var s = Console.ReadLine();
            int K = int.Parse(Console.ReadLine());
            var list = new List<String>();
            for (int i = 1; i <= K; i++)
            {
                for (int j = 0; j <= s.Length - i; j++)
                {
                    if (!list.Contains(s.Substring(j, i)))
                    {
                        list.Add(s.Substring(j, i));
                    }
                }
            }
            list.Sort();
            Console.WriteLine(list.ElementAt(K - 1));
        }
        public static void ABC124_D()
        {
            var NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            String S = Console.ReadLine();
            int cnt = 0;
            int ans = 0;
            int index = 0;
            for (int i = 0; i < S.Length; i++)
            {
                while (cnt <= NK[1] && index < S.Length - 1)
                {
                    if (index >= 1 && S[index - 1] == '1' && S[index] == '0' || index == 0 && S[index] == '0')
                    {
                        cnt++;
                    }
                    if (cnt == NK[1] && index < S.Length - 1 && S[index] == '1' && S[index + 1] == '0') break;
                    index++;
                }
                ans = Math.Max(ans, index - i + 1);
                if (i < S.Length - 1 && S[i] == '0' && S[i + 1] == '1') cnt--;
            }
            Console.WriteLine(ans);
        }
        public static void ABC218_A()
        {
            int N = int.Parse(Console.ReadLine());
            var S = Console.ReadLine();
            if (S[N - 1] == 'o')
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        public static void ABC091_D()
        {
            var NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long ans = 0;
            for (int i = NK[1] + 1; i <= NK[0]; i++)
            {
                long a = (NK[0] + 1) / i;
                long temp = 0;
                temp += ((long)i - NK[1]) * a;
                long l = NK[1] + i * a;
                if (l <= NK[0]) temp += NK[0] - l + 1;
                ans += temp;
            }
            if (NK[1] == 0) ans -= NK[0];
            Console.WriteLine(ans);
        }
        public static void ABC048_C()
        {
            var NX = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long ans = 0;
            for (int i = 0; i < NX[0]; i++)
            {
                if (A[i] > NX[1])
                {
                    int temp = A[i] - NX[1];
                    A[i] -= temp;
                    ans += temp;
                }
                if (i < NX[0] - 1 && A[i] + A[i + 1] > NX[1])
                {
                    int temp = A[i] + A[i + 1] - NX[1];
                    A[i + 1] -= temp;
                    ans += temp;
                }
            }
            Console.WriteLine(ans);
        }
        public static void programking_C()
        {
            int N = int.Parse(Console.ReadLine());
            var AB = new long[N];
            long X = 0;
            for (int i = 0; i < N; i++)
            {
                var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
                AB[i] = read[0] + read[1];
                X -= read[1];
            }
            AB = AB.OrderByDescending(x => x).ToArray();
            for (int i = 0; i < N; i++)
            {
                if (i % 2 == 0)
                {
                    X += AB[i];
                }
            }
            Console.WriteLine(X);
        }
        public static void AGC033_A()
        {
            var HW = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var A = new char[HW[0], HW[1]];
            var q = new Queue<(int, int, int)>();
            for (int i = 0; i < HW[0]; i++)
            {
                var read = Console.ReadLine().ToCharArray();
                for (int j = 0; j < HW[1]; j++)
                {
                    A[i, j] = read[j];
                    if (A[i, j] == '#')
                    {
                        q.Enqueue((i, j, 0));
                    }
                }
            }
            var move = new (int, int)[4] { (-1, 0), (1, 0), (0, -1), (0, 1) };
            int ans = 0;
            while (q.Count() != 0)
            {
                var now = q.Dequeue();
                foreach (var n in move)
                {
                    int dy = now.Item1 + n.Item1;
                    int dx = now.Item2 + n.Item2;
                    if (dy >= 0 && dy < HW[0] && dx >= 0 && dx < HW[1] && A[dy, dx] == '.')
                    {
                        q.Enqueue((dy, dx, now.Item3 + 1));
                        A[dy, dx] = '#';
                        ans = Math.Max(ans, now.Item3 + 1);
                    }
                }
            }
            Console.WriteLine(ans);
        }
        public static void ABC080_C()
        {
            int N = int.Parse(Console.ReadLine());
            var F = new int[N, 10];
            var P = new long[N, 11];
            for (int i = 0; i < N; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < 10; j++)
                {
                    F[i, j] = read[j];
                }
            }
            for (int i = 0; i < N; i++)
            {
                var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
                for (int j = 0; j <= 10; j++)
                {
                    P[i, j] = read[j];
                }
            }
            long ans = -longMax;
            for (int i = 1; i < (1 << 10); i++)
            {
                var bit = new bool[10];
                for (int j = 0; j < 10; j++)
                {
                    if ((1 & (i >> j)) == 1)
                    {
                        bit[j] = true;
                    }
                }
                long temp = 0;
                for (int j = 0; j < N; j++)
                {
                    int cnt = 0;
                    for (int k = 0; k < 10; k++)
                    {
                        if (F[j, k] == 1 && bit[k])
                        {
                            cnt++;
                        }
                    }
                    temp += P[j, cnt];
                }
                ans = Math.Max(ans, temp);
            }
            Console.WriteLine(ans);
        }
        public static void ABC112_C()
        {
            int N = int.Parse(Console.ReadLine());
            var x = new long[N];
            var y = new long[N];
            var h = new long[N];
            for (int i = 0; i < N; i++)
            {
                var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
                x[i] = read[0];
                y[i] = read[1];
                h[i] = read[2];
            }
            for (int i = 0; i <= 100; i++)
            {
                for (int j = 0; j <= 100; j++)
                {
                    var ok = true;
                    int idx = 0;
                    while (h[idx] == 0)
                    {
                        idx++;
                    }
                    long H = h[idx] + Math.Abs(x[idx] - i) + Math.Abs(y[idx] - j);
                    for (int k = 0; k < N; k++)
                    {
                        long temph = H - Math.Abs(x[k] - i) - Math.Abs(y[k] - j);
                        if (temph < 0) temph = 0;
                        if (h[k] != temph)
                        {
                            ok = false;
                        }
                    }
                    if (ok)
                    {
                        Console.WriteLine($"{i} {j} {H}");
                        return;
                    }
                }
            }
        }
        public static void ARC081_D()
        {
            int N = int.Parse(Console.ReadLine());
            var S = new char[2][];
            S[0] = Console.ReadLine().ToCharArray();
            S[1] = Console.ReadLine().ToCharArray();
            var list = new List<char>();
            long mod = 1000000007;
            for (int i = 0; i < N; i++)
            {
                if (S[0][i] != S[1][i])
                {
                    list.Add('Y');
                    i++;
                }
                else
                {
                    list.Add('X');
                }
            }
            long ans = 0;
            if (list[0] == 'X')
            {
                ans = 3;
            }
            else
            {
                ans = 6;
            }
            for (int i = 1; i < list.Count(); i++)
            {
                if (list[i - 1] == 'Y' && list[i] == 'Y')
                {
                    ans *= 3;
                    ans %= mod;
                }
                else if (list[i - 1] == 'Y' && list[i] == 'X')
                {
                    ans *= 1;
                }
                else if (list[i - 1] == 'X' && list[i] == 'Y')
                {
                    ans *= 2;
                    ans %= mod;
                }
                else
                {
                    ans *= 2;
                    ans %= mod;
                }
            }
            Console.WriteLine(ans);
        }
        public static void ABC157_D()
        {
            var NMK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var friend = new List<List<int>>();
            var block = new List<List<int>>();
            var uf = new UnionFind<int>();
            for (int i = 0; i < NMK[0]; i++)
            {
                friend.Add(new List<int>());
                block.Add(new List<int>());
            }
            for (int i = 0; i < NMK[1]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                friend[read[0] - 1].Add(read[1] - 1);
                friend[read[1] - 1].Add(read[0] - 1);
                if (!uf.Contains(read[0] - 1))
                {
                    uf.Add(read[0] - 1);
                }
                if (!uf.Contains(read[1] - 1))
                {
                    uf.Add(read[1] - 1);
                }
                uf.Unite(read[0] - 1, read[1] - 1);
            }
            for (int i = 0; i < NMK[2]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (uf.Contains(read[0] - 1) && uf.Contains(read[1] - 1) && uf.IsSame(read[0] - 1, read[1] - 1))
                {
                    block[read[0] - 1].Add(read[1] - 1);
                    block[read[1] - 1].Add(read[0] - 1);
                }
            }
            var sb = new StringBuilder();
            for (int i = 0; i < NMK[0]; i++)
            {
                long temp = 0;
                if (uf.Contains(i))
                {
                    temp = uf.Size(i);
                }
                temp -= friend[i].Count();
                temp -= block[i].Count();
                if (temp > 0) temp--;
                sb.Append($"{temp} ");
            }
            Console.WriteLine(sb.ToString().TrimEnd());
        }
        public static void ABC121_D()
        {
            var AB = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long ans = 0;
            if ((AB[1] - (AB[0] - 1)) % 2 == 0)
            {
                if (AB[0] % 2 == 0)
                {
                    long s = (AB[1] - (AB[0] - 1)) / 2;
                    if (s % 2 == 0)
                    {
                        ans = 0;
                    }
                    else
                    {
                        ans = 1;
                    }
                }
                else
                {
                    long s = (AB[1] - (AB[0] - 1) - 2) / 2;
                    if (s % 2 == 0)
                    {
                        ans = AB[0] ^ AB[1];
                    }
                    else
                    {
                        ans = AB[0] ^ 1 ^ AB[1];
                    }
                }
            }
            else
            {
                if (AB[0] % 2 == 0)
                {
                    long s = (AB[1] - (AB[0] - 1) - 1) / 2;
                    if (s % 2 == 0)
                    {
                        ans = AB[1] ^ 0;
                    }
                    else
                    {
                        ans = AB[1] ^ 1;
                    }
                }
                else
                {
                    long s = (AB[1] - (AB[0] - 1) - 1) / 2;
                    if (s % 2 == 0)
                    {
                        ans = AB[0] ^ 0;
                    }
                    else
                    {
                        ans = AB[0] ^ 1;
                    }
                }
            }
            Console.WriteLine(ans);
        }
        public static void mitui2019_E()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long mod = 1000000007;
            long ans = 1;
            (int, int, int) color = (0, 0, 0);
            for (int i = 0; i < N; i++)
            {
                int cnt = 0;
                if (color.Item1 == A[i])
                {
                    cnt++;
                }
                if (color.Item2 == A[i])
                {
                    cnt++;
                }
                if (color.Item3 == A[i])
                {
                    cnt++;
                }
                if (color.Item1 == A[i])
                {
                    color.Item1++;
                }
                else if (color.Item2 == A[i])
                {
                    color.Item2++;
                }
                else
                {
                    color.Item3++;
                }
                ans *= cnt;
                ans %= mod;
            }
            Console.WriteLine(ans);
        }
        public static void ABC126_D()
        {
            int N = int.Parse(Console.ReadLine());
            var graph = new List<List<(int, long)>>();
            for (int i = 0; i < N; i++)
            {
                graph.Add(new List<(int, long)>());
            }
            for (int i = 0; i < N - 1; i++)
            {
                var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
                graph[(int)read[0] - 1].Add(((int)read[1] - 1, read[2]));
                graph[(int)read[1] - 1].Add(((int)read[0] - 1, read[2]));
            }
            var q = new Queue<(int, long)>();
            var color = Enumerable.Repeat(-1, N).ToArray();
            color[0] = 0;
            foreach (var v in graph[0])
            {
                q.Enqueue(v);
                if (color[v.Item1] == -1)
                {
                    if (v.Item2 % 2 == 0)
                    {
                        color[v.Item1] = 0;
                    }
                    else
                    {
                        color[v.Item1] = 1;
                    }
                }

            }
            while (q.Count() != 0)
            {
                var now = q.Dequeue();
                foreach (var nx in graph[now.Item1])
                {
                    if (color[nx.Item1] == -1)
                    {
                        if (nx.Item2 % 2 == 0)
                        {
                            color[nx.Item1] = color[now.Item1];
                        }
                        else
                        {
                            color[nx.Item1] = color[now.Item1] ^ 1;
                        }
                        q.Enqueue((nx.Item1, nx.Item2));
                    }
                }
            }
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(color[i]);
            }
        }
        public static void ABC146_D()
        {
            int N = int.Parse(Console.ReadLine());
            var graph = new List<List<int>>();
            var color = new Dictionary<(int, int), int>();
            var edge = new List<List<int>>();
            for (int i = 0; i < N; i++)
            {
                graph.Add(new List<int>());
                edge.Add(new List<int>());
            }
            for (int i = 0; i < N - 1; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                graph[read[0] - 1].Add(read[1] - 1);
                graph[read[1] - 1].Add(read[0] - 1);
                color.Add((read[0] - 1, read[1] - 1), -1);
            }
            var q = new Queue<int>();
            int temp = 1;
            foreach (var g in graph[0])
            {
                q.Enqueue(g);
                if (color.ContainsKey((0, g)))
                {
                    if (color[(0, g)] == -1)
                    {
                        color[(0, g)] = temp;
                        edge[0].Add(temp);
                        edge[g].Add(temp);
                        temp++;
                    }
                }
            }
            int cnt = 0;
            while (q.Count() != 0)
            {
                var now = q.Dequeue();
                //int cnt = 1;
                foreach (var nx in graph[now])
                {
                    if (color.ContainsKey((now, nx)) && color[(now, nx)] == -1)
                    {
                        int col = 1;
                        while (edge[now].Contains(col) || edge[nx].Contains(col))
                        {
                            col++;
                        }

                        color[(now, nx)] = col;
                        edge[now].Add(col);
                        edge[nx].Add(col);
                        q.Enqueue(nx);
                    }
                    cnt = Math.Max(cnt, Math.Max(edge[now].Count(), edge[nx].Count()));
                }
            }
            Console.WriteLine(cnt);
            foreach (var v in color)
            {
                Console.WriteLine(v.Value);
            }
        }
        public static void ABC234_A()
        {
            long t = long.Parse(Console.ReadLine());
            long ans = f(f(f(t) + t) + f(f(t)));
            Console.WriteLine(ans);
            long f(long x)
            {
                return x * x + 2 * x + 3;

            }
        }
        public static void ABC234_B()
        {
            int N = int.Parse(Console.ReadLine());
            var point = new (int, int)[N];
            for (int i = 0; i < N; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                point[i] = (read[0], read[1]);
            }
            double ans = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    double temp = Math.Sqrt(Math.Abs(point[i].Item1 - point[j].Item1) * Math.Abs(point[i].Item1 - point[j].Item1) + Math.Abs(point[i].Item2 - point[j].Item2) * Math.Abs(point[i].Item2 - point[j].Item2));
                    ans = Math.Max(ans, temp);
                }
            }
            Console.WriteLine(ans);

        }
        public static void ABC234_C()
        {
            long K = long.Parse(Console.ReadLine());
            String ans = "";
            long temp = 1;
            for (int i = 0; i < 100; i++)
            {
                if ((1 & (K >> i)) == 1) ans = "2" + ans;
                else ans = "0" + ans;
                temp *= 2;
                if (temp > K) break;
            }
            Console.WriteLine(ans);
        }
        public static void ABC234_D()
        {
            var NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var P = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var set = new Set<int>();
            for (int i = 0; i < NK[1]; i++)
            {
                set.Add(P[i]);
            }
            int pre = 0;
            int idx = 0;
            int temp = 0;
            for (int i = NK[1] - 1; i < NK[0]; i++)
            {
                if (pre > P[i]) Console.WriteLine(pre);
                else
                {
                    //temp = set[i - (NK[1] - 1)];
                    temp = set[idx];
                    Console.WriteLine(temp);
                }
                if (i < NK[0] - 1 && P[i + 1] > temp)
                {
                    set.Add(P[i + 1]);
                    idx++;
                }
                pre = temp;
            }
        }
        public static void ABC234_s()
        {
            var NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var P = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var sortedP = new SortedDictionary<int, int>();
            for (int i = 0; i < NK[1]; i++)
            {
                sortedP.Add(P[i], 0);
            }
            for (int i = NK[1] - 1; i < NK[0]; i++)
            {

            }
        }
        public static void ABC234_E()
        {
            String X = Console.ReadLine();
            var set = new Set<long>();
            for (int d = -9; d <= 9; d++)
            {
                for (int i = 1; i <= 9; i++)
                {
                    var sb = new StringBuilder();
                    int dg = i;
                    for (int j = 0; j <= 18; j++)
                    {
                        sb.Append(Convert.ToString(dg));
                        if (sb.Length > 18) break;
                        set.Add(long.Parse(sb.ToString()));
                        dg += d;
                        if (dg < 0 || dg > 9) break;
                    }
                }
            }
            int idx = set.LowerBound(long.Parse(X));
            Console.WriteLine(set[idx]);
        }
        public static void AGC014_B()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var cnt = new int[NM[0]];
            for (int i = 0; i < NM[1]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                cnt[read[0] - 1]++;
                cnt[read[1] - 1]++;
            }
            var ok = true;
            for (int i = 0; i < NM[0]; i++)
            {
                if (cnt[i] % 2 != 0)
                {
                    ok = false;
                }
            }
            if (ok) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
        public static void ABC070_D()
        {
            int N = int.Parse(Console.ReadLine());
            var dijkstra = new Dijkstra(N + 1);
            for (int i = 0; i < N - 1; i++)
            {
                var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
                dijkstra.Add((int)read[0] - 1, (int)read[1] - 1, read[2]);
                dijkstra.Add((int)read[1] - 1, (int)read[0] - 1, read[2]);
            }
            var QK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var distance = dijkstra.GetMinCost(QK[1] - 1);
            for (int i = 0; i < QK[0]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                Console.WriteLine(distance[read[0] - 1] + distance[read[1] - 1]);
            }
        }
        public static void ABC132_D()
        {
            var NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 1; i <= NK[1]; i++)
            {
                var comb = new Comb(10000);
                if (NK[0] - NK[1] + 1 < i)
                {
                    Console.WriteLine(0);
                    continue;
                }
                long ans = comb.nCk(NK[0] - NK[1] + 1, i) * comb.nCk(NK[1] - 1, i - 1);
                ans %= 1000000007;
                Console.WriteLine(ans);
            }
        }
        public static void ABC147_D()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long ans = 0;
            long mod = 1000000007;
            for (int i = 0; i <= 60; i++)
            {
                long msk = 1L << i;
                int zero = 0;
                int one = 0;
                for (int j = 0; j < N; j++)
                {
                    if ((A[j] & msk) != 0) one++;
                    else zero++;
                }
                long temp = ((msk % mod) * zero);
                temp %= mod;
                temp *= one;
                temp %= mod;
                ans += temp;
                ans %= mod;
            }
            Console.WriteLine(ans);
        }
        public static void ABC109_D()
        {
            var HW = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var a = new int[HW[0]][];
            for (int i = 0; i < HW[0]; i++)
            {
                a[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
            int row = 0;
            int col = 0;
            bool rowdown = true;
            var list = new List<(int, int, int, int)>();
            int cnt = 0;
            while ((HW[1] % 2 == 0 && (row != 0 || col != HW[1] - 1)) || (HW[1] % 2 == 1 && (row != HW[0] - 1 || col != HW[1] - 1)))
            {
                if (a[row][col] % 2 == 1)
                {
                    if (rowdown && row == HW[0] - 1)
                    {
                        a[row][col + 1]++;
                        a[row][col]--;
                        list.Add((row, col, row, col + 1));
                    }
                    else if (rowdown)
                    {
                        a[row + 1][col]++;
                        a[row][col]--;
                        list.Add((row, col, row + 1, col));
                    }
                    else if (!rowdown && row == 0)
                    {
                        a[row][col + 1]++;
                        a[row][col]--;
                        list.Add((row, col, row, col + 1));
                    }
                    else
                    {
                        a[row - 1][col]++;
                        a[row][col]--;
                        list.Add((row, col, row - 1, col));
                    }
                }
                if (rowdown && row != HW[0] - 1)
                {
                    row++;
                }
                else if (rowdown && row == HW[0] - 1)
                {
                    col++;
                    rowdown = !rowdown;
                }
                else if (!rowdown && row == 0)
                {
                    col++;
                    rowdown = !rowdown;
                }
                else if (!rowdown && row != 0)
                {
                    row--;
                }
                cnt++;
            }
            Console.WriteLine(list.Count());
            foreach (var l in list)
            {
                Console.WriteLine($"{l.Item1 + 1} {l.Item2 + 1} {l.Item3 + 1} {l.Item4 + 1}");
            }
        }
        public static void ABC128_D()
        {
            var Nk = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var V = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long ans = 0;
            for (int l = 0; l <= Nk[0]; l++)
            {
                for (int r = 0; r <= Nk[0]; r++)
                {
                    if (l + r > Nk[0] || l + r > Nk[1]) continue;
                    int rest = Nk[1] - l - r;
                    var list = new List<long>();
                    for (int i = 0; i < l; i++)
                    {
                        list.Add(V[i]);
                    }
                    for (int i = 0; i < r; i++)
                    {
                        list.Add(V[Nk[0] - 1 - i]);
                    }
                    list = list.OrderBy(x => x).ToList();
                    long sum = list.Sum();
                    for (int i = 0; i < Math.Min(list.Count(), rest); i++)
                    {
                        if (list[i] < 0) sum += -list[i];
                    }
                    ans = Math.Max(ans, sum);
                }
            }
            Console.WriteLine(ans);
        }
        public static void ABC131_D()
        {
            int N = int.Parse(Console.ReadLine());
            var work = new (long, long)[N];
            for (int i = 0; i < N; i++)
            {
                var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
                work[i] = (read[0], read[1]);
            }
            work = work.OrderBy(x => x.Item2).ToArray();
            long temp = 0;
            var ok = true;
            for (int i = 0; i < N; i++)
            {
                temp += work[i].Item1;
                if (temp > work[i].Item2) ok = false;
            }
            if (ok) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
        public static void ABC135_D()
        {
            String S = Console.ReadLine();
            var dp = new long[S.Length + 1, 14];
            long mod = 1000000007;
            dp[0, 0] = 1;
            for (int i = 1; i <= S.Length; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    if (S[i - 1] == '?')
                    {
                        for (int k = 0; k < 10; k++)
                        {
                            dp[i, (j * 10 + k) % 13] += dp[i - 1, j];
                            dp[i, (j * 10 + k) % 13] %= mod;
                        }
                    }
                    else
                    {
                        dp[i, (j * 10 + (S[i - 1] - '0')) % 13] += dp[i - 1, j];
                    }
                }
            }
            Console.WriteLine(dp[S.Length, 5]);
        }
        public static void ABC137_D()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var work = new (long, long)[NM[0]];
            for (int i = 0; i < NM[0]; i++)
            {
                var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
                work[i] = (read[0], read[1]);
            }
            work = work.OrderBy(x => x.Item1).ThenByDescending(x => x.Item2).ToArray();
            long ans = 0;
            int idx = 0;
            var pq = new PriorityQueue<long>(NM[0] + 1);
            for (int i = NM[1] - 1; i >= 0; i--)
            {
                while (idx <= NM[0] - 1 && work[idx].Item1 == NM[1] - i)
                {
                    pq.Push(work[idx].Item2);
                    idx++;
                }
                if (pq.Count > 0)
                    ans += pq.Pop();
            }
            Console.WriteLine(ans);
        }
        public static void ABC143_D()
        {
            int N = int.Parse(Console.ReadLine());
            var L = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long ans = 0;
            Array.Sort(L);
            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    int sa = Math.Abs(L[i] - L[j]);
                    int wa = L[i] + L[j];
                    for (int k = j + 1; k < N; k++)
                    {
                        if (sa < L[k] && L[k] < wa)
                        {
                            ans++;
                        }
                    }

                }
            }
            Console.WriteLine(ans);
        }
        public static void ABC144_D()
        {
            var abx = Console.ReadLine().Split().Select(int.Parse).ToArray();
            double l = 0;
            double r = 180;
            double h = (double)abx[2] / (abx[0] * abx[0]);
            double res = abx[1] - h;
            double mid = (l + r) / 2;
            for (int i = 0; i < 1000; i++)
            {
                mid = (l + r) / 2;
                double temp = 0;
                if (res < abx[1] / (double)2)
                {
                    temp = res * 2 * Math.Tan((90 - mid) * (Math.PI / 180));
                    if (temp <= abx[0])
                    {
                        r = mid;
                    }
                    else
                    {
                        l = mid;
                    }
                }
                else
                {
                    temp = (2 * abx[2]) / (abx[0] * (double)abx[1]) * Math.Tan(mid * (Math.PI / 180));

                    if (temp > abx[1])
                    {
                        r = mid;
                    }
                    else
                    {
                        l = mid;
                    }
                }

            }
            Console.WriteLine(l);
        }
        public static void ABC149_D()
        {
            var NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var RSP = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var T = Console.ReadLine();
            var preK = new Queue<char>();
            long ans = 0;
            for (int i = 0; i < NK[0]; i++)
            {
                var list = new List<char>() { 'r', 's', 'p' };

                if (i >= NK[1])
                {
                    char temp = preK.Dequeue();
                    list.Remove(temp);
                    if (T[i] == 'r')
                    {
                        if (list.Contains('p'))
                        {
                            ans += RSP[2];
                            preK.Enqueue('p');
                        }
                        else if (i + NK[1] < NK[0] && T[i + NK[1]] != 's')
                        {
                            preK.Enqueue('r');
                        }
                        else
                        {
                            preK.Enqueue('s');
                        }
                    }
                    else if (T[i] == 's')
                    {
                        if (list.Contains('r'))
                        {
                            ans += RSP[0];
                            preK.Enqueue('r');
                        }
                        else if (i + NK[1] < NK[0] && T[i + NK[1]] != 'p')
                        {
                            preK.Enqueue('s');
                        }
                        else
                        {
                            preK.Enqueue('p');
                        }
                    }
                    else
                    {
                        if (list.Contains('s'))
                        {
                            ans += RSP[1];
                            preK.Enqueue('s');
                        }
                        else if (i + NK[1] < NK[0] && T[i + NK[1]] != 'r')
                        {
                            preK.Enqueue('p');
                        }
                        else
                        {
                            preK.Enqueue('r');
                        }
                    }
                }
                else
                {
                    if (T[i] == 'r')
                    {
                        ans += RSP[2];
                        preK.Enqueue('p');
                    }
                    else if (T[i] == 's')
                    {
                        ans += RSP[0];
                        preK.Enqueue('r');
                    }
                    else
                    {
                        ans += RSP[1];
                        preK.Enqueue('s');
                    }
                }
            }
            Console.WriteLine(ans);
        }
        public static void ABC148_C()
        {
            var AB = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long ans = gcd(AB[0], AB[1]);
            Console.WriteLine(ans);
            long gcd(long C, long D)
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
                var CD = (long)Math.Floor(((decimal)C * D) / tempC);
                return CD;
            }
        }
        public static void ABC150_D()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var a = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long ans = 0;
            long lcm = a[0] / 2;
            for (int i = 1; i < NM[0]; i++)
            {
                lcm = gcd(lcm, a[i] / 2);
                if (lcm > NM[1])
                {
                    Console.WriteLine(0);
                    return;
                }
            }
            for (int i = 0; i < NM[0]; i++)
            {
                if ((lcm / (a[i] / 2) % 2 == 0))
                {
                    Console.WriteLine(0);
                    return;
                }
            }
            for (int i = 1; i * lcm <= NM[1]; i += 2)
            {
                ans++;
            }

            Console.WriteLine(ans);
            long gcd(long C, long D)
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
                var CD = (long)Math.Floor(((decimal)C * D) / tempC);
                return CD;
            }

        }
        public static void ABC153_D()
        {
            long H = long.Parse(Console.ReadLine());
            long p = 0;
            long temp = H;
            long ans = 1;
            while (temp > 1)
            {
                temp /= 2;
                p++;
                ans += (long)Math.Pow(2, p);
            }

            Console.WriteLine(ans);
        }
        public static void ABC159_C()
        {
            int L = int.Parse(Console.ReadLine());
            double ans = (double)L / 3 * (double)L / 3 * (double)L / 3;

            Console.WriteLine(ans);
        }
        public static void ABC162_D()
        {
            int N = int.Parse(Console.ReadLine());
            String S = Console.ReadLine();
            var r = new List<int>();
            var g = new List<int>();
            var b = new List<int>();
            for (int i = 0; i < N; i++)
            {
                if (S[i] == 'R')
                {
                    r.Add(i);
                }
                else if (S[i] == 'G')
                {
                    g.Add(i);
                }
                else
                {
                    b.Add(i);
                }
            }
            long ans = (long)r.Count * g.Count * b.Count;

            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    int k = j + j - i;
                    if (k >= N) continue;
                    var temp = new List<char>();
                    temp.Add(S[i]);
                    if (!temp.Contains(S[j])) temp.Add(S[j]);
                    if (!temp.Contains(S[k])) temp.Add(S[k]);
                    if (temp.Count == 3)
                    {
                        ans--;
                    }
                }
            }
            Console.WriteLine(ans);

        }
        public static void ABC235_A()
        {
            var s = Console.ReadLine();
            var sb1 = new StringBuilder();
            var sb2 = new StringBuilder();
            var sb3 = new StringBuilder();
            sb1.Append(s[0]);
            sb1.Append(s[1]);
            sb1.Append(s[2]);
            sb2.Append(s[1]);
            sb2.Append(s[2]);
            sb2.Append(s[0]);
            sb3.Append(s[2]);
            sb3.Append(s[0]);
            sb3.Append(s[1]);
            int ans = Convert.ToInt32(sb1.ToString()) + Convert.ToInt32(sb2.ToString()) + Convert.ToInt32(sb3.ToString());
            Console.WriteLine(ans);
        }
        public static void ABC235_B()
        {
            int N = int.Parse(Console.ReadLine());
            var H = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int idx = 0;
            for (int i = 0; i < N - 1; i++)
            {
                if (H[i + 1] > H[i])
                {
                    idx++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(H[idx]);
        }
        public static void ABC235_C()
        {
            var NQ = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var list = new Dictionary<int, List<int>>();
            for (int i = 0; i < NQ[0]; i++)
            {
                if (!list.ContainsKey(a[i]))
                {
                    list.Add(a[i], new List<int>() { i + 1 });
                }
                else
                {
                    list[a[i]].Add(i + 1);
                }
            }
            for (int i = 0; i < NQ[1]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (!list.ContainsKey(read[0]))
                {
                    Console.WriteLine(-1);
                }
                else if (list[read[0]].Count < read[1])
                {
                    Console.WriteLine(-1);
                }
                else
                {
                    Console.WriteLine(list[read[0]][read[1] - 1]);
                }
            }
        }
        public static void ABC235_Dsub()
        {
            var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int a = read[0];
            int N = read[1];
            int ans = intMax;
            var list = new List<String>();
            dfs("1", 0);
            if (ans == intMax) ans = -1;
            Console.WriteLine(ans);
            void dfs(String now, int cnt)
            {
                if (now == Convert.ToString(N))
                {
                    ans = Math.Min(ans, cnt);
                }
                if (now.Length > Convert.ToString(N).Length) return;
                int nxt = int.Parse(now) * a;
                if (!list.Contains(Convert.ToString(nxt)))
                {
                    list.Add(Convert.ToString(nxt));
                    dfs(Convert.ToString(nxt), cnt + 1);
                }
                else
                {
                    return;
                }
                String nxts = now.Substring(now.Length - 1, 1) + now.Substring(0, now.Length - 1);
                if (!list.Contains(nxts))
                {
                    list.Add(nxts);
                    dfs(nxts, cnt + 1);
                }
                else
                {
                    return;
                }
            }

        }
        public static void ABC235_D()
        {
            var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int a = read[0];
            int N = read[1];
            int ans = intMax;
            int temp = N;
            var list = new List<String>();
            dfs(N, 0);
            if (ans == intMax) ans = -1;
            Console.WriteLine(ans);
            void dfs(int now, int cnt)
            {
                if (now == 1)
                {
                    ans = Math.Min(ans, cnt);
                }
                if (now % a == 0)
                {
                    dfs(now / a, cnt + 1);
                }
                string snow = Convert.ToString(now);
                String nxts = snow.Substring(1, snow.Length - 1) + snow.Substring(0, 1);
                if (!list.Contains(nxts))
                {
                    list.Add(nxts);
                    dfs(int.Parse(nxts), cnt + 1);
                }

            }
        }
        public static void ABC235_E()
        {
            var NMQ = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var edges = new List<(int, int, int, int)>();
            for (int i = 0; i < NMQ[1]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                edges.Add((read[0], read[1], read[2], -1));
            }
            for (int i = 0; i < NMQ[2]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                edges.Add((read[0], read[1], read[2], i));
            }
            edges = edges.OrderBy(x => x.Item3).ToList();
            var uf = new UnionFind<int>(Enumerable.Range(0, NMQ[0] + 1));
            var flag = new bool[NMQ[2]];
            foreach (var e in edges)
            {
                if (e.Item4 == -1)
                {
                    if (!uf.IsSame(e.Item1, e.Item2))
                    {
                        uf.Unite(e.Item1, e.Item2);
                    }
                }
                else
                {
                    if (!uf.IsSame(e.Item1, e.Item2))
                        flag[e.Item4] = true;
                }
            }
            for (int i = 0; i < NMQ[2]; i++)
            {
                if (flag[i])
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
        }
        public static void ABC160_C()
        {
            var KN = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int max = 0;
            for (int i = 0; i < KN[1]; i++)
            {
                if (i == KN[1] - 1)
                {
                    max = Math.Max(max, A[0] + KN[0] - A[KN[1] - 1]);
                }
                else
                {
                    max = Math.Max(max, A[i + 1] - A[i]);
                }
            }
            Console.WriteLine(KN[0] - max);
        }
        /// <summary>
        /// 素数列挙
        /// </summary>
        public static void algorithm_and_math_011()
        {
            int N = int.Parse(Console.ReadLine());
            var prime = new int[N + 1];
            for (int i = 2; i <= N; i++)
            {
                int temp = 1;
                while (temp * i <= N)
                {
                    prime[temp * i]++;
                    temp++;
                }
            }
            var sb = new StringBuilder();
            for (int i = 0; i < N + 1; i++)
            {
                if (prime[i] == 1)
                {
                    sb.Append($"{i} ");
                }
            }
            Console.WriteLine(sb.ToString().Trim());
        }
        public static void algorithm_and_math_013()
        {
            long N = long.Parse(Console.ReadLine());
            var common = new List<long>();
            for (int i = 1; i < Math.Sqrt(N); i++)
            {
                if (N % i == 0)
                {
                    if (!common.Contains(i))
                    {
                        common.Add(i);
                    }
                    if (!common.Contains(N / i))
                    {
                        common.Add(N / i);
                    }
                }
            }
            common.OrderBy(x => x);
            foreach (var p in common)
            {
                Console.WriteLine(p);
            }
        }
        public static void algorithm_and_math_016()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long ans = gcd(A[0], A[1]);
            for (int i = 2; i < N; i++)
            {
                ans = gcd(ans, A[i]);
            }
            Console.WriteLine(ans);
            long gcd(long A, long B)
            {
                while (A >= 1 && B >= 1)
                {
                    if (A < B) B = B % A;
                    else A = A % B;
                }
                if (A >= 1) return A;
                else return B;
            }
        }
        public static void algorithm_and_math_017()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long ans = A[0] * A[1] / gcd(A[0], A[1]);
            for (int i = 2; i < N; i++)
            {
                ans = (ans / gcd(ans, A[i])) * A[i];
            }
            Console.WriteLine(ans);

            long gcd(long A, long B)
            {
                while (A >= 1 && B >= 1)
                {
                    if (A < B) B = B % A;
                    else A = A % B;
                }
                if (A >= 1) return A;
                else return B;
            }
        }
        public static void algorithm_and_math_018()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var item = new int[4];
            for (int i = 0; i < N; i++)
            {
                if (A[i] == 100)
                {
                    item[0]++;
                }
                else if (A[i] == 200)
                {
                    item[1]++;
                }
                else if (A[i] == 300)
                {
                    item[2]++;
                }
                else
                {
                    item[3]++;
                }
            }
            long ans = (long)item[0] * item[3] + (long)item[1] * item[2];
            Console.WriteLine(ans);
        }
        public static void algorithm_and_math_019()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var card = new long[3];
            for (int i = 0; i < N; i++)
            {
                if (A[i] == 1)
                {
                    card[0]++;
                }
                else if (A[i] == 2)
                {
                    card[1]++;
                }
                else
                {
                    card[2]++;
                }
            }
            long ans = (card[0] - 1) * card[0] / 2 + (card[1] - 1) * card[1] / 2 + (card[2] - 1) * card[2] / 2;
            Console.WriteLine(ans);
        }
        public static void algorithm_and_math_020()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long ans = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    for (int k = j + 1; k < N; k++)
                    {
                        for (int l = k + 1; l < N; l++)
                        {
                            for (int m = l + 1; m < N; m++)
                            {
                                if (A[i] + A[j] + A[k] + A[l] + A[m] == 1000)
                                {
                                    ans++;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(ans);
        }
        public static void algorithm_and_math_022()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var cnt = new long[1000000];
            for (int i = 0; i < N; i++)
            {
                cnt[A[i]]++;
            }
            long ans = 0;
            for (int i = 0; i <= 50000; i++)
            {
                if (i != 50000)
                {
                    ans += cnt[i] * cnt[100000 - i];
                }
                else
                {
                    if (cnt[50000] > 0)
                        ans += (cnt[50000] - 1) * cnt[50000] / 2;
                }
            }
            Console.WriteLine(ans);
        }
        public static void ABC161_C()
        {
            var NK = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long ans = NK[0] % NK[1];
            ans = Math.Min(ans, Math.Abs(ans - NK[1]));
            Console.WriteLine(ans);
        }
        public static void algorithm_and_math_027()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var C = new int[N];
            MergeSort(0, N);
            var sb = new StringBuilder();
            for (int i = 0; i < N; i++)
            {
                sb.Append($"{C[i]} ");
            }
            Console.WriteLine(sb.ToString().Trim());
            void MergeSort(int l, int r)
            {
                if (r - l == 1) return;
                int m = (l + r) / 2;
                MergeSort(l, m);
                MergeSort(m, r);

                int c1 = l, c2 = m, cnt = 0;
                while (c1 != m || c2 != r)
                {
                    if (c1 == m)
                    {
                        C[cnt] = A[c2]; c2++;
                    }
                    else if (c2 == r)
                    {
                        C[cnt] = A[c1]; c1++;
                    }
                    else
                    {
                        if (A[c1] < A[c2])
                        {
                            C[cnt] = A[c1]; c1++;
                        }
                        else
                        {
                            C[cnt] = A[c2]; c2++;
                        }
                    }
                    cnt++;
                }

                for (int i = 0; i < cnt; i++)
                {
                    A[l + i] = C[i];
                }
            }
        }
        public static void algorithm_and_math_009()
        {
            var NS = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var dp = new int[NS[0] + 1, NS[1] + 1];
            dp[0, 0] = 1;
            for (int i = 1; i <= NS[0]; i++)
            {
                for (int j = 0; j <= NS[1]; j++)
                {
                    dp[i, j] += dp[i - 1, j];
                    if (j - A[i - 1] >= 0)
                    {
                        dp[i, j] += dp[i - 1, j - A[i - 1]];
                    }
                }
            }
            if (dp[NS[0], NS[1]] > 0)
                Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
        public static void algorithm_and_math_031()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var dp = new long[N + 1, 2];
            dp[0, 0] = 0;
            dp[0, 1] = A[0];
            for (int i = 1; i < N; i++)
            {
                dp[i, 1] += dp[i - 1, 0] + A[i];
                dp[i, 0] += Math.Max(dp[i - 1, 0], dp[i - 1, 1]);
            }
            Console.WriteLine(Math.Max(dp[N - 1, 0], dp[N - 1, 1]));
        }
        public static void ABC168_C()
        {
            var ABHM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            double A = ABHM[0];
            double B = ABHM[1];
            double H = ABHM[2];
            double M = ABHM[3];
            double rad = Math.PI * 2 * ((H / 12) + (M / 60) / 12 - M / 60);
            double rsq = (A * A + B * B) - (2 * A * B * Math.Cos(rad));
            Console.WriteLine(Math.Sqrt(rsq));
        }
        public static void ABC216_E()
        {
            var NK = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long ans = 0;
            Array.Sort(A);
            Array.Reverse(A);
            for (int i = 0; i < NK[0]; i++)
            {
                long dif = 0;
                if (i + 1 < NK[0])
                    dif = A[i] - A[i + 1];
                else dif = A[i];

                long cnt = dif * (i + 1);
                if (cnt <= NK[1])
                {
                    NK[1] -= cnt;
                    ans += (A[i] * 2 + -1 * (dif - 1)) * dif / 2 * (i + 1);
                }
                else
                {
                    long d = NK[1] / (i + 1);
                    long m = NK[1] % (i + 1);
                    ans += (A[i] * 2 + (-1) * (d - 1)) * d / 2 * (i + 1);
                    ans += (A[i] - d) * m;
                    NK[1] = 0;
                }
            }
            Console.WriteLine(ans);
        }
        public static void ABC163_C()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var cnt = new int[N];
            for (int i = 0; i < N - 1; i++)
            {
                cnt[A[i] - 1]++;
            }
            for (int i = 0; i < N - 1; i++)
            {
                Console.WriteLine(cnt[i]);
            }
            Console.WriteLine(0);
        }
        public static void ABC165_D()
        {
            var ABN = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long ans = 0;
            if (ABN[1] > ABN[2])
            {
                ans = (long)Math.Floor((decimal)ABN[0] * (ABN[2]) / ABN[1]) - ABN[0] * (long)Math.Floor(((decimal)ABN[2]) / ABN[1]);
            }
            else
            {
                ans = (long)Math.Floor((decimal)ABN[0] * (ABN[1] - 1) / ABN[1]) - ABN[0] * (long)Math.Floor(((decimal)ABN[1] - 1) / ABN[1]);
            }
            Console.WriteLine(ans);
        }
        public static void ABC164_C()
        {
            int N = int.Parse(Console.ReadLine());
            var list = new Dictionary<String, int>();
            for (int i = 0; i < N; i++)
            {
                var read = Console.ReadLine();
                if (!list.ContainsKey(read))
                {
                    list.Add(read, 1);
                }
            }
            Console.WriteLine(list.Count);
        }
        public static void ABC141_C()
        {
            var NKQ = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var score = Enumerable.Repeat(NKQ[2], (int)NKQ[0]).ToArray();
            for (int i = 0; i < NKQ[2]; i++)
            {
                int idx = int.Parse(Console.ReadLine());
                score[idx - 1]--;
            }
            for (int i = 0; i < NKQ[0]; i++)
            {
                if (NKQ[1] > score[i])
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
        }
        public static void ABC163_D()
        {
            var NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long ans = 0;
            for (int i = NK[1]; i <= NK[0] + 1; i++)
            {
                long min = (i - 1) * (long)i / 2;
                long max = (2 * (long)NK[0] - (i - 1)) * i / 2;
                ans += max - min + 1;
                ans %= 1000000007;
            }
            Console.WriteLine(ans);
        }
        public static void JOI09yosen_B()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var masu = new int[NM[0]];
            for (int i = 0; i < NM[0]; i++)
            {
                masu[i] = int.Parse(Console.ReadLine());
            }
            int cnt = 0;
            int now = 0;
            int idx = 0;
            var result = new int[NM[1]];
            for (int i = 0; i < NM[1]; i++)
            {
                result[i] = int.Parse(Console.ReadLine());
            }
            while (idx < NM[1])
            {
                now += result[idx];
                cnt++;
                if (now >= NM[0] - 1) break;
                now += masu[now];
                if (now >= NM[0] - 1) break;
                idx++;
            }
            Console.WriteLine(cnt);
        }
        public static void JOI10yosen_B()
        {
            String find = Console.ReadLine();
            int N = int.Parse(Console.ReadLine());
            var list = new String[N];
            for (int i = 0; i < N; i++)
            {
                list[i] = Console.ReadLine();
                list[i] += list[i];
            }
            int cnt = 0;
            for (int i = 0; i < N; i++)
            {
                if (list[i].Contains(find))
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }
        public static void JOI11yosen_B()
        {
            int N = int.Parse(Console.ReadLine());
            var result = new (int, int, int)[N];
            for (int i = 0; i < N; i++)
            {
                result[i].Item1 = i;
            }
            for (int i = 0; i < (N - 1) * N / 2; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (read[2] < read[3])
                {
                    result[read[1] - 1].Item2 += 3;
                }
                else if (read[2] == read[3])
                {
                    result[read[0] - 1].Item2++;
                    result[read[1] - 1].Item2++;
                }
                else
                {
                    result[read[0] - 1].Item2 += 3;
                }
            }
            result = result.OrderByDescending(x => x.Item2).ToArray();
            int idx = 1;
            for (int i = 0; i < N; i++)
            {
                result[i].Item3 = idx;
                if (i < N - 1)
                {
                    if (result[i].Item2 != result[i + 1].Item2) idx = i + 2;
                }
            }
            result = result.OrderBy(x => x.Item1).ToArray();
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(result[i].Item3);
            }

        }
        public static void ABC162_C()
        {
            int K = int.Parse(Console.ReadLine());
            long ans = 0;
            for (int i = 1; i <= K; i++)
            {
                for (int j = 1; j <= K; j++)
                {
                    for (int k = 1; k <= K; k++)
                    {
                        ans += gcd(i, gcd(j, k));
                    }
                }
            }
            Console.WriteLine(ans);

            long gcd(long C, long D)
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
        }
        public static void ABC166_D()
        {
            long X = long.Parse(Console.ReadLine());
            for (int i = -1000; i <= 1000; i++)
            {
                for (int j = -1000; j <= 1000; j++)
                {
                    long A = (long)Math.Pow(i, 5);
                    long B = (long)Math.Pow(j, 5);
                    if (A - B == X)
                    {
                        Console.WriteLine($"{i} {j}");
                        return;
                    }
                }
            }
        }
        public static void ABC190_D()
        {
            long N = long.Parse(Console.ReadLine());
            int ans = 0;
            while (N % 2 == 0)
            {
                N /= 2;
            }
            for (int i = 1; i <= Math.Sqrt(N); i++)
            {
                if (N % i == 0) ans += 2;
            }
            if ((long)Math.Sqrt(N) * (long)Math.Sqrt(N) == N) ans--;
            Console.WriteLine(ans * 2);
        }
        public static void ABC173_D()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var q = new Queue<long>();
            long ans = 0;
            Array.Sort(A);
            Array.Reverse(A);
            q.Enqueue(A[0]);
            for (int i = 1; i < N; i++)
            {
                ans += q.Dequeue();
                q.Enqueue(A[i]);
                q.Enqueue(A[i]);
            }
            Console.WriteLine(ans);
        }
        public static void zone2021_D()
        {
            String S = Console.ReadLine();
            StringBuilder rev = new StringBuilder();
            StringBuilder nor = new StringBuilder();
            bool reverse = false;
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == 'R')
                {
                    reverse = !reverse;
                }
                else
                {
                    if (!reverse)
                    {
                        if (nor.Length > 0 && nor[nor.Length - 1] == S[i])
                        {
                            nor = nor.Remove(nor.Length - 1, 1);
                        }
                        else
                        {
                            nor.Append(S[i]);
                        }
                    }
                    else
                    {
                        if (rev.Length > 0 && rev[rev.Length - 1] == S[i])
                        {
                            rev = rev.Remove(rev.Length - 1, 1);
                        }
                        else
                        {
                            rev.Append(S[i]);
                        }
                    }
                }
            }
            String ans = "";
            if (reverse)
            {
                var temp = nor.ToString().ToCharArray();
                Array.Reverse(temp);
                nor.Clear();
                nor = nor.Append(temp);
                int len = Math.Min(nor.Length, rev.Length);
                for (int i = 0; i < len; i++)
                {
                    if (nor[nor.Length - 1] == rev[0])
                    {
                        nor = nor.Remove(nor.Length - 1, 1);
                        rev = rev.Remove(0, 1);
                    }
                }
                ans += nor.ToString() + rev.ToString();
            }
            else
            {
                var temp = rev.ToString().ToCharArray();
                Array.Reverse(temp);
                rev.Clear();
                rev.Append(temp);
                int len = Math.Min(nor.Length, rev.Length);
                for (int i = 0; i < len; i++)
                {
                    if (rev[rev.Length - 1] == nor[0])
                    {
                        rev = rev.Remove(nor.Length - 1, 1);
                        nor = nor.Remove(0, 1);
                    }
                }
                ans += rev.ToString() + nor.ToString();
            }
            Console.WriteLine(ans);
        }
        public static void ARC133_A_sub()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var list = new Dictionary<int, int>();
            for (int i = 0; i < N; i++)
            {
                if (!list.ContainsKey(A[i]))
                {
                    list.Add(A[i], 1);
                }
                else
                {
                    list[A[i]]++;
                }
            }
            list = list.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key).ToDictionary(x => x.Key, y => y.Value);


            var sb = new StringBuilder();
            int temp = list.ElementAt(0).Value;
            var anslist = new List<List<int>>();
            foreach (var l in list)
            {
                if (l.Value != temp) break;
                var templist = new List<int>();
                int id = l.Key;
                for (int i = 0; i < N; i++)
                {
                    if (A[i] != id)
                    {
                        templist.Add(A[i]);
                    }
                }
                if (anslist.Count() > 0)
                    for (int i = 0; i < templist.Count(); i++)
                    {
                        if (templist[i] < anslist[0][i])
                        {
                            anslist.Insert(0, templist);
                            break;
                        }
                        else if (templist[i] != anslist[0][i])
                        {
                            break;
                        }
                    }
                if (anslist.Count() == 0)
                    anslist.Add(templist);
            }
            foreach (var i in anslist[0])
            {
                sb.Append($"{i} ");
            }

            Console.WriteLine(sb.ToString().Trim());
        }
        public static void ARC133_A()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int remId = -1;
            for (int i = 0; i < N; i++)
            {
                if (i < N - 1)
                {
                    if (A[i] > A[i + 1])
                    {
                        remId = A[i];
                        break;
                    }
                }
                else
                {
                    remId = A[i];
                }
            }
            var sb = new StringBuilder();
            for (int i = 0; i < N; i++)
            {
                if (A[i] != remId)
                {
                    sb.Append($"{A[i]} ");
                }
            }
            Console.WriteLine(sb.ToString().Trim());
        }
        public static void ABC218_D()
        {
            int N = int.Parse(Console.ReadLine());
            var point = new List<(int, int)>();
            for (int i = 0; i < N; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                point.Add((read[0], read[1]));
            }
            point = point.OrderBy(x => x.Item1).ThenBy(y => y.Item2).ToList();
            long ans = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (point[i].Item1 < point[j].Item1 && point[i].Item2 < point[j].Item2)
                    {
                        if (point.BinarySearch((point[i].Item1, point[j].Item2)) > 0 && point.BinarySearch((point[j].Item1, point[i].Item2)) > 0)
                        {
                            ans++;
                        }
                    }
                }
            }
            Console.WriteLine(ans);
        }
        public static void ABC205_D()
        {
            var NQ = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var low = new Set<long>();
            low.IsMultiSet = true;
            for (int i = 0; i < NQ[0]; i++)
            {
                low.Add(A[i] - (i + 1));
            }
            for (int i = 0; i < NQ[1]; i++)
            {
                long K = long.Parse(Console.ReadLine());
                int idx = low.LowerBound(K);
                if (idx == NQ[0])
                {
                    Console.WriteLine(A[NQ[0] - 1] + (K - low[NQ[0] - 1]));
                }
                else
                {
                    Console.WriteLine(A[idx] - (low[idx] - K + 1));
                }
            }
        }
        public static void ABC213_D()
        {
            int N = int.Parse(Console.ReadLine());
            var graph = new List<List<int>>();
            for (int i = 0; i < N; i++)
            {
                graph.Add(new List<int>());
            }
            for (int i = 0; i < N - 1; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                graph[read[0] - 1].Add(read[1] - 1);
                graph[read[1] - 1].Add(read[0] - 1);
            }
            var visited = new bool[N];
            var visitedList = new List<int>();
            var from = Enumerable.Repeat(-1, N).ToArray();
            dfs(0, 0, false);
            var sb = new StringBuilder();
            foreach (var i in visitedList)
            {
                sb.Append($"{i + 1} ");
            }
            Console.WriteLine(sb.ToString().Trim());
            void dfs(int now, int pre, bool rev)
            {
                visited[now] = true;
                visitedList.Add(now);
                if (!rev)
                    from[now] = pre;
                var flag = false;
                foreach (var v in graph[now])
                {
                    if (!visited[v])
                    {
                        flag = true;
                        dfs(v, now, false);
                    }
                }
                if (!flag && now != 0)
                {
                    dfs(from[now], now, true);
                }
                else
                {
                    return;
                }
                return;
            }
        }
        public static void ABC236_A()
        {
            String S = Console.ReadLine();
            var ab = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var ans = S.ToCharArray();
            ans[ab[0] - 1] = S[ab[1] - 1];
            ans[ab[1] - 1] = S[ab[0] - 1];
            Console.WriteLine(new String(ans));
        }
        public static void ABC236_B()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var cnt = new int[N];
            for (int i = 0; i < 4 * N - 1; i++)
            {
                cnt[A[i] - 1]++;
            }
            for (int i = 0; i < N; i++)
            {
                if (cnt[i] != 4)
                {
                    Console.WriteLine(i + 1);
                    return;
                }
            }
        }
        public static void ABC236_C()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var S = Console.ReadLine().Split().ToList();
            var T = Console.ReadLine().Split().ToList();
            T = T.OrderBy(x => x).ToList();
            for (int i = 0; i < NM[0]; i++)
            {
                if (T.BinarySearch(S[i]) >= 0)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }

        }
        public static void ABC236_Dsub()
        {
            int N = int.Parse(Console.ReadLine());
            var A = new long[2 * N][];
            long ans = 0;
            var p = Enumerable.Range(0, N).ToArray();
            for (int i = 0; i < 2 * N - 1; i++)
            {
                A[i] = Console.ReadLine().Split().Select(long.Parse).ToArray();
            }
            int cnt = 0;
            for (int i = 0; i < (1 << 2 * N); i++)
            {
                var flag = new bool[2 * N];
                for (int j = 0; j < 2 * N; j++)
                {
                    if ((i & (1 << j)) != 0)
                    {
                        flag[j] = true;
                    }
                }
                var one = new List<long>();
                var two = new List<long>();
                for (int j = 0; j < 2 * N; j++)
                {
                    if (flag[j]) one.Add(j);
                    else two.Add(j);
                }
                if (one.Count != N) continue;
                cnt++;
                if (cnt > 1 << N) break;

                long temp = 0;
                do
                {
                    if (one[0] < two[p[0]])
                        temp = A[one[0]][two[p[0]] - one[0] - 1];
                    else temp = A[two[p[0]]][one[0] - two[p[0]] - 1];
                    for (int j = 1; j < N; j++)
                    {
                        if (one[j] < two[p[j]])
                            temp = temp ^ A[one[j]][two[p[j]] - one[j] - 1];
                        else temp = temp ^ A[two[p[j]]][one[j] - two[p[j]] - 1];
                    }
                    ans = Math.Max(ans, temp);
                } while (NextPermutation.Next_Permutation(p));
            }
            Console.WriteLine(ans);
        }
        public static void ABC236_D()
        {
            int N = int.Parse(Console.ReadLine());
            var A = new long[2 * N][];
            long ans = 0;
            var selected = new bool[2 * N];
            for (int i = 0; i < 2 * N - 1; i++)
            {
                A[i] = Console.ReadLine().Split().Select(long.Parse).ToArray();
            }
            dfs(0, 0);
            Console.WriteLine(ans);
            void dfs(int cnt, long score)
            {
                if (cnt == N)
                {
                    ans = Math.Max(ans, score);
                    return;
                }
                int last = 0;
                for (int j = 2 * N - 1; j >= 0; j--)
                {
                    if (!selected[j])
                    {
                        last = j;
                        break;
                    }
                }
                selected[last] = true;
                for (int j = 0; j < 2 * N; j++)
                {
                    if (!selected[j])
                    {
                        selected[j] = true;
                        dfs(cnt + 1, score ^ A[j][last - j - 1]);
                        selected[j] = false;
                    }
                }
                selected[last] = false;
            }
        }
        public static void ABC236_E()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var adp = new long[N, 2];

        }
        public static void ABC169_D()
        {
            long N = long.Parse(Console.ReadLine());
            long ans = 0;
            var kaisa = new int[36];
            kaisa[0] = 1;
            for (int i = 1; i < 36; i++)
            {
                kaisa[i] = kaisa[i - 1] + i + 1;
            }
            for (int i = 2; i <= Math.Sqrt(N); i++)
            {
                int idx = 0;
                int cnt = 0;
                while (N % i == 0)
                {
                    cnt++;
                    if (cnt >= kaisa[idx])
                    {
                        ans++;
                        idx++;
                    }
                    N = N / i;
                }
            }
            if (N > 1) ans++;
            Console.WriteLine(ans);
        }
        public static void ABC167_C()
        {
            var NMX = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = NMX[0];
            int M = NMX[1];
            int X = NMX[2];
            var A = new int[N, M];
            var C = new int[N];
            for (int i = 0; i < N; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                C[i] = read[0];
                for (int j = 0; j < M; j++)
                {
                    A[i, j] = read[j + 1];
                }
            }
            int ans = intMax;
            for (int i = 0; i < (1 << N); i++)
            {
                var flag = new bool[N];
                for (int j = 0; j < N; j++)
                {
                    if ((i & (1 << j)) != 0) flag[j] = true;
                }
                var master = new int[M];
                int temp = 0;
                for (int j = 0; j < N; j++)
                {
                    if (flag[j])
                    {
                        temp += C[j];
                        for (int k = 0; k < M; k++)
                        {
                            master[k] += A[j, k];
                        }
                    }
                }
                var ok = true;
                for (int j = 0; j < M; j++)
                {
                    if (master[j] < X)
                    {
                        ok = false;
                    }
                }
                if (ok) ans = Math.Min(ans, temp);
            }
            if (ans == intMax) ans = -1;
            Console.WriteLine(ans);
        }
        public static void ABC126_E()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var num = new (int, int, int)[NM[1]];
            var graph = new List<List<int>>();
            for (int i = 0; i < NM[0]; i++)
            {
                graph.Add(new List<int>());
            }
            for (int i = 0; i < NM[1]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                num[i] = (read[0], read[1], read[2]);
                graph[num[i].Item1 - 1].Add(num[i].Item2 - 1);
                graph[num[i].Item2 - 1].Add(num[i].Item1 - 1);
            }
            var visited = new bool[NM[0]];
            int ans = 0;
            for (int i = 0; i < NM[0]; i++)
            {
                if (!visited[i])
                {
                    ans++;
                    dfs(i);
                }
            }
            Console.WriteLine(ans);
            void dfs(int now)
            {
                visited[now] = true;
                foreach (var v in graph[now])
                {
                    if (!visited[v])
                    {
                        dfs(v);
                    }
                }
                return;
            }
        }
        public static void ABC127_E()
        {
            var NMK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = NMK[0];
            int M = NMK[1];
            int K = NMK[2];
            long mod = 1000000007;
            long ans = 0;
            var comb = new Comb(N * M);
            for (int d = 1; d <= N - 1; d++)
            {
                long one = comb.nCk(N * M - 2, K - 2);
                one %= mod;
                long two = (N - d) * M;
                two %= mod;
                two *= M;
                two %= mod;
                long temp = one * two;
                temp %= mod;
                temp *= d;
                temp %= mod;
                ans += temp;
                ans %= mod;
            }
            for (int d = 1; d <= M - 1; d++)
            {
                long one = comb.nCk(N * M - 2, K - 2);
                one %= mod;
                long two = (M - d) * N;
                two %= mod;
                two *= N;
                two %= mod;
                long temp = one * two;
                temp %= mod;
                temp *= d;
                temp %= mod;
                ans += temp;
                ans %= mod;
            }
            Console.WriteLine(ans);
        }
        public static void ABC177_D()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var uf = new UnionFind<int>(Enumerable.Range(0, NM[0]));
            for (int i = 0; i < NM[1]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (!uf.IsSame(read[0] - 1, read[1] - 1))
                {
                    uf.Unite(read[0] - 1, read[1] - 1);
                }
            }
            int ans = 0;
            for (int i = 0; i < NM[0]; i++)
            {
                ans = (int)Math.Max(ans, uf.Size(i));
            }
            Console.WriteLine(ans);
        }
        public static void ARC106_B()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var a = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var b = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var graph = new List<List<int>>();
            for (int i = 0; i < NM[0]; i++)
            {
                graph.Add(new List<int>());
            }
            for (int i = 0; i < NM[1]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                graph[read[0] - 1].Add(read[1] - 1);
                graph[read[1] - 1].Add(read[0] - 1);
            }
            var ok = true;
            var visited = new bool[NM[0]];
            for (int i = 0; i < NM[0]; i++)
            {
                if (!visited[i])
                {
                    dfs(i, 0);
                }
            }
            if (ok) Console.WriteLine("Yes");
            else Console.WriteLine("No");

            void dfs(int now, long sum)
            {
                var s = new Stack<int>();
                s.Push(now);
                visited[now] = true;
                while (s.Count() > 0)
                {
                    int nxt = s.Pop();
                    sum += a[nxt] - b[nxt];
                    foreach (var v in graph[nxt])
                    {
                        if (!visited[v])
                        {
                            visited[v] = true;
                            s.Push(v);
                        }
                    }
                }
                if (sum != 0) ok = false;
            }
        }
        public static void ARC129_A()
        {
            var NLR = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long N = NLR[0];
            long L = NLR[1];
            long R = NLR[2];
            int k = 0;
            long ans = 0;
            while (N > 0)
            {
                if (N % 2 == 1)
                {
                    if ((long)Math.Min(R, pow(2, k + 1) - 1) >= (long)Math.Max(L, pow(2, k)))
                        ans += (long)Math.Min(R, pow(2, k + 1) - 1) - (long)Math.Max(L, pow(2, k)) + 1;
                }
                k++;
                N /= 2;
            }
            Console.WriteLine(ans);
            long pow(long x, int n)
            {
                long ret = 1;
                while (n > 0)
                {
                    if ((n & 1) > 0) ret *= x;
                    x *= x;
                    n = n >> 1;
                }
                return ret;
            }
        }
        public static void ARC129_B()
        {
            int N = int.Parse(Console.ReadLine());
            long l = 0;
            long r = 0;
            for (int i = 0; i < N; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i == 0)
                {
                    l = read[0];
                    r = read[1];
                    Console.WriteLine(0);
                }
                else
                {
                    long ans = 0;
                    r = Math.Min(r, read[1]);
                    l = Math.Max(l, read[0]);
                    if (l > r)
                    {
                        ans = (long)Math.Ceiling(((decimal)l - r) / 2);
                    }
                    Console.WriteLine(ans);
                }
            }
        }
        public static void ARC107_B()
        {
            var NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var num = new long[2 * NK[0] + 1];
            for (int i = 1; i < num.Length; i++)
            {
                if (i % 2 == 0)
                {
                    num[i] = (i / 2 - 1) * 2;
                    if (i - 1 > NK[0])
                        num[i] -= ((i - 1) - NK[0]) * 2;
                    num[i]++;
                }
                else
                {
                    num[i] = (i / 2) * 2;
                    if (i - 1 > NK[0])
                        num[i] -= ((i - 1) - NK[0]) * 2;
                }
            }
            long ans = 0;
            for (int i = 1; i < num.Length; i++)
            {
                if (NK[1] >= 0)
                {
                    if (NK[1] + i > 2 * NK[1]) continue;
                    ans += num[i] * (num[NK[1] + i]);
                }
                else
                {
                    if (-NK[1] + i > 2 * NK[0]) continue;
                    ans += num[i] * (num[-NK[i] + i]);
                }

            }
            Console.WriteLine(ans);
        }
        public static void AGC022_A()
        {
            String S = Console.ReadLine();
            var list = new bool[26];
            var changed = false;
            for (int i = 0; i < S.Length; i++)
            {
                list[S[i] - 'a'] = true;
            }
            String ans = S;
            if (S.Length < 26)
            {
                for (int i = 0; i < 26; i++)
                {
                    if (!list[i])
                    {
                        ans += (char)(i + 'a');
                        changed = true;
                        break;
                    }
                }
            }
            else
            {
                var used = new bool[26];
                for (int i = S.Length - 1; i >= 0; i--)
                {
                    int temp = S[i] - 'a';
                    used[temp] = true;
                    for (int j = temp + 1; j < 26; j++)
                    {
                        if (used[j])
                        {
                            ans = S.Substring(0, i) + (char)(j + 'a');
                            changed = true;
                            break;
                        }
                    }
                    if (changed) break;
                }
            }
            if (!changed) Console.WriteLine(-1);
            else Console.WriteLine(ans);
        }
        public static void ABC191_C()
        {
            var HW = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var fields = new char[HW[0]][];
            for (int i = 0; i < HW[0]; i++)
            {
                fields[i] = Console.ReadLine().ToCharArray();
            }
            int cnt = 0;
            var move = new (int, int)[4] { (0, 0), (1, 1), (1, 0), (0, 1) };
            for (int i = 0; i < HW[0] - 1; i++)
            {
                for (int j = 0; j < HW[1] - 1; j++)
                {
                    var temp = 0;
                    foreach (var v in move)
                    {
                        if (fields[i + v.Item1][j + v.Item2] == '#')
                        {
                            temp++;
                        }
                    }
                    if (temp == 1 || temp == 3)
                    {
                        cnt++;
                    }
                }
            }
            Console.WriteLine(cnt);
        }
        public static void ABC166_E()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var cnt = new Dictionary<long, long>();
            long ans = 0;
            for (int i = 0; i < N; i++)
            {
                if (cnt.ContainsKey(i - A[i]))
                    ans += cnt[i - A[i]];
                if (!cnt.ContainsKey(A[i] + i))
                {
                    cnt.Add(A[i] + i, 1);
                }
                else
                {
                    cnt[A[i] + i]++;
                }
            }
            Console.WriteLine(ans);
        }
        public static void ABC237_E()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var H = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var dijkstra = new Dijkstra(NM[0] + 1);
            for (int i = 0; i < NM[1]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                read[1]--;
                read[0]--;
                if (H[read[0]] < H[read[1]])
                {
                    int temp = read[0];
                    read[0] = read[1];
                    read[1] = temp;
                }
                dijkstra.Add(read[0], read[1], 0);
                dijkstra.Add(read[1], read[0], H[read[0]] - H[read[1]]);
            }
            var distance = dijkstra.GetMinCost(0);
            long ans = 0;
            for (int i = 0; i < NM[0]; i++)
            {
                ans = Math.Max(ans, -(H[i] + distance[i] - H[0]));
            }
            Console.WriteLine(ans);
        }
        public static void ABC134_E()
        {
            int N = int.Parse(Console.ReadLine());
            var A = new int[N];
            var set = new Set<int>();
            set.IsMultiSet = true;
            int ans = 0;
            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
                int idx = set.LowerBound(A[i]);
                if (set.Count == 0 || idx == 0)
                {
                    ans++;
                    set.Add(A[i]);
                }
                else
                {
                    set.RemoveAt(idx - 1);
                    set.Add(A[i]);
                }
            }
            Console.WriteLine(ans);
        }
        public static void ABC142_C()
        {
            int N = int.Parse(Console.ReadLine());
            var list = new (int, int)[N];
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < N; i++)
            {
                list[i] = (A[i], i + 1);
            }
            list = list.OrderBy(x => x.Item1).ToArray();
            var sb = new StringBuilder();
            for (int i = 0; i < N; i++)
            {
                sb.Append($"{list[i].Item2} ");
            }
            Console.WriteLine(sb.ToString().Trim());
        }
        public static void ABC128_E()
        {
            var NQ = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var koji = new List<(long, long, long)>();
            var D = new long[NQ[1]];
            for (int i = 0; i < NQ[0]; i++)
            {
                var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
                koji.Add((read[0] - read[2], 1, read[2]));
                koji.Add((read[1] - read[2], -1, read[2]));
            }
            for (int i = 0; i < NQ[1]; i++)
            {
                D[i] = long.Parse(Console.ReadLine());
            }
            koji = koji.OrderBy(x => x.Item1).ToList();
            var stop = new Set<long>();
            int idx = 0;
            for (int i = 0; i < NQ[1]; i++)
            {
                while (idx < koji.Count)
                {
                    var now = koji[idx];
                    if (D[i] < now.Item1) break;
                    if (now.Item2 == 1) stop.Add(now.Item3);
                    else stop.Remove(now.Item3);
                    idx++;
                }
                if (stop.Count > 0)
                {
                    Console.WriteLine(stop[0]);
                }
                else
                {
                    Console.WriteLine(-1);
                }
            }
        }
        public static void ABC176_D()
        {
            var HW = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var C = Console.ReadLine().Split().Select(int.Parse).ToArray();
            C[0]--;
            C[1]--;
            var D = Console.ReadLine().Split().Select(int.Parse).ToArray();
            D[0]--;
            D[1]--;
            var S = new char[HW[0]][];
            for (int i = 0; i < HW[0]; i++)
            {
                S[i] = Console.ReadLine().ToCharArray();
            }
            var move = new (int, int)[4] { (-1, 0), (1, 0), (0, 1), (0, -1) };
            var visited = new bool[HW[0], HW[1]];
            var searched = new bool[HW[0], HW[1]];
            var warp = new List<(int, int)>();
            int ans = intMax;
            var q = new Queue<(int, int, int)>();
            var warpq = new Queue<(int, int, int)>();
            q.Enqueue((C[0], C[1], 0));
            dfs();
            if (visited[D[0], D[1]]) Console.WriteLine(ans);
            else Console.WriteLine(-1);
            void dfs()
            {
                while (q.Count() > 0)
                {
                    var now = q.Dequeue();
                    int y = now.Item1;
                    int x = now.Item2;
                    if (!visited[y, x])
                        visited[y, x] = true;
                    else continue;
                    if (y == D[0] && x == D[1])
                    {
                        ans = Math.Min(ans, now.Item3);
                        return;
                    }
                    foreach (var n in move)
                    {
                        int ny = y + n.Item1;
                        int nx = x + n.Item2;
                        if (ny >= 0 && ny < HW[0] && nx >= 0 && nx < HW[1] && !visited[ny, nx] && S[ny][nx] == '.')
                        {
                            searched[ny, nx] = true;
                            q.Enqueue((ny, nx, now.Item3));
                        }
                    }
                    for (int i = -2; i < 3; i++)
                    {
                        for (int j = -2; j < 3; j++)
                        {
                            int wy = y + i;
                            int wx = x + j;
                            if (wy >= 0 && wy < HW[0] && wx >= 0 && wx < HW[1] && !visited[wy, wx] && !searched[wy, wx] && S[wy][wx] == '.')
                            {
                                warpq.Enqueue((wy, wx, now.Item3));
                                searched[wy, wx] = true;
                            }
                        }
                    }
                }
                while (warpq.Count() > 0)
                {
                    var wp = warpq.Dequeue();
                    if (!visited[wp.Item1, wp.Item2])
                    {
                        q.Enqueue((wp.Item1, wp.Item2, wp.Item3 + 1));
                    }
                }
                if (q.Count > 0) dfs();
            }
        }

    }
}

