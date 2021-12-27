using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructure
{
    public class Dijkstra
    {
        public int N {get;}
        private List<Edge>[] _graph;
        public Dijkstra(int N)
        {
            this.N = N;
            _graph = new List<Edge>[N];
            for(int i = 0; i < N; i++)
            {
                _graph[i] = new List<Edge>();
            }
        }
        public void Add(int a, int b, long cost)
            => _graph[a].Add(new Edge(b, cost));
        public long[] GetMinCost(int now)
        {
            var cost = new long[N];
            for(int i = 0; i < N; i++)
            {
                cost[i] = long.MaxValue;
            }
            cost[now] = 0;
            var pq = new PriorityQueue<Vertex>(N * 10, Comparer<Vertex>.Create((a, b) => b.CompareTo(a)));
            pq.Push(new Vertex(now, 0));
            while(pq.Count != 0)
            {
                var v = pq.Pop();
                if(v.cost != cost[v.index]) continue;
                foreach(var e in _graph[v.index])
                {
                    if(v.cost + e.cost < cost[e.to] )
                    {
                        cost[e.to] = v.cost + e.cost;
                        pq.Push(new Vertex(e.to, cost[e.to]));
                    }
                }
            }
            return cost;
        }
    }
    //接続先とコストを記録
    public struct Edge : IComparable<Edge>
    {
        public int to;
        public long cost;
        public Edge(int to, long cost)
        {
            this.to = to;
            this.cost = cost;
        }
        public int CompareTo(Edge other) => cost.CompareTo(other.cost);
    }
    //頂点番号と頂点までのコストを保持
    public struct Vertex : IComparable<Vertex>
    {
        public int index;
        public long cost;
        public Vertex(int index, long cost)
        {
            this.index = index;
            this.cost = cost;
        }
        public int CompareTo(Vertex other) => cost.CompareTo(other.cost);

    }
}