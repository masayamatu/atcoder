using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DataStructure
{
    public class Kruskal
    {
        public int N { get; }
        public PriorityQueue<kEdge> edges;
        public List<kEdge> minEdges;
        public UnionFind<int> trees;
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public Kruskal(int N)
        {
            this.N = N;
            edges = new PriorityQueue<kEdge>(N * 1000, Comparer<kEdge>.Create((a, b) => b.CompareTo(a)));
            minEdges = new List<kEdge>();
            var dataSet = new int[N];
            for (int i = 0; i < N; i++)
            {
                dataSet[i] = i;
            }
            trees = new UnionFind<int>(dataSet);
        }
        public long GetMinSpanCost()
        {
            long minSpanCost = 0;
            foreach (var edge in edges.GetAllElements())
            {
                if (trees.Contains(edge.from) && trees.Contains(edge.to) && !trees.IsSame(edge.from, edge.to))
                {
                    minSpanCost += edge.cost;
                    trees.Unite(edge.from, edge.to);
                    minEdges.Add(new kEdge(edge.from, edge.to, edge.cost));
                }
            }
            return minSpanCost;
        }
        public void Add(int from, int to, long cost)
        {
            kEdge ke = new kEdge(from, to, cost);
            edges.Push(ke);
        }

    }
    public struct kEdge : IComparable<kEdge>
    {
        public int from;
        public int to;
        public long cost;
        public kEdge(int from, int to, long cost)
        {
            this.from = from;
            this.to = to;
            this.cost = cost;
        }
        public int CompareTo(kEdge other) => cost.CompareTo(other.cost);
    }
}