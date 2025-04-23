using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9_tr49
{
    public class CQueue
    {
        private ArrayList list;

        public CQueue()
        {
            list = new ArrayList();
        }

        public void Enqueue(object item)
        {
            list.Add(item);
        }

        public object Dequeue()
        {
            object item = list[0];
            list.RemoveAt(0);
            return item;
        }

        public object Peek()
        {
            return list[0];
        }

        public bool IsEmpty()
        {
            return list.Count == 0;
        }

        public int Count
        {
            get { return list.Count; }
        }

        public void Clear()
        {
            list.Clear();
        }
    }
}
