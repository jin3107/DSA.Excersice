using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nsCQueue
{
    public class Cqueue
    {
        private ArrayList list;

        public Cqueue()
        {
            list = new ArrayList();
        }

        public int Count
        {
            get { return list.Count; }
        }

        public void Enqueue(Object item)
        {
            list.Add(item);
        }

        public Object Dequeue()
        {
            Object obj = list[0];
            list.RemoveAt(0);
            return obj;
        }
    }
}
