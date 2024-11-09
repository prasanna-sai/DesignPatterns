using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRUCache
{
    internal class Node<Tk, Tv>
    {
        public Tk Key { get; }
        public Tv Value { get; set; }

        public Node<Tk, Tv> Prev { get; set; }
        public Node<Tk, Tv> Next { get; set; }

        public Node(Tk key, Tv value)
        {
            Key = key;
            Value = value;
        }
    }
}
