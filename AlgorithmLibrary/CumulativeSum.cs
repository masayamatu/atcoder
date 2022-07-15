using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DataStructure
{
    public class CumulativeSum
    {
        public long[] Array{ get; }
        public CumulativeSum(IReadOnlyList<int> array) : this(array.Select(t => (long)t).ToArray()){}
        public CumulativeSum(IReadOnlyList<long> array)
        {
            var length = array.Count;
            Array = new long[length + 1];
            for(int i = 0; i < length; i++)
            {
                Array[i +  1] = array[i] + Array[i];
            }
        }
        public long GetSum(int left, int right)
        {
            if(left >= right) return 0;
            return Array[right] - Array[left];
        }
    }
    
}