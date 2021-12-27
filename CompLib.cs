using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructure{

    public static class CompLib{
        //順列全探索アルゴリズム
        public static IEnumerable<T[]> next_permutation<T>(IEnumerable<T> indata)
        {
            if (indata.Count() == 1) yield return new T[] { indata.First() };
            foreach (var i in indata)
            {
                var used = new T[] { i };
                var unused = indata.Except(used);
                foreach (var t in next_permutation(unused))
                    yield return used.Concat(t).ToArray();
            }
        }
    }
}

 
