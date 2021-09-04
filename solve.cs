using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using static CompLib.CompLib;
using DataStructure;

namespace atcoder
{
    class Solve
    {
        const int intMax = 1000000000;
        const long longMax = 2000000000000000000;
        public static void ABC144_B()
        {
            int N = int.Parse(Console.ReadLine());
            bool flag = false;
            for(int i = 1; i < 10; i++)
            {
                if(N % i == 0 && N / i < 10)
                {
                    flag = true;
                }
            }
            if(flag == true)
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
            for(int i = 0; i < charS.Length; i++)
            {
                if(charS[i] == 'A' && i < charS.Length - 2)
                {
                    if(charS[i + 1] == 'B' && charS[i + 2] == 'C')
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
            for(int i = 0; i < charS.Length; i++)
            {
                if(charS[i] == 'A' || charS[i] == 'T' || charS[i] == 'C' || charS[i] == 'G' )
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
            for(int i = 1; i <= N; i++)
            {
                char[] num = Convert.ToString(i).ToCharArray();
                if(num.Length % 2 == 1)
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
            for(int i = 1; i <= N; i += 2)
            {
                int temp = 0;
                for(int j = 1; j <= i; j++)
                {
                    if(i % j == 0)
                    {
                        temp++;
                    }
                }
                if(temp == 8)
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
            for(int i = 1; i <= Math.Min(A, B); i++)
            {
                if(A % i == 0 && B % i == 0)
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
            for(long i = 1; i <= Math.Sqrt(N); i++)
            {
                int temp = 100;
                if(N % i == 0)
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
            if(C < (A + B) / 2)
            {
                int numC = Math.Min(X, Y) * 2;
                sum += numC * C;
                if(X > Y)
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
                sum =Math.Min(A * X + B * Y, Math.Max(X, Y) * 2 * C);
            }
            Console.WriteLine(sum);
        }
        public static void MSB2019_D()
        {
            int N = int.Parse(Console.ReadLine());
            char[] charS = Console.ReadLine().ToCharArray();
            int[] intS = new int[N];
            for(int i = 0; i < N; i++)
            {
                intS[i] = Convert.ToInt32(charS[i]);
            }
            int count = 0;
            for(int i = 0; i < 10; i++)
            {
                int indexI = Array.IndexOf(intS,i + 48);
                if(indexI == -1)
                {
                    continue;
                }
                for(int j = 0; j < 10; j++)
                {
                    int indexJ = Array.IndexOf(intS, j + 48, indexI + 1);
                    if(indexJ == -1)
                    {
                        continue;
                    }
                    for(int k = 0; k < 10; k++)
                    {
                        int indexK = Array.IndexOf(intS, k + 48, indexJ + 1);
                        if(indexK >= 0)
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
            for(int i = 0; i < M; i++)
            {
                String[] read2 = Console.ReadLine().Split();
                s.Add(new List<int>());
                for(int j = 1; j <= int.Parse(read2[0]); j++)
                {
                    s[i].Add(int.Parse(read2[j]));
                }
            }
            List<int> p = new List<int>();
            String[] read3 = Console.ReadLine().Split();
            for(int i = 0; i < M; i++)
            {
                p.Add(int.Parse(read3[i]));
            }
            for(int i = 0; i < Math.Pow(2, N); i++)
            {
                bool[] switches = new bool[N];
                bool[] lights = new bool[M];
                for(int j = 0; j < N; j++)
                {
                    switches[j] = ((i >> j) & 1) == 1;
                }
                for(int j = 0; j < M; j++)
                {
                    int count = 0;
                    for(int k = 0; k < s[j].Count; k++)
                    {
                        if(switches[s[j][k] - 1] == true)
                        {
                            count++;
                        } 
                    }
                    if(count % 2 == p[j])
                    {
                        lights[j] = true;
                    }
                }
                for(int j = 0; j < lights.Length; j++)
                {
                    if(lights[j] == false)
                    {
                        break;
                    }
                    else if(j == lights.Length - 1)
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

            for(int i = 0; i < N; i++)
            {
                int tempN = int.Parse(Console.ReadLine());
                data[i] = new Tuple<int, int>[tempN];
                for(int j = 0; j < tempN; j++)
                {  
                    var read = Console.ReadLine().Split();
                    data[i][j] = Tuple.Create(int.Parse(read[0]), int.Parse(read[1]));
                }
            }
            int ans = 0;
            for(int i = 1; i < (1 << N); i++ )
            {
                bool[] katei = new bool[N];
                for(int j = 0; j < N; j++)
                {
                    katei[j] = ((i >> j) & 1) == 1;
                }
                bool flag = true;
                for(int j = 0; j < N; j++)
                {
                    if(katei[j])
                    {
                        for(int k = 0; k < data[j].Length; k++)
                        {
                            int temp = data[j][k].Item1 - 1;
                            if(katei[temp] != (data[j][k].Item2 == 1))
                            {
                                flag = false;
                            }
                            
                        }
                    }
                }
                if(flag)
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
            for(int i = 0; i < N; i++)
            {
                var read = Console.ReadLine().Split();
                point[i] = Tuple.Create(int.Parse(read[0]), int.Parse(read[1]));
            }
            var allpattern = next_permutation(Enumerable.Range(1,N)).ToArray();
            for(int i = 0; i < allpattern.Length; i++)
            {
                for(int j = 0; j < N - 1; j++)
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
            var allpattern = next_permutation(Enumerable.Range(1, N)).ToArray();
            int countA = 0;
            int countB = 0;
            int count= 0;
            for(int i = 0; i < allpattern.Length; i++)
            {
                count++;
                bool aflag = true;
                bool bflag = true;
                for(int j = 0; j < N; j++)
                {
                    if(int.Parse(a[j]) != allpattern[i][j])
                    {
                        aflag = false;
                    }
                    if(int.Parse(b[j]) != allpattern[i][j])
                    {
                        bflag = false;
                    }
                }
                if(aflag)
                {
                    countA = count;
                }
                if(bflag)
                {
                    countB = count;
                }
            }
            Console.WriteLine(Math.Abs(countA - countB));
        }
        public static  void ABC054_C()
        {
            var read = Console.ReadLine().Split();
            int N = int.Parse(read[0]);
            int M = int.Parse(read[1]);
            var edge = new bool[N][];
            for(int i = 0; i < N; i++)
            {
                edge[i] = new bool[N];
            }
            int count = 0;
            for(int i = 0; i < M; i++)
            {
                var query = Console.ReadLine().Split();
                edge[int.Parse(query[0]) - 1][int.Parse(query[1]) - 1] = true;
                edge[int.Parse(query[1]) - 1][int.Parse(query[0]) - 1] = true;
            }
            var allpattern = next_permutation(Enumerable.Range(1, N)).ToArray();
            for(int i = 0; i < allpattern.Length; i++)
            {
                if(allpattern[i][0] != 1)
                {
                    break;
                }
                bool flag = true;
                for(int j = 0; j < N - 1; j++)
                {
                    if(!edge[allpattern[i][j] - 1][allpattern[i][j + 1] - 1])
                    {
                        flag = false;
                    }
                }
                if(flag)
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
            for(int i = 1; i <= N; i++)
            {
                for(int j = 0; j < N - (i-1); j++)
                {
                    long tempMax = cumlativesum.GetSum(j, j + i);
                    max[i-1] = Math.Max(max[i-1], tempMax);
                }
            }
            for(int i = 0; i < N; i++)
            {
                Console.WriteLine(max[i]);
            }
        }
        public static void JOI2009_1()
        {
            var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var yado = new int[read[0] - 1];
            var move = new int[read[1]];
            
            for(int i = 0; i < read[0] - 1; i++)
            {
                yado[i] = int.Parse(Console.ReadLine());
            }
            var cumYado = new CumulativeSum(yado);
            for(int i = 0; i < read[1]; i++)
            {
                move[i] = int.Parse(Console.ReadLine());
            }
            long sum = 0;
            int now = 1;
            for(int i = 0; i < read[1]; i++)
            {
                if(move[i] < 0) sum += cumYado.GetSum((now - 1) + move[i], (now - 1));
                else sum += cumYado.GetSum((now - 1),(now - 1) + move[i]);
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
            for(int i = 1; i < read[0] + 1; i++)
            {
                var read2 = Console.ReadLine().ToCharArray();
                fields[i] = new char[read[1] + 1];
                cumsJ[i] = new int[read[1] + 1];
                cumsO[i] = new int[read[1] + 1];
                cumsI[i] = new int[read[1] + 1];
                for(int j = 1; j < read[1] + 1; j++)
                {
                    fields[i][j] = read2[j - 1];
                    if(fields[i][j] == 'J')
                    {
                        cumsJ[i][j] = cumsJ[i - 1][j] + cumsJ[i][j - 1] - cumsJ[i - 1][j - 1] + 1;
                        cumsO[i][j] = cumsO[i - 1][j] + cumsO[i][j - 1] - cumsO[i - 1][j - 1];
                        cumsI[i][j] = cumsI[i - 1][j] + cumsI[i][j - 1] - cumsI[i - 1][j - 1];

                    }
                    else if(fields[i][j] == 'O')
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
            for(int i = 0; i < N; i++)
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
             for(int i = 0; i < count.Length; i++)
             {
                 count[i] = new int[nmq[0]];
             }
            for(int i = 0; i < nmq[1]; i++)
            {
                var lr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                count[lr[0] - 1][lr[1] - 1]++;
            }
             for(int l = 0; l < nmq[0]; l++)
                {
                    for(int r = l + 1; r < nmq[0]; r++)
                    {
                        count[l][r] += count[l][r-1];
                    }
                }
            for(int i = 0; i < nmq[2]; i++)
            {
                var pq = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int ans = 0;
                for(int l = pq[0] - 1; l < pq[1]; l++)
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
            for(int i = 1; i <= read[0]; i++)
            {
                fields[i] = new long[read[1] + 1];
                cumsFields[i] = new long[read[1] + 1];
                var totikakaku = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for(int j = 1; j <= read[1]; j++)
                {
                    fields[i][j] = totikakaku[j - 1];
                    cumsFields[i][j] = cumsFields[i - 1][j] + cumsFields[i][j - 1] - cumsFields[i-1][j-1] + fields[i][j];
                }
            }
            int ans = 0;
            for(int a = 1; a <= read[0]; a++)
            {
                for(int b = 1; b <= read[1]; b++)
                {
                    for(int c = a; c <= read[0]; c++)
                    {
                        for(int d = b; d <= read[1]; d++)
                        {
                            long tatemono = (c - a + 1) * (d - b + 1) * read[2];
                            long toti = cumsFields[c][d] - cumsFields[c][b - 1] - cumsFields[a - 1][d] + cumsFields[a - 1][b - 1];
                            int area = (c - a + 1) * (d - b + 1);
                            if(tatemono + toti > read[3])
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
            
            for(int i = 0; i < n; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                color[read[0]]++;
                color[read[1] + 1]--;
            }
            int max = color[0];
            for(int i = 1; i < 1000002; i++)
            {
                color[i] += color[i-1];
                max = Math.Max(max, color[i]);
            }
            Console.WriteLine(max);
        }
        public static void ABC075_C()
        {
            var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var edge = new List<Tuple<int, int>>();
            var v = Enumerable.Range(1,read[0]);
            var dfs = new DepthFirstSearch<int>(v);
            for(int i = 0; i < read[1]; i++)
            {
                var ab = Console.ReadLine().Split().Select(int.Parse).ToArray();
                edge.Add(Tuple.Create(ab[0], ab[1]));
                dfs.Add(ab[0], ab[1]);
                dfs.Add(ab[1], ab[0]);

            }
            int count = 0;
            for(int i = 0; i < edge.Count; i++)
            {
                dfs.Remove(edge[i].Item1,edge[i].Item2);   
                dfs.Remove(edge[i].Item2,edge[i].Item1);
                if(!dfs.IsExist(edge[i].Item1,edge[i].Item2)) count++;   
                dfs.Add(edge[i].Item1,edge[i].Item2);   
                dfs.Add(edge[i].Item2,edge[i].Item1);
            }
            Console.WriteLine(count);
        }
        public static void ABC120_D()
        {
            var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var bridge = new Tuple<int, int>[read[1]];
            for(int i = 0; i < read[1]; i++)
            {
                var ab = Console.ReadLine().Split().Select(int.Parse).ToArray();
                bridge[i] = Tuple.Create(ab[0], ab[1]);
            }
            var count = new long[read[1]];
            var v = Enumerable.Range(1, read[0]);
            var uf = new UnionFind<int>(v);
            count[bridge.Length - 1] = ((long)read[0] * (read[0] - 1)) / 2;
            for(int i = bridge.Length - 1; i >= 1; i--)
            {
                if(uf.IsSame(bridge[i].Item1, bridge[i].Item2))
                {
                    count[i - 1] = count[i];
                }
                else
                {
                    count[i - 1] = count[i] - (long)uf.Size(bridge[i].Item1) * (long)uf.Size(bridge[i].Item2);
                    uf.Unite(bridge[i].Item1, bridge[i].Item2);
                }
            }
            for(int i = 0; i < count.Length; i++)
            {
                Console.WriteLine(count[i]);
            }
        }
        public static void JOI7_F()
        {
            var nk = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var dijkstra = new Dijkstra(nk[0]);
            for(int i = 0; i < nk[1]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if(read[0] == 1)
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
            var dp = new long[2100,2100];
            for(int i = 0; i < 2100; i++)
            {
                for(int j  = 0; j < 2100; j++)
                {
                    dp[i, j] = -1;
                }
            }
            for(int i = 0; i < n; i++)
            {
                cut[i] = int.Parse(Console.ReadLine());
            }
            long ans = 0;
            for(int i = 0; i < n; i++)
            {
                ans = Math.Max(ans, JOI14B_B_memo((i + 1) % n, (i + n - 1) % n, dp, cut, 1) + cut[i]);
            }
            Console.WriteLine(ans);
        }
        public static long JOI14B_B_memo(int l, int r, long[,] dp,int[] cut, int s)
        {
            if(dp[l, r] != -1) return dp[l, r];
            if(l == r)
            {
                if(s == 1) return dp[l, r] = 0;
                else return dp[l, r] = cut[l];
            }
            if(s == 1)
            {
                if(cut[l] > cut[r])
                {
                    return dp[l,r] = JOI14B_B_memo((l + 1)%cut.Length, r, dp, cut, 0);
                }
                else
                {
                    return dp[l,r] = JOI14B_B_memo(l, (r + cut.Length - 1) % cut.Length, dp, cut, 0);
                }
            }
            else
            {
                return dp[l, r] = Math.Max(JOI14B_B_memo((l + 1)%cut.Length, r, dp, cut, 1) + cut[l], JOI14B_B_memo(l, (r + cut.Length - 1) % cut.Length, dp, cut, 1) + cut[r]);
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
        for(int i = 0; i < distance.GetLength(0); i++)
        {
            for(int j = 0; j < distance.GetLength(1); j++)
            {
                distance[i, j] = (longMax,0);
            }
        }
        for(int i = 0; i < read[1]; i++)
        {
            var readD = Console.ReadLine().Split();
            distance[int.Parse(readD[0]) - 1, int.Parse(readD[1]) -1] = (long.Parse(readD[2]), long.Parse(readD[3]));
            distance[int.Parse(readD[1]) - 1, int.Parse(readD[0]) -1] = (long.Parse(readD[2]), long.Parse(readD[3]));
        }
        var dp = new (long cost, long count)[1 << 17, 17];
        var res = sales(dp, distance, (1 << read[0]) - 1, 0);
        Console.WriteLine(res.Item1 == longMax ? "IMPOSSIBLE" : $"{res.Item1} {res.Item2}");
    }
    public static (long, long) sales((long, long)[,] dp,(long,long)[,] distance, int bit, int v)
    {
        if(bit == 0)
        {
            if(v == 0)
            {
                return (0, 1);
            }
            else
            {
                return(longMax, 0);
            }
        }
        if((bit & (1 << v)) == 0)
        {
            return (longMax, 0);
        }
        //すでに訪れていた場合そのまま値を返す
        if(dp[bit, v].Item1 != 0) return dp[bit, v];
        (long, long) res = (longMax, 0);
        for(int u = 0; u < distance.GetLength(0); u++)
        {
            (long, long) temp = sales(dp, distance, bit^(1 << v), u);
            temp.Item1 += distance[u, v].Item1;
            if(temp.Item1 <= distance[u, v].Item2)
            {
                if(res.Item1 > temp.Item1)
                {
                    res = temp;
                }
                else if(res.Item1 == temp.Item1)
                {
                    res.Item2 += temp.Item2;
                }
            }
        }
            return  dp[bit, v] = res;
    }
    public static void JOI13_D()
    {
        int n = int.Parse(Console.ReadLine());
        var read = Console.ReadLine().ToCharArray();
        var dp = new long[1 << 3, 1100];
        var resp = new int[1100];
        for(int i = 0; i < n; i++)
        {
            if(read[i] == 'J')
            {
                resp[i + 1] = 1 << 0;
            }
            else if(read[i] == 'O')
            {
                resp[i + 1] = 1 << 1;
            }
            else if(read[i] == 'I')
            {
                resp[i + 1] = 1 << 2;
            }
        }
        dp[1, 0] = 1;
        for(int i = 0; i < n; i++)
        {
            for(int now = 0; now < 1 << 3; now++)
            {
                for(int next = 0; next < 1 << 3; next++)
                {
                    if((now & next) > 0)
                    {
                        if((next & resp[i + 1]) > 0)
                        {
                            dp[next, i + 1] += dp[now, i];
                            dp[next, i + 1] %= 10007;
                        }
                    }
                }
            }
        }
        long ans = 0;
        for(int now = 0; now < 1 << 3; now++)
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
        for(int i = 0; i < N; i++)
        {
            var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for(int j = 0; j < N; j++)
            {
                match[i, j] = read[j];
            }
        }
        var dp = new long[1 << N];
        dp[0] = 1;
        for(int S = 1; S < 1 << N; S++)
        {
            var i = BitOperations.PopCount((uint)S);
            for(int j = 0; j < N; j++)
            {
                if((S >> j & 1) == 1 && match[i - 1,j] == 1)
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
        var dp = new long[102,22];
        dp[1, read[0]] = 1;
        for(int i = 1; i < n - 1; i++)
        {
            for(int j = 0; j <= 20; j++)
            {
                if(dp[i, j] > 0)
                {
                    int plus = j + read[i];
                    int minus = j - read[i];
                    if(plus <= 20)
                    {
                        dp[i + 1,plus] += dp[i, j];
                    }
                    if(minus >= 0)
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
        for(int i = 0; i < read[1]; i++)
        {
            var read2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            A[read2[0] - 1] = read2[1];
        }
        var dp = new long[read[0] + 1, 4, 4];
        dp[0, 0, 0] = 1;
        for(int i = 0; i < read[0]; i++)
        {
            for(int j = 0; j < 4; j++)
            {
                for(int k = 0; k < 4; k++)
                {
                    var menu = new int[]{1, 2, 3};
                    foreach(var pasta in menu)
                    {
                        if(A[i] > 0 && pasta != A[i])
                        {
                            continue;
                        }
                        if(pasta != k || k != j)
                        {
                            dp[i + 1, pasta, j] += dp[i, j, k];
                            dp[i + 1, pasta, j] %= 10000;
                        }
                    }
                }
            }
        }
        long ans = 0;
        for(int i = 0; i < 4; i++)
        {
            for(int j = 0; j < 4; j++)
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
        for(int i = 0; i < dn[0]; i++)
        {
            day[i] = int.Parse(Console.ReadLine());
        }
        for(int i = 0; i < dn[1]; i++)
        {
            var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            huku[i].Item1 = read[0];
            huku[i].Item2 = read[1];
            huku[i].Item3 = read[2];
        }
        var dp = new int[dn[0],dn[1]];
        
        for(int i = 0; i < dn[0] - 1; i++)
        {
            for(int j = 0; j < dn[1]; j++)
            {
                if(huku[j].Item1 > day[i + 1] || day[i + 1] > huku[j].Item2) continue;
                for(int k = 0; k < huku.GetLength(0); k++)
                {
                    if(huku[k].Item1 > day[i] || day[i] > huku[k].Item2) continue;
                    dp[i + 1, j] = Math.Max(dp[i + 1, j],dp[i, k] + Math.Abs(huku[j].Item3 - huku[k].Item3));
                }
                
            }
        }
        long ans = 0;
        for(int i = 0; i < dn[1]; i++)
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
        for(int i = 0; i < nm[0] + nm[1]; i++)
        {
            if(i < nm[0])
            {
                distance[i] = int.Parse(Console.ReadLine());
            }
            else
            {
                wether[i - nm[0]] = int.Parse(Console.ReadLine()); 
            }
        }
        var dp = new long[nm[1] + 1, nm[0] + 1];
        for(int i = 0; i < dp.GetLength(0); i++)
        {
            for(int j = 0; j < dp.GetLength(1); j++)
            {
                dp[i, j] = longMax;
            }
        }
        dp[0, 0] = 0;
        for(int i = 0; i < nm[1]; i++)
        {
            for(int  now = 0; now < nm[0]; now++)
            {
                dp[i + 1, now + 1] =  Math.Min(dp[i + 1, now + 1], dp[i, now] + distance[now] * wether[i]);
                dp[i + 1, now] = Math.Min(dp[i + 1, now], dp[i, now]);
            }
        }
        long ans = longMax;
        for(int i = 0; i <= nm[1]; i++)
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
        for(int i = 2; i < N; i++)
        {
            dp[i] = Math.Min(dp[i - 1] + Math.Abs(h[i] - h[i - 1]), dp[i -2] + Math.Abs(h[i] - h[i - 2]));
        }
        Console.WriteLine(dp[N - 1]);
    }
    public static void educational_DP_B()
    {
        var nk = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var h = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var dp = new int[nk[0]];
        for(int i = 0; i < nk[0]; i++)
        {
            dp[i] = 1000000000;
        }
        dp[0] = 0;
        dp[1] = Math.Abs(h[1] - h[0]);
        for(int i = 0; i < nk[0]; i++)
        {
            for(int j = 1; j <= nk[1]; j++)
            {
                if(i - j < 0) continue;
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
        for(int i = 0; i < N; i++)
        {
            var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            A[i, 0] = read[0];
            A[i, 1] = read[1];
            A[i, 2] = read[2];
        }
        dp[0,0] = A[0, 0];
        dp[0,1] = A[0,1];
        dp[0,2] = A[0,2];    
        for(int i = 0; i < N - 1; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                for(int k = 0; k < 3; k++)
                {
                    if(j == k) continue;
                    dp[i + 1, k] = Math.Max(dp[i + 1, k], dp[i, j] + A[i + 1, k]);
                }
                
            }
        }
        long ans = 0;
        for(int i = 0; i < 3; i++)
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
        for(int i = 0; i < N; i++)
        {
            var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
            A[i + 1].Item1 = read[0];
            A[i + 1].Item2 = read[1];
        }
        var dp = new long[N + 1, W + 1];
        for(int i = 1; i <= N; i++)
        {
            for(int j = 0; j <= W; j++)
            {
                if(j >= A[i].Item1)
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
        for(int i = 1; i < n + 1; i++)
        {
            var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            A[i].Item1 = read[0];
            A[i].Item2 = read[1];
        }
        for(int i = 0; i < n + 1; i++)
        {
            for(int j = 0; j < 100001; j++)
            {
                dp[i, j] = longMax;
            }
        }
        dp[0,0] = 0;
        for(int i = 1; i < n + 1; i++)
        {
            for(int j = 0; j < 100001; j++)
            {
                if(j - A[i].Item2 >= 0) dp[i, j] = Math.Min(dp[i - 1, j], dp[i - 1, j - A[i].Item2] + A[i].Item1);
                else dp[i, j] = dp[i - 1, j];
             }
        }

        int ans = 100000;
        while(dp[n, ans] > w)ans--;
        Console.WriteLine(ans);
    }
    public static void ABC178_D()
    {
        int S = int.Parse(Console.ReadLine());
        var dp = new long[2001];
        for(int i = 0; i < 2001; i++)
        {
            dp[i] = 1;
        }
        dp[0] = 1;
        dp[1] = 0;
        dp[2] = 0;
        for(int i = 3; i <= S; i++)
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
     
        for(int i = 1; i < read1.Length; i++)
        {
            for(int j = 1; j < read2.Length; j++)
            {
               if(read1[i] == read2[j])
               {
                   dp[i, j] = dp[i - 1, j - 1] + 1;
               }
               else if(dp[i - 1, j] >= dp[i, j - 1])
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
        while(len > 0)
        {
            if(read1[len1] == read2[len2])
            {
                ans[len - 1] = read1[len1];
                len1--;
                len2--;
                len--;
            }
            else if(dp[len1, len2] == dp[len1 - 1, len2])
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
        for(int i = 0; i < nm[0]; i++)
        {
            graph[i] = new List<int>();
        }
        for(int i = 0; i < nm[1]; i++)
        {
            var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            graph[read[0] - 1].Add(read[1] - 1);
        }
        var dp = new int[nm[0]];
        for(int i = 0; i < nm[0]; i++)
        {
            dp[i] = -1;
        }
        int func(int x)
        {
            if(dp[x] != -1) return dp[x];
            int ret = 0;
            foreach(var i in graph[x])
            {
                ret = Math.Max(ret, func(i) + 1);
            }
            return dp[x] = ret;
        }
        int ans = 0;
        for(int i = 0; i < nm[0]; i++)
        {
            ans = Math.Max(ans, func(i));
        }
        Console.WriteLine(ans);
    }
    public static void educational_DP_J()
    {
        int n = int.Parse(Console.ReadLine());
        var sushi = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var dp = new double[n + 2,n + 2,n + 2];
        var cnt = new int[4];
        for(int i = 0; i < sushi.Length; i++)
        {
            cnt[sushi[i]]++;
        }
        for(int k = 0; k < n + 1; k++)
        {
            for(int j = 0; j < n + 1; j++)
            {
                for(int i = 0; i < n + 1; i++)
                {
                    int sum = i + j + k;
                    if(sum == 0) continue;
                    dp[i, j ,k] = 1 * n / (double)sum;
                    if(i != 0) dp[i, j, k] += dp[i - 1, j, k] * i / (double)sum;
                    if(j != 0) dp[i, j, k] += dp[i + 1, j - 1, k] * j / (double)sum;
                    if(k != 0) dp[i, j, k] += dp[i, j + 1, k - 1] * k / (double)sum;
                    
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
        for(int i = 0; i <= nk[1]; i++)
        {
            int lose = 0;
            int cnt = 0;
            for(int j = 0; j < nk[0]; j++)
            {
                
                if(i >= a[j])
                {
                    cnt++;
                    if(dp[i - a[j]] == false) lose++;
                } 
            }
            if(cnt == 0) dp[i] = false;
            else if(lose > 0) dp[i] = true;
            else dp[i] = false;
        }
        if(dp[nk[1]]) Console.WriteLine("First");
        else Console.WriteLine("Second");

    }
    public static void educational_DP_L()
    {
        int N = int.Parse(Console.ReadLine());
        var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var visited = new int[N,N];
        var dp = new long[N, N];
        long rec(int l, int r, int turn)
        {
            if(l > r) return 0;
            if(visited[l, r] != 0) return dp[l, r];
            visited[l, r] = 1;
            long ret = 0;
            if(turn == 0)
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
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < k; j++)
            {
                sum[j + 1] = (sum[j + 1] + sum[j]) % mod;
            }
            for(int j = k; j >= a[i] + 1; j--)
            {
                sum[j] = (sum[j] - sum[j - a[i] - 1]) % mod;
            }
        }
        if(sum[k] < 0) sum[k] += mod;
        Console.WriteLine(sum[k]);
    }
    public static void typical_dp_A()
    {
        var n = int.Parse(Console.ReadLine());
        var p = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var dp = new int[101, 100001];
        dp[0, 0] = 1;
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < 100001; j++)
            {
                dp[i + 1, j] = dp[i, j];
                if(j >= p[i]) dp[i + 1, j] |= dp[i, j - p[i]];
            }
        }
        int sum = 0;
        for(int i = 0; i < 100001; i++ )
        {
            if(dp[n, i] > 0) sum++;
        }
        Console.WriteLine(sum);
    }
    public static void typical_dp_B()
    {
        var ab = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var b = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var dp = new int[ab[0] + 1, ab[1] + 1];
        for(int i = 0; i <= ab[0] ; i++)
        {
            for(int j = 0; j <= ab[1]; j++)
            {
                if((ab[0] + ab[1] - i - j) % 2 == 0)
                {
                    dp[i, j] = Math.Max(i > 0 ? dp[i - 1, j] + a[ab[0] - i]:0, j > 0 ? dp[i, j - 1] + b[ab[1] - j]:0);
                }
                else
                {
                    if(i == 0 && j == 0) continue;
                    dp[i, j ] = Math.Min(i > 0 ? dp[i - 1, j]:intMax, j > 0 ? dp[i, j - 1]: intMax);
                }
                
            }
        }
        Console.WriteLine(dp[ab[0], ab[1]]);

    }
    }
}
