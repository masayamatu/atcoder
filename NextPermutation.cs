using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructure
{
    public class NextPermutation
    {
        public static void Swap<T>(ref T x, ref T y) { T tmp = x; x = y; y = tmp; }
 
        public static bool Next_Permutation<T>(T[] array, int index, int length, Comparison<T> comp)
        {
            if (length <= 1) return false;
            for (int i = length - 1; i > 0; i--)
            {
                int k = i - 1;
                if (comp(array[k], array[i]) < 0)
                {
                    int j = Array.FindLastIndex(array, delegate (T x) { return comp(array[k], x) < 0; });
                    Swap(ref array[k], ref array[j]);
                    Array.Reverse(array, i, length - i);
                    return true;
                }
            }
            Array.Reverse(array, index, length);
            return false;
        }
 
        public static bool Next_Permutation<T>(T[] array) where T : IComparable
        {
            return Next_Permutation(array, 0, array.Length, Comparer<T>.Default.Compare);
        }
    }
}