using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursovSAOD
{
    class Node
    {
        private StaticList _shop;
        private Node previous;
        private Node next;

        public StaticList Shop { get { return _shop; } set { _shop = value; } }
        public Node Previous { get { return previous; } set { previous = value; } }
        public Node Next { get { return next; } set { next = value; } }

        public Node(StaticList shop)
        {
            Shop = shop;
        }
        ~Node() {
            Shop.Dispose_();
            Previous = null;
            Next = null;
        }
    }
}
