using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_tr58
{
    public class Node
    {
        public int Key;
        public Node Left;
        public Node Right;

        public Node()
        {
            Left = null;
            Right = null;
        }

        public Node(int key)
        {
            Key = key;
        }
    }
}
