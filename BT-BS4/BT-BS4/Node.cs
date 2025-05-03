using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_BS4
{
    public class Node
    {
        public object Value;
        public Node Next;

        public Node()
        { 
            Value = null;
            Next = null;
        }

        public Node(object val)
        {
            Value = val;
            Next = null;
        }
    }
}
