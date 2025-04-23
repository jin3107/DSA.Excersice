using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nsBinarySearchTree
{
    public class Node
    {
        public int key;
        public Node left;
        public Node right;

        public Node()
        {
            left = null;
            right = null;
        }

        public Node(int Key)
        {
            key = Key;
            left = null;
            right = null;
        }
    }
}
