using System;
using System.Linq;
using System.Collections.Generic;
using static CompLib.CompLib;

namespace atcoder
{
    class Solve
    {
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
    }
}
