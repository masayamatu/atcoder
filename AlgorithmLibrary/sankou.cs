using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using static System.Math;
using static Output;
using static Consts;
 
 
class Program
{
    /*static void Main(string[] args)
    {
        var CP = new CP();
        CP.Solve();
    }+*/
}
public class CP
{
 
    Input cin = new Input();
    public void Solve()
    {
        //ここから
        var n = cin.Int;
        var m = cin.Int;
        if (n == 1 && m == 0) { Put(1, 2); return; }
        if (m < 0 || m == n || m == n - 1) { Put(-1); return; }
 
        Put(1, 2 * m + 4);
        for (int i = 0; i <= m; ++i)
        {
            Put(2 * (i + 1), 2 * (i + 1) + 1);
        }
 
        for (int i = 0; i < n - m - 2; ++i)
        {
            Put(2 * m + 4 + 2 * i + 1, 2 * m + 4 + 2 * i + 2);
        }
 
        //ここまで
    }
 
 
 
 
}
 
 
 
public static class Consts
{
    //1  << 29
    //1L << 60
    //1000000007
    //998244353
    public const long INF = 1 << 60;
    public const int MOD = 1000000007;
}
 
#region I/O
public static class Output
{
 
    public static void Put(string a) => Console.WriteLine(a);
    public static void Put(params object[] i) => Put(string.Join(" ", i));
    public static void Put<T>(IEnumerable<T> a) => Put(string.Join(" ", a));
    public static void PutV<T>(IEnumerable<T> a) { foreach (var z in a) Put(z); }
    public static void YN(bool i) { if (i) Put("Yes"); else Put("No"); }
}
public class Input
{
    public static string Str => Console.ReadLine();
    public static bool IsTypeEqual<T, U>() => typeof(T).Equals(typeof(U));
    public static T ConvertType<T, U>(U a) => (T)Convert.ChangeType(a, typeof(T));
    public static T Cast<T>(string s)
    {
        if (IsTypeEqual<T, int>()) return ConvertType<T, int>(int.Parse(s));
        else if (IsTypeEqual<T, long>()) return ConvertType<T, long>(long.Parse(s));
        else if (IsTypeEqual<T, double>()) return ConvertType<T, double>(double.Parse(s));
        else if (IsTypeEqual<T, char>()) return ConvertType<T, char>(char.Parse(s));
        else if (IsTypeEqual<T, BigInteger>()) return ConvertType<T, BigInteger>(BigInteger.Parse(s));
        else if (IsTypeEqual<T, decimal>()) return ConvertType<T, decimal>(decimal.Parse(s));
        else return ConvertType<T, string>(s);
    }
    public static T[] Castarr<T>(string[] s)
    {
 
        var ret = new T[s.Length];
        int i = 0;
        if (IsTypeEqual<T, char>())
        {
            var list = new List<T>();
            foreach (var t in s)
            {
                foreach (var u in t)
                {
                    list.Add(ConvertType<T, char>(char.Parse(u.ToString())));
                }
            }
            return list.ToArray();
        }
        foreach (var t in s)
        {
            if (IsTypeEqual<T, int>()) ret[i++] = ConvertType<T, int>(int.Parse(t));
            else if (IsTypeEqual<T, long>()) ret[i++] = ConvertType<T, long>(long.Parse(t));
            else if (IsTypeEqual<T, double>()) ret[i++] = ConvertType<T, double>(double.Parse(t));
            else if (IsTypeEqual<T, BigInteger>()) ret[i++] = ConvertType<T, BigInteger>(BigInteger.Parse(t));
            else ret[i++] = ConvertType<T, string>(t);
        }
        return ret;
    }
    Queue<string> q = new Queue<string>();
    void next() { var ss = Str.Split(' '); foreach (var item in ss) q.Enqueue(item); }
    public T cin<T>() { if (!q.Any()) next(); return Cast<T>(q.Dequeue()); }
    public T[] cinarr<T>() { return Castarr<T>(Str.Split(' ')); }
    public T[] cinarr<T>(int n) { var ret = new T[n]; for (int i = 0; i < n; ++i) ret[i] = cin<T>(); return ret; }
    public int Int => cin<int>();
    public long Long => cin<long>();
    public double Double => cin<double>();
    public char Char => cin<char>();
    public string String => cin<string>();
    public BigInteger BI => cin<BigInteger>();
    public int[] Intarr => cinarr<int>();
    public long[] Longarr => cinarr<long>();
    public double[] Doublearr => cinarr<double>();
    public char[] Chararr => cinarr<char>();
    public string[] Stringarr => cinarr<string>();
    public BigInteger[] BIarr => cinarr<BigInteger>();
    public void cin<T>(out T t) { t = cin<T>(); }
    public void mul<T, U>(out T t, out U u) { t = cin<T>(); u = cin<U>(); }
    public void mul<T, U, V>(out T t, out U u, out V v) { t = cin<T>(); u = cin<U>(); v = cin<V>(); }
    public void mul<T, U, V, W>(out T t, out U u, out V v, out W w) { t = cin<T>(); u = cin<U>(); v = cin<V>(); w = cin<W>(); }
    public void mul<T, U, V, W, X>(out T t, out U u, out V v, out W w, out X x) { t = cin<T>(); u = cin<U>(); v = cin<V>(); w = cin<W>(); x = cin<X>(); }
    public void mul<T, U, V, W, X, Y>(out T t, out U u, out V v, out W w, out X x, out Y y) { t = cin<T>(); u = cin<U>(); v = cin<V>(); w = cin<W>(); x = cin<X>(); y = cin<Y>(); }
    public void mul<T, U, V, W, X, Y, Z>(out T t, out U u, out V v, out W w, out X x, out Y y, out Z z) { t = cin<T>(); u = cin<U>(); v = cin<V>(); w = cin<W>(); x = cin<X>(); y = cin<Y>(); z = cin<Z>(); }
}
 
#endregion