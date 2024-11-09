using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRUCache
{
    internal class LRUCache<Tk, Tv>
    {
        private readonly int _capacity;
        private readonly Dictionary<Tk, Node<Tk,Tv>> _cache;
        private readonly Node<Tk,Tv> _head;
        private readonly Node<Tk,Tv> _tail;

        public LRUCache(int capacity)
        {
            _capacity = capacity;
            _cache = new Dictionary<Tk, Node<Tk, Tv>>(capacity);

            _head = new Node<Tk, Tv>(default, default);
            _tail = new Node<Tk, Tv> (default, default);

            _head.Next = _tail;
            _tail.Prev = _head;
        }

        public Tv Get(Tk key)
        {
            if(!_cache.TryGetValue(key, out var node))
            {
                return default;
            }
            MoveToHead(node);
            return node.Value;
        }

        public void Put(Tk key, Tv value)
        {
            if(_cache.TryGetValue(key, out var node))
            {
                node.Value = value;
                MoveToHead(node);
            }
            else
            {
                var newNode = new Node<Tk, Tv>(key, value);
                AddToHead(newNode);
                _cache[key] = newNode;

                if(_cache.Count > _capacity)
                {
                    var removedNode = RemoveFromTail();
                    _cache.Remove(removedNode.Key);
                }
            }
        }

        private void AddToHead(Node<Tk, Tv> node)
        {
            node.Prev = _head;
            node.Next = _head.Next;
            _head.Next.Prev = node;
            _head.Next = node;
        }

        private void RemoveNode(Node<Tk, Tv> node)
        {
            var PrevNode = node.Prev;
            var NextNode = node.Next;
            PrevNode.Next = NextNode;
            NextNode.Prev = PrevNode;
        }

        private void MoveToHead(Node<Tk,Tv> node)
        {
            RemoveNode(node);
            AddToHead(node);
        }

        private Node<Tk, Tv> RemoveFromTail()
        {
            var node = _tail.Prev;
            RemoveNode(node);
            return node;
        }
    }
}
