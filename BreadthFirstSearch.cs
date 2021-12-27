using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DataStructure
{
    public class BreadthFirstSearch<T>
    {
        private Dictionary<T, Node> _graph;
        private Dictionary<T, bool> _memo;
        private T _memoStart;
        public BreadthFirstSearch(IEnumerable<T> V)
        {
            _graph = new Dictionary<T, Node>();
            _memo = new Dictionary<T, bool>();
            foreach(var v in V)
            {
                _graph[v] = new Node();
            }
        }
        public BreadthFirstSearch<T> Add(T from, T to)
        {
            _memo = new Dictionary<T, bool>();
            _memoStart = default(T);
            _graph[from].Add(to);
            return this;
        }
        public bool IsExist(T start, T target)
        {
            if(Equals(_memoStart, start) && _memo.ContainsKey(target)) return _memo[target];
             foreach(var node in _graph) node.Value.IsSeen = false;
             var q = new Queue<T>();
             q.Enqueue(start);
             _graph[start].IsSeen = true;
             while(q.Count != 0)
             {
                 T now = q.Dequeue();
                 foreach(var v in _graph[now].To)
                 {
                     if(!_graph[v].IsSeen)
                     {
                         q.Enqueue(v);
                         _graph[v].IsSeen = true;
                     }
                 }
             }
             _memo = _graph.ToDictionary(graph => graph.Key, graph => graph.Value.IsSeen);
            _memoStart = start;
            return _graph[target].IsSeen;
        }
        public class Node
        {
        public List<T> To{get; private set;}
        public bool IsSeen{get; set;}
        public Node()
        {
            To = new List<T>();
            IsSeen = false;
        }
        public void Add(T item)
            => To.Add(item);
        }
    }
}