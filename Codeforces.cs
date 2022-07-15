using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using DataStructure;
using System.Runtime.CompilerServices;
using System.Text;

namespace atcoder
{
    class Codeforces
    {
        const int intMax = 1000000000;
        const long longMax = 2000000000000000000;
        public static void codeforces_1633_A()
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                int temp = int.Parse(Console.ReadLine());
                int keta = 10;
                int ans = temp;
                while (ans % 7 != 0)
                {
                    ans -= ans % keta;
                    for (int j = 0; j < 9; j++)
                    {
                        ans += 1 * (keta / 10);
                        if (ans % 7 == 0)
                        {
                            break;
                        }
                    }
                    keta *= 10;
                }
                Console.WriteLine(ans);
            }
        }
        public static void codeforces_1633_B()
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                String s = Console.ReadLine();
                int one = 0;
                int zero = 0;
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[j] == '0')
                    {
                        zero++;
                    }
                    else
                    {
                        one++;
                    }
                }
                if (one == zero && s.Length <= 2) Console.WriteLine(0);
                else if (one == zero) Console.WriteLine(one - 1);
                else Console.WriteLine(Math.Min(one, zero));
            }
        }
        public static void codeforces_1633_C()
        {
            int N = int.Parse(Console.ReadLine());
            while (N > 0)
            {
                var character = Console.ReadLine().Split().Select(long.Parse).ToArray();
                var monster = Console.ReadLine().Split().Select(long.Parse).ToArray();
                var option = Console.ReadLine().Split().Select(long.Parse).ToArray();
                var ok = false;
                for (int i = 0; i <= option[0]; i++)
                {
                    long uph = character[0] + (option[0] - i) * option[2];
                    long upa = character[1] + i * option[1];
                    if (Math.Ceiling((decimal)uph / monster[1]) >= Math.Ceiling((decimal)monster[0] / upa))
                    {
                        ok = true;
                        break;

                    }
                    else if (Math.Ceiling((decimal)uph / monster[1]) >= Math.Ceiling((decimal)monster[0] / upa))
                    {
                        ok = true;
                        break;
                    }
                    else
                    {
                        ok = false;
                    }
                }
                if (ok) Console.WriteLine("Yes");
                else Console.WriteLine("No");
                N--;
            }
        }
        public static void codeforces_1626_A()
        {
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                String s = Console.ReadLine();
                var once = new List<char>();
                var twice = new List<char>();
                var sb = new StringBuilder();
                for (int i = 0; i < s.Length; i++)
                {
                    if (!once.Contains(s[i]))
                    {
                        once.Add(s[i]);
                    }
                    else
                    {
                        twice.Add(s[i]);
                    }
                }
                if (twice.Count > 1)
                {
                    for (int i = 0; i < twice.Count; i++)
                    {
                        sb.Append(twice[i]);
                        sb.Append(twice[i]);
                        once.Remove(twice[i]);
                    }
                    foreach (var o in once)
                    {
                        sb.Append(o);
                    }
                }
                else
                {
                    foreach (var o in once)
                    {
                        sb.Append(o);
                    }
                    if (twice.Count == 1)
                    {
                        sb.Append(twice[0]);
                    }
                }
                Console.WriteLine(sb.ToString());
                t--;
            }
        }
        public static void codeforces_1626_C()
        {
            int t = int.Parse(Console.ReadLine());

            while (t > 0)
            {
                int n = int.Parse(Console.ReadLine());
                var k = Console.ReadLine().Split().Select(long.Parse).ToArray();
                var h = Console.ReadLine().Split().Select(long.Parse).ToArray();
                long ans = 0;
                long nowh = h[n - 1];
                long nowk = k[n - 1];
                for (int i = n - 2; i >= 0; i--)
                {
                    if (nowk - k[i] >= nowh)
                    {
                        ans += nowh * (nowh + 1) / 2;
                        nowh = h[i];
                        nowk = k[i];
                    }
                    else if (h[i] > nowh - (nowk - k[i]))
                    {
                        nowh += (h[i] - (nowh - (nowk - k[i])));
                    }
                    if (i == 0)
                    {
                        ans += nowh * (nowh + 1) / 2;
                    }
                }
                if (n == 1) ans += h[0] * (h[0] + 1) / 2;
                Console.WriteLine(ans);
                t--;
            }
        }
    }
}