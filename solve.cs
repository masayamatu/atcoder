using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using static CompLib.CompLib;
using DataStructure;
using System.Runtime.CompilerServices;
using System.Text;

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
    /// <summary>
    /// DP 和の通り数数え上げ
    /// </summary>
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
    /// <summary>
    /// DP ゲーム
    /// </summary>
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
    /// <summary>
    /// 区DP　slime
    /// </summary>
    public static void educational_DP_N()
    {
        int N = int.Parse(Console.ReadLine());
        var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var sum = new long[N + 1];
        var dp = new long[N + 1, N + 1];
        for(int i = 0; i < N; i++)
        {
            sum[i + 1] = sum[i] + a[i];
        }
        for(int i = 0; i < dp.GetLength(0); i++)
        {
            for(int j = 0; j < dp.GetLength(1); j++)
            {
                dp[i, j] = 0;
            }
        }
        for(int bet = 1; bet < N; bet++)
        {
            for(int l = 0; l < N - bet; l++)
            {
                long temp = longMax;
                for(int k = l; k < l + bet; k++)
                {
                    //区間の合成に利用された最小コストを取得
                    temp = Math.Min(temp, dp[l, k] + dp[k + 1,l + bet]);   
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
        for(int i = 1; i < N; i++)
        {
            if(i >= 2)
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
        for(int i = 0; i < nm[1]; i++)
        {
            var temp = int.Parse(Console.ReadLine());
            stairs[temp] = true;
        }
        var dp = new long[nm[0] + 1];
        var mod = 1000000007;
        dp[0] = 1;
        for(int i = 1; i <= nm[0]; i++)
        {
            if(i < 2)
            {
                if(!stairs[i]) dp[1] = 1;
            }
            else
            {
                if(!stairs[i])
                {
                    if(!stairs[i - 1] && !stairs[i - 2])
                    {
                        dp[i] = (dp[i - 1] + dp[i - 2]) % mod;
                    }
                    else if(!stairs[i - 1])
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
        
        for(int i = 0; i < 100001; i++)
        {
           dp[i] = intMax;
        }
        dp[0] = 0;
        dp[1] = 1;
        for(int i = 1; i < 100001; i++)
        {
            for(int k = 1; Math.Pow(6, k) <= i; k++)
            {
                dp[i] =　Math.Min(dp[i], dp[i - (int)Math.Round(Math.Pow(6, k),0)] + 1);
            }
            for(int k = 1; Math.Pow(9, k) <= i; k++)
            {
                dp[i] =　Math.Min(dp[i], dp[i - (int)Math.Round(Math.Pow(9, k), 0)] + 1);
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
        for(int i = 0; i < nk[0]; i++)
        {
            sum[i + 1] = sum[i] + a[i];
        }
        long ans = 0;
        for(int i = 0; i < nk[0] - nk[1] + 1; i++)
        {
            ans += sum[i + nk[1]] - sum[i];
        }
        Console.WriteLine(ans);
    }
    public static void typical_dp_C()
    {
        int K = int.Parse(Console.ReadLine());
        var R = new int[(int)Math.Pow(2, K)];
        for(int i = 0; i < Math.Pow(2, K); i++)
        {
            R[i] = int.Parse(Console.ReadLine());
        }
        var dp = new double[(int)Math.Pow(2, K) + 1, K + 1];
        for(int i = 0; i < 1 << K; i++)
        {
            dp[i, 0] = 1;
        }
        
        for(int j = 0; j < K; j++)
        {
            for(int i = 0; i < 1 << K; i++)
            {
                double p = 0;
                for(int l = 0; l < 1 << j; l++)
                {
                    int candidate = ((i ^ 1 << j) & ~((1 << j) - 1)) + l;
                    p += dp[candidate, j] * 1.0/(1 + Math.Pow(10.0, (R[candidate] - R[i])/400.0));
                }
                dp[i, j + 1] = p * dp[i, j];
                
            }
        }
        for(int i = 0; i < 1 << K; i++)
        {
            Console.WriteLine("{0:f9}",dp[i, K]);
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
        while(d % 2 == 0)
        {
            l++;
            d /= 2;
        }
        while(d % 3 == 0)
        {
            m++;
            d /= 3;
        }
        while(d % 5 == 0)
        {
            k++;
            d /= 5;
        }
        if(d > 1)
        {
            ans = 0.0;
            Console.WriteLine(ans);
            return;
        }
        dp[0,0,0,0] = 1.0;
        for(int i = 0; i < n; i++)
        {
            int cur = i % 2;
            int tar = 1 ^ cur;
            for(int x = 0; x < 70; x++)
            {
                for(int y = 0; y < 50; y++)
                {
                    for(int z = 0; z < 40; z++)
                    {
                        if(x == 0 && y == 0 && z == 0)
                        {
                            //dp[tar, x, y, z] = 1;
                            //continue;
                        }
                        dp[tar, x, y, z] = 0;
                    }
                }
            }
            for(int x = 0; x < 70; x++)
            {
                for(int y = 0; y < 50; y++)
                {
                    for(int z = 0; z < 40; z++)
                    {
                        if(dp[cur, x, y, z] == 0)continue;
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
        for(int x = l; x < 70; x++)
        {
            for(int y = m; y < 50; y++)
            {
                for(int z = k; z < 40; z++)
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
        for(int i = 1; i <= N.Length; i++)
        {
            for(int j = 0; j < D; j++)
            {
                for(int k = 0; k < 10; k++)
                {
                    int now = N[i - 1] - '0';
                    if(now > k)
                    {
                        dp[i, (j + k) % D, 1] += (dp[i - 1, j, 0] + dp[i - 1, j, 1] % mod);
                        dp[i, (j + k) % D, 1] %= mod;
                    }
                    else if(now == k)
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
        var dp = new long[N.Length,N.Length + 1,2];
        if(N[0] == '1')
        {
            dp[0,1,0] = 1;
            dp[0,0,1] = 1; 
        }
        else
        {
            dp[0,0,0] = 1;
            dp[0,1,1] = 1;
            dp[0,0,1] = N[0] - '0' - 1;
        }
        for(int i = 0; i < N.Length - 1; i++)
        {
            int now = N[i + 1] - '0';
            for(int j = 0; j < N.Length; j++)
            {
                if(now == 1)
                {
                    dp[i + 1, j + 1, 0] += dp[i, j ,0];
                    dp[i + 1, j, 1] += dp[i, j, 0];
                }
                else
                {
                    dp[i + 1, j, 0] += dp[i, j, 0];
                    if(now > 1)
                    {
                        dp[i + 1, j, 1] += (now - 1) * dp[i, j, 0];
                        dp[i + 1, j + 1, 1] += dp[i, j, 0];
                    }
                }
                dp[i + 1, j + 1, 1] += dp[i ,j, 1];
                dp[i + 1, j, 1] += dp[i, j, 1] * 9;
            }
            
        }
        long ans = 0;
        for(long i = 1; i <= N.Length; i++)
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
            var dp = new long[strX.Length + 1,2];
            dp[0,0] = 1;
            for(int i = 0; i < strX.Length; i++)
            {
                long count = 0;
                for(int j = 0; j < 9; j++)
                {
                    if(j == 4)continue;
                    if(j < strX[i] - '0') count++;
                }
                if(strX[i] == '4' || strX[i] == '9')
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
        for(int i = 0; i < dp.GetLength(0); i++)
        {
            for(int j = 0; j < dp.GetLength(1); j++)
            {
                dp[i, j] = -1;
            }
        }
        dp[0,0] = 0;
        for(int d = 0; d < maxD; d++)
        {
            long mask = (long)1 << (maxD - d - 1);
            int count = 0;
            for(int i = 0; i < nk[0]; i++)
            {
                if((A[i] & mask) > 0) count++;
            }
            long cost0 = mask  * count;
            long cost1 = mask * (nk[0] - count);

            if(dp[d, 1] != -1)
            {
                dp[d + 1, 1] = Math.Max(dp[d + 1, 1], dp[d, 1] + Math.Max(cost0, cost1));
            }

            if(dp[d, 0] != -1)
            {
                if((nk[1] & mask) > 0)
                {
                    dp[d + 1, 1] = Math.Max(dp[d + 1, 1], dp[d, 0] + cost0);
                }
            }

            if(dp[d, 0] != -1)
            {
                if((nk[1] & mask) > 0)
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
        dp[0,0,0] = 1;

        for(int i = 0; i < k.Length; i++)
        {
            int now = k[i] - '0';
            for(int j = 0; j < D; j++)
            {
               for(int x = 0; x < 10; x++)
                {
                  if(x > now)
                  {
                      dp[i + 1, (j + x) % D, 1] += dp[i, j, 1];
                      dp[i + 1, (j + x) % D, 1] %= mod;

                  }
                  else if(x == now)
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
        for(int i = 0; i < graph.Length; i++)
        {
            graph[i] = new List<int>();
        }
        for(int i = 0; i < N - 1; i++)
        {
            var xy = Console.ReadLine().Split().Select(int.Parse).ToArray();
            graph[xy[0] - 1].Add(xy[1] - 1);
            graph[xy[1] - 1].Add(xy[0] - 1);
        }
        void dfs(int now, int p = -1)
        {
            dp[now, 0] = dp[now, 1] = 1;
            foreach(var to in graph[now])
            {
                if(to != p)
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
        for(int i = 0; i < graph.Length; i++)
        {
            graph[i] = new List<int>();
        }
        long mod = 1000000007;
        for(int i = 0; i < N - 1; i++)
        {
            var ab = Console.ReadLine().Split().Select(int.Parse).ToArray();
            graph[ab[0] - 1].Add(ab[1] - 1);
            graph[ab[1] - 1].Add(ab[0] - 1);
        }
        var dp = new long[N, 2];
        void dfs(int now, int pre)
        {
            dp[now, 0] = dp[now, 1] = 1;
            foreach(var next in graph[now])
            {
                if(next == pre) continue;
                dfs(next, now);
                dp[now, 0] *= ((dp[next, 0] + dp[next, 1]) % mod);
                dp[now, 0] %= mod;
                dp[now , 1] *= dp[next, 0];
                dp[now, 1] %= mod;
            }
        }
        dfs(0, - 1);
        long ans = (dp[0, 0] + dp[0, 1]) % mod;
        Console.WriteLine(ans);
    }
    public static void typical_dp_N()
    {
        int N = int.Parse(Console.ReadLine());
        var graph = new List<int>[N];
        long mod = 1000000007;
        for(int i = 0; i < N; i++)
        {
            graph[i] = new List<int>();
        }
        var dp = new ValueTuple<long, long>[N];
        for(int i = 0; i < N - 1; i++)
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
            foreach(var next in graph[now])
            {
                if(visited[next] != 1)
                {
                    s.Push(dfs(next));
                } 
            }
            ValueTuple<long, long> ret = ValueTuple.Create(1, 0);
            if(s.Count() != 0)
            {
                foreach(var a in s)
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
        for(int i = 0; i < N; i++)
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
        if(X >= 90)
        {
            Console.WriteLine("expert");
        }
        else if(X < 90 && X >= 70)
        {
            Console.WriteLine(90 - X);
        }
        else if(X < 70 && X >= 40)
        {
            Console.WriteLine(70 - X);
        }
        else if(X < 40)
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
        for(int i = 0; i < a.Length; i++)
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
        for(int i = 0; i < N; i++)
        {
            name[i] = Console.ReadLine();
            var tempchar = name[i].ToCharArray();
            String temp = "";
            for(int j = 0; j < tempchar.Length; j++)
            {
                int index = S.IndexOf(tempchar[j]);
                temp += alphabet[index];              
            }
            list.Add(temp);
        }
        list.Sort();
        foreach(var s in list)
        {
            string temp = "";
            foreach(var t in s)
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
        
        for(int i = 1; i <= N; i++)
        {
            var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            ab[i, 0] = read[0];
            ab[i, 1] = read[1];
        }
        //dp[i, j, k]・・・i 番目の弁当までで j個のたこ焼きとk個のたい焼きを購入しているときの最小の弁当の購入数
        var dp = new int[N + 1,301,301];
        for(int i = 0; i < dp.GetLength(0); i++)
        {
            for(int j = 0; j < dp.GetLength(1); j++)
            {
                for(int k = 0; k < dp.GetLength(2); k++)
                {
                    dp[i, j, k] = intMax;
                }
            
            }
        }
        dp[0,0,0] = 0;//0番目の弁当ではたこ焼きもタイ焼きも０個で弁当の購入数ももちろん０

        for(int now = 1; now < dp.GetLength(0); now++)
        {
            for(int j = 0; j < dp.GetLength(1); j++)
            {
                for(int k = 0; k < dp.GetLength(2); k++)
                {
                    //now番目の弁当を買うときの遷移
                    dp[now, Math.Min(xy[0], j + ab[now, 0]),Math.Min(xy[1], k + ab[now, 1])] = Math.Min(dp[now, Math.Min(xy[0], j + ab[now, 0]),Math.Min(xy[1], k + ab[now, 1])],dp[now - 1,j, k] + 1); 
                    //now番目の弁当を買わないときの遷移
                    dp[now, j, k] = Math.Min(dp[now, j, k], dp[now - 1, j, k]);
                }
            }
        }

        if(dp[N, xy[0], xy[1]] == intMax)
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
        for(int i = 0; i < nk[0]; i++)
        {
            int temp = i + 1;
            double tempP = 1 / (double)nk[0];
            while(temp < nk[1])
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
        for(int i = 0; i < nm[1]; i++)
        {
            var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            id[i].Item1 = read[0];
            id[i].Item2 = read[1]; 
            cards[id[i].Item1] += 1;
            cards[id[i].Item2 + 1] = -1;  
        }
        
        for(int i = 1; i < nm[0] + 1; i++)
        {
            cards[i] += cards[i - 1];
        }
        var ans = 0;
        for(int i = 0; i < cards.Length; i++)
        {
            if(cards[i] == nm[1]) ans++;
        }
        Console.WriteLine(ans);
    }
    public static void ABC128_B()
    {
        int N = int.Parse(Console.ReadLine());
        var list = new Dictionary<string, List<(int, int)>>();
        for(int i = 0; i < N; i++)
        {
            var read = Console.ReadLine().Split();
            if(!list.ContainsKey(read[0]))
            {
                list[read[0]] = new List<(int, int)>();
                list[read[0]].Add((int.Parse(read[1]), i));
            }
            else
            {
                list[read[0]].Add((int.Parse(read[1]),i));
            }
        }
        foreach(var l in list.OrderBy(c => c.Key))
        {
            foreach(var v in l.Value.OrderByDescending(c => c.Item1))
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
        

        if(read[2] * 2 == read[0] && read[3] * 2 == read[1]) multi = true;
  
        if(multi)
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
        for(int i = 0; i < nk[0]; i++)
        {           
            while(sum < nk[1])
            {
                if(r == nk[0])break;
                else
                {
                    sum += a[r];
                    r++; 
                }                   
            }
            if(sum < nk[1]) break;
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
            var aNc = Math.Floor((decimal)A/C);
            var aNd = Math.Floor((decimal)A/D);

            long tempC = C;
            long tempD = D;

            long r = tempD % tempC;
            while(r != 0)
            {
                tempD = tempC;
                tempC = r;
                r = tempD % tempC;
            }
            var CD = Math.Floor(((decimal)C * D) / tempC);

            var acd = Math.Floor((decimal)A/CD);
            var ret = A - aNc - aNd + acd;
            return (long)ret;
        }
        long ans = num(abcd[1],abcd[2],abcd[3]) - num(abcd[0] - 1, abcd[2], abcd[3]); 
        Console.WriteLine(ans);
    }
    public static void ARC114_A()
    {
        int N = int.Parse(Console.ReadLine());
        var x = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var list = new List<long>();
        var prime = new long[]{2,3,5,7,11,13,17,19,23,29,31,37,41,43,47};
        long ans = longMax;
        for(long i = 0; i < 1 << prime.Length; i++)
        {
            var bit = new bool[prime.Length];
            var check = new bool[x.Length];
            for(int j = 0; j < prime.Length; j++)
            {
                if(((i >> j) & 1) == 1) bit[j] = true;
            }
            long temp = 1;
            for(int j = 0; j < prime.Length; j++)
            {
                if(bit[j])temp *= prime[j];   
            }
            for(int j = 0; j < x.Length; j++)
            {
                for(int k = 0; k < prime.Length; k++)
                {
                    if(x[j] % prime[k]== 0 && temp % prime[k] == 0)
                    {
                        check[j] = true;
                        break;
                    }
                }
            }
            for(int j = 0; j < check.Length; j++)
            {
                if(!check[j])break;
                else if(j == check.Length - 1) ans = Math.Min(ans, temp);
            }
        }
        Console.WriteLine(ans);
        
    }
    public static void ARC109_B()
    {
        long n = long.Parse(Console.ReadLine());
        long r = 2 * 1000000000;
        long l = 0;
        while(r - l > 1)
        {
            long mid = (l + r) / 2;
            long sum = (mid * (mid + 1)) / 2;   
            if(sum > n + 1)
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
        for(int i = 1; i < N; i++)
        {
            dp[i, 0] = dp[i - 1, 1] - A[i];
           
        }
    }
    public static void ARC126_A()
    {
        long N = long.Parse(Console.ReadLine());
        var test = new (long, long, long)[N];
        for(int  i=0 ;i < N ;i++ )
        {
            var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
            test[i].Item1 = read[0];
            test[i].Item2 = read[1];
            test[i].Item3 = read[2];
        }
        
        for(int i = 0; i < N; i++)
        {
            long ans = 0;
            //長さ3は偶数個しかつかえない
            if(test[i].Item2 % 2 != 0)test[i].Item2--;
            //長さ３×２＋長さ４
            if(test[i].Item2 >= test[i].Item3 * 2)
            {
                ans += test[i].Item3;
                test[i].Item2 -= test[i].Item3 * 2;
                test[i].Item3 = 0;
            }
            else
            {
                ans += test[i].Item2/2;
                test[i].Item3 -= test[i].Item2 / 2;
                test[i].Item2 %= 2;
            }
             //長さ２×２＋長さ３×２
            if(test[i].Item2 > 0)
            {
                ans += Math.Min(test[i].Item1/2,test[i].Item2/2);
                test[i].Item1 -= Math.Min(test[i].Item1,test[i].Item2);
                test[i].Item2 -= Math.Min(test[i].Item1,test[i].Item2);
            }
            else if(test[i].Item3 > 0)
            {
                //長さ４×２＋長さ２
                if(test[i].Item3  >= test[i].Item1 * 2)
                {
                    ans += test[i].Item1;
                    test[i].Item3 -= test[i].Item1 * 2;
                    test[i].Item1 = 0;
                }
                else
                {
                    ans += test[i].Item3/2;
                    test[i].Item1 -= test[i].Item3/2;
                    test[i].Item3 %= 2;
                }
            }    
            //長さ２×３＋長さ４
            if(test[i].Item1 >= 3 && test[i].Item3 >= 1)
            {
                ans += test[i].Item3;
                test[i].Item1 -= test[i].Item3 * 3;
                test[i].Item3 = 0;
            }
            //長さ２×５
            ans += test[i].Item1/5;
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
        for(int i = 0; i < 1 << 4; i++)
        {
            var bit = new bool[4];
            long eat = 0;
            for(int j = 0; j < 4; j++)
            {
                if(((i >> j) & 1) == 1) bit[j] = true;
            }
            for(int j = 0; j < 4; j++)
            {
                
                if(bit[j]) eat += read[j];
            }
            if(sum - eat == eat) ok = true;
        }
        if(ok) Console.WriteLine("Yes");
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
            while(n > 0)
            {
                if((n & 1) > 0) ret *= x;
                x *= x;
                n = n >> 1;
            }
            return ret;
        }
        while(pow(3, A) <= N)
        {
            int B = 1;
            long sum = pow(3, A) + pow(5,B);
            while(pow(3, A) + pow(5,B) <= N)
            {
                if(pow(3, A) + pow(5,B) == N)
                {
                    ok = true;
                    ansA = A;
                    ansB = B;
                    break;
                }
                B++;
            }
            if(pow(3, A) + pow(5,B) == N)
            {
                    break;
            }
            A++;
        }
        if(ok) Console.WriteLine($"{ansA} {ansB}");
        else Console.WriteLine(-1);
    }
    public static void ARC107_A()
    {
        var abc = Console.ReadLine().Split().Select(long.Parse).ToArray();
        long mod = 998244353;
        long sumC = ((abc[2] * (abc[2] + 1))/2) % mod;
        long sumB = ((abc[1] * (abc[1] + 1))/2) % mod;
        long sumA = ((abc[0] * (abc[0] + 1))/2) % mod;
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
        for(int i = 0; i < N; i++)
        {
            int countA = 0;
            int countC = 0;
            for(int j = i; j < N; j++)
            {
                if(S[j] == 'A')
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

                if(countA == 0 && countC == 0)
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
        for(int i = 0; i < 10000000; i++)
        {
            if(i * (sp[0] - i) == sp[1])
            {
                ok = true;
                break;
            }
        }
        if(ok) Console.WriteLine("Yes");
        else Console.WriteLine("No");
    }
    public static void ARC109_A()
    {
        var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int ans = 0;
        if(read[0] - read[1] == 1)
        {
            ans = read[2];
        }
        else if(read[2] * 2 < read[3] && read[1] >= read[0])
        {
            ans = Math.Abs(read[0] - read[1]) * read[2] * 2 + read[2];
        }
        else if(read[2] * 2 >= read[3] && read[1] >= read[0])
        {
            ans = Math.Abs(read[0] - read[1]) * read[3] + read[2];
        }
        else if(read[1] < read[0])
        {
            ans = Math.Min((read[0] - read[1] - 1) * 2 * read[2] + read[2],(read[0] - read[1] - 1) * read[3] + read[2]);
        }
        Console.WriteLine(ans);
    }
    public static void ARC110_A()
    {
        int N = int.Parse(Console.ReadLine());
        if(N == 2)
        {
            Console.WriteLine(3);
            return;
        }
        long s = 2;
        long ans = 0;
        for(int i = 3; i <= N; i++)
        {
            long tempA = s;
            long tempB = i;
            long r = tempA % tempB;
            while(r != 0)
            {
                tempA = tempB;
                tempB = r;
                r = tempA% tempB;
            }
            ans = (s * i / tempB) + 1;
            s = ans - 1;
        }
        Console.WriteLine(ans);
    }
    public static void ARC112_A()
    {
        int T = int.Parse(Console.ReadLine());
        for(int i = 0; i < T; i++)
        {
            var lr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long temp = lr[1] - 2 * lr[0] + 1;
            if(lr[0] == 0 && lr[1] == 0)
            {
                Console.WriteLine(1);
            }
            else if(lr[0] == lr[1])
            {
                Console.WriteLine(0);
            }
            else if(temp <= 0 || lr[1] + 1 < temp)
            {
                Console.WriteLine(0);
            }
            else
            {
                long ans = (temp * (temp + 1))/2;
                Console.WriteLine(ans);
            }
        }
    }
    public static void ARC113_A()
    {
        int K = int.Parse(Console.ReadLine());
        long ans = 0;
        for(int  A = 1; A <= K ; A++)
        {
            for(int B = 1; B <= K/A; B++)
            {
                for(int  C = 1;  C <= K / (A * B);  C++)
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
        for(int i = 0; i < T; i++)
        {
            long N = long.Parse(Console.ReadLine());
            if(N % 2 == 1)
            {
                Console.WriteLine("Odd");
            }
            else if(N % 4 == 0)
            {
                Console.WriteLine("Even");
            }
            else if(N % 2 == 0)
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

        if(AB[0] > AB[1])
        {
            for(int i = 0; i < AB[0]; i++)
            {
                seq +=" " + (i + 1);
                sumA += i + 1;
            }
            for(int i = 0; i < AB[1] - 1; i++)
            {
                seq += " " + -(i + 1);
                sumB -= (i + 1);
            }
            long temp = sumA + sumB;
            seq += " " + -temp;
            seq = seq.TrimStart(' ');
        }
        else if(AB[0] < AB[1])
        {
             for(int i = 0; i < AB[0] - 1; i++)
            {
                seq +=" " + (i + 1);
                sumA += i + 1;
            }
            for(int i = 0; i < AB[1]; i++)
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
            for(int i = 0; i < AB[0]; i++)
            {
                seq += " " + (i + 1);
            }
            for(int i = 0; i < AB[0]; i++)
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
        for(int i = 1; i <= 100; i++)
        {
            int a = (int)Math.Floor(i * (100 + t)/(double)100);
            if(a - temp > 1) not.Add(temp + 1);
            temp = a;
        }
        long M = N/not.Count();
        long index = N % not.Count();
        long ans = 0;
        
        if(N <= not.Count())
        {
            ans = not[(int)N - 1];
        }
        else if(index == 0)
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
            while(n > 0)
            {
                if((n & 1) > 0) ret *= x;
                x *= x;
                n = n >> 1;
            }
            return ret;
        }
        long ans = longMax;
        int b = (int)Math.Log2(N);
        for(int i = b; 0 <= i ; i--)
        {
            long a = N/pow(2, i);
            long c = N % (pow(2, i) * a);
            ans = Math.Min(ans,i + a + c);
            
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
        for(int i = 0; i < A.Length; i++)
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

        if(d == 0)
        {
            ans = 0;
        }
        else if (d > 0)
        {
            ans = d;
        }
        else
        {
            if(-d % 2 == 0)
            {
                ans = Math.Abs(d/2);
            }
            else
            {
                ans = Math.Abs((d - 1)/2) + 1;
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
        for(int i = 0; i < K; i++)
        {
            var read = Console.ReadLine().Split();
            int num = int.Parse(read[1]) - 1;
                        
            if(read[0] == "L")
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
        for(int i = 0; i < N; i++)
        {
            int temp = K;
            if(card[i] == 0)
            {
                foreach(var l in lList)
                {
                    if(i < (l.Item2))
                    {
                        temp--;
                    }
                }
                foreach(var r in rList)
                {
                    if(i > (r.Item2))
                    {
                        temp--;
                    }
                }
                card[i] = temp;
            }
        }
        long ans = 1;
        
        for(int i = 0; i < N; i++)
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
        
        for(int i = 0; i < a.Length; i++)
        {
            if(!x.Contains(a[0] ^ b[i]))
                x.Add(a[0] ^ b[i]);
        }
        foreach(var i in x)
        {
            var c = new long[N];
            var ok = true;
            for(int j = 0; j < N; j++)
            {
                c[j] = a[j] ^ i;
            }
            Array.Sort(c);
            Array.Sort(b);
            for(int j = 0; j < N; j++)
            {
                if(c[j] != b[j]) ok = false;
            }
            if(ok)
            {
                ans++;
                ansList.Add(i);
            }
        }
        ansList.Sort();
        Console.WriteLine(ans);
      　foreach(var i in ansList)
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
        if(S[0] == 0)
        {
            for(int i = N; i < listS.Count(); i++)
            {
                if(listS[i] == 1)
                {
                    find = (i - (N));
                    break;
                }
                
            }
            for(int i = N; i >= 0; i--)
            {
                if(listS[i] == 1) find = Math.Min(find,(N) - i);
            }
        }
        else if(S[0] == 1)
        {
            for(int i = N; i < listS.Count(); i++)
            {
                if(listS[i] == 0)
                {
                    find = (i - (N));
                    break;
                }
                
            }
            for(int i = N; i >= 0; i--)
            {
                if(listS[i] == 0) find = Math.Min(find,(N) - i);
            }
        }
        if(find == 0) 
        {
            for(int i = 0; i < M; i++)
            {
                if(S[0] != T[i])
                {
                　　Console.WriteLine(-1);
            　　　　return;
                }
            }
            Console.WriteLine(ans);
            return;     
        }
        
        bool first = true;
        if(S[0] != T[0])
        {
            ans += find;
            first = false;
        }
        for(int i = 1; i < M; i++)
        {
            if(T[i] != T[i - 1] && first) 
            {
                ans += find;
                first = false;
            }
            else if(T[i] != T[i - 1]) ans += 1;
        }
        Console.WriteLine(ans);
    }
    public static void ARC002_A()
    {
        int Y = int.Parse(Console.ReadLine());
        bool uruu = false;
        if(Y % 4 == 0)
        {
            uruu = true;
        }
        if(Y % 100 == 0)
        {
            uruu = false;
        }
        if (Y % 400 == 0)
        {
            uruu = true;
        }
        if(uruu) Console.WriteLine("YES");
        else Console.WriteLine("NO");
    }
    public static void ARC057_A()
    {
        var AK = Console.ReadLine().Split().Select(long.Parse).ToArray();
        long A = AK[0];
        long K = AK[1];
        long ans = 0;
        if(K == 0)
        {
            ans = 2000000000000 - A;
            Console.WriteLine(ans);
            return;
        }
        while(A < 2000000000000)
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
        if(read[3] * read[0] < read[1])
        {
            ans = read[0] * read[2];
        }
        else
        {
            ans = read[2]/read[3] * read[1] + (read[2] % read[3]) * read[0];
            if(read[2] % read[3] != 0)
            ans = Math.Min(ans, (read[2]/read[3] + 1) * read[1]);
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
        while(true)
        {
            var charN = Convert.ToString(N).ToCharArray();
            bool ok = true;
            for(int i = 0; i < charN.Length; i++)
            {
                if(noList.Contains(charN[i] - '0'))
                {
                    ok = false;
                    break;
                }
            }
            if(ok)
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
        int ave = (int)Math.Round((decimal)a.Sum()/a.Length,0);
        long cost = 0;
        for(int i = 0; i < N; i++)
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
        for(int i = 0; i < N; i++)
        {
            for(int j = 0; j < N; j++)
            {
                for(int k = 0; k < 2550; k++)
                {
                    dp[i + 1, j, k] += dp[i, j, k];
                    if(k - x[i] >= 0)
                    {
                        dp[i + 1, j + 1, k] += dp[i, j, k - x[i]];
                    }
                    
                }    
            }
        }
        long ans = 0;
        for(int i = 1; i <= N; i++)
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
        for(int i = 0; i < nm[0]; i++)
        {
            S[i] = Console.ReadLine().ToCharArray();
            int temp = 0;
            for(int j = 0; j < nm[1]; j++)
            {
                if(S[i][j] == '1') temp++;
            }
            if(temp % 2 == 0) evenCount++;
            else oddCount++;
        }
        long ans = (long)evenCount * oddCount;
        Console.WriteLine(ans);
    }
    public static void ARC121_A()
    {
        int N = int.Parse(Console.ReadLine());
        var point = new List<(int, long, long)>();
        for(int i = 0; i < N; i++)
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
        for(int i = 0; i < list.Count(); i++)
        {
            for(int j = i; j < list.Count(); j++)
            {
                if(list[i].Item1 == list[j].Item1)
                {
                    continue;
                }
                dist.Add(Math.Max(Math.Abs(list[i].Item2 - list[j].Item2),Math.Abs(list[i].Item3 - list[j].Item3)));
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
        count[0,1] = 1;
        for(int i = 0; i < N; i++)
        {
            count[i + 1, 1] += (count[i, 0] + count[i , 1]) % mod;
            count[i + 1, 0] += count[i, 1];
            count[i + 1, 0] %= mod;
        }
        if(N == 1)
        {
            Console.WriteLine(A[0]);
            return;
        }
        dp[1,0] = (A[0] - A[1]);
        dp[1,1] = (A[0] + A[1]); 
        for(int i = 1; i < N - 1; i++)
        {
            dp[i + 1, 1] += ((dp[i, 0] + (count[i, 0] * A[i + 1]) % mod));
            dp[i + 1, 1] %= mod;
            dp[i + 1, 1] += ((dp[i, 1] + (count[i, 1] * A[i + 1]) % mod));
            dp[i + 1, 1] %= mod;
            dp[i + 1, 0] += ((dp[i, 1] + mod - (count[i, 1] * A[i + 1]) % mod));
            dp[i + 1, 0] %= mod;
        }
        long ans = (dp[N - 1, 0] + dp[N - 1 , 1]) % mod;
        Console.WriteLine(ans);

    }
    public static void ARC122_B()
    {
        int N = int.Parse(Console.ReadLine());
        var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
        Array.Sort(A);
        var sum = new long[N];
        sum[0] = A[0];
        for(int i = 1; i < N; i++)
        {
            sum[i] = sum[i - 1] + A[i];
        }
        double ans = longMax;
        for(int i = 0; i < N; i++)
        {
            double x = A[i]/(double)2;
            var temp = N * x + sum[N - 1] - sum[i] - 2 * x * (N - i - 1);
            ans = Math.Min(ans, temp/N);
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
        while(p <= longN)
        {
            long u = 1;
            while(p * u <= longN)
            {
                long temp = longN - p*u + 1;
                ans += Math.Min(u,temp);
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
        int k = A[N / 2] - A[N/2 - 1];
        Console.WriteLine(k);
    }
    public static void ABC133_C()
    {
        var LR = Console.ReadLine().Split().Select(long.Parse).ToArray();
        long ans = longMax;
        for(long i = LR[0]; i < LR[1]; i++)
        {
            for(long j = i + 1; j <= LR[1]; j++)
            {
                ans = Math.Min(ans, i * j % 2019);
                if(ans == 0)
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
        for(int i = 0; i < N; i++)
        {
            A[i] = int.Parse(Console.ReadLine());
        }
        var list = A.ToList();
        list = list.OrderBy(x => x).ToList();
        for(int i = 0; i < N; i++)
        {
            if(A[i] == list[list.Count - 1])
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
        for(int i = 0; i < N; i++)
        {
            long temp = Math.Min(A[i], B[i]);
            ans += temp;
            B[i] -= temp;
            if(B[i] > 0)
            {
                temp = Math.Min(A[i + 1],B[i]);
                ans += temp;
                A[i + 1] -=temp;
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
        for(int i = 0; i < N; i++)
        {
            max = Math.Max(max, H[i]);
            if(max - H[i] > 1)
            {
                ok = false;
                break;
            }
            else
            {
                ok = true;
            }
        }
        if(ok) Console.WriteLine("Yes");
        else Console.WriteLine("No");
    }
    public static void ABC138_C()
    {
        int N = int.Parse(Console.ReadLine());
        var v = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Array.Sort(v);
        double ave = ((double)v[0] + v[1])/2;
        for(int i =  2; i < N; i++)
        {
            ave = ((double)v[i] + ave)/2;
        }
        Console.WriteLine(ave);
    }
    public static void ABC065_B()
    {
        int N = int.Parse(Console.ReadLine());
        var a = new int[N];
        for(int i = 0; i < N; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        var pushed = new bool[N];
        int next = -1;
        long ans = 1;
        while(true)
        {
            if(pushed[0] == false)
            {
                next = a[0] - 1;
                if(a[0]== 2)
                {
                    Console.WriteLine(1);
                    return;
                }
                pushed[0] = true;
                ans = 1;
            }
            if(pushed[next])
            {
                Console.WriteLine(-1);
                return;
            }
            else if(a[next] == 2)
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
        for(int i = 0; i < charS.Length; i++)
        {
            
            if(charS[i] == 'B')
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
        for(int i = 1; i < a.Length; i++)
        {
            if(charS[i - 1] == '<')
            {
                leftCount++;
            }
            else
            {
                leftCount = 0;
            }
            a[i] = Math.Max(a[i], leftCount);
        }
        for(int i = a.Length - 2; i >= 0; i--)
        {
            if(charS[i] == '>')
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
        var list = new int[]{1,2,3,4,5};
        var count = 0;
        int id = 4;
        var ans = 0;
        while(X != 0 || id >= 0)
        {
            count += X/list[id];
            X %= list[id];
            if(count * 100 > max)
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
        for(int i = 0; i < NL[0]; i++)
        {
            list.Add(Console.ReadLine());
        }
        list = list.OrderBy(x => x).ToList();
        String ans = "";
        for(int i = 0; i < list.Count(); i++)
        {
            ans += list[i];
        }
        Console.WriteLine(ans);
    }
    public static void ABC097_B()
    {
        int X = int.Parse(Console.ReadLine());
        var ans = 1;
        for(int i = 2; i <= 100; i++)
        {
            int p = 2;
            while(Math.Pow(i, p) <= X)
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

        if(charN[0] - '0' != 9)
        {
            for(int i = 0; i < charN.Length; i++)
            {
                ans += charN[i] - '0';
            }
            ans = Math.Max(ans, (charN[0] - '0' - 1) + (charN.Length - 1) * 9); 
            
        }
        else
        {
            for(int i = 0; i < charN.Length; i++)
            {
                ans += charN[i] - '0';
            }
            if(charN.Length > 1)
            {
                ans = Math.Max(ans, 8 + 9*(charN.Length - 1));
            }
        }
        Console.WriteLine(ans);
    }
    public static void ABC115_C()
    {
        var NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var h = new long[NK[0]];
        for(int i = 0; i < NK[0]; i++)
        {
            h[i] = long.Parse(Console.ReadLine());
        }
        Array.Sort(h);
        long min = longMax;
        for(int i = 0; i <= NK[0] - NK[1]; i++)
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
        for(int i = 0; i < NM[1]; i++)
        {
            var read = Console.ReadLine().Split();
            if(read[1] == "WA")
            {
                if(!submit.ContainsKey(read[0]))
                {
                    submit.Add(read[0],(0,1));
                }
                else
                {
                    if(submit[read[0]].Item1 != 1)
                        submit[read[0]] = (submit[read[0]].Item1,submit[read[0]].Item2 + 1);
                }
            }
            else
            {
                if(!submit.ContainsKey(read[0]))
                {
                    submit.Add(read[0],(1,0));
                }
                else
                {
                    submit[read[0]] = (1,submit[read[0]].Item2);
                }
            }
        }
        foreach(var value in submit.Values)
        {
            if(value.Item1 == 1)
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
        while(read[2] <= read[1])
        {
            if(read[0] <= read[2] && read[2] <= read[1])
            {
                ans = read[2];
                break;
            }
            read[2] *= p;
            p++;
        }
        if(ans == 0) Console.WriteLine(-1);
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
        for(int i = A.Length - 1; i >= 0; i--)
        {
            ka += (int)Math.Pow(k,i)*(A[(A.Length-1)-i] - '0');
        }
        for(int i = B.Length - 1; i >= 0; i--)
        {
            kb += (int)Math.Pow(k,i)*(B[(B.Length-1)-i] - '0');
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
        long d = X/sum;
        long ans = d * count;
        long r = X % sum;
        long temp = 0;
        long id = 1;
        while(r >= temp)
        {
            temp += A[id - 1];
            id++;
        }
        ans += (id-1);
        Console.WriteLine(ans);
    }
    public static void ABC220_D()
    {
        int N = int.Parse(Console.ReadLine());
        var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var list = new List<int>();
        list.AddRange(A);
        var dp = new long[N + 1, 10, 10];
        dp[0,A[0],A[1]] = 1;
        long mod = 998244353;
        for(int i = 0; i < N; i++)
        {
            for(int j = 0; j < 10; j++)
            {
                for(int k = 0; k < 10; k++)
                {
                    if(i + 2 < A.Length)
                    {
                        dp[i + 1,(j + k)%10,A[i + 2]] += dp[i, j, k];
                        dp[i + 1,(j + k)%10,A[i + 2]] %= mod;
                        dp[i + 1,(j * k)%10,A[i + 2]] += dp[i, j, k];
                        dp[i + 1,(j * k)%10,A[i + 2]] %= mod;
                    }
                    else
                    {
                        dp[i + 1,(j + k)%10,0] += dp[i, j, k];
                        dp[i + 1,(j + k)%10,0] %= mod;
                        dp[i + 1,(j * k)%10,0] += dp[i, j, k];
                        dp[i + 1,(j * k)%10,0] %= mod;
                    }
                    
                }
            }
        }
        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine(dp[N - 1,i,0]);
        }
    }
    public static void AGC012_A()
    {
        int N = int.Parse(Console.ReadLine());
        var a = Console.ReadLine().Split().Select(long.Parse).ToArray();
        Array.Sort(a);
        long ans = 0;
        for(int i = N; i < 3 * N; i += 2)
        {
            ans += a[i];
        }
        Console.WriteLine(ans);
    }
    public static  void AGC041_A()
    {
        var NAB = Console.ReadLine().Split().Select(long.Parse).ToArray();
        long ans = 0;
        if(Math.Abs(NAB[1] - NAB[2]) % 2 == 0)
        {
            ans = Math.Abs(NAB[1] - NAB[2])/2;
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
        for(long i = 1; i <= Math.Sqrt(N); i++)
        {
            if(N % i == 0)
            {
                min = Math.Min(min, i + N/i);
            }   
        }
        long ans = min- 2;
        Console.WriteLine(ans);
    }
    public static void ABC100_C()
    {
        int N = int.Parse(Console.ReadLine());
        var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
        long ans = 0;
        for(int i = 0; i < a.Length; i++)
        {
            while(a[i] % 2 == 0)
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
        if(list[0] > read[3]/2)
        {
            ans += N/2 * read[3];
            if(N % 2 != 0)
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
        for(int i = 0; i < N; i++)
        {
            int temp = 0;
            int sum = 0;
            while(temp <= i)
            {
                sum += A[temp];
                temp++;
            }
            for(int j = i; j < N; j++)
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
        if(DN[1] % 100 != 0)
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
        if(charS.Length >= K)
        {
            for(int i = 0; i < K; i++)
            {
                if(charS[i] != '1')
                {
                    break;
                }
                else if(i == K - 1)
                {
                    ans = '1';
                    Console.WriteLine(ans);
                    return;
                }
            }
        }
        for(int i = 0; i < charS.Length; i++)
        {
            if(charS[i] != '1')
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
            while(r != 0)
            {
                tempD = tempC;
                tempC = r;
                r = tempD % tempC;
            }
            var CD = (long)Math.Floor(((decimal)C * D) / tempC);
            return CD;
        }
        long ans = 0;
        gcd(1 , 2);
        for(int i = 0; i < a.Length; i++)
        {
            ans += a[i] - 1;
        }
        Console.WriteLine(ans);
    }
    public static void ABC091_B()
    {
        int N = int.Parse(Console.ReadLine());
        var blueList = new Dictionary<String, int>();
        for(int i = 0; i < N; i++)
        {
            var temp = Console.ReadLine();
            if(!blueList.ContainsKey(temp))
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
        for(int j = 0; j < M; j++)
        {
            var temp = Console.ReadLine();
            if(!redList.ContainsKey(temp))
            {
                redList.Add(temp, 1);
            }
            else
            {
                redList[temp]++;
            }
        }
        long ans = 0;
        foreach(var key in blueList.Keys)
        {
            int plus = 0;
            int minus = 0;
            plus = blueList[key];
            if(redList.ContainsKey(key))
            {
                minus = redList[key];
            }
            ans = Math.Max(ans , plus - minus);
        }
        Console.WriteLine(ans);

    }
    public static void ARC088_C()
    {
        var XY = Console.ReadLine().Split().Select(long.Parse).ToArray();
        long temp = XY[0];
        long count = 1;
        while(temp <= XY[1]/2)
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
        for(int i = 2; i <= N; i++)
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
        for(int i = 0; i < charS.Length; i++)
        {
            if(charS[i] == '0')
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

        for(int i = 0; i < N; i++)
        {
            sum[i + 1] = sum[i] + A[i];
        }
        long ans = longMax;
        for(int i = 0; i < N; i++)
        {
            ans = Math.Min(ans, Math.Abs((sum[N] - sum[i]) - sum[i]));
        }
        Console.WriteLine(ans);
    }
    public static void ABC079_C()
    {
        var ABCD = Console.ReadLine().ToCharArray();
        var ans = new bool[3];
        for(int i = 0; i < 1 << 3; i++)
        {
            var bit = new bool[3];
            int sum = ABCD[0] - '0';
            for(int j = 0; j < 3; j++)
            {
                if(((i >> j) & 1) == 1)
                {
                    bit[j] = true;
                }
            }
            for(int j = 0; j < 3; j++)
            {
                if(bit[j])
                {
                    sum += ABCD[j + 1] - '0';
                }
                else
                {
                    sum -= ABCD[j + 1] - '0';
                }
            }
            if(sum == 7)
            {
                ans = bit;
                break;
            }
        }
        for(int i = 0; i < 4; i++)
        {
            Console.Write($"{ABCD[i]}");
            if(i != 3)
            {
                if(ans[i])Console.Write("+");
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

        if(read[1] % 2 != read[0] % 2)
        {
            read[1]++;
            read[2]++;
            ans++;
        }
        ans += (read[1] - read[0])/2;
        ans += read[2] - read[1];
        Console.WriteLine(ans);
    }
    public static void codefes2017_C()
    {
        int N = int.Parse(Console.ReadLine());
        var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
        long sum = 1;
        long except = 1;
        for(int i = 0; i < A.Length; i++)
        {
            if(A[i] % 2 == 0)except *= 2;
            sum *= 3;
        }

        long ans = sum - except;
        Console.WriteLine(ans);
    }
    public static void ABC121_C()
    {
        var NM = Console.ReadLine().Split().Select(long.Parse).ToArray();
        var list = new List<(long, long)>();
        for(int i = 0; i < NM[0]; i++)
        {
            var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
            list.Add((read[0], read[1]));
        }
        list = list.OrderBy(x => x.Item1).ToList();
        long temp = 0;
        long ans = 0;
        foreach(var l in list)
        {
            if(l.Item2 + temp >= NM[1])
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
        if(ABC[0] % 2 == 0 || ABC[1] % 2 == 0 || ABC[2] % 2 == 0)
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
            while(n > 0)
            {
                if((n & 1) > 0) ret *= x;
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
        for(int i = 0; i < N; i++)
        {
            if(a[a[i] - 1] - 1 == i)
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
        for(int i = 2; i < charS.Length; i += 2)
        {
            bool ok = true;
            for(int j = 0; j < (charS.Length - i)/2; j++)
            {
                if(charS[j] != charS[j + (charS.Length - i) / 2]) ok = false;
            }
            if(ok) ans = Math.Max(ans, charS.Length - i);
        }
        Console.WriteLine(ans);
    }
    public static void ABC075_B()
    {
        var HW = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var S = new char[HW[0]][];
        for(int i = 0; i < HW[0]; i++)
        {
            S[i] = Console.ReadLine().ToCharArray();
        }
        var dx = new int[]{-1, 0, 1};
        var dy = new int[]{-1, 0, 1};
        for(int i = 0; i < HW[0]; i++)
        {
            for(int j = 0; j < HW[1]; j++)
            {
                var count = 0;
                if(S[i][j] == '.')
                {
                    foreach(var x in dx)
                    {
                        foreach(var y in dy)
                        {
                            if(x == 0 && y == 0) continue;
                            if(j + x >= 0 && j + x <= HW[1] - 1 && i + y >= 0 && i + y <= HW[0] - 1)
                            {
                                if(S[i + y][j + x] == '#')
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
        for(int i = 0; i < HW[0]; i++)
        {
            for(int j = 0; j < HW[1]; j++)
            {
                if(j == HW[1] - 1)
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
        if(new String(charS) == new String(charT)) ok = true;
        for(int i = 0; i < charT.Length - 1; i++)
        {
            var temp = new char[charT.Length];
            Array.Copy(charT, temp, charT.Length);
            var t = temp[i + 1];
            temp[i + 1] = temp[i];
            temp[i] = t;
            if(new String(charS) == new String(temp)) ok = true;
        }
        if(ok)Console.WriteLine("Yes");
        else Console.WriteLine(("No"));
    }
    public static void ABC221_C()
    {
        var charN = Console.ReadLine().ToCharArray();
        Array.Sort(charN);
        Array.Reverse(charN);
        long ans = 0;
        for(int i = 1; i < 1 << charN.Length; i++)
        {
            long tempA = 0;
            long tempB = 0;
            for(int j = 0; j < charN.Length; j++)
            {
                if(((i >> j) & 1) == 1)
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
        for(int i = 0; i < N; i++)
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
        while(outINdex < logout.Count)
        {
            if(login[inINdex] == logout[outINdex])
            {
                num[count] += login[inINdex] - now;
                now = login[inINdex];
                inINdex++;
                outINdex++;

            }
            else if(login[inINdex] < logout[outINdex])
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
        for(int i = 1; i < N + 1; i++)
        {
            if(i != N) Console.Write($"{num[i]} ");
            else Console.WriteLine(num[i]);
        }
        
    }
    public static void ABC098_B()
    {
        int N = int.Parse(Console.ReadLine());
        var S = Console.ReadLine();
        var ans = 0;
        for(int i = 0; i < N - 1; i++)
        {
            var a = S[0 .. i];
            var b = S[i .. N];
            var list = new List<char>();
            var temp = 0;
            for(int j = 0; j < a.Length; j++)
            {
                if(!list.Contains(a[j]))
                {
                    list.Add(a[j]);
                }    
            }
            for(int j = 0; j < b.Length; j++)
            {
                if(list.Contains(b[j]))
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
        for(int i = 0; i < a.Length; i++)
        {
            a[i] /= 400;
            if(a[i] == 0)
            {
                if(!list.ContainsKey("gray"))
                {
                    list.Add("gray", 1);
                }
            }
            else if(a[i] == 1)
            {
                if(!list.ContainsKey("brown"))
                {
                    list.Add("brown", 1);
                }
            }
            else if(a[i] == 2)
            {
                if(!list.ContainsKey("green"))
                {
                    list.Add("green", 1);
                }
            }
            else if(a[i] == 3)
            {
                if(!list.ContainsKey("water"))
                {
                    list.Add("water", 1);
                }
            }
            else if(a[i] == 4)
            {
                if(!list.ContainsKey("blue"))
                {
                    list.Add("blue", 1);
                }
            }
            else if(a[i] == 5)
            {
                if(!list.ContainsKey("yellow"))
                {
                    list.Add("yellow", 1);
                }
            }
            else if(a[i] == 6)
            {
                if(!list.ContainsKey("orange"))
                {
                    list.Add("orange", 1);
                }
            }
            else if(a[i] == 7)
            {
                if(!list.ContainsKey("red"))
                {
                    list.Add("red", 1);
                }
            }
            else if(a[i] >= 8)
            {
                if(!list.ContainsKey("all"))
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
        foreach(var l in list)
        {
            if(l.Key != "all")
            {
                max += l.Value;
                min++;
            }
        }
        if(list.ContainsKey("all"))
        {
            max += list["all"];
            if(list.Count == 1)
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
        while(true)
        {
            temp = A % ABC[1];
            if(seen[temp])
            {
                Console.WriteLine("NO");
                return;
            }
            else if(temp == ABC[2])
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

        for(int j = 0; j < a.Length; j++)
        {
            numbers[a[j] + 1]++;
            numbers[a[j]]++;
            if(a[j] > 0)
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
        for(int i = 0; i < NM[0]; i++)
        {
            var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            students[i] = (read[0], read[1]);
        }
        for(int i = 0; i < NM[1]; i++)
        {
            var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            points[i] = (read[0], read[1]);
        }
        var ans = new int[NM[0]];
        for(int i = 0; i < NM[0]; i++)
        {
            int temp = intMax;
            for(int j = 0; j < NM[1]; j++)
            {
                if(temp > Math.Abs(students[i].Item1 - points[j].Item1) + Math.Abs(students[i].Item2 - points[j].Item2))
                {
                    temp = Math.Abs(students[i].Item1 - points[j].Item1) + Math.Abs(students[i].Item2 - points[j].Item2);
                    ans[i] = j + 1;
                }
            }
        }
        for(int i = 0; i < NM[0]; i++)
        {
            Console.WriteLine(ans[i]);
        }
    }
    public static  void ABC155_C()
    {
        int N = int.Parse(Console.ReadLine());
        var list = new Dictionary<String, int>();
        var max = 0;
        for(int i = 0; i < N; i++)
        {
            var read = Console.ReadLine();
            if(!list.ContainsKey(read))
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
        foreach(var l in list)
        {
            if(max == 0)
            {
                ans.Add(l.Key);
                continue;
            }
            if(l.Value == max)
            {
                ans.Add(l.Key);
            }
        }
        ans = ans.OrderBy(x => x).ToList();
        foreach(var l in ans)
        {
            Console.WriteLine(l);
        }
    }
    public static void ABC107_B()
    {
        var HW = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var fields = new char[HW[0]][];
        for(int i = 0; i < HW[0]; i++)
        {
            fields[i] = Console.ReadLine().ToCharArray();
        }
        var removeH = new List<int>();
        var removeW = new List<int>();
        for(int i = 0; i < HW[0]; i++)
        {
            var ok = true;
            for(int j = 0; j < HW[1]; j++)
            {
                if(fields[i][j] == '#')
                {
                    ok = false;
                }
            }
            if(ok) removeH.Add(i);
        }
        for(int i = 0; i < HW[1]; i++)
        {
            var ok = true;
            for(int j = 0; j < HW[0]; j++)
            {
                if(fields[j][i] == '#')
                {
                    ok = false;
                }
            }
            if(ok) removeW.Add(i);
        }
        var result = new List<List<char>>();
        int temp = 0;
        for(int i = 0; i < HW[0]; i++)
        {
            if(removeH.Contains(i))continue;
            result.Add(new List<char>());
            for(int j = 0; j < HW[1]; j++)
            {
                if(removeW.Contains(j))continue;
                result[temp].Add(fields[i][j]);
            }
            temp++;
        }
        foreach(var h in result)
        {
            int count = 0;
            foreach(var w in h)
            {
                if(count == h.Count() - 1)
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
        for(int i = 0; i < N; i++)
        {
            var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            list.Add((read[0], read[1], read[2]));
        }
        var ok = true;
        (int min, int x, int y) now = (0, 0, 0);
        for(int i = 0; i < list.Count(); i++)
        {
            var dif = Math.Abs(list[i].x - now.x) + Math.Abs(list[i].y - now.y);
            var difTime = Math.Abs(list[i].min - now.min);
            if(dif > difTime)
            {
                ok = false;
                break;
            }
            else if(dif % 2 == 0 && difTime % 2 == 1)
            {
                ok = false;
                break;
            }
            else if(dif % 2 == 1 && difTime % 2 == 0)
            {
                ok = false;
                break;
            }
            now = (list[i].min, list[i].x, list[i].y);
        }
        if(ok) Console.WriteLine("Yes");
        else Console.WriteLine("No");
    }
    public static void ABC096_C()
    {
        var HW = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var fields = new char[HW[0]][];
        for(int i = 0; i < HW[0]; i++)
        {
            fields[i] = Console.ReadLine().ToCharArray();
        }
        var x = new int[]{-1, 0, 1};
        var y = new int[]{-1, 0, 1};
        var ok = true;
        for(int i = 0; i < HW[0]; i++)
        {
            for(int j = 0; j < HW[1]; j++)
            {
                if(fields[i][j] == '#')
                {
                    var check = false;
                    foreach(var dx in x)
                    {
                        foreach(var dy in y)
                        {  
                            if((dx == 1 && dy == 1 ) ||  (dx == -1 && dy == 1 ) ||  (dx == 1 && dy == -1 ) ||  (dx == -1 && dy == -1 ) ||  (dx == 0 && dy == 0 ))
                            {
                                continue;
                            }
                            if(i + dy >= 0 && i + dy <= HW[0] - 1 && j + dx >= 0 && j + dx <= HW[1] - 1)
                            {
                                if(fields[i + dy][j + dx] == '#')
                                {
                                    check = true;
                                }
                            }
                            
                        }
                    }
                    if(check == false)
                    {
                        Console.WriteLine("No");
                        return;
                    }
                }
                
            }
        }
        if(ok)Console.WriteLine("Yes");
    }
    public static void keyence2019_B()
    {
        var S = Console.ReadLine();
        for(int i = 0; i < S.Length; i++)
        {
            for(int j = i; j < S.Length; j++)
            {
                String temp = "";
                temp += S.Substring(0, i);
                temp += S.Substring(j, S.Length - j);
                if(temp == "keyence")
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
        for(int i = 0; i < N; i++)
        {
            s[i] = int.Parse(Console.ReadLine());
            sum += s[i];
        }
        if(sum % 10 != 0)
        {
            Console.WriteLine(sum);
        }
        else
        {
            int min = intMax;
            for(int i = 0; i < N; i++)
            {
                if(s[i] % 10 != 0)
                {
                    min = Math.Min(min, s[i]);
                }
            }
            if(min != intMax)
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
        while(N.Length != 4)
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
        for(int i = 0; i < NP[0]; i++)
        {
            if(a[i] < NP[1])
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
        for(int i = 0; i < 2 * NM[0]; i++)
        {
            score[i] = (i, 0);
           a[i] = Console.ReadLine().ToCharArray();
        }
        for(int i = 0; i < NM[1]; i++)
        {
            for(int j = 0; j < 2 * NM[0]; j += 2)
            {
                if(a[score[j].Item1][i] == 'G' && a[score[j + 1].Item1][i] == 'P' || a[score[j].Item1][i] == 'P' && a[score[j + 1].Item1][i] == 'C' || a[score[j].Item1][i] == 'C' && a[score[j + 1].Item1][i] == 'G')
                {
                    score[j + 1].Item2++;
                }
                else if(a[score[j + 1].Item1][i] == 'G' && a[score[j].Item1][i] == 'P' || a[score[j + 1].Item1][i] == 'P' && a[score[j].Item1][i] == 'C' || a[score[j + 1].Item1][i] == 'C' && a[score[j].Item1][i] == 'G')
                {
                    score[j].Item2++;
                }    
            }
            score = score.ToList().OrderByDescending(x => x.Item2).ThenBy(x => x.Item1).ToArray();
        }
        for(int i = 0; i < score.Length; i++)
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
        var dp = new long[N  + 1,max + 1];
        dp[0, 0] = 1;
        for(int i = 0; i < N; i++)
        {
            for(int j = 0; j < max; j++)
            {
                //i番目jまでの累積和を計算しておく
                dp[i,j + 1] += dp[i,j]; 
            }
            for(int j = a[i]; j <= b[i]; j++)
            {
                //上で累積和を計算しているのでこれを利用してO(1)でi+1のjを更新可能
                dp[i + 1, j] += dp[i, j];
                dp[i + 1, j] %= mod;
            } 
        }
        long ans = 0;
        for(int i = 0; i <= max; i++)
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
        for(int i = 0; i < t.Length - 1; i++)
        {
            ans += Math.Min(t[i + 1] - t[i], NT[1]);
        }
        ans += NT[1];
        Console.WriteLine(ans);
    }
    public static void ABC088_C()
    {
        var grid = new int[3,3];
        for(int i = 0; i < 3; i++)
        {
            var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            for(int j = 0; j < 3; j++)
            {
                grid[i, j] = read[j];
            }
        }
        for(int i = 0; i <= 100; i++)
        {
            for(int j = 0; j <= 100; j++)
            {
                for(int k = 0; k <= 100; k++)
                {
                    var tempB = new int[]{grid[0,0] - i, grid[0, 1] - i, grid[0, 2] - i};
                    bool ok = true;
                    for(int l = 1; l < 3; l++)
                    {
                        if(l == 1 && (tempB[0] != grid[l,0] - j || tempB[1] != grid[l, 1] - j || tempB[2] != grid[l, 2] - j))
                        {
                            ok = false;
                        }
                        else if(l == 2 &&  (tempB[0] != grid[l,0] - k || tempB[1] != grid[l, 1] - k || tempB[2] != grid[l, 2] - k))
                        {
                            ok = false;
                        }
                    }
                    if(ok)
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
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == 'N')
            {
                N++;
            }
            else if(s[i] == 'S')
            {
                S++;
            }
            else if(s[i] == 'W')
            {
                W++;
            }
            else if(s[i] == 'E')
            {
                E++;
            }
        }
        if(N != 0 && S == 0 || N == 0 && S != 0 || E != 0 && W == 0 || E == 0 && W != 0)
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
        for(int i = 0; i <= read[3]/read[0]; i++)
        {
            for(int j = 0; j <= (read[3] - i * read[0])/read[1]; j++)
            {
                if((read[3] - i * read[0] - j * read[1]) % read[2] == 0)
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
        for(int i = 0; i < N; i++)
        {
            var read = long.Parse(Console.ReadLine());
            
            if(A.ContainsKey(read))
            {
                A[read]++;
            }
            else
            {
                A.Add(read, 1);
            }
        }
        var count = 0;
        foreach(var a in A)
        {
            if(a.Value % 2 != 0)
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
        
        for(int i = 0; i < N; i++)
        {
            list[A[i]]++;
        }
        long all = 0;
        for(int i = 0; i <= N; i++)
        {
            if(list[i] > 0)
                all += list[i] * (list[i] - 1) / 2;
        }
        for(int i = 0; i < N; i++)
        {
            long ans = 0;
            if(A[i] > 0)
                ans = all - (list[A[i]] - 1);
            Console.WriteLine(ans);
        }
    }
    public static void ABC053_B()
    {
        var s = Console.ReadLine().ToCharArray();
        int indexA = intMax;
        int indexZ = 0;
        for(int i = 0; i < s.Length; i++)
        {    
            if(s[i] == 'A')
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
        for(int i = 0; i < NM[1]; i++)
        {
            var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            sc[i].Item1 = read[0];
            sc[i].Item2 = read[1];
            max = Math.Max(max, sc[i].Item1);
        }
        int ans = intMax;
        for(int i = 0; i < 1000; i++)
        {
            bool ok = true;
            var charI = Convert.ToString(i).ToCharArray();
            if(charI.Length != NM[0])ok = false;
            for(int j = 0; j < sc.Length; j++)
            {

                if(charI.Length >= sc[j].Item1  && sc[j].Item2 != (charI[sc[j].Item1 - 1] - '0'))
                {
                    ok = false;
                }

            }
            if(ok) ans = Math.Min(ans, i);
        }
        if(ans == intMax) ans = -1;
        Console.WriteLine(ans);
    }
    public static void AGC015_A()
    {
        var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
        long ans = 0;
        if((read[0] != 1 && read[1] <= read[2]) || (read[0] == 1 && read[1] == read[2]))
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
        for(int i = 0; i < N - 1; i++)
        {
            if(gold == true && v[i] > v[i + 1])
            {
                ans.Append("1 ");
                gold = false;
            }
            else if(i >= 1 && gold == false && v[i] <= v[i + 1])
            {
                ans.Append("1 ");
                gold = true;
            }
            else
            {
                ans.Append("0 ");
            }
        }
        if(gold == false)
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
        for(int i = 0; i < T; i++)
        {
            var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
            Array.Sort(read);
            long count = longMax;
            var ok = false;

            if((read[1] - read[0]) % 3 == 0)
            {
                ok = true;
                count = Math.Min(count, read[1]);
            }
            if((read[2] - read[0]) % 3 == 0 )
            {
                ok = true;
                count = Math.Min(count, read[2]);
            }
            if((read[2] - read[1]) % 3 == 0)
            {
                ok = true;
                count = Math.Min(count,read[2]);
            }
            if(ok)Console.WriteLine(count);
            else Console.WriteLine(-1);
        }
    }
    public static void ARC086_C()
    {
        var NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var list = new Dictionary<int, int>();
        for(int i = 0; i < NK[0]; i++)
        {
            if(list.ContainsKey(A[i]))
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
        if(now > NK[1])
        {
            foreach(var l in list)
            {
                ans += l.Value;
                now--;
                if(now == NK[1]) break;
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
        for(int i = 0; i < N; i++)
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
        while(burnA < time)
        {
            burnA += A[index]/(double)B[index];
            if(index > 0) 
            {
                pretime += A[index - 1]/(double)B[index - 1];
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
        for(int i = 0; i < N; i++)
        {
            var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
            list.Add((read[0], read[1]));
        }
        long left = 0;
        long right = longMax;
        var t = new long[N];
        while(right - left > 1)
        {
            long mid = (right + left) / 2;
            bool ok = true;
            for(int i = 0; i < N; i++)
            {
                if(mid < list[i].Item1) ok = false;
                else t[i] = (mid - list[i].Item1) / list[i].Item2;
            }
            Array.Sort(t);
            for(int i = 0; i < N; i++)
            {
                if(t[i] < i) ok = false;
            }
            if(ok) right = mid;
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
        while(index <= O.Length || index <= E.Length)
        {
            if(index < O.Length)
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
        for(int i = 0; i < N; i++)
        {
            if(a[i] == now + 1)
            {
                now++;
            }
        }
        int ans = 0;
        if(now != 0)
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
        for(int i = 0; i < NM[0]; i++)
        {
            graph.Add(new List<int>());
        }
        var indeg = new int[NM[0]];
        for(int i = 0; i < NM[1]; i++)
        {
            var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            A[i] = read[0] - 1;
            B[i] = read[1] - 1;
            graph[A[i]].Add(B[i]);
            indeg[B[i]]++;
        }
        var heap = new PriorityQueue<int>(NM[0], Comparer<int>.Create((x, y) => (y - x)));
        for(int i = 0; i < NM[0]; i++)
        {
            if(indeg[i] == 0)
            {
                heap.Push(i);
            }
        }
        var ans = new List<int>();
        while(heap.Count != 0)
        {
            int i = heap.Pop();
            ans.Add(i);
            foreach(var l in graph[i])
            {
                indeg[l]--;
                if(indeg[l] == 0)
                {
                    heap.Push(l);
                }
            }
        }
        if(ans.Count != NM[0])
        {
            Console.WriteLine(-1);
        }
        else
        {
            for(int i = 0; i < NM[0]; i++)
            {
                if(i == NM[0] - 1)
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
        if(N == 1)
        {
            Console.WriteLine(1);
            return;
        }
        int index = 0;
        while(index < N - 1)
        {
            int tempUp = index;
            int tempDown = index;

            while(tempUp != N - 1 && A[tempUp] <= A[tempUp + 1])
            {
                tempUp++;
            }
            while(tempDown != N - 1 && A[tempDown] >= A[tempDown + 1])
            {
                tempDown++;
            }
            count++;
            index = Math.Max(tempDown, tempUp) + 1;
        }
        if(index < N)count++;
        Console.WriteLine(count);
    }
    public static void AGC006_A()
    {
        int N = int.Parse(Console.ReadLine());
        var s = Console.ReadLine();
        var t = Console.ReadLine();
        int ans = s.Length + t.Length;
        var temp = 0;
        for(int i = 0; i < Math.Min(s.Length, t.Length); i++)
        {
            bool ok = true;
            for(int j = 0; j <= i; j++)
            {
                if(s[s.Length - 1 - i + j] != t[j])
                {
                    ok = false;
                }
            }
            if(ok) temp = Math.Max(temp, i + 1);
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
        for(int i = 1; i <= NK[0]; i++)
        {
            sum[i] = sum[i - 1] + (((double)p[i - 1] + 1) * (p[i - 1])) / 2 / p[i - 1];   
        }
        for(int i = 0; i < NK[0] - (NK[1] - 1); i++)
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
        for(int i = 0; i < Math.Min(s.Length, t.Length); i++)
        {
            if(((t[i] - 'a') - (s[i] - 'a')) < 0)
            {
                ok = false;
                equal = false;
                break;
            }
            else if(((t[i] - 'a') - (s[i] - 'a')) > 0)
            {
                equal = false;
                break;
            }
        }
        if(!ok)
        {
            Console.WriteLine("No");
        }
        else if(ok && equal && s.Length >= t.Length)
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
        if(NM[0] == 1 && NM[1] == 1)
        {
            ans = 1;
        }
        else if(NM[0] == 1)
        {
            ans = Math.Max(0, NM[1] - 2);
        }
        else if(NM[1] == 1)
        {
            ans = Math.Max(0, NM[0] - 2);
        }
        else
        {
            ans = Math.Max(0,NM[0] * NM[1] - ((NM[1] - 2) * 2 + NM[0] * 2));
        }
        Console.WriteLine(ans);
    }
    public static void ARC080_C()
    {
        int N = int.Parse(Console.ReadLine());
        var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int not2 = 0;
        int ok4 = 0;
        for(int i = 0; i < N; i++)
        {
            if(a[i] % 2 != 0)
            {
                not2++;
            }
            else if(a[i] % 4 == 0)
            {
                ok4++;
            }
        }
        if(ok4 >= not2)
        {
            Console.WriteLine("Yes");
        }
        else if(ok4 == (not2 - 1) && (ok4 + not2) == N)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
    public static void  ABC085_C()
    {
        var NY = Console.ReadLine().Split().Select(long.Parse).ToArray();
        long max = NY[0] * 10000;
        long dx = max - NY[1];
        long count5 = 0;
        long count1 = 0;
        bool ok = false;
        for(int i = 0; i <= dx / 5000; i++)
        {
            if((dx - 5000 * i) % 9000 == 0)
            {
                count1 = (dx - 5000 * i) / 9000;
                count5 = i;
                if(count1 + count5 <= NY[0])
                {
                    ok = true;
                    break;
                }
            }
        }
        if(ok)
        {
            Console.WriteLine($"{NY[0] - count5 - count1} {count5} {count1}");
        }
        else if(dx == 0)
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
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] != 'B')
            {
                ans.Add(s[i]);
            }
            else
            {
                if(ans.Count > 0)
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
        ans += (NK[0] - 1)/(NK[1] - 1);
        if((NK[0] - 1) % (NK[1] - 1) != 0)
        {
            ans++;
        }
        Console.WriteLine(ans);
    }
    public static void ABC224_A()
    {
        var S = Console.ReadLine();
        var er = S.Substring(S.Length - 2, 2);
        if(er == "er")
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
        for(int i = 0; i < HW[0]; i++)
        {
            var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
            
            for(int j = 0; j < HW[1]; j++)
            {
                fields[i,j] = read[j];
            }
        }
        for(int i = 0; i < HW[0]; i++)
        {
            
            for(int j = i + 1; j < HW[0]; j++)
            {
                for(int l = 0; l < HW[1]; l++)
                {
                    for(int m = l + 1; m < HW[1] ;m++ )
                    {
                        if(fields[i,l] + fields[j,m] > fields[j,l] + fields[i,m])
                        {
                            ok = false;
                        }
                    }
                }
                
            }
        }
        if(ok)
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
        for(int i = 0; i < N; i++)
        {
            var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            list[i] = (read[0], read[1]);
        }
        for(int i = 0; i < N - 2; i++)
        {
            for(int j = i + 1; j < N - 1; j++)
            {
                for(int k = j + 1; k < N; k++)
                {
                    long a = Math.Abs((list[j].Item1 - list[i].Item1) * (list[k].Item2 - list[i].Item2) - (list[j].Item2 - list[i].Item2) * (list[k].Item1 - list[i].Item1));
                    if(a > 0)
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
        for(int i = 0; i <= 9; i++)
        {
            graph.Add(new List<int>());
        }
        for(int i = 0; i < M; i++)
        {
            var　read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            graph[read[0]].Add(read[1]);
            graph[read[1]].Add(read[0]);
        }
        var p = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var s = new char[]{'9','9','9','9','9','9','9','9','9'};
        for(int i = 0; i < 8; i++)
        {
            s[p[i] - 1] = Convert.ToString(i + 1)[0];
        }
        String first = new string(s);
        var q = new Queue<String>();
        q.Enqueue(first);
        var dic = new Dictionary<String, int>();
        dic.Add(first,0);
        while(q.Count > 0)
        {
            String temp = q.Dequeue();
            int empI = -1;
            for(int i = 1; i <= 9; i++)
            {
                if(temp[i - 1] == '9') empI = i;
            }
            foreach(var u in graph[empI])
            {
                var t = temp.ToCharArray();
                t[empI - 1] = temp[u - 1];
                t[u - 1] = '9';
                String st = new string(t);
                if(dic.ContainsKey(st))continue;
                dic.Add(st, dic[temp] + 1);
                q.Enqueue(st);
            }
        }
        if(!dic.ContainsKey("123456789")) Console.WriteLine(-1);
        else Console.WriteLine(dic["123456789"]);
    }
    public static void ABC109_C()
    {
        var NX = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var x = Console.ReadLine().Split().Select(int.Parse).ToArray();
        if(NX[0] == 1)
        {
            Console.WriteLine(Math.Abs(NX[1] - x[0]));
            return;
        }
        long ans = gcd(Math.Abs(x[0] - NX[1]), Math.Abs(x[1] - NX[1]));
        for(int i = 2; i < NX[0]; i++)
        {
            ans = gcd(ans, Math.Abs(x[i] - NX[1]));
        }
        Console.WriteLine(ans);
        long gcd(long C, long D)
        {
            long tempC = C;
            long tempD = D;

            long r = tempD % tempC;
            while(r != 0)
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
        while(!allzero)
        {
            allzero = true;
            bool flag = false;
            for(int i = 0; i < N; i++)
            {
                if(h[i] != 0)
                {
                    allzero = false;
                    if(!flag)
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
        for(int i = 1; i <= ND[0]; i++)
        {
            two[i] = two[i - 1] * 2;
            two[i] %= mod;
        }
        for(int i = 1; i <= ND[0] ; i++)
        {
            int l = i - 1;
            int r = ND[1] - l;
            long leaf = 0;
            if(0 <= r && r <= i - 1)
            {
                leaf = (long)two[Math.Max(l - 1, 0)] * two[Math.Max(r - 1, 0)];
                leaf %= mod;
                if(l != r)
                {
                    leaf *= 2;
                    leaf %= mod;
                }
            }
            g[i] = g[i - 1] + leaf;
            g[i] %= mod;
        }
        for(int i = 1; i <= ND[0]; i++)
        {
            f[i] = f[i - 1] * 2;
            f[i] %= mod;
            f[i] +=  g[i];
            f[i] %= mod;
        }
        Console.WriteLine((f[ND[0]] * 2)%mod);
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
        for(int i = 0; i < N; i++)
        {
            if(set.ContainsKey(D[i]))
            {
                set[D[i]]++;
            }
            else
            {
                set.Add(D[i], 1);
            }
        }
        var ok = true;
        for(int i = 0; i < M; i++)
        {
            if(set.ContainsKey(T[i]))
            {
                if(set[T[i]] == 0)
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
        if(ok)Console.WriteLine("YES");
        else Console.WriteLine("NO"); 
    }
    public static void minna2019_C()
    {
        var KAB = Console.ReadLine().Split().Select(long.Parse).ToArray();
        long ans = 0;
        if(KAB[0] <= KAB[1])
        {
            ans = KAB[0] + 1;
        }
        else if(KAB[2] - KAB[1] >= 2)
        {
            ans += (Math.Max(0, KAB[0] - KAB[1] + 1)) / 2 * Math.Abs(KAB[2] - KAB[1]) + KAB[1];
            if(Math.Abs(KAB[0] - KAB[1] + 1) % 2 != 0)
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
        if(NM[0] >= NM[1])
        {
            Console.WriteLine(ans);
            return;
        }
        Array.Sort(X);
        var distance = new int[NM[1] - 1];
        for(int i = 0; i < NM[1] - 1; i++)
        {
            distance[i] = X[i + 1] - X[i];
        }
        Array.Sort(distance);
        ans = (X[NM[1] - 1] - X[0]);
        for(int i = 0; i < NM[0] - 1; i++)
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
        foreach(var a in alphabet)
        {
            int temp = 0;
            int cnt = 0;
            for(int i = 0; i < s.Length; i++)
            {
                if(s[i] == a)
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
        for(int i = 0; i < S.Length; i++)
        {
            if(S[i] == 'U')
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
        for(int i = 0; i < 1000000000; i++)
        {
            if((i + 1) * i/2 > X)
            {
                ans = i;
                break;
            }
            else if((i + 1) * i / 2 == X)
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
        for(int i = 0; i < HW[0]; i++)
        {
            C[i] = Console.ReadLine().ToCharArray();
        }
        for(int i = 0; i < HW[0]; i++)
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
        for(int i = 0; i < N; i++)
        {
            if(list.ContainsKey(A[i]))
            {
                list[A[i]]++;
            }   
            else
            {
                list.Add(A[i], 1);
            }
            if(list[A[i]] >= 2 && !edge.Contains(A[i]) || list[A[i]] == 4)
            {
                edge.Add(A[i]);
            }
            if(edge.Count() == 2)
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
        var ans  = new List<int>();
        if(n % 2 == 0)
        {
            ans.Add(a[0]);
            for(int i = 1; i < n; i++)
            {
                if(i % 2 == 1)
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
            for(int i = 1; i < n; i++)
            {
                if(i % 2 == 1)
                {
                    ans.Add(a[i]);
                }
                else
                {
                    ans.Insert(0, a[i]);
                }
            }
        }
        for(int i = 0; i < n; i++)
        {
            if(i != n - 1)
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
        temp = NM[1]/4;
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
        while(right - left > 1)
        {
            long mid = (right + left) / 2;
            bool ok = true;
            long cut = 0;
            long temp = 0;
            for(int i = 0; i < NL[0]; i++)
            {
                if(i == 0)temp = A[0];
                else temp += A[i] - A[i - 1];
                if(temp - pre >= mid)
                {
                    pre = A[i];
                    cut++;
                }
                if(cut == K && NL[1] - temp >= mid)
                {
                    break;
                }
                if((i == NL[0] - 1 && cut < K) || NL[1] - temp < mid)
                {
                    ok = false;
                }
            }
            if(ok) left = mid;
            else right = mid;
            pre = 0;
        }
        Console.WriteLine(left);
    }
    public static void typical90_002()
    {
        int N = int.Parse(Console.ReadLine());
        if(N % 2 != 0)
        {
            return;
        }
        String S = "(";
        void dfs(String s)
        {
            if(s.Length == N)
            {
                int left = 0;
                int right = 0;
                for(int i = 0; i < s.Length; i++)
                {
                    if(s[i] == '(')
                    {
                        left++;
                    }
                    else
                    {
                        right++;
                    }
                    if(right > left)
                    {
                        return;
                    }
                    if(i == s.Length - 1 && right != left)
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
        for(int i = 0; i < N + 1; i++)
        {
            graph.Add(new List<int>());
        }
        for(int i = 0; i < N - 1; i++)
        {
            var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            graph[read[0]].Add(read[1]);
            graph[read[1]].Add(read[0]);
        }
        var d = new int[N + 1];
        void bfs(int s)
        {
            for(int i = 0; i < N + 1; i++)
            {
                d[i] = intMax;
            }
            var q = new Queue<int>();
            q.Enqueue(s);
            d[s] = 0;
            int now;
            while(q.Count != 0)
            {
                now = q.Dequeue();
                foreach(var v in graph[now])
                {
                    if(d[v] == intMax)
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
        for(int i = 1; i <= N; i++)
        {
            if(d[i] == intMax) continue;
            if(tempMax < d[i])
            {
                tempMax = d[i];
                tempMaxV = i;
            }
        }
        bfs(tempMaxV);
        int max = 0;
        for(int i = 1; i <= N; i++)
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
        for(int i = 0; i < HW[0]; i++)
        {
            A[i] = Console.ReadLine().Split().Select(long.Parse).ToArray();
            for(int j = 0; j < HW[1]; j++)
            {
                rowSum[i] += A[i][j];
                colSum[j] += A[i][j];
            }
        }
        for(int i = 0; i < HW[0]; i++)
        {
            var s = new StringBuilder();
            for(int j = 0; j < HW[1]; j++)
            {
                if(j != HW[1] - 1)
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
        if(s[0] == s[1] && s[0] != s[2] || s[0] == s[2] && s[0] != s[1] || s[1] == s[2] && s[1] != s[0])
        {
            ans = 3;
        }
        else if(s[0] == s[1] && s[0] == s[2])
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
        for(int i = 0; i < N + 1; i++)
        {
            graph.Add(new List<int>());
        }
        for(int i = 0; i < N - 1; i++)
        {
            var　read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            graph[read[0]].Add(read[1]);
            graph[read[1]].Add(read[0]);
        }
        var ok = false;
        foreach(var g in graph)
        {
            var list = new List<int>();
            foreach(var v in g)
            {
                if(!list.Contains(v))
                list.Add(v);
            }
            if(list.Count() == N - 1)
            ok = true;
        }
        if(ok) Console.WriteLine("Yes");
        else Console.WriteLine("No");
    }
    public static void ABC225_C()
    {
        var NM = Console.ReadLine().Split().Select(long.Parse).ToArray();
        var B = new long[NM[0]][];
        for(int i = 0; i < NM[0]; i++)
        {
            B[i] = Console.ReadLine().Split().Select(long.Parse).ToArray();
        }
        var ok = true;
        if(NM[1] != 1 && NM[0] != 1){
            for(int i = 0; i < NM[0] - 1; i++)
            {
                for(int j = 0; j < NM[1] - 1; j++)
                {
                    if(B[i + 1][j] - B[i][j] != 7)
                    {
                        ok = false;
                    }
                    if(B[i][j + 1] - B[i][j] != 1 || B[i][j]%7 == 0)
                    {
                        ok = false;
                    }
                }
            }
        }
        else if(NM[0] ==1 && NM[1] == 1)
        {
            bool temp = false;
            for(int i = 1; i < 8; i++)
            {
                if((B[0][0] - i) % 7 == 0)
                {
                    temp = true;

                }
            }
            if(!temp) ok = false;
        }
        else if(NM[1] ==1)
        {
            for(int  i= 0; i < NM[0] - 1;i++ )
            {
                if(B[i + 1][0] - B[i][0] != 7)
                {
                    ok = false;
                }
            }
        }
        else if(NM[0] ==1)
        {
            for(int  i= 0; i < NM[1] - 1;i++ )
            {
                if(B[0][i + 1] - B[0][i] != 1 || B[0][i] % 7 == 0)
                {
                    ok = false;
                }
            }
        }
        
        if(ok) Console.WriteLine("Yes");
        else Console.WriteLine("No");

    }
    public static void ABC225_D()
    {
        var NQ = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var front = new int[NQ[0] + 1];
        var back = new int[NQ[0] + 1];
        for(int i = 0; i < NQ[1]; i++)
        {
            var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if(read[0] == 1)
            {
                front[read[2]] = read[1];
                back[read[1]] = read[2];
            }
            else if(read[0] == 2)
            {
                back[read[1]] = 0;
                front[read[2]] = 0;
            }
            else
            {
                int x = read[1];
                while(front[x] != 0)
                {
                    x = front[x];
                }
                var ans = new List<int>();
                ans.Add(x);
                while(back[x] != 0)
                {
                    ans.Add(back[x]);
                    x = back[x];
                }
                var sb = new StringBuilder();
                sb.Append($"{ans.Count()} ");
                for(int j = 0; j < ans.Count(); j++)
                {
                    if(j != ans.Count() - 1)
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
        var count = new Dictionary<char,int>();
        for(int i = 0; i < S.Length; i++)
        {
            if(!count.ContainsKey(S[i]))
            {
                count.Add(S[i], 1);
            }
            else
            {
                count[S[i]]++;
            }
        }
        bool ok = true;
        if(count.Count() == 1)
        {
            foreach(var a in count)
            {
                if(a.Value > 1)
                {
                    ok = false;
                }
            }
        }
        else if (count.Count() == 2)
        {
            foreach(var a in count)
            {
                if(a.Value > 1)
                {
                    ok = false;
                }
            }
        }
        else
        {
            
            if(Math.Abs(count.ElementAt(0).Value - count.ElementAt(1).Value) > 1 || Math.Abs(count.ElementAt(2).Value - count.ElementAt(1).Value) > 1 || Math.Abs(count.ElementAt(0).Value - count.ElementAt(2).Value) > 1)
            {
                ok = false;
            }
        }        
        if(ok)Console.WriteLine("YES");
        else Console.WriteLine("NO");
    }
    public static void ABC136_D()
    {
        var S = Console.ReadLine().ToCharArray();
        var count = new int[S.Length];
        int rCount = 0;
        int lCount = 0;
        for(int i = 0; i < S.Length; i++)
        {
            if(S[i] == 'R')
            {
                rCount++;
            }
            else if(rCount > 0 && S[i] == 'L')
            {
                int temp = 0;
                while(i + temp < S.Length && S[i + temp] != 'R')
                {
                    lCount++;
                    temp++;
                }
                count[i - 1] = (int)Math.Ceiling(rCount/(decimal)2) + lCount/2;
                count[i] = rCount/2 + (int)Math.Ceiling(lCount/(decimal)2);
                rCount = 0;
                lCount = 0;
            }
        }
        var sb = new  StringBuilder();
        for(int i = 0; i < S.Length; i++)
        {
            if(i != S.Length - 1)
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
        for(int i = 0; i < HW[0]; i++)
        {
            s[i] = Console.ReadLine().ToCharArray();
        }
        var dp = new int[HW[0], HW[1]];
        for(int i = 0; i < HW[0]; i++)
        {
            for(int j = 0; j < HW[1]; j++)
            {
                dp[i, j] = intMax;
            }
        }
        if(s[0][0] == '#')
        {
            dp[0, 0] = 1;
        }
        else
        {
            dp[0, 0] = 0;
        }
        for(int i = 0; i < HW[0]; i++)
        {
            for(int j = 0; j < HW[1]; j++)
            {
                if(i == 0 && j == 0) continue;
                int up = intMax;
                int left = intMax;
                if(i - 1 >= 0 && s[i - 1][j] == '.' && s[i][j] == '#')
                {
                    up = dp[i - 1, j]　+ 1;
                }
                else if(i - 1 >= 0)
                {
                    up = dp[i - 1, j];
                }
                if(j - 1 >= 0 && s[i][j - 1] == '.' && s[i][j] == '#')
                {
                    left = dp[i, j - 1]　+ 1;
                }
                else if ( j - 1 >= 0)
                {
                    left = dp[i, j - 1];
                }
                dp[i ,j] = Math.Min(up, left);
            }
        }
        Console.WriteLine(dp[HW[0] - 1, HW[1] - 1]);
    }
    public static void ABC048_B()
    {
        var abx = Console.ReadLine().Split().Select(long.Parse).ToArray();
        long ans = 0;
        if(abx[0] % abx[2] == 0)
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
        for(int i = 0; i < A.Length; i++)
        {
            pqueue.Push(A[i]);
        }
        for(int i = 1; i <= NM[1]; i++)
        {
            long temp = pqueue.Pop();
            sum -= (temp - temp/2);
            pqueue.Push(temp/2);
        }
        Console.WriteLine(sum);
    }
    public static void ABC076_C()
    {
        var S = Console.ReadLine().ToCharArray();
        var T = Console.ReadLine().ToCharArray();
        bool flag = false;
        if(T.Length == 1 && S.Length == 1 && S[0] == T[0])
        {
            flag = true;
        }
        for(int i = S.Length - 1; i >= 0; i--)
        {
            
            if(S[i] == '?' || S[i] == T[T.Length - 1])
            {
                int temp = 0;
                while(S[i - temp] == T[T.Length - 1 - temp] || S[i - temp] == '?')
                {
                    if(temp == T.Length - 1)
                    {
                        for(int j = i - temp; j <= i - temp + T.Length - 1; j++)
                        {
                            S[j] = T[j - (i - temp)];
                        }
                        flag = true;
                        break;
                    }
                    temp++;
                    if(flag || i - temp < 0)break;
                }
            }
            if(flag)break;
        }
        for(int i = 0; i < S.Length; i++)
        {
            if(S[i] == '?') S[i] = 'a';
        }
        if(flag)
        Console.WriteLine(new String(S));
        else Console.WriteLine("UNRESTORABLE");
    }
    public static void ABC103_B()
    {
        var S = Console.ReadLine().ToCharArray();
        var T = Console.ReadLine().ToCharArray();
        var flag = false;
        if(new String(S) == new string(T))flag = true;
        for(int i = 1; i <= S.Length; i++)
        {
            String temp = new String(S[(S.Length - i) .. (S.Length)]) + new String(S[0 .. (S.Length - i)]);
            if(temp == new String(T))
            {
                flag = true;
            }
        }
        if(flag)Console.WriteLine("Yes");
        else Console.WriteLine("No");
    }
    public static void ABC226_A()
    {
        double X = double.Parse(Console.ReadLine());
        int ans = (int)Math.Round(X,MidpointRounding.AwayFromZero);
        Console.WriteLine(ans);
    }
    public static void ABC226_B()
    {
        var N = long.Parse(Console.ReadLine());
        var dictionary = new Dictionary<String,int>();
        for(int i = 0; i < N; i++)
        {
            var read = Console.ReadLine();
            if(!dictionary.ContainsKey(read))
            {
                dictionary.Add(read,1);
            }
        }
        Console.WriteLine(dictionary.Count());
    }
    public static void ABC226_C()
    {
        var N = long.Parse(Console.ReadLine());
        var graph = new List<List<long>>();
        for(int i = 0; i < N; i++)
        {
            graph.Add(new List<long>());
        }
        var T = new long[N];
        for(int i = 0; i < N; i++)
        {
            var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
            T[i] = read[0];
            for(int j = 0; j < read[1]; j++)
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
            foreach(var next in graph[(int)now])
            {
                if(master[next]) continue;
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
        for(int i = 0; i < S.Length; i++)
        {
            for(int j = 0; j < 26; j++)
            {
                table[i, j] = S.Length;
            }
        }
        for(int i = S.Length - 1; i >= 0; i--)
        {
            for(int j = 0; j < 26; j++)
            {
                if(S[i] - 'a' == j)
                {
                    table[i, j] = i;
                }
                else
                {
                    if(i < S.Length - 1)
                    table[i, j] = table[i + 1, j];
                }
            }
        }
        var sb = new StringBuilder();
        int now = 0;
        for(int i = 0; i < NK[1]; i++)
        {
            for(int j = 0; j < 26; j++)
            {
                int next = table[now, j];
                int max = S.Length - next - 1 + (i + 1);
                if(max >= NK[1])
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
        for(int i = 0; i < Q; i++)
        {
            long B = long.Parse(Console.ReadLine());
            int l = 0;
            int r = A.Length - 1;
            while(r - l > 1)
            {
                int mid = (l + r) / 2;
                if(A[mid] > B)
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
        for(int i = 0; i < S.Length; i++)
        {
            for(int j = 0; j <= 7; j++)
            {
                if(j != 7 && S[i] == "atcoder"[j])
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
        for(int i = 1; i <= N; i++)
        {
            var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
            if(read[0] == 1)
            {
                one[i] = read[1];
            }
            else
            {
                two[i] = read[1];
            }
        }
        for(int i = 0; i < N; i++)
        {
            one[i + 1] += one[i];
        }
        for(int i = 0; i < N; i++)
        {
            two[i + 1] += two[i];
        }
        int Q = int.Parse(Console.ReadLine());
        for(int i = 0; i < Q; i++)
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
        for(int i = 0; i < M; i++)
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
        for(int i = 0; i < NM[1]; i++)
        {
            var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
            list[i] = (((int)read[0], read[1]));
        }
        list = list.OrderByDescending(x => x.Item2).ToArray();
        long start = 0;
        for(int i = 0; i < NM[1]; i++)
        {
            for(int j = 0; j < list[i].Item1; j++)
            {
                if(j + start > NM[0] - 1)
                {
                    break;
                }
                if(list[i].Item2 - A[j + start] > 0)
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
        for(int i = 0; i < N; i++)
        {
            var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
            point[i] = (read[0], read[1]);
        }
        var set = new HashSet<(long, long)>();
        for(int i = 0; i < N - 1; i++)
        {
            for(int j = i + 1; j < N; j++)
            {
                var dx = point[i].Item1 - point[j].Item1;
                var dy = point[i].Item2 - point[j].Item2;
                if(dx == 0)
                {
                    set.Add((0, 1));
                }
                else if(dy == 0)
                {
                    set.Add((1, 0));
                }
                else
                {
                    var g = gcd(dx, dy);
                    set.Add((dx/g, dy/g));
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
            while(r != 0)
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
        for(int i = 0; i < Q; i++)
        {
            var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if(read[0] == 1)
            {
                field[read[1] - 1, read[2] - 1] = 1;
            }
            else
            {
                var visit = new int[HW[0], HW[1]];
                dfs(read[1] - 1, read[2] - 1, visit, (read[3] - 1, read[4] - 1));
                if(visit[read[3] - 1, read[4] - 1] == 1 && field[read[3] - 1, read[4] - 1] == 1)
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
            if(field[y, x] == 0)
            {
                return;
            }
            visit[y, x] = 1;
            if(y == goal.Item1 && x == goal.Item2 && field[goal.Item1, goal.Item2] == 1)
            {
                return;
            }
            var move = new (int, int)[]{(-1,0),(0,-1),(1,0),(0,1)};
            foreach(var d in move)
            {
                if(y + d.Item1 >= 0 && y + d.Item1 < HW[0] && x + d.Item2 >= 0 && x + d.Item2 < HW[1])
                {
                    if(visit[y + d.Item1, x + d.Item2] == 0)
                    {
                        dfs(y +  d.Item1, x + d.Item2, visit, goal);
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
        for(int i = 0; i < Q; i++)
        {
            var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if(read[0] == 1)
            {
                if(!uf.Contains((read[1] - 1, read[2] - 1)))
                {
                    uf.Add((read[1] - 1, read[2] - 1));
                }
                field[read[1] - 1, read[2] - 1] = 1;
                var move = new (int ,int)[]{(-1,0),(0,-1),(1,0),(0,1)};
                foreach(var d in move)
                {
                    if(read[1] - 1 + d.Item1 >= 0 && read[1] - 1 + d.Item1 < HW[0] &&  read[2] - 1 + d.Item2 >= 0 && read[2] - 1 + d.Item2 < HW[1])
                    {
                        if(field[read[1] - 1 + d.Item1, read[2] - 1 + d.Item2] == 1)
                        {
                            uf.Unite((read[1] - 1, read[2] - 1), (read[1] - 1 + d.Item1, read[2] - 1 + d.Item2));
                        }
                    }
                }
            }
            else
            {
                if(uf.Contains((read[1] - 1, read[2] - 1)) && uf.Contains((read[3] - 1, read[4] - 1)))
                {
                    if(uf.IsSame((read[1] - 1, read[2] - 1), (read[3] - 1, read[4] - 1)))
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
    }
}
