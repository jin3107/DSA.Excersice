using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree_String
{
    public class Node
    {
        public string Value;
        public Node Left;
        public Node Right;

        public Node()
        {
            Left = null;
            Right = null;
        }

        public Node(string value)
        {
            Value = value;
        }
    }
}
