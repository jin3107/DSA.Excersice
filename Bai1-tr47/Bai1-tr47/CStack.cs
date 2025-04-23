using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_tr47
{
    public class CStack
    {
        private int topIndex;
        private ArrayList list;

        public CStack()
        {
            topIndex = -1;
            list = new ArrayList();
        }

        public void Push(object item)
        {
            list.Add(item);
            topIndex++;
        }

        public object Pop()
        {
            object obj = list[topIndex];
            list.RemoveAt(topIndex);
            topIndex--;
            return obj;
        }

        public object Peek()
        {
            return list[topIndex];
        }

        public int Count
        {
            get { return list.Count; }
        }

        public void Clear()
        {
            list.Clear();
            topIndex = -1;
        }
    }
}
