using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DataStructure
{
    public class UnionFind<T>
    {
        private Dictionary<T, Node> _nodes;
        public int GetGroupSize()
        {
            var parent = new List<Node>();
            foreach (var n in _nodes)
            {
                if (!parent.Contains(n.Value._parent))
                {
                    parent.Add(n.Value._parent);
                }
            }
            return parent.Count();
        }
        public List<Node> GetParents()
        {
            var parent = new List<Node>();
            foreach (var n in _nodes)
            {
                if (!parent.Contains(n.Value._parent))
                {
                    parent.Add(n.Value._parent);
                }
            }
            return parent;
        }
        public long GetSize()
        {
            var parent = new List<Node>();
            long cnt = 0;
            foreach (var n in _nodes)
            {
                if (!parent.Contains(n.Value._parent))
                {
                    parent.Add(n.Value._parent);
                    cnt += n.Value.Size - 1;
                }
            }
            return cnt;
        }
        public UnionFind(IEnumerable<T> items = null)
        {
            _nodes = new Dictionary<T, Node>();
            if (items != null) foreach (var item in items) Add(item);
        }
        public UnionFind<T> Add(T item)
        {
            _nodes[item] = new Node(item);
            return this;
        }
        public UnionFind<T> Unite(T x, T y)
        {
            Node.Unite(_nodes[x], _nodes[y]);
            return this;
        }
        public bool IsSame(T x, T y)
            => _nodes[x].Find() == _nodes[y].Find();
        public long Size(T x)
            => _nodes[x].Size;
        public bool Contains(T item)
        {
            if (_nodes.ContainsKey(item))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public class Node
        {
            private long _size;
            private long _rank;
            public Node _parent;
            public long Size => Find()._size;
            public Node(T item)
            {
                _rank = 0;
                _size = 1;
                _parent = this;
            }
            public Node Find()
            {
                if (_parent == this) return this;
                Node parent = _parent.Find();
                _parent = parent;
                return parent;
            }
            public static bool Unite(Node x, Node y)
            {
                var rootX = x.Find();
                var rootY = y.Find();
                if (rootX == rootY) return false;
                if (rootX._rank < rootY._rank)
                {
                    rootX._parent = rootY;
                    rootY._rank = Math.Max(rootX._rank + 1, rootY._rank);
                    rootY._size = rootX._size + rootY._size;
                }
                else
                {
                    rootY._parent = rootX;
                    rootX._rank = Math.Max(rootY._rank + 1, rootX._rank);
                    rootX._size = rootX._size + rootY._size;
                }
                return true;
            }
        }
    }

}