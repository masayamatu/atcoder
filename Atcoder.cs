using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using DataStructure;
using System.Runtime.CompilerServices;
using System.Text;

namespace atcoder
{
    class Atcoder
    {
        const int intMax = 1000000000;
        const long longMax = 2000000000000000000;
        public static void ABC213_C()
        {
            var HWN = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var card = new Dictionary<(int, int), int>();
            var row = new Set<int>();
            var col = new Set<int>();
            for (int i = 0; i < HWN[2]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                card.Add((read[0], read[1]), i);
                row.Add(read[0]);
                col.Add(read[1]);
            }
            foreach (var c in card)
            {
                int i = row.LowerBound(c.Key.Item1);
                int j = col.LowerBound(c.Key.Item2);
                Console.WriteLine($"{i + 1} {j + 1}");
            }
        }
        public static void ABC211_C()
        {
            String S = Console.ReadLine();
            var dp = new long[S.Length + 1, 9];
            var chokudai = "chokudai".ToCharArray().ToList();
            dp[0, 0] = 1;
            for (int i = 1; i <= S.Length; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    dp[i, j] = dp[i - 1, j];
                }
                if (chokudai.Contains(S[i - 1]))
                {
                    int idx = chokudai.IndexOf(S[i - 1]);
                    dp[i, idx + 1] += dp[i - 1, idx];
                    dp[i, idx + 1] %= 1000000007;
                }

            }
            Console.WriteLine(dp[S.Length, 8]);
        }
        public static void ABC154_E()
        {
            String N = Console.ReadLine();
            int K = int.Parse(Console.ReadLine());

        }
        /// <summary>
        /// 未提出
        /// </summary>
        public static void ABC128_A()
        {
            var AP = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = AP[0] * 3 + AP[1];
            int ans = sum / 2;
            Console.WriteLine(ans);
        }
        /// <summary>
        /// 未提出
        /// </summary>
        public static void ABC129_B()
        {
            int N = int.Parse(Console.ReadLine());
            var W = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum1 = 0;
            int sum2 = W.Sum();
            int ans = intMax;
            for (int i = 0; i < N; i++)
            {
                sum1 += W[i];
                sum2 -= W[i];
                ans = Math.Min(ans, Math.Abs(sum2 - sum1));
            }
            Console.WriteLine(ans);
        }
        public static void ABC182_E()
        {
            var HWNM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int H = HWNM[0];
            int W = HWNM[1];
            int N = HWNM[2];
            int M = HWNM[3];
            var light = new (int, int)[N];
            var block = new (int, int)[M];
            var grid = new int[H, W];
            var visited = new int[H, W];
            for (int i = 0; i < N; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                light[i] = (read[0] - 1, read[1] - 1);
                grid[read[0] - 1, read[1] - 1] = 1;
            }
            for (int i = 0; i < M; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                block[i] = (read[0], read[1]);
                grid[read[0] - 1, read[1] - 1] = -1;
            }
            int ans = 0;
            foreach (var v in light)
            {
                int i = v.Item1;
                int j = v.Item2;
                if (visited[i, j] == 0)
                    ans++;
                visited[i, j] = 1;
                int up = 1;
                int down = -1;
                while (i + up < H && grid[i + up, j] != -1 && visited[i + up, j] != 1)
                {

                    ans++;
                    visited[i + up, j] = 1;
                    up++;
                }
                while (i + down >= 0 && grid[i + down, j] != -1 && visited[i + down, j] != 1)
                {
                    ans++;
                    visited[i + down, j] = 1;
                    down--;
                }
            }
            foreach (var v in light)
            {
                int i = v.Item1;
                int j = v.Item2;
                int r = 1;
                int l = -1;
                while (j + r < W && grid[i, j + r] != -1 && visited[i, j + r] != 2)
                {
                    if (visited[i, j + r] == 0)
                    {
                        ans++;
                    }
                    visited[i, j + r] = 2;
                    r++;
                }
                while (j + l >= 0 && grid[i, j + l] != -1 && visited[i, j + l] != 2)
                {
                    if (visited[i, j + l] == 0)
                    {
                        ans++;
                    }
                    visited[i, j + l] = 2;
                    l--;
                }
            }
            Console.WriteLine(ans);
        }
        public static void ABC180_D()
        {
            var XYAB = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long X = XYAB[0];
            long Y = XYAB[1];
            long A = XYAB[2];
            long B = XYAB[3];
            long ans = 0;
            long now = X;
            long pre = 0;
            while (now * (A - 1) < B && now * A < Y)
            {
                pre = now;
                now *= A;
                if ((now <= 0 || now < pre))
                    break;
                ans++;
            }
            if (Y - 1 - X * pow(A, ans) > 0)
                ans += (Y - 1 - X * pow(A, ans)) / B;
            Console.WriteLine(ans);
            long pow(long x, long n)
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
        public static void ABC214_C()
        {
            int N = int.Parse(Console.ReadLine());
            var S = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var T = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var get = new long[N];
            for (int i = 0; i < N; i++)
            {
                get[i] = T[i];
            }
            for (int i = 1; i < N; i++)
            {
                get[i] = Math.Min(get[i], get[i - 1] + S[i - 1]);
            }
            get[0] = Math.Min(get[0], get[N - 1] + S[N - 1]);
            for (int i = 1; i < N; i++)
            {
                get[i] = Math.Min(get[i], get[i - 1] + S[i - 1]);
            }
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(get[i]);
            }
        }
        public static void ABC201_C()
        {
            var S = Console.ReadLine();
            int ans = 0;
            for (int i = 0; i < 10000; i++)
            {
                int x = i;
                var temp = new bool[10];
                for (int j = 0; j < 4; j++)
                {
                    temp[x % 10] = true;
                    x /= 10;
                }
                var flag = true;
                for (int j = 0; j < 10; j++)
                {
                    if (S[j] == 'o' && !temp[j]) flag = false;
                    if (S[j] == 'x' && temp[j]) flag = false;
                }
                if (flag) ans++;
            }
            Console.WriteLine(ans);
        }
        public static void ABC210_C()
        {
            var NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var c = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var set = new Dictionary<int, int>();
            for (int i = 0; i < NK[1]; i++)
            {
                if (!set.ContainsKey(c[i]))
                {
                    set.Add(c[i], 1);
                }
                else
                {
                    set[c[i]]++;
                }
            }
            int ans = set.Count;
            for (int i = NK[1]; i < NK[0]; i++)
            {
                if (!set.ContainsKey(c[i]))
                {
                    set.Add(c[i], 1);
                }
                else
                {
                    set[c[i]]++;
                }
                set[c[i - NK[1]]]--;
                if (set[c[i - NK[1]]] == 0) set.Remove(c[i - NK[1]]);
                ans = Math.Max(ans, set.Count);
            }
            Console.WriteLine(ans);
        }
        public static void ABC199_C()
        {
            int N = int.Parse(Console.ReadLine());
            var S = Console.ReadLine();
            int Q = int.Parse(Console.ReadLine());
            var idx = Enumerable.Range(0, 2 * N).ToArray();
            var flip = false;
            for (int i = 0; i < Q; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (read[0] == 2) flip = !flip;
                else
                {
                    if (!flip)
                    {
                        int temp = idx[read[1] - 1];
                        idx[read[1] - 1] = idx[read[2] - 1];
                        idx[read[2] - 1] = temp;
                    }
                    else
                    {
                        if (read[1] <= N) read[1] += N;
                        else read[1] -= N;
                        if (read[2] <= N) read[2] += N;
                        else read[2] -= N;
                        int temp = idx[read[1] - 1];
                        idx[read[1] - 1] = idx[read[2] - 1];
                        idx[read[2] - 1] = temp;

                    }
                }
            }
            var sb = new StringBuilder();
            if (flip)
            {
                for (int i = N; i < 2 * N; i++)
                {
                    sb.Append(S[idx[i]]);
                }
                for (int i = 0; i < N; i++)
                {
                    sb.Append(S[idx[i]]);
                }
            }
            else
            {
                for (int i = 0; i < 2 * N; i++)
                {
                    sb.Append(S[idx[i]]);
                }
            }
            Console.WriteLine(sb.ToString());
        }
        public static void ARC110_C()
        {
            int N = int.Parse(Console.ReadLine());
            var P = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var idx = new (int, int)[N];
            var used = new bool[N - 1];
            for (int i = 0; i < N; i++)
            {
                idx[i] = (P[i], i);
            }
            idx = idx.OrderByDescending(x => x.Item1).ToArray();
            var m = new List<int>();
            for (int i = 0; i < N; i++)
            {
                if (P[idx[i].Item1 - 1] == idx[i].Item1) continue;
                int now = idx[i].Item2;
                while (now != P[now] - 1 && now <= N - 1)
                {
                    if (used[now])
                    {
                        Console.WriteLine(-1);
                        return;
                    }
                    used[now] = true;
                    m.Add(now + 1);
                    int temp = P[now];
                    P[now] = P[now + 1];
                    P[now + 1] = temp;
                    now++;
                }
            }
            if (m.Count < N - 1)
            {
                Console.WriteLine(-1);
                return;
            }
            foreach (var i in m)
            {
                Console.WriteLine(i);
            }
        }
        public static void ARC113_B()
        {
            var ABC = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var list = new List<int>();
            var list2 = new List<int>();
            long temp = ABC[0];
            long temp2 = ABC[1];
            while (true)
            {
                long s = temp % 10;
                if (list.Contains((int)s))
                {
                    break;
                }
                if (!list.Contains((int)s))
                {
                    list.Add((int)s);
                }
                temp *= ABC[0];
                temp %= 10;
            }
            while (true)
            {
                long s2 = temp2 % 100;
                if (list2.Contains((int)s2 % 4))
                {
                    break;
                }
                if (!list2.Contains((int)s2 % 4))
                {
                    list2.Add((int)s2 % 4);
                }
                temp2 *= ABC[1];
                if (temp2 < 0) break;
            }
            long idx = 0;
            if (ABC[1] % 4 != 2)
            {
                if ((int)ABC[2] % list2.Count() == 0) idx = list2[list2.Count - 1];
                else idx = list2[(int)ABC[2] % list2.Count() - 1];
            }
            else
            {
                if (ABC[2] > 1)
                {
                    idx = 0;
                }
                else
                {
                    idx = 2;
                }
            }

            idx = (int)idx % list.Count;
            if (idx == 0) Console.WriteLine(list[list.Count - 1]);
            else Console.WriteLine(list[(int)idx - 1]);
        }
        public static void ABC194_E()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var set = new Set<int>();
            var removed = new int[NM[0] + 1];
            int ans = intMax;
            for (int i = 0; i <= NM[0]; i++)
            {
                set.Add(i);
            }
            for (int i = 0; i < NM[1]; i++)
            {
                set.Remove(A[i]);
                removed[A[i]]++;
            }
            ans = set[0];
            for (int i = 0; i < NM[0] - NM[1]; i++)
            {
                set.Remove(A[i + NM[1]]);
                removed[A[i + NM[1]]]++;
                if (removed[A[i]] == 1)
                {
                    set.Add(A[i]);
                    removed[A[i]]++;

                }
                else
                {
                    removed[A[i]]--;
                }
                ans = Math.Min(ans, set[0]);
            }
            Console.WriteLine(ans);
        }
        public static void typical90_063()
        {
            var HW = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var P = new int[HW[0]][];
            for (int i = 0; i < HW[0]; i++)
            {
                P[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
            long ans = 0;
            for (int i = 0; i < 1 << HW[0]; i++)
            {
                var flag = new bool[HW[0]];
                for (int j = 0; j < HW[0]; j++)
                {
                    if ((i & (1 << j)) > 0) flag[j] = true;
                }
                var list = new Dictionary<int, int>();
                for (int j = 0; j < HW[1]; j++)
                {
                    var ok = true;
                    int now = -1;

                    int cnt = 0;
                    for (int k = 0; k < HW[0]; k++)
                    {
                        if (flag[k])
                        {
                            cnt++;
                            if (now == -1)
                            {
                                now = P[k][j];
                            }
                            else if (now != P[k][j])
                            {
                                ok = false;
                            }
                        }
                    }
                    if (ok)
                    {
                        if (!list.ContainsKey(now))
                        {
                            list.Add(now, cnt);
                        }
                        else
                        {
                            list[now] += cnt;
                        }
                    }
                }
                int max = 0;
                foreach (var l in list)
                {
                    max = Math.Max(max, l.Value);
                }
                ans = Math.Max(ans, max);
            }
            Console.WriteLine(ans);
        }
        public static void typical90_064()
        {
            var NQ = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var diff = new long[NQ[0]];
            long ans = 0;

            for (int i = 1; i < NQ[0]; i++)
            {
                ans += Math.Abs(A[i] - A[i - 1]);
                diff[i] = A[i] - A[i - 1];
            }
            for (int i = 0; i < NQ[1]; i++)
            {
                var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
                read[0]--;
                read[1]--;
                if (read[0] != 0 && read[1] != NQ[0] - 1)
                {
                    long ldiff = Math.Abs((diff[read[0]] + read[2])) - Math.Abs(diff[read[0]]);
                    long rdiff = Math.Abs((diff[read[1] + 1] - read[2])) - Math.Abs(diff[read[1] + 1]);
                    ans += ldiff + rdiff;
                    diff[read[0]] += read[2];
                    diff[read[1] + 1] -= read[2];
                }
                else if (read[0] == 0 && read[1] != NQ[0] - 1)
                {
                    long rdiff = Math.Abs((diff[read[1] + 1] - read[2])) - Math.Abs(diff[read[1] + 1]);
                    ans += rdiff;
                    diff[read[1] + 1] -= read[2];
                }
                else if (read[0] != 0 && read[1] == NQ[0] - 1)
                {
                    long ldiff = Math.Abs((diff[read[0]] + read[2])) - Math.Abs(diff[read[0]]);
                    ans += ldiff;
                    diff[read[0]] += read[2];
                }
                Console.WriteLine(ans);
            }
        }
        public static void typical90_068()
        {
            int N = int.Parse(Console.ReadLine());
            int Q = int.Parse(Console.ReadLine());
            var query = new (int, int, int, int)[Q];
            for (int i = 0; i < Q; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                query[i] = (read[0], read[1] - 1, read[2] - 1, read[3]);
            }
            var sum = new int[N];
            for (int i = 0; i < Q; i++)
            {
                if (query[i].Item1 == 0)
                {
                    sum[query[i].Item2] = query[i].Item4;
                }
            }
            var potential = new long[N];
            for (int i = 0; i < N - 1; i++)
            {
                potential[i + 1] = sum[i] - potential[i];
            }
            var uf = new UnionFind<int>(Enumerable.Range(0, N));
            for (int i = 0; i < Q; i++)
            {
                if (query[i].Item1 == 0)
                {
                    uf.Unite(query[i].Item2, query[i].Item3);
                }
                else
                {
                    if (!uf.IsSame(query[i].Item2, query[i].Item3))
                    {
                        Console.WriteLine("Ambiguous");
                    }
                    else if ((query[i].Item2 + query[i].Item3) % 2 == 0)
                    {
                        Console.WriteLine(query[i].Item4 + (potential[query[i].Item3] - potential[query[i].Item2]));
                    }
                    else
                    {
                        Console.WriteLine(potential[query[i].Item2] + potential[query[i].Item3] - query[i].Item4);
                    }
                }
            }
        }
        public static void typical90_069()
        {
            var NK = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long ans = 1;
            long mod = 1000000007;
            ans *= NK[1];
            if (NK[0] > 1)
                ans *= NK[1] - 1;
            ans %= mod;
            if (NK[0] > 2)
                ans *= pow(NK[1] - 2, NK[0] - 2);
            ans %= mod;
            Console.WriteLine(ans);
            long pow(long x, long n)
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

        }
        public static void typical90_070()
        {
            int N = int.Parse(Console.ReadLine());
            var x = new long[N];
            var y = new long[N];
            for (int i = 0; i < N; i++)
            {
                var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
                x[i] = read[0];
                y[i] = read[1];
            }
            Array.Sort(x);
            Array.Sort(y);
            long ans = 0;
            for (int i = 0; i < N; i++)
            {
                ans += Math.Abs(x[N / 2] - x[i]) + Math.Abs(y[N / 2] - y[i]);
            }
            Console.WriteLine(ans);
        }
        public static void typical90_072()
        {
            var HW = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var grid = new char[HW[0]][];
            for (int i = 0; i < HW[0]; i++)
            {
                grid[i] = Console.ReadLine().ToCharArray();
            }
            var sx = 0;
            var sy = 0;
            var visited = new bool[HW[0], HW[1]];
            int ans = 0;
            var move = new (int, int)[4] { (-1, 0), (1, 0), (0, -1), (0, 1) };
            for (int i = 0; i < HW[0]; i++)
            {
                for (int j = 0; j < HW[1]; j++)
                {
                    sy = i;
                    sx = j;
                    dfs(i, j, 0);
                }
            }
            if (ans <= 3) Console.WriteLine(-1);
            else Console.WriteLine(ans);
            void dfs(int y, int x, int cnt)
            {
                if (y == sy && x == sx) ans = Math.Max(ans, cnt);
                foreach (var nxt in move)
                {
                    int ny = nxt.Item1 + y;
                    int nx = nxt.Item2 + x;
                    if (ny >= 0 && ny < HW[0] && nx >= 0 && nx < HW[1] && grid[ny][nx] != '#' && !visited[ny, nx])
                    {
                        visited[ny, nx] = true;
                        dfs(ny, nx, cnt + 1);
                        visited[ny, nx] = false;

                    }
                }
                return;
            }
        }
        public static void typical90_075()
        {
            long N = long.Parse(Console.ReadLine());
            var list = Prime.GetPrimes((int)Math.Sqrt(N));
            int cnt = 0;
            foreach (var i in list)
            {
                while (N % i == 0)
                {
                    N /= i;
                    cnt++;
                }
            }
            if (N > 1) cnt++;
            int ans = 0;
            int temp = 1;
            while (temp < cnt)
            {
                ans++;
                temp *= 2;
            }
            Console.WriteLine(ans);
        }
        public static void typical90_076()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var temp = new List<long>();
            long sum = A.Sum();
            temp.AddRange(A);
            temp.AddRange(A);
            int l = 0;
            int r = 0;
            long now = 0;
            while (l < N)
            {
                while (r < 2 * N && now <= (double)sum / 10)
                {
                    now += temp[r];
                    if (now == (double)sum / 10)
                    {
                        Console.WriteLine("Yes");
                        return;
                    }
                    r++;
                }
                while (now > (double)sum / 10 && l < r)
                {
                    now -= temp[l];
                    if (now == (double)sum / 10)
                    {
                        Console.WriteLine("Yes");
                        return;
                    }
                    l++;
                }
            }
            Console.WriteLine("No");
        }
        public static void ARC105_B()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long ans = A[0];
            for (int i = 1; i < N; i++)
            {
                ans = gcd(ans, A[i]);
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
        public static void ARC107_B()
        {
            var NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var dp = new long[2 * NK[0] + 1];
            for (int i = 1; i <= 2 * NK[0]; i++)
            {
                dp[i] = Math.Min(i - 1, 2 * NK[0] + 1 - i);
            }
            long ans = 0;
            for (int i = Math.Abs(NK[1]); i <= 2 * NK[0]; i++)
            {
                ans += dp[i] * dp[i - Math.Abs(NK[1])];
            }
            Console.WriteLine(ans);
        }
        public static void ARC108_B()
        {
            int N = int.Parse(Console.ReadLine());
            var S = Console.ReadLine();
            var stack = new Stack<char>();
            for (int i = 0; i < N; i++)
            {
                stack.Push(S[i]);
                if (stack.Count >= 3 && stack.ElementAt(2) == 'f' && stack.ElementAt(1) == 'o' && stack.ElementAt(0) == 'x')
                {
                    stack.Pop();
                    stack.Pop();
                    stack.Pop();

                }
            }
            Console.WriteLine(stack.Count());
        }
        public static void typical90_078()
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
                read[0]--;
                read[1]--;
                if (read[0] < read[1])
                {
                    graph[read[1]].Add(read[0]);
                }
                else
                {
                    graph[read[0]].Add(read[1]);
                }
            }
            int ans = 0;
            for (int i = 0; i < NM[0]; i++)
            {
                if (graph[i].Count == 1) ans++;
            }
            Console.WriteLine(ans);
        }
        public static void typical90_079()
        {
            var HW = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var A = new int[HW[0]][];
            var B = new int[HW[0]][];
            for (int i = 0; i < HW[0]; i++)
            {
                A[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
            for (int i = 0; i < HW[0]; i++)
            {
                B[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
            var nxt = new (int, int)[4] { (0, 0), (1, 0), (0, 1), (1, 1) };
            long cnt = 0;
            for (int i = 0; i < HW[0]; i++)
            {
                for (int j = 0; j < HW[1]; j++)
                {
                    if (i >= HW[0] - 1 || j >= HW[1] - 1) continue;
                    int diff = Math.Abs(A[i][j] - B[i][j]);
                    if (A[i][j] > B[i][j])
                    {
                        foreach (var v in nxt)
                        {
                            int ny = i + v.Item1;
                            int nx = j + v.Item2;
                            if (ny < HW[0] && nx < HW[1])
                            {
                                A[ny][nx] -= diff;
                            }
                        }
                    }
                    else
                    {
                        foreach (var v in nxt)
                        {
                            int ny = i + v.Item1;
                            int nx = j + v.Item2;
                            if (ny < HW[0] && nx < HW[1])
                            {
                                A[ny][nx] += diff;
                            }
                        }
                    }
                    cnt += diff;
                }
            }
            var ok = true;
            for (int i = 0; i < HW[0]; i++)
            {
                for (int j = 0; j < HW[1]; j++)
                {
                    if (A[i][j] != B[i][j])
                    {
                        ok = false;
                    }
                }
            }
            if (ok)
            {
                Console.WriteLine("Yes");
                Console.WriteLine(cnt);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        public static void typical90_061()
        {
            int Q = int.Parse(Console.ReadLine());
            var q = new Deque<int>();
            for (int i = 0; i < Q; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (read[0] == 1)
                {
                    q.PushFront(read[1]);
                }
                else if (read[0] == 2)
                {
                    q.PushBack(read[1]);
                }
                else
                {
                    Console.WriteLine(q[read[1] - 1]);
                }
            }
        }
        public static void typical90_073()
        {
            int N = int.Parse(Console.ReadLine());
            var c = Console.ReadLine().Replace(" ", "").ToCharArray();
            var graph = new List<List<int>>();
            var dp = new long[1 << 18, 3];
            long mod = 1000000007;
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
            dfs(0, -1);
            Console.WriteLine(dp[0, 2]);
            void dfs(int pos, int pre)
            {
                //val1 = posと同じアルファベットのみの場合の数
                long val1 = 1;
                //val2 = a,b両方含む場合の数
                long val2 = 1;
                foreach (var i in graph[pos])
                {
                    if (i == pre) continue;
                    dfs(i, pos);
                    //iはposの子要素、すべての子要素の積をとる
                    if (c[pos] == 'a')
                    {
                        val1 *= (dp[i, 0] + dp[i, 2]);
                        val2 *= (dp[i, 0] + dp[i, 1] + 2 * dp[i, 2]);
                    }
                    if (c[pos] == 'b')
                    {
                        val1 *= (dp[i, 1] + dp[i, 2]);
                        val2 *= (dp[i, 0] + dp[i, 1] + 2 * dp[i, 2]);
                    }
                    val1 %= mod;
                    val2 %= mod;
                }
                //子要素すべて計算し終えたval1,val2でdpを更新
                if (c[pos] == 'a')
                {
                    dp[pos, 0] = val1;
                    dp[pos, 2] = (val2 - val1 + mod) % mod;
                }
                if (c[pos] == 'b')
                {
                    dp[pos, 1] = val1;
                    dp[pos, 2] = (val2 - val1 + mod) % mod;
                }
            }
        }
        public static void typical90_082()
        {
            var LR = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var ans = new BigInteger();
            long mod = 1000000007;
            var low = new BigInteger();
            low = 1;
            var up = new BigInteger();
            up = 9;
            var L = new BigInteger();
            L = LR[0];
            var R = new BigInteger();
            R = LR[1];
            long cnt = 1;
            while (low <= LR[1])
            {
                if (up >= LR[0])
                {
                    ans += cnt * ((BigInteger.Max(low, LR[0]) + BigInteger.Min(up, LR[1])) * (BigInteger.Min(up, LR[1]) - BigInteger.Max(low, LR[0]) + 1)) / 2;
                }

                ans %= mod;
                cnt++;
                low = up + 1;
                up = 10 * up + 9;
            }
            Console.WriteLine(ans);
        }
        public static void typical90_084()
        {
            int N = int.Parse(Console.ReadLine());
            var S = Console.ReadLine();
            int r = 0;
            int maru = 0;
            int batu = 0;
            long ans = 0;
            for (int i = 0; i < N; i++)
            {
                while (r <= N - 1 && (maru == 0 || batu == 0))
                {
                    if (S[r] == 'o')
                    {
                        maru++;
                    }
                    else
                    {
                        batu++;
                    }
                    r++;
                }
                if (maru > 0 && batu > 0) ans += (N - r + 1);
                if (S[i] == 'o') maru--;
                else batu--;
            }
            Console.WriteLine(ans);
        }
        public static void ABC179_E()
        {
            var NXM = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long N = NXM[0];
            long X = NXM[1];
            long M = NXM[2];
            var next = new long[56, M + 1];
            var sum = new long[56, M + 1];
            for (long i = 0; i < M; i++)
            {
                next[0, i] = i * i % M;
                sum[0, i] = i;
            }
            for (int p = 0; p < 55; p++)
            {
                for (int r = 0; r < M; r++)
                {
                    next[p + 1, r] = next[p, next[p, r]];
                    sum[p + 1, r] = sum[p, r] + sum[p, next[p, r]];
                }
            }
            long ans = 0;
            long now = X;
            for (int p = 56; p >= 0; p--)
            {
                if ((1 & (N >> p)) != 0)
                {
                    ans += sum[p, now];
                    now = next[p, now];
                }
            }
            Console.WriteLine(ans);
        }
        public static void ABC055_D()
        {
            int N = int.Parse(Console.ReadLine());
            var s = Console.ReadLine();
            var firsts = new char[8, 3] { { 'S', 'W', 'W' }, { 'S', 'S', 'S' }, { 'S', 'W', 'S' }, { 'S', 'S', 'W' }, { 'W', 'W', 'S' }, { 'W', 'S', 'W' }, { 'W', 'S', 'S' }, { 'W', 'W', 'W' } };
            for (int c = 0; c < 8; c++)
            {
                var ans = new char[N];
                ans[0] = firsts[c, 0];
                ans[1] = firsts[c, 1];
                ans[N - 1] = firsts[c, 2];
                if (s[0] == 'o')
                {
                    if (ans[0] == 'S')
                    {
                        if (ans[N - 1] != ans[1])
                        {
                            continue;
                        }
                    }
                    else
                    {
                        if (ans[N - 1] == ans[1])
                        {
                            continue;
                        }
                    }
                }
                else
                {
                    if (ans[0] == 'S')
                    {
                        if (ans[N - 1] == ans[1])
                        {
                            continue;
                        }
                    }
                    else
                    {
                        if (ans[N - 1] != ans[1])
                        {
                            continue;
                        }
                    }
                }
                for (int i = 1; i < N; i++)
                {
                    if (ans[i - 1] == 'W')
                    {
                        if (ans[i] == 'W')
                        {
                            if (s[i] == 'o')
                            {
                                if (i < N - 1)
                                    ans[i + 1] = 'S';
                                else
                                    ans[0] = 'S';
                            }
                            else
                            {
                                if (i < N - 1)
                                    ans[i + 1] = 'W';
                                else
                                    ans[0] = 'W';
                            }
                        }
                        else
                        {
                            if (s[i] == 'o')
                            {
                                if (i < N - 1)
                                    ans[i + 1] = 'W';
                                else
                                    ans[0] = 'W';
                            }
                            else
                            {
                                if (i < N - 1)
                                    ans[i + 1] = 'S';
                                else
                                    ans[0] = 'S';
                            }
                        }
                    }
                    else
                    {
                        if (ans[i] == 'W')
                        {
                            if (s[i] == 'o')
                            {
                                if (i < N - 1)
                                    ans[i + 1] = 'W';
                                else ans[0] = 'W';
                            }
                            else
                            {
                                if (i < N - 1)
                                    ans[i + 1] = 'S';
                                else
                                    ans[0] = 'S';
                            }
                        }
                        else
                        {
                            if (s[i] == 'o')
                            {
                                if (i < N - 1)
                                    ans[i + 1] = 'S';
                                else
                                    ans[0] = 'S';
                            }
                            else
                            {
                                if (i < N - 1)
                                    ans[i + 1] = 'W';
                                else
                                    ans[0] = 'W';
                            }
                        }
                    }
                }
                if (ans[0] == firsts[c, 0] && ans[N - 1] == firsts[c, 2])
                {
                    Console.WriteLine(new String(ans));
                    return;
                }
            }
            Console.WriteLine(-1);
        }
        public static void typical90_085()
        {
            long K = long.Parse(Console.ReadLine());
            long sqrtK = (long)Math.Sqrt(K);
            var cnt = new List<long>();
            long ans = 0;
            for (int i = 1; i <= sqrtK; i++)
            {
                if (K % i == 0)
                {
                    cnt.Add(K / i);
                    if (i != K / i)
                        cnt.Add(i);
                }
            }
            cnt = cnt.OrderBy(a => a).ToList();
            for (int i = 0; i < cnt.Count; i++)
            {
                for (int j = i; j < cnt.Count; j++)
                {
                    if (cnt[i] > sqrtK && cnt[j] > sqrtK) continue;
                    if (K / (cnt[i] * cnt[j]) >= cnt[j] && K % (cnt[i] * cnt[j]) == 0) ans++;
                }
            }
            Console.WriteLine(ans);
        }
        public static void ABC054_D()
        {
            var NAB = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var dp = new int[NAB[0] + 1, 500, 500];
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
            var medicine = new (int, int, int)[NAB[0]];
            for (int i = 0; i < NAB[0]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                medicine[i] = (read[0], read[1], read[2]);
            }
            dp[0, 0, 0] = 0;
            for (int i = 1; i <= NAB[0]; i++)
            {
                for (int j = 0; j <= 400; j++)
                {
                    for (int k = 0; k <= 400; k++)
                    {
                        dp[i, j + medicine[i - 1].Item1, k + medicine[i - 1].Item2] = Math.Min(dp[i, j + medicine[i - 1].Item1, k + medicine[i - 1].Item2], dp[i - 1, j, k] + medicine[i - 1].Item3);
                        dp[i, j, k] = Math.Min(dp[i, j, k], dp[i - 1, j, k]);
                    }
                }
            }
            int ans = intMax;
            int a = NAB[1];
            int b = NAB[2];
            while (a <= 400 && b <= 400)
            {
                ans = Math.Min(ans, dp[NAB[0], a, b]);
                a += NAB[1];
                b += NAB[2];
            }

            if (ans == intMax) Console.WriteLine(-1);
            else Console.WriteLine(ans);
        }
        public static void ABC162_E()
        {
            var NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long ans = 0;
            long mod = 1000000007;
            var cnt = new long[101010];
            for (int i = NK[1]; i >= 1; i--)
            {
                cnt[i] = MyMath.pow(NK[1] / i, NK[0], mod);
                int multi = i * 2;
                while (multi <= NK[1])
                {
                    cnt[i] -= cnt[multi];
                    multi += i;
                }
            }
            for (int i = 1; i <= NK[1]; i++)
            {
                ans += cnt[i] * i;
                ans %= mod;
            }
            Console.WriteLine(ans);

        }
        public static void ABC212_C()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var B = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var list = new List<(int, int)>();
            int ans = intMax;
            for (int i = 0; i < NM[0]; i++)
            {
                list.Add((A[i], 0));
            }
            for (int i = 0; i < NM[1]; i++)
            {
                list.Add((B[i], 1));
            }
            list = list.OrderBy(a => a.Item1).ToList();
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i].Item2 != list[i + 1].Item2)
                {
                    ans = Math.Min(ans, Math.Abs(list[i].Item1 - list[i + 1].Item1));
                }
            }
            Console.WriteLine(ans);
        }
        public static void ABC243_E()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var edge = new (int, int, int)[NM[1]];
            for (int i = 0; i < NM[1]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                edge[i] = (read[0] - 1, read[1] - 1, read[2]);
            }
            var d = new int[NM[0], NM[0]];
            for (int i = 0; i < d.GetLength(0); i++)
            {
                for (int j = 0; j < d.GetLength(1); j++)
                {
                    d[i, j] = intMax;
                }
            }
            for (int i = 0; i < NM[1]; i++)
            {
                d[edge[i].Item1, edge[i].Item2] = edge[i].Item3;
                d[edge[i].Item2, edge[i].Item1] = edge[i].Item3;
            }
            for (int k = 0; k < NM[0]; k++)
            {
                for (int i = 0; i < NM[0]; i++)
                {
                    for (int j = 0; j < NM[0]; j++)
                    {
                        d[i, j] = Math.Min(d[i, j], d[i, k] + d[k, j]);
                    }
                }
            }
            int ans = 0;
            for (int i = 0; i < NM[1]; i++)
            {
                int unused = 0;
                for (int j = 0; j < NM[0]; j++)
                {
                    if (d[edge[i].Item1, j] + d[j, edge[i].Item2] <= edge[i].Item3) unused = 1;
                }
                ans += unused;
            }
            Console.WriteLine(ans);
        }
        public static void ABC215_D()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var prime = MyMath.GetPrimes(NM[1]);
            var list = Enumerable.Range(1, NM[1]).ToList();
            var seen = new bool[1000001];
            for (int i = 0; i < NM[0]; i++)
            {
                int temp = A[i];
                int idx = 0;
                while (idx < prime.Count && Math.Sqrt(temp) >= prime[idx])
                {
                    while (temp % prime[idx] == 0)
                    {
                        temp /= prime[idx];
                        int rem1 = temp;
                        int rem2 = prime[idx];
                        if (!seen[temp])
                        {
                            while (rem1 != 1 && rem1 <= NM[1])
                            {
                                if (list.BinarySearch(rem1) >= 0)
                                    list.Remove(rem1);
                                rem1 += temp;
                            }
                            seen[temp] = true;
                        }
                        if (!seen[prime[idx]])
                        {
                            while (rem2 != 1 && rem2 <= NM[1])
                            {
                                if (list.BinarySearch(rem2) >= 0)
                                    list.Remove(rem2);
                                rem2 += prime[idx];
                            }
                            seen[prime[idx]] = true;
                        }
                    }
                    idx++;
                }
                int rem = A[i];
                while (rem != 1 && rem <= NM[1] && !seen[A[i]])
                {
                    if (list.BinarySearch(rem) >= 0)
                        list.Remove(rem);
                    rem += A[i];
                }
                seen[A[i]] = true;
            }
            Console.WriteLine(list.Count);
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
        }
        public static void ABC215_A()
        {
            var S = Console.ReadLine();
            if (S == "Hello,World!")
            {
                Console.WriteLine("AC");
            }
            else
            {
                Console.WriteLine("WA");
            }
        }
        public static void ABC214_D()
        {
            int N = int.Parse(Console.ReadLine());
            var edge = new (long, long, long)[N - 1];
            for (int i = 0; i < N - 1; i++)
            {
                var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
                read[0]--;
                read[1]--;
                edge[i] = (read[2], read[0], read[1]);
            }
            edge = edge.OrderBy(a => a.Item1).ToArray();
            var uf = new UnionFind<int>(Enumerable.Range(0, N + 1));
            long ans = 0;
            for (int i = 0; i < N - 1; i++)
            {
                ans += edge[i].Item1 * uf.Size((int)edge[i].Item2) * uf.Size((int)edge[i].Item3);
                uf.Unite((int)edge[i].Item2, (int)edge[i].Item3);
            }
            Console.WriteLine(ans);
        }
        public static void ABC223_B()
        {
            var S = Console.ReadLine().ToCharArray();
            var list = new List<String>();
            for (int i = 0; i < S.Length; i++)
            {
                list.Add(new string(S));
                char temp = S[S.Length - 1];
                for (int j = S.Length - 1; j >= 1; j--)
                {
                    S[j] = S[j - 1];
                }
                S[0] = temp;
            }
            list = list.OrderBy(a => a).ToList();
            Console.WriteLine(list[0]);
            Console.WriteLine(list[list.Count - 1]);
        }
        public static void ABC073_D()
        {
            var NMR = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            r = r.Select(a => a - 1).ToArray();
            var distance = new long[NMR[0], NMR[0]];
            var edge = new List<(int, int)>();
            for (int i = 0; i < distance.GetLength(0); i++)
            {
                for (int j = 0; j < distance.GetLength(1); j++)
                {
                    distance[i, j] = longMax;
                    if (i == j) distance[i, j] = 0;
                }
            }
            for (int i = 0; i < NMR[1]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                read[0]--;
                read[1]--;
                edge.Add((read[0], read[1]));
                edge.Add((read[1], read[0]));
                distance[read[0], read[1]] = read[2];
                distance[read[1], read[0]] = read[2];
            }
            for (int k = 0; k < NMR[0]; k++)
            {
                for (int i = 0; i < NMR[0]; i++)
                {
                    for (int j = 0; j < NMR[0]; j++)
                    {
                        if (distance[i, j] > distance[i, k] + distance[k, j])
                        {
                            distance[i, j] = distance[i, k] + distance[k, j];
                        }
                    }
                }
            }
            long ans = longMax;
            var np = Enumerable.Range(0, NMR[2]).ToArray();
            do
            {
                long temp = 0;
                for (int i = 0; i < NMR[2] - 1; i++)
                {
                    temp += distance[r[np[i]], r[np[i + 1]]];
                }
                ans = Math.Min(ans, temp);
            } while (NextPermutation.Next_Permutation(np));

            Console.WriteLine(ans);
        }
        public static void ABC046_C()
        {
            int N = int.Parse(Console.ReadLine());
            long takahashi = 1;
            long aoki = 1;
            for (int i = 0; i < N; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (read[1] / (double)read[0] != aoki / (double)takahashi)
                {
                    long one = read[0];
                    long two = read[1];
                    long multi = Math.Max((long)Math.Ceiling((decimal)takahashi / read[0]), (long)Math.Ceiling((decimal)aoki / read[1]));
                    takahashi = one * multi;
                    aoki = two * multi;
                }
            }
            Console.WriteLine(aoki + takahashi);
        }
        public static void ABC046_D()
        {
            var s = Console.ReadLine();
            int g = 0;
            int p = 0;
            int score = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'p')
                {
                    if (g > p)
                    {
                        p++;
                    }
                    else
                    {
                        g++;
                        score--;
                    }
                }
                else
                {
                    if (g > p)
                    {
                        p++;
                        score++;
                    }
                    else
                    {
                        g++;
                    }
                }
            }
            Console.WriteLine(score);
        }
        public static void ABC051_D()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var dist = new int[NM[0], NM[0]];
            var a = new int[NM[1]];
            var b = new int[NM[1]];
            var c = new int[NM[1]];
            for (int i = 0; i < NM[0]; i++)
            {
                for (int j = 0; j < NM[0]; j++)
                {
                    if (i != j) dist[i, j] = intMax;
                }
            }
            for (int i = 0; i < NM[1]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                read[0]--;
                read[1]--;
                a[i] = read[0];
                b[i] = read[1];
                c[i] = read[2];
                dist[read[0], read[1]] = read[2];
                dist[read[1], read[0]] = read[2];
            }
            for (int k = 0; k < NM[0]; k++)
            {
                for (int i = 0; i < NM[0]; i++)
                {
                    for (int j = 0; j < NM[0]; j++)
                    {
                        if (dist[i, j] > dist[i, k] + dist[k, j])
                        {
                            dist[i, j] = dist[i, k] + dist[k, j];
                        }
                    }
                }
            }
            int ans = NM[1];
            for (int i = 0; i < NM[1]; i++)
            {
                bool flag = false;
                for (int j = 0; j < NM[0]; j++)
                {
                    if (dist[j, a[i]] + c[i] == dist[j, b[i]]) flag = true;
                }
                if (flag) ans--;
            }
            Console.WriteLine(ans);
        }
        public static void ABC111_C()
        {
            int N = int.Parse(Console.ReadLine());
            var v = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var one = new Dictionary<int, int>();
            var two = new Dictionary<int, int>();
            for (int i = 0; i < N; i++)
            {
                if (i % 2 == 0)
                {
                    if (!one.ContainsKey(v[i]))
                    {
                        one.Add(v[i], 1);
                    }
                    else
                    {
                        one[v[i]]++;
                    }
                }
                else
                {
                    if (!two.ContainsKey(v[i]))
                    {
                        two.Add(v[i], 1);
                    }
                    else
                    {
                        two[v[i]]++;
                    }
                }
            }
            one = one.OrderByDescending(a => a.Value).ToDictionary(x => x.Key, y => y.Value);
            two = two.OrderByDescending(a => a.Value).ToDictionary(x => x.Key, y => y.Value);
            if (one.Count == 1 && two.Count == 1 && v[0] == v[1])
            {
                Console.WriteLine(N / 2);
            }
            else if (one.ElementAt(0).Key == two.ElementAt(0).Key)
            {
                if (one.Count == 1)
                {
                    Console.WriteLine((N / 2 - one.ElementAt(0).Value + N / 2 - two.ElementAt(1).Value));
                }
                else if (two.Count == 1)
                {
                    Console.WriteLine((N / 2 - two.ElementAt(0).Value + N / 2 - one.ElementAt(1).Value));
                }
                else
                {
                    Console.WriteLine(Math.Min(N / 2 - one.ElementAt(0).Value + N / 2 - two.ElementAt(1).Value, N / 2 - two.ElementAt(0).Value + N / 2 - one.ElementAt(1).Value));
                }
            }
            else
            {
                Console.WriteLine((N / 2 - one.ElementAt(0).Value + N / 2 - two.ElementAt(0).Value));
            }
        }
        public static void ABC061_C()
        {
            var NK = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var list = new List<(int, int)>();
            for (int i = 0; i < NK[0]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                list.Add((read[0], read[1]));
            }
            list = list.OrderBy(x => x.Item1).ToList();
            long now = 0;
            int idx = 0;
            while (now <= NK[1])
            {
                now += (long)list.ElementAt(idx).Item2;
                if (now >= NK[1]) break;
                idx++;
            }
            Console.WriteLine(list[idx].Item1);
        }
        public static void ABC019_B()
        {
            var s = Console.ReadLine();
            var list = new List<(char, int)>();
            var stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (stack.Count > 0)
                {
                    if (stack.ElementAt(0) != s[i])
                    {
                        list.Add((stack.ElementAt(0), stack.Count));
                        stack.Clear();
                        stack.Push(s[i]);
                    }
                    else
                    {
                        stack.Push(s[i]);
                    }
                }
                else
                {
                    stack.Push(s[i]);
                }
            }
            list.Add((stack.ElementAt(0), stack.Count));
            String ans = "";
            foreach (var v in list)
            {
                ans += v.Item1;
                ans += Convert.ToString(v.Item2);
            }
            Console.WriteLine(ans);
        }
        public static void ABC019_C()
        {
            int N = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(int.Parse).ToList();
            a = a.OrderBy(a => a).ToList();
            var set = new HashSet<int>();
            for (int i = 0; i < N; i++)
            {
                while (a[i] % 2 == 0)
                {
                    a[i] /= 2;
                }
                set.Add(a[i]);
            }

            Console.WriteLine(set.Count);
        }
        public static void ABC022_B()
        {
            int N = int.Parse(Console.ReadLine());
            var A = new int[100001];
            int cnt = 0;
            for (int i = 0; i < N; i++)
            {
                int temp = int.Parse(Console.ReadLine());
                if (A[temp] > 0)
                {
                    cnt++;
                    A[temp]++;
                }
                else A[temp]++;
            }
            Console.WriteLine(cnt);
        }
        public static void ABC021_C()
        {
            int N = int.Parse(Console.ReadLine());
            var ab = Console.ReadLine().Split().Select(int.Parse).ToArray();
            ab[0]--;
            ab[1]--;
            int M = int.Parse(Console.ReadLine());
            var graph = new List<List<int>>();
            for (int i = 0; i < N; i++)
            {
                graph.Add(new List<int>());
            }
            for (int i = 0; i < M; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                read[0]--;
                read[1]--;
                graph[read[0]].Add(read[1]);
                graph[read[1]].Add(read[0]);
            }
            var q = new Queue<(int, int)>();
            q.Enqueue((ab[0], 0));
            var distance = new int[N];
            for (int i = 0; i < N; i++)
            {
                distance[i] = intMax;
            }
            var pre = new (int, long)[N];
            long ans = 0;
            int idx = ab[1];
            long mod = 1000000007;
            var visited = new bool[N];
            while (q.Count > 0)
            {
                var now = q.Dequeue();
                visited[now.Item1] = true;
                if (now.Item1 == ab[1]) break;
                foreach (var v in graph[now.Item1])
                {
                    if (!visited[v] && distance[v] > now.Item2 + 1)
                    {
                        distance[v] = now.Item2 + 1;
                        pre[v] = (now.Item1, 1);
                        q.Enqueue((v, now.Item2 + 1));
                    }
                    else if (!visited[v] && distance[v] == now.Item2 + 1)
                    {
                        pre[v].Item2++;
                    }
                }
            }
            while (true)
            {
                if (ans == 0)
                {
                    ans += pre[idx].Item2;
                    ans %= mod;
                }
                else
                {
                    ans *= pre[idx].Item2;
                    ans %= mod;
                }
                if (pre[idx].Item1 == ab[0]) break;
                idx = pre[idx].Item1;
            }
            Console.WriteLine(ans);
        }
        public static void ABC023_B()
        {
            int N = int.Parse(Console.ReadLine());
            var S = Console.ReadLine();
            String temp = "b";
            if (S == temp)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 1)
                {
                    temp = "a" + temp + "c";
                }
                else if (i % 3 == 2)
                {
                    temp = "c" + temp + "a";
                }
                else
                {
                    temp = "b" + temp + "b";
                }
                if (S == temp)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine(-1);
        }
        public static void UTPC2021_A()
        {
            int N = int.Parse(Console.ReadLine());
            var S = Console.ReadLine();
            int cnt = 0;
            var UTPC = new char[4] { 'U', 'T', 'P', 'C' };
            var idx = new Dictionary<char, int>();
            idx.Add('U', 0);
            idx.Add('T', 1);
            idx.Add('P', 2);
            idx.Add('C', 3);
            for (int i = 0; i < N; i++)
            {
                var temp = 0;
                var swap = 0;
                if (S[i] == 'U')
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (i + j >= 0 && i + j < N && S[i + j] == UTPC[j])
                        {
                            temp++;
                        }
                        else if (i + j >= 0 && i + j < N)
                        {
                            int now = idx[S[i + j]];
                            int right = idx.ElementAt(j).Value;
                            int diff = now - right;
                            if (i + diff >= 0 && i + diff < N && S[i + diff] == UTPC[right])
                            {
                                swap++;
                            }
                        }
                    }
                }
                else if (S[i] == 'T')
                {
                    for (int j = -1; j < 3; j++)
                    {
                        if (i + j >= 0 && i + j < N && S[i + j] == UTPC[j + 1])
                        {
                            temp++;
                        }
                        else if (i + j >= 0 && i + j < N)
                        {
                            int now = idx[S[i + j]];
                            int right = idx.ElementAt(j + 1).Value;
                            int diff = now - right;
                            if (i + diff >= 0 && i + diff < N && S[i + diff] == UTPC[right])
                            {
                                swap++;
                            }
                        }
                    }
                }
                else if (S[i] == 'P')
                {
                    for (int j = -2; j < 2; j++)
                    {
                        if (i + j >= 0 && i + j < N && S[i + j] == UTPC[j + 2])
                        {
                            temp++;
                        }
                        else if (i + j >= 0 && i + j < N)
                        {
                            int now = idx[S[i + j]];
                            int right = idx.ElementAt(j + 2).Value;
                            int diff = now - right;
                            if (i + diff >= 0 && i + diff < N && S[i + diff] == UTPC[right])
                            {
                                swap++;
                            }
                        }
                    }
                }
                else
                {
                    for (int j = -3; j < 1; j++)
                    {
                        if (i + j >= 0 && i + j < N && S[i + j] == UTPC[j + 3])
                        {
                            temp++;
                        }
                        else if (i + j >= 0 && i + j < N)
                        {
                            int now = idx[S[i + j]];
                            int right = idx.ElementAt(j + 3).Value;
                            int diff = now - right;
                            if (i + diff >= 0 && i + diff < N && S[i + diff] == UTPC[right])
                            {
                                swap++;
                            }
                        }
                    }
                }
                cnt = Math.Max(cnt, temp + swap / 2);
            }
            Console.WriteLine(4 - cnt);
        }
        public static void ABC202_C()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var B = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var C = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long ans = 0;
            var cnt = new int[N + 1];
            for (int i = 0; i < N; i++)
            {
                cnt[B[C[i] - 1]]++;
            }
            for (int i = 0; i < N; i++)
            {
                ans += cnt[A[i]];
            }
            Console.WriteLine(ans);
        }
        public static void ABC202_D()
        {
            var ABK = Console.ReadLine().Split().Select(long.Parse).ToArray();
            int A = (int)ABK[0];
            int B = (int)ABK[1];
            long K = ABK[2] - 1;
            int N = A + B;
            var c = new long[N, N];
            c[0, 0] = 1;
            for (int i = 1; i < A + B; i++)
            {
                c[i, 0] = 1;
                c[i, i] = 1;
                for (int j = 1; j < i; j++)
                {
                    c[i, j] = c[i - 1, j - 1] + c[i - 1, j];
                }
            }
            String ans = "";
            for (int i = 0; i < N; i++)
            {
                if (0 < A)
                {
                    if (K < c[A + B - 1, B])
                    {
                        ans += "a";
                        A--;
                    }
                    else
                    {
                        ans += "b";
                        K -= c[A + B - 1, B];
                        B--;
                    }
                }
                else
                {
                    ans += "b";
                    B--;
                }
            }
            Console.WriteLine(ans);
        }
        public static void ABC216_C()
        {
            long N = long.Parse(Console.ReadLine());
            var ans = "";
            long now = N;
            while (now > 0)
            {
                if (now % 2 != 0)
                {

                    ans += "A";
                    now--;
                    if (now == 0) break;
                }
                ans += "B";
                now /= 2;
            }
            var rev = ans.ToCharArray();
            Array.Reverse(rev);
            Console.WriteLine(new String(rev));
        }
        public static void ABC089_C()
        {
            int N = int.Parse(Console.ReadLine());
            var head = new Dictionary<char, long>();
            head.Add('M', 0);
            head.Add('A', 0);
            head.Add('R', 0);
            head.Add('C', 0);
            head.Add('H', 0);
            for (int i = 0; i < N; i++)
            {
                var S = Console.ReadLine();
                if (head.ContainsKey(S[0]))
                    head[S[0]]++;
            }
            long ans = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    for (int k = j + 1; k < 5; k++)
                    {
                        ans += head.ElementAt(i).Value * head.ElementAt(j).Value * head.ElementAt(k).Value;
                    }
                }
            }
            Console.WriteLine(ans);
        }
        public static void ABC059_C()
        {
            int N = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long ans = 0;
            bool plus = false;
            long now = a[0];
            var a2 = new long[N];
            Array.Copy(a, a2, N);
            if (now >= 0) plus = true;
            if (a[0] == 0)
            {
                now += 1;
                ans += 1;
            }
            for (int i = 1; i < N; i++)
            {
                if (plus)
                {
                    if (now + a[i] >= 0)
                    {
                        ans += now + a[i] + 1;
                        a[i] = -(now + 1);

                    }
                    now += a[i];
                    plus = !plus;
                }
                else
                {
                    if (now + a[i] <= 0)
                    {
                        ans += -now + 1 - a[i];
                        a[i] = (-now + 1);

                    }
                    now += a[i];
                    plus = !plus;
                }
            }
            long now2 = 0;
            long ans2 = 0;
            ans2 += Math.Abs(a2[0]) + 1;
            if (a2[0] >= 0)
            {
                plus = false;
                now2 = -1;
            }
            else
            {
                plus = true;
                now2 = 1;
            }
            for (int i = 1; i < N; i++)
            {
                if (plus)
                {
                    if (now2 + a2[i] >= 0)
                    {
                        ans2 += now2 + a2[i] + 1;
                        a2[i] = -(now2 + 1);

                    }
                    now2 += a2[i];
                    plus = !plus;
                }
                else
                {
                    if (now2 + a2[i] <= 0)
                    {
                        ans2 += -now2 + 1 - a2[i];
                        a2[i] = (-now2 + 1);

                    }
                    now2 += a2[i];
                    plus = !plus;
                }
            }
            Console.WriteLine(Math.Min(ans, ans2));
        }
        public static void ABC118_C()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var gcd = MyMath.gcd(A[0], A[1]);
            for (int i = 2; i < N; i++)
            {
                gcd = MyMath.gcd(gcd, A[i]);
            }
            Console.WriteLine(gcd);
        }
        public static void ABC062_C()
        {
            var HW = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long ans = longMax;
            if (HW[0] % 3 == 0 || HW[1] % 3 == 0)
            {
                ans = 0;
            }
            else
            {
                long one = Math.Min(HW[0], HW[1]);
                long two = one / 2;
                long three = one - two;
                for (int i = 1; i < Math.Max(HW[0], HW[1]); i++)
                {
                    long max = one * i;
                    long min = one * i;
                    max = Math.Max(max, two * (Math.Max(HW[0], HW[1]) - i));
                    min = Math.Min(min, two * (Math.Max(HW[0], HW[1]) - i));
                    max = Math.Max(max, three * (Math.Max(HW[0], HW[1]) - i));
                    min = Math.Min(min, three * (Math.Max(HW[0], HW[1]) - i));
                    ans = Math.Min(ans, max - min);
                }
                one = Math.Max(HW[0], HW[1]);
                two = one / 2;
                three = one - two;
                for (int i = 1; i < Math.Min(HW[0], HW[1]); i++)
                {
                    long max = one * i;
                    long min = one * i;
                    max = Math.Max(max, two * (Math.Min(HW[0], HW[1]) - i));
                    min = Math.Min(min, two * (Math.Min(HW[0], HW[1]) - i));
                    max = Math.Max(max, three * (Math.Min(HW[0], HW[1]) - i));
                    min = Math.Min(min, three * (Math.Min(HW[0], HW[1]) - i));
                    ans = Math.Min(ans, max - min);
                }
                one = Math.Max(HW[0], HW[1]);
                for (int i = 1; i < Math.Min(HW[0], HW[1]); i++)
                {
                    long max = one * i;
                    long min = one * i;
                    two = (Math.Min(HW[0], HW[1]) - i) / 2;
                    three = (Math.Min(HW[0], HW[1]) - i) - two;
                    max = Math.Max(max, two * one);
                    min = Math.Min(min, two * one);
                    max = Math.Max(max, three * one);
                    min = Math.Min(min, three * one);
                    ans = Math.Min(ans, max - min);
                }
                one = Math.Min(HW[0], HW[1]);
                for (int i = 1; i < Math.Max(HW[0], HW[1]); i++)
                {
                    long max = one * i;
                    long min = one * i;
                    two = (Math.Max(HW[0], HW[1]) - i) / 2;
                    three = (Math.Max(HW[0], HW[1]) - i) - two;
                    max = Math.Max(max, two * one);
                    min = Math.Min(min, two * one);
                    max = Math.Max(max, three * one);
                    min = Math.Min(min, three * one);
                    ans = Math.Min(ans, max - min);
                }
            }
            Console.WriteLine(ans);
        }
        public static void ABC021_B()
        {
            int N = int.Parse(Console.ReadLine());
            var ab = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int K = int.Parse(Console.ReadLine());
            var P = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var list = new List<int>();
            list.Add(ab[0]);
            list.Add(ab[1]);
            for (int i = 0; i < K; i++)
            {
                if (list.Contains(P[i]))
                {
                    Console.WriteLine("NO");
                    return;
                }
                else
                {
                    list.Add(P[i]);
                }
            }
            Console.WriteLine("YES");
        }
        public static void ABC028_C()
        {
            var ABCDE = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var list = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    for (int k = j + 1; k < 5; k++)
                    {
                        if (!list.Contains(ABCDE[i] + ABCDE[j] + ABCDE[k]))
                        {
                            list.Add((ABCDE[i] + ABCDE[j] + ABCDE[k]));
                        }
                    }
                }
            }
            list = list.OrderByDescending(x => x).ToList();
            Console.WriteLine(list[2]);
        }
        public static void ABC047_C()
        {
            var S = Console.ReadLine();
            int cnt = 0;
            char pre = S[0];
            for (int i = 1; i < S.Length; i++)
            {
                if (pre != S[i])
                {
                    cnt++;
                    pre = S[i];
                }
            }
            Console.WriteLine(cnt);
        }
        public static void ABC044_B()
        {
            var S = Console.ReadLine();
            var list = new Dictionary<char, int>();
            for (int i = 0; i < S.Length; i++)
            {
                if (!list.ContainsKey(S[i]))
                {
                    list.Add(S[i], 1);
                }
                else
                {
                    list[S[i]]++;
                }
            }
            var ok = true;
            foreach (var v in list)
            {
                if (v.Value % 2 != 0) ok = false;
            }
            if (ok) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
        public static void ABC029_C()
        {
            int N = int.Parse(Console.ReadLine());
            var list = new List<String>();
            String temp = "";
            dfs(temp);
            foreach (var s in list)
            {
                Console.WriteLine(s);
            }
            void dfs(String now)
            {
                if (now.Length == N)
                {
                    if (!list.Contains(now))
                    {
                        list.Add(now);
                    }
                    return;
                }
                dfs(now + "a");
                dfs(now + "b");
                dfs(now + "c");
            }
        }
        public static void ABC209_C()
        {
            int N = int.Parse(Console.ReadLine());
            var C = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long ans = 0;
            long mod = 1000000007;
            Array.Sort(C);
            for (int i = 0; i < N; i++)
            {
                long temp = Math.Max(0, C[i] - i);
                if (ans == 0)
                {
                    ans += temp;
                    ans %= mod;
                }
                else
                {
                    ans *= temp;
                    ans %= mod;
                }
            }
            Console.WriteLine(ans);
        }
        public static void ABC207_C()
        {
            int N = int.Parse(Console.ReadLine());
            var list = new (int, int, int)[N];
            for (int i = 0; i < N; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (read[0] == 1)
                {
                    list[i] = (read[0], read[1], read[2]);
                }
                else if (read[0] == 2)
                {
                    list[i] = (read[0], read[1], read[2] - 1);
                }
                else if (read[0] == 3)
                {
                    list[i] = (read[0], read[1] + 1, read[2]);
                }
                else
                {
                    list[i] = (read[0], read[1] + 1, read[2] - 1);
                }
            }
            list = list.OrderBy(x => x.Item2).ThenBy(x => x.Item3).ToArray();
            int cnt = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (list[i].Item3 >= list[j].Item2)
                    {
                        cnt++;
                    }
                    else if (list[j].Item2 - list[i].Item3 == 1)
                    {
                        if ((list[i].Item1 == 2 || list[i].Item1 == 4) && (list[j].Item1 == 3 || list[j].Item1 == 4))
                        {
                            cnt++;
                        }
                    }
                }
            }
            Console.WriteLine(cnt);
        }
        public static void ABC198_C()
        {
            var RXY = Console.ReadLine().Split().Select(long.Parse).ToArray();
            double dist = Math.Sqrt(RXY[1] * RXY[1] + RXY[2] * RXY[2]);
            int ans = 0;
            if ((long)dist == dist && (int)dist % RXY[0] == 0) ans = (int)dist / (int)RXY[0];
            else if (RXY[0] > dist) ans = 2;
            else ans = (int)Math.Ceiling(dist / (double)RXY[0]);
            Console.WriteLine(ans);
        }
        public static void ABC208_C()
        {
            var NK = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var idx = new (int, int)[NK[0]];
            for (int i = 0; i < NK[0]; i++)
            {
                idx[i] = (i, a[i]);
            }
            idx = idx.OrderBy(x => x.Item2).ToArray();
            var cnt = new long[NK[0]];
            long temp = NK[1] / NK[0];
            for (int i = 0; i < NK[0]; i++)
            {
                cnt[i] += temp;
                NK[1] -= temp;
            }
            for (int i = 0; i < NK[1]; i++)
            {
                cnt[idx[i].Item1]++;
            }
            for (int i = 0; i < NK[0]; i++)
            {

                Console.WriteLine(cnt[i]);
            }
        }
        public static void ABC195_C()
        {
            long N = long.Parse(Console.ReadLine());
            long cnt = 0;
            long now = 1000;
            while (now <= N)
            {
                cnt += N - (now - 1);
                now *= 1000;
            }
            Console.WriteLine(cnt);
        }
        public static void ABC193_B()
        {
            int N = int.Parse(Console.ReadLine());
            var shop = new (int, int)[N];
            for (int i = 0; i < N; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                shop[i] = (read[1], read[2] - read[0]);
            }
            shop = shop.OrderBy(x => x.Item1).ToArray();
            int ans = intMax;
            for (int i = 0; i < N; i++)
            {
                if (shop[i].Item2 > 0)
                {
                    ans = Math.Min(ans, shop[i].Item1);
                }
            }
            if (ans == intMax) Console.WriteLine(-1);
            else Console.WriteLine(ans);
        }
        public static void ABC123_C()
        {
            long N = long.Parse(Console.ReadLine());
            long A = long.Parse(Console.ReadLine());
            long B = long.Parse(Console.ReadLine());
            long C = long.Parse(Console.ReadLine());
            long D = long.Parse(Console.ReadLine());
            long E = long.Parse(Console.ReadLine());
            long ans = 0;
            long min = A;
            //int idx = 0;
            if (min > B)
            {
                min = B;
                //idx = 1;
            }
            if (min > C)
            {
                min = C;
                //idx = 2;
            }
            if (min > D)
            {
                min = D;
                //idx = 3;
            }
            if (min > E)
            {
                min = E;
                //idx = 4;
            }
            ans += (long)Math.Ceiling((decimal)N / min) + 4;
            /*if (A <= B)
            {
                ans += 1;
            }
            else
            {
                ans += (long)Math.Ceiling((decimal)N / B) - 1;
            }
            if (A <= C || B <= C)
            {
                ans += 1;
            }
            else
            {
                ans += (long)Math.Ceiling((decimal)N / C) - 2;
            }
            if (A <= D || B <= D || C <= D)
            {
                ans += 1;
            }
            else
            {
                ans += (long)Math.Ceiling((decimal)N / D) - 3;
            }
            if (A <= E || B <= E || C <= E || D <= E)
            {
                ans += 1;
            }
            else
            {
                ans += (long)Math.Ceiling((decimal)N / E) - 4;
            }*/
            Console.WriteLine(ans);
        }
        public static void ABC197_C()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long ans = longMax;
            for (int i = 1; i <= (1 << N - 1); i++)
            {
                var ok = new bool[N - 1];
                for (int j = 0; j < N - 1; j++)
                {
                    if ((i & (1 << j)) > 0) ok[j] = true;
                }
                int cnt = 0;
                for (int j = 0; j < N - 1; j++)
                {
                    if (ok[j]) cnt++;
                }
                var temp = new long[cnt + 1];
                int idx = 0;
                for (int j = 0; j < N; j++)
                {
                    //temp[idx] = temp[idx] | A[j];
                    if (j < N - 1 && ok[j]) idx++;
                }
                long tempA = temp[0];
                for (int j = 1; j < temp.Length; j++)
                {
                    tempA = tempA ^ temp[j];
                }
                ans = Math.Min(ans, tempA);
            }
            Console.WriteLine(ans);
        }
        public static void ABC196_B()
        {
            String X = Console.ReadLine();
            var temp = X.Split(".");
            Console.WriteLine(temp[0]);
        }
        public static void ABC197_B()
        {
            var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var grid = new char[read[0]][];
            for (int i = 0; i < read[0]; i++)
            {
                grid[i] = Console.ReadLine().ToCharArray();
            }
            int cnt = 1;
            int x = read[2] - 1;
            int y = read[3] - 1;
            int up = 1;
            int down = -1;
            while (up <= 100)
            {
                if (x + up >= read[0] || grid[x + up][y] == '#') break;
                cnt++;
                up++;
            }
            up = 1;
            while (up <= 100)
            {
                if (y + up >= read[1] || grid[x][y + up] == '#') break;
                cnt++;
                up++;
            }
            while (down >= -100)
            {
                if (x + down < 0 || grid[x + down][y] == '#') break;
                cnt++;
                down--;
            }
            down = -1;
            while (up >= -100)
            {
                if (y + down < 0 || grid[x][y + down] == '#') break;
                cnt++;
                down--;
            }
            Console.WriteLine(cnt);
        }
        public static void ABC205_C()
        {
            var ABC = Console.ReadLine().Split().Select(long.Parse).ToArray();
            if (Math.Abs(ABC[0]) == Math.Abs(ABC[1]))
            {
                if (ABC[2] % 2 == 0)
                {
                    Console.WriteLine("=");
                }
                else
                {
                    if (ABC[0] == ABC[1])
                    {
                        Console.WriteLine("=");
                    }
                    else if (ABC[0] < ABC[1])
                    {
                        Console.WriteLine("<");
                    }
                    else
                    {
                        Console.WriteLine(">");
                    }

                }

            }
            else if (ABC[0] == 0)
            {
                if (ABC[2] % 2 == 0 || ABC[1] > 0)
                    Console.WriteLine("<");
                else
                    Console.WriteLine(">");
            }
            else if (ABC[1] == 0)
            {
                if (ABC[2] % 2 == 0 || ABC[0] > 0)
                    Console.WriteLine(">");
                else
                    Console.WriteLine("<");
            }
            else if (Math.Abs(ABC[0]) < Math.Abs(ABC[1]))
            {
                if (ABC[2] % 2 == 0)
                {
                    Console.WriteLine("<");
                }
                else
                {
                    if (ABC[0] < 0 && ABC[1] < 0)
                    {
                        Console.WriteLine(">");
                    }
                    else if (ABC[0] < 0)
                    {
                        Console.WriteLine("<");
                    }
                    else if (ABC[1] < 0)
                    {
                        Console.WriteLine(">");
                    }
                    else
                    {
                        Console.WriteLine("<");
                    }
                }
            }
            else
            {
                if (ABC[2] % 2 == 0)
                {
                    Console.WriteLine(">");
                }
                else
                {
                    if (ABC[0] < 0 && ABC[1] < 0)
                    {
                        Console.WriteLine("<");
                    }
                    else if (ABC[0] < 0)
                    {
                        Console.WriteLine("<");
                    }
                    else if (ABC[1] < 0)
                    {
                        Console.WriteLine(">");
                    }
                    else
                    {
                        Console.WriteLine(">");
                    }
                }
            }
        }
        public static void ABC212_B()
        {
            var read = Console.ReadLine();
            var S = new int[4];
            for (int i = 0; i < 4; i++)
            {
                S[i] = read[i] - '0';
            }
            var ok = false;
            int cnt = 0;
            for (int i = 1; i < 4; i++)
            {
                if (S[i] != 0)
                {
                    if (S[i] != S[i - 1])
                    {
                        ok = true;
                    }
                    if (S[i] == S[i - 1] + 1) cnt++;
                }
                else
                {
                    if (S[i] != S[i - 1])
                    {
                        ok = true;
                    }
                    if (S[i - 1] == 9) cnt++;
                }
            }
            if (ok && cnt != 3) Console.WriteLine("Strong");
            else Console.WriteLine("Weak");
        }
        public static void ABC198_B()
        {
            var S = Console.ReadLine();
            var trim = S.TrimEnd('0');
            var r = trim.ToCharArray();
            Array.Reverse(r);
            if (trim == new String(r))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        public static void ABC199_B()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var B = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int ans = B.Min() - A.Max() + 1;
            Console.WriteLine(Math.Max(0, ans));
        }
        public static void ABC248_A()
        {
            var S = Console.ReadLine();
            var list = Enumerable.Range(0, 10).ToList();
            for (int i = 0; i < S.Length; i++)
            {
                list.Remove(S[i] - '0');
            }
            Console.WriteLine(list[0]);
        }
        public static void ABC248_B()
        {
            var ABK = Console.ReadLine().Split().Select(long.Parse).ToArray();
            int cnt = 0;
            while (ABK[0] < ABK[1])
            {
                ABK[0] *= ABK[2];
                cnt++;
            }
            Console.WriteLine(cnt);
        }
        public static void ABC248_C()
        {
            var NMK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var dp = new long[NMK[0] + 1, NMK[0] * NMK[2] + 1];
            dp[0, 0] = 1;
            long mod = 998244353;
            for (int i = 1; i <= NMK[0]; i++)
            {
                for (int j = 0; j <= NMK[0] * NMK[2]; j++)
                {
                    for (int k = 1; k <= NMK[1]; k++)
                    {
                        if (k + j <= NMK[0] * NMK[2])
                        {
                            dp[i, k + j] += dp[i - 1, j];
                            dp[i, k + j] %= mod;
                        }
                    }
                }
            }
            long ans = 0;
            for (int i = 0; i <= NMK[2]; i++)
            {
                ans += dp[NMK[0], i];
                ans %= mod;
            }
            Console.WriteLine(ans);
        }
        public static void ABC248_D()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int Q = int.Parse(Console.ReadLine());
            var list = new List<Set<int>>();
            for (int i = 1; i <= N; i++)
            {
                list.Add(new Set<int>());
            }
            for (int i = 0; i < N; i++)
            {
                list[A[i] - 1].Add(i);
            }
            while (Q-- > 0)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                read[0]--;
                read[2]--;
                int a = list[read[2]].LowerBound(read[1]);
                int b = list[read[2]].LowerBound(read[0] - 1);
                int ans = list[read[2]].LowerBound(read[1]) - (list[read[2]].LowerBound(read[0]));
                Console.WriteLine(ans);
            }
        }
        public static void AGC048_A()
        {
            int Q = int.Parse(Console.ReadLine()); ;
            while (Q-- > 0)
            {
                var T = Console.ReadLine();
                int ans = intMax;
                var atcoder = "atcoder".ToCharArray();
                if (T.CompareTo("atcoder") > 0) ans = 0;
                for (int i = 0; i < T.Length; i++)
                {
                    if (T[i] != 'a')
                    {
                        if (i > 1 && (T[i] - 'a' > 't' - 'a'))
                        {
                            ans = Math.Min(ans, i - 1);
                        }
                        else
                        {
                            ans = Math.Min(ans, i);
                        }
                    }
                }
                if (ans == intMax) Console.WriteLine(-1);
                else Console.WriteLine(ans);
            }
        }
        public static void ABC211_B()
        {
            var S1 = Console.ReadLine();
            var S2 = Console.ReadLine();
            var S3 = Console.ReadLine();
            var S4 = Console.ReadLine();
            var list = new List<string>();
            if (!list.Contains(S1))
            {
                list.Add(S1);
            }
            if (!list.Contains(S2))
            {
                list.Add(S2);
            }
            if (!list.Contains(S3))
            {
                list.Add(S3);
            }
            if (!list.Contains(S4))
            {
                list.Add(S4);
            }
            if (list.Count == 4) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
        public static void ABC247_E()
        {
            var NXY = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long ans = 0;
            int s = 0;
            while (s < NXY[0])
            {
                var temp = new List<int>();
                while (s < NXY[0] && A[s] >= NXY[2] && A[s] <= NXY[1])
                {
                    temp.Add(A[s]);
                    s++;
                }
                if (temp.Count > 0)
                {
                    ans += calc(temp.ToArray());
                }
                s++;
            }

            Console.WriteLine(ans);
            long calc(int[] list)
            {
                int l = 0;
                int r = 0;
                int countX = 0;
                int countY = 0;
                long res = 0;

                while (l != list.Length)
                {
                    while (r != list.Length && (countX == 0 || countY == 0))
                    {
                        if (list[r] == NXY[1])
                        {
                            countX++;
                        }
                        if (list[r] == NXY[2])
                        {
                            countY++;
                        }
                        r++;
                    }
                    if (countX > 0 && countY > 0)
                    {
                        res += list.Length + 1 - r;
                    }
                    if (list[l] == NXY[1])
                    {
                        countX--;
                    }
                    else if (list[l] == NXY[2])
                    {
                        countY--;
                    }
                    l++;
                }
                return res;
            }
        }
        public static void ABC193_D()
        {
            long K = int.Parse(Console.ReadLine());
            String S = Console.ReadLine();
            String T = Console.ReadLine();
            int takahashi = 0;
            int aoki = 0;
            var tNum = new long[10];
            var aNum = new long[10];
            for (int i = 0; i < S.Length - 1; i++)
            {
                tNum[S[i] - '0']++;
            }
            for (int i = 0; i < S.Length - 1; i++)
            {
                aNum[T[i] - '0']++;
            }
            for (int i = 1; i < 10; i++)
            {
                takahashi += i * (int)Math.Pow(10, tNum[i]);
                aoki += i * (int)Math.Pow(10, aNum[i]);
            }
            long M = (9 * K - 8) * (9 * K - 9);
            long C = 0;
            long diff = takahashi - aoki;
            for (long i = 1; i < 10; i++)
            {
                for (long j = 1; j < 10; j++)
                {
                    long tempT = i * (long)Math.Pow(10, tNum[i] + 1) - i * (long)Math.Pow(10, tNum[i]);
                    long tempA = j * (long)Math.Pow(10, aNum[j] + 1) - j * (long)Math.Pow(10, aNum[j]);
                    if (diff + tempT - tempA > 0)
                    {
                        if (i != j && K - (tNum[i] + aNum[i]) > 0 && K - (tNum[j] + aNum[j]) > 0)
                            C += (K - (tNum[i] + aNum[i])) * (K - (tNum[j] + aNum[j]));
                        else if (K - (tNum[i] + aNum[i]) > 0 && K - (tNum[j] + aNum[j] + 1) > 0)
                            C += (K - (tNum[i] + aNum[i])) * (K - (tNum[j] + aNum[j] + 1));
                    }

                }
            }
            Console.WriteLine((double)C / M);
        }
        public static void ABC208_D()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var path = new (int, int, int)[NM[1]];
            for (int i = 0; i < NM[1]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                path[i] = (read[0] - 1, read[1] - 1, read[2]);
            }
            long ans = 0;
            var d = new long[NM[0], NM[0]];
            for (int i = 0; i < NM[0]; i++)
            {
                for (int j = 0; j < NM[0]; j++)
                {
                    if (i != j) d[i, j] = longMax;
                }
            }
            for (int i = 0; i < NM[1]; i++)
            {
                d[path[i].Item1, path[i].Item2] = path[i].Item3;
            }
            for (int k = 0; k < NM[0]; k++)
            {
                var nxt = new long[NM[0], NM[0]];
                for (int i = 0; i < NM[0]; i++)
                {
                    for (int j = 0; j < NM[0]; j++)
                    {
                        nxt[i, j] = Math.Min(d[i, j], d[i, k] + d[k, j]);
                        if (nxt[i, j] < longMax)
                        {
                            ans += nxt[i, j];
                        }
                    }
                }
                d = nxt;
            }
            Console.WriteLine(ans);
        }
        public static void AGC049_B()
        {
            int N = int.Parse(Console.ReadLine());
            var S = Console.ReadLine().ToCharArray();
            var T = Console.ReadLine().ToCharArray();
            int scnt = 0;
            int tcnt = 0;
            for (int i = 0; i < N; i++)
            {
                if (S[i] == '1')
                {
                    scnt++;
                }
                if (T[i] == '1')
                {
                    tcnt++;
                }
            }
            if (tcnt > scnt || scnt % 2 != tcnt % 2)
            {
                Console.WriteLine(-1);
                return;
            }
            long ans = 0;
            int now = 0;
            for (int i = 0; i < N; i++)
            {
                if (S[i] != T[i])
                {
                    if (T[i] == '0')
                    {
                        now = Math.Max(now, i + 1);
                        while (now < N - 1 && S[now] != '1')
                        {
                            now++;
                        }
                        if (now == N - 1 && S[now] != '1') break;
                        S[now] = '0';
                        S[i] = '0';
                        ans += now - i;
                    }
                    else
                    {
                        now = Math.Max(now, i + 1);
                        while (now < N - 1 && S[now] != '1')
                        {
                            now++;
                        }
                        if (now == N - 1 && S[now] != '1') break;
                        S[now] = '0';
                        S[i] = '1';
                        ans += now - i;
                    }
                }
            }
            if (new String(S) != new String(T)) Console.WriteLine(-1);
            else Console.WriteLine(ans);
        }
        public static void ABC206_Dsub()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int l = 0;
            int r = N - 1;
            var uf = new UnionFind<int>();
            long ans = 0;
            while (r > l)
            {
                if (A[l] != A[r])
                {
                    if (!uf.Contains(A[l]))
                    {
                        uf.Add(A[l]);
                    }
                    if (!uf.Contains(A[r]))
                    {
                        uf.Add(A[r]);
                    }
                    if (!uf.IsSame(A[l], A[r]))
                    {
                        uf.Unite(A[l], A[r]);
                        ans++;
                    }

                }
                l++;
                r--;
            }
            Console.WriteLine(ans);

        }
        public static void ABC210_B()
        {
            int N = int.Parse(Console.ReadLine());
            var S = Console.ReadLine();
            for (int i = 0; i < N; i++)
            {
                if (S[i] == '1')
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine("Takahashi");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Aoki");
                        return;
                    }
                }
            }
        }
        public static void ABC206_D()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var graph = new List<List<int>>();
            for (int i = 0; i < 2 * 100000 + 1; i++)
            {
                graph.Add(new List<int>());
            }
            int l = 0;
            int r = N - 1;
            var visited = new int[2 * 10000 + 1];
            visited.Select(a => -1);
            while (r > l)
            {
                if (A[l] != A[r])
                {

                }
                l++;
                r--;
            }
        }
        public static void algorithm_math042()
        {
            int N = int.Parse(Console.ReadLine());
            long ans = 0;
            var cnt = new long[N + 1];
            //cnt[1] = 1;
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; i * j <= N; j++)
                {
                    cnt[i * j]++;
                }
            }
            for (long i = 1; i <= N; i++)
            {
                ans += i * cnt[i];
            }
            Console.WriteLine(ans);
        }
        public static void algorithm_math055()
        {
            long N = long.Parse(Console.ReadLine());
            var A = new long[2, 2] { { 2, 1 }, { 1, 0 } };
            long mod = 1000000007;
            var B = MyMath.MathrixPow(A, N - 1, mod);
            Console.WriteLine((B[1, 0] + B[1, 1]) % mod);
        }
        public static void algorithm_math056()
        {
            long N = long.Parse(Console.ReadLine());
            var A = new long[3, 3] { { 1, 1, 1 }, { 1, 0, 0 }, { 0, 1, 0 } };
            long mod = 1000000007;
            var B = MyMath.MathrixPow(A, N - 1);
            Console.WriteLine((B[2, 0] * 2 + B[2, 1] + B[2, 2]) % mod);
        }
        public static void algorithm_math061()
        {
            long N = long.Parse(Console.ReadLine());
            long temp = N + 1;
            while (temp >= 0)
            {
                if (temp % 2 == 0)
                {
                    temp /= 2;
                }
                else
                {
                    break;
                }
            }
            if (temp == 1) Console.WriteLine("Second");
            else Console.WriteLine("First");
        }
        public static void algorithm_math065()
        {
            var HW = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long v = (long)Math.Ceiling((decimal)HW[0] / 2);
            long h = (long)Math.Ceiling((decimal)HW[1] / 2);
            long sv = (long)Math.Floor((decimal)HW[0] / 2);
            long sh = (long)Math.Floor((decimal)HW[1] / 2);
            long ans = v * h + sv * sh;
            if (HW[0] == 1 || HW[1] == 1) ans = 1;
            Console.WriteLine(ans);
        }
        public static void algorithm_math066()
        {
            var NK = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long yojisyou = 0;
            for (int a = 1; a <= NK[0]; a++)
            {
                for (int b = (int)Math.Max(1, a - (NK[1] - 1)); b <= Math.Min(NK[0], a + NK[1] - 1); b++)
                {
                    for (int c = (int)Math.Max(1, a - (NK[1] - 1)); c <= Math.Min(NK[0], a + NK[1] - 1); c++)
                    {
                        if (Math.Abs(b - c) <= NK[1] - 1) yojisyou++;
                    }
                }
            }
            long ans = NK[0] * NK[0] * (long)NK[0] - yojisyou;
            Console.WriteLine(ans);
        }
        public static void algorithm_math067()
        {
            var HW = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var A = new int[HW[0]][];
            for (int i = 0; i < HW[0]; i++)
            {
                A[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
            var v = new int[HW[1]];
            var h = new int[HW[0]];
            for (int i = 0; i < HW[0]; i++)
            {
                for (int j = 0; j < HW[1]; j++)
                {
                    h[i] += A[i][j];
                    v[j] += A[i][j];
                }
            }
            var B = new int[HW[0], HW[1]];
            for (int i = 0; i < HW[0]; i++)
            {
                for (int j = 0; j < HW[1]; j++)
                {
                    B[i, j] = v[j] + h[i] - A[i][j];
                }
            }
            for (int i = 0; i < HW[0]; i++)
            {
                var sb = new StringBuilder();
                for (int j = 0; j < HW[1]; j++)
                {
                    sb.Append($"{B[i, j]} ");
                }
                Console.WriteLine(sb.ToString().TrimEnd());
            }
        }
        public static void algorithm_math071()
        {
            int N = int.Parse(Console.ReadLine());
            var S = new (double, double, double)[N];
            for (int i = 0; i < N; i++)
            {
                var read = Console.ReadLine().Split().Select(double.Parse).ToArray();
                S[i] = (read[0], read[1], read[2]);
            }
            double ans = 0.0;
            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (S[i].Item1 * S[j].Item2 == S[j].Item1 * S[i].Item2) continue;
                    double px = ((double)S[j].Item2 * S[i].Item3 - S[i].Item2 * S[j].Item3) / ((double)S[i].Item1 * S[j].Item2 - S[j].Item1 * S[i].Item2);
                    double py = ((double)S[j].Item1 * S[i].Item3 - S[i].Item1 * S[j].Item3) / ((double)S[j].Item1 * S[i].Item2 - S[i].Item1 * S[j].Item2);
                    var ok = true;
                    for (int k = 0; k < N; k++)
                    {
                        if (S[k].Item1 * (px - 0.00000001) + S[k].Item2 * (py - 0.00000001) > S[k].Item3) ok = false;
                    }
                    if (ok) ans = Math.Max(ans, px + py);
                }
            }
            Console.WriteLine(ans);
        }
        public static void algorithm_math072()
        {
            var AB = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int ans = 0;
            for (int i = 1; i <= AB[1]; i++)
            {
                int l = (AB[0] + i - 1) / i;
                int r = AB[1] / i;
                if (r - l >= 1) ans = Math.Max(ans, i);
            }
            Console.WriteLine(ans);
        }
        public static void algorithm_math073()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var pow = new long[300009];
            long mod = 1000000007;
            pow[0] = 1;
            for (int i = 1; i <= N; i++)
            {
                pow[i] = (2 * pow[i - 1]) % mod;
            }
            long ans = 0;
            for (int i = 0; i < N; i++)
            {
                if (i > 0)
                {
                    ans += pow[i] * A[i];
                    ans %= mod;
                }
                else
                {
                    ans += A[i];
                }

            }
            Console.WriteLine(ans);
        }
        public static void algorithm_math074()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long ans = 0;
            for (long i = 0; i < N; i++)
            {
                ans += A[i] * (-N + 2 * (i + 1) - 1);
            }
            Console.WriteLine(ans);
        }
        public static void algorithm_math075()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long ans = 0;
            long mod = 1000000007;
            var comb = new Comb(N + 1);
            for (int i = 0; i < N; i++)
            {
                ans += A[i] * comb.nCk(N - 1, i);
                ans %= mod;
            }
            Console.WriteLine(ans);
        }
        public static void algorithm_math076()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            Array.Sort(A);
            long ans = 0;
            for (int i = 0; i < N; i++)
            {
                ans += A[i] * (-N + 2 * i + 1);
            }
            Console.WriteLine(ans);
        }
        public static void ABC223_A()
        {
            int N = int.Parse(Console.ReadLine());
            if (N != 0 && N % 100 == 0) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
        public static void algorithm_math077()
        {
            int N = int.Parse(Console.ReadLine());
            var X = new long[N];
            var Y = new long[N];
            for (int i = 0; i < N; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                X[i] = read[0];
                Y[i] = read[1];
            }
            long ans = 0;
            Array.Sort(X);
            Array.Sort(Y);
            for (int i = 0; i < N; i++)
            {
                ans += X[i] * (-N + 2 * i + 1);
                ans += Y[i] * (-N + 2 * i + 1);
            }
            Console.WriteLine(ans);
        }
        public static void algorithm_math078()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var age = new int[NM[0]];
            age = age.Select(a => 120).ToArray();
            age[0] = 0;
            var check = new bool[NM[0]];
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
            var q = new Queue<int>();
            q.Enqueue(0);
            while (q.Count > 0)
            {
                int now = q.Dequeue();
                check[now] = true;
                foreach (var v in graph[now])
                {

                    if (!check[v])
                    {
                        age[v] = age[now] + 1;
                        q.Enqueue(v);
                        check[v] = true;
                    }

                }
            }
            for (int i = 0; i < NM[0]; i++)
            {
                Console.WriteLine(age[i]);
            }


        }
        public static void algorithm_math079()
        {
            long N = long.Parse(Console.ReadLine());
            long ans = N * (N - 1) / 2;
            Console.WriteLine(ans);
        }
        public static void ABC217_C()
        {
            int N = int.Parse(Console.ReadLine());
            var P = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var Q = new int[N];
            for (int i = 0; i < N; i++)
            {
                Q[P[i] - 1] = i + 1;
            }
            var sb = new StringBuilder();
            for (int i = 0; i < N; i++)
            {
                sb.Append($"{Q[i]} ");
            }
            Console.WriteLine(sb.ToString().TrimEnd());
        }
        public static void ABC250_C()
        {
            var NQ = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var num = Enumerable.Range(0, NQ[0]).ToArray();
            var idx = Enumerable.Range(0, NQ[0]).ToArray();
            while (NQ[1]-- > 0)
            {
                int x = int.Parse(Console.ReadLine()) - 1;
                int temp = num[idx[x]];
                int nexi = idx[x] == NQ[0] - 1 ? idx[x] - 1 : idx[x] + 1;
                int nexv = num[nexi];
                num[idx[x]] = num[nexi];
                num[nexi] = temp;
                int itemp = idx[temp];
                idx[temp] = idx[nexv];
                idx[nexv] = itemp;

            }
            var sb = new StringBuilder();
            for (int i = 0; i < NQ[0]; i++)
            {
                sb.Append($"{num[i] + 1} ");
            }
            Console.WriteLine(sb.ToString().TrimEnd());
        }
        public static void ABC250_D()
        {
            long N = long.Parse(Console.ReadLine());
            var primes = MyMath.GetPrimes(1000000);
            int cnt = 0;
            for (int i = 0; i < primes.Count; i++)
            {
                for (int j = i + 1; j < primes.Count; j++)
                {
                    BigInteger num = new BigInteger();
                    num = (long)primes[i];
                    num *= primes[j];
                    num *= primes[j];
                    num *= primes[j];
                    if (num <= N)
                    {
                        cnt++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(cnt);
        }
        public static void ABC250_E()
        {
            int N = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var b = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var acnt = new int[N];
            var bcnt = new int[N];
            var ra = new int[N];
            var rb = new int[N];
            var adic = new Dictionary<int, int>();
            var bdic = new Dictionary<int, int>();
            int ax = -1;
            for (int i = 0; i < N; i++)
            {
                if (!adic.ContainsKey(a[i]))
                {
                    adic.Add(a[i], 1);
                }
                while (ax < N - 1 && adic.ContainsKey(b[ax + 1]))
                {
                    ax++;
                }
                ra[i] = ax;
                acnt[i] = adic.Count;
            }
            int bx = -1;
            for (int i = 0; i < N; i++)
            {
                if (!bdic.ContainsKey(b[i]))
                {
                    bdic.Add(b[i], 1);
                }
                while (bx < N - 1 && bdic.ContainsKey(a[bx + 1]))
                {
                    bx++;
                }
                rb[i] = bx;
                bcnt[i] = bdic.Count;
            }
            int Q = int.Parse(Console.ReadLine());
            var x = new int[Q];
            var y = new int[Q];
            for (int i = 0; i < Q; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                x[i] = read[0] - 1;
                y[i] = read[1] - 1;
                if (acnt[x[i]] != bcnt[y[i]])
                {
                    Console.WriteLine("No");
                }
                else
                {
                    if (ra[x[i]] >= y[i] && rb[y[i]] >= x[i]) Console.WriteLine("Yes");
                    else Console.WriteLine("No");
                }

            }

        }
        public static void ABC042_D()
        {
            var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long H = read[0];
            long W = read[1];
            long A = read[2];
            long B = read[3];
            long mod = 1000000007;
            long ans = 0;
            var comb = new Comb(1000001);
            for (int i = 0; i < W - B; i++)
            {
                //long one = fact[H - A - 1 + B + 1 + i] / (fact[H - A - 1] * fact[B + 1 + i]);
                //long one = fact[H - A - 1 + B + i] / (fact[H - A - 1] * fact[B + i]);
                int xy = (int)(H - A - 1 + B + i);
                int x = (int)(H - A - 1);
                long one = comb.nCk(xy, x);
                one %= mod;
                xy = (int)(A - 1 + W - B - i - 1);
                x = (int)(A - 1);
                //long two = fact[A - 1 + W - B - i - 1] / (fact[A - 1] * fact[W - B - i - 1]);
                long two = comb.nCk(xy, x);
                two %= mod;
                long temp = one * two;
                temp %= mod;
                ans += temp;
                ans %= mod;
            }
            Console.WriteLine(ans);
        }
        public static void ABC070_C()
        {
            int N = int.Parse(Console.ReadLine());
            long ans = 0;

            for (int i = 0; i < N; i++)
            {
                long T = long.Parse(Console.ReadLine());
                if (i == 0) ans = T;
                else ans = lcm(ans, T);
            }
            Console.WriteLine(ans);
            long lcm(long C, long D)
            {
                if (C > D)
                {
                    long temp = C;
                    C = D;
                    D = temp;
                }
                long tempC = C;
                long tempD = D;

                long r = tempD % tempC;
                while (r != 0)
                {
                    tempD = tempC;
                    tempC = r;
                    r = tempD % tempC;
                }
                BigInteger CD = new BigInteger();
                CD = C;
                CD *= D;
                CD /= tempC;
                return (long)CD;
            }
        }
        public static void ABC078_C()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = NM[0];
            int M = NM[1];
            int mo = (int)Math.Pow(2, M);
            long ans = (1900 * M + 100 * (N - M)) * mo;
            Console.WriteLine(ans);
        }
        public static void ABC043_D()
        {
            String S = Console.ReadLine();
            if (S.Length == 2)
            {
                if (S[0] == S[1])
                {
                    Console.WriteLine($"1 2");
                    return;
                }
            }
            for (int i = 0; i < S.Length - 2; i++)
            {
                if (S[i] == S[i + 1] || S[i] == S[i + 2] || S[i + 1] == S[i + 2])
                {
                    Console.WriteLine($"{i + 1} {i + 3}");
                    return;
                }
            }
            Console.WriteLine("-1 -1");
        }
        public static void ABC045_D()
        {
            var HWN = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int H = HWN[0];
            int W = HWN[1];
            int N = HWN[2];
            var cnt = new long[10];
            var list = new Dictionary<(int, int), int>();
            cnt[0] = (long)(H - 2) * (W - 2);
            for (int i = 0; i < N; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                read[0]--;
                read[1]--;
                for (int sy = read[0] - 2; sy <= read[0]; sy++)
                {
                    for (int sx = read[1] - 2; sx <= read[1]; sx++)
                    {
                        if (sy >= 0 && sy < H && sx >= 0 && sx < W)
                        {
                            if (sy + 2 >= H || sx + 2 >= W) continue;
                            int temp = 0;
                            for (int dy = 0; dy <= 2; dy++)
                            {
                                for (int dx = 0; dx <= 2; dx++)
                                {

                                    if (list.ContainsKey((sy + dy, sx + dx)))
                                    {
                                        temp++;
                                    }
                                }
                            }
                            cnt[temp]--;
                            cnt[temp + 1]++;
                        }
                    }
                }
                list.Add((read[0], read[1]), 1);
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(cnt[i]);
            }
        }
        public static void ABC129_E()
        {
            String L = Console.ReadLine();
            long mod = 1000000007;
            var dp = new long[L.Length + 1, 2];
            dp[0, 0] = 1;
            for (int i = 0; i < L.Length; i++)
            {
                for (int isless = 0; isless < 2; isless++)
                {
                    //i桁目が1であれば1と0どちらにもできるのでislessが1と0どちらからでもislessが1に遷移できる
                    //(0,0)への遷移を考えるのでisless = 1への遷移のみ
                    if (L[i] == '1') dp[i + 1, 1] += dp[i, isless];
                    //i桁目が0のときは0にしかできないのでislessが0の時islessが1へは遷移できない
                    else dp[i + 1, isless] += dp[i, isless];
                    dp[i + 1, 1] %= mod;
                    dp[i + 1, isless] %= mod;
                    //(1, 0)、(0, 1)へ遷移できるので２倍になる
                    //i桁目0でislessが0の場合(0,1)、(1,0)へ遷移するとLを超えるのでこの場合は考えない
                    if (!(L[i] == '0' && isless == 0)) dp[i + 1, isless] += dp[i, isless] * 2;
                    dp[i + 1, isless] %= mod;
                }
            }
            Console.WriteLine((dp[L.Length, 0] + dp[L.Length, 1]) % mod);
        }
        public static void ABC045_B()
        {
            var SA = Console.ReadLine();
            var SB = Console.ReadLine();
            var SC = Console.ReadLine();
            int ia = 0;
            int ib = -1;
            int ic = -1;
            int now = 1;
            while (true)
            {
                if (now == 1)
                {
                    if (SA[ia] == 'a')
                    {
                        ia++;
                        if (ia == SA.Length)
                        {
                            Console.WriteLine("A");
                            return;
                        }
                        now = 1;
                    }
                    else if (SA[ia] == 'b')
                    {
                        ib++;
                        if (ib == SB.Length)
                        {
                            Console.WriteLine("B");
                            return;
                        }
                        now = 2;
                    }
                    else
                    {
                        ic++;
                        if (ic == SC.Length)
                        {
                            Console.WriteLine("C");
                            return;
                        }
                        now = 3;
                    }
                }
                else if (now == 2)
                {
                    if (SB[ib] == 'a')
                    {
                        ia++;
                        if (ia == SA.Length)
                        {
                            Console.WriteLine("A");
                            return;
                        }
                        now = 1;
                    }
                    else if (SB[ib] == 'b')
                    {
                        ib++;
                        if (ib == SB.Length)
                        {
                            Console.WriteLine("B");
                            return;
                        }
                        now = 2;
                    }
                    else
                    {
                        ic++;
                        if (ic == SC.Length)
                        {
                            Console.WriteLine("C");
                            return;
                        }
                        now = 3;
                    }
                }
                else
                {
                    if (SC[ic] == 'a')
                    {
                        ia++;
                        if (ia == SA.Length)
                        {
                            Console.WriteLine("A");
                            return;
                        }
                        now = 1;
                    }
                    else if (SC[ic] == 'b')
                    {
                        ib++;
                        if (ib == SB.Length)
                        {
                            Console.WriteLine("B");
                            return;
                        }
                        now = 2;
                    }
                    else
                    {
                        ic++;
                        if (ic == SC.Length)
                        {
                            Console.WriteLine("C");
                            return;
                        }
                        now = 3;
                    }
                }
            }
        }
        public static void ARC140_A()
        {
            var NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            String S = Console.ReadLine();
            var list = new List<int>();
            int ans = intMax;
            for (int i = 1; i <= Math.Sqrt(NK[0]); i++)
            {
                if (NK[0] % i == 0)
                {
                    list.Add(i);
                    list.Add(NK[0] / i);
                }
            }
            foreach (var p in list)
            {
                var cnt = 0;
                for (int i = 0; i < p; i++)
                {
                    var cnts = new int[26];
                    for (int j = 0; j < NK[0] / p; j++)
                    {
                        cnts[S[i + j * p] - 'a']++;
                    }
                    cnt += NK[0] / p - cnts.Max();
                }
                if (cnt <= NK[1]) ans = Math.Min(ans, p);
            }
            if (ans == intMax) Console.WriteLine(NK[0]);
            else Console.WriteLine(ans);
        }
        public static void ABC209_B()
        {
            var NX = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int cnt = 0;
            for (int i = 0; i < NX[0]; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    cnt += A[i] - 1;
                }
                else
                {
                    cnt += A[i];
                }
            }
            if (cnt <= NX[1]) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
        public static void ABC047_B()
        {
            var WHN = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int ans = WHN[0] * WHN[1];
            int leftX = 0;
            int rightX = WHN[0];
            int topY = WHN[1];
            int downY = 0;
            for (int i = 0; i < WHN[2]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (read[2] == 1)
                {
                    leftX = Math.Max(leftX, read[0]);
                }
                else if (read[2] == 2)
                {
                    rightX = Math.Min(rightX, read[0]);

                }
                else if (read[2] == 3)
                {

                    downY = Math.Max(downY, read[1]);

                }
                else
                {
                    topY = Math.Min(topY, read[1]);
                }
            }
            if (leftX >= rightX)
            {
                Console.WriteLine(0);
                return;
            }
            else if (downY > topY)
            {
                Console.WriteLine(0);
                return;
            }
            ans -= WHN[1] * leftX;
            ans -= (WHN[0] - rightX) * WHN[1];
            ans -= WHN[0] * downY;
            ans -= (WHN[1] - topY) * WHN[0];
            ans += leftX * (WHN[1] - topY);
            ans += (WHN[0] - rightX) * (WHN[1] - topY);
            ans += leftX * downY;
            ans += (WHN[0] - rightX) * downY;
            Console.WriteLine(ans);
        }
        public static void ABC051_B()
        {
            var KS = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long cnt = 0;
            for (int i = 0; i <= KS[0]; i++)
            {
                for (int j = 0; j <= KS[0]; j++)
                {
                    if (KS[1] - (i + j) <= KS[0] && 0 <= KS[1] - (i + j)) cnt++;

                }
            }
            Console.WriteLine(cnt);
        }
        public static void ABC068_C()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var land = new List<List<int>>();
            for (int i = 0; i < NM[0]; i++)
            {
                land.Add(new List<int>());
            }
            for (int i = 0; i < NM[1]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                read[0]--;
                read[1]--;
                land[read[0]].Add(read[1]);
                land[read[1]].Add(read[0]);
            }
            var q = new Queue<(int, int)>();
            q.Enqueue((0, 0));
            var visited = new bool[NM[0]];
            while (q.Count > 0)
            {
                var now = q.Dequeue();
                visited[now.Item1] = true;
                foreach (var nxt in land[now.Item1])
                {
                    if (nxt == NM[0] - 1 && now.Item2 == 1)
                    {
                        Console.WriteLine("POSSIBLE");
                        return;
                    }
                    if (!visited[nxt])
                    {
                        q.Enqueue((nxt, now.Item2 + 1));
                    }
                }
            }
            Console.WriteLine("IMPOSSIBLE");
        }
        public static void ABC251_E()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var dp = new long[N, 2];
            dp[0, 1] = A[0];
            dp[0, 0] = longMax;
            long ans = longMax;
            for (int i = 1; i < N; i++)
            {
                dp[i, 0] = dp[i - 1, 1];
                dp[i, 1] = Math.Min(dp[i - 1, 0], dp[i - 1, 1]) + A[i];
            }
            ans = Math.Min(ans, Math.Min(dp[N - 1, 1], dp[N - 1, 0]));
            dp[0, 0] = 0;
            dp[0, 1] = longMax;
            for (int i = 1; i < N; i++)
            {
                dp[i, 0] = dp[i - 1, 1];
                dp[i, 1] = Math.Min(dp[i - 1, 0], dp[i - 1, 1]) + A[i];
            }
            ans = Math.Min(ans, dp[N - 1, 1]);
            Console.WriteLine(ans);
        }
        public static void ABC149_C()
        {
            int X = int.Parse(Console.ReadLine());
            while (true)
            {
                var ok = true;
                for (int i = 2; i <= Math.Sqrt(X); i++)
                {
                    if (X % i == 0)
                    {
                        ok = false;
                        break;
                    }
                }
                if (ok)
                {
                    Console.WriteLine(X);
                    return;
                }
                X++;
            }
        }
        public static void ABC082_C()
        {
            int N = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var cnt = new Dictionary<int, int>();
            long ans = 0;
            for (int i = 0; i < N; i++)
            {
                if (!cnt.ContainsKey(a[i]))
                {
                    cnt.Add(a[i], 1);
                }
                else
                {
                    cnt[a[i]]++;
                }
            }
            foreach (var i in cnt)
            {
                if (i.Value >= i.Key)
                {
                    ans += i.Value - i.Key;
                }
                else
                {
                    ans += i.Value;
                }
            }
            Console.WriteLine(ans);
        }
        public static void ABC091_C()
        {
            int N = int.Parse(Console.ReadLine());
            var red = new (int, int)[N];
            var blue = new (int, int)[N];
            for (int i = 0; i < N; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                red[i] = (read[0], read[1]);
            }
            for (int i = 0; i < N; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                blue[i] = (read[0], read[1]);
            }
            red = red.OrderBy(a => a.Item1).ThenBy(a => a.Item2).ToArray();
            blue = blue.OrderBy(a => a.Item1).ThenBy(a => a.Item2).ToArray();
            int cnt = 0;
            int ans = 0;
            var used = new bool[N];
            for (int i = 0; i < N; i++)
            {
                for (int j = N - 1; j >= 0; j--)
                {
                    if (!used[j] && red[j].Item1 <= blue[i].Item1 && red[j].Item2 <= blue[i].Item2)
                    {
                        cnt++;
                        used[j] = true;
                        break;
                    }
                }
            }
            ans = Math.Max(ans, cnt);
            cnt = 0;
            used = used.Select(a => false).ToArray();
            red = red.OrderBy(a => a.Item2).ThenBy(a => a.Item1).ToArray();
            blue = blue.OrderBy(a => a.Item1).ThenBy(a => a.Item2).ToArray();
            for (int i = 0; i < N; i++)
            {
                for (int j = N - 1; j >= 0; j--)
                {
                    if (!used[j] && red[j].Item1 <= blue[i].Item1 && red[j].Item2 <= blue[i].Item2)
                    {
                        cnt++;
                        used[j] = true;
                        break;
                    }
                }
            }
            ans = Math.Max(ans, cnt);
            cnt = 0;
            used = used.Select(a => false).ToArray();
            red = red.OrderBy(a => a.Item1).ThenBy(a => a.Item2).ToArray();
            blue = blue.OrderBy(a => a.Item2).ThenBy(a => a.Item1).ToArray();
            for (int i = 0; i < N; i++)
            {
                for (int j = N - 1; j >= 0; j--)
                {
                    if (!used[j] && red[j].Item1 <= blue[i].Item1 && red[j].Item2 <= blue[i].Item2)
                    {
                        cnt++;
                        used[j] = true;
                        break;
                    }
                }
            }
            ans = Math.Max(ans, cnt);
            cnt = 0;
            used = used.Select(a => false).ToArray();
            red = red.OrderBy(a => a.Item2).ThenBy(a => a.Item1).ToArray();
            blue = blue.OrderBy(a => a.Item2).ThenBy(a => a.Item1).ToArray();
            for (int i = 0; i < N; i++)
            {
                for (int j = N - 1; j >= 0; j--)
                {
                    if (!used[j] && red[j].Item1 <= blue[i].Item1 && red[j].Item2 <= blue[i].Item2)
                    {
                        cnt++;
                        used[j] = true;
                        break;
                    }
                }
            }
            Console.WriteLine(ans);
        }
        public static void ABC153_C()
        {
            var NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var H = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long ans = 0;
            H = H.OrderByDescending(a => a).ToArray();
            for (int i = NK[1]; i < NK[0]; i++)
            {
                ans += H[i];
            }
            Console.WriteLine(ans);
        }
        public static void ABC047_D()
        {
            var NT = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long r = 0;
            var Aindex = new (int, int)[NT[0]];
            int min = intMax;
            int ans = 0;
            for (int i = 0; i < NT[0]; i++)
            {
                r = Math.Max(r, A[i] - min);
                min = Math.Min(min, A[i]);
            }
            min = intMax;
            for (int i = 0; i < NT[0]; i++)
            {
                if (r == A[i] - min) ans++;
                min = Math.Min(min, A[i]);
            }
            Console.WriteLine(ans);
        }
        public static void ABC048_D()
        {
            var S = Console.ReadLine();
            if (S[0] != S[S.Length - 1])
            {
                if (S.Length % 2 == 0)
                {
                    Console.WriteLine("Second");
                }
                else
                {
                    Console.WriteLine("First");
                }
            }
            else
            {
                if (S.Length % 2 == 1)
                {
                    Console.WriteLine("Second");
                }
                else
                {
                    Console.WriteLine("First");
                }
            }
        }
        public static void ABC166_C()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var H = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var list = new List<List<int>>();
            for (int i = 0; i < NM[0]; i++)
            {
                list.Add(new List<int>());
            }
            for (int i = 0; i < NM[1]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                read[0]--;
                read[1]--;
                list[read[0]].Add(read[1]);
                list[read[1]].Add(read[0]);
            }
            int cnt = 0;
            for (int i = 0; i < NM[0]; i++)
            {
                var ok = true;
                foreach (var nxt in list[i])
                {
                    if (H[i] <= H[nxt]) ok = false;
                }
                if (ok) cnt++;
            }
            Console.WriteLine(cnt);
        }
        public static void ABC092_C()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long all = 0;
            for (int i = 0; i <= N; i++)
            {
                if (i == 0)
                {
                    all += Math.Abs(A[i]);
                }
                else if (i == N)
                {
                    all += Math.Abs(A[N - 1]);
                }
                else
                {
                    all += Math.Abs(A[i] - A[i - 1]);
                }
            }
            for (int i = 0; i < N; i++)
            {
                long ans = all;
                if (i == N - 1)
                {
                    ans -= Math.Abs(Math.Abs(0 - A[i - 1]) - (Math.Abs(A[i] - A[i - 1]) + Math.Abs(0 - A[i])));
                }
                else if (i == 0)
                {
                    ans -= Math.Abs(Math.Abs(A[i + 1] - 0) - (Math.Abs(A[i] - 0) + Math.Abs(A[i + 1] - A[i])));
                }
                else
                {

                    ans -= Math.Abs(Math.Abs(A[i + 1] - A[i - 1]) - (Math.Abs(A[i] - A[i - 1]) + Math.Abs(A[i + 1] - A[i])));
                }
                Console.WriteLine(ans);
            }
        }
        public static void ABC098_C()
        {
            int N = int.Parse(Console.ReadLine());
            var S = Console.ReadLine();
            int W = 0;
            int E = 0;
            for (int i = 0; i < N; i++)
            {
                if (S[i] == 'W')
                {
                    W++;
                }
                else
                {
                    E++;
                }
            }
            int ans = intMax;
            int nowE = 0;
            int nowW = 0;
            for (int i = 0; i < N; i++)
            {
                if (S[i] == 'E')
                {
                    ans = Math.Min(ans, nowW + E - (nowE + 1));
                }
                else
                {
                    ans = Math.Min(ans, nowW + E - nowE);
                }

                if (S[i] == 'W')
                {
                    nowW++;
                }
                else
                {
                    nowE++;
                }

            }
            Console.WriteLine(ans);
        }
        public static void ABC140_B()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var B = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var C = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int ans = 0;
            for (int i = 0; i < N; i++)
            {
                ans += B[A[i] - 1];
                if (i > 0)
                {
                    if (A[i] == A[i - 1] + 1)
                    {
                        ans += C[A[i] - 2];
                    }
                }
            }
            Console.WriteLine(ans);
        }
        public static void ABC104_C()
        {
            var DG = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var problems = new (int, int)[DG[0]];
            for (int i = 0; i < DG[0]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                problems[i] = (read[0], read[1]);
            }
            int ans = intMax;
            for (int i = 0; i < 1 << DG[0]; i++)
            {
                var bit = new bool[DG[0]];
                int tnum = 0;
                int tscore = 0;
                for (int j = 0; j < DG[0]; j++)
                {
                    if ((i & (1 << j)) > 0)
                    {
                        bit[j] = true;
                        tnum += problems[j].Item1;
                        tscore += problems[j].Item1 * (j + 1) * 100 + problems[j].Item2;
                    }
                }
                int idx = DG[0] - 1;
                while (idx >= 0 && tscore < DG[1])
                {
                    if (bit[idx])
                    {
                        idx--;
                        continue;
                    }
                    for (int j = 1; j <= problems[idx].Item1; j++)
                    {
                        tnum++;
                        tscore += (idx + 1) * 100;
                        if (tscore >= DG[1]) break;
                    }
                    idx--;
                }
                ans = Math.Min(ans, tnum);
            }
            Console.WriteLine(ans);
        }
        public static void ABC057_D()
        {
            var NAB = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = NAB[0];
            int A = NAB[1];
            int B = NAB[2];
            var v = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var comb = new long[51, 51];
            for (int i = 0; i <= 50; i++)
            {
                for (int j = 0; j <= 50; j++)
                {
                    if (j == 0 || j == i)
                    {
                        comb[i, j] = 1;
                    }
                    else
                    {
                        if (i >= 1)
                            comb[i, j] = comb[i - 1, j - 1] + comb[i - 1, j];
                    }
                }
            }
            v = v.OrderByDescending(a => a).ToArray();
            double ave = 0;
            long sum = 0;
            for (int i = 0; i < A; i++)
            {
                sum += v[i];
            }
            ave = (double)sum / A;
            int num = 0;
            int pos = 0;
            for (int i = 0; i < N; i++)
            {
                if (v[i] == v[A - 1])
                {
                    num++;
                    if (i < A)
                    {
                        pos++;
                    }
                }
            }
            long cnt = 0;
            if (pos == A)
            {
                for (pos = A; pos <= B; pos++)
                {
                    cnt += comb[num, pos];
                }
            }
            else
            {
                cnt += comb[num, pos];
            }
            Console.WriteLine(ave);
            Console.WriteLine(cnt);
        }
        public static void ABC058_D()
        {
            var NM = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var x = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var y = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long mod = 1000000007;
            long area = (x[x.Length - 1] - x[0]) * (y[y.Length - 1] - y[0]);
            long ans = 0;
            long sumX = 0;
            long sumY = 0;
            for (int i = 1; i <= x.Length; i++)
            {
                sumX += (i - 1) * x[i - 1] - (NM[0] - i) * x[i - 1];
                sumX %= mod;
            }
            for (int i = 1; i <= y.Length; i++)
            {
                sumY += (i - 1) * y[i - 1] - (NM[1] - i) * y[i - 1];
                sumY %= mod;
            }
            ans = sumX * sumY;
            ans %= mod;
            Console.WriteLine(ans);
        }
        public static void ABC059_D()
        {
            var XY = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long X = XY[0];
            long Y = XY[1];
            if (Math.Abs(X - Y) <= 1)
            {
                Console.WriteLine("Brown");
            }
            else
            {
                Console.WriteLine("Alice");
            }
        }
        public static void ABC060_D()
        {
            var NW = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = NW[0];
            int W = NW[1];
            var goods = new (long, long)[N];
            var group = new List<List<long>>();
            group.Add(new List<long>());
            group.Add(new List<long>());
            group.Add(new List<long>());
            group.Add(new List<long>());
            for (int i = 0; i < N; i++)
            {
                var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
                goods[i] = (read[0], read[1]);
            }
            for (int i = 0; i < N; i++)
            {
                group[(int)Math.Abs(goods[i].Item1 - goods[0].Item1)].Add(goods[i].Item2);
            }
            for (int i = 0; i < 4; i++)
            {
                group[i] = group[i].OrderByDescending(a => a).ToList();
            }
            var sum = new long[4, Math.Max(group[0].Count, Math.Max(group[1].Count, Math.Max(group[2].Count, group[3].Count))) + 1];
            for (int i = 0; i < 4; i++)
            {
                if (group[i].Count > 0)
                    sum[i, 1] = group[i][0];
                for (int j = 2; j <= group[i].Count; j++)
                {
                    sum[i, j] = sum[i, j - 1] + group[i][j - 1];
                }
            }
            long ans = 0;
            for (int i = 0; i <= group[0].Count; i++)
            {
                for (int j = 0; j <= group[1].Count; j++)
                {
                    for (int k = 0; k <= group[2].Count; k++)
                    {
                        for (int l = 0; l <= group[3].Count; l++)
                        {
                            if (goods[0].Item1 * i + (goods[0].Item1 + 1) * j + (goods[0].Item1 + 2) * k + (goods[0].Item1 + 3) * l <= W)
                            {
                                ans = Math.Max(ans, sum[0, i] + sum[1, j] + sum[2, k] + sum[3, l]);
                            }
                        }
                    }
                }
            }
            Console.WriteLine(ans);
        }
        public static void ABC061_D()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = NM[0];
            int M = NM[1];
            var dist = new long[N];
            dist = dist.Select(a => longMax).ToArray();
            dist[0] = 0;
            var a = new long[M];
            var b = new long[M];
            var c = new long[M];
            for (int i = 0; i < M; i++)
            {
                var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
                read[0]--;
                read[1]--;
                a[i] = read[0];
                b[i] = read[1];
                c[i] = -read[2];
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (dist[a[j]] == longMax) continue;

                    if (dist[b[j]] > dist[a[j]] + c[j])
                    {
                        dist[b[j]] = dist[a[j]] + c[j];
                    }
                }
            }
            long ans = dist[N - 1];
            var negative = new bool[N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (dist[a[j]] == longMax) continue;
                    if (dist[b[j]] > dist[a[j]] + c[j])
                    {
                        dist[b[j]] = dist[a[j]] + c[j];
                        negative[b[j]] = true;
                    }
                    if (negative[a[j]])
                    {
                        negative[b[j]] = true;
                    }
                }
            }

            if (negative[N - 1]) Console.WriteLine("inf");
            else Console.WriteLine(-ans);
        }
        public static void ABC062_D()
        {
            int N = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var pq1 = new PriorityQueue<long>(N, Comparer<long>.Create((x, y) => (int)(y - x)));
            long sum = 0;
            for (int i = 0; i < N; i++)
            {
                pq1.Push(a[i]);
                sum += a[i];
            }
            var L = new long[3 * N];
            L[N - 1] = sum;
            for (int i = N; i < 2 * N; i++)
            {
                if (pq1.Root < a[i])
                {
                    sum -= pq1.Root;
                    pq1.Pop();
                    sum += a[i];
                    pq1.Push(a[i]);
                }
                L[i] = sum;
            }
            sum = 0;
            var R = new long[3 * N];
            var pq2 = new PriorityQueue<long>(N);
            for (int i = 3 * N - 1; i >= 2 * N; i--)
            {
                sum += a[i];
                pq2.Push(a[i]);
            }
            R[2 * N] = sum;
            for (int i = 2 * N - 1; i >= N; i--)
            {
                if (pq2.Root > a[i])
                {
                    sum -= pq2.Root;
                    pq2.Pop();
                    sum += a[i];
                    pq2.Push(a[i]);
                }
                R[i] = sum;
            }
            long ans = -longMax;
            for (int i = N; i <= 2 * N; i++)
            {
                ans = Math.Max(ans, L[i - 1] - R[i]);
            }
            Console.WriteLine(ans);
        }
        public static void ABC065_D()
        {
            int N = int.Parse(Console.ReadLine());
            var point = new (long, long, int)[N];
            for (int i = 0; i < N; i++)
            {
                var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
                point[i] = (read[0], read[1], i);
            }
            var kruskal = new Kruskal(N);
            point = point.OrderBy(a => a.Item1).ToArray();
            for (int i = 0; i < N - 1; i++)
            {
                kruskal.Add(point[i].Item3, point[i + 1].Item3, Math.Min(Math.Abs(point[i].Item2 - point[i + 1].Item2), Math.Abs(point[i].Item1 - point[i + 1].Item1)));
            }
            point = point.OrderBy(a => a.Item2).ToArray();
            for (int i = 0; i < N - 1; i++)
            {
                kruskal.Add(point[i].Item3, point[i + 1].Item3, Math.Min(Math.Abs(point[i].Item2 - point[i + 1].Item2), Math.Abs(point[i].Item1 - point[i + 1].Item1)));
            }
            long ans = kruskal.GetMinSpanCost();
            Console.WriteLine(ans);
        }
        public static void ABC063_D()
        {
            var NAB = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long N = NAB[0];
            long A = NAB[1];
            long B = NAB[2];
            var monsters = new long[N];
            for (int i = 0; i < N; i++)
            {
                monsters[i] = long.Parse(Console.ReadLine());
            }

            monsters = monsters.OrderByDescending(a => a).ToArray();
            long l = 0;
            long r = 1000000001;
            while (r - l > 1)
            {
                long mid = (l + r) / 2;
                long cnt = 0;
                for (int i = 0; i < N; i++)
                {
                    if (monsters[i] > mid * B)
                    {
                        long temp = monsters[i] - mid * B;
                        cnt += (long)Math.Ceiling((decimal)temp / (A - B));
                    }
                }
                if (cnt <= mid) r = mid;
                else l = mid;
            }
            Console.WriteLine(r);
        }
        public static void ABC066_D()
        {
            int N = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var cnt = new Dictionary<int, int>();
            var comb = new Comb(N + 1);
            int l = 0;
            int r = 0;
            for (int i = 0; i < N + 1; i++)
            {
                if (!cnt.ContainsKey(a[i]))
                {
                    cnt.Add(a[i], i);
                }
                else
                {
                    l = cnt[a[i]] + 1;
                    r = i + 1;
                }
            }
            for (int i = 1; i <= N + 1; i++)
            {
                long ans = comb.nCk(N + 1, i);
                if (l + N - r >= i - 1)
                    ans -= comb.nCk(l + N - r, i - 1);
                Console.WriteLine((ans + 1000000007) % 1000000007);
            }
        }
        public static void ABC067_D()
        {
            int N = int.Parse(Console.ReadLine());
            var edges = new List<List<int>>();
            for (int i = 0; i < N; i++)
            {
                edges.Add(new List<int>());
            }
            for (int i = 0; i < N - 1; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                read[0]--;
                read[1]--;
                edges[read[0]].Add(read[1]);
                edges[read[1]].Add(read[0]);
            }
            var feneck = new int[N];
            var snuke = new int[N];
            feneck = feneck.Select(a => intMax).ToArray();
            snuke = snuke.Select(a => intMax).ToArray();
            var visited = new bool[N];
            var q = new Queue<(int, int)>();
            q.Enqueue((0, 0));
            while (q.Count > 0)
            {
                var now = q.Dequeue();
                visited[now.Item1] = true;
                feneck[now.Item1] = Math.Min(feneck[now.Item1], now.Item2);
                foreach (var nxt in edges[now.Item1])
                {
                    if (!visited[nxt])
                    {
                        visited[nxt] = true;
                        q.Enqueue((nxt, now.Item2 + 1));
                    }
                }
            }
            visited = new bool[N];
            q.Enqueue((N - 1, 0));
            while (q.Count > 0)
            {
                var now = q.Dequeue();
                visited[now.Item1] = true;
                snuke[now.Item1] = Math.Min(snuke[now.Item1], now.Item2);
                foreach (var nxt in edges[now.Item1])
                {
                    if (!visited[nxt])
                    {
                        visited[nxt] = true;
                        q.Enqueue((nxt, now.Item2 + 1));
                    }
                }
            }
            int snukecnt = 0;
            int feneckcnt = 0;
            for (int i = 0; i < N; i++)
            {
                if (snuke[i] < feneck[i])
                {
                    snukecnt++;
                }
                else
                {
                    feneckcnt++;
                }
            }
            if (feneckcnt > snukecnt) Console.WriteLine("Fennec");
            else Console.WriteLine("Snuke");
        }
        public static void ABC154_C()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var set = new Set<int>();
            for (int i = 0; i < N; i++)
            {
                set.Add(A[i]);
            }
            if (set.Count != N) Console.WriteLine("NO");
            else Console.WriteLine("YES");
        }
        public static void ABC156_C()
        {
            int N = int.Parse(Console.ReadLine());
            var X = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long ans = longMax;
            for (int i = 0; i <= 100; i++)
            {
                long temp = 0;
                for (int j = 0; j < N; j++)
                {
                    temp += (i - X[j]) * (i - X[j]);
                }
                ans = Math.Min(ans, temp);
            }
            Console.WriteLine(ans);
        }
        public static void ABC169_C()
        {
            var AB = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
            decimal ans = AB[0] * AB[1];
            Console.WriteLine(Math.Floor(ans));
        }
        public static void ABC170_C()
        {
            var XN = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (XN[1] == 0)
            {
                Console.WriteLine(XN[0]);
                return;
            }
            var p = Console.ReadLine().Split().Select(int.Parse).ToList();
            p = p.OrderBy(a => a).ToList();
            int diff = 0;

            while (true)
            {

                if (p.BinarySearch(XN[0] - diff) < 0)
                {
                    Console.WriteLine(XN[0] - diff);
                    return;
                }
                else if (p.BinarySearch(XN[0] + diff) < 0)
                {
                    Console.WriteLine(XN[0] + diff);
                    return;
                }
                diff++;
            }
        }
        public static void ABC254_D()
        {
            int N = int.Parse(Console.ReadLine());
            long ans = 0;
            var sq = new bool[N + 1];
            for (int i = 1; i * i <= N; i++)
            {
                sq[i * i] = true;
            }
            var d = new List<List<int>>();
            for (int i = 0; i <= N; i++)
            {
                d.Add(new List<int>());
            }
            for (int i = 1; i <= N; i++)
            {
                for (int j = i; j <= N; j += i)
                {
                    d[j].Add(i);
                }
            }
            var cnt = new long[N + 1];
            for (int i = 1; i <= N; i++)
            {
                int f = 0;
                for (int j = 0; j < d[i].Count; j++)
                {
                    if (sq[d[i][j]]) f = d[i][j];
                }
                cnt[i / f]++;
            }
            for (int i = 1; i <= N; i++)
            {
                ans += cnt[i] * cnt[i];
            }
            Console.WriteLine(ans);
        }
        public static void ABC171_D()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int Q = int.Parse(Console.ReadLine());
            var cnt = new long[1000001];
            long sum = 0;
            for (int i = 0; i < N; i++)
            {
                cnt[A[i]]++;
                sum += A[i];
            }

            while (Q-- > 0)
            {
                var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
                long temp = cnt[read[0]] * (read[1] - read[0]);
                sum += temp;
                long tempcnt = cnt[read[0]];
                cnt[read[0]] = 0;
                cnt[read[1]] += tempcnt;
                Console.WriteLine(sum);
            }
        }
        public static void ABC164_D()
        {
            var S = Console.ReadLine();
            var list = new List<int>();
            var cnt = new int[2020];
            cnt[0] = 1;
            int tot = 0;
            int p = 1;
            long ans = 0;
            for (int i = S.Length - 1; i >= 0; i--)
            {
                tot = (tot + (S[i] - '0') * p) % 2019;
                ans += cnt[tot];
                p = (p * 10) % 2019;
                cnt[tot]++;
            }
            Console.WriteLine(ans);
        }
        public static void ABC171_C()
        {
            long N = long.Parse(Console.ReadLine());
            var list = new List<char>();
            while (N > 0)
            {
                long temp = N % 26;
                if (temp == 0)
                {
                    list.Add('z');
                }
                else
                {
                    list.Add((char)('a' + (temp - 1)));
                }

                N /= 26;
                if (temp == 0) N--;
            }
            list.Reverse();
            Console.WriteLine(new String(list.ToArray()));
        }
        public static void ABC170_D()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            A = A.OrderBy(a => a).ToArray();
            var cnt = new int[1000001];
            var seen = new bool[1000001];
            var ok = new bool[1000001];
            ok = ok.Select(a => true).ToArray();
            for (int i = 0; i < N; i++)
            {
                cnt[A[i]]++;
                if (seen[A[i]])
                {
                    ok[A[i]] = false;
                    continue;
                }
                int now = A[i] * 2;
                seen[A[i]] = true;
                while (now < 1000001)
                {
                    ok[now] = false;
                    now += A[i];
                }
            }
            int ans = 0;
            for (int i = 0; i < N; i++)
            {
                if (ok[A[i]]) ans++;
            }
            Console.WriteLine(ans);
        }
        public static void ABC174_D()
        {
            int N = int.Parse(Console.ReadLine());
            String c = Console.ReadLine();
            int rcnt = 0;
            for (int i = 0; i < N; i++)
            {
                if (c[i] == 'R') rcnt++;
            }
            int ans = 0;
            for (int i = 0; i < rcnt; i++)
            {
                if (c[i] == 'W') ans++;
            }
            Console.WriteLine(ans);
        }
        public static void ABC172_C()
        {
            var NMK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = NMK[0];
            int M = NMK[1];
            int K = NMK[2];
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var B = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var sumA = new long[N + 1];
            var sumB = new long[M + 1];
            for (int i = 1; i <= N; i++)
            {
                sumA[i] += sumA[i - 1] + A[i - 1];
            }
            for (int i = 1; i <= M; i++)
            {
                sumB[i] += sumB[i - 1] + B[i - 1];
            }
            int ans = 0;
            int j = M;
            for (int i = 0; i <= N; i++)
            {
                if (sumA[i] > K) break;

                while (sumB[j] > K - sumA[i])
                {
                    j--;
                }
                ans = Math.Max(ans, i + j);
            }
            Console.WriteLine(ans);
        }
        public static void ABC169_B()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            BigInteger multi = new BigInteger();
            if (A.ToList().IndexOf(0) >= 0)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = 0; i < N; i++)
            {
                if (i == 0) multi = A[i];
                else multi *= A[i];
                if (multi > 1000000000000000000)
                {
                    Console.WriteLine(-1);
                    return;
                }
            }
            Console.WriteLine(multi);
        }
        public static void ABC173_C()
        {
            var HWK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int H = HWK[0];
            int W = HWK[1];
            int K = HWK[2];
            int ans = 0;
            var grid = new char[H][];
            for (int i = 0; i < H; i++)
            {
                grid[i] = Console.ReadLine().ToCharArray();
            }
            for (int i = 0; i < 1 << H; i++)
            {
                for (int j = 0; j < 1 << W; j++)
                {
                    var paintH = new bool[H];
                    var paintW = new bool[W];
                    for (int k = 0; k < H; k++)
                    {
                        if ((i & (1 << k)) > 0)
                        {
                            paintH[k] = true;
                        }
                    }
                    for (int k = 0; k < W; k++)
                    {
                        if ((j & (1 << k)) > 0)
                        {
                            paintW[k] = true;
                        }
                    }
                    int cnt = 0;
                    for (int k = 0; k < H; k++)
                    {
                        for (int l = 0; l < W; l++)
                        {
                            if (!paintH[k] && !paintW[l] && grid[k][l] == '#')
                            {
                                cnt++;
                            }
                        }
                    }
                    if (cnt == K) ans++;
                }
            }
            Console.WriteLine(ans);
        }
        public static void ABC193_C()
        {
            long N = long.Parse(Console.ReadLine());
            long ans = N;
            var seen = new bool[(int)Math.Sqrt(N) + 1];
            for (long i = 2; i <= Math.Sqrt(N); i++)
            {
                long now = i * i;
                if (seen[i]) continue;
                seen[i] = true;
                int temp = 0;
                while (now <= N)
                {
                    if (now <= (int)Math.Sqrt(N))
                        seen[now] = true;
                    temp++;
                    now *= i;
                }
                ans -= temp;
            }
            Console.WriteLine(ans);
        }
        public static void ABC192_C()
        {
            var NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long ans = NK[0];
            for (int i = 0; i < NK[1]; i++)
            {
                ans = calc(Convert.ToString(ans));
            }
            Console.WriteLine(ans);
            long calc(String S)
            {
                var charS = S.ToCharArray();
                var g1 = new List<char>();
                var g2 = new List<char>();
                for (int i = 0; i < S.Length; i++)
                {
                    g1.Add(charS[i]);
                    if (charS[i] != '0')
                        g2.Add(charS[i]);
                }
                g1 = g1.OrderByDescending(a => a).ToList();
                g2 = g2.OrderBy(a => a).ToList();
                long num1 = 0;
                long num2 = 0;
                if (g1.Count > 0)
                    num1 = Convert.ToInt64(new String(g1.ToArray()));
                if (g2.Count > 0)
                    num2 = Convert.ToInt64(new String(g2.ToArray()));
                long ret = num1 - num2;
                return ret;
            }
        }
        public static void ABC175_C()
        {
            var XKD = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long X = XKD[0];
            long K = XKD[1];
            long D = XKD[2];
            BigInteger KD = K;
            KD *= D;
            long ans = 0;
            if (KD <= Math.Abs(X))
            {
                ans = Math.Abs(X) - (long)KD;
            }
            else
            {
                long cnt = Math.Abs(X) / D;
                if ((K - cnt) % 2 == 0)
                {
                    ans = Math.Abs(X) - cnt * D;
                }
                else
                {
                    ans = Math.Min(Math.Abs(Math.Abs(X) - (cnt + 1) * D), Math.Abs(X) - cnt * D + D);
                }
            }
            Console.WriteLine(ans);
        }
        public static void ABC204_D()
        {
            int N = int.Parse(Console.ReadLine());
            var T = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            var dp = new bool[N + 1, 101001];
            dp[0, 0] = true;
            for (int i = 1; i <= N; i++)
            {
                for (int j = 0; j < 100001; j++)
                {
                    if (dp[i - 1, j])
                    {
                        dp[i, j] = true;
                        dp[i, j + T[i - 1]] = true;
                    }
                }
                sum += T[i - 1];
            }
            int ans = intMax;
            for (int i = 0; i <= 100000; i++)
            {
                if (dp[N, i])
                {
                    ans = Math.Min(ans, Math.Max(i, sum - i));
                }
            }
            Console.WriteLine(ans);
        }
        public static void ABC190_C()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var jouken = new (int, int)[NM[1]];
            for (int i = 0; i < NM[1]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                read[0]--;
                read[1]--;
                jouken[i] = (read[0], read[1]);
            }
            int K = int.Parse(Console.ReadLine());
            var put = new (int, int)[K];
            int ans = 0;
            for (int i = 0; i < K; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                read[0]--;
                read[1]--;
                put[i] = (read[0], read[1]);
            }
            for (int i = 0; i < 1 << K; i++)
            {
                var ball = new bool[NM[0]];
                for (int j = 0; j < K; j++)
                {
                    if ((i & (1 << j)) > 0)
                    {
                        ball[put[j].Item1] = true;
                    }
                    else
                    {
                        ball[put[j].Item2] = true;
                    }
                }
                int cnt = 0;
                for (int j = 0; j < NM[1]; j++)
                {
                    if (ball[jouken[j].Item1] && ball[jouken[j].Item2]) cnt++;
                }
                ans = Math.Max(ans, cnt);
            }
            Console.WriteLine(ans);
        }
        public static void ABC181_D()
        {
            String S = Console.ReadLine();
            var list = new Dictionary<char, int>();
            for (int i = 0; i < S.Length; i++)
            {
                if (!list.ContainsKey(S[i]))
                {
                    list.Add(S[i], 1);
                }
                else
                {
                    list[S[i]]++;
                }
            }
            for (int i = 1; i * 8 <= 1000; i++)
            {
                int temp = i * 8;
                var ctemp = Convert.ToString(temp).ToCharArray();
                var tlist = new Dictionary<char, int>();
                if ((S.Length >= 4 && ctemp.Length < 3) || ctemp.Contains('0'))
                {
                    continue;
                }
                for (int j = 0; j < ctemp.Length; j++)
                {
                    if (!tlist.ContainsKey(ctemp[j]))
                    {
                        tlist.Add(ctemp[j], 1);
                    }
                    else
                    {
                        tlist[ctemp[j]]++;
                    }
                }
                var ok = true;
                if (S.Length >= 4)
                {
                    foreach (var c in tlist)
                    {
                        if (!list.ContainsKey(c.Key))
                        {
                            ok = false;
                        }
                        else if (list[c.Key] < c.Value)
                        {
                            ok = false;
                        }
                    }
                }
                else
                {
                    foreach (var c in tlist)
                    {
                        if (!list.ContainsKey(c.Key) || list[c.Key] != c.Value)
                        {
                            ok = false;
                        }
                    }
                    if (ctemp.Length != S.Length)
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
            Console.WriteLine("No");
        }
        public static void ABC177_C()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long ans = 0;
            var sum = new long[N + 1];
            long mod = 1000000007;
            for (int i = 1; i <= N; i++)
            {
                sum[i] = sum[i - 1] + A[i - 1];
                sum[i - 1] %= mod;
            }
            for (int i = 0; i < N; i++)
            {
                ans += A[i] * ((sum[N] - sum[i + 1] + mod) % mod);
                ans %= mod;
            }
            Console.WriteLine(ans);
        }
        public static void ABC178_C()
        {
            int N = int.Parse(Console.ReadLine());

            long ans = 0;
            long mod = 1000000007;
            long ten = 10;
            long eight = 8;
            long nine = 9;
            for (int i = 1; i < N; i++)
            {
                ten *= 10;
                ten %= mod;
                eight *= 8;
                eight %= mod;
                nine *= 9;
                nine %= mod;
            }
            ans = ten - nine - nine + eight;
            ans %= mod;
            Console.WriteLine((ans + mod) % mod);
        }
        public static void ABC181_C()
        {
            int N = int.Parse(Console.ReadLine());
            var point = new (int, int)[N];
            for (int i = 0; i < N; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                point[i] = (read[0], read[1]);
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    int dx = point[j].Item1 - point[i].Item1;
                    int dy = point[j].Item2 - point[i].Item2;
                    int p = 0;
                    if (dx != 0 && dy != 0)
                    {
                        p = (int)MyMath.gcd(dx, dy);
                        dx /= p;
                        dy /= p;
                    }
                    for (int k = j + 1; k < N; k++)
                    {
                        int tx = point[k].Item1 - point[j].Item1;
                        int ty = point[k].Item2 - point[j].Item2;
                        int tp = 0;
                        if (tx != 0 && ty != 0)
                        {
                            tp = (int)MyMath.gcd(tx, ty);
                            tx /= tp;
                            ty /= tp;
                            if ((double)ty / tx == (double)dy / dx)
                            {
                                Console.WriteLine("Yes");
                                return;
                            }
                        }
                        else if (tx == 0)
                        {
                            if (dx == 0)
                            {
                                Console.WriteLine("Yes");
                                return;
                            }
                        }
                        else if (ty == 0)
                        {
                            if (dy == 0)
                            {
                                Console.WriteLine("Yes");
                                return;
                            }
                        }
                    }
                }
            }
            Console.WriteLine("No");
        }
        public static void ABC182_C()
        {
            var S = Console.ReadLine().ToCharArray();
            var numS = new int[S.Length];
            for (int i = 0; i < S.Length; i++)
            {
                numS[i] = (S[i] - '0') % 3;
            }
            int sum = numS.Sum();

            var cnt = new int[3];
            for (int i = 0; i < S.Length; i++)
            {
                cnt[numS[i]]++;
            }
            sum %= 3;
            int idx = sum;
            if (sum == 1)
            {
                if (cnt[sum] > 0 && S.Length > 1)
                {
                    Console.WriteLine(1);
                }
                else if (cnt[2] >= 2 && S.Length > 2)
                {
                    Console.WriteLine(2);
                }
                else
                {
                    Console.WriteLine(-1);
                }
            }
            else if (sum == 2)
            {
                if (cnt[sum] > 0 && S.Length > 1)
                {
                    Console.WriteLine(1);
                }
                else if (cnt[1] >= 2 && S.Length > 2)
                {
                    Console.WriteLine(2);
                }
                else
                {
                    Console.WriteLine(-1);
                }
            }
            else
            {
                Console.WriteLine(0);
            }
            /*while (sum > 0 && idx > 0)
            {
                while (cnt[idx] > 0 && sum >= idx)
                {
                    sum -= idx;
                    cnt[idx]--;
                    ans++;
                }
                idx--;
            }
            if (sum > 0 || ans == S.Length)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(ans);
            }*/

        }
        public static void ABC183_C()
        {
            var NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = NK[0];
            int K = NK[1];
            var T = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < N; j++)
                {
                    T[i, j] = read[j];
                }
            }
            var idx = Enumerable.Range(1, N - 1).ToArray();
            int ans = 0;
            do
            {
                int temp = T[0, idx[0]];
                for (int i = 0; i < N - 2; i++)
                {
                    temp += T[idx[i], idx[i + 1]];
                }
                temp += T[idx[N - 2], 0];
                if (temp == K) ans++;
            } while (NextPermutation.Next_Permutation(idx));
            Console.WriteLine(ans);
        }
        public static void ABC196_C()
        {
            long N = long.Parse(Console.ReadLine());
            int ans = 0;
            int now = 1;
            while (true)
            {
                int log = (int)Math.Log10((double)now) + 1;
                long doubled = now * (long)Math.Pow(10, log) + now;
                if (doubled > N) break;
                ans++;
                now++;
            }
            Console.WriteLine(ans);
        }
        public static void ABC192_B()
        {
            String S = Console.ReadLine();
            String small = S.ToLower();
            String big = S.ToUpper();
            var ok = true;
            for (int i = 0; i < S.Length; i++)
            {
                if ((i + 1) % 2 == 1)
                {
                    if (small[i] != S[i])
                    {
                        ok = false;
                    }
                }
                else
                {
                    if (big[i] != S[i])
                    {
                        ok = false;
                    }
                }
            }
            if (ok) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
        public static void ARC143_A()
        {
            var ABC = Console.ReadLine().Split().Select(long.Parse).ToArray();
            Array.Sort(ABC);
            long ans = 0;
            if (ABC[0] + ABC[1] < ABC[2])
            {
                Console.WriteLine(-1);
            }
            else
            {
                ans = ABC[0];
                ans += ABC[2] - ABC[0];
                Console.WriteLine(ans);
            }
        }
        public static void ABC200_C()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var cnt = new long[201];
            for (int i = 0; i < N; i++)
            {
                cnt[A[i] % 200]++;
            }
            long ans = 0;
            for (int i = 0; i < 201; i++)
            {
                ans += (cnt[i] * (cnt[i] - 1)) / 2;
            }
            /*for (int i = 0; i < 201; i++)
            {
                for (int j = i + 1; j < 201; j++)
                {
                    if (i - j % 200 == 0)
                        ans += cnt[i] * cnt[j];
                }
            }*/
            Console.WriteLine(ans);
        }
        public static void ABC203_C()
        {
            var NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = NK[0];
            long K = NK[1];
            var list = new Dictionary<long, long>();
            for (int i = 0; i < N; i++)
            {
                var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
                if (!list.ContainsKey(read[0]))
                {
                    list.Add(read[0], read[1]);
                }
                else
                {
                    list[read[0]] += read[1];
                }
            }
            long now = 0;
            long pre = 0;
            list = list.OrderBy(a => a.Key).ToDictionary(a => a.Key, a => a.Value);
            foreach (var i in list)
            {
                if (i.Key - pre <= K)
                {
                    K -= (i.Key - pre);
                    K += i.Value;
                    now = i.Key;
                    pre = i.Key;
                }
            }
            now += K;
            Console.WriteLine(now);
        }
        public static void ABC189_C()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long ans = 0;
            for (int i = 0; i < N; i++)
            {
                long now = A[i];
                long seq = 0;
                long cnt = 0;
                for (int j = 0; j < N; j++)
                {
                    if (A[j] < now)
                    {
                        cnt = 0;
                    }
                    else
                    {
                        cnt++;
                    }
                    seq = Math.Max(seq, cnt);
                }
                ans = Math.Max(ans, now * seq);
            }
            Console.WriteLine(ans);
        }
        public static void ABC188_C()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int first = 0;
            int fidx = 0;
            int second = 0;
            int sidx = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (i < Math.Pow(2, N) / 2)
                {
                    if (first < A[i])
                    {
                        first = A[i];
                        fidx = i;
                    }
                }
                else
                {
                    if (second < A[i])
                    {
                        second = A[i];
                        sidx = i;
                    }
                }
            }
            if (first > second)
            {
                Console.WriteLine(sidx + 1);
            }
            else
            {
                Console.WriteLine(fidx + 1);
            }
        }
        /// <summary>
        /// doubling
        /// </summary>
        public static void ABC167_D()
        {
            var NK = Console.ReadLine().Split().Select(long.Parse).ToArray();
            int N = (int)NK[0];
            long K = NK[1];
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            A = A.Select(a => a - 1).ToArray();
            int logk = 1;
            while (((long)1 << logk) < K)
            {
                logk++;
            }
            var doubling = new int[logk, N];
            for (int i = 0; i < N; i++)
            {
                doubling[0, i] = A[i];
            }
            for (int k = 0; k < logk - 1; k++)
            {
                for (int i = 0; i < N; i++)
                {
                    doubling[k + 1, i] = doubling[k, doubling[k, i]];
                }
            }
            int now = 0;
            for (int k = 0; K > 0; k++)
            {
                if ((K & 1) > 0) now = doubling[k, now];
                K = K >> 1;
            }
            Console.WriteLine(now + 1);
        }
        /// <summary>
        /// オイラーツアー
        /// </summary>
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
                read[0]--;
                read[1]--;
                graph[read[0]].Add(read[1]);
                graph[read[1]].Add(read[0]);
            }
            graph = graph.Select(a => a.OrderBy(b => b).ToList()).ToList();
            var visited = new bool[N];
            var s = new Stack<int>();
            var path = new List<int>();
            s.Push(0);
            dfs(0, -1);
            var sb = new StringBuilder();
            foreach (var i in path)
            {
                sb.Append($"{i} ");
            }
            Console.WriteLine(sb.ToString().TrimEnd());
            void dfs(int now, int pre)
            {
                //visited[now] = true;
                path.Add(now + 1);
                foreach (var nxt in graph[now])
                {
                    if (nxt != pre)
                    {
                        //s.Push(nxt);
                        //visited[nxt] = true;
                        dfs(nxt, now);
                        path.Add(now + 1);
                    }
                }
                /*while (s.Count > 0)
                {
                    int back = s.Peek();
                    if (back == now)
                    {
                        s.Pop();
                        continue;
                    }
                    path.Add(back + 1);
                    dfs(back);
                }*/
            }
        }
        public static void ABC212_D()
        {
            int Q = int.Parse(Console.ReadLine());
            long add = 0;
            //var pq = new PriorityQueue<long>(Q, Comparer<long>.Create((x, y) => (y - x)));
            var set = new Set<long>();
            set.IsMultiSet = true;
            while (Q-- > 0)
            {
                var read = Console.ReadLine().Split().Select(long.Parse).ToArray();
                if (read[0] == 1)
                {
                    set.Add(read[1] - add);
                }
                else if (read[0] == 2)
                {
                    add += read[1];
                }
                else
                {
                    long ans = set[0] + add;
                    set.RemoveAt(0);
                    Console.WriteLine(ans);
                }
            }
        }
        public static void ABC187_C()
        {
            int N = int.Parse(Console.ReadLine());
            var zero = new Dictionary<String, int>();
            var one = new Dictionary<String, int>();
            for (int i = 0; i < N; i++)
            {
                String read = Console.ReadLine();
                if (read[0] == '!')
                {
                    if (zero.ContainsKey(read.Substring(1, read.Length - 1)))
                    {
                        Console.WriteLine(read.Substring(1, read.Length - 1));
                        return;
                    }
                    else
                    {
                        if (!one.ContainsKey(read.Substring(1, read.Length - 1)))
                        {
                            one.Add(read.Substring(1, read.Length - 1), 1);
                        }
                    }
                }
                else
                {
                    if (one.ContainsKey(read))
                    {
                        Console.WriteLine(read);
                        return;
                    }
                    else
                    {
                        if (!zero.ContainsKey(read))
                        {
                            zero.Add(read, 1);
                        }
                    }
                }
            }
            Console.WriteLine("satisfiable");
        }
        public static void ABC184_C()
        {
            var rc1 = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var rc2 = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long r = rc2[0] - rc1[0];
            long c = rc2[1] - rc1[1];
            if (r == 0 && c == 0)
            {
                Console.WriteLine(0);
            }
            else if (r == c || r == -c || Math.Abs(r) + Math.Abs(c) <= 3)
            {
                Console.WriteLine(1);
            }
            else if ((r + c) % 2 == 0)
            {
                Console.WriteLine(2);
            }
            else if (Math.Abs(r) + Math.Abs(c) <= 6)
            {
                Console.WriteLine(2);
            }
            else if (Math.Abs(r + c) <= 3)
            {
                Console.WriteLine(2);
            }
            else if (Math.Abs(r - c) <= 3)
            {
                Console.WriteLine(2);
            }
            else
            {
                Console.WriteLine(3);
            }
            /*else if ((rc2[0] + rc2[1]) % 2 == 1 || (rc2[1] - rc2[0]) % 2 == 1)
            {
                Console.WriteLine(3);
            }
            else
            {
                Console.WriteLine(2);
            }*/
        }
        public static void ABC052_B()
        {
            int N = int.Parse(Console.ReadLine());
            String S = Console.ReadLine();
            int x = 0;
            int max = 0;
            for (int i = 0; i < N; i++)
            {
                if (S[i] == 'D')
                {
                    x--;
                    max = Math.Max(max, x);
                }
                else
                {
                    x++;
                    max = Math.Max(max, x);
                }
            }
            Console.WriteLine(max);
        }
        public static void ABC182_D()
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var sum = new long[N + 1];
            for (int i = 0; i < N; i++)
            {
                sum[i + 1] += sum[i] + A[i];
            }
            long max = 0;
            long temp = 0;
            int maxi = 0;
            for (int i = 0; i < N; i++)
            {
                temp += sum[i];
                if (temp >= max)
                {
                    max = temp;
                    maxi = i;
                }
            }
            long presum = 0;
            for (int i = 0; i < maxi; i++)
            {
                presum += sum[i];
            }
            long ans = presum;
            for (int i = 0; i < maxi; i++)
            {
                presum += A[i];
                ans = Math.Max(ans, presum);
            }
            for (int i = 0; i <= maxi; i++)
            {
                presum += A[i];
                ans = Math.Max(ans, presum);
            }
            Console.WriteLine(ans);
        }
        public static void ABC183_D()
        {
            var NW = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var water = new (int, int, int)[NW[0]];
            for (int i = 0; i < NW[0]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                water[i] = (read[0], read[1], read[2]);
            }
            var imos = new long[200002];
            for (int i = 0; i < NW[0]; i++)
            {
                imos[water[i].Item1] += water[i].Item3;
                imos[water[i].Item2] -= water[i].Item3;
            }
            for (int i = 0; i < 200000; i++)
            {
                imos[i + 1] += imos[i];
            }
            var ok = true;
            for (int i = 0; i <= 200000; i++)
            {
                if (imos[i] > NW[1])
                {
                    ok = false;
                }
            }
            if (ok) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
        public static void ABC211_D()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var path = new List<List<int>>();
            for (int i = 0; i < NM[0]; i++)
            {
                path.Add(new List<int>());
            }
            for (int i = 0; i < NM[1]; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                read[0]--;
                read[1]--;
                path[read[0]].Add(read[1]);
                path[read[1]].Add(read[0]);
            }
            var cnt = new long[NM[0]];
            var min = new int[NM[0]];
            min = min.Select(a => intMax).ToArray();
            cnt[0] = 1;
            min[0] = 0;
            var pre = new int[NM[0]];
            var visited = new bool[NM[0]];
            long mod = 1000000007;
            var q = new Queue<int>();
            q.Enqueue(0);
            while (q.Count > 0)
            {
                int now = q.Dequeue();
                visited[now] = true;
                foreach (var nxt in path[now])
                {
                    if (min[nxt] > min[now] + 1)
                    {
                        min[nxt] = min[now] + 1;
                        cnt[nxt] = cnt[now];
                        cnt[nxt] %= mod;
                    }
                    else if (min[nxt] == min[now] + 1)
                    {
                        cnt[nxt] += cnt[now];
                        cnt[nxt] %= mod;
                    }
                    if (!visited[nxt])
                    {
                        visited[nxt] = true;
                        q.Enqueue(nxt);

                    }
                }
            }
            Console.WriteLine(cnt[NM[0] - 1]);
        }
        public static void ABC186_C()
        {
            int N = int.Parse(Console.ReadLine());
            int cnt = 0;
            for (int i = 1; i <= N; i++)
            {
                var temp = Convert.ToString(i);
                var temp8 = Convert.ToString(i, 8);
                if (temp.IndexOf('7') >= 0 || temp8.IndexOf('7') >= 0) continue;
                cnt++;
            }
            Console.WriteLine(cnt);
        }
        public static void ABC185_C()
        {
            int L = int.Parse(Console.ReadLine());
            var fact = new long[201];
            fact[0] = 1;
            fact[1] = 1;
            for (long i = 2; i <= 200; i++)
            {
                fact[i] = fact[i - 1] * i;
            }
            long ans = 1;
            int j = 1;
            for (long i = L - 1; L - i <= 11; i--)
            {
                ans *= i;
                ans /= j;
                j++;
            }
            //ans /= fact[11];
            Console.WriteLine(ans);
        }
        public static void ABC204_C()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = NM[0];
            int M = NM[1];
            var path = new List<List<int>>();
            for (int i = 0; i < N; i++)
            {
                path.Add(new List<int>());
            }
            for (int i = 0; i < M; i++)
            {
                var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                read[0]--;
                read[1]--;
                path[read[0]].Add(read[1]);
            }
            int cnt = N;
            for (int i = 0; i < N; i++)
            {
                var q = new Queue<int>();
                q.Enqueue(i);
                var visited = new bool[N];
                while (q.Count > 0)
                {
                    int now = q.Dequeue();
                    visited[now] = true;
                    foreach (var nxt in path[now])
                    {
                        if (!visited[nxt])
                        {
                            cnt++;
                            visited[nxt] = true;
                            q.Enqueue(nxt);
                        }
                    }
                }
            }
            Console.WriteLine(cnt);
        }
        public static void ABC191_B()
        {
            var NX = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var ans = new List<int>();
            for (int i = 0; i < NX[0]; i++)
            {
                if (A[i] != NX[1])
                {
                    ans.Add(A[i]);
                }
            }
            var sb = new StringBuilder();
            for (int i = 0; i < ans.Count; i++)
            {
                sb.Append($"{ans[i]} ");
            }
            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}

